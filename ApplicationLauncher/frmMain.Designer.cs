namespace ApplicationLauncher
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdmintoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dTaSAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBDAppIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBDAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDAppAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendingApprovalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusPID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDivider1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDivider2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.imlApp_Image = new System.Windows.Forms.ImageList(this.components);
            this.dgvUserApps = new System.Windows.Forms.DataGridView();
            this.App_Odr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDApp_Command = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.bDAppIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDAppNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDAppNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_Fav = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.App_Img = new System.Windows.Forms.DataGridViewImageColumn();
            this.bDAppFriendlyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restrictedBDAppDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bDAppGoverningDLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDAppAdminContactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDAppVersionNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDAppInstallFileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDAppStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateProcessDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDAppBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDAppBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.AdmintoolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(695, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // AdmintoolStripMenuItem
            // 
            this.AdmintoolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dTaSAdminToolStripMenuItem,
            this.bDAppAdminToolStripMenuItem});
            this.AdmintoolStripMenuItem.Name = "AdmintoolStripMenuItem";
            this.AdmintoolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.AdmintoolStripMenuItem.Text = "Admin";
            this.AdmintoolStripMenuItem.Visible = false;
            // 
            // dTaSAdminToolStripMenuItem
            // 
            this.dTaSAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBDAppIconToolStripMenuItem,
            this.addBDAppToolStripMenuItem});
            this.dTaSAdminToolStripMenuItem.Name = "dTaSAdminToolStripMenuItem";
            this.dTaSAdminToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dTaSAdminToolStripMenuItem.Text = "DTaS Admin";
            this.dTaSAdminToolStripMenuItem.Visible = false;
            // 
            // addBDAppIconToolStripMenuItem
            // 
            this.addBDAppIconToolStripMenuItem.Name = "addBDAppIconToolStripMenuItem";
            this.addBDAppIconToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addBDAppIconToolStripMenuItem.Text = "Add BDApp Icon";
            this.addBDAppIconToolStripMenuItem.Click += new System.EventHandler(this.addBDAppIconToolStripMenuItem_Click);
            // 
            // addBDAppToolStripMenuItem
            // 
            this.addBDAppToolStripMenuItem.Name = "addBDAppToolStripMenuItem";
            this.addBDAppToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.addBDAppToolStripMenuItem.Text = "Add BDApp";
            // 
            // bDAppAdminToolStripMenuItem
            // 
            this.bDAppAdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pendingApprovalsToolStripMenuItem});
            this.bDAppAdminToolStripMenuItem.Name = "bDAppAdminToolStripMenuItem";
            this.bDAppAdminToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.bDAppAdminToolStripMenuItem.Text = "BDApp Admin";
            this.bDAppAdminToolStripMenuItem.Visible = false;
            // 
            // pendingApprovalsToolStripMenuItem
            // 
            this.pendingApprovalsToolStripMenuItem.Name = "pendingApprovalsToolStripMenuItem";
            this.pendingApprovalsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pendingApprovalsToolStripMenuItem.Text = "Pending Approvals";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuExit.Size = new System.Drawing.Size(133, 22);
            this.mnuExit.Text = "E&xit";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusPID,
            this.toolStripStatusDivider1,
            this.toolStripStatusName,
            this.toolStripStatusDivider2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(695, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusPID
            // 
            this.toolStripStatusPID.Name = "toolStripStatusPID";
            this.toolStripStatusPID.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusPID.Text = "PID : ";
            // 
            // toolStripStatusDivider1
            // 
            this.toolStripStatusDivider1.Name = "toolStripStatusDivider1";
            this.toolStripStatusDivider1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusDivider1.Text = "|";
            this.toolStripStatusDivider1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripStatusName
            // 
            this.toolStripStatusName.Name = "toolStripStatusName";
            this.toolStripStatusName.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusName.Text = "Name : ";
            // 
            // toolStripStatusDivider2
            // 
            this.toolStripStatusDivider2.Name = "toolStripStatusDivider2";
            this.toolStripStatusDivider2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusDivider2.Text = "|";
            this.toolStripStatusDivider2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(695, 365);
            // 
            // imlApp_Image
            // 
            this.imlApp_Image.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlApp_Image.ImageSize = new System.Drawing.Size(16, 16);
            this.imlApp_Image.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dgvUserApps
            // 
            this.dgvUserApps.AutoGenerateColumns = false;
            this.dgvUserApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserApps.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bDAppIDDataGridViewTextBoxColumn,
            this.bDAppNumberDataGridViewTextBoxColumn,
            this.App_Odr,
            this.bDAppNameDataGridViewTextBoxColumn,
            this.App_Fav,
            this.App_Img,
            this.BDApp_Command,
            this.bDAppFriendlyNameDataGridViewTextBoxColumn,
            this.restrictedBDAppDataGridViewCheckBoxColumn,
            this.bDAppGoverningDLDataGridViewTextBoxColumn,
            this.bDAppAdminContactDataGridViewTextBoxColumn,
            this.bDAppVersionNumberDataGridViewTextBoxColumn,
            this.bDAppInstallFileDataGridViewTextBoxColumn,
            this.bDAppStatusDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn,
            this.dateUpdatedDataGridViewTextBoxColumn,
            this.updateProcessDataGridViewTextBoxColumn,
            this.statusDescriptionDataGridViewTextBoxColumn});
            this.dgvUserApps.DataSource = this.bDAppBindingSource;
            this.dgvUserApps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserApps.Location = new System.Drawing.Point(0, 24);
            this.dgvUserApps.Name = "dgvUserApps";
            this.dgvUserApps.ReadOnly = true;
            this.dgvUserApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserApps.Size = new System.Drawing.Size(695, 396);
            this.dgvUserApps.TabIndex = 6;
            this.dgvUserApps.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvUserApps_CellMouseDown);
            this.dgvUserApps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvUserApps_MouseClick);
            this.dgvUserApps.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvUserApps_MouseDoubleClick);
            // 
            // App_Odr
            // 
            this.App_Odr.DataPropertyName = "App_Odr";
            this.App_Odr.HeaderText = "App_Odr";
            this.App_Odr.Name = "App_Odr";
            this.App_Odr.ReadOnly = true;
            // 
            // BDApp_Command
            // 
            this.BDApp_Command.DataPropertyName = "BDApp_Command";
            this.BDApp_Command.HeaderText = "BDApp_Command";
            this.BDApp_Command.Name = "BDApp_Command";
            this.BDApp_Command.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "App_Img";
            this.dataGridViewImageColumn1.HeaderText = "Icon";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // bDAppIDDataGridViewTextBoxColumn
            // 
            this.bDAppIDDataGridViewTextBoxColumn.DataPropertyName = "BDApp_ID";
            this.bDAppIDDataGridViewTextBoxColumn.HeaderText = "BDApp_ID";
            this.bDAppIDDataGridViewTextBoxColumn.Name = "bDAppIDDataGridViewTextBoxColumn";
            this.bDAppIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDAppNumberDataGridViewTextBoxColumn
            // 
            this.bDAppNumberDataGridViewTextBoxColumn.DataPropertyName = "BDApp_Number";
            this.bDAppNumberDataGridViewTextBoxColumn.HeaderText = "BDApp_Number";
            this.bDAppNumberDataGridViewTextBoxColumn.Name = "bDAppNumberDataGridViewTextBoxColumn";
            this.bDAppNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDAppNameDataGridViewTextBoxColumn
            // 
            this.bDAppNameDataGridViewTextBoxColumn.DataPropertyName = "BDApp_Name";
            this.bDAppNameDataGridViewTextBoxColumn.HeaderText = "BDApp_Name";
            this.bDAppNameDataGridViewTextBoxColumn.Name = "bDAppNameDataGridViewTextBoxColumn";
            this.bDAppNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // App_Fav
            // 
            this.App_Fav.DataPropertyName = "App_Fav";
            this.App_Fav.HeaderText = "App_Fav";
            this.App_Fav.Name = "App_Fav";
            this.App_Fav.ReadOnly = true;
            // 
            // App_Img
            // 
            this.App_Img.DataPropertyName = "App_Img";
            this.App_Img.HeaderText = "Icon";
            this.App_Img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.App_Img.Name = "App_Img";
            this.App_Img.ReadOnly = true;
            // 
            // bDAppFriendlyNameDataGridViewTextBoxColumn
            // 
            this.bDAppFriendlyNameDataGridViewTextBoxColumn.DataPropertyName = "BDApp_Friendly_Name";
            this.bDAppFriendlyNameDataGridViewTextBoxColumn.HeaderText = "BDApp_Friendly_Name";
            this.bDAppFriendlyNameDataGridViewTextBoxColumn.Name = "bDAppFriendlyNameDataGridViewTextBoxColumn";
            this.bDAppFriendlyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // restrictedBDAppDataGridViewCheckBoxColumn
            // 
            this.restrictedBDAppDataGridViewCheckBoxColumn.DataPropertyName = "Restricted_BDApp";
            this.restrictedBDAppDataGridViewCheckBoxColumn.HeaderText = "Restricted_BDApp";
            this.restrictedBDAppDataGridViewCheckBoxColumn.Name = "restrictedBDAppDataGridViewCheckBoxColumn";
            this.restrictedBDAppDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // bDAppGoverningDLDataGridViewTextBoxColumn
            // 
            this.bDAppGoverningDLDataGridViewTextBoxColumn.DataPropertyName = "BDApp_Governing_DL";
            this.bDAppGoverningDLDataGridViewTextBoxColumn.HeaderText = "BDApp_Governing_DL";
            this.bDAppGoverningDLDataGridViewTextBoxColumn.Name = "bDAppGoverningDLDataGridViewTextBoxColumn";
            this.bDAppGoverningDLDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDAppAdminContactDataGridViewTextBoxColumn
            // 
            this.bDAppAdminContactDataGridViewTextBoxColumn.DataPropertyName = "BDApp_Admin_Contact";
            this.bDAppAdminContactDataGridViewTextBoxColumn.HeaderText = "BDApp_Admin_Contact";
            this.bDAppAdminContactDataGridViewTextBoxColumn.Name = "bDAppAdminContactDataGridViewTextBoxColumn";
            this.bDAppAdminContactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDAppVersionNumberDataGridViewTextBoxColumn
            // 
            this.bDAppVersionNumberDataGridViewTextBoxColumn.DataPropertyName = "BDApp_Version_Number";
            this.bDAppVersionNumberDataGridViewTextBoxColumn.HeaderText = "BDApp_Version_Number";
            this.bDAppVersionNumberDataGridViewTextBoxColumn.Name = "bDAppVersionNumberDataGridViewTextBoxColumn";
            this.bDAppVersionNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDAppInstallFileDataGridViewTextBoxColumn
            // 
            this.bDAppInstallFileDataGridViewTextBoxColumn.DataPropertyName = "BDApp_Install_File";
            this.bDAppInstallFileDataGridViewTextBoxColumn.HeaderText = "BDApp_Install_File";
            this.bDAppInstallFileDataGridViewTextBoxColumn.Name = "bDAppInstallFileDataGridViewTextBoxColumn";
            this.bDAppInstallFileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDAppStatusDataGridViewTextBoxColumn
            // 
            this.bDAppStatusDataGridViewTextBoxColumn.DataPropertyName = "BDApp_Status";
            this.bDAppStatusDataGridViewTextBoxColumn.HeaderText = "BDApp_Status";
            this.bDAppStatusDataGridViewTextBoxColumn.Name = "bDAppStatusDataGridViewTextBoxColumn";
            this.bDAppStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updatedByDataGridViewTextBoxColumn
            // 
            this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "Updated_By";
            this.updatedByDataGridViewTextBoxColumn.HeaderText = "Updated_By";
            this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
            this.updatedByDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateUpdatedDataGridViewTextBoxColumn
            // 
            this.dateUpdatedDataGridViewTextBoxColumn.DataPropertyName = "Date_Updated";
            this.dateUpdatedDataGridViewTextBoxColumn.HeaderText = "Date_Updated";
            this.dateUpdatedDataGridViewTextBoxColumn.Name = "dateUpdatedDataGridViewTextBoxColumn";
            this.dateUpdatedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // updateProcessDataGridViewTextBoxColumn
            // 
            this.updateProcessDataGridViewTextBoxColumn.DataPropertyName = "Update_Process";
            this.updateProcessDataGridViewTextBoxColumn.HeaderText = "Update_Process";
            this.updateProcessDataGridViewTextBoxColumn.Name = "updateProcessDataGridViewTextBoxColumn";
            this.updateProcessDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDescriptionDataGridViewTextBoxColumn
            // 
            this.statusDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Status_Description";
            this.statusDescriptionDataGridViewTextBoxColumn.HeaderText = "Status_Description";
            this.statusDescriptionDataGridViewTextBoxColumn.Name = "statusDescriptionDataGridViewTextBoxColumn";
            this.statusDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bDAppBindingSource
            // 
            this.bDAppBindingSource.DataSource = typeof(ApplicationLauncher.BDApp);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 442);
            this.Controls.Add(this.dgvUserApps);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTaS LaunchPad";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDAppBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ImageList imlApp_Image;
        private System.Windows.Forms.DataGridView dgvUserApps;
        private System.Windows.Forms.BindingSource bDAppBindingSource;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusPID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDivider1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDivider2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAppIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAppNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_Odr;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAppNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn App_Fav;
        private System.Windows.Forms.DataGridViewImageColumn App_Img;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDApp_Command;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAppFriendlyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn restrictedBDAppDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAppGoverningDLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAppAdminContactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAppVersionNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAppInstallFileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDAppStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateProcessDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem AdmintoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dTaSAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBDAppIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBDAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDAppAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendingApprovalsToolStripMenuItem;
    }
}

