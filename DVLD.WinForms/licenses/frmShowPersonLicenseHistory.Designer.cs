namespace DVLD.Licenses.International_License
{
    partial class frmShowPersonLicenseHistory
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
            pbPersonImage = new PictureBox();
            btnClose = new Button();
            ctrlDriverLicenses1 = new DVLD.Licenses.Local_Licenses.Controls.ctrlDriverLicenses();
            ctrlPersonCardWithFilter1 = new DVLD.Controls.ctrlPersonCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(12, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1062, 39);
            lblTitle.TabIndex = 129;
            lblTitle.Text = "License History";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.Image = WinForms.Properties.Resources.PersonLicenseHistory_512;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(8, 188);
            pbPersonImage.Margin = new Padding(4, 5, 4, 5);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(220, 189);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 130;
            pbPersonImage.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(938, 783);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 131;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // ctrlDriverLicenses1
            // 
            ctrlDriverLicenses1.BackColor = Color.White;
            ctrlDriverLicenses1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDriverLicenses1.Location = new Point(13, 437);
            ctrlDriverLicenses1.Margin = new Padding(4, 5, 4, 5);
            ctrlDriverLicenses1.Name = "ctrlDriverLicenses1";
            ctrlDriverLicenses1.Size = new Size(1061, 342);
            ctrlDriverLicenses1.TabIndex = 2;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            ctrlPersonCardWithFilter1.BackColor = Color.White;
            ctrlPersonCardWithFilter1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCardWithFilter1.Location = new Point(241, 46);
            ctrlPersonCardWithFilter1.Margin = new Padding(4, 5, 4, 5);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.Size = new Size(837, 399);
            ctrlPersonCardWithFilter1.TabIndex = 132;
            // 
            // frmShowPersonLicenseHistory
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnClose;
            ClientSize = new Size(1086, 829);
            Controls.Add(ctrlPersonCardWithFilter1);
            Controls.Add(btnClose);
            Controls.Add(pbPersonImage);
            Controls.Add(lblTitle);
            Controls.Add(ctrlDriverLicenses1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmShowPersonLicenseHistory";
            StartPosition = FormStartPosition.CenterParent;
            Text = "License History";
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private Local_Licenses.Controls.ctrlDriverLicenses ctrlDriverLicenses1;
       

        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private DVLD.Controls.ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
    }
}