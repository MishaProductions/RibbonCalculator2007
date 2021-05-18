
namespace MicrosoftCalculator2007
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.btnOK = new System.Windows.Forms.RibbonButton();
            this.btnOK2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonLabel1 = new System.Windows.Forms.RibbonLabel();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbVisible = false;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(722, 148);
            this.ribbon1.TabIndex = 2;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Halloween;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "About";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Items.Add(this.btnOK);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Tools";
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOK.LargeImage")));
            this.btnOK.Name = "btnOK";
            this.btnOK.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnOK.SmallImage")));
            this.btnOK.Text = "Exit";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOK2
            // 
            this.btnOK2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK2.Location = new System.Drawing.Point(608, 356);
            this.btnOK2.Name = "btnOK2";
            this.btnOK2.Size = new System.Drawing.Size(102, 42);
            this.btnOK2.TabIndex = 3;
            this.btnOK2.Text = "OK";
            this.btnOK2.UseVisualStyleBackColor = true;
            this.btnOK2.Click += new System.EventHandler(this.btnOK2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(697, 195);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Ribbon Calculator 2007\nCreated by Misha, just for fun.\nVersion: v1.0";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.ribbonLabel1);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "AboutPage";
            this.ribbonPanel2.Click += new System.EventHandler(this.ribbonPanel2_Click);
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "About page";
            this.ribbonLabel1.Click += new System.EventHandler(this.ribbonPanel2_Click);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 410);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOK2);
            this.Controls.Add(this.ribbon1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About Ribbon Calculator 2007";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonButton btnOK;
        private System.Windows.Forms.Button btnOK2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonLabel ribbonLabel1;
    }
}