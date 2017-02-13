using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.TextManager.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.XmlEditor;
using EnvDTE;
using LinqToSalesforce.VsPlugin.Ui;
using ISysServiceProvider = System.IServiceProvider;
using IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;
using VSStd97CmdID = Microsoft.VisualStudio.VSConstants.VSStd97CmdID;

namespace LinqToSalesforce.VsPlugin
{
    [ComVisible(true)]
    public sealed class EditorPane : WindowPane, IOleComponent, IVsDeferredDocView, IVsLinkedUndoClient
    {
        private readonly LinqToSalesforceVsPackage _package;
        private readonly string _filename;
        private readonly IVsTextLines _textBuffer;
        private AuthenticationControl _vsDesignerControl;

        public EditorPane(LinqToSalesforceVsPackage package, string filename, IVsTextLines textBuffer)
            : base(null)
        {
            _package = package;
            _filename = filename;
            _textBuffer = textBuffer;
        }

        protected override void Initialize()
        {
            base.Initialize();

            _vsDesignerControl = new AuthenticationControl(_textBuffer);
            Content = _vsDesignerControl;

            RegisterIndependentView(true);
        }

        void RegisterIndependentView(bool subscribe)
        {
            IVsTextManager textManager = (IVsTextManager)GetService(typeof(SVsTextManager));

            if (textManager != null)
            {
                if (subscribe)
                {
                    textManager.RegisterIndependentView(this, _textBuffer);
                }
                else
                {
                    textManager.UnregisterIndependentView(this, _textBuffer);
                }
            }
        }

        public int FReserved1(uint dwReserved, uint message, IntPtr wParam, IntPtr lParam)
        {
            return VSConstants.S_OK;
        }

        public int FPreTranslateMessage(MSG[] pMsg)
        {
            return VSConstants.S_OK;
        }

        public void OnEnterState(uint uStateID, int fEnter)
        {
        }

        public void OnAppActivate(int fActive, uint dwOtherThreadID)
        {
        }

        public void OnLoseActivation()
        {
        }

        public void OnActivationChange(IOleComponent pic, int fSameComponent, OLECRINFO[] pcrinfo, int fHostIsActivating,
            OLECHOSTINFO[] pchostinfo, uint dwReserved)
        {
        }

        public int FDoIdle(uint grfidlef)
        {
            if (_vsDesignerControl != null)
            {
                //_vsDesignerControl.DoIdle();
            }
            return VSConstants.S_OK;
        }

        public int FContinueMessageLoop(uint uReason, IntPtr pvLoopData, MSG[] pMsgPeeked)
        {
            return VSConstants.S_OK;
        }

        public int FQueryTerminate(int fPromptUser)
        {
            return 1;
        }

        public void Terminate()
        {

        }

        public IntPtr HwndGetWindow(uint dwWhich, uint dwReserved)
        {
            return IntPtr.Zero;
        }

        int IVsDeferredDocView.get_CmdUIGuid(out Guid pGuidCmdId)
        {
            pGuidCmdId = GuidList.GuidVsTemplateDesignerEditorFactory;
            return VSConstants.S_OK;
        }

        /// <summary>
        /// Assigns out parameter with the document view being implemented.
        /// </summary>
        /// <param name="ppUnkDocView">The parameter that receives a reference to current view.</param>
        /// <returns>S_OK if Marshal operations completed successfully.</returns>
        [EnvironmentPermission(SecurityAction.Demand)]
        int IVsDeferredDocView.get_DocView(out IntPtr ppUnkDocView)
        {
            ppUnkDocView = Marshal.GetIUnknownForObject(this);
            return VSConstants.S_OK;
        }

        public int OnInterveningUnitBlockingLinkedUndo()
        {
            return VSConstants.E_FAIL;
        }
    }
}