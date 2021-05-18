using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrosoftCalculator2007
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
