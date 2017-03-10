using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.OLE.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TextManager.Interop;
using IOleServiceProvider = Microsoft.VisualStudio.OLE.Interop.IServiceProvider;

namespace LinqToSalesforce.VsPlugin2017
{
    [Guid(GuidList.GuidVsTemplateDesignerEditorFactoryString)]
    public sealed class SalesforceEntity : IVsEditorFactory, IDisposable
    {
        public const string Extension = ".sfdiagram";

        private CreateDiagramCommandPackage editorPackage;
        private ServiceProvider vsServiceProvider;


        public SalesforceEntity(CreateDiagramCommandPackage package)
        {
            editorPackage = package;
        }

        [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        public int CreateEditorInstance(uint grfCreateDoc, string pszMkDocument, string pszPhysicalView, IVsHierarchy pvHier,
            uint itemid, IntPtr punkDocDataExisting, out IntPtr ppunkDocView, out IntPtr ppunkDocData,
            out string pbstrEditorCaption, out Guid pguidCmdUI, out int pgrfCDW)
        {
            // Initialize to null
            ppunkDocView = IntPtr.Zero;
            ppunkDocData = IntPtr.Zero;
            pguidCmdUI = GuidList.GuidVsTemplateDesignerEditorFactory;
            pgrfCDW = 0;
            pbstrEditorCaption = null;

            // Validate inputs
            if ((grfCreateDoc & (VSConstants.CEF_OPENFILE | VSConstants.CEF_SILENT)) == 0)
            {
                return VSConstants.E_INVALIDARG;
            }

            IVsTextLines textBuffer = null;

            if (punkDocDataExisting == IntPtr.Zero)
            {
                // punkDocDataExisting is null which means the file is not yet open.
                // We need to create a new text buffer object 

                // get the ILocalRegistry interface so we can use it to
                // create the text buffer from the shell's local registry
                try
                {
                    ILocalRegistry localRegistry = (ILocalRegistry)GetService(typeof(SLocalRegistry));
                    if (localRegistry != null)
                    {
                        IntPtr ptr;
                        Guid iid = typeof(IVsTextLines).GUID;
                        Guid CLSID_VsTextBuffer = typeof(VsTextBufferClass).GUID;
                        localRegistry.CreateInstance(CLSID_VsTextBuffer, null, ref iid, 1 /*CLSCTX_INPROC_SERVER*/, out ptr);
                        try
                        {
                            textBuffer = Marshal.GetObjectForIUnknown(ptr) as IVsTextLines;
                        }
                        finally
                        {
                            Marshal.Release(ptr); // Release RefCount from CreateInstance call
                        }

                        // It is important to site the TextBuffer object
                        IObjectWithSite objWSite = (IObjectWithSite)textBuffer;
                        if (objWSite != null)
                        {
                            IOleServiceProvider oleServiceProvider = (IOleServiceProvider)GetService(typeof(IOleServiceProvider));
                            objWSite.SetSite(oleServiceProvider);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Can not get IVsCfgProviderEventsHelper" + ex.Message);
                    throw;
                }
            }
            else
            {
                // punkDocDataExisting is *not* null which means the file *is* already open. 
                // We need to verify that the open document is in fact a TextBuffer. If not
                // then we need to return the special error code VS_E_INCOMPATIBLEDOCDATA which
                // causes the user to be prompted to close the open file. If the user closes the
                // file then we will be called again with punkDocDataExisting as null

                // QI existing buffer for text lines
                textBuffer = Marshal.GetObjectForIUnknown(punkDocDataExisting) as IVsTextLines;
                if (textBuffer == null)
                {
                    return VSConstants.VS_E_INCOMPATIBLEDOCDATA;
                }
            }

            // Create the Document (editor)
            var editor = new EditorPane(editorPackage, pszMkDocument);
            ppunkDocView = Marshal.GetIUnknownForObject(editor);
            ppunkDocData = Marshal.GetIUnknownForObject(textBuffer);
            pbstrEditorCaption = "coucou";
            return VSConstants.S_OK;
        }

        public object GetService(Type serviceType)
        {
            return vsServiceProvider.GetService(serviceType);
        }

        public int Close()
        {
            return VSConstants.S_OK;
        }

        public int MapLogicalView(ref Guid rguidLogicalView, out string pbstrPhysicalView)
        {
            pbstrPhysicalView = null;    // initialize out parameter

            // we support only a single physical view
            if (VSConstants.LOGVIEWID_Primary == rguidLogicalView)
                return VSConstants.S_OK;        // primary view uses NULL as pbstrPhysicalView
            else
                return VSConstants.E_NOTIMPL;   // you must return E_NOTIMPL for any unrecognized rguidLogicalView values
        }

        public void Dispose()
        {

        }

        public int SetSite(IOleServiceProvider psp)
        {
            vsServiceProvider = new ServiceProvider(psp);
            return VSConstants.S_OK;
        }
    }
}