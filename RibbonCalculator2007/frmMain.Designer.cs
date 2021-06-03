
namespace RibbonCalculator2007
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.ribbonOrbAbout = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbSettings = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelNumbers = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonList2 = new System.Windows.Forms.RibbonButtonList();
            this.btn1 = new System.Windows.Forms.RibbonButton();
            this.btn2 = new System.Windows.Forms.RibbonButton();
            this.btn3 = new System.Windows.Forms.RibbonButton();
            this.btn4 = new System.Windows.Forms.RibbonButton();
            this.btn5 = new System.Windows.Forms.RibbonButton();
            this.btn6 = new System.Windows.Forms.RibbonButton();
            this.btn7 = new System.Windows.Forms.RibbonButton();
            this.btn8 = new System.Windows.Forms.RibbonButton();
            this.btn9 = new System.Windows.Forms.RibbonButton();
            this.btn0 = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelMathOperations = new System.Windows.Forms.RibbonPanel();
            this.btnAdd = new System.Windows.Forms.RibbonButton();
            this.btnSubtract = new System.Windows.Forms.RibbonButton();
            this.btnDivide = new System.Windows.Forms.RibbonButton();
            this.btnMultiple = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelOther = new System.Windows.Forms.RibbonPanel();
            this.btnFindout = new System.Windows.Forms.RibbonButton();
            this.btnClear = new System.Windows.Forms.RibbonButton();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Minimized = false;
            this.ribbon.Name = "ribbon";
            // 
            // 
            // 
            this.ribbon.OrbDropDown.BorderRoundness = 2;
            this.ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbAbout);
            this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbExit);
            this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbSettings);
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 204);
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.OrbText = "Orb text";
            this.ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon.Size = new System.Drawing.Size(719, 152);
            this.ribbon.TabIndex = 0;
            this.ribbon.Tabs.Add(this.ribbonTab1);
            this.ribbon.Text = "ribbon1";
            this.ribbon.ThemeColor = System.Windows.Forms.RibbonTheme.Green;
            // 
            // ribbonOrbAbout
            // 
            this.ribbonOrbAbout.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbAbout.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbAbout.Image")));
            this.ribbonOrbAbout.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbAbout.LargeImage")));
            this.ribbonOrbAbout.Name = "ribbonOrbAbout";
            this.ribbonOrbAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbAbout.SmallImage")));
            this.ribbonOrbAbout.Text = "About";
            this.ribbonOrbAbout.Click += new System.EventHandler(this.ribbonOrbAbout_Click);
            // 
            // ribbonOrbExit
            // 
            this.ribbonOrbExit.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbExit.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbExit.Image")));
            this.ribbonOrbExit.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbExit.LargeImage")));
            this.ribbonOrbExit.Name = "ribbonOrbExit";
            this.ribbonOrbExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbExit.SmallImage")));
            this.ribbonOrbExit.Text = "Exit";
            this.ribbonOrbExit.Click += new System.EventHandler(this.ribbonOrbExit_Click);
            // 
            // ribbonOrbSettings
            // 
            this.ribbonOrbSettings.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbSettings.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSettings.Image")));
            this.ribbonOrbSettings.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSettings.LargeImage")));
            this.ribbonOrbSettings.Name = "ribbonOrbSettings";
            this.ribbonOrbSettings.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbSettings.SmallImage")));
            this.ribbonOrbSettings.Text = "Settings";
            this.ribbonOrbSettings.Click += new System.EventHandler(this.ribbonOrbSettings_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanelNumbers);
            this.ribbonTab1.Panels.Add(this.ribbonPanelMathOperations);
            this.ribbonTab1.Panels.Add(this.ribbonPanelOther);
            this.ribbonTab1.Text = "Numbers";
            // 
            // ribbonPanelNumbers
            // 
            this.ribbonPanelNumbers.Items.Add(this.ribbonButtonList2);
            this.ribbonPanelNumbers.Name = "ribbonPanelNumbers";
            this.ribbonPanelNumbers.Text = "Numbers";
            // 
            // ribbonButtonList2
            // 
            this.ribbonButtonList2.Buttons.Add(this.btn1);
            this.ribbonButtonList2.Buttons.Add(this.btn2);
            this.ribbonButtonList2.Buttons.Add(this.btn3);
            this.ribbonButtonList2.Buttons.Add(this.btn4);
            this.ribbonButtonList2.Buttons.Add(this.btn5);
            this.ribbonButtonList2.Buttons.Add(this.btn6);
            this.ribbonButtonList2.Buttons.Add(this.btn7);
            this.ribbonButtonList2.Buttons.Add(this.btn8);
            this.ribbonButtonList2.Buttons.Add(this.btn9);
            this.ribbonButtonList2.Buttons.Add(this.btn0);
            this.ribbonButtonList2.ButtonsSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonList2.FlashEnabled = true;
            this.ribbonButtonList2.FlashImage = global::RibbonCalculator2007.Properties.Resources.Calc;
            this.ribbonButtonList2.FlowToBottom = false;
            this.ribbonButtonList2.ItemsSizeInDropwDownMode = new System.Drawing.Size(7, 5);
            this.ribbonButtonList2.Name = "ribbonButtonList2";
            this.ribbonButtonList2.ShowFlashImage = true;
            this.ribbonButtonList2.Text = "ribbonButtonList2";
            // 
            // btn1
            // 
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn1.LargeImage")));
            this.btn1.Name = "btn1";
            this.btn1.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn1.SmallImage")));
            this.btn1.Text = "1";
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn2.LargeImage")));
            this.btn2.Name = "btn2";
            this.btn2.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn2.SmallImage")));
            this.btn2.Text = "2";
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn3.LargeImage")));
            this.btn3.Name = "btn3";
            this.btn3.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn3.SmallImage")));
            this.btn3.Text = "3";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn4.LargeImage")));
            this.btn4.Name = "btn4";
            this.btn4.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn4.SmallImage")));
            this.btn4.Text = "4";
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn5.LargeImage")));
            this.btn5.Name = "btn5";
            this.btn5.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn5.SmallImage")));
            this.btn5.Text = "5";
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn6.LargeImage")));
            this.btn6.Name = "btn6";
            this.btn6.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn6.SmallImage")));
            this.btn6.Text = "6";
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn7.LargeImage")));
            this.btn7.Name = "btn7";
            this.btn7.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn7.SmallImage")));
            this.btn7.Text = "7";
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn8.LargeImage")));
            this.btn8.Name = "btn8";
            this.btn8.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn8.SmallImage")));
            this.btn8.Text = "8";
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn9.LargeImage")));
            this.btn9.Name = "btn9";
            this.btn9.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn9.SmallImage")));
            this.btn9.Text = "9";
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn0
            // 
            this.btn0.Image = ((System.Drawing.Image)(resources.GetObject("btn0.Image")));
            this.btn0.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn0.LargeImage")));
            this.btn0.Name = "btn0";
            this.btn0.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn0.SmallImage")));
            this.btn0.Text = "0";
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // ribbonPanelMathOperations
            // 
            this.ribbonPanelMathOperations.Items.Add(this.btnAdd);
            this.ribbonPanelMathOperations.Items.Add(this.btnSubtract);
            this.ribbonPanelMathOperations.Items.Add(this.btnDivide);
            this.ribbonPanelMathOperations.Items.Add(this.btnMultiple);
            this.ribbonPanelMathOperations.Name = "ribbonPanelMathOperations";
            this.ribbonPanelMathOperations.Text = "Math Operations";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.SmallImage")));
            this.btnAdd.Text = "+";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Image = ((System.Drawing.Image)(resources.GetObject("btnSubtract.Image")));
            this.btnSubtract.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSubtract.LargeImage")));
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSubtract.SmallImage")));
            this.btnSubtract.Text = "-";
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Image = ((System.Drawing.Image)(resources.GetObject("btnDivide.Image")));
            this.btnDivide.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDivide.LargeImage")));
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDivide.SmallImage")));
            this.btnDivide.Text = "➗";
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Image = ((System.Drawing.Image)(resources.GetObject("btnMultiple.Image")));
            this.btnMultiple.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMultiple.LargeImage")));
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnMultiple.SmallImage")));
            this.btnMultiple.Text = "×";
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // ribbonPanelOther
            // 
            this.ribbonPanelOther.Items.Add(this.btnFindout);
            this.ribbonPanelOther.Items.Add(this.btnClear);
            this.ribbonPanelOther.Name = "ribbonPanelOther";
            this.ribbonPanelOther.Text = "Other";
            // 
            // btnFindout
            // 
            this.btnFindout.Image = ((System.Drawing.Image)(resources.GetObject("btnFindout.Image")));
            this.btnFindout.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnFindout.LargeImage")));
            this.btnFindout.Name = "btnFindout";
            this.btnFindout.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnFindout.SmallImage")));
            this.btnFindout.Text = "Find out";
            this.btnFindout.Click += new System.EventHandler(this.btnFindout_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClear.LargeImage")));
            this.btnClear.Name = "btnClear";
            this.btnClear.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnClear.SmallImage")));
            this.btnClear.Text = "Clear ";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(719, 283);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 435);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Ribbon Calculator 2007";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanelNumbers;
        private System.Windows.Forms.RibbonPanel ribbonPanelMathOperations;
        private System.Windows.Forms.RibbonButton btnAdd;
        private System.Windows.Forms.RibbonButton btnSubtract;
        private System.Windows.Forms.RibbonButton btnDivide;
        private System.Windows.Forms.RibbonButton btnMultiple;
        private System.Windows.Forms.RibbonPanel ribbonPanelOther;
        private System.Windows.Forms.RibbonButton btnFindout;
        private System.Windows.Forms.RibbonButton btnClear;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbAbout;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbExit;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbSettings;
        private System.Windows.Forms.RibbonButtonList ribbonButtonList2;
        private System.Windows.Forms.RibbonButton btn1;
        private System.Windows.Forms.RibbonButton btn2;
        private System.Windows.Forms.RibbonButton btn3;
        private System.Windows.Forms.RibbonButton btn4;
        private System.Windows.Forms.RibbonButton btn5;
        private System.Windows.Forms.RibbonButton btn6;
        private System.Windows.Forms.RibbonButton btn7;
        private System.Windows.Forms.RibbonButton btn8;
        private System.Windows.Forms.RibbonButton btn9;
        private System.Windows.Forms.RibbonButton btn0;
        private System.Windows.Forms.Timer timer1;
    }
}

