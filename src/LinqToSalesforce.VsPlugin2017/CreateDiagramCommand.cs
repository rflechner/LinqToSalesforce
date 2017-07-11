//------------------------------------------------------------------------------
// <copyright file="CreateDiagramCommand.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO;
using System.Linq;
using LinqToSalesforce.VsPlugin2017.Helpers;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace LinqToSalesforce.VsPlugin2017
{
    /// <summary>
    /// Command handler
    /// </summary>
    internal sealed class CreateDiagramCommand
    {
        /// <summary>
        /// Command ID.
        /// </summary>
        public const int CommandId = 0x0100;

        /// <summary>
        /// Command menu group (command set GUID).
        /// </summary>
        public static readonly Guid CommandSet = new Guid("262c34d1-0b95-46ad-9556-267a991fb531");

        /// <summary>
        /// VS Package that provides this command, not null.
        /// </summary>
        private readonly Package package;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDiagramCommand"/> class.
        /// Adds our command handlers for menu (commands must exist in the command table file)
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        private CreateDiagramCommand(Package package)
        {
            if (package == null)
            {
                throw new ArgumentNullException("package");
            }

            this.package = package;

            OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
            if (commandService != null)
            {
                var menuCommandID = new CommandID(CommandSet, CommandId);
                var menuItem = new MenuCommand(this.MenuItemCallback, menuCommandID);
                commandService.AddCommand(menuItem);
            }
        }

        /// <summary>
        /// Gets the instance of the command.
        /// </summary>
        public static CreateDiagramCommand Instance
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the service provider from the owner package.
        /// </summary>
        private IServiceProvider ServiceProvider
        {
            get
            {
                return this.package;
            }
        }

        /// <summary>
        /// Initializes the singleton instance of the command.
        /// </summary>
        /// <param name="package">Owner package, not null.</param>
        public static void Initialize(Package package)
        {
            Instance = new CreateDiagramCommand(package);
        }

        /// <summary>
        /// This function is the callback used to execute the command when the menu item is clicked.
        /// See the constructor to see how the menu item is associated with this function using
        /// OleMenuCommandService service and MenuCommand class.
        /// </summary>
        /// <param name="sender">Event sender.</param>
        /// <param name="e">Event args.</param>
        private void MenuItemCallback(object sender, EventArgs e)
        {
            //string message = string.Format(CultureInfo.CurrentCulture, "Inside {0}.MenuItemCallback()", this.GetType().FullName);
            //string title = "Create Salesforce linq entities";
            //VsShellUtilities.ShowMessageBox(
            //    this.IocServiceProvider,
            //    message,
            //    title,
            //    OLEMSGICON.OLEMSGICON_INFO,
            //    OLEMSGBUTTON.OLEMSGBUTTON_OK,
            //    OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
            var dte = (EnvDTE.DTE)ServiceProvider.GetService(typeof(EnvDTE.DTE));

            var uiShell = (IVsUIShell)ServiceProvider.GetService(typeof(SVsUIShell));
            var reply = VsShellUtilities.PromptYesNo("Do you want to add a Salesforce datacontext to the current project ?",
                "LinqToSalesForce", OLEMSGICON.OLEMSGICON_QUERY, uiShell);
            if (reply)
            {
                var project = dte.GetCurrentProject();
                if (!project.GetProjectFiles().Any(f => f.FileNames[0].EndsWith(SalesforceEntity.Extension)))
                {
                    var directory = Path.GetDirectoryName(project.FileName);
                    var filename = Path.Combine(directory, "SoqlDataContext.sfdiagram");
                    File.WriteAllText(filename, String.Empty);
                    project.ProjectItems.AddFromFile(filename);
                }
                else
                {
                    VsShellUtilities.ShowMessageBox(
                        ServiceProvider,
                        $"Another {SalesforceEntity.Extension} detected",
                        "Invalid operation",
                        OLEMSGICON.OLEMSGICON_INFO,
                        OLEMSGBUTTON.OLEMSGBUTTON_OK,
                        OLEMSGDEFBUTTON.OLEMSGDEFBUTTON_FIRST);
                }
            }
        }
    }
}
