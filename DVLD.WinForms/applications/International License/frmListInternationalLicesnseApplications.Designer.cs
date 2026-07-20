namespace DVLD.Applications.International_License
{
    partial class frmListInternationalLicesnseApplications
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
            pictureBox1 = new PictureBox();
            btnNewApplication = new Button();
            btnClose = new Button();
            showPersonLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            pbPersonImage = new PictureBox();
            PesonDetailsToolStripMenuItem = new ToolStripMenuItem();
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            cmsApplications = new ContextMenuStrip(components);
            lblTitle = new Label();
            dgvInternationalLicenses = new DataGridView();
            lblInternationalLicensesRecords = new Label();
            label5 = new Label();
            cbIsReleased = new ComboBox();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            cmsApplications.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(669, 81);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 141;
            pictureBox1.TabStop = false;
            // 
            // btnNewApplication
            // 
            btnNewApplication.FlatStyle = FlatStyle.Flat;
            btnNewApplication.Image = WinForms.Properties.Resources.New_Application_64;
            btnNewApplication.Location = new Point(1038, 243);
            btnNewApplication.Name = "btnNewApplication";
            btnNewApplication.Size = new Size(88, 75);
            btnNewApplication.TabIndex = 140;
            btnNewApplication.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(991, 674);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 131;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            showPersonLicenseHistoryToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            showPersonLicenseHistoryToolStripMenuItem.Size = new Size(225, 22);
            showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.Image = WinForms.Properties.Resources.Applications1;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(493, 14);
            pbPersonImage.Margin = new Padding(4, 5, 4, 5);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(220, 189);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 139;
            pbPersonImage.TabStop = false;
            // 
            // PesonDetailsToolStripMenuItem
            // 
            PesonDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            PesonDetailsToolStripMenuItem.Name = "PesonDetailsToolStripMenuItem";
            PesonDetailsToolStripMenuItem.Size = new Size(225, 22);
            PesonDetailsToolStripMenuItem.Text = "Show Person Details";
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(225, 22);
            showDetailsToolStripMenuItem.Text = "&Show License Details";
            // 
            // cmsApplications
            // 
            cmsApplications.Items.AddRange(new ToolStripItem[] { PesonDetailsToolStripMenuItem, showDetailsToolStripMenuItem, showPersonLicenseHistoryToolStripMenuItem });
            cmsApplications.Name = "contextMenuStrip1";
            cmsApplications.Size = new Size(226, 70);
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(311, 208);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(568, 39);
            lblTitle.TabIndex = 135;
            lblTitle.Text = "International License Applications";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvInternationalLicenses
            // 
            dgvInternationalLicenses.AllowUserToAddRows = false;
            dgvInternationalLicenses.AllowUserToDeleteRows = false;
            dgvInternationalLicenses.AllowUserToResizeRows = false;
            dgvInternationalLicenses.BackgroundColor = Color.White;
            dgvInternationalLicenses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicenses.ContextMenuStrip = cmsApplications;
            dgvInternationalLicenses.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInternationalLicenses.Location = new Point(24, 326);
            dgvInternationalLicenses.Margin = new Padding(4, 5, 4, 5);
            dgvInternationalLicenses.MultiSelect = false;
            dgvInternationalLicenses.Name = "dgvInternationalLicenses";
            dgvInternationalLicenses.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInternationalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInternationalLicenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInternationalLicenses.Size = new Size(1102, 340);
            dgvInternationalLicenses.TabIndex = 145;
            dgvInternationalLicenses.TabStop = false;
            // 
            // lblInternationalLicensesRecords
            // 
            lblInternationalLicensesRecords.AutoSize = true;
            lblInternationalLicensesRecords.Location = new Point(118, 675);
            lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            lblInternationalLicensesRecords.Size = new Size(27, 20);
            lblInternationalLicensesRecords.TabIndex = 147;
            lblInternationalLicensesRecords.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 675);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 146;
            label5.Text = "# Records:";
            // 
            // cbIsReleased
            // 
            cbIsReleased.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIsReleased.FormattingEnabled = true;
            cbIsReleased.Items.AddRange(new object[] { "All", "Yes", "No" });
            cbIsReleased.Location = new Point(320, 290);
            cbIsReleased.Name = "cbIsReleased";
            cbIsReleased.Size = new Size(121, 28);
            cbIsReleased.TabIndex = 163;
            cbIsReleased.Visible = false;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "International License ID", "Application ID", "Driver ID", "Local License ID", "Is Active" });
            cbFilterBy.Location = new Point(104, 290);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(210, 28);
            cbFilterBy.TabIndex = 162;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Location = new Point(321, 290);
            txtFilterValue.Margin = new Padding(4, 5, 4, 5);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(256, 26);
            txtFilterValue.TabIndex = 161;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 293);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 160;
            label1.Text = "Filter By:";
            // 
            // frmListInternationalLicesnseApplications
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1139, 720);
            Controls.Add(cbIsReleased);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(lblInternationalLicensesRecords);
            Controls.Add(label5);
            Controls.Add(dgvInternationalLicenses);
            Controls.Add(pictureBox1);
            Controls.Add(btnNewApplication);
            Controls.Add(btnClose);
            Controls.Add(pbPersonImage);
            Controls.Add(lblTitle);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListInternationalLicesnseApplications";
            StartPosition = FormStartPosition.CenterParent;
            Text = "List International Licesnse Applications";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            cmsApplications.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicenses).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNewApplication;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.ToolStripMenuItem PesonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsApplications;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvInternationalLicenses;
        private System.Windows.Forms.Label lblInternationalLicensesRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIsReleased;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
    }
}