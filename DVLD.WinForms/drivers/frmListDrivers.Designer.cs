namespace DVLD.Drivers
{
    partial class frmListDrivers
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
            lblTitle = new Label();
            lblRecordsCount = new Label();
            label2 = new Label();
            dgvDrivers = new DataGridView();
            cmsDrivers = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            issueInternationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            pbDriverImage = new PictureBox();
            btnClose = new Button();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            cmsDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbDriverImage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(376, 226);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(446, 39);
            lblTitle.TabIndex = 123;
            lblTitle.Text = "Manage Drivers";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(121, 699);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(27, 20);
            lblRecordsCount.TabIndex = 121;
            lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 699);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 120;
            label2.Text = "# Records:";
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AllowUserToResizeRows = false;
            dgvDrivers.BackgroundColor = Color.White;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.ContextMenuStrip = cmsDrivers;
            dgvDrivers.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvDrivers.Location = new Point(17, 330);
            dgvDrivers.Margin = new Padding(4, 5, 4, 5);
            dgvDrivers.MultiSelect = false;
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrivers.Size = new Size(1097, 354);
            dgvDrivers.TabIndex = 119;
            dgvDrivers.TabStop = false;
            // 
            // cmsDrivers
            // 
            cmsDrivers.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator2, issueInternationalLicenseToolStripMenuItem, toolStripSeparator1, showPersonLicenseHistoryToolStripMenuItem });
            cmsDrivers.Name = "contextMenuStrip1";
            cmsDrivers.Size = new Size(226, 82);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(225, 22);
            showDetailsToolStripMenuItem.Text = "&Show Person Info";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(222, 6);
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            issueInternationalLicenseToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            issueInternationalLicenseToolStripMenuItem.Size = new Size(225, 22);
            issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(222, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(225, 22);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // pbDriverImage
            // 
            pbDriverImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbDriverImage.Image = WinForms.Properties.Resources.Driver_Main;
            pbDriverImage.InitialImage = null;
            pbDriverImage.Location = new Point(440, 3);
            pbDriverImage.Margin = new Padding(4, 5, 4, 5);
            pbDriverImage.Name = "pbDriverImage";
            pbDriverImage.Size = new Size(308, 218);
            pbDriverImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbDriverImage.TabIndex = 122;
            pbDriverImage.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(979, 692);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 118;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Driver ID", "Person ID", "National No.", "Full Name" });
            cbFilterBy.Location = new Point(102, 293);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(210, 28);
            cbFilterBy.TabIndex = 126;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Location = new Point(319, 293);
            txtFilterValue.Margin = new Padding(4, 5, 4, 5);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(256, 26);
            txtFilterValue.TabIndex = 125;
            txtFilterValue.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 296);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 124;
            label1.Text = "Filter By:";
            // 
            // frmListDrivers
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1127, 754);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvDrivers);
            Controls.Add(pbDriverImage);
            Controls.Add(btnClose);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListDrivers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "List Drivers";
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            cmsDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbDriverImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDrivers;
        private System.Windows.Forms.PictureBox pbDriverImage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsDrivers;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}