namespace DVLD.Licenses.Local_Licenses.Controls
{
    partial class ctrlDriverLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            tcDriverLicenses = new TabControl();
            tpLocalLicenses = new TabPage();
            label1 = new Label();
            lblLocalLicensesRecords = new Label();
            label2 = new Label();
            dgvLocalLicensesHistory = new DataGridView();
            cmsLocalLicenseHistory = new ContextMenuStrip(components);
            showLicenseInfoToolStripMenuItem = new ToolStripMenuItem();
            tbInternationalLicenses = new TabPage();
            label3 = new Label();
            lblInternationalLicensesRecords = new Label();
            label5 = new Label();
            dgvInternationalLicensesHistory = new DataGridView();
            cmsInterenationalLicenseHistory = new ContextMenuStrip(components);
            InternationalLicenseHistorytoolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            tcDriverLicenses.SuspendLayout();
            tpLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicensesHistory).BeginInit();
            cmsLocalLicenseHistory.SuspendLayout();
            tbInternationalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicensesHistory).BeginInit();
            cmsInterenationalLicenseHistory.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tcDriverLicenses);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1055, 334);
            groupBox1.TabIndex = 131;
            groupBox1.TabStop = false;
            groupBox1.Text = "Driver Licenses";
            // 
            // tcDriverLicenses
            // 
            tcDriverLicenses.Controls.Add(tpLocalLicenses);
            tcDriverLicenses.Controls.Add(tbInternationalLicenses);
            tcDriverLicenses.Location = new Point(16, 36);
            tcDriverLicenses.Name = "tcDriverLicenses";
            tcDriverLicenses.SelectedIndex = 0;
            tcDriverLicenses.Size = new Size(1032, 288);
            tcDriverLicenses.TabIndex = 131;
            // 
            // tpLocalLicenses
            // 
            tpLocalLicenses.Controls.Add(label1);
            tpLocalLicenses.Controls.Add(lblLocalLicensesRecords);
            tpLocalLicenses.Controls.Add(label2);
            tpLocalLicenses.Controls.Add(dgvLocalLicensesHistory);
            tpLocalLicenses.Location = new Point(4, 29);
            tpLocalLicenses.Name = "tpLocalLicenses";
            tpLocalLicenses.Padding = new Padding(3);
            tpLocalLicenses.Size = new Size(1024, 255);
            tpLocalLicenses.TabIndex = 0;
            tpLocalLicenses.Text = "Local";
            tpLocalLicenses.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 135;
            label1.Text = "Local Licenses History:";
            // 
            // lblLocalLicensesRecords
            // 
            lblLocalLicensesRecords.AutoSize = true;
            lblLocalLicensesRecords.Location = new Point(105, 219);
            lblLocalLicensesRecords.Name = "lblLocalLicensesRecords";
            lblLocalLicensesRecords.Size = new Size(27, 20);
            lblLocalLicensesRecords.TabIndex = 134;
            lblLocalLicensesRecords.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 219);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 133;
            label2.Text = "# Records:";
            // 
            // dgvLocalLicensesHistory
            // 
            dgvLocalLicensesHistory.AllowUserToAddRows = false;
            dgvLocalLicensesHistory.AllowUserToDeleteRows = false;
            dgvLocalLicensesHistory.AllowUserToResizeRows = false;
            dgvLocalLicensesHistory.BackgroundColor = Color.White;
            dgvLocalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocalLicensesHistory.ContextMenuStrip = cmsLocalLicenseHistory;
            dgvLocalLicensesHistory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvLocalLicensesHistory.Location = new Point(11, 46);
            dgvLocalLicensesHistory.Margin = new Padding(4, 5, 4, 5);
            dgvLocalLicensesHistory.MultiSelect = false;
            dgvLocalLicensesHistory.Name = "dgvLocalLicensesHistory";
            dgvLocalLicensesHistory.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLocalLicensesHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLocalLicensesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocalLicensesHistory.Size = new Size(996, 168);
            dgvLocalLicensesHistory.TabIndex = 132;
            dgvLocalLicensesHistory.TabStop = false;
            // 
            // cmsLocalLicenseHistory
            // 
            cmsLocalLicenseHistory.Items.AddRange(new ToolStripItem[] { showLicenseInfoToolStripMenuItem });
            cmsLocalLicenseHistory.Name = "cmsLocalLicenseHistory";
            cmsLocalLicenseHistory.Size = new Size(186, 42);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            showLicenseInfoToolStripMenuItem.Image = WinForms.Properties.Resources.License_View_322;
            showLicenseInfoToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            showLicenseInfoToolStripMenuItem.Size = new Size(185, 38);
            showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            showLicenseInfoToolStripMenuItem.Click += showLicenseInfoToolStripMenuItem_Click;
            // 
            // tbInternationalLicenses
            // 
            tbInternationalLicenses.Controls.Add(label3);
            tbInternationalLicenses.Controls.Add(lblInternationalLicensesRecords);
            tbInternationalLicenses.Controls.Add(label5);
            tbInternationalLicenses.Controls.Add(dgvInternationalLicensesHistory);
            tbInternationalLicenses.Location = new Point(4, 24);
            tbInternationalLicenses.Name = "tbInternationalLicenses";
            tbInternationalLicenses.Padding = new Padding(3);
            tbInternationalLicenses.Size = new Size(1024, 260);
            tbInternationalLicenses.TabIndex = 1;
            tbInternationalLicenses.Text = "International";
            tbInternationalLicenses.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 17);
            label3.Name = "label3";
            label3.Size = new Size(253, 20);
            label3.TabIndex = 139;
            label3.Text = "International Licenses History:";
            // 
            // lblInternationalLicensesRecords
            // 
            lblInternationalLicensesRecords.AutoSize = true;
            lblInternationalLicensesRecords.Location = new Point(108, 218);
            lblInternationalLicensesRecords.Name = "lblInternationalLicensesRecords";
            lblInternationalLicensesRecords.Size = new Size(27, 20);
            lblInternationalLicensesRecords.TabIndex = 138;
            lblInternationalLicensesRecords.Text = "??";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 218);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 137;
            label5.Text = "# Records:";
            // 
            // dgvInternationalLicensesHistory
            // 
            dgvInternationalLicensesHistory.AllowUserToAddRows = false;
            dgvInternationalLicensesHistory.AllowUserToDeleteRows = false;
            dgvInternationalLicensesHistory.AllowUserToResizeRows = false;
            dgvInternationalLicensesHistory.BackgroundColor = Color.White;
            dgvInternationalLicensesHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternationalLicensesHistory.ContextMenuStrip = cmsInterenationalLicenseHistory;
            dgvInternationalLicensesHistory.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvInternationalLicensesHistory.Location = new Point(14, 45);
            dgvInternationalLicensesHistory.Margin = new Padding(4, 5, 4, 5);
            dgvInternationalLicensesHistory.MultiSelect = false;
            dgvInternationalLicensesHistory.Name = "dgvInternationalLicensesHistory";
            dgvInternationalLicensesHistory.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInternationalLicensesHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInternationalLicensesHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInternationalLicensesHistory.Size = new Size(996, 168);
            dgvInternationalLicensesHistory.TabIndex = 136;
            dgvInternationalLicensesHistory.TabStop = false;
            // 
            // cmsInterenationalLicenseHistory
            // 
            cmsInterenationalLicenseHistory.Items.AddRange(new ToolStripItem[] { InternationalLicenseHistorytoolStripMenuItem });
            cmsInterenationalLicenseHistory.Name = "cmsLocalLicenseHistory";
            cmsInterenationalLicenseHistory.Size = new Size(197, 64);
            // 
            // InternationalLicenseHistorytoolStripMenuItem
            // 
            InternationalLicenseHistorytoolStripMenuItem.Image = WinForms.Properties.Resources.License_View_32;
            InternationalLicenseHistorytoolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            InternationalLicenseHistorytoolStripMenuItem.Name = "InternationalLicenseHistorytoolStripMenuItem";
            InternationalLicenseHistorytoolStripMenuItem.Size = new Size(196, 38);
            InternationalLicenseHistorytoolStripMenuItem.Text = "Show License Info";
            InternationalLicenseHistorytoolStripMenuItem.Click += InternationalLicenseHistorytoolStripMenuItem_Click;
            // 
            // ctrlDriverLicenses
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ctrlDriverLicenses";
            Size = new Size(1061, 342);
            groupBox1.ResumeLayout(false);
            tcDriverLicenses.ResumeLayout(false);
            tpLocalLicenses.ResumeLayout(false);
            tpLocalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLocalLicensesHistory).EndInit();
            cmsLocalLicenseHistory.ResumeLayout(false);
            tbInternationalLicenses.ResumeLayout(false);
            tbInternationalLicenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternationalLicensesHistory).EndInit();
            cmsInterenationalLicenseHistory.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tcDriverLicenses;
        private System.Windows.Forms.TabPage tpLocalLicenses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocalLicensesRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLocalLicensesHistory;
        private System.Windows.Forms.TabPage tbInternationalLicenses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInternationalLicensesRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvInternationalLicensesHistory;
        private System.Windows.Forms.ContextMenuStrip cmsLocalLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsInterenationalLicenseHistory;
        private System.Windows.Forms.ToolStripMenuItem InternationalLicenseHistorytoolStripMenuItem;
    }
}
