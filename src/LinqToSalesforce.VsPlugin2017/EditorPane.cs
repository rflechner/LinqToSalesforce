using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using EnvDTE;
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
    {
        public EditorPane(string filename, DTE dte) : base(null)
        {
            Content = new AuthenticationControl(filename, dte);
            
        }
        
        public int FReserved1(uint dwReserved, uint message, IntPtr wParam, IntPtr lParam) => VSConstants.S_OK;

        public int FPreTranslateMessage(MSG[] pMsg) => VSConstants.S_OK;

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

        public int FDoIdle(uint grfidlef) => VSConstants.S_OK;

        public int FContinueMessageLoop(uint uReason, IntPtr pvLoopData, MSG[] pMsgPeeked) => VSConstants.S_OK;

        public int FQueryTerminate(int fPromptUser) => 1;

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

        public int OnInterveningUnitBlockingLinkedUndo() => VSConstants.E_FAIL;
    }
}