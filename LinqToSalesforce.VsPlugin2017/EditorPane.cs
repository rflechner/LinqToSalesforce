using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using LinqToSalesforce.VsPlugin2017.Ui;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TextManager.Interop;

namespace LinqToSalesforce.VsPlugin2017
{
    [ComVisible(true)]
    public sealed class EditorPane : WindowPane, 
        IOleComponent, 
        IVsDeferredDocView, 
        IVsLinkedUndoClient

        //IOleCommandTarget,
        //IVsPersistDocData,
        //IPersistFileFormat

    {
        private readonly CreateDiagramCommandPackage _package;
        private readonly string _filename;
        private AuthenticationControl authenticationControl;
        //private UserControl1 authenticationControl;

        public EditorPane(CreateDiagramCommandPackage package, string filename) : base(null)
        {
            _package = package;
            _filename = filename;
            
            Content = authenticationControl = new AuthenticationControl();
        }

        protected override void Initialize()
        {
            base.Initialize();
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
            //if (authenticationControl != null)
            //{
            //    //authenticationControl.DoIdle();
            //}
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