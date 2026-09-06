namespace DVLD.Applications
{
    partial class frmAddUpdateLocalDrivingLicesnseApplication
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
            lblTitle = new Label();
            tcApplicationInfo = new TabControl();
            tpPersonalInfo = new TabPage();
            btnApplicationInfoNext = new Button();
            ctrlPersonCardWithFilter1 = new DVLD.Controls.ctrlPersonCardWithFilter();
            tpApplicationInfo = new TabPage();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblCreatedByUser = new Label();
            lblFees = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            cbLicenseClass = new ComboBox();
            pictureBox6 = new PictureBox();
            label15 = new Label();
            lblApplicationDate = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            lblLocalDrivingLicebseApplicationID = new Label();
            label4 = new Label();
            btnClose = new Button();
            btnSave = new Button();
            tcApplicationInfo.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tpApplicationInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(12, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(869, 39);
            lblTitle.TabIndex = 122;
            lblTitle.Text = "Local Driving License Application";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tcApplicationInfo
            // 
            tcApplicationInfo.Controls.Add(tpPersonalInfo);
            tcApplicationInfo.Controls.Add(tpApplicationInfo);
            tcApplicationInfo.Location = new Point(12, 80);
            tcApplicationInfo.Name = "tcApplicationInfo";
            tcApplicationInfo.SelectedIndex = 0;
            tcApplicationInfo.Size = new Size(856, 498);
            tcApplicationInfo.TabIndex = 121;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.Controls.Add(btnApplicationInfoNext);
            tpPersonalInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonalInfo.Location = new Point(4, 29);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(3);
            tpPersonalInfo.Size = new Size(848, 465);
            tpPersonalInfo.TabIndex = 0;
            tpPersonalInfo.Text = "Personal Info";
            tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // btnApplicationInfoNext
            // 
            btnApplicationInfoNext.FlatStyle = FlatStyle.Popup;
            btnApplicationInfoNext.Image = WinForms.Properties.Resources.Next_321;
            btnApplicationInfoNext.ImageAlign = ContentAlignment.MiddleRight;
            btnApplicationInfoNext.Location = new Point(706, 404);
            btnApplicationInfoNext.Margin = new Padding(4, 5, 4, 5);
            btnApplicationInfoNext.Name = "btnApplicationInfoNext";
            btnApplicationInfoNext.Size = new Size(126, 37);
            btnApplicationInfoNext.TabIndex = 119;
            btnApplicationInfoNext.Text = "Next";
            btnApplicationInfoNext.UseVisualStyleBackColor = true;
            btnApplicationInfoNext.Click += btnApplicationInfoNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            ctrlPersonCardWithFilter1.BackColor = Color.White;
            ctrlPersonCardWithFilter1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCardWithFilter1.Location = new Point(5, 8);
            ctrlPersonCardWithFilter1.Margin = new Padding(4, 5, 4, 5);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(837, 405);
            ctrlPersonCardWithFilter1.TabIndex = 123;
            // 
            // tpApplicationInfo
            // 
            tpApplicationInfo.Controls.Add(pictureBox2);
            tpApplicationInfo.Controls.Add(pictureBox1);
            tpApplicationInfo.Controls.Add(label1);
            tpApplicationInfo.Controls.Add(lblCreatedByUser);
            tpApplicationInfo.Controls.Add(lblFees);
            tpApplicationInfo.Controls.Add(label2);
            tpApplicationInfo.Controls.Add(pictureBox3);
            tpApplicationInfo.Controls.Add(cbLicenseClass);
            tpApplicationInfo.Controls.Add(pictureBox6);
            tpApplicationInfo.Controls.Add(label15);
            tpApplicationInfo.Controls.Add(lblApplicationDate);
            tpApplicationInfo.Controls.Add(pictureBox4);
            tpApplicationInfo.Controls.Add(label5);
            tpApplicationInfo.Controls.Add(lblLocalDrivingLicebseApplicationID);
            tpApplicationInfo.Controls.Add(label4);
            tpApplicationInfo.Location = new Point(4, 24);
            tpApplicationInfo.Name = "tpApplicationInfo";
            tpApplicationInfo.Padding = new Padding(3);
            tpApplicationInfo.Size = new Size(848, 470);
            tpApplicationInfo.TabIndex = 1;
            tpApplicationInfo.Text = "Application Info.";
            tpApplicationInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(229, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 144;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(228, 210);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 143;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 210);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 142;
            label1.Text = "Created By:";
            // 
            // lblCreatedByUser
            // 
            lblCreatedByUser.AutoSize = true;
            lblCreatedByUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedByUser.Location = new Point(267, 210);
            lblCreatedByUser.Margin = new Padding(4, 0, 4, 0);
            lblCreatedByUser.Name = "lblCreatedByUser";
            lblCreatedByUser.Size = new Size(59, 20);
            lblCreatedByUser.TabIndex = 141;
            lblCreatedByUser.Text = "[????]";
            // 
            // lblFees
            // 
            lblFees.AutoSize = true;
            lblFees.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFees.Location = new Point(267, 174);
            lblFees.Margin = new Padding(4, 0, 4, 0);
            lblFees.Name = "lblFees";
            lblFees.Size = new Size(49, 20);
            lblFees.TabIndex = 140;
            lblFees.Text = "[$$$]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 172);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 20);
            label2.TabIndex = 138;
            label2.Text = "Application Fees:";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(228, 173);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 139;
            pictureBox3.TabStop = false;
            // 
            // cbLicenseClass
            // 
            cbLicenseClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLicenseClass.FormattingEnabled = true;
            cbLicenseClass.Location = new Point(267, 135);
            cbLicenseClass.Name = "cbLicenseClass";
            cbLicenseClass.Size = new Size(270, 28);
            cbLicenseClass.TabIndex = 134;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(228, 135);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(31, 26);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 136;
            pictureBox6.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(58, 134);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(125, 20);
            label15.TabIndex = 135;
            label15.Text = "License Class:";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApplicationDate.Location = new Point(267, 100);
            lblApplicationDate.Margin = new Padding(4, 0, 4, 0);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(109, 20);
            lblApplicationDate.TabIndex = 133;
            lblApplicationDate.Text = "[??/??/????]";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(229, 94);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(31, 26);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 132;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(58, 96);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 131;
            label5.Text = "Application Date:";
            // 
            // lblLocalDrivingLicebseApplicationID
            // 
            lblLocalDrivingLicebseApplicationID.AutoSize = true;
            lblLocalDrivingLicebseApplicationID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocalDrivingLicebseApplicationID.Location = new Point(267, 58);
            lblLocalDrivingLicebseApplicationID.Margin = new Padding(4, 0, 4, 0);
            lblLocalDrivingLicebseApplicationID.Name = "lblLocalDrivingLicebseApplicationID";
            lblLocalDrivingLicebseApplicationID.Size = new Size(49, 20);
            lblLocalDrivingLicebseApplicationID.TabIndex = 129;
            lblLocalDrivingLicebseApplicationID.Text = "[???]";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(58, 58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(160, 20);
            label4.TabIndex = 128;
            label4.Text = "D.L.Application ID:";
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(605, 586);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 37);
            btnClose.TabIndex = 120;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = WinForms.Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(739, 586);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 37);
            btnSave.TabIndex = 119;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddUpdateLocalDrivingLicesnseApplication
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(877, 632);
            Controls.Add(lblTitle);
            Controls.Add(tcApplicationInfo);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAddUpdateLocalDrivingLicesnseApplication";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmAddUpdateApplication";
            Load += frmAddUpdateLocalDrivingLicesnseApplication_Load;
            tcApplicationInfo.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tpApplicationInfo.ResumeLayout(false);
            tpApplicationInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tcApplicationInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.Button btnApplicationInfoNext;
        private System.Windows.Forms.TabPage tpApplicationInfo;
        private System.Windows.Forms.Label lblLocalDrivingLicebseApplicationID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbLicenseClass;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblFees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCreatedByUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}