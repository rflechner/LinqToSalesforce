using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;
using EnvDTE;
using LinqToSalesforce.VsPlugin2017.Model;
using LinqToSalesforce.VsPlugin2017.Storage;
using Microsoft.FSharp.Collections;
using Microsoft.FSharp.Control;
using Microsoft.FSharp.Core;
using Microsoft.VisualStudio.TextManager.Interop;
using Newtonsoft.Json;

namespace LinqToSalesforce.VsPlugin2017.Ui
{
    /// <summary>
    /// Interaction logic for AuthenticationControl.xaml
    /// </summary>
    public partial class AuthenticationControl : UserControl
    {
        private readonly DTE dte;
        readonly DiagramDocumentStorage documentStorage = new DiagramDocumentStorage();
        private DiagramDocument document;

        public AuthenticationControl(string filename, DTE dte)
        {
            this.dte = dte;
            Filename = filename;

            InitializeComponent();
        }
        
        public string Filename { get; }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            document = documentStorage.LoadDocument(Filename);
            if (document?.Credentials != null)
            {
                CheckCredentials();
            }
        }

        private void CheckCredentials()
        {
            Task.Factory.StartNew(async () =>
            {
                var identity = await AuthenticateAsync();
                Dispatcher.Invoke(() => DisplayTablesSelector(identity));
            });
        }

        private void DisplayTablesSelector(Rest.OAuth.Identity identity)
        {
            var tablesSelectorControl = new TablesSelectorControl(Filename, document, identity, dte);
            tablesSelectorControl.Backclicked += (sender, args) => { Content = MainGrid; };
            Content = tablesSelectorControl;
        }

        public async Task<Rest.OAuth.Identity> AuthenticateAsync()
        {
            var param = document.Credentials.ToImpersonationParam();
            var authenticateWithCredentials = Rest.OAuth.authenticateWithCredentials(param);

            return FSharpAsync.RunSynchronously(authenticateWithCredentials, FSharpOption<int>.None, FSharpOption<CancellationToken>.None);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;
            
            Rest.Config.ProductionInstance = InstanceBox.Text;
            var oauth = new Rest.OAuth.ImpersonationParam
            {
                ClientId = ClientIdBox.Text,
                ClientSecret = ClientSecretBox.Text,
                Username = UsernameBox.Text,
                Password = PasswordEntry.Password,
                SecurityToken = SecurityTokenBox.Text
            };

            document = new DiagramDocument
            {
                Credentials = Credentials.From(oauth)
            };
            document.Credentials.Instance = InstanceBox.Text;

            documentStorage.Save(document, Filename);

            CheckCredentials();
        }
    }

}
