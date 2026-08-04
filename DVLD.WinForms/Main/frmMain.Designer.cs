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
            drivingLicensesToolStripMenuItem = new ToolStripMenuItem();
            NewDrivingLicenseToolStripMenuItem = new ToolStripMenuItem();
            localLicenseToolStripMenuItem2 = new ToolStripMenuItem();
            internationalLicenseToolStripMenuItem2 = new ToolStripMenuItem();
            renewDrivingLicenseToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator6 = new ToolStripSeparator();
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            releaseDetainedDrivingLicenseToolStripMenuItem2 = new ToolStripMenuItem();
            retakeTestToolStripMenuItem2 = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tsMManageApplications = new ToolStripMenuItem();
            manageLocalDrivingLicenseApplicationsToolStripMenuItem = new ToolStripMenuItem();
            ManageInternationaDrivingLicenseToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            DetainLicensesToolStripMenuItem1 = new ToolStripMenuItem();
            ManageDetainedLicensestoolStripMenuItem1 = new ToolStripMenuItem();
            detainLicenseToolStripMenuItem = new ToolStripMenuItem();
            releaseDetainedLicenseToolStripMenuItem = new ToolStripMenuItem();
            manageApplicationTypesToolStripMenuItem = new ToolStripMenuItem();
            manageTestTypesToolStripMenuItem = new ToolStripMenuItem();
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
            servicesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { drivingLicensesToolStripMenuItem, toolStripSeparator3, tsMManageApplications, toolStripSeparator5, DetainLicensesToolStripMenuItem1, manageApplicationTypesToolStripMenuItem, manageTestTypesToolStripMenuItem });
            servicesToolStripMenuItem.Image = WinForms.Properties.Resources.Applications_64;
            servicesToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            servicesToolStripMenuItem.Name = "servicesToolStripMenuItem";
            servicesToolStripMenuItem.Size = new Size(182, 68);
            servicesToolStripMenuItem.Text = "&Applications";
            // 
            // drivingLicensesToolStripMenuItem
            // 
            drivingLicensesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { NewDrivingLicenseToolStripMenuItem, renewDrivingLicenseToolStripMenuItem2, toolStripSeparator6, ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem2, toolStripSeparator7, releaseDetainedDrivingLicenseToolStripMenuItem2, retakeTestToolStripMenuItem2 });
            drivingLicensesToolStripMenuItem.Image = WinForms.Properties.Resources.Driver_License_32;
            drivingLicensesToolStripMenuItem.Name = "drivingLicensesToolStripMenuItem";
            drivingLicensesToolStripMenuItem.Size = new Size(282, 26);
            drivingLicensesToolStripMenuItem.Text = "&Driving Licenses Services";
            // 
            // NewDrivingLicenseToolStripMenuItem
            // 
            NewDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { localLicenseToolStripMenuItem2, internationalLicenseToolStripMenuItem2 });
            NewDrivingLicenseToolStripMenuItem.Image = WinForms.Properties.Resources.New_Driving_License_32;
            NewDrivingLicenseToolStripMenuItem.Name = "NewDrivingLicenseToolStripMenuItem";
            NewDrivingLicenseToolStripMenuItem.Size = new Size(399, 26);
            NewDrivingLicenseToolStripMenuItem.Text = "&New Driving License";
            // 
            // localLicenseToolStripMenuItem2
            // 
            localLicenseToolStripMenuItem2.Image = WinForms.Properties.Resources.Local_32;
            localLicenseToolStripMenuItem2.Name = "localLicenseToolStripMenuItem2";
            localLicenseToolStripMenuItem2.Size = new Size(240, 26);
            localLicenseToolStripMenuItem2.Text = "&Local License";
            // 
            // internationalLicenseToolStripMenuItem2
            // 
            internationalLicenseToolStripMenuItem2.Image = WinForms.Properties.Resources.International_32;
            internationalLicenseToolStripMenuItem2.Name = "internationalLicenseToolStripMenuItem2";
            internationalLicenseToolStripMenuItem2.Size = new Size(240, 26);
            internationalLicenseToolStripMenuItem2.Text = "&International License";
            // 
            // renewDrivingLicenseToolStripMenuItem2
            // 
            renewDrivingLicenseToolStripMenuItem2.Image = WinForms.Properties.Resources.Renew_Driving_License_32;
            renewDrivingLicenseToolStripMenuItem2.Name = "renewDrivingLicenseToolStripMenuItem2";
            renewDrivingLicenseToolStripMenuItem2.Size = new Size(399, 26);
            renewDrivingLicenseToolStripMenuItem2.Text = "&Renew Driving License";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(396, 6);
            // 
            // ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem2
            // 
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem2.Image = WinForms.Properties.Resources.Damaged_Driving_License_32;
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem2.Name = "ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem2";
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem2.Size = new Size(399, 26);
            ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem2.Text = "Replacement for Lost or &Damaged License";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(396, 6);
            // 
            // releaseDetainedDrivingLicenseToolStripMenuItem2
            // 
            releaseDetainedDrivingLicenseToolStripMenuItem2.Image = WinForms.Properties.Resources.Detained_Driving_License_32;
            releaseDetainedDrivingLicenseToolStripMenuItem2.Name = "releaseDetainedDrivingLicenseToolStripMenuItem2";
            releaseDetainedDrivingLicenseToolStripMenuItem2.Size = new Size(399, 26);
            releaseDetainedDrivingLicenseToolStripMenuItem2.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem2
            // 
            retakeTestToolStripMenuItem2.Image = WinForms.Properties.Resources.Retake_Test_32;
            retakeTestToolStripMenuItem2.Name = "retakeTestToolStripMenuItem2";
            retakeTestToolStripMenuItem2.Size = new Size(399, 26);
            retakeTestToolStripMenuItem2.Text = "Retake Test";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(279, 6);
            // 
            // tsMManageApplications
            // 
            tsMManageApplications.DropDownItems.AddRange(new ToolStripItem[] { manageLocalDrivingLicenseApplicationsToolStripMenuItem, ManageInternationaDrivingLicenseToolStripMenuItem1 });
            tsMManageApplications.Image = WinForms.Properties.Resources.Manage_Applications_64;
            tsMManageApplications.Name = "tsMManageApplications";
            tsMManageApplications.Size = new Size(282, 26);
            tsMManageApplications.Text = "Manage Applications";
            // 
            // manageLocalDrivingLicenseApplicationsToolStripMenuItem
            // 
            manageLocalDrivingLicenseApplicationsToolStripMenuItem.Image = WinForms.Properties.Resources.LocalDriving_License;
            manageLocalDrivingLicenseApplicationsToolStripMenuItem.Name = "manageLocalDrivingLicenseApplicationsToolStripMenuItem";
            manageLocalDrivingLicenseApplicationsToolStripMenuItem.Size = new Size(341, 26);
            manageLocalDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            // 
            // ManageInternationaDrivingLicenseToolStripMenuItem1
            // 
            ManageInternationaDrivingLicenseToolStripMenuItem1.Image = WinForms.Properties.Resources.International_32;
            ManageInternationaDrivingLicenseToolStripMenuItem1.Name = "ManageInternationaDrivingLicenseToolStripMenuItem1";
            ManageInternationaDrivingLicenseToolStripMenuItem1.Size = new Size(341, 26);
            ManageInternationaDrivingLicenseToolStripMenuItem1.Text = "International License Applications";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(279, 6);
            // 
            // DetainLicensesToolStripMenuItem1
            // 
            DetainLicensesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ManageDetainedLicensestoolStripMenuItem1, detainLicenseToolStripMenuItem, releaseDetainedLicenseToolStripMenuItem });
            DetainLicensesToolStripMenuItem1.Image = WinForms.Properties.Resources.Detain_64;
            DetainLicensesToolStripMenuItem1.Name = "DetainLicensesToolStripMenuItem1";
            DetainLicensesToolStripMenuItem1.Size = new Size(282, 26);
            DetainLicensesToolStripMenuItem1.Text = "Detain Licenses";
            // 
            // ManageDetainedLicensestoolStripMenuItem1
            // 
            ManageDetainedLicensestoolStripMenuItem1.Image = WinForms.Properties.Resources.Detain_32;
            ManageDetainedLicensestoolStripMenuItem1.Name = "ManageDetainedLicensestoolStripMenuItem1";
            ManageDetainedLicensestoolStripMenuItem1.Size = new Size(283, 26);
            ManageDetainedLicensestoolStripMenuItem1.Text = "Manage Detained Licenses";
            // 
            // detainLicenseToolStripMenuItem
            // 
            detainLicenseToolStripMenuItem.Image = WinForms.Properties.Resources.Detain_32;
            detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            detainLicenseToolStripMenuItem.Size = new Size(283, 26);
            detainLicenseToolStripMenuItem.Text = "Detain License";
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            releaseDetainedLicenseToolStripMenuItem.Image = WinForms.Properties.Resources.Driver_License_32;
            releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            releaseDetainedLicenseToolStripMenuItem.Size = new Size(283, 26);
            releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            // 
            // manageApplicationTypesToolStripMenuItem
            // 
            manageApplicationTypesToolStripMenuItem.Image = WinForms.Properties.Resources.Application_Types_64;
            manageApplicationTypesToolStripMenuItem.Name = "manageApplicationTypesToolStripMenuItem";
            manageApplicationTypesToolStripMenuItem.Size = new Size(282, 26);
            manageApplicationTypesToolStripMenuItem.Text = "Manage Application Types";
            manageApplicationTypesToolStripMenuItem.Click += manageApplicationTypesToolStripMenuItem_Click;
            // 
            // manageTestTypesToolStripMenuItem
            // 
            manageTestTypesToolStripMenuItem.Image = WinForms.Properties.Resources.Test_Type_64;
            manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            manageTestTypesToolStripMenuItem.Size = new Size(282, 26);
            manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            manageTestTypesToolStripMenuItem.Click += manageTestTypesToolStripMenuItem_Click;
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
            employeesToolStripMenuItem.Click += employeesToolStripMenuItem_Click;
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
            currentUserInfoToolStripMenuItem.Click += currentUserInfoToolStripMenuItem_Click;
            // 
            // changePasswordToolStripMenuItem
            // 
            changePasswordToolStripMenuItem.Image = WinForms.Properties.Resources.Password_32;
            changePasswordToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            changePasswordToolStripMenuItem.Size = new Size(230, 38);
            changePasswordToolStripMenuItem.Text = "Change Password";
            changePasswordToolStripMenuItem.Click += changePasswordToolStripMenuItem_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(227, 6);
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Image = WinForms.Properties.Resources.sign_out_32__2;
            signOutToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(230, 38);
            signOutToolStripMenuItem.Text = "Sign &Out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
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
        private ToolStripMenuItem drivingLicensesToolStripMenuItem;
        private ToolStripMenuItem tsMManageApplications;
        private ToolStripMenuItem DetainLicensesToolStripMenuItem1;
        private ToolStripMenuItem manageApplicationTypesToolStripMenuItem;
        private ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem manageLocalDrivingLicenseApplicationsToolStripMenuItem;
        private ToolStripMenuItem ManageInternationaDrivingLicenseToolStripMenuItem1;
        private ToolStripMenuItem ManageDetainedLicensestoolStripMenuItem1;
        private ToolStripMenuItem detainLicenseToolStripMenuItem;
        private ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private ToolStripMenuItem NewDrivingLicenseToolStripMenuItem;
        private ToolStripMenuItem renewDrivingLicenseToolStripMenuItem2;
        private ToolStripMenuItem ReplacementLostOrDamagedDrivingLicenseToolStripMenuItem2;
        private ToolStripMenuItem releaseDetainedDrivingLicenseToolStripMenuItem2;
        private ToolStripMenuItem retakeTestToolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem localLicenseToolStripMenuItem2;
        private ToolStripMenuItem internationalLicenseToolStripMenuItem2;
    }
}

