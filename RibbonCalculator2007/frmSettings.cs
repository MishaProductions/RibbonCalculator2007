using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrosoftCalculator2007
{
    public partial class frmSettings : RibbonForm
    {
        public frmSettings()
        {
            InitializeComponent();
            ribbon1.ThemeColor = (RibbonTheme)Properties.Settings.Default.Theme;
            int i = 0;
            foreach (var value in Enum.GetValues(typeof(RibbonTheme)))
            {
                comboBox1.Items.Add(new ComboBoxItem() { Text = value.ToString(), Tag = i});
                i++;
            }
            comboBox1.SelectedIndex = Properties.Settings.Default.Theme;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
            ribbon1.ThemeColor = (RibbonTheme)Properties.Settings.Default.Theme;

            this.Close();
        }
    }
    internal class ComboBoxItem
    {
        public string Text;
        public int Tag;

        public override string ToString()
        {
            return Text;
        }
    }
}
