namespace ApplicationLauncher
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
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.UpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblBDAppNumber = new System.Windows.Forms.Label();
            this.lblBDAppName = new System.Windows.Forms.Label();
            this.lblResolver = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.BackColor = System.Drawing.Color.Turquoise;
            this.lblApplicationName.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.ForeColor = System.Drawing.Color.White;
            this.lblApplicationName.Location = new System.Drawing.Point(80, 50);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(420, 60);
            this.lblApplicationName.TabIndex = 0;
            this.lblApplicationName.Text = "DTaS LaunchPad";
            this.lblApplicationName.MouseEnter += new System.EventHandler(this.frmAbout_MouseEnter);
            this.lblApplicationName.MouseLeave += new System.EventHandler(this.frmAbout_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.OrangeRed;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(634, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 25);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(240, 120);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(100, 20);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "Version 0.0.0.0";
            this.labelVersion.MouseEnter += new System.EventHandler(this.frmAbout_MouseEnter);
            this.labelVersion.MouseLeave += new System.EventHandler(this.frmAbout_MouseLeave);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(12, 236);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status ...";
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Tick += new System.EventHandler(this.UpdateTimer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.BackColor = System.Drawing.Color.Transparent;
            this.lblHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.White;
            this.lblHelp.Location = new System.Drawing.Point(12, 181);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(39, 13);
            this.lblHelp.TabIndex = 5;
            this.lblHelp.Text = "lblHelp";
            this.lblHelp.Visible = false;
            this.lblHelp.MouseEnter += new System.EventHandler(this.frmAbout_MouseEnter);
            this.lblHelp.MouseLeave += new System.EventHandler(this.frmAbout_MouseLeave);
            // 
            // lblBDAppNumber
            // 
            this.lblBDAppNumber.AutoSize = true;
            this.lblBDAppNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblBDAppNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDAppNumber.ForeColor = System.Drawing.Color.White;
            this.lblBDAppNumber.Location = new System.Drawing.Point(12, 199);
            this.lblBDAppNumber.Name = "lblBDAppNumber";
            this.lblBDAppNumber.Size = new System.Drawing.Size(88, 13);
            this.lblBDAppNumber.TabIndex = 6;
            this.lblBDAppNumber.Text = "lblBDAppNumber";
            this.lblBDAppNumber.Visible = false;
            this.lblBDAppNumber.MouseEnter += new System.EventHandler(this.frmAbout_MouseEnter);
            this.lblBDAppNumber.MouseLeave += new System.EventHandler(this.frmAbout_MouseLeave);
            // 
            // lblBDAppName
            // 
            this.lblBDAppName.AutoSize = true;
            this.lblBDAppName.BackColor = System.Drawing.Color.Transparent;
            this.lblBDAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDAppName.ForeColor = System.Drawing.Color.White;
            this.lblBDAppName.Location = new System.Drawing.Point(12, 217);
            this.lblBDAppName.Name = "lblBDAppName";
            this.lblBDAppName.Size = new System.Drawing.Size(79, 13);
            this.lblBDAppName.TabIndex = 7;
            this.lblBDAppName.Text = "lblBDAppName";
            this.lblBDAppName.Visible = false;
            this.lblBDAppName.MouseEnter += new System.EventHandler(this.frmAbout_MouseEnter);
            this.lblBDAppName.MouseLeave += new System.EventHandler(this.frmAbout_MouseLeave);
            // 
            // lblResolver
            // 
            this.lblResolver.AutoSize = true;
            this.lblResolver.BackColor = System.Drawing.Color.Transparent;
            this.lblResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolver.ForeColor = System.Drawing.Color.White;
            this.lblResolver.Location = new System.Drawing.Point(12, 235);
            this.lblResolver.Name = "lblResolver";
            this.lblResolver.Size = new System.Drawing.Size(59, 13);
            this.lblResolver.TabIndex = 8;
            this.lblResolver.Text = "lblResolver";
            this.lblResolver.Visible = false;
            this.lblResolver.MouseEnter += new System.EventHandler(this.frmAbout_MouseEnter);
            this.lblResolver.MouseLeave += new System.EventHandler(this.frmAbout_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ApplicationLauncher.Properties.Resources.world;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(580, 260);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResolver);
            this.Controls.Add(this.lblBDAppName);
            this.Controls.Add(this.lblBDAppNumber);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblApplicationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAbout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAbout_FormClosed);
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.MouseEnter += new System.EventHandler(this.frmAbout_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.frmAbout_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelVersion;
        protected internal System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer1;
        protected internal System.Windows.Forms.Label lblHelp;
        protected internal System.Windows.Forms.Label lblBDAppNumber;
        protected internal System.Windows.Forms.Label lblBDAppName;
        protected internal System.Windows.Forms.Label lblResolver;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
