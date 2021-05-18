using System;
using System.Windows.Forms;

namespace RibbonCalculator2007
{
    public partial class frmAbout : RibbonForm
    {
        public frmAbout()
        {
            InitializeComponent();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;

            ribbon1.ThemeColor = (RibbonTheme)Properties.Settings.Default.Theme;
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
