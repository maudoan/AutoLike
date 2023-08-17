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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            this.toolBar = new System.Windows.Forms.Panel();
            this.pictureBoxLogoShop = new System.Windows.Forms.PictureBox();
            this.labelAppName = new System.Windows.Forms.Label();
            this.toolBar.SuspendLayout();
            this.SuspendLayout();



            // 
            // ToolBar
            // 
            this.toolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            //this.panel1.Controls.Add(this.label66);
            this.toolBar.Controls.Add(this.pictureBoxLogoShop);
            //this.panel1.Controls.Add(this.button1);
            //this.panel1.Controls.Add(this.button2);
            //this.panel1.Controls.Add(this.label2);
            this.toolBar.Controls.Add(this.labelAppName);
            //this.panel1.Controls.Add(this.panel2);
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "ToolBar";
            this.toolBar.Size = new System.Drawing.Size(1678, 32);
            this.toolBar.TabIndex = 3;
            //this.ToolBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            //this.ToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);



            // 
            // pictureBoxLogoShop
            // 
            this.pictureBoxLogoShop.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLogoShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo")));
            this.pictureBoxLogoShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLogoShop.Location = new System.Drawing.Point(6, 5);
            this.pictureBoxLogoShop.Name = "pictureBoxLogoShop";
            this.pictureBoxLogoShop.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxLogoShop.TabIndex = 6;
            this.pictureBoxLogoShop.TabStop = false;
            //this.pictureBoxLogoShop.Click += new System.EventHandler(this.PictureBox1_Click);


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
            //this.labelAppName.Click += new System.EventHandler(this.Label1_Click);


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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1678, 873);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            //this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoShop)).BeginInit();
        }

        #endregion

        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.PictureBox pictureBoxLogoShop;
        private System.Windows.Forms.Label labelAppName;
    }
}

