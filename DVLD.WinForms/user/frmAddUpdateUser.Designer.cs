namespace DVLD.User
{
    partial class frmAddUpdateUser
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
            components = new System.ComponentModel.Container();
            tcUserInfo = new TabControl();
            tpPersonalInfo = new TabPage();
            ctrlPersonCardWithFilter1 = new DVLD.Controls.ctrlPersonCardWithFilter();
            btnPersonInfoNext = new Button();
            tpLoginInfo = new TabPage();
            pictureBox2 = new PictureBox();
            lblUserID = new Label();
            label4 = new Label();
            chkIsActive = new CheckBox();
            txtUserName = new TextBox();
            txtConfirmPassword = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblTitle = new Label();
            errorProvider1 = new ErrorProvider(components);
            btnClose = new Button();
            btnSave = new Button();
            tcUserInfo.SuspendLayout();
            tpPersonalInfo.SuspendLayout();
            tpLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // tcUserInfo
            // 
            tcUserInfo.Controls.Add(tpPersonalInfo);
            tcUserInfo.Controls.Add(tpLoginInfo);
            tcUserInfo.Location = new Point(12, 97);
            tcUserInfo.Name = "tcUserInfo";
            tcUserInfo.SelectedIndex = 0;
            tcUserInfo.Size = new Size(863, 498);
            tcUserInfo.TabIndex = 117;
            // 
            // tpPersonalInfo
            // 
            tpPersonalInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tpPersonalInfo.Controls.Add(btnPersonInfoNext);
            tpPersonalInfo.Location = new Point(4, 29);
            tpPersonalInfo.Name = "tpPersonalInfo";
            tpPersonalInfo.Padding = new Padding(3);
            tpPersonalInfo.Size = new Size(855, 465);
            tpPersonalInfo.TabIndex = 0;
            tpPersonalInfo.Text = "Personal Info";
            tpPersonalInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            ctrlPersonCardWithFilter1.BackColor = Color.White;
            ctrlPersonCardWithFilter1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCardWithFilter1.Location = new Point(11, 11);
            ctrlPersonCardWithFilter1.Margin = new Padding(4, 5, 4, 5);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(837, 399);
            ctrlPersonCardWithFilter1.TabIndex = 121;
            // 
            // btnPersonInfoNext
            // 
            btnPersonInfoNext.FlatStyle = FlatStyle.Popup;
            btnPersonInfoNext.Image = WinForms.Properties.Resources.Next_32;
            btnPersonInfoNext.ImageAlign = ContentAlignment.MiddleRight;
            btnPersonInfoNext.Location = new Point(711, 420);
            btnPersonInfoNext.Margin = new Padding(4, 5, 4, 5);
            btnPersonInfoNext.Name = "btnPersonInfoNext";
            btnPersonInfoNext.Size = new Size(126, 37);
            btnPersonInfoNext.TabIndex = 119;
            btnPersonInfoNext.Text = "Next";
            btnPersonInfoNext.UseVisualStyleBackColor = true;
            btnPersonInfoNext.Click += btnPersonInfoNext_Click;
            // 
            // tpLoginInfo
            // 
            tpLoginInfo.Controls.Add(pictureBox2);
            tpLoginInfo.Controls.Add(lblUserID);
            tpLoginInfo.Controls.Add(label4);
            tpLoginInfo.Controls.Add(chkIsActive);
            tpLoginInfo.Controls.Add(txtUserName);
            tpLoginInfo.Controls.Add(txtConfirmPassword);
            tpLoginInfo.Controls.Add(label1);
            tpLoginInfo.Controls.Add(label3);
            tpLoginInfo.Controls.Add(label2);
            tpLoginInfo.Controls.Add(txtPassword);
            tpLoginInfo.Controls.Add(pictureBox1);
            tpLoginInfo.Controls.Add(pictureBox8);
            tpLoginInfo.Controls.Add(pictureBox3);
            tpLoginInfo.Location = new Point(4, 24);
            tpLoginInfo.Name = "tpLoginInfo";
            tpLoginInfo.Padding = new Padding(3);
            tpLoginInfo.Size = new Size(855, 470);
            tpLoginInfo.TabIndex = 1;
            tpLoginInfo.Text = "LoginInfo";
            tpLoginInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = WinForms.Properties.Resources.Number_32;
            pictureBox2.Location = new Point(193, 58);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 130;
            pictureBox2.TabStop = false;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(233, 58);
            lblUserID.Margin = new Padding(4, 0, 4, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(39, 20);
            lblUserID.TabIndex = 129;
            lblUserID.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(102, 58);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 128;
            label4.Text = "UserID:";
            // 
            // chkIsActive
            // 
            chkIsActive.AutoSize = true;
            chkIsActive.Checked = true;
            chkIsActive.CheckState = CheckState.Checked;
            chkIsActive.Location = new Point(231, 214);
            chkIsActive.Name = "chkIsActive";
            chkIsActive.Size = new Size(88, 24);
            chkIsActive.TabIndex = 127;
            chkIsActive.Text = "Is Active";
            chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(231, 96);
            txtUserName.Margin = new Padding(4, 5, 4, 5);
            txtUserName.MaxLength = 50;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(167, 26);
            txtUserName.TabIndex = 118;
            txtUserName.TextChanged += txtUserName_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(231, 168);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.MaxLength = 50;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(167, 26);
            txtConfirmPassword.TabIndex = 124;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(75, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 120;
            label1.Text = "UserName:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 168);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 125;
            label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(82, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 121;
            label2.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(231, 132);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MaxLength = 50;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(167, 26);
            txtPassword.TabIndex = 119;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WinForms.Properties.Resources.Number_32;
            pictureBox1.Location = new Point(193, 168);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 126;
            pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = WinForms.Properties.Resources.Person_32;
            pictureBox8.Location = new Point(193, 94);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(31, 26);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 123;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = WinForms.Properties.Resources.Number_32;
            pictureBox3.Location = new Point(193, 131);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 122;
            pictureBox3.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(12, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(863, 39);
            lblTitle.TabIndex = 118;
            lblTitle.Text = "Edit Application Type";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(611, 603);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 37);
            btnClose.TabIndex = 113;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = WinForms.Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(745, 603);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(126, 37);
            btnSave.TabIndex = 112;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmAddUpdateUser
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            CancelButton = btnClose;
            ClientSize = new Size(881, 665);
            Controls.Add(lblTitle);
            Controls.Add(tcUserInfo);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmAddUpdateUser";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Update User";
            Load += frmAddUpdateUser_Load;
            tcUserInfo.ResumeLayout(false);
            tpPersonalInfo.ResumeLayout(false);
            tpLoginInfo.ResumeLayout(false);
            tpLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tpPersonalInfo;
        private System.Windows.Forms.TabPage tpLoginInfo;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnPersonInfoNext;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}