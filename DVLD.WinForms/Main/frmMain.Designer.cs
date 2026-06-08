namespace DVLD
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
            msMainMenue = new MenuStrip();
            servicesToolStripMenuItem = new ToolStripMenuItem();
            peopleToolStripMenuItem = new ToolStripMenuItem();
            driversToolStripMenuItem = new ToolStripMenuItem();
            employeesToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            currentUserInfoToolStripMenuItem = new ToolStripMenuItem();
            changePasswordToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            lblLoggedInUser = new Label();
            panel1 = new Panel();
            oNewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            releaseDetainedDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            retakeTestToolStripMenuItem1 = new ToolStripMenuItem();
            msMainMenue.SuspendLayout();
            SuspendLayout();
            // 
            // msMainMenue
            // 
            msMainMenue.BackColor = Color.White;
            msMainMenue.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            msMainMenue.Items.AddRange(new ToolStripItem[] { servicesToolStripMenuItem, peopleToolStripMenuItem, driversToolStripMenuItem, employeesToolStripMenuItem, closeToolStripMenuItem });
            msMainMenue.LayoutStyle = ToolStripLayoutStyle.Flow;
            msMainMenue.Location = new Point(0, 0);
            msMainMenue.Name = "msMainMenue";
            msMainMenue.Padding = new Padding(8, 2, 0, 2);
            msMainMenue.Size = new Size(884, 91);
            msMainMenue.TabIndex = 1;
            msMainMenue.Text = "menuStrip1";
            // 
            // servicesToolStripMenuItem
            // 
            servicesToolStripMenuItem.Image = WinForms.Properties.Resources.Applications_64;
            servicesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(182, 68);
            servicesToolStripMenuItem.Text = "&Applications";
            // 
            // peopleToolStripMenuItem
            // 
            peopleToolStripMenuItem.Image = (Image)resources.GetObject("peopleToolStripMenuItem.Image");
            peopleToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            peopleToolStripMenuItem.Size = new Size(139, 68);
            peopleToolStripMenuItem.Text = "People";
            peopleToolStripMenuItem.Click += peopleToolStripMenuItem_Click;
            // 
            // driversToolStripMenuItem
            // 
            driversToolStripMenuItem.Image = WinForms.Properties.Resources.Drivers_64;
            driversToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            driversToolStripMenuItem.Size = new Size(140, 68);
            driversToolStripMenuItem.Text = "Drivers";
            // 
            // employeesToolStripMenuItem
            // 
            employeesToolStripMenuItem.Image = WinForms.Properties.Resources.Users_2_64;
            employeesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            employeesToolStripMenuItem.Size = new Size(127, 68);
            employeesToolStripMenuItem.Text = "Users";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { currentUserInfoToolStripMenuItem, changePasswordToolStripMenuItem, toolStripSeparator4, signOutToolStripMenuItem });
            closeToolStripMenuItem.Image = WinForms.Properties.Resources.account_settings_64;
            closeToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(215, 68);
            closeToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            currentUserInfoToolStripMenuItem.Image = WinForms.Properties.Resources.PersonDetails_32;
            currentUserInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            currentUserInfoToolStripMenuItem.Size = new Size(230, 38);
            currentUserInfoToolStripMenuItem.Text = "&Current User Info";
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(230, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(227, 6);
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(230, 38);
            signOutToolStripMenuItem.Text = "Sign &Out";
            // 
            // lblLoggedInUser
            // 
            lblLoggedInUser.AutoSize = true;
            lblLoggedInUser.BackColor = SystemColors.Control;
            lblLoggedInUser.Location = new Point(1201, 1067);
            lblLoggedInUser.Name = "lblLoggedInUser";
            lblLoggedInUser.Size = new Size(81, 16);
            lblLoggedInUser.TabIndex = 4;
            lblLoggedInUser.Text = "[UserName]";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 37, 38);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 91);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 470);
            panel1.TabIndex = 6;
            // 
            // oNewDrivingLicenseToolStripMenuItem
            // 
            oNewDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem, internationalLicenseToolStripMenuItem });
            oNewDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            oNewDrivingLicenseToolStripMenuItem.Name = "oNewDrivingLicenseToolStripMenuItem";
            oNewDrivingLicenseToolStripMenuItem.Size = new Size(399, 26);
            oNewDrivingLicenseToolStripMenuItem.Text = "&New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            localLicenseToolStripMenuItem.Size = new Size(183, 22);
            localLicenseToolStripMenuItem.Text = "&Local License";
            // 
            // internationalLicenseToolStripMenuItem
            // 
            internationalLicenseToolStripMenuItem.BackColor = Color.White;
            internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            internationalLicenseToolStripMenuItem.Size = new Size(183, 22);
            internationalLicenseToolStripMenuItem.Text = "&International License";
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            renewDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            renewDrivingLicenseToolStripMenuItem.Size = new Size(399, 26);
            renewDrivingLicenseToolStripMenuItem.Text = "&Renew Driving License";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(396, 6);
            // 
            // ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem
            // 
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.Name = "ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem";
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.Size = new Size(399, 26);
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem.Text = "Replacement for Lost or &Damaged License";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(396, 6);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem
            // 
            releaseDetainedDrivingLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            releaseDetainedDrivingLicenseToolStripMenuItem.Name = "releaseDetainedDrivingLicenseToolStripMenuItem";
            releaseDetainedDrivingLicenseToolStripMenuItem.Size = new Size(399, 26);
            releaseDetainedDrivingLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem1
            // 
            retakeTestToolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            retakeTestToolStripMenuItem1.Name = "retakeTestToolStripMenuItem1";
            retakeTestToolStripMenuItem1.Size = new Size(399, 26);
            retakeTestToolStripMenuItem1.Text = "Retake Test";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(884, 561);
            Controls.Add(panel1);
            Controls.Add(lblLoggedInUser);
            Controls.Add(msMainMenue);
            DoubleBuffered = true;
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = msMainMenue;
            Margin = new Padding(4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            WindowState = FormWindowState.Maximized;
            msMainMenue.ResumeLayout(false);
            msMainMenue.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMainMenue;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private Panel panel1;
        private ToolStripMenuItem oNewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem localLicenseToolStripMenuItem;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem retakeTestToolStripMenuItem1;
        private ToolStripMenuItem servicesToolStripMenuItem;
    }
}

