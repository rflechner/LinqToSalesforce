using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Microsoft.VisualStudio.TextManager.Interop;

namespace LinqToSalesforce.VsPlugin2017.Ui
{
    /// <summary>
    /// Interaction logic for AuthenticationControl.xaml
    /// </summary>
    public partial class AuthenticationControl : UserControl
    {
        public AuthenticationControl()
        {
            InitializeComponent();
        }

        private int i = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
                return;

            button.Content = $"Click {++i}";
        }
    }
}
