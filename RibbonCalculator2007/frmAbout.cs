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

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ribbonPanel2_Click(object sender, EventArgs e)
        {
            //Nothing to see here
            a++;
            if (a == (1 + 1 + 1))
            {
                Form b = new Form();
                b.BackgroundImage = Properties.Resources._03WQjoBe;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.Show();
            }
        }
        int a = 0;
    }
}
