module CodeGeneration

open System
open System.Collections.Generic
open System.Linq
open System.Linq.Expressions
open System.Reflection
open System.Security.Cryptography.X509Certificates
open System.Text
open System.Net
open System.Net.Http
open Newtonsoft
open Newtonsoft.Json
open Newtonsoft.Json.Serialization
open Newtonsoft.Json.Converters
open Newtonsoft.Json.Linq
open LinqToSalesforce.Rest
open System.Data.Entity.Design.PluralizationServices
open System.Globalization

let c = CultureInfo "en-us"
let ps = PluralizationService.CreateService c

let ucFirst (s:string) =
  match s.ToCharArray() |> Seq.toList with
  | c :: t ->
    let f = Char.ToUpper c
    [f] @ t |> List.toArray |> String
  | _ -> s

let fixName (name:string) = 
  let parts = 
    name.Split([|' ';'_';'-'|], StringSplitOptions.RemoveEmptyEntries)
      |> Array.filter (fun p -> p <> "c")
      |> Array.map ucFirst
  String.Join("", parts)

let removeNonLetterDigit (s:string) =
  s.ToCharArray()
  |> Array.filter Char.IsLetterOrDigit
  |> String
let generateCsharp (tables:TableDesc list) (``namespace``:string) =
  let b = StringBuilder()
  let add (text:string) =
    text |> b.Append |> ignore
  let writeIndent i =
    for _ in 0 .. (i-1) do
      add "    "
  let addLine indent text =
    writeIndent indent
    text |> b.AppendLine |> ignore

  let generatePickTypeConverter (name:string)  (indent:int) =
    let converterName = sprintf "Pick%sConverter" name
    let typeName = sprintf "Pick%s" name
    let tmpl = """public class {name} : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) 
            => sourceType == typeof(string);

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            => destinationType == typeof(string);

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            var o = ({type})value;
            return destinationType == typeof(string) ? o.Value : base.ConvertTo(context, culture, value, destinationType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is string)
                return new {type} {Value = (string)value};
            return base.ConvertFrom(context, culture, value);
        }
    }"""
    let c = tmpl.Replace("{type}", typeName).Replace("{name}", converterName)
    addLine indent c


  let generatePickList (name:string) (values:string list) (indent:int) =
    let typeName = sprintf "Pick%s" name
    generatePickTypeConverter name indent
    sprintf "[TypeConverter(typeof(%sConverter))]" typeName |> addLine indent
    sprintf "public class %s" typeName |> addLine indent
    addLine indent "{"
    for value in values do
      let prefix = if value.FirstOrDefault() |> Char.IsDigit then '_' else ' '
      let line = sprintf """public static readonly string %c%s = "%s"; """ prefix (removeNonLetterDigit value) value
      addLine (indent+1) line
    let operators = 
      sprintf """
        public string Value { get; set; }

        public static implicit operator string(%s o)
        {
            return o.Value;
        }

        public static implicit operator %s(string s)
        {
            return new %s {Value = s};
        }

        public override string ToString()
        {
            return Value;
        }
        """ typeName typeName typeName
    addLine indent operators
    addLine 0 ""
    addLine indent "}"

  let generateTableCsharp (table:TableDesc) (indent:int) =
    sprintf """[EntityName("%s")]""" table.Name |> addLine indent
    let typeName = fixName table.Name
    sprintf "public class %s : ISalesforceEntity" typeName |> addLine indent
    addLine indent "{"
    
    let constructors =
      sprintf """[JsonConstructor]
        private %s(string hack)
        {
            trackPropertyUpdates = false;
        }

        public %s()
        {
            trackPropertyUpdates = true;
        } """ typeName typeName
    addLine indent constructors

    addLine indent """
        private IDictionary<string, object> _updatedProperties = new Dictionary<string, object>();
        public IDictionary<string, object> UpdatedProperties => _updatedProperties;
        private bool trackPropertyUpdates = false;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void TrackPropertyUpdates() => trackPropertyUpdates = true;

        protected bool SetField<T>(ref T field, T value, string serializedName, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;

            if (trackPropertyUpdates && !string.IsNullOrWhiteSpace(serializedName))
            {
              if (_updatedProperties.ContainsKey(serializedName))
                  _updatedProperties[serializedName] = value;
              else
                  _updatedProperties.Add(serializedName, value);
            }

            OnPropertyChanged(propertyName);
            return true;
        }"""

    let writeProperty typeName fieldName serializedName auto isReadonly =
      let ptypeName = fixName typeName
      add "public "; add ptypeName; add " "
      addLine 0 fieldName
      addLine (indent+1) "{"
      if not auto
      then
        addLine (indent+2) (sprintf "get { return __%s; }" fieldName)
        if not isReadonly
        then addLine (indent+2) (sprintf """set { SetField(ref __%s, value, "%s"); }""" fieldName serializedName)
      else
        addLine (indent+2) "get;set;"
      addLine (indent+1) "}"
      
    for field in table.Fields do
      let fieldName =
        match removeNonLetterDigit field.Name with
        | n when n = table.Name -> sprintf "_%s" n
        | n -> n
      let typeName =
        match field.Type with
        | Native t -> 
          if field.Nillable && t <> typeof<string> 
          then sprintf "%s?" (fixName t.FullName)
          else fixName t.FullName
        | Picklist _ -> sprintf "Pick%s%s" (fixName table.Name) (fixName field.Name)
      
      let backingField = sprintf "private %s __%s;" typeName fieldName
      addLine (indent+1) backingField
      if fieldName <> field.Name
      then
        let attr = sprintf """[JsonProperty(PropertyName = "%s")]""" field.Name
        addLine (indent+1) attr
      addLine (indent+1) (sprintf "[EntityField(%b)]" field.Nillable)
      writeIndent (indent+1)
      let shipFields = 
        table.RelationShips |> List.map (fun r -> r.Field)
      let isWrongReference = 
        field.ReferenceTo.Length > 0 && field.ReferenceTo |> List.exists(fun r -> shipFields |> List.contains r |> not)
      writeProperty typeName fieldName field.Name false field.Calculated
    
    for relation in table.RelationShips do
      if relation.RelationshipName |> String.IsNullOrWhiteSpace |> not
      then
        addLine (indent+1) "[JsonIgnore]"
        addLine (indent+1) <| sprintf """[ReferencedByField("%s")]""" relation.Field
        writeIndent (indent+1)
        let tname = sprintf "RelationShip<%s, %s>" (fixName table.Name) (fixName relation.ChildSObject)
        writeProperty tname relation.RelationshipName "" true false

    addLine indent "}"
      
  addLine 0 "using System;"
  addLine 0 "using System.Globalization;"
  addLine 0 "using System.Collections.Generic;"
  addLine 0 "using System.Runtime.Serialization;"
  addLine 0 "using Newtonsoft.Json;"
  addLine 0 "using Newtonsoft.Json.Converters;"
  addLine 0 "using LinqToSalesforce;"
  addLine 0 "using System.Runtime.CompilerServices;"
  addLine 0 "using System.ComponentModel;"
  addLine 0 "using System.Linq;"

  addLine 0 ""
  add "namespace "
  add ``namespace``
  addLine 0 "\n{"

  let enums = 
    tables
    |> Seq.collect (
        fun t ->
          t.Fields 
          |> List.choose(
              fun f -> 
                match f.Type with
                | Native _ -> None
                | Picklist values ->
                    let name = sprintf "%s%s" (fixName t.Name) (fixName f.Name)
                    Some (name, values)
              )
      ) |> List.ofSeq

  for (name, values) in enums do
    let vs = values |> List.distinct
    generatePickList name vs 1

  for table in tables do
    generateTableCsharp table 1
  
  addLine 1 "public class SalesforceDataContext : SoqlContext"
  addLine 1 "{"
  addLine 2 "public SalesforceDataContext(string instanceName, Rest.OAuth.ImpersonationParam authparams) : base(instanceName, authparams) { }"
  
  for table in tables do
    let typename = table.Name |> fixName
    let name = ps.Pluralize typename
    let line = sprintf "public IQueryable<%s> %s => GetTable<%s>();" typename name typename
    addLine 2 line

  addLine 1 "}"
  
  addLine 0 "}"

  b.AppendLine() |> ignore
  b.ToString()


