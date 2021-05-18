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
    public partial class frmMain : RibbonForm
    {
        string Operand1;
        string Operand2;

        string Input;
        string CurrentOperation = "";
        bool InitalZero = true;
        public frmMain()
        {
            InitializeComponent();
            //set theme
            ribbon.ThemeColor = (RibbonTheme)Properties.Settings.Default.Theme;
        }
        #region Number buttons
        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("1");
        }
        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("2");
        }

        private void ribbonButton3_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("3");
        }

        private void ribbonButton4_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("4");
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("5");
        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("6");
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("7");
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("8");
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("0");
        }
        #endregion
        #region Operations
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            SetOperation("-");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetOperation("➗");
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            SetOperation("×");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperation("+");
        }
        #endregion
        #region Other tab
        private void btnFindout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Input))
            {
                MessageBox.Show("Please input a second number");
                return;
            }
            if (string.IsNullOrEmpty(CurrentOperation))
            {
                MessageBox.Show("Please enter an operation");
                return;
            }
            Operand2 = Input;
            Input = "";

            //Check if user has not inputed any numbers
            if (string.IsNullOrEmpty(Operand1))
            {
                MessageBox.Show("Please input a number first!");
                return;
            }

            var num1 = double.Parse(Operand1);
            var num2 = double.Parse(Operand2);

            if (CurrentOperation == "+")
            {
                var result = num1 + num2;
                Input = "";
                Operand1 = result.ToString(); //This is so adding the result with another number would work
                Operand2 = "";
                CurrentOperation = "";
                textBox1.Text = result.ToString();
            }
            else if (CurrentOperation == "-")
            {
                var result = num1 - num2;
                Input = "";
                Operand1 = result.ToString(); //This is so adding the result with another number would work
                Operand2 = "";
                CurrentOperation = "";
                textBox1.Text = result.ToString();
            }
            else if (CurrentOperation == "➗")
            {
                if (num2 == 0)
                {
                    HandleError("Cannot divide by zero.");
                    Clear();
                    return;
                }    
                var result = num1 / num2;
                Input = "";
                Operand1 = result.ToString(); //This is so adding the result with another number would work
                Operand2 = "";
                CurrentOperation = "";
                textBox1.Text = result.ToString();
            }
            else if (CurrentOperation == "×")
            {
                var result = num1 * num2;
                Input = "";
                Operand1 = result.ToString(); //This is so adding the result with another number would work
                Operand2 = "";
                CurrentOperation = "";
                textBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Unknown operation.");
                return;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion
        #region Helper functions
        private void SetOperation(string Operation)
        {
            if (!string.IsNullOrEmpty(CurrentOperation))
            {
                HandleError("More than 1 operations not supported!");
                return;
            }

            CurrentOperation = Operation;
            if (string.IsNullOrEmpty(Operand1))
            {
                Operand1 = Input;
                Input = "";
                textBox1.Text += Operation;
                return;
            }
            else if (string.IsNullOrEmpty(Operand2))
            {
                Operand2 = Input;
                Input = "";
                textBox1.Text += Operation;
                return;
            }
            throw new NotImplementedException();
        }
        private void AddNumberToTextBox(string numb)
        {
            if (InitalZero)
            {
                textBox1.Text = "";
                InitalZero = false;
            }
            Input += numb;
            textBox1.Text += numb;
        }
        private void HandleError(string error)
        {
            MessageBox.Show(error,"Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Clear()
        {
            Input = "";
            Operand1 = ""; //This is so adding the result with another number would work
            Operand2 = "";
            CurrentOperation = "";
            textBox1.Text = "0";
            InitalZero = true;
        }
        #endregion
        #region Orb menu buttons
        private void ribbonOrbAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().ShowDialog();
        }

        private void ribbonOrbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ribbonOrbSettings_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog();
        }
        #endregion
    }
}
