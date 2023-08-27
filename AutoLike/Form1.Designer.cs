using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolBar = new System.Windows.Forms.Panel();
            this.pictureBoxLogoShop = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.lableContact = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.lablePhoneContact = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.doashBoardTabPage = new System.Windows.Forms.TabPage();
            this.fileManagementGroupBox = new System.Windows.Forms.GroupBox();
            this.fileManagementChild1GroupBox = new System.Windows.Forms.GroupBox();
            this.fileManagementLabel = new System.Windows.Forms.Label();
            this.importFileTextBox = new System.Windows.Forms.TextBox();
            this.importFileLabel = new System.Windows.Forms.Label();
            this.createFileLabel = new System.Windows.Forms.Label();
            this.createFileTextBox = new System.Windows.Forms.TextBox();
            this.fileManagementChild2GroupBox = new System.Windows.Forms.GroupBox();
            this.statusFilterLabel = new System.Windows.Forms.Label();
            this.statusFilterComboBox = new System.Windows.Forms.ComboBox();
            this.readAllFileLabel = new System.Windows.Forms.Label();
            this.readAllFileButton = new System.Windows.Forms.Button();
            this.listFileDataGridView = new System.Windows.Forms.DataGridView();
            this.listFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listFileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFileDetail = new System.Windows.Forms.TextBox();
            this.passCheckPointGroupBox = new System.Windows.Forms.GroupBox();
            this.backupGroupBox = new System.Windows.Forms.GroupBox();
            this.checkViaGroupBox = new System.Windows.Forms.GroupBox();
            this.settingChormeGroupBox = new System.Windows.Forms.GroupBox();
            this.turnOffChormeButton = new System.Windows.Forms.Button();
            this.detailListAccountsPanel = new System.Windows.Forms.Panel();
            this.detailListAccountsDataGridView = new System.Windows.Forms.DataGridView();
            this.sttAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkboxItemAccount = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uidAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code2faAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookieAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cookieldAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tokenldAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passmailAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namtaoAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.friendsAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupsAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastactiveAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenfileAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichuAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthaiAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.featuresContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.loadingPictureBox = new System.Windows.Forms.PictureBox();
            this.selectAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAccountNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLiveAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDieAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCheckpointAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSelectAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSelectAllAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoShop)).BeginInit();
            this.tabControl.SuspendLayout();
            this.doashBoardTabPage.SuspendLayout();
            this.fileManagementGroupBox.SuspendLayout();
            this.fileManagementChild1GroupBox.SuspendLayout();
            this.fileManagementChild2GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFileDataGridView)).BeginInit();
            this.listFileContextMenuStrip.SuspendLayout();
            this.settingChormeGroupBox.SuspendLayout();
            this.detailListAccountsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailListAccountsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
            this.featuresContextMenuStrip.SuspendLayout();
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
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.doashBoardTabPage);
            this.tabControl.Font = new System.Drawing.Font("Tahoma", 8F);
            this.tabControl.HotTrack = true;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabControl.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl.Location = new System.Drawing.Point(3, 35);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1672, 787);
            this.tabControl.TabIndex = 40;
            // 
            // doashBoardTabPage
            // 
            this.doashBoardTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(151)))), ((int)(((byte)(153)))));
            this.doashBoardTabPage.Controls.Add(this.fileManagementGroupBox);
            this.doashBoardTabPage.Controls.Add(this.itemFileDetail);
            this.doashBoardTabPage.Controls.Add(this.passCheckPointGroupBox);
            this.doashBoardTabPage.Controls.Add(this.backupGroupBox);
            this.doashBoardTabPage.Controls.Add(this.checkViaGroupBox);
            this.doashBoardTabPage.Controls.Add(this.settingChormeGroupBox);
            this.doashBoardTabPage.Controls.Add(this.detailListAccountsPanel);
            this.doashBoardTabPage.ForeColor = System.Drawing.Color.White;
            this.doashBoardTabPage.Location = new System.Drawing.Point(4, 34);
            this.doashBoardTabPage.Name = "doashBoardTabPage";
            this.doashBoardTabPage.Size = new System.Drawing.Size(1664, 749);
            this.doashBoardTabPage.TabIndex = 15;
            this.doashBoardTabPage.Text = "DoashBoard";
            // 
            // fileManagementGroupBox
            // 
            this.fileManagementGroupBox.Controls.Add(this.fileManagementChild1GroupBox);
            this.fileManagementGroupBox.Controls.Add(this.fileManagementChild2GroupBox);
            this.fileManagementGroupBox.Controls.Add(this.listFileDataGridView);
            this.fileManagementGroupBox.Location = new System.Drawing.Point(1307, 157);
            this.fileManagementGroupBox.Name = "fileManagementGroupBox";
            this.fileManagementGroupBox.Size = new System.Drawing.Size(321, 592);
            this.fileManagementGroupBox.TabIndex = 57;
            this.fileManagementGroupBox.TabStop = false;
            // 
            // fileManagementChild1GroupBox
            // 
            this.fileManagementChild1GroupBox.Controls.Add(this.fileManagementLabel);
            this.fileManagementChild1GroupBox.Controls.Add(this.importFileTextBox);
            this.fileManagementChild1GroupBox.Controls.Add(this.importFileLabel);
            this.fileManagementChild1GroupBox.Controls.Add(this.createFileLabel);
            this.fileManagementChild1GroupBox.Controls.Add(this.createFileTextBox);
            this.fileManagementChild1GroupBox.Location = new System.Drawing.Point(5, 10);
            this.fileManagementChild1GroupBox.Name = "fileManagementChild1GroupBox";
            this.fileManagementChild1GroupBox.Size = new System.Drawing.Size(310, 140);
            this.fileManagementChild1GroupBox.TabIndex = 55;
            this.fileManagementChild1GroupBox.TabStop = false;
            // 
            // fileManagementLabel
            // 
            this.fileManagementLabel.AutoSize = true;
            this.fileManagementLabel.BackColor = System.Drawing.Color.Green;
            this.fileManagementLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileManagementLabel.Location = new System.Drawing.Point(4, 9);
            this.fileManagementLabel.Name = "fileManagementLabel";
            this.fileManagementLabel.Size = new System.Drawing.Size(69, 13);
            this.fileManagementLabel.TabIndex = 81;
            this.fileManagementLabel.Text = "Quản lý file";
            // 
            // importFileTextBox
            // 
            this.importFileTextBox.Location = new System.Drawing.Point(80, 39);
            this.importFileTextBox.Name = "importFileTextBox";
            this.importFileTextBox.ReadOnly = true;
            this.importFileTextBox.Size = new System.Drawing.Size(200, 20);
            this.importFileTextBox.TabIndex = 35;
            this.importFileTextBox.DoubleClick += new System.EventHandler(this.importFileTextBox_DoubleClick);
            // 
            // importFileLabel
            // 
            this.importFileLabel.AutoSize = true;
            this.importFileLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importFileLabel.ForeColor = System.Drawing.Color.White;
            this.importFileLabel.Location = new System.Drawing.Point(5, 40);
            this.importFileLabel.Name = "importFileLabel";
            this.importFileLabel.Size = new System.Drawing.Size(69, 13);
            this.importFileLabel.TabIndex = 85;
            this.importFileLabel.Text = "Import File";
            // 
            // createFileLabel
            // 
            this.createFileLabel.AutoSize = true;
            this.createFileLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFileLabel.ForeColor = System.Drawing.Color.White;
            this.createFileLabel.Location = new System.Drawing.Point(2, 80);
            this.createFileLabel.Name = "createFileLabel";
            this.createFileLabel.Size = new System.Drawing.Size(67, 13);
            this.createFileLabel.TabIndex = 84;
            this.createFileLabel.Text = "Create File";
            // 
            // createFileTextBox
            // 
            this.createFileTextBox.Location = new System.Drawing.Point(80, 80);
            this.createFileTextBox.Name = "createFileTextBox";
            this.createFileTextBox.Size = new System.Drawing.Size(200, 20);
            this.createFileTextBox.TabIndex = 36;
            // 
            // fileManagementChild2GroupBox
            // 
            this.fileManagementChild2GroupBox.Controls.Add(this.statusFilterLabel);
            this.fileManagementChild2GroupBox.Controls.Add(this.statusFilterComboBox);
            this.fileManagementChild2GroupBox.Controls.Add(this.readAllFileLabel);
            this.fileManagementChild2GroupBox.Controls.Add(this.readAllFileButton);
            this.fileManagementChild2GroupBox.Location = new System.Drawing.Point(5, 150);
            this.fileManagementChild2GroupBox.Name = "fileManagementChild2GroupBox";
            this.fileManagementChild2GroupBox.Size = new System.Drawing.Size(310, 140);
            this.fileManagementChild2GroupBox.TabIndex = 55;
            this.fileManagementChild2GroupBox.TabStop = false;
            // 
            // statusFilterLabel
            // 
            this.statusFilterLabel.AutoSize = true;
            this.statusFilterLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusFilterLabel.Location = new System.Drawing.Point(2, 110);
            this.statusFilterLabel.Name = "statusFilterLabel";
            this.statusFilterLabel.Size = new System.Drawing.Size(100, 16);
            this.statusFilterLabel.TabIndex = 0;
            this.statusFilterLabel.Text = "Lọc Tình Trạng";
            // 
            // statusFilterComboBox
            // 
            this.statusFilterComboBox.FormattingEnabled = true;
            this.statusFilterComboBox.Items.AddRange(new object[] {
            "ALL",
            "Live",
            "Checkpoint",
            "Die",
            "null"});
            this.statusFilterComboBox.Location = new System.Drawing.Point(105, 110);
            this.statusFilterComboBox.Name = "statusFilterComboBox";
            this.statusFilterComboBox.Size = new System.Drawing.Size(152, 21);
            this.statusFilterComboBox.TabIndex = 1;
            // 
            // readAllFileLabel
            // 
            this.readAllFileLabel.AutoSize = true;
            this.readAllFileLabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readAllFileLabel.Location = new System.Drawing.Point(2, 40);
            this.readAllFileLabel.Name = "readAllFileLabel";
            this.readAllFileLabel.Size = new System.Drawing.Size(76, 16);
            this.readAllFileLabel.TabIndex = 1;
            this.readAllFileLabel.Text = "Đọc All File";
            // 
            // readAllFileButton
            // 
            this.readAllFileButton.BackColor = System.Drawing.Color.DarkGray;
            this.readAllFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.readAllFileButton.ForeColor = System.Drawing.Color.White;
            this.readAllFileButton.Location = new System.Drawing.Point(100, 40);
            this.readAllFileButton.Name = "readAllFileButton";
            this.readAllFileButton.Size = new System.Drawing.Size(69, 25);
            this.readAllFileButton.TabIndex = 89;
            this.readAllFileButton.Text = "Read All";
            this.readAllFileButton.UseVisualStyleBackColor = false;
            // 
            // listFileDataGridView
            // 
            this.listFileDataGridView.AllowUserToAddRows = false;
            this.listFileDataGridView.AllowUserToResizeRows = false;
            this.listFileDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.listFileDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listFileDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.listFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listFileDataGridView.ColumnHeadersVisible = false;
            this.listFileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.listFileDataGridViewTextBoxColumn});
            this.listFileDataGridView.ContextMenuStrip = this.listFileContextMenuStrip;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listFileDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.listFileDataGridView.GridColor = System.Drawing.Color.White;
            this.listFileDataGridView.Location = new System.Drawing.Point(5, 300);
            this.listFileDataGridView.Name = "listFileDataGridView";
            this.listFileDataGridView.RowHeadersVisible = false;
            this.listFileDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listFileDataGridView.Size = new System.Drawing.Size(309, 285);
            this.listFileDataGridView.TabIndex = 2;
            this.listFileDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listFileDataGridView_CellContentDoubleClick);
            // 
            // listFileDataGridViewTextBoxColumn
            // 
            this.listFileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.listFileDataGridViewTextBoxColumn.HeaderText = "Column1";
            this.listFileDataGridViewTextBoxColumn.Name = "listFileDataGridViewTextBoxColumn";
            this.listFileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // listFileContextMenuStrip
            // 
            this.listFileContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFileToolStripMenuItem,
            this.editNameFileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.listFileContextMenuStrip.Name = "listFileContextMenuStrip";
            this.listFileContextMenuStrip.Size = new System.Drawing.Size(134, 70);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteFileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteFileToolStripMenuItem.Text = "Xóa File";
            // 
            // editNameFileToolStripMenuItem
            // 
            this.editNameFileToolStripMenuItem.Name = "editNameFileToolStripMenuItem";
            this.editNameFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.editNameFileToolStripMenuItem.Text = "Đổi tên File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // itemFileDetail
            // 
            this.itemFileDetail.Location = new System.Drawing.Point(8, 668);
            this.itemFileDetail.Multiline = true;
            this.itemFileDetail.Name = "itemFileDetail";
            this.itemFileDetail.Size = new System.Drawing.Size(1293, 74);
            this.itemFileDetail.TabIndex = 88;
            // 
            // passCheckPointGroupBox
            // 
            this.passCheckPointGroupBox.Location = new System.Drawing.Point(1153, 3);
            this.passCheckPointGroupBox.Name = "passCheckPointGroupBox";
            this.passCheckPointGroupBox.Size = new System.Drawing.Size(464, 151);
            this.passCheckPointGroupBox.TabIndex = 20;
            this.passCheckPointGroupBox.TabStop = false;
            // 
            // backupGroupBox
            // 
            this.backupGroupBox.Location = new System.Drawing.Point(682, 3);
            this.backupGroupBox.Name = "backupGroupBox";
            this.backupGroupBox.Size = new System.Drawing.Size(464, 151);
            this.backupGroupBox.TabIndex = 20;
            this.backupGroupBox.TabStop = false;
            // 
            // checkViaGroupBox
            // 
            this.checkViaGroupBox.Location = new System.Drawing.Point(211, 3);
            this.checkViaGroupBox.Name = "checkViaGroupBox";
            this.checkViaGroupBox.Size = new System.Drawing.Size(465, 151);
            this.checkViaGroupBox.TabIndex = 20;
            this.checkViaGroupBox.TabStop = false;
            // 
            // settingChormeGroupBox
            // 
            this.settingChormeGroupBox.Controls.Add(this.turnOffChormeButton);
            this.settingChormeGroupBox.Location = new System.Drawing.Point(8, 3);
            this.settingChormeGroupBox.Name = "settingChormeGroupBox";
            this.settingChormeGroupBox.Size = new System.Drawing.Size(197, 151);
            this.settingChormeGroupBox.TabIndex = 19;
            this.settingChormeGroupBox.TabStop = false;
            // 
            // turnOffChormeButton
            // 
            this.turnOffChormeButton.BackColor = System.Drawing.Color.White;
            this.turnOffChormeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnOffChormeButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnOffChormeButton.ForeColor = System.Drawing.Color.Teal;
            this.turnOffChormeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.turnOffChormeButton.Location = new System.Drawing.Point(22, 83);
            this.turnOffChormeButton.Name = "turnOffChormeButton";
            this.turnOffChormeButton.Size = new System.Drawing.Size(152, 31);
            this.turnOffChormeButton.TabIndex = 56;
            this.turnOffChormeButton.Text = "Tắt Chromedriver";
            this.turnOffChormeButton.UseVisualStyleBackColor = false;
            // 
            // detailListAccountsPanel
            // 
            this.detailListAccountsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailListAccountsPanel.Controls.Add(this.detailListAccountsDataGridView);
            this.detailListAccountsPanel.Location = new System.Drawing.Point(8, 163);
            this.detailListAccountsPanel.Name = "detailListAccountsPanel";
            this.detailListAccountsPanel.Size = new System.Drawing.Size(1293, 499);
            this.detailListAccountsPanel.TabIndex = 18;
            // 
            // detailListAccountsDataGridView
            // 
            this.detailListAccountsDataGridView.AllowUserToAddRows = false;
            this.detailListAccountsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.detailListAccountsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.detailListAccountsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailListAccountsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.detailListAccountsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailListAccountsDataGridView.CausesValidation = false;
            this.detailListAccountsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.detailListAccountsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailListAccountsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detailListAccountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailListAccountsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sttAccount,
            this.checkboxItemAccount,
            this.uidAccount,
            this.passAccount,
            this.code2faAccount,
            this.cookieAccount,
            this.tokenAccount,
            this.cookieldAccount,
            this.tokenldAccount,
            this.emailAccount,
            this.passmailAccount,
            this.namtaoAccount,
            this.tenAccount,
            this.birthdayAccount,
            this.friendsAccount,
            this.groupsAccount,
            this.genderAccount,
            this.tinhtrangAccount,
            this.proxyAccount,
            this.lastactiveAccount,
            this.tenfileAccount,
            this.ghichuAccount,
            this.buAccount,
            this.trangthaiAccount});
            this.detailListAccountsDataGridView.ContextMenuStrip = this.featuresContextMenuStrip;
            this.detailListAccountsDataGridView.EnableHeadersVisualStyles = false;
            this.detailListAccountsDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.detailListAccountsDataGridView.Location = new System.Drawing.Point(3, 2);
            this.detailListAccountsDataGridView.Name = "detailListAccountsDataGridView";
            this.detailListAccountsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailListAccountsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.detailListAccountsDataGridView.RowHeadersVisible = false;
            this.detailListAccountsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailListAccountsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.detailListAccountsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailListAccountsDataGridView.Size = new System.Drawing.Size(1286, 492);
            this.detailListAccountsDataGridView.TabIndex = 83;
            // 
            // sttAccount
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sttAccount.DefaultCellStyle = dataGridViewCellStyle6;
            this.sttAccount.HeaderText = "STT";
            this.sttAccount.Name = "sttAccount";
            this.sttAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sttAccount.Width = 30;
            // 
            // checkboxItemAccount
            // 
            this.checkboxItemAccount.HeaderText = "All";
            this.checkboxItemAccount.Name = "checkboxItemAccount";
            this.checkboxItemAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkboxItemAccount.Width = 20;
            // 
            // uidAccount
            // 
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uidAccount.DefaultCellStyle = dataGridViewCellStyle7;
            this.uidAccount.HeaderText = "UID";
            this.uidAccount.Name = "uidAccount";
            this.uidAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uidAccount.Width = 60;
            // 
            // passAccount
            // 
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passAccount.DefaultCellStyle = dataGridViewCellStyle8;
            this.passAccount.HeaderText = "Pass Mail";
            this.passAccount.Name = "passAccount";
            this.passAccount.Width = 50;
            // 
            // code2faAccount
            // 
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.code2faAccount.DefaultCellStyle = dataGridViewCellStyle9;
            this.code2faAccount.HeaderText = "2FA";
            this.code2faAccount.Name = "code2faAccount";
            this.code2faAccount.Width = 50;
            // 
            // cookieAccount
            // 
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cookieAccount.DefaultCellStyle = dataGridViewCellStyle10;
            this.cookieAccount.HeaderText = "Cookie";
            this.cookieAccount.Name = "cookieAccount";
            this.cookieAccount.Width = 60;
            // 
            // tokenAccount
            // 
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tokenAccount.DefaultCellStyle = dataGridViewCellStyle11;
            this.tokenAccount.HeaderText = "Token";
            this.tokenAccount.Name = "tokenAccount";
            this.tokenAccount.Width = 60;
            // 
            // cookieldAccount
            // 
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cookieldAccount.DefaultCellStyle = dataGridViewCellStyle12;
            this.cookieldAccount.HeaderText = "Cookie LD";
            this.cookieldAccount.Name = "cookieldAccount";
            this.cookieldAccount.Width = 60;
            // 
            // tokenldAccount
            // 
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tokenldAccount.DefaultCellStyle = dataGridViewCellStyle13;
            this.tokenldAccount.HeaderText = "Token LD";
            this.tokenldAccount.Name = "tokenldAccount";
            this.tokenldAccount.Width = 60;
            // 
            // emailAccount
            // 
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailAccount.DefaultCellStyle = dataGridViewCellStyle14;
            this.emailAccount.HeaderText = "Email";
            this.emailAccount.Name = "emailAccount";
            this.emailAccount.Width = 50;
            // 
            // passmailAccount
            // 
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passmailAccount.DefaultCellStyle = dataGridViewCellStyle15;
            this.passmailAccount.HeaderText = "Pass Mail";
            this.passmailAccount.Name = "passmailAccount";
            this.passmailAccount.Width = 50;
            // 
            // namtaoAccount
            // 
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.namtaoAccount.DefaultCellStyle = dataGridViewCellStyle16;
            this.namtaoAccount.HeaderText = "Avatar";
            this.namtaoAccount.Name = "namtaoAccount";
            this.namtaoAccount.Width = 60;
            // 
            // tenAccount
            // 
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.SlateBlue;
            this.tenAccount.DefaultCellStyle = dataGridViewCellStyle17;
            this.tenAccount.FillWeight = 150F;
            this.tenAccount.HeaderText = "Name";
            this.tenAccount.Name = "tenAccount";
            this.tenAccount.ReadOnly = true;
            this.tenAccount.Width = 60;
            // 
            // birthdayAccount
            // 
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.birthdayAccount.DefaultCellStyle = dataGridViewCellStyle18;
            this.birthdayAccount.HeaderText = "Birthday";
            this.birthdayAccount.Name = "birthdayAccount";
            this.birthdayAccount.ReadOnly = true;
            this.birthdayAccount.Width = 60;
            // 
            // friendsAccount
            // 
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.friendsAccount.DefaultCellStyle = dataGridViewCellStyle19;
            this.friendsAccount.HeaderText = "Friends";
            this.friendsAccount.Name = "friendsAccount";
            this.friendsAccount.ReadOnly = true;
            this.friendsAccount.Width = 50;
            // 
            // groupsAccount
            // 
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupsAccount.DefaultCellStyle = dataGridViewCellStyle20;
            this.groupsAccount.HeaderText = "Groups";
            this.groupsAccount.Name = "groupsAccount";
            this.groupsAccount.ReadOnly = true;
            this.groupsAccount.Width = 50;
            // 
            // genderAccount
            // 
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genderAccount.DefaultCellStyle = dataGridViewCellStyle21;
            this.genderAccount.HeaderText = "Gender";
            this.genderAccount.Name = "genderAccount";
            this.genderAccount.ReadOnly = true;
            this.genderAccount.Width = 50;
            // 
            // tinhtrangAccount
            // 
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Green;
            this.tinhtrangAccount.DefaultCellStyle = dataGridViewCellStyle22;
            this.tinhtrangAccount.HeaderText = "Live/Die";
            this.tinhtrangAccount.Name = "tinhtrangAccount";
            this.tinhtrangAccount.ReadOnly = true;
            this.tinhtrangAccount.Width = 60;
            // 
            // proxyAccount
            // 
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyAccount.DefaultCellStyle = dataGridViewCellStyle23;
            this.proxyAccount.HeaderText = "Proxy";
            this.proxyAccount.Name = "proxyAccount";
            this.proxyAccount.Width = 50;
            // 
            // lastactiveAccount
            // 
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastactiveAccount.DefaultCellStyle = dataGridViewCellStyle24;
            this.lastactiveAccount.HeaderText = "Last Active";
            this.lastactiveAccount.Name = "lastactiveAccount";
            this.lastactiveAccount.Width = 50;
            // 
            // tenfileAccount
            // 
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Navy;
            this.tenfileAccount.DefaultCellStyle = dataGridViewCellStyle25;
            this.tenfileAccount.HeaderText = "DM";
            this.tenfileAccount.Name = "tenfileAccount";
            this.tenfileAccount.Width = 60;
            // 
            // ghichuAccount
            // 
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ghichuAccount.DefaultCellStyle = dataGridViewCellStyle26;
            this.ghichuAccount.HeaderText = "Ghi chú";
            this.ghichuAccount.Name = "ghichuAccount";
            this.ghichuAccount.Width = 50;
            // 
            // buAccount
            // 
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buAccount.DefaultCellStyle = dataGridViewCellStyle27;
            this.buAccount.HeaderText = "Ngày BU";
            this.buAccount.Name = "buAccount";
            this.buAccount.Width = 60;
            // 
            // trangthaiAccount
            // 
            this.trangthaiAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trangthaiAccount.DefaultCellStyle = dataGridViewCellStyle28;
            this.trangthaiAccount.HeaderText = "Status";
            this.trangthaiAccount.Name = "trangthaiAccount";
            this.trangthaiAccount.ReadOnly = true;
            // 
            // featuresContextMenuStrip
            // 
            this.featuresContextMenuStrip.AllowDrop = true;
            this.featuresContextMenuStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresContextMenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.featuresContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAccountToolStripMenuItem,
            this.unSelectAccountToolStripMenuItem
            });
            this.featuresContextMenuStrip.Name = "featuresContextMenuStrip";
            this.featuresContextMenuStrip.Size = new System.Drawing.Size(245, 378);
            // 
            // loadingPictureBox
            // 
            this.loadingPictureBox.Location = new System.Drawing.Point(0, 0);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(100, 50);
            this.loadingPictureBox.TabIndex = 0;
            this.loadingPictureBox.TabStop = false;
            // 
            // contextMenuStripFeature
            // 
            this.featuresContextMenuStrip.AllowDrop = true;
            this.featuresContextMenuStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresContextMenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.featuresContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            //this.cHỌNACCOUNTToolStripMenuItem,
            //this.bỎCHỌNTẤTCẢToolStripMenuItem
            });
            this.featuresContextMenuStrip.Name = "contextMenuStripFeature";
            this.featuresContextMenuStrip.Size = new System.Drawing.Size(245, 378);
            //this.contextMenuStripFeature.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // selectAccountToolStripMenuItem
            // 
            this.selectAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAccountNowToolStripMenuItem,
            this.selectAllAccountToolStripMenuItem,
            this.selectLiveAccountToolStripMenuItem,
            this.selectDieAccountToolStripMenuItem,
            this.selectCheckpointAccountToolStripMenuItem,
            this.selectAllFileToolStripMenuItem
            });
            this.selectAccountToolStripMenuItem.Name = "selectAccountToolStripMenuItem";
            this.selectAccountToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.selectAccountToolStripMenuItem.Text = "CHỌN";
            //this.selectAccountToolStripMenuItem.Click += new System.EventHandler(this.cHỌNACCOUNTToolStripMenuItem_Click);
            // 
            // selectAccountNowToolStripMenuItem
            // 
            this.selectAccountNowToolStripMenuItem.Name = "selectAccountNowToolStripMenuItem";
            this.selectAccountNowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.selectAccountNowToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectAccountNowToolStripMenuItem.Text = "CHỌN DÒNG BÔI ĐEN";
            //this.selectAccountNowToolStripMenuItem.Click += new System.EventHandler(this.cHỌNDÒNGBÔIĐENToolStripMenuItem_Click);
            // 
            // selectAllAccountToolStripMenuItem
            // 
            this.selectAllAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectAllAccountToolStripMenuItem.Name = "selectAllAccountToolStripMenuItem";
            this.selectAllAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.selectAllAccountToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectAllAccountToolStripMenuItem.Text = "CHỌN TẤT CẢ";
            //this.selectAllAccountToolStripMenuItem.Click += new System.EventHandler(this.cHỌNTẤTCẢToolStripMenuItem_Click);
            // 
            // selectLiveAccountToolStripMenuItem
            // 
            this.selectLiveAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectLiveAccountToolStripMenuItem.Name = "selectLiveAccountToolStripMenuItem";
            this.selectLiveAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.selectLiveAccountToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectLiveAccountToolStripMenuItem.Text = "CHỌN ACC LIVE";
            //this.selectLiveAccountToolStripMenuItem.Click += new System.EventHandler(this.cHỌNACCLIVEToolStripMenuItem_Click);
            // 
            // selectDieAccountToolStripMenuItem
            // 
            this.selectDieAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectDieAccountToolStripMenuItem.Name = "selectDieAccountToolStripMenuItem";
            this.selectDieAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.selectDieAccountToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectDieAccountToolStripMenuItem.Text = "CHỌN ACC DIE";
            //this.selectDieAccountToolStripMenuItem.Click += new System.EventHandler(this.cHỌNACCDIEToolStripMenuItem_Click);
            // 
            // selectCheckpointAccountToolStripMenuItem
            // 
            this.selectCheckpointAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectCheckpointAccountToolStripMenuItem.Name = "selectCheckpointAccountToolStripMenuItem";
            this.selectCheckpointAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.selectCheckpointAccountToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectCheckpointAccountToolStripMenuItem.Text = "CHỌN ACC CHECKPOINT";
            //this.selectCheckpointAccountToolStripMenuItem.Click += new System.EventHandler(this.cHỌNACCCHECKPOINTToolStripMenuItem_Click);
            // 
            // selectAllFileToolStripMenuItem
            // 
            this.selectAllFileToolStripMenuItem.Name = "toolStripMenuItem1";
            this.selectAllFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.A)));
            this.selectAllFileToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectAllFileToolStripMenuItem.Text = "CHỌN ALL FILE";
            //this.selectAllFileToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // unSelectAccountToolStripMenuItem
            // 
            this.unSelectAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.unSelectAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unSelectAllAccountToolStripMenuItem});
            this.unSelectAccountToolStripMenuItem.Name = "unSelectAccountToolStripMenuItem";
            this.unSelectAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.D1)));
            this.unSelectAccountToolStripMenuItem.ShowShortcutKeys = false;
            this.unSelectAccountToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.unSelectAccountToolStripMenuItem.Text = "BỎ CHỌN";
            //this.unSelectAccountToolStripMenuItem.Click += new System.EventHandler(this.bỎCHỌNTẤTCẢToolStripMenuItem_Click);
            // 
            // unSelectAllAccountToolStripMenuItem
            // 
            this.unSelectAllAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.unSelectAllAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bỎCHỌNTẤTCẢToolStripMenuItem2.Image")));
            this.unSelectAllAccountToolStripMenuItem.Name = "unSelectAllAccountToolStripMenuItem";
            this.unSelectAllAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
            | System.Windows.Forms.Keys.D2)));
            this.unSelectAllAccountToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.unSelectAllAccountToolStripMenuItem.Text = "BỎ CHỌN TẤT CẢ";
            //this.unSelectAllAccountToolStripMenuItem.Click += new System.EventHandler(this.bỎCHỌNTẤTCẢToolStripMenuItem2_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoShop)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.doashBoardTabPage.ResumeLayout(false);
            this.doashBoardTabPage.PerformLayout();
            this.fileManagementGroupBox.ResumeLayout(false);
            this.fileManagementChild1GroupBox.ResumeLayout(false);
            this.fileManagementChild1GroupBox.PerformLayout();
            this.fileManagementChild2GroupBox.ResumeLayout(false);
            this.fileManagementChild2GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFileDataGridView)).EndInit();
            this.listFileContextMenuStrip.ResumeLayout(false);
            this.settingChormeGroupBox.ResumeLayout(false);
            this.detailListAccountsPanel.ResumeLayout(false);
            this.featuresContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailListAccountsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox settingChormeGroupBox;
        private System.Windows.Forms.Button turnOffChormeButton;
        private System.Windows.Forms.GroupBox checkViaGroupBox;
        private System.Windows.Forms.GroupBox backupGroupBox;
        private System.Windows.Forms.GroupBox passCheckPointGroupBox;
        private System.Windows.Forms.GroupBox fileManagementGroupBox;
        private System.Windows.Forms.GroupBox fileManagementChild1GroupBox;
        private System.Windows.Forms.GroupBox fileManagementChild2GroupBox;
        private System.Windows.Forms.Label fileManagementLabel;
        private System.Windows.Forms.Label importFileLabel;
        private System.Windows.Forms.TextBox importFileTextBox;
        private System.Windows.Forms.Label createFileLabel;
        private System.Windows.Forms.TextBox createFileTextBox;
        private System.Windows.Forms.Label statusFilterLabel;
        private System.Windows.Forms.ComboBox statusFilterComboBox;
        private System.Windows.Forms.Label readAllFileLabel;
        private System.Windows.Forms.Button readAllFileButton;
        private System.Windows.Forms.DataGridView listFileDataGridView;
        private System.Windows.Forms.ContextMenuStrip listFileContextMenuStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn listFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TextBox itemFileDetail;
        private System.Windows.Forms.Panel detailListAccountsPanel;
        private System.Windows.Forms.DataGridView detailListAccountsDataGridView;
        private System.Windows.Forms.PictureBox loadingPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttAccount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkboxItemAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn passAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn code2faAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookieAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn cookieldAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tokenldAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn passmailAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn namtaoAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn friendsAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupsAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastactiveAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenfileAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichuAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn buAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthaiAccount;
        private System.Windows.Forms.ContextMenuStrip featuresContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem selectAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAccountNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectLiveAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectDieAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCheckpointAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unSelectAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unSelectAllAccountToolStripMenuItem;
    }
}

