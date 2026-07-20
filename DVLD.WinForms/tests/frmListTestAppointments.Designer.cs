namespace DVLD.Tests
{
    partial class frmListTestAppointments
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cmsApplications = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            lblRecordsCount = new Label();
            label2 = new Label();
            dgvLicenseTestAppointments = new DataGridView();
            lblTitle = new Label();
            label1 = new Label();
            btnClose = new Button();
            pbTestTypeImage = new PictureBox();
            btnAddNewAppointment = new Button();
            ctrlDrivingLicenseApplicationInfo1 = new DVLD.Controls.ApplicationControls.ctrlDrivingLicenseApplicationInfo();
            cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).BeginInit();
            SuspendLayout();
            // 
            // cmsApplications
            // 
            cmsApplications.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, takeTestToolStripMenuItem });
            cmsApplications.Name = "contextMenuStrip1";
            cmsApplications.Size = new Size(123, 48);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(122, 22);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(122, 22);
            takeTestToolStripMenuItem.Text = "Take Test";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(118, 738);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(27, 20);
            lblRecordsCount.TabIndex = 131;
            lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 738);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 130;
            label2.Text = "# Records:";
            // 
            // dgvLicenseTestAppointments
            // 
            dgvLicenseTestAppointments.AllowUserToAddRows = false;
            dgvLicenseTestAppointments.AllowUserToDeleteRows = false;
            dgvLicenseTestAppointments.AllowUserToResizeRows = false;
            dgvLicenseTestAppointments.BackgroundColor = Color.White;
            dgvLicenseTestAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLicenseTestAppointments.ContextMenuStrip = cmsApplications;
            dgvLicenseTestAppointments.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLicenseTestAppointments.Location = new Point(20, 571);
            dgvLicenseTestAppointments.Margin = new Padding(4, 5, 4, 5);
            dgvLicenseTestAppointments.MultiSelect = false;
            dgvLicenseTestAppointments.Name = "dgvLicenseTestAppointments";
            dgvLicenseTestAppointments.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLicenseTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLicenseTestAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLicenseTestAppointments.Size = new Size(887, 161);
            dgvLicenseTestAppointments.TabIndex = 129;
            dgvLicenseTestAppointments.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(285, 124);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(441, 39);
            lblTitle.TabIndex = 133;
            lblTitle.Text = "Vision Test Appointments";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 534);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 135;
            label1.Text = "Appointments:";
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(772, 738);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 128;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // pbTestTypeImage
            // 
            pbTestTypeImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbTestTypeImage.Image = WinForms.Properties.Resources.Vision_512;
            pbTestTypeImage.InitialImage = null;
            pbTestTypeImage.Location = new Point(444, 14);
            pbTestTypeImage.Margin = new Padding(4, 5, 4, 5);
            pbTestTypeImage.Name = "pbTestTypeImage";
            pbTestTypeImage.Size = new Size(113, 104);
            pbTestTypeImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbTestTypeImage.TabIndex = 132;
            pbTestTypeImage.TabStop = false;
            // 
            // btnAddNewAppointment
            // 
            btnAddNewAppointment.FlatStyle = FlatStyle.Flat;
            btnAddNewAppointment.Image = WinForms.Properties.Resources.AddAppointment_32;
            btnAddNewAppointment.Location = new Point(858, 530);
            btnAddNewAppointment.Name = "btnAddNewAppointment";
            btnAddNewAppointment.Size = new Size(49, 36);
            btnAddNewAppointment.TabIndex = 137;
            btnAddNewAppointment.UseVisualStyleBackColor = true;
            // 
            // ctrlDrivingLicenseApplicationInfo1
            // 
            ctrlDrivingLicenseApplicationInfo1.BackColor = Color.White;
            ctrlDrivingLicenseApplicationInfo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDrivingLicenseApplicationInfo1.Location = new Point(13, 157);
            ctrlDrivingLicenseApplicationInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDrivingLicenseApplicationInfo1.Name = "ctrlDrivingLicenseApplicationInfo1";
            ctrlDrivingLicenseApplicationInfo1.Size = new Size(909, 365);
            ctrlDrivingLicenseApplicationInfo1.TabIndex = 134;
            // 
            // frmListTestAppointments
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(926, 789);
            Controls.Add(btnAddNewAppointment);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(ctrlDrivingLicenseApplicationInfo1);
            Controls.Add(btnClose);
            Controls.Add(pbTestTypeImage);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvLicenseTestAppointments);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListTestAppointments";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmListTestAppointments";
            cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLicenseTestAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTestTypeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbTestTypeImage;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLicenseTestAppointments;
        private System.Windows.Forms.Label lblTitle;
        private Controls.ApplicationControls.ctrlDrivingLicenseApplicationInfo ctrlDrivingLicenseApplicationInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddNewAppointment;
    }
}