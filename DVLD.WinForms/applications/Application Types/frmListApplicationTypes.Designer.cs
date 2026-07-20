namespace DVLD.Applications
{
    partial class frmManageApplicationTypes
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
            dgvApplicationTypes = new DataGridView();
            cmsApplicationTypes = new ContextMenuStrip(components);
            toolStripSeparator2 = new ToolStripSeparator();
            editToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnClose = new Button();
            pbApplicationTypesmage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).BeginInit();
            cmsApplicationTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbApplicationTypesmage).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(145, 211);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(446, 39);
            lblTitle.TabIndex = 111;
            lblTitle.Text = "Manage Application Types";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(129, 640);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(27, 20);
            lblRecordsCount.TabIndex = 109;
            lblRecordsCount.Text = "??";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 640);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 108;
            label2.Text = "# Records:";
            // 
            // dgvApplicationTypes
            // 
            dgvApplicationTypes.AllowUserToAddRows = false;
            dgvApplicationTypes.AllowUserToDeleteRows = false;
            dgvApplicationTypes.AllowUserToResizeRows = false;
            dgvApplicationTypes.BackgroundColor = Color.White;
            dgvApplicationTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApplicationTypes.ContextMenuStrip = cmsApplicationTypes;
            dgvApplicationTypes.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvApplicationTypes.Location = new Point(25, 271);
            dgvApplicationTypes.Margin = new Padding(4, 5, 4, 5);
            dgvApplicationTypes.MultiSelect = false;
            dgvApplicationTypes.Name = "dgvApplicationTypes";
            dgvApplicationTypes.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvApplicationTypes.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvApplicationTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvApplicationTypes.Size = new Size(679, 354);
            dgvApplicationTypes.TabIndex = 104;
            dgvApplicationTypes.TabStop = false;
            // 
            // cmsApplicationTypes
            // 
            cmsApplicationTypes.Items.AddRange(new ToolStripItem[] { toolStripSeparator2, editToolStripMenuItem, toolStripSeparator1 });
            cmsApplicationTypes.Name = "contextMenuStrip1";
            cmsApplicationTypes.Size = new Size(187, 38);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(183, 6);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(186, 22);
            editToolStripMenuItem.Text = "&Edit Application Type";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(183, 6);
            // 
            // btnClose
            // 
            btnClose.AutoEllipsis = true;
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(569, 633);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // pbApplicationTypesmage
            // 
            pbApplicationTypesmage.BackgroundImageLayout = ImageLayout.Zoom;
            pbApplicationTypesmage.Image = WinForms.Properties.Resources.Application_Types_512;
            pbApplicationTypesmage.InitialImage = null;
            pbApplicationTypesmage.Location = new Point(269, 6);
            pbApplicationTypesmage.Margin = new Padding(4, 5, 4, 5);
            pbApplicationTypesmage.Name = "pbApplicationTypesmage";
            pbApplicationTypesmage.Size = new Size(220, 189);
            pbApplicationTypesmage.SizeMode = PictureBoxSizeMode.Zoom;
            pbApplicationTypesmage.TabIndex = 110;
            pbApplicationTypesmage.TabStop = false;
            // 
            // frmManageApplicationTypes
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnClose;
            ClientSize = new Size(719, 695);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(pbApplicationTypesmage);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(dgvApplicationTypes);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmManageApplicationTypes";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage Application Types";
            ((System.ComponentModel.ISupportInitialize)dgvApplicationTypes).EndInit();
            cmsApplicationTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbApplicationTypesmage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbApplicationTypesmage;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvApplicationTypes;
        private System.Windows.Forms.ContextMenuStrip cmsApplicationTypes;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}