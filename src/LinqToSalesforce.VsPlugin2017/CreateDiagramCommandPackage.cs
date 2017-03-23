//------------------------------------------------------------------------------
// <copyright file="CreateDiagramCommandPackage.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using LinqToSalesforce.VsPlugin2017.Ui;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Win32;

namespace LinqToSalesforce.VsPlugin2017
{
    //[ProvideXmlEditorChooserDesignerView("SFDiagram", "sfdiagram", LogicalViewID.Designer, 1000,
    //DesignerLogicalViewEditor = typeof(SalesforceEntity),
    //Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005",
    //MatchExtensionAndNamespace = false)]
    
    //[ProvideEditorExtension(typeof(SalesforceEntity), SalesforceEntity.Extension, 1000, NameResourceID = 106)]
    [ProvideEditorExtension(CreateDiagramCommandPackage.PackageGuidString, SalesforceEntity.Extension, 97)]
    [ProvideEditorLogicalView(typeof(SalesforceEntity), LogicalViewID.Designer)]

    // We register the XML Editor ("{FA3CD31E-987B-443A-9B81-186104E8DAC1}") as an EditorFactoryNotify
    // object to handle our ".vstemplate" file extension for the following projects:
    // Microsoft Visual Basic Project
    [EditorFactoryNotifyForProject("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}", SalesforceEntity.Extension, GuidList.GuidXmlChooserEditorFactory)]
    // Microsoft Visual C# Project
    [EditorFactoryNotifyForProject("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}", SalesforceEntity.Extension, GuidList.GuidXmlChooserEditorFactory)]

    //[ProvideXmlEditorChooserDesignerView("LinqToSalesforce",
    //    ".sfdiagram",
    //    LogicalViewID.Designer,
    //    1,
    //    Namespace = "https://rflechner.github.io/LinqToSalesforce",
    //    MatchExtensionAndNamespace = true,
    //    CodeLogicalViewEditor = typeof(SalesforceEntity),
    //    DesignerLogicalViewEditor = typeof(SalesforceEntity),
    //    DebuggingLogicalViewEditor = typeof(SalesforceEntity),
    //    TextLogicalViewEditor = typeof(SalesforceEntity))]
    [ProvideEditorExtension(typeof(SalesforceEntity), ".sfdiagram", 100, NameResourceID = 113, DefaultName = "Linq to Salesforce")]
    [ProvideEditorFactory(typeof(SalesforceEntity), 113, TrustLevel = __VSEDITORTRUSTLEVEL.ETL_AlwaysTrusted)]

    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [ProvideMenuResource("Menus.ctmenu", 1)]
    [Guid(CreateDiagramCommandPackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    public sealed class CreateDiagramCommandPackage : Package
    {
        /// <summary>
        /// CreateDiagramCommandPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "791d6061-abe2-40a8-9b07-f43992ce0c35";

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiagramCommand"/> class.
        /// </summary>
        public CreateDiagramCommandPackage()
        {
            // Inside this method you can place any initialization code that does not require
            // any Visual Studio service because at this point the package object is created but
            // not sited yet inside Visual Studio environment. The place to do all the other
            // initialization is the Initialize method.
        }

        #region Package Members

        /// <summary>
        /// Initialization of the package; this method is called right after the package is sited, so this is the place
        /// where you can put all the initialization code that rely on services provided by VisualStudio.
        /// </summary>
        protected override void Initialize()
        {
            CreateDiagramCommand.Initialize(this);
            RegisterEditorFactory(new SalesforceEntity(this));

            base.Initialize();
        }

        #endregion
    }
}
