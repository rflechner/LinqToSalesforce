using System;

namespace LinqToSalesforce.VsPlugin2017
{
    static class GuidList
    {
        public const string GuidVsTemplateDesignerPkgString = "28d60403-f5aa-4745-9e52-ac634cbf0c5c";
        public const string GuidVsTemplateDesignerCmdSetString = "22de8a49-aa75-49f7-9180-83d225bbc303";
        public const string GuidVsTemplateDesignerEditorFactoryString = "6bf3ea12-98bb-41e2-ba01-8662f713d293";

        public static readonly Guid GuidVsTemplateDesignerCmdSet = new Guid(GuidVsTemplateDesignerCmdSetString);
        public static readonly Guid GuidVsTemplateDesignerEditorFactory = new Guid(GuidVsTemplateDesignerEditorFactoryString);

        public const string GuidXmlChooserEditorFactory = @"{32CC8DFA-2D70-49b2-94CD-22D57349B778}";
    }
}