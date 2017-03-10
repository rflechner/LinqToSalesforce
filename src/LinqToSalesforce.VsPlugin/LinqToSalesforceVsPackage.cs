//------------------------------------------------------------------------------
// <copyright file="LinqToSalesforceVsPackage.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System.ComponentModel.Design;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.Win32;

namespace LinqToSalesforce.VsPlugin
{
    [ProvideXmlEditorChooserDesignerView("SFDiagram", "sfdiagram", LogicalViewID.Designer, 0x60,
    DesignerLogicalViewEditor = typeof(EditorFactory),
    Namespace = "http://schemas.microsoft.com/developer/vstemplate/2005",
    MatchExtensionAndNamespace = false)]
    // And which type of files we want to handle
    [ProvideEditorExtension(typeof(EditorFactory), EditorFactory.Extension, 0x40, NameResourceID = 106)]
    // We register that our editor supports LOGVIEWID_Designer logical view
    [ProvideEditorLogicalView(typeof(EditorFactory), LogicalViewID.Designer)]

    // We register the XML Editor ("{FA3CD31E-987B-443A-9B81-186104E8DAC1}") as an EditorFactoryNotify
    // object to handle our ".vstemplate" file extension for the following projects:
    // Microsoft Visual Basic Project
    [EditorFactoryNotifyForProject("{F184B08F-C81C-45F6-A57F-5ABD9991F28F}", EditorFactory.Extension, GuidList.GuidXmlChooserEditorFactory)]
    // Microsoft Visual C# Project
    [EditorFactoryNotifyForProject("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}", EditorFactory.Extension, GuidList.GuidXmlChooserEditorFactory)]
    [PackageRegistration(UseManagedResourcesOnly = true)]
    [InstalledProductRegistration("#110", "#112", "1.0", IconResourceID = 400)] // Info on this package for Help/About
    [Guid(LinqToSalesforceVsPackage.PackageGuidString)]
    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "pkgdef, VS and vsixmanifest are valid VS terms")]
    [ProvideMenuResource("Menus.ctmenu", 1)]
    public sealed class LinqToSalesforceVsPackage : Package
    {
        /// <summary>
        /// LinqToSalesforceVsPackage GUID string.
        /// </summary>
        public const string PackageGuidString = "f8c5ff2d-41c3-4427-aad7-38d7de67acf6";

        /// <summary>
        /// Initializes a new instance of the <see cref="LinqToSalesforceVsPackage"/> class.
        /// </summary>
        public LinqToSalesforceVsPackage()
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
            base.Initialize();
            LinqToSalesforce.VsPlugin.Command1.Initialize(this);
            base.RegisterEditorFactory(new EditorFactory(this));
        }

        #endregion
    }
}
