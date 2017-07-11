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
using EnvDTE;

namespace LinqToSalesforce.VsPlugin2017.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        private readonly string _filename;
        private readonly DTE _dte;

        public MainWindow(string filename, DTE dte)
        {
            _filename = filename;
            _dte = dte;
            InitializeComponent();

            mainFrame.NavigationService.Navigate(new AuthenticationControl(filename, dte));
        }


    }
}
