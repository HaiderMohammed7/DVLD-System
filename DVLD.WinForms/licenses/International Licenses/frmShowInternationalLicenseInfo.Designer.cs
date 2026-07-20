namespace DVLD.Licenses.International_Licenses
{
    partial class frmShowInternationalLicenseInfo
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
            btnClose = new Button();
            lblTitle = new Label();
            pbTestTypeImage = new PictureBox();
            ctrlDriverInternationalLicenseInfo1 = new DVLD.Licenses.International_Licenses.Controls.ctrlDriverInternationalLicenseInfo();
            pictureBox9 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(744, 435);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 37);
            btnClose.TabIndex = 139;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(176, 119);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(520, 39);
            lblTitle.TabIndex = 138;
            lblTitle.Text = "Driver International License Info";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbTestTypeImage
            // 
            pbTestTypeImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbTestTypeImage.Image = WinForms.Properties.Resources.LicenseView_400;
            pbTestTypeImage.InitialImage = null;
            pbTestTypeImage.Location = new Point(393, 9);
            pbTestTypeImage.Margin = new Padding(4, 5, 4, 5);
            pbTestTypeImage.Name = "pbTestTypeImage";
            pbTestTypeImage.Size = new Size(113, 104);
            pbTestTypeImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestTypeImage.TabIndex = 137;
            pbTestTypeImage.TabStop = false;
            // 
            // ctrlDriverInternationalLicenseInfo1
            // 
            ctrlDriverInternationalLicenseInfo1.BackColor = Color.White;
            ctrlDriverInternationalLicenseInfo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDriverInternationalLicenseInfo1.Location = new Point(13, 163);
            ctrlDriverInternationalLicenseInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDriverInternationalLicenseInfo1.Name = "ctrlDriverInternationalLicenseInfo1";
            ctrlDriverInternationalLicenseInfo1.Size = new Size(869, 273);
            ctrlDriverInternationalLicenseInfo1.TabIndex = 140;
            // 
            // pictureBox9
            // 
            pictureBox9.Location = new Point(393, 9);
            pictureBox9.Margin = new Padding(4, 5, 4, 5);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(31, 26);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 190;
            pictureBox9.TabStop = false;
            // 
            // frmShowInternationalLicenseInfo
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnClose;
            ClientSize = new Size(883, 482);
            Controls.Add(pictureBox9);
            Controls.Add(btnClose);
            Controls.Add(ctrlDriverInternationalLicenseInfo1);
            Controls.Add(lblTitle);
            Controls.Add(pbTestTypeImage);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmShowInternationalLicenseInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "International Driver Info";
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private Controls.ctrlDriverInternationalLicenseInfo ctrlDriverInternationalLicenseInfo1;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}