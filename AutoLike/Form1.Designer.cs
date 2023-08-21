namespace AutoLike
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolBar = new System.Windows.Forms.Panel();
            this.pictureBoxLogoShop = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.lableContact = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.lablePhoneContact = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.doashBoardTabPage = new System.Windows.Forms.TabPage();
            this.toolBar.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoShop)).BeginInit();
            this.SuspendLayout();

            // 
            // toolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.toolBar.Controls.Add(this.pictureBoxLogoShop);
            this.toolBar.Controls.Add(this.minimizeButton);
            this.toolBar.Controls.Add(this.buttonCloseApp);
            this.toolBar.Controls.Add(this.lableContact);
            this.toolBar.Controls.Add(this.labelAppName);
            this.toolBar.Controls.Add(this.lablePhoneContact);
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(1678, 32);
            this.toolBar.TabIndex = 3;

            // 
            // pictureBoxLogoShop
            // 
            this.pictureBoxLogoShop.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogoShop.BackgroundImage")));
            this.pictureBoxLogoShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogoShop.Location = new System.Drawing.Point(6, 5);
            this.pictureBoxLogoShop.Name = "pictureBoxLogoShop";
            this.pictureBoxLogoShop.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxLogoShop.TabIndex = 6;
            this.pictureBoxLogoShop.TabStop = false;


            // 
            // labelAppName
            // 
            this.labelAppName.AutoSize = true;
            this.labelAppName.BackColor = System.Drawing.Color.Transparent;
            this.labelAppName.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.labelAppName.ForeColor = System.Drawing.Color.White;
            this.labelAppName.Location = new System.Drawing.Point(37, 10);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(72, 13);
            this.labelAppName.TabIndex = 4;
            this.labelAppName.Text = "Shoplike.vn";


            // 
            // lablePhoneContact
            // 
            this.lablePhoneContact.AutoSize = true;
            this.lablePhoneContact.BackColor = System.Drawing.Color.Transparent;
            this.lablePhoneContact.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lablePhoneContact.ForeColor = System.Drawing.Color.White;
            this.lablePhoneContact.Location = new System.Drawing.Point(1266, 9);
            this.lablePhoneContact.Name = "lablePhoneContact";
            this.lablePhoneContact.Size = new System.Drawing.Size(127, 13);
            this.lablePhoneContact.TabIndex = 7;
            this.lablePhoneContact.Text = "Phone : 0969.066.386";

            // 
            // lableContact
            // 
            this.lableContact.AutoSize = true;
            this.lableContact.BackColor = System.Drawing.Color.Transparent;
            this.lableContact.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lableContact.ForeColor = System.Drawing.Color.White;
            this.lableContact.Location = new System.Drawing.Point(1431, 8);
            this.lableContact.Name = "lableContact";
            this.lableContact.Size = new System.Drawing.Size(176, 13);
            this.lableContact.TabIndex = 5;
            this.lableContact.Text = "wWw.facebook.com/Huydepzajnek";

            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Location = new System.Drawing.Point(1615, 6);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);

            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseApp.BackgroundImage")));
            this.buttonCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCloseApp.FlatAppearance.BorderSize = 0;
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCloseApp.Location = new System.Drawing.Point(1641, 5);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(20, 20);
            this.buttonCloseApp.TabIndex = 2;
            this.buttonCloseApp.UseVisualStyleBackColor = false;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);

            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.doashBoardTabPage);
            //this.tabControl.Controls.Add(this.LDPlayer);
            //this.tabControl.Controls.Add(this.tabPage13);
            //this.tabControl.Controls.Add(this.tabPage2);
            //this.tabControl.Controls.Add(this.tabPage14);
            //this.tabControl.Controls.Add(this.tabPage5);
            //this.tabControl.Controls.Add(this.tabPage3);
            //this.tabControl.Controls.Add(this.tabPage6);
            //this.tabControl.Controls.Add(this.tabPage7);
            //this.tabControl.Controls.Add(this.tabPage8);
            //this.tabControl.Controls.Add(this.tabPage9);
            //this.tabControl.Controls.Add(this.tabPage11);
            //this.tabControl.Controls.Add(this.tabPage10);
            //this.tabControl.Controls.Add(this.tabPage4);
            //this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tabControl.HotTrack = true;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl.Location = new System.Drawing.Point(3, 35);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl1";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1672, 787);
            this.tabControl.TabIndex = 40;

            // 
            // doashBoardTabPage
            // 
            this.doashBoardTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(151)))), ((int)(((byte)(153)))));
            //this.mainTabPage.Controls.Add(this.groupBox1);
            //this.mainTabPage.Controls.Add(this.txtlog);
            //this.mainTabPage.Controls.Add(this.tabControl2);
            //this.mainTabPage.Controls.Add(this.groupBox6);
            //this.mainTabPage.Controls.Add(this.groupBox4);
            //this.mainTabPage.Controls.Add(this.groupBox3);
            //this.mainTabPage.Controls.Add(this.groupBox2);
            //this.mainTabPage.Controls.Add(this.panel4);
            this.doashBoardTabPage.ForeColor = System.Drawing.Color.White;
            this.doashBoardTabPage.Location = new System.Drawing.Point(4, 34);
            this.doashBoardTabPage.Name = "doashBoardTabPage";
            this.doashBoardTabPage.Size = new System.Drawing.Size(1664, 749);
            this.doashBoardTabPage.TabIndex = 15;
            this.doashBoardTabPage.Text = "DoashBoard";


            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1678, 873);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1678, 873);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoShop)).EndInit();
            //this.ResumeLayout(false);
            //this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.PictureBox pictureBoxLogoShop;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Label lableContact;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label lablePhoneContact;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage doashBoardTabPage;  

    }
}

