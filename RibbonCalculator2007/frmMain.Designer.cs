
namespace MicrosoftCalculator2007
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new System.Windows.Forms.Ribbon();
            this.ribbonOrbAbout = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbExit = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelNumbers = new System.Windows.Forms.RibbonPanel();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton9 = new System.Windows.Forms.RibbonButton();
            this.btnZero = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelMathOperations = new System.Windows.Forms.RibbonPanel();
            this.btnAdd = new System.Windows.Forms.RibbonButton();
            this.btnSubtract = new System.Windows.Forms.RibbonButton();
            this.btnDivide = new System.Windows.Forms.RibbonButton();
            this.btnMultiple = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelOther = new System.Windows.Forms.RibbonPanel();
            this.btnFindout = new System.Windows.Forms.RibbonButton();
            this.btnClear = new System.Windows.Forms.RibbonButton();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.ribbonOrbSettings = new System.Windows.Forms.RibbonOrbMenuItem();
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
            this.ribbon.OrbDropDown.BorderRoundness = 8;
            this.ribbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbAbout);
            this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbExit);
            this.ribbon.OrbDropDown.MenuItems.Add(this.ribbonOrbSettings);
            this.ribbon.OrbDropDown.Name = "";
            this.ribbon.OrbDropDown.Size = new System.Drawing.Size(527, 204);
            this.ribbon.OrbDropDown.TabIndex = 0;
            this.ribbon.OrbText = "ORb text";
            this.ribbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon.Size = new System.Drawing.Size(719, 152);
            this.ribbon.TabIndex = 0;
            this.ribbon.Tabs.Add(this.ribbonTab1);
            this.ribbon.Text = "ribbon1";
            this.ribbon.ThemeColor = System.Windows.Forms.RibbonTheme.Halloween;
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
            this.ribbonPanelNumbers.Items.Add(this.ribbonButton1);
            this.ribbonPanelNumbers.Items.Add(this.ribbonButton2);
            this.ribbonPanelNumbers.Items.Add(this.ribbonButton3);
            this.ribbonPanelNumbers.Items.Add(this.ribbonButton4);
            this.ribbonPanelNumbers.Items.Add(this.ribbonButton5);
            this.ribbonPanelNumbers.Items.Add(this.ribbonButton6);
            this.ribbonPanelNumbers.Items.Add(this.ribbonButton7);
            this.ribbonPanelNumbers.Items.Add(this.ribbonButton8);
            this.ribbonPanelNumbers.Items.Add(this.ribbonButton9);
            this.ribbonPanelNumbers.Items.Add(this.btnZero);
            this.ribbonPanelNumbers.Name = "ribbonPanelNumbers";
            this.ribbonPanelNumbers.Text = "Numbers";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "1";
            this.ribbonButton1.Click += new System.EventHandler(this.ribbonButton1_Click);
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "2";
            this.ribbonButton2.Click += new System.EventHandler(this.ribbonButton2_Click);
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "3";
            this.ribbonButton3.Click += new System.EventHandler(this.ribbonButton3_Click);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "4";
            this.ribbonButton4.Click += new System.EventHandler(this.ribbonButton4_Click);
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.LargeImage")));
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "5";
            this.ribbonButton5.Click += new System.EventHandler(this.ribbonButton5_Click);
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.LargeImage")));
            this.ribbonButton6.Name = "ribbonButton6";
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "6";
            this.ribbonButton6.Click += new System.EventHandler(this.ribbonButton6_Click);
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
            this.ribbonButton7.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.LargeImage")));
            this.ribbonButton7.Name = "ribbonButton7";
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Text = "7";
            this.ribbonButton7.Click += new System.EventHandler(this.ribbonButton7_Click);
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.Image")));
            this.ribbonButton8.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.LargeImage")));
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Text = "8";
            this.ribbonButton8.Click += new System.EventHandler(this.ribbonButton8_Click);
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.Image")));
            this.ribbonButton9.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.LargeImage")));
            this.ribbonButton9.Name = "ribbonButton9";
            this.ribbonButton9.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.SmallImage")));
            this.ribbonButton9.Text = "9";
            this.ribbonButton9.Click += new System.EventHandler(this.ribbonButton9_Click);
            // 
            // btnZero
            // 
            this.btnZero.Image = ((System.Drawing.Image)(resources.GetObject("btnZero.Image")));
            this.btnZero.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnZero.LargeImage")));
            this.btnZero.Name = "btnZero";
            this.btnZero.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnZero.SmallImage")));
            this.btnZero.Text = "0";
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
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
            this.textBox1.Text = "";
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 435);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ribbon);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Ribbon Calculator 2007";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanelNumbers;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonButton ribbonButton8;
        private System.Windows.Forms.RibbonButton ribbonButton9;
        private System.Windows.Forms.RibbonButton btnZero;
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
    }
}

