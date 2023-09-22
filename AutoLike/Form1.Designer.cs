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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolBar = new System.Windows.Forms.Panel();
            this.pictureBoxLogoShop = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.lableContact = new System.Windows.Forms.Label();
            this.labelAppName = new System.Windows.Forms.Label();
            this.lablePhoneContact = new System.Windows.Forms.Label();
            this.listFileContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNameFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAccountNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectLiveAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectDieAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCheckpointAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSelectAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSelectAllAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLoginCookieTOkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regAndSeedingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadingPictureBox = new System.Windows.Forms.PictureBox();
            this.doashBoardHScrollBar = new System.Windows.Forms.HScrollBar();
            this.totalAccountLabel = new System.Windows.Forms.Label();
            this.totalAccountLiveLabel = new System.Windows.Forms.Label();
            this.totalAccountDieLabel = new System.Windows.Forms.Label();
            this.totalAccountSelectedLabel = new System.Windows.Forms.Label();
            this.totalAccountValueLabel = new System.Windows.Forms.Label();
            this.totalAccountLiveValueLabel = new System.Windows.Forms.Label();
            this.totalAccountDieValueLabel = new System.Windows.Forms.Label();
            this.totalAccountSelectedValueLabel = new System.Windows.Forms.Label();
            this.regAndSeedingTabPage = new System.Windows.Forms.TabPage();
            this.seedingPageGroupBox = new System.Windows.Forms.GroupBox();
            this.changePageToUidButton = new System.Windows.Forms.Button();
            this.sType2SeedingPageCheckbox = new System.Windows.Forms.CheckBox();
            this.startWithSeedingWithPageButton = new System.Windows.Forms.Button();
            this.startWithSeedingWithUidButton = new System.Windows.Forms.Button();
            this.saveSeetingSeedingPageButton = new System.Windows.Forms.Button();
            this.contentShareSeedingPageTextBox = new System.Windows.Forms.TextBox();
            this.saveContentShareSeedingPageButton = new System.Windows.Forms.Button();
            this.attentionShareSeedingPageLabel = new System.Windows.Forms.Label();
            this.contentShareSeedingPageLabel = new System.Windows.Forms.Label();
            this.contentCommentSeedingPageLabel = new System.Windows.Forms.Label();
            this.saveContentSeedingPageButton = new System.Windows.Forms.Button();
            this.contentCommentSeedingPageTextBox = new System.Windows.Forms.TextBox();
            this.attentionContentSeedingPageLabel = new System.Windows.Forms.Label();
            this.timeGetNumBerNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeGetUidSeedingPageLabel = new System.Windows.Forms.Label();
            this.keyGetUidSeedingPageTextBox = new System.Windows.Forms.TextBox();
            this.keyGetUidSeedingPageLabel = new System.Windows.Forms.Label();
            this.getUidSeedingPageCheckBox = new System.Windows.Forms.CheckBox();
            this.shareWallSeedingPageCheckBox = new System.Windows.Forms.CheckBox();
            this.shareGroupSeedingPageCheckBox = new System.Windows.Forms.CheckBox();
            this.attentionSeedingPageLabel = new System.Windows.Forms.Label();
            this.uidSeedingPageTextBox = new System.Windows.Forms.TextBox();
            this.uidSeedingPageLabel = new System.Windows.Forms.Label();
            this.followSeedingPageCheckBox = new System.Windows.Forms.CheckBox();
            this.commentSeedingPageCheckBox = new System.Windows.Forms.CheckBox();
            this.likePageSeedingPageCheckBox = new System.Windows.Forms.CheckBox();
            this.likePostSeedingPageCheckBox = new System.Windows.Forms.CheckBox();
            this.regPageGroupBox = new System.Windows.Forms.GroupBox();
            this.startRegPageButton = new System.Windows.Forms.Button();
            this.setRuleAdminRegPageCheckBox = new System.Windows.Forms.CheckBox();
            this.selectPathAvatarPageButton = new System.Windows.Forms.Button();
            this.selectPathAvatarPageTextBox = new System.Windows.Forms.TextBox();
            this.selectPathAvatarPageLabel = new System.Windows.Forms.Label();
            this.selectAvatarPageLabel = new System.Windows.Forms.Label();
            this.selectPathNamePageButton = new System.Windows.Forms.Button();
            this.selectPathNamePageLabel = new System.Windows.Forms.Label();
            this.selectPathNamePageTextBox = new System.Windows.Forms.TextBox();
            this.namePageLabel = new System.Windows.Forms.Label();
            this.generalSettingTabPage = new System.Windows.Forms.TabPage();
            this.generalSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.savegeneralSettingButton = new System.Windows.Forms.Button();
            this.apiKeyTextBox = new System.Windows.Forms.TextBox();
            this.apiKeyLabel = new System.Windows.Forms.Label();
            this.pathProfileChromeGroupBox = new System.Windows.Forms.GroupBox();
            this.pathProfileChromeLabel = new System.Windows.Forms.Label();
            this.selectPathProfileChromeLabel = new System.Windows.Forms.Label();
            this.selectPathProfileChromeTextBox = new System.Windows.Forms.TextBox();
            this.selectPathProfileChromeButton = new System.Windows.Forms.Button();
            this.generalSetingUserProxyComboBox = new System.Windows.Forms.ComboBox();
            this.generalSetingUserProxyLabel = new System.Windows.Forms.Label();
            this.generalSetingResetIpLabel = new System.Windows.Forms.Label();
            this.generalSetingResetIpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generalSetingResetIpCheckBox = new System.Windows.Forms.CheckBox();
            this.generalSettingflowNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.generalSettingflowNumberLabel = new System.Windows.Forms.Label();
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
            this.itemFileDetail = new System.Windows.Forms.TextBox();
            this.passCheckPointGroupBox = new System.Windows.Forms.GroupBox();
            this.backupGroupBox = new System.Windows.Forms.GroupBox();
            this.checkViaGroupBox = new System.Windows.Forms.GroupBox();
            this.checkStatusCookieButton = new System.Windows.Forms.Button();
            this.getInfoAccountToken = new System.Windows.Forms.Button();
            this.getAccessTokenEAAGButton = new System.Windows.Forms.Button();
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
            this.pageNumberAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoShop)).BeginInit();
            this.listFileContextMenuStrip.SuspendLayout();
            this.featuresContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).BeginInit();
            this.regAndSeedingTabPage.SuspendLayout();
            this.seedingPageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeGetNumBerNumericUpDown)).BeginInit();
            this.regPageGroupBox.SuspendLayout();
            this.generalSettingTabPage.SuspendLayout();
            this.generalSettingGroupBox.SuspendLayout();
            this.pathProfileChromeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalSetingResetIpNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalSettingflowNumberNumericUpDown)).BeginInit();
            this.doashBoardTabPage.SuspendLayout();
            this.fileManagementGroupBox.SuspendLayout();
            this.fileManagementChild1GroupBox.SuspendLayout();
            this.fileManagementChild2GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFileDataGridView)).BeginInit();
            this.checkViaGroupBox.SuspendLayout();
            this.settingChormeGroupBox.SuspendLayout();
            this.detailListAccountsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailListAccountsDataGridView)).BeginInit();
            this.tabControl.SuspendLayout();
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
            // listFileContextMenuStrip
            // 
            this.listFileContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            // featuresContextMenuStrip
            // 
            this.featuresContextMenuStrip.AllowDrop = true;
            this.featuresContextMenuStrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.featuresContextMenuStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.featuresContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAccountToolStripMenuItem,
            this.unSelectAccountToolStripMenuItem,
            this.LoginToolStripMenuItem,
            this.featuresToolStripMenuItem});
            this.featuresContextMenuStrip.Name = "featuresContextMenuStrip";
            this.featuresContextMenuStrip.Size = new System.Drawing.Size(140, 92);
            // 
            // selectAccountToolStripMenuItem
            // 
            this.selectAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAccountNowToolStripMenuItem,
            this.selectAllAccountToolStripMenuItem,
            this.selectLiveAccountToolStripMenuItem,
            this.selectDieAccountToolStripMenuItem,
            this.selectCheckpointAccountToolStripMenuItem,
            this.selectAllFileToolStripMenuItem});
            this.selectAccountToolStripMenuItem.Name = "selectAccountToolStripMenuItem";
            this.selectAccountToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.selectAccountToolStripMenuItem.Text = "CHỌN";
            this.selectAccountToolStripMenuItem.Click += new System.EventHandler(this.selectAccountToolStripMenuItem_Click);
            // 
            // selectAccountNowToolStripMenuItem
            // 
            this.selectAccountNowToolStripMenuItem.Name = "selectAccountNowToolStripMenuItem";
            this.selectAccountNowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.selectAccountNowToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectAccountNowToolStripMenuItem.Text = "CHỌN DÒNG BÔI ĐEN";
            this.selectAccountNowToolStripMenuItem.Click += new System.EventHandler(this.selectAccountNowToolStripMenuItem_Click);
            // 
            // selectAllAccountToolStripMenuItem
            // 
            this.selectAllAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectAllAccountToolStripMenuItem.Name = "selectAllAccountToolStripMenuItem";
            this.selectAllAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.selectAllAccountToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectAllAccountToolStripMenuItem.Text = "CHỌN TẤT CẢ";
            this.selectAllAccountToolStripMenuItem.Click += new System.EventHandler(this.selectAllAccountToolStripMenuItem_Click);
            // 
            // selectLiveAccountToolStripMenuItem
            // 
            this.selectLiveAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectLiveAccountToolStripMenuItem.Name = "selectLiveAccountToolStripMenuItem";
            this.selectLiveAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.selectLiveAccountToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectLiveAccountToolStripMenuItem.Text = "CHỌN ACC LIVE";
            this.selectLiveAccountToolStripMenuItem.Click += new System.EventHandler(this.selectLiveAccountToolStripMenuItem_Click);
            // 
            // selectDieAccountToolStripMenuItem
            // 
            this.selectDieAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectDieAccountToolStripMenuItem.Name = "selectDieAccountToolStripMenuItem";
            this.selectDieAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.selectDieAccountToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectDieAccountToolStripMenuItem.Text = "CHỌN ACC DIE";
            this.selectDieAccountToolStripMenuItem.Click += new System.EventHandler(this.selectDieAccountToolStripMenuItem_Click);
            // 
            // selectCheckpointAccountToolStripMenuItem
            // 
            this.selectCheckpointAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.selectCheckpointAccountToolStripMenuItem.Name = "selectCheckpointAccountToolStripMenuItem";
            this.selectCheckpointAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.selectCheckpointAccountToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectCheckpointAccountToolStripMenuItem.Text = "CHỌN ACC CHECKPOINT";
            // 
            // selectAllFileToolStripMenuItem
            // 
            this.selectAllFileToolStripMenuItem.Name = "selectAllFileToolStripMenuItem";
            this.selectAllFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.selectAllFileToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.selectAllFileToolStripMenuItem.Text = "CHỌN ALL FILE";
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
            this.unSelectAccountToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.unSelectAccountToolStripMenuItem.Text = "BỎ CHỌN";
            this.unSelectAccountToolStripMenuItem.Click += new System.EventHandler(this.unSelectAccountToolStripMenuItem_Click);
            // 
            // unSelectAllAccountToolStripMenuItem
            // 
            this.unSelectAllAccountToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.unSelectAllAccountToolStripMenuItem.Name = "unSelectAllAccountToolStripMenuItem";
            this.unSelectAllAccountToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D2)));
            this.unSelectAllAccountToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.unSelectAllAccountToolStripMenuItem.Text = "BỎ CHỌN TẤT CẢ";
            this.unSelectAllAccountToolStripMenuItem.Click += new System.EventHandler(this.unSelectAllAccountToolStripMenuItem_Click);
            // 
            // LoginToolStripMenuItem
            // 
            this.LoginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flowLoginCookieTOkenToolStripMenuItem});
            this.LoginToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem";
            this.LoginToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.LoginToolStripMenuItem.Text = "ĐĂNG NHẬP";
            // 
            // flowLoginCookieTOkenToolStripMenuItem
            // 
            this.flowLoginCookieTOkenToolStripMenuItem.Name = "flowLoginCookieTOkenToolStripMenuItem";
            this.flowLoginCookieTOkenToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.flowLoginCookieTOkenToolStripMenuItem.Text = "Tạo Profile(Cookie-Token)";
            this.flowLoginCookieTOkenToolStripMenuItem.Click += new System.EventHandler(this.flowLoginCookieTOkenToolStripMenuItem_Click);
            // 
            // featuresToolStripMenuItem
            // 
            this.featuresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regAndSeedingToolStripMenuItem});
            this.featuresToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.featuresToolStripMenuItem.ForeColor = System.Drawing.Color.DarkGreen;
            this.featuresToolStripMenuItem.Name = "featuresToolStripMenuItem";
            this.featuresToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.featuresToolStripMenuItem.Text = "FEATURES";
            // 
            // regAndSeedingToolStripMenuItem
            // 
            this.regAndSeedingToolStripMenuItem.Name = "regAndSeedingToolStripMenuItem";
            this.regAndSeedingToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.regAndSeedingToolStripMenuItem.Text = "REG & SEEDING PAGE";
            this.regAndSeedingToolStripMenuItem.Click += new System.EventHandler(this.regAndSeedingToolStripMenuItem_Click);
            // 
            // loadingPictureBox
            // 
            this.loadingPictureBox.Location = new System.Drawing.Point(0, 0);
            this.loadingPictureBox.Name = "loadingPictureBox";
            this.loadingPictureBox.Size = new System.Drawing.Size(100, 50);
            this.loadingPictureBox.TabIndex = 0;
            this.loadingPictureBox.TabStop = false;
            // 
            // doashBoardHScrollBar
            // 
            this.doashBoardHScrollBar.Location = new System.Drawing.Point(9, 824);
            this.doashBoardHScrollBar.Maximum = 200;
            this.doashBoardHScrollBar.Name = "doashBoardHScrollBar";
            this.doashBoardHScrollBar.Size = new System.Drawing.Size(1662, 17);
            this.doashBoardHScrollBar.TabIndex = 41;
            this.doashBoardHScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.doashBoardHScrollBar_Scroll);
            // 
            // totalAccountLabel
            // 
            this.totalAccountLabel.AutoSize = true;
            this.totalAccountLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.totalAccountLabel.ForeColor = System.Drawing.Color.SlateBlue;
            this.totalAccountLabel.Location = new System.Drawing.Point(622, 847);
            this.totalAccountLabel.Name = "totalAccountLabel";
            this.totalAccountLabel.Size = new System.Drawing.Size(78, 13);
            this.totalAccountLabel.TabIndex = 31;
            this.totalAccountLabel.Text = "*TỔNG ACC : ";
            // 
            // totalAccountLiveLabel
            // 
            this.totalAccountLiveLabel.AutoSize = true;
            this.totalAccountLiveLabel.BackColor = System.Drawing.Color.LimeGreen;
            this.totalAccountLiveLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.totalAccountLiveLabel.ForeColor = System.Drawing.Color.White;
            this.totalAccountLiveLabel.Location = new System.Drawing.Point(733, 847);
            this.totalAccountLiveLabel.Name = "totalAccountLiveLabel";
            this.totalAccountLiveLabel.Size = new System.Drawing.Size(36, 13);
            this.totalAccountLiveLabel.TabIndex = 33;
            this.totalAccountLiveLabel.Text = "Live :";
            // 
            // totalAccountDieLabel
            // 
            this.totalAccountDieLabel.AutoSize = true;
            this.totalAccountDieLabel.BackColor = System.Drawing.Color.IndianRed;
            this.totalAccountDieLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.totalAccountDieLabel.ForeColor = System.Drawing.Color.White;
            this.totalAccountDieLabel.Location = new System.Drawing.Point(812, 847);
            this.totalAccountDieLabel.Name = "totalAccountDieLabel";
            this.totalAccountDieLabel.Size = new System.Drawing.Size(31, 13);
            this.totalAccountDieLabel.TabIndex = 34;
            this.totalAccountDieLabel.Text = "Die :";
            // 
            // totalAccountSelectedLabel
            // 
            this.totalAccountSelectedLabel.AutoSize = true;
            this.totalAccountSelectedLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.totalAccountSelectedLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.totalAccountSelectedLabel.Location = new System.Drawing.Point(882, 847);
            this.totalAccountSelectedLabel.Name = "totalAccountSelectedLabel";
            this.totalAccountSelectedLabel.Size = new System.Drawing.Size(66, 13);
            this.totalAccountSelectedLabel.TabIndex = 32;
            this.totalAccountSelectedLabel.Text = "*Đã chọn :";
            // 
            // totalAccountValueLabel
            // 
            this.totalAccountValueLabel.AutoSize = true;
            this.totalAccountValueLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.totalAccountValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalAccountValueLabel.Location = new System.Drawing.Point(692, 847);
            this.totalAccountValueLabel.Name = "totalAccountValueLabel";
            this.totalAccountValueLabel.Size = new System.Drawing.Size(16, 13);
            this.totalAccountValueLabel.TabIndex = 38;
            this.totalAccountValueLabel.Text = "...";
            // 
            // totalAccountLiveValueLabel
            // 
            this.totalAccountLiveValueLabel.AutoSize = true;
            this.totalAccountLiveValueLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.totalAccountLiveValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalAccountLiveValueLabel.Location = new System.Drawing.Point(774, 847);
            this.totalAccountLiveValueLabel.Name = "totalAccountLiveValueLabel";
            this.totalAccountLiveValueLabel.Size = new System.Drawing.Size(16, 13);
            this.totalAccountLiveValueLabel.TabIndex = 35;
            this.totalAccountLiveValueLabel.Text = "...";
            // 
            // totalAccountDieValueLabel
            // 
            this.totalAccountDieValueLabel.AutoSize = true;
            this.totalAccountDieValueLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.totalAccountDieValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalAccountDieValueLabel.Location = new System.Drawing.Point(852, 847);
            this.totalAccountDieValueLabel.Name = "totalAccountDieValueLabel";
            this.totalAccountDieValueLabel.Size = new System.Drawing.Size(16, 13);
            this.totalAccountDieValueLabel.TabIndex = 36;
            this.totalAccountDieValueLabel.Text = "...";
            // 
            // totalAccountSelectedValueLabel
            // 
            this.totalAccountSelectedValueLabel.AutoSize = true;
            this.totalAccountSelectedValueLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.totalAccountSelectedValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.totalAccountSelectedValueLabel.Location = new System.Drawing.Point(947, 847);
            this.totalAccountSelectedValueLabel.Name = "totalAccountSelectedValueLabel";
            this.totalAccountSelectedValueLabel.Size = new System.Drawing.Size(16, 13);
            this.totalAccountSelectedValueLabel.TabIndex = 37;
            this.totalAccountSelectedValueLabel.Text = "...";
            // 
            // regAndSeedingTabPage
            // 
            this.regAndSeedingTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(151)))), ((int)(((byte)(153)))));
            this.regAndSeedingTabPage.Controls.Add(this.seedingPageGroupBox);
            this.regAndSeedingTabPage.Controls.Add(this.regPageGroupBox);
            this.regAndSeedingTabPage.ForeColor = System.Drawing.Color.White;
            this.regAndSeedingTabPage.Location = new System.Drawing.Point(4, 34);
            this.regAndSeedingTabPage.Name = "regAndSeedingTabPage";
            this.regAndSeedingTabPage.Size = new System.Drawing.Size(1664, 749);
            this.regAndSeedingTabPage.TabIndex = 15;
            this.regAndSeedingTabPage.Text = "Reg & Seeding Page";
            this.regAndSeedingTabPage.UseVisualStyleBackColor = true;
            // 
            // seedingPageGroupBox
            // 
            this.seedingPageGroupBox.BackColor = System.Drawing.Color.White;
            this.seedingPageGroupBox.Controls.Add(this.changePageToUidButton);
            this.seedingPageGroupBox.Controls.Add(this.sType2SeedingPageCheckbox);
            this.seedingPageGroupBox.Controls.Add(this.startWithSeedingWithPageButton);
            this.seedingPageGroupBox.Controls.Add(this.startWithSeedingWithUidButton);
            this.seedingPageGroupBox.Controls.Add(this.saveSeetingSeedingPageButton);
            this.seedingPageGroupBox.Controls.Add(this.contentShareSeedingPageTextBox);
            this.seedingPageGroupBox.Controls.Add(this.saveContentShareSeedingPageButton);
            this.seedingPageGroupBox.Controls.Add(this.attentionShareSeedingPageLabel);
            this.seedingPageGroupBox.Controls.Add(this.contentShareSeedingPageLabel);
            this.seedingPageGroupBox.Controls.Add(this.contentCommentSeedingPageLabel);
            this.seedingPageGroupBox.Controls.Add(this.saveContentSeedingPageButton);
            this.seedingPageGroupBox.Controls.Add(this.contentCommentSeedingPageTextBox);
            this.seedingPageGroupBox.Controls.Add(this.attentionContentSeedingPageLabel);
            this.seedingPageGroupBox.Controls.Add(this.timeGetNumBerNumericUpDown);
            this.seedingPageGroupBox.Controls.Add(this.timeGetUidSeedingPageLabel);
            this.seedingPageGroupBox.Controls.Add(this.keyGetUidSeedingPageTextBox);
            this.seedingPageGroupBox.Controls.Add(this.keyGetUidSeedingPageLabel);
            this.seedingPageGroupBox.Controls.Add(this.getUidSeedingPageCheckBox);
            this.seedingPageGroupBox.Controls.Add(this.shareWallSeedingPageCheckBox);
            this.seedingPageGroupBox.Controls.Add(this.shareGroupSeedingPageCheckBox);
            this.seedingPageGroupBox.Controls.Add(this.attentionSeedingPageLabel);
            this.seedingPageGroupBox.Controls.Add(this.uidSeedingPageTextBox);
            this.seedingPageGroupBox.Controls.Add(this.uidSeedingPageLabel);
            this.seedingPageGroupBox.Controls.Add(this.followSeedingPageCheckBox);
            this.seedingPageGroupBox.Controls.Add(this.commentSeedingPageCheckBox);
            this.seedingPageGroupBox.Controls.Add(this.likePageSeedingPageCheckBox);
            this.seedingPageGroupBox.Controls.Add(this.likePostSeedingPageCheckBox);
            this.seedingPageGroupBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seedingPageGroupBox.Location = new System.Drawing.Point(596, 23);
            this.seedingPageGroupBox.Name = "seedingPageGroupBox";
            this.seedingPageGroupBox.Size = new System.Drawing.Size(935, 651);
            this.seedingPageGroupBox.TabIndex = 2;
            this.seedingPageGroupBox.TabStop = false;
            this.seedingPageGroupBox.Text = "Seeding";
            // 
            // changePageToUidButton
            // 
            this.changePageToUidButton.BackColor = System.Drawing.Color.DarkCyan;
            this.changePageToUidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePageToUidButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePageToUidButton.ForeColor = System.Drawing.Color.White;
            this.changePageToUidButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changePageToUidButton.Location = new System.Drawing.Point(240, 582);
            this.changePageToUidButton.Name = "changePageToUidButton";
            this.changePageToUidButton.Size = new System.Drawing.Size(153, 31);
            this.changePageToUidButton.TabIndex = 102;
            this.changePageToUidButton.Text = "Chuyển PAGE về UID";
            this.changePageToUidButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changePageToUidButton.UseVisualStyleBackColor = false;
            this.changePageToUidButton.Click += new System.EventHandler(this.changePageToUidButton_Click);
            // 
            // sType2SeedingPageCheckbox
            // 
            this.sType2SeedingPageCheckbox.AutoSize = true;
            this.sType2SeedingPageCheckbox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sType2SeedingPageCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sType2SeedingPageCheckbox.Location = new System.Drawing.Point(444, 41);
            this.sType2SeedingPageCheckbox.Name = "sType2SeedingPageCheckbox";
            this.sType2SeedingPageCheckbox.Size = new System.Drawing.Size(66, 17);
            this.sType2SeedingPageCheckbox.TabIndex = 101;
            this.sType2SeedingPageCheckbox.Text = "Stype2";
            this.sType2SeedingPageCheckbox.UseVisualStyleBackColor = true;
            // 
            // startWithSeedingWithPageButton
            // 
            this.startWithSeedingWithPageButton.BackColor = System.Drawing.Color.ForestGreen;
            this.startWithSeedingWithPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startWithSeedingWithPageButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.startWithSeedingWithPageButton.ForeColor = System.Drawing.Color.White;
            this.startWithSeedingWithPageButton.Location = new System.Drawing.Point(720, 581);
            this.startWithSeedingWithPageButton.Name = "startWithSeedingWithPageButton";
            this.startWithSeedingWithPageButton.Size = new System.Drawing.Size(179, 32);
            this.startWithSeedingWithPageButton.TabIndex = 100;
            this.startWithSeedingWithPageButton.Text = "START SEEDING WITH PAGE";
            this.startWithSeedingWithPageButton.UseVisualStyleBackColor = false;
            this.startWithSeedingWithPageButton.Click += new System.EventHandler(this.startWithSeedingWithPageButton_Click);
            // 
            // startWithSeedingWithUidButton
            // 
            this.startWithSeedingWithUidButton.BackColor = System.Drawing.Color.ForestGreen;
            this.startWithSeedingWithUidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startWithSeedingWithUidButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.startWithSeedingWithUidButton.ForeColor = System.Drawing.Color.White;
            this.startWithSeedingWithUidButton.Location = new System.Drawing.Point(501, 581);
            this.startWithSeedingWithUidButton.Name = "startWithSeedingWithUidButton";
            this.startWithSeedingWithUidButton.Size = new System.Drawing.Size(179, 32);
            this.startWithSeedingWithUidButton.TabIndex = 99;
            this.startWithSeedingWithUidButton.Text = "START SEEDING WITH UID";
            this.startWithSeedingWithUidButton.UseVisualStyleBackColor = false;
            // 
            // saveSeetingSeedingPageButton
            // 
            this.saveSeetingSeedingPageButton.BackColor = System.Drawing.Color.DarkCyan;
            this.saveSeetingSeedingPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveSeetingSeedingPageButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveSeetingSeedingPageButton.ForeColor = System.Drawing.Color.White;
            this.saveSeetingSeedingPageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveSeetingSeedingPageButton.Location = new System.Drawing.Point(22, 582);
            this.saveSeetingSeedingPageButton.Name = "saveSeetingSeedingPageButton";
            this.saveSeetingSeedingPageButton.Size = new System.Drawing.Size(120, 31);
            this.saveSeetingSeedingPageButton.TabIndex = 98;
            this.saveSeetingSeedingPageButton.Text = "Lưu Cài đặt";
            this.saveSeetingSeedingPageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveSeetingSeedingPageButton.UseVisualStyleBackColor = false;
            // 
            // contentShareSeedingPageTextBox
            // 
            this.contentShareSeedingPageTextBox.ForeColor = System.Drawing.Color.Gray;
            this.contentShareSeedingPageTextBox.Location = new System.Drawing.Point(492, 336);
            this.contentShareSeedingPageTextBox.Multiline = true;
            this.contentShareSeedingPageTextBox.Name = "contentShareSeedingPageTextBox";
            this.contentShareSeedingPageTextBox.Size = new System.Drawing.Size(407, 187);
            this.contentShareSeedingPageTextBox.TabIndex = 97;
            // 
            // saveContentShareSeedingPageButton
            // 
            this.saveContentShareSeedingPageButton.BackColor = System.Drawing.Color.DarkCyan;
            this.saveContentShareSeedingPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveContentShareSeedingPageButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveContentShareSeedingPageButton.ForeColor = System.Drawing.Color.White;
            this.saveContentShareSeedingPageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveContentShareSeedingPageButton.Location = new System.Drawing.Point(779, 299);
            this.saveContentShareSeedingPageButton.Name = "saveContentShareSeedingPageButton";
            this.saveContentShareSeedingPageButton.Size = new System.Drawing.Size(120, 31);
            this.saveContentShareSeedingPageButton.TabIndex = 96;
            this.saveContentShareSeedingPageButton.Text = " Lưu Nội dung";
            this.saveContentShareSeedingPageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveContentShareSeedingPageButton.UseVisualStyleBackColor = false;
            // 
            // attentionShareSeedingPageLabel
            // 
            this.attentionShareSeedingPageLabel.AutoSize = true;
            this.attentionShareSeedingPageLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attentionShareSeedingPageLabel.ForeColor = System.Drawing.Color.Teal;
            this.attentionShareSeedingPageLabel.Location = new System.Drawing.Point(603, 308);
            this.attentionShareSeedingPageLabel.Name = "attentionShareSeedingPageLabel";
            this.attentionShareSeedingPageLabel.Size = new System.Drawing.Size(142, 14);
            this.attentionShareSeedingPageLabel.TabIndex = 95;
            this.attentionShareSeedingPageLabel.Text = "*Mỗi nội dung một dòng";
            // 
            // contentShareSeedingPageLabel
            // 
            this.contentShareSeedingPageLabel.AutoSize = true;
            this.contentShareSeedingPageLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentShareSeedingPageLabel.ForeColor = System.Drawing.Color.Teal;
            this.contentShareSeedingPageLabel.Location = new System.Drawing.Point(489, 308);
            this.contentShareSeedingPageLabel.Name = "contentShareSeedingPageLabel";
            this.contentShareSeedingPageLabel.Size = new System.Drawing.Size(91, 13);
            this.contentShareSeedingPageLabel.TabIndex = 94;
            this.contentShareSeedingPageLabel.Text = "Nội dung Share";
            // 
            // contentCommentSeedingPageLabel
            // 
            this.contentCommentSeedingPageLabel.AutoSize = true;
            this.contentCommentSeedingPageLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentCommentSeedingPageLabel.ForeColor = System.Drawing.Color.Teal;
            this.contentCommentSeedingPageLabel.Location = new System.Drawing.Point(19, 304);
            this.contentCommentSeedingPageLabel.Name = "contentCommentSeedingPageLabel";
            this.contentCommentSeedingPageLabel.Size = new System.Drawing.Size(113, 13);
            this.contentCommentSeedingPageLabel.TabIndex = 90;
            this.contentCommentSeedingPageLabel.Text = "Nội dung Comment";
            // 
            // saveContentSeedingPageButton
            // 
            this.saveContentSeedingPageButton.BackColor = System.Drawing.Color.DarkCyan;
            this.saveContentSeedingPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveContentSeedingPageButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveContentSeedingPageButton.ForeColor = System.Drawing.Color.White;
            this.saveContentSeedingPageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveContentSeedingPageButton.Location = new System.Drawing.Point(313, 299);
            this.saveContentSeedingPageButton.Name = "saveContentSeedingPageButton";
            this.saveContentSeedingPageButton.Size = new System.Drawing.Size(120, 31);
            this.saveContentSeedingPageButton.TabIndex = 92;
            this.saveContentSeedingPageButton.Text = " Lưu Nội dung";
            this.saveContentSeedingPageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveContentSeedingPageButton.UseVisualStyleBackColor = false;
            // 
            // contentCommentSeedingPageTextBox
            // 
            this.contentCommentSeedingPageTextBox.ForeColor = System.Drawing.Color.Gray;
            this.contentCommentSeedingPageTextBox.Location = new System.Drawing.Point(22, 336);
            this.contentCommentSeedingPageTextBox.Multiline = true;
            this.contentCommentSeedingPageTextBox.Name = "contentCommentSeedingPageTextBox";
            this.contentCommentSeedingPageTextBox.Size = new System.Drawing.Size(411, 187);
            this.contentCommentSeedingPageTextBox.TabIndex = 93;
            // 
            // attentionContentSeedingPageLabel
            // 
            this.attentionContentSeedingPageLabel.AutoSize = true;
            this.attentionContentSeedingPageLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attentionContentSeedingPageLabel.ForeColor = System.Drawing.Color.Teal;
            this.attentionContentSeedingPageLabel.Location = new System.Drawing.Point(146, 304);
            this.attentionContentSeedingPageLabel.Name = "attentionContentSeedingPageLabel";
            this.attentionContentSeedingPageLabel.Size = new System.Drawing.Size(142, 14);
            this.attentionContentSeedingPageLabel.TabIndex = 91;
            this.attentionContentSeedingPageLabel.Text = "*Mỗi nội dung một dòng";
            // 
            // timeGetNumBerNumericUpDown
            // 
            this.timeGetNumBerNumericUpDown.Location = new System.Drawing.Point(629, 135);
            this.timeGetNumBerNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timeGetNumBerNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeGetNumBerNumericUpDown.Name = "timeGetNumBerNumericUpDown";
            this.timeGetNumBerNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.timeGetNumBerNumericUpDown.TabIndex = 89;
            this.timeGetNumBerNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // timeGetUidSeedingPageLabel
            // 
            this.timeGetUidSeedingPageLabel.AutoSize = true;
            this.timeGetUidSeedingPageLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeGetUidSeedingPageLabel.ForeColor = System.Drawing.Color.Teal;
            this.timeGetUidSeedingPageLabel.Location = new System.Drawing.Point(538, 137);
            this.timeGetUidSeedingPageLabel.Name = "timeGetUidSeedingPageLabel";
            this.timeGetUidSeedingPageLabel.Size = new System.Drawing.Size(58, 13);
            this.timeGetUidSeedingPageLabel.TabIndex = 88;
            this.timeGetUidSeedingPageLabel.Text = "Time Get";
            // 
            // keyGetUidSeedingPageTextBox
            // 
            this.keyGetUidSeedingPageTextBox.Location = new System.Drawing.Point(606, 87);
            this.keyGetUidSeedingPageTextBox.Name = "keyGetUidSeedingPageTextBox";
            this.keyGetUidSeedingPageTextBox.Size = new System.Drawing.Size(157, 20);
            this.keyGetUidSeedingPageTextBox.TabIndex = 87;
            // 
            // keyGetUidSeedingPageLabel
            // 
            this.keyGetUidSeedingPageLabel.AutoSize = true;
            this.keyGetUidSeedingPageLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyGetUidSeedingPageLabel.ForeColor = System.Drawing.Color.Teal;
            this.keyGetUidSeedingPageLabel.Location = new System.Drawing.Point(538, 87);
            this.keyGetUidSeedingPageLabel.Name = "keyGetUidSeedingPageLabel";
            this.keyGetUidSeedingPageLabel.Size = new System.Drawing.Size(28, 13);
            this.keyGetUidSeedingPageLabel.TabIndex = 86;
            this.keyGetUidSeedingPageLabel.Text = "Key";
            // 
            // getUidSeedingPageCheckBox
            // 
            this.getUidSeedingPageCheckBox.AutoSize = true;
            this.getUidSeedingPageCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getUidSeedingPageCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.getUidSeedingPageCheckBox.Location = new System.Drawing.Point(541, 41);
            this.getUidSeedingPageCheckBox.Name = "getUidSeedingPageCheckBox";
            this.getUidSeedingPageCheckBox.Size = new System.Drawing.Size(115, 17);
            this.getUidSeedingPageCheckBox.TabIndex = 85;
            this.getUidSeedingPageCheckBox.Text = "GET UID từ SITE";
            this.getUidSeedingPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // shareWallSeedingPageCheckBox
            // 
            this.shareWallSeedingPageCheckBox.AutoSize = true;
            this.shareWallSeedingPageCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareWallSeedingPageCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.shareWallSeedingPageCheckBox.Location = new System.Drawing.Point(337, 150);
            this.shareWallSeedingPageCheckBox.Name = "shareWallSeedingPageCheckBox";
            this.shareWallSeedingPageCheckBox.Size = new System.Drawing.Size(113, 17);
            this.shareWallSeedingPageCheckBox.TabIndex = 84;
            this.shareWallSeedingPageCheckBox.Text = "Share về tường";
            this.shareWallSeedingPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // shareGroupSeedingPageCheckBox
            // 
            this.shareGroupSeedingPageCheckBox.AutoSize = true;
            this.shareGroupSeedingPageCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.shareGroupSeedingPageCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareGroupSeedingPageCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.shareGroupSeedingPageCheckBox.Location = new System.Drawing.Point(337, 96);
            this.shareGroupSeedingPageCheckBox.Name = "shareGroupSeedingPageCheckBox";
            this.shareGroupSeedingPageCheckBox.Size = new System.Drawing.Size(96, 17);
            this.shareGroupSeedingPageCheckBox.TabIndex = 83;
            this.shareGroupSeedingPageCheckBox.Text = "Share Group";
            this.shareGroupSeedingPageCheckBox.UseVisualStyleBackColor = false;
            // 
            // attentionSeedingPageLabel
            // 
            this.attentionSeedingPageLabel.AutoSize = true;
            this.attentionSeedingPageLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attentionSeedingPageLabel.ForeColor = System.Drawing.Color.Teal;
            this.attentionSeedingPageLabel.Location = new System.Drawing.Point(89, 95);
            this.attentionSeedingPageLabel.Name = "attentionSeedingPageLabel";
            this.attentionSeedingPageLabel.Size = new System.Drawing.Size(206, 14);
            this.attentionSeedingPageLabel.TabIndex = 81;
            this.attentionSeedingPageLabel.Text = "*Mỗi hàng 1 UID nếu Like nhiều UID";
            // 
            // uidSeedingPageTextBox
            // 
            this.uidSeedingPageTextBox.Location = new System.Drawing.Point(92, 123);
            this.uidSeedingPageTextBox.Multiline = true;
            this.uidSeedingPageTextBox.Name = "uidSeedingPageTextBox";
            this.uidSeedingPageTextBox.Size = new System.Drawing.Size(196, 82);
            this.uidSeedingPageTextBox.TabIndex = 80;
            // 
            // uidSeedingPageLabel
            // 
            this.uidSeedingPageLabel.AutoSize = true;
            this.uidSeedingPageLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidSeedingPageLabel.ForeColor = System.Drawing.Color.Teal;
            this.uidSeedingPageLabel.Location = new System.Drawing.Point(19, 96);
            this.uidSeedingPageLabel.Name = "uidSeedingPageLabel";
            this.uidSeedingPageLabel.Size = new System.Drawing.Size(28, 13);
            this.uidSeedingPageLabel.TabIndex = 79;
            this.uidSeedingPageLabel.Text = "UID";
            // 
            // followSeedingPageCheckBox
            // 
            this.followSeedingPageCheckBox.AutoSize = true;
            this.followSeedingPageCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followSeedingPageCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.followSeedingPageCheckBox.Location = new System.Drawing.Point(357, 41);
            this.followSeedingPageCheckBox.Name = "followSeedingPageCheckBox";
            this.followSeedingPageCheckBox.Size = new System.Drawing.Size(61, 17);
            this.followSeedingPageCheckBox.TabIndex = 78;
            this.followSeedingPageCheckBox.Text = "Follow";
            this.followSeedingPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // commentSeedingPageCheckBox
            // 
            this.commentSeedingPageCheckBox.AutoSize = true;
            this.commentSeedingPageCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentSeedingPageCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.commentSeedingPageCheckBox.Location = new System.Drawing.Point(239, 40);
            this.commentSeedingPageCheckBox.Name = "commentSeedingPageCheckBox";
            this.commentSeedingPageCheckBox.Size = new System.Drawing.Size(81, 17);
            this.commentSeedingPageCheckBox.TabIndex = 77;
            this.commentSeedingPageCheckBox.Text = "Comment";
            this.commentSeedingPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // likePageSeedingPageCheckBox
            // 
            this.likePageSeedingPageCheckBox.AutoSize = true;
            this.likePageSeedingPageCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likePageSeedingPageCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.likePageSeedingPageCheckBox.Location = new System.Drawing.Point(133, 37);
            this.likePageSeedingPageCheckBox.Name = "likePageSeedingPageCheckBox";
            this.likePageSeedingPageCheckBox.Size = new System.Drawing.Size(80, 17);
            this.likePageSeedingPageCheckBox.TabIndex = 76;
            this.likePageSeedingPageCheckBox.Text = "Like Page";
            this.likePageSeedingPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // likePostSeedingPageCheckBox
            // 
            this.likePostSeedingPageCheckBox.AutoSize = true;
            this.likePostSeedingPageCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likePostSeedingPageCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.likePostSeedingPageCheckBox.Location = new System.Drawing.Point(22, 37);
            this.likePostSeedingPageCheckBox.Name = "likePostSeedingPageCheckBox";
            this.likePostSeedingPageCheckBox.Size = new System.Drawing.Size(77, 17);
            this.likePostSeedingPageCheckBox.TabIndex = 1;
            this.likePostSeedingPageCheckBox.Text = "Like Post";
            this.likePostSeedingPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // regPageGroupBox
            // 
            this.regPageGroupBox.BackColor = System.Drawing.Color.White;
            this.regPageGroupBox.Controls.Add(this.startRegPageButton);
            this.regPageGroupBox.Controls.Add(this.setRuleAdminRegPageCheckBox);
            this.regPageGroupBox.Controls.Add(this.selectPathAvatarPageButton);
            this.regPageGroupBox.Controls.Add(this.selectPathAvatarPageTextBox);
            this.regPageGroupBox.Controls.Add(this.selectPathAvatarPageLabel);
            this.regPageGroupBox.Controls.Add(this.selectAvatarPageLabel);
            this.regPageGroupBox.Controls.Add(this.selectPathNamePageButton);
            this.regPageGroupBox.Controls.Add(this.selectPathNamePageLabel);
            this.regPageGroupBox.Controls.Add(this.selectPathNamePageTextBox);
            this.regPageGroupBox.Controls.Add(this.namePageLabel);
            this.regPageGroupBox.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regPageGroupBox.Location = new System.Drawing.Point(19, 23);
            this.regPageGroupBox.Name = "regPageGroupBox";
            this.regPageGroupBox.Size = new System.Drawing.Size(458, 535);
            this.regPageGroupBox.TabIndex = 1;
            this.regPageGroupBox.TabStop = false;
            this.regPageGroupBox.Text = "REG PAGE";
            // 
            // startRegPageButton
            // 
            this.startRegPageButton.BackColor = System.Drawing.Color.ForestGreen;
            this.startRegPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startRegPageButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.startRegPageButton.ForeColor = System.Drawing.Color.White;
            this.startRegPageButton.Location = new System.Drawing.Point(368, 471);
            this.startRegPageButton.Name = "startRegPageButton";
            this.startRegPageButton.Size = new System.Drawing.Size(64, 32);
            this.startRegPageButton.TabIndex = 80;
            this.startRegPageButton.Text = "START";
            this.startRegPageButton.UseVisualStyleBackColor = false;
            this.startRegPageButton.Click += new System.EventHandler(this.startRegPageButton_Click);
            // 
            // setRuleAdminRegPageCheckBox
            // 
            this.setRuleAdminRegPageCheckBox.AutoSize = true;
            this.setRuleAdminRegPageCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setRuleAdminRegPageCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.setRuleAdminRegPageCheckBox.Location = new System.Drawing.Point(28, 204);
            this.setRuleAdminRegPageCheckBox.Name = "setRuleAdminRegPageCheckBox";
            this.setRuleAdminRegPageCheckBox.Size = new System.Drawing.Size(123, 17);
            this.setRuleAdminRegPageCheckBox.TabIndex = 8;
            this.setRuleAdminRegPageCheckBox.Text = "Set Quyền Admin";
            this.setRuleAdminRegPageCheckBox.UseVisualStyleBackColor = true;
            // 
            // selectPathAvatarPageButton
            // 
            this.selectPathAvatarPageButton.BackColor = System.Drawing.Color.White;
            this.selectPathAvatarPageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPathAvatarPageButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPathAvatarPageButton.ForeColor = System.Drawing.Color.Black;
            this.selectPathAvatarPageButton.Location = new System.Drawing.Point(299, 150);
            this.selectPathAvatarPageButton.Name = "selectPathAvatarPageButton";
            this.selectPathAvatarPageButton.Size = new System.Drawing.Size(53, 33);
            this.selectPathAvatarPageButton.TabIndex = 7;
            this.selectPathAvatarPageButton.Text = "Mở";
            this.selectPathAvatarPageButton.UseVisualStyleBackColor = false;
            // 
            // selectPathAvatarPageTextBox
            // 
            this.selectPathAvatarPageTextBox.Location = new System.Drawing.Point(98, 155);
            this.selectPathAvatarPageTextBox.Name = "selectPathAvatarPageTextBox";
            this.selectPathAvatarPageTextBox.Size = new System.Drawing.Size(176, 20);
            this.selectPathAvatarPageTextBox.TabIndex = 6;
            // 
            // selectPathAvatarPageLabel
            // 
            this.selectPathAvatarPageLabel.AutoSize = true;
            this.selectPathAvatarPageLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPathAvatarPageLabel.ForeColor = System.Drawing.Color.Teal;
            this.selectPathAvatarPageLabel.Location = new System.Drawing.Point(33, 163);
            this.selectPathAvatarPageLabel.Name = "selectPathAvatarPageLabel";
            this.selectPathAvatarPageLabel.Size = new System.Drawing.Size(35, 13);
            this.selectPathAvatarPageLabel.TabIndex = 5;
            this.selectPathAvatarPageLabel.Text = "Chọn";
            // 
            // selectAvatarPageLabel
            // 
            this.selectAvatarPageLabel.AutoSize = true;
            this.selectAvatarPageLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.selectAvatarPageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.selectAvatarPageLabel.Location = new System.Drawing.Point(25, 126);
            this.selectAvatarPageLabel.Name = "selectAvatarPageLabel";
            this.selectAvatarPageLabel.Size = new System.Drawing.Size(103, 13);
            this.selectAvatarPageLabel.TabIndex = 4;
            this.selectAvatarPageLabel.Text = "Avatar FanPage :";
            // 
            // selectPathNamePageButton
            // 
            this.selectPathNamePageButton.BackColor = System.Drawing.Color.White;
            this.selectPathNamePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPathNamePageButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPathNamePageButton.ForeColor = System.Drawing.Color.Black;
            this.selectPathNamePageButton.Location = new System.Drawing.Point(299, 67);
            this.selectPathNamePageButton.Name = "selectPathNamePageButton";
            this.selectPathNamePageButton.Size = new System.Drawing.Size(53, 33);
            this.selectPathNamePageButton.TabIndex = 3;
            this.selectPathNamePageButton.Text = "Mở";
            this.selectPathNamePageButton.UseVisualStyleBackColor = false;
            this.selectPathNamePageButton.Click += new System.EventHandler(this.selectPathNamePageButton_Click);
            // 
            // selectPathNamePageLabel
            // 
            this.selectPathNamePageLabel.AutoSize = true;
            this.selectPathNamePageLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPathNamePageLabel.ForeColor = System.Drawing.Color.Teal;
            this.selectPathNamePageLabel.Location = new System.Drawing.Point(30, 81);
            this.selectPathNamePageLabel.Name = "selectPathNamePageLabel";
            this.selectPathNamePageLabel.Size = new System.Drawing.Size(35, 13);
            this.selectPathNamePageLabel.TabIndex = 2;
            this.selectPathNamePageLabel.Text = "Chọn";
            // 
            // selectPathNamePageTextBox
            // 
            this.selectPathNamePageTextBox.Location = new System.Drawing.Point(98, 74);
            this.selectPathNamePageTextBox.Name = "selectPathNamePageTextBox";
            this.selectPathNamePageTextBox.Size = new System.Drawing.Size(176, 20);
            this.selectPathNamePageTextBox.TabIndex = 1;
            // 
            // namePageLabel
            // 
            this.namePageLabel.AutoSize = true;
            this.namePageLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.namePageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.namePageLabel.Location = new System.Drawing.Point(22, 41);
            this.namePageLabel.Name = "namePageLabel";
            this.namePageLabel.Size = new System.Drawing.Size(85, 13);
            this.namePageLabel.TabIndex = 0;
            this.namePageLabel.Text = "Tên FanPage :";
            // 
            // generalSettingTabPage
            // 
            this.generalSettingTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(151)))), ((int)(((byte)(153)))));
            this.generalSettingTabPage.Controls.Add(this.generalSettingGroupBox);
            this.generalSettingTabPage.ForeColor = System.Drawing.Color.White;
            this.generalSettingTabPage.Location = new System.Drawing.Point(4, 34);
            this.generalSettingTabPage.Name = "generalSettingTabPage";
            this.generalSettingTabPage.Size = new System.Drawing.Size(1664, 749);
            this.generalSettingTabPage.TabIndex = 15;
            this.generalSettingTabPage.Text = "Setting chung";
            this.generalSettingTabPage.UseVisualStyleBackColor = true;
            // 
            // generalSettingGroupBox
            // 
            this.generalSettingGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.generalSettingGroupBox.Controls.Add(this.savegeneralSettingButton);
            this.generalSettingGroupBox.Controls.Add(this.apiKeyTextBox);
            this.generalSettingGroupBox.Controls.Add(this.apiKeyLabel);
            this.generalSettingGroupBox.Controls.Add(this.pathProfileChromeGroupBox);
            this.generalSettingGroupBox.Controls.Add(this.generalSetingUserProxyComboBox);
            this.generalSettingGroupBox.Controls.Add(this.generalSetingUserProxyLabel);
            this.generalSettingGroupBox.Controls.Add(this.generalSetingResetIpLabel);
            this.generalSettingGroupBox.Controls.Add(this.generalSetingResetIpNumericUpDown);
            this.generalSettingGroupBox.Controls.Add(this.generalSetingResetIpCheckBox);
            this.generalSettingGroupBox.Controls.Add(this.generalSettingflowNumberNumericUpDown);
            this.generalSettingGroupBox.Controls.Add(this.generalSettingflowNumberLabel);
            this.generalSettingGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalSettingGroupBox.Location = new System.Drawing.Point(415, 48);
            this.generalSettingGroupBox.Name = "generalSettingGroupBox";
            this.generalSettingGroupBox.Size = new System.Drawing.Size(503, 537);
            this.generalSettingGroupBox.TabIndex = 0;
            this.generalSettingGroupBox.TabStop = false;
            this.generalSettingGroupBox.Text = "SETTING CHUNG";
            // 
            // savegeneralSettingButton
            // 
            this.savegeneralSettingButton.BackColor = System.Drawing.Color.DarkCyan;
            this.savegeneralSettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savegeneralSettingButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savegeneralSettingButton.ForeColor = System.Drawing.Color.White;
            this.savegeneralSettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savegeneralSettingButton.Location = new System.Drawing.Point(376, 487);
            this.savegeneralSettingButton.Name = "savegeneralSettingButton";
            this.savegeneralSettingButton.Size = new System.Drawing.Size(97, 27);
            this.savegeneralSettingButton.TabIndex = 82;
            this.savegeneralSettingButton.Text = " Lưu Cài Đặt";
            this.savegeneralSettingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savegeneralSettingButton.UseVisualStyleBackColor = false;
            this.savegeneralSettingButton.Click += new System.EventHandler(this.savegeneralSettingButton_Click);
            // 
            // apiKeyTextBox
            // 
            this.apiKeyTextBox.Enabled = false;
            this.apiKeyTextBox.Location = new System.Drawing.Point(20, 335);
            this.apiKeyTextBox.Multiline = true;
            this.apiKeyTextBox.Name = "apiKeyTextBox";
            this.apiKeyTextBox.Size = new System.Drawing.Size(368, 80);
            this.apiKeyTextBox.TabIndex = 81;
            // 
            // apiKeyLabel
            // 
            this.apiKeyLabel.AutoSize = true;
            this.apiKeyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.apiKeyLabel.Location = new System.Drawing.Point(17, 300);
            this.apiKeyLabel.Name = "apiKeyLabel";
            this.apiKeyLabel.Size = new System.Drawing.Size(168, 13);
            this.apiKeyLabel.TabIndex = 71;
            this.apiKeyLabel.Text = "API KEY/Mỗi key trên 1 dòng";
            // 
            // pathProfileChromeGroupBox
            // 
            this.pathProfileChromeGroupBox.Controls.Add(this.pathProfileChromeLabel);
            this.pathProfileChromeGroupBox.Controls.Add(this.selectPathProfileChromeLabel);
            this.pathProfileChromeGroupBox.Controls.Add(this.selectPathProfileChromeTextBox);
            this.pathProfileChromeGroupBox.Controls.Add(this.selectPathProfileChromeButton);
            this.pathProfileChromeGroupBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathProfileChromeGroupBox.Location = new System.Drawing.Point(20, 179);
            this.pathProfileChromeGroupBox.Name = "pathProfileChromeGroupBox";
            this.pathProfileChromeGroupBox.Size = new System.Drawing.Size(465, 94);
            this.pathProfileChromeGroupBox.TabIndex = 70;
            this.pathProfileChromeGroupBox.TabStop = false;
            // 
            // pathProfileChromeLabel
            // 
            this.pathProfileChromeLabel.AutoSize = true;
            this.pathProfileChromeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathProfileChromeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pathProfileChromeLabel.Location = new System.Drawing.Point(19, 15);
            this.pathProfileChromeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pathProfileChromeLabel.Name = "pathProfileChromeLabel";
            this.pathProfileChromeLabel.Size = new System.Drawing.Size(155, 13);
            this.pathProfileChromeLabel.TabIndex = 36;
            this.pathProfileChromeLabel.Text = "Đường dẫn Chrome Profile";
            // 
            // selectPathProfileChromeLabel
            // 
            this.selectPathProfileChromeLabel.AutoSize = true;
            this.selectPathProfileChromeLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPathProfileChromeLabel.ForeColor = System.Drawing.Color.Teal;
            this.selectPathProfileChromeLabel.Location = new System.Drawing.Point(11, 48);
            this.selectPathProfileChromeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectPathProfileChromeLabel.Name = "selectPathProfileChromeLabel";
            this.selectPathProfileChromeLabel.Size = new System.Drawing.Size(35, 13);
            this.selectPathProfileChromeLabel.TabIndex = 36;
            this.selectPathProfileChromeLabel.Text = "Chọn";
            // 
            // selectPathProfileChromeTextBox
            // 
            this.selectPathProfileChromeTextBox.Location = new System.Drawing.Point(50, 46);
            this.selectPathProfileChromeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectPathProfileChromeTextBox.Name = "selectPathProfileChromeTextBox";
            this.selectPathProfileChromeTextBox.Size = new System.Drawing.Size(350, 21);
            this.selectPathProfileChromeTextBox.TabIndex = 35;
            // 
            // selectPathProfileChromeButton
            // 
            this.selectPathProfileChromeButton.BackColor = System.Drawing.Color.White;
            this.selectPathProfileChromeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectPathProfileChromeButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPathProfileChromeButton.ForeColor = System.Drawing.Color.Black;
            this.selectPathProfileChromeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectPathProfileChromeButton.Location = new System.Drawing.Point(413, 40);
            this.selectPathProfileChromeButton.Name = "selectPathProfileChromeButton";
            this.selectPathProfileChromeButton.Size = new System.Drawing.Size(40, 30);
            this.selectPathProfileChromeButton.TabIndex = 34;
            this.selectPathProfileChromeButton.Text = "Mở";
            this.selectPathProfileChromeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectPathProfileChromeButton.UseVisualStyleBackColor = false;
            this.selectPathProfileChromeButton.Click += new System.EventHandler(this.selectPathProfileChromeButton_Click);
            // 
            // generalSetingUserProxyComboBox
            // 
            this.generalSetingUserProxyComboBox.FormattingEnabled = true;
            this.generalSetingUserProxyComboBox.Items.AddRange(new object[] {
            "Use Proxy",
            "No Proxy"});
            this.generalSetingUserProxyComboBox.Location = new System.Drawing.Point(130, 143);
            this.generalSetingUserProxyComboBox.Name = "generalSetingUserProxyComboBox";
            this.generalSetingUserProxyComboBox.Size = new System.Drawing.Size(100, 21);
            this.generalSetingUserProxyComboBox.TabIndex = 69;
            this.generalSetingUserProxyComboBox.SelectedIndexChanged += new System.EventHandler(this.generalSetingUserProxyComboBox_SelectedIndexChanged);
            // 
            // generalSetingUserProxyLabel
            // 
            this.generalSetingUserProxyLabel.AutoSize = true;
            this.generalSetingUserProxyLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.generalSetingUserProxyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.generalSetingUserProxyLabel.Location = new System.Drawing.Point(17, 143);
            this.generalSetingUserProxyLabel.Name = "generalSetingUserProxyLabel";
            this.generalSetingUserProxyLabel.Size = new System.Drawing.Size(89, 13);
            this.generalSetingUserProxyLabel.TabIndex = 68;
            this.generalSetingUserProxyLabel.Text = "Sử dụng Proxy";
            // 
            // generalSetingResetIpLabel
            // 
            this.generalSetingResetIpLabel.AutoSize = true;
            this.generalSetingResetIpLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalSetingResetIpLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.generalSetingResetIpLabel.Location = new System.Drawing.Point(200, 90);
            this.generalSetingResetIpLabel.Name = "generalSetingResetIpLabel";
            this.generalSetingResetIpLabel.Size = new System.Drawing.Size(30, 13);
            this.generalSetingResetIpLabel.TabIndex = 67;
            this.generalSetingResetIpLabel.Text = "lượt";
            // 
            // generalSetingResetIpNumericUpDown
            // 
            this.generalSetingResetIpNumericUpDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalSetingResetIpNumericUpDown.Location = new System.Drawing.Point(134, 85);
            this.generalSetingResetIpNumericUpDown.Name = "generalSetingResetIpNumericUpDown";
            this.generalSetingResetIpNumericUpDown.Size = new System.Drawing.Size(42, 21);
            this.generalSetingResetIpNumericUpDown.TabIndex = 66;
            this.generalSetingResetIpNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // generalSetingResetIpCheckBox
            // 
            this.generalSetingResetIpCheckBox.AutoSize = true;
            this.generalSetingResetIpCheckBox.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalSetingResetIpCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.generalSetingResetIpCheckBox.Location = new System.Drawing.Point(20, 89);
            this.generalSetingResetIpCheckBox.Name = "generalSetingResetIpCheckBox";
            this.generalSetingResetIpCheckBox.Size = new System.Drawing.Size(97, 17);
            this.generalSetingResetIpCheckBox.TabIndex = 65;
            this.generalSetingResetIpCheckBox.Text = "Reset IP sau";
            this.generalSetingResetIpCheckBox.UseVisualStyleBackColor = true;
            // 
            // generalSettingflowNumberNumericUpDown
            // 
            this.generalSettingflowNumberNumericUpDown.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalSettingflowNumberNumericUpDown.Location = new System.Drawing.Point(109, 33);
            this.generalSettingflowNumberNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.generalSettingflowNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.generalSettingflowNumberNumericUpDown.Name = "generalSettingflowNumberNumericUpDown";
            this.generalSettingflowNumberNumericUpDown.Size = new System.Drawing.Size(42, 21);
            this.generalSettingflowNumberNumericUpDown.TabIndex = 64;
            this.generalSettingflowNumberNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // generalSettingflowNumberLabel
            // 
            this.generalSettingflowNumberLabel.AutoSize = true;
            this.generalSettingflowNumberLabel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generalSettingflowNumberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.generalSettingflowNumberLabel.Location = new System.Drawing.Point(17, 35);
            this.generalSettingflowNumberLabel.Name = "generalSettingflowNumberLabel";
            this.generalSettingflowNumberLabel.Size = new System.Drawing.Size(58, 13);
            this.generalSettingflowNumberLabel.TabIndex = 63;
            this.generalSettingflowNumberLabel.Text = "Số Luồng";
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
            this.doashBoardTabPage.Text = "DashBoard";
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
            this.readAllFileButton.Click += new System.EventHandler(this.readAllFileButton_Click);
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
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listFileDataGridView.DefaultCellStyle = dataGridViewCellStyle30;
            this.listFileDataGridView.GridColor = System.Drawing.Color.White;
            this.listFileDataGridView.Location = new System.Drawing.Point(5, 300);
            this.listFileDataGridView.Name = "listFileDataGridView";
            this.listFileDataGridView.RowHeadersVisible = false;
            this.listFileDataGridView.RowHeadersWidth = 51;
            this.listFileDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listFileDataGridView.Size = new System.Drawing.Size(309, 285);
            this.listFileDataGridView.TabIndex = 2;
            this.listFileDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listFileDataGridView_CellContentDoubleClick);
            // 
            // listFileDataGridViewTextBoxColumn
            // 
            this.listFileDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.listFileDataGridViewTextBoxColumn.HeaderText = "Column1";
            this.listFileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.listFileDataGridViewTextBoxColumn.Name = "listFileDataGridViewTextBoxColumn";
            this.listFileDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.checkViaGroupBox.Controls.Add(this.checkStatusCookieButton);
            this.checkViaGroupBox.Controls.Add(this.getInfoAccountToken);
            this.checkViaGroupBox.Controls.Add(this.getAccessTokenEAAGButton);
            this.checkViaGroupBox.Location = new System.Drawing.Point(211, 3);
            this.checkViaGroupBox.Name = "checkViaGroupBox";
            this.checkViaGroupBox.Size = new System.Drawing.Size(465, 151);
            this.checkViaGroupBox.TabIndex = 20;
            this.checkViaGroupBox.TabStop = false;
            // 
            // checkStatusCookieButton
            // 
            this.checkStatusCookieButton.BackColor = System.Drawing.Color.White;
            this.checkStatusCookieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkStatusCookieButton.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.checkStatusCookieButton.ForeColor = System.Drawing.Color.Teal;
            this.checkStatusCookieButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkStatusCookieButton.Location = new System.Drawing.Point(15, 74);
            this.checkStatusCookieButton.Name = "checkStatusCookieButton";
            this.checkStatusCookieButton.Size = new System.Drawing.Size(110, 29);
            this.checkStatusCookieButton.TabIndex = 53;
            this.checkStatusCookieButton.Text = "Check Cookie";
            this.checkStatusCookieButton.UseVisualStyleBackColor = false;
            this.checkStatusCookieButton.Click += new System.EventHandler(this.checkStatusCookieButton_Click);
            // 
            // getInfoAccountToken
            // 
            this.getInfoAccountToken.BackColor = System.Drawing.Color.White;
            this.getInfoAccountToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getInfoAccountToken.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getInfoAccountToken.ForeColor = System.Drawing.Color.DarkOrange;
            this.getInfoAccountToken.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getInfoAccountToken.Location = new System.Drawing.Point(149, 19);
            this.getInfoAccountToken.Name = "getInfoAccountToken";
            this.getInfoAccountToken.Size = new System.Drawing.Size(96, 31);
            this.getInfoAccountToken.TabIndex = 52;
            this.getInfoAccountToken.Text = "Get INFO ACC";
            this.getInfoAccountToken.UseVisualStyleBackColor = false;
            this.getInfoAccountToken.Click += new System.EventHandler(this.getInfoAccountToken_Click);
            // 
            // getAccessTokenEAAGButton
            // 
            this.getAccessTokenEAAGButton.BackColor = System.Drawing.Color.White;
            this.getAccessTokenEAAGButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getAccessTokenEAAGButton.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAccessTokenEAAGButton.ForeColor = System.Drawing.Color.Teal;
            this.getAccessTokenEAAGButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getAccessTokenEAAGButton.Location = new System.Drawing.Point(15, 19);
            this.getAccessTokenEAAGButton.Name = "getAccessTokenEAAGButton";
            this.getAccessTokenEAAGButton.Size = new System.Drawing.Size(110, 31);
            this.getAccessTokenEAAGButton.TabIndex = 51;
            this.getAccessTokenEAAGButton.Text = "Get Token EAAG";
            this.getAccessTokenEAAGButton.UseVisualStyleBackColor = false;
            this.getAccessTokenEAAGButton.Click += new System.EventHandler(this.getAccessTokenEAAGButton_Click);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.detailListAccountsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.detailListAccountsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailListAccountsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.detailListAccountsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailListAccountsDataGridView.CausesValidation = false;
            this.detailListAccountsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.detailListAccountsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailListAccountsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
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
            this.trangthaiAccount,
            this.pageNumberAccount});
            this.detailListAccountsDataGridView.ContextMenuStrip = this.featuresContextMenuStrip;
            this.detailListAccountsDataGridView.EnableHeadersVisualStyles = false;
            this.detailListAccountsDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.detailListAccountsDataGridView.Location = new System.Drawing.Point(3, 2);
            this.detailListAccountsDataGridView.Name = "detailListAccountsDataGridView";
            this.detailListAccountsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailListAccountsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.detailListAccountsDataGridView.RowHeadersVisible = false;
            this.detailListAccountsDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailListAccountsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle57;
            this.detailListAccountsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailListAccountsDataGridView.Size = new System.Drawing.Size(1286, 492);
            this.detailListAccountsDataGridView.TabIndex = 83;
            // 
            // sttAccount
            // 
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sttAccount.DefaultCellStyle = dataGridViewCellStyle32;
            this.sttAccount.HeaderText = "STT";
            this.sttAccount.MinimumWidth = 6;
            this.sttAccount.Name = "sttAccount";
            this.sttAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sttAccount.Width = 30;
            // 
            // checkboxItemAccount
            // 
            this.checkboxItemAccount.HeaderText = "All";
            this.checkboxItemAccount.MinimumWidth = 6;
            this.checkboxItemAccount.Name = "checkboxItemAccount";
            this.checkboxItemAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkboxItemAccount.Width = 20;
            // 
            // uidAccount
            // 
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uidAccount.DefaultCellStyle = dataGridViewCellStyle33;
            this.uidAccount.HeaderText = "UID";
            this.uidAccount.MinimumWidth = 6;
            this.uidAccount.Name = "uidAccount";
            this.uidAccount.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.uidAccount.Width = 40;
            // 
            // passAccount
            // 
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passAccount.DefaultCellStyle = dataGridViewCellStyle34;
            this.passAccount.HeaderText = "Password";
            this.passAccount.MinimumWidth = 6;
            this.passAccount.Name = "passAccount";
            this.passAccount.Width = 50;
            // 
            // code2faAccount
            // 
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.code2faAccount.DefaultCellStyle = dataGridViewCellStyle35;
            this.code2faAccount.HeaderText = "2FA";
            this.code2faAccount.MinimumWidth = 6;
            this.code2faAccount.Name = "code2faAccount";
            this.code2faAccount.Width = 50;
            // 
            // cookieAccount
            // 
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cookieAccount.DefaultCellStyle = dataGridViewCellStyle36;
            this.cookieAccount.HeaderText = "Cookie";
            this.cookieAccount.MinimumWidth = 6;
            this.cookieAccount.Name = "cookieAccount";
            this.cookieAccount.Width = 60;
            // 
            // tokenAccount
            // 
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tokenAccount.DefaultCellStyle = dataGridViewCellStyle37;
            this.tokenAccount.HeaderText = "Token";
            this.tokenAccount.MinimumWidth = 6;
            this.tokenAccount.Name = "tokenAccount";
            this.tokenAccount.Width = 60;
            // 
            // cookieldAccount
            // 
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cookieldAccount.DefaultCellStyle = dataGridViewCellStyle38;
            this.cookieldAccount.HeaderText = "Cookie LD";
            this.cookieldAccount.MinimumWidth = 6;
            this.cookieldAccount.Name = "cookieldAccount";
            this.cookieldAccount.Width = 60;
            // 
            // tokenldAccount
            // 
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tokenldAccount.DefaultCellStyle = dataGridViewCellStyle39;
            this.tokenldAccount.HeaderText = "Token LD";
            this.tokenldAccount.MinimumWidth = 6;
            this.tokenldAccount.Name = "tokenldAccount";
            this.tokenldAccount.Width = 60;
            // 
            // emailAccount
            // 
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailAccount.DefaultCellStyle = dataGridViewCellStyle40;
            this.emailAccount.HeaderText = "Email";
            this.emailAccount.MinimumWidth = 6;
            this.emailAccount.Name = "emailAccount";
            this.emailAccount.Width = 50;
            // 
            // passmailAccount
            // 
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passmailAccount.DefaultCellStyle = dataGridViewCellStyle41;
            this.passmailAccount.HeaderText = "Pass Mail";
            this.passmailAccount.MinimumWidth = 6;
            this.passmailAccount.Name = "passmailAccount";
            this.passmailAccount.Width = 50;
            // 
            // namtaoAccount
            // 
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.namtaoAccount.DefaultCellStyle = dataGridViewCellStyle42;
            this.namtaoAccount.HeaderText = "Avatar";
            this.namtaoAccount.MinimumWidth = 6;
            this.namtaoAccount.Name = "namtaoAccount";
            this.namtaoAccount.Width = 60;
            // 
            // tenAccount
            // 
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.SlateBlue;
            this.tenAccount.DefaultCellStyle = dataGridViewCellStyle43;
            this.tenAccount.FillWeight = 150F;
            this.tenAccount.HeaderText = "Name";
            this.tenAccount.MinimumWidth = 6;
            this.tenAccount.Name = "tenAccount";
            this.tenAccount.ReadOnly = true;
            this.tenAccount.Width = 60;
            // 
            // birthdayAccount
            // 
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.birthdayAccount.DefaultCellStyle = dataGridViewCellStyle44;
            this.birthdayAccount.HeaderText = "Birthday";
            this.birthdayAccount.MinimumWidth = 6;
            this.birthdayAccount.Name = "birthdayAccount";
            this.birthdayAccount.ReadOnly = true;
            this.birthdayAccount.Width = 60;
            // 
            // friendsAccount
            // 
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.friendsAccount.DefaultCellStyle = dataGridViewCellStyle45;
            this.friendsAccount.HeaderText = "Friends";
            this.friendsAccount.MinimumWidth = 6;
            this.friendsAccount.Name = "friendsAccount";
            this.friendsAccount.ReadOnly = true;
            this.friendsAccount.Width = 50;
            // 
            // groupsAccount
            // 
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupsAccount.DefaultCellStyle = dataGridViewCellStyle46;
            this.groupsAccount.HeaderText = "Groups";
            this.groupsAccount.MinimumWidth = 6;
            this.groupsAccount.Name = "groupsAccount";
            this.groupsAccount.ReadOnly = true;
            this.groupsAccount.Width = 50;
            // 
            // genderAccount
            // 
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.genderAccount.DefaultCellStyle = dataGridViewCellStyle47;
            this.genderAccount.HeaderText = "Gender";
            this.genderAccount.MinimumWidth = 6;
            this.genderAccount.Name = "genderAccount";
            this.genderAccount.ReadOnly = true;
            this.genderAccount.Width = 50;
            // 
            // tinhtrangAccount
            // 
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.Green;
            this.tinhtrangAccount.DefaultCellStyle = dataGridViewCellStyle48;
            this.tinhtrangAccount.HeaderText = "Live/Die";
            this.tinhtrangAccount.MinimumWidth = 6;
            this.tinhtrangAccount.Name = "tinhtrangAccount";
            this.tinhtrangAccount.ReadOnly = true;
            this.tinhtrangAccount.Width = 60;
            // 
            // proxyAccount
            // 
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proxyAccount.DefaultCellStyle = dataGridViewCellStyle49;
            this.proxyAccount.HeaderText = "Proxy";
            this.proxyAccount.MinimumWidth = 6;
            this.proxyAccount.Name = "proxyAccount";
            this.proxyAccount.Width = 50;
            // 
            // lastactiveAccount
            // 
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastactiveAccount.DefaultCellStyle = dataGridViewCellStyle50;
            this.lastactiveAccount.HeaderText = "Last Active";
            this.lastactiveAccount.MinimumWidth = 6;
            this.lastactiveAccount.Name = "lastactiveAccount";
            this.lastactiveAccount.Width = 50;
            // 
            // tenfileAccount
            // 
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.Navy;
            this.tenfileAccount.DefaultCellStyle = dataGridViewCellStyle51;
            this.tenfileAccount.HeaderText = "DM";
            this.tenfileAccount.MinimumWidth = 6;
            this.tenfileAccount.Name = "tenfileAccount";
            this.tenfileAccount.Width = 60;
            // 
            // ghichuAccount
            // 
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ghichuAccount.DefaultCellStyle = dataGridViewCellStyle52;
            this.ghichuAccount.HeaderText = "Ghi chú";
            this.ghichuAccount.MinimumWidth = 6;
            this.ghichuAccount.Name = "ghichuAccount";
            this.ghichuAccount.Width = 50;
            // 
            // buAccount
            // 
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buAccount.DefaultCellStyle = dataGridViewCellStyle53;
            this.buAccount.HeaderText = "Ngày BU";
            this.buAccount.MinimumWidth = 6;
            this.buAccount.Name = "buAccount";
            this.buAccount.Width = 60;
            // 
            // trangthaiAccount
            // 
            this.trangthaiAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.trangthaiAccount.DefaultCellStyle = dataGridViewCellStyle54;
            this.trangthaiAccount.HeaderText = "Status";
            this.trangthaiAccount.MinimumWidth = 6;
            this.trangthaiAccount.Name = "trangthaiAccount";
            this.trangthaiAccount.ReadOnly = true;
            // 
            // pageNumberAccount
            // 
            this.pageNumberAccount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pageNumberAccount.DefaultCellStyle = dataGridViewCellStyle55;
            this.pageNumberAccount.HeaderText = "Page Number";
            this.pageNumberAccount.MinimumWidth = 6;
            this.pageNumberAccount.Name = "pageNumberAccount";
            this.pageNumberAccount.ReadOnly = true;
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.doashBoardTabPage);
            this.tabControl.Controls.Add(this.generalSettingTabPage);
            this.tabControl.Controls.Add(this.regAndSeedingTabPage);
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
            this.Controls.Add(this.doashBoardHScrollBar);
            this.Controls.Add(this.totalAccountLabel);
            this.Controls.Add(this.totalAccountLiveLabel);
            this.Controls.Add(this.totalAccountDieLabel);
            this.Controls.Add(this.totalAccountSelectedLabel);
            this.Controls.Add(this.totalAccountValueLabel);
            this.Controls.Add(this.totalAccountLiveValueLabel);
            this.Controls.Add(this.totalAccountDieValueLabel);
            this.Controls.Add(this.totalAccountSelectedValueLabel);
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
            this.listFileContextMenuStrip.ResumeLayout(false);
            this.featuresContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingPictureBox)).EndInit();
            this.regAndSeedingTabPage.ResumeLayout(false);
            this.seedingPageGroupBox.ResumeLayout(false);
            this.seedingPageGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeGetNumBerNumericUpDown)).EndInit();
            this.regPageGroupBox.ResumeLayout(false);
            this.regPageGroupBox.PerformLayout();
            this.generalSettingTabPage.ResumeLayout(false);
            this.generalSettingGroupBox.ResumeLayout(false);
            this.generalSettingGroupBox.PerformLayout();
            this.pathProfileChromeGroupBox.ResumeLayout(false);
            this.pathProfileChromeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.generalSetingResetIpNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalSettingflowNumberNumericUpDown)).EndInit();
            this.doashBoardTabPage.ResumeLayout(false);
            this.doashBoardTabPage.PerformLayout();
            this.fileManagementGroupBox.ResumeLayout(false);
            this.fileManagementChild1GroupBox.ResumeLayout(false);
            this.fileManagementChild1GroupBox.PerformLayout();
            this.fileManagementChild2GroupBox.ResumeLayout(false);
            this.fileManagementChild2GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listFileDataGridView)).EndInit();
            this.checkViaGroupBox.ResumeLayout(false);
            this.settingChormeGroupBox.ResumeLayout(false);
            this.detailListAccountsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailListAccountsDataGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void GeneralSetingUserProxyComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel toolBar;
        private System.Windows.Forms.PictureBox pictureBoxLogoShop;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.Button buttonCloseApp;
        private System.Windows.Forms.Label lableContact;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label lablePhoneContact;
        private System.Windows.Forms.ContextMenuStrip listFileContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNameFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.PictureBox loadingPictureBox;
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
        private System.Windows.Forms.HScrollBar doashBoardHScrollBar;
        private System.Windows.Forms.Label totalAccountLabel;
        private System.Windows.Forms.Label totalAccountLiveLabel;
        private System.Windows.Forms.Label totalAccountDieLabel;
        private System.Windows.Forms.Label totalAccountSelectedLabel;
        private System.Windows.Forms.Label totalAccountValueLabel;
        private System.Windows.Forms.Label totalAccountLiveValueLabel;
        private System.Windows.Forms.Label totalAccountDieValueLabel;
        private System.Windows.Forms.Label totalAccountSelectedValueLabel;
        private System.Windows.Forms.GroupBox SelectPathProfileGroupBox;
        private System.Windows.Forms.ToolStripMenuItem LoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowLoginCookieTOkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regAndSeedingToolStripMenuItem;
        private System.Windows.Forms.TabPage regAndSeedingTabPage;
        private System.Windows.Forms.GroupBox regPageGroupBox;
        private System.Windows.Forms.Button startRegPageButton;
        private System.Windows.Forms.CheckBox setRuleAdminRegPageCheckBox;
        private System.Windows.Forms.Button selectPathAvatarPageButton;
        private System.Windows.Forms.TextBox selectPathAvatarPageTextBox;
        private System.Windows.Forms.Label selectPathAvatarPageLabel;
        private System.Windows.Forms.Label selectAvatarPageLabel;
        private System.Windows.Forms.Button selectPathNamePageButton;
        private System.Windows.Forms.Label selectPathNamePageLabel;
        private System.Windows.Forms.TextBox selectPathNamePageTextBox;
        private System.Windows.Forms.Label namePageLabel;
        private System.Windows.Forms.TabPage generalSettingTabPage;
        private System.Windows.Forms.GroupBox generalSettingGroupBox;
        private System.Windows.Forms.Button savegeneralSettingButton;
        private System.Windows.Forms.TextBox apiKeyTextBox;
        private System.Windows.Forms.Label apiKeyLabel;
        private System.Windows.Forms.GroupBox pathProfileChromeGroupBox;
        private System.Windows.Forms.Label pathProfileChromeLabel;
        private System.Windows.Forms.Label selectPathProfileChromeLabel;
        private System.Windows.Forms.TextBox selectPathProfileChromeTextBox;
        private System.Windows.Forms.Button selectPathProfileChromeButton;
        private System.Windows.Forms.ComboBox generalSetingUserProxyComboBox;
        private System.Windows.Forms.Label generalSetingUserProxyLabel;
        private System.Windows.Forms.Label generalSetingResetIpLabel;
        private System.Windows.Forms.NumericUpDown generalSetingResetIpNumericUpDown;
        private System.Windows.Forms.CheckBox generalSetingResetIpCheckBox;
        private System.Windows.Forms.NumericUpDown generalSettingflowNumberNumericUpDown;
        private System.Windows.Forms.Label generalSettingflowNumberLabel;
        private System.Windows.Forms.TabPage doashBoardTabPage;
        private System.Windows.Forms.GroupBox fileManagementGroupBox;
        private System.Windows.Forms.GroupBox fileManagementChild1GroupBox;
        private System.Windows.Forms.Label fileManagementLabel;
        private System.Windows.Forms.TextBox importFileTextBox;
        private System.Windows.Forms.Label importFileLabel;
        private System.Windows.Forms.Label createFileLabel;
        private System.Windows.Forms.TextBox createFileTextBox;
        private System.Windows.Forms.GroupBox fileManagementChild2GroupBox;
        private System.Windows.Forms.Label statusFilterLabel;
        private System.Windows.Forms.ComboBox statusFilterComboBox;
        private System.Windows.Forms.Label readAllFileLabel;
        private System.Windows.Forms.Button readAllFileButton;
        private System.Windows.Forms.DataGridView listFileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn listFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox itemFileDetail;
        private System.Windows.Forms.GroupBox passCheckPointGroupBox;
        private System.Windows.Forms.GroupBox backupGroupBox;
        private System.Windows.Forms.GroupBox checkViaGroupBox;
        private System.Windows.Forms.GroupBox settingChormeGroupBox;
        private System.Windows.Forms.Button turnOffChormeButton;
        private System.Windows.Forms.Panel detailListAccountsPanel;
        private System.Windows.Forms.DataGridView detailListAccountsDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn pageNumberAccount;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button getAccessTokenEAAGButton;
        private System.Windows.Forms.Button getInfoAccountToken;
        private System.Windows.Forms.Button checkStatusCookieButton;
        private System.Windows.Forms.GroupBox seedingPageGroupBox;
        private System.Windows.Forms.CheckBox followSeedingPageCheckBox;
        private System.Windows.Forms.CheckBox commentSeedingPageCheckBox;
        private System.Windows.Forms.CheckBox likePageSeedingPageCheckBox;
        private System.Windows.Forms.CheckBox likePostSeedingPageCheckBox;
        private System.Windows.Forms.Label uidSeedingPageLabel;
        private System.Windows.Forms.TextBox uidSeedingPageTextBox;
        private System.Windows.Forms.Label attentionSeedingPageLabel;
        private System.Windows.Forms.CheckBox shareWallSeedingPageCheckBox;
        private System.Windows.Forms.CheckBox shareGroupSeedingPageCheckBox;
        private System.Windows.Forms.Label timeGetUidSeedingPageLabel;
        private System.Windows.Forms.TextBox keyGetUidSeedingPageTextBox;
        private System.Windows.Forms.Label keyGetUidSeedingPageLabel;
        private System.Windows.Forms.CheckBox getUidSeedingPageCheckBox;
        private System.Windows.Forms.NumericUpDown timeGetNumBerNumericUpDown;
        private System.Windows.Forms.TextBox contentCommentSeedingPageTextBox;
        private System.Windows.Forms.Button saveContentSeedingPageButton;
        private System.Windows.Forms.Label attentionContentSeedingPageLabel;
        private System.Windows.Forms.Label contentCommentSeedingPageLabel;
        private System.Windows.Forms.TextBox contentShareSeedingPageTextBox;
        private System.Windows.Forms.Button saveContentShareSeedingPageButton;
        private System.Windows.Forms.Label attentionShareSeedingPageLabel;
        private System.Windows.Forms.Label contentShareSeedingPageLabel;
        private System.Windows.Forms.Button saveSeetingSeedingPageButton;
        private System.Windows.Forms.Button startWithSeedingWithUidButton;
        private System.Windows.Forms.Button startWithSeedingWithPageButton;
        private System.Windows.Forms.CheckBox sType2SeedingPageCheckbox;
        private System.Windows.Forms.Button changePageToUidButton;
    }
}

