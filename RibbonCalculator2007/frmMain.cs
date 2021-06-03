using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace RibbonCalculator2007
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
            try
            {
                ribbon.ThemeColor = (RibbonTheme)Properties.Settings.Default.Theme;
            }
            catch
            {

            }
        }
        #region Number buttons
        private void btn1_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddNumberToTextBox("9");
        }

        private void btn0_Click(object sender, EventArgs e)
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
            MessageBox.Show(error, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        Keys prevKey;
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Handled)
                return;
            if (e.KeyCode == Keys.Oemplus && prevKey == Keys.ShiftKey)
            {
                SetOperation("+");
            }
            else if (e.KeyCode == Keys.OemMinus && prevKey != Keys.ShiftKey)
            {
                SetOperation("-");
            }
            else if (e.KeyCode == Keys.OemQuestion && prevKey == Keys.ShiftKey)
            {
                SetOperation("➗");
            }
            else if (e.KeyCode == Keys.D8 && prevKey == Keys.ShiftKey)
            {
                SetOperation("×");
            }
            else if (e.KeyCode == Keys.D1)
            {
                AddNumberToTextBox("1");
            }
            else if (e.KeyCode == Keys.D2)
            {
                AddNumberToTextBox("2");
            }
            else if (e.KeyCode == Keys.D3)
            {
                AddNumberToTextBox("3");
            }
            else if (e.KeyCode == Keys.D4)
            {
                AddNumberToTextBox("4");
            }
            else if (e.KeyCode == Keys.D5)
            {
                AddNumberToTextBox("5");
            }
            else if (e.KeyCode == Keys.D6)
            {
                AddNumberToTextBox("6");
            }
            else if (e.KeyCode == Keys.D7)
            {
                AddNumberToTextBox("7");
            }
            else if (e.KeyCode == Keys.D8)
            {
                AddNumberToTextBox("8");
            }
            else if (e.KeyCode == Keys.D9)
            {
                AddNumberToTextBox("9");
            }
            else if (e.KeyCode == Keys.D0)
            {
                AddNumberToTextBox("0");
            }
            else if (e.KeyCode == Keys.Oemplus && prevKey != Keys.ShiftKey)
            {
                btnFindout_Click(null, null);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnFindout_Click(null, null);
            }
            else if (e.KeyCode == Keys.OemBackslash)
            {
                //not yet supported
            }
            else
            {
                Debug.WriteLine(e.KeyCode + "prev key: " + prevKey);
            }

            prevKey = e.KeyCode;
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.SelectionLength = 0;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
