using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace LinqToSalesforce.VsPlugin2017.Ui
{
    public class OptionPageGrid : DialogPage
    {
        private int optionInt = 256;

        [Category("My Category")]
        [DisplayName("My Integer Option")]
        [Description("My integer option")]
        public int OptionInteger
        {
            get { return optionInt; }
            set { optionInt = value; }
        }
    }

    [Guid("92ED23A1-BFCB-4DEE-B8AC-0E6CE840BADC")]
    public class OptionPageCustom : DialogPage
    {
        private string optionValue = "alpha";
        
        public string OptionString
        {
            get { return optionValue; }
            set { optionValue = value; }
        }
    }
}
