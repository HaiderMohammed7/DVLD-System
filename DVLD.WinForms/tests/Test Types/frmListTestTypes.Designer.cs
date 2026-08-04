namespace DVLD.Tests
{
    partial class frmListTestTypes
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
            dgvTestTypes = new DataGridView();
            cmsTestTypes = new ContextMenuStrip(components);
            toolStripSeparator2 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnClose = new Button();
            pbApplicationTypesmage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).BeginInit();
            cmsTestTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbApplicationTypesmage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(274, 223);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(446, 39);
            lblTitle.TabIndex = 117;
            lblTitle.Text = "Manage Test Types";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(117, 647);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(27, 20);
            lblRecordsCount.TabIndex = 115;
            lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 647);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 114;
            label2.Text = "# Records:";
            // 
            // dgvTestTypes
            // 
            dgvTestTypes.AllowUserToAddRows = false;
            dgvTestTypes.AllowUserToDeleteRows = false;
            dgvTestTypes.AllowUserToResizeRows = false;
            dgvTestTypes.BackgroundColor = Color.White;
            dgvTestTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTestTypes.ContextMenuStrip = cmsTestTypes;
            dgvTestTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvTestTypes.Location = new Point(13, 278);
            dgvTestTypes.Margin = new Padding(4, 5, 4, 5);
            dgvTestTypes.MultiSelect = false;
            dgvTestTypes.Name = "dgvTestTypes";
            dgvTestTypes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTestTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTestTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTestTypes.Size = new Size(931, 354);
            dgvTestTypes.TabIndex = 113;
            dgvTestTypes.TabStop = false;
            // 
            // cmsTestTypes
            // 
            cmsTestTypes.Items.AddRange(new ToolStripItem[] { toolStripSeparator2, editToolStripMenuItem, toolStripSeparator1 });
            cmsTestTypes.Name = "contextMenuStrip1";
            cmsTestTypes.Size = new Size(197, 76);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(193, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = WinForms.Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(196, 38);
            editToolStripMenuItem.Text = "&Edit Test Type";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(193, 6);
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(809, 639);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 112;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pbApplicationTypesmage
            // 
            pbApplicationTypesmage.BackgroundImageLayout = ImageLayout.Zoom;
            pbApplicationTypesmage.Image = WinForms.Properties.Resources.TestType_512;
            pbApplicationTypesmage.InitialImage = null;
            pbApplicationTypesmage.Location = new Point(398, 18);
            pbApplicationTypesmage.Margin = new Padding(4, 5, 4, 5);
            pbApplicationTypesmage.Name = "pbApplicationTypesmage";
            pbApplicationTypesmage.Size = new Size(220, 189);
            pbApplicationTypesmage.SizeMode = PictureBoxSizeMode.Zoom;
            pbApplicationTypesmage.TabIndex = 116;
            pbApplicationTypesmage.TabStop = false;
            // 
            // frmListTestTypes
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClose;
            ClientSize = new Size(954, 692);
            Controls.Add(lblTitle);
            Controls.Add(pbApplicationTypesmage);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvTestTypes);
            Controls.Add(btnClose);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListTestTypes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "List Test Types";
            Load += frmListTestTypes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTestTypes).EndInit();
            cmsTestTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbApplicationTypesmage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbApplicationTypesmage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTestTypes;
        private System.Windows.Forms.ContextMenuStrip cmsTestTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button btnClose;
    }
}