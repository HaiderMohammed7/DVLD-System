namespace DVLD.People
{
    partial class frmListPeople
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
            dgvPeople = new DataGridView();
            cmsPeople = new ContextMenuStrip(components);
            showDetailsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            txtFilterValue = new TextBox();
            cbFilterBy = new ComboBox();
            label2 = new Label();
            lblRecordsCount = new Label();
            lblTitle = new Label();
            pbPersonImage = new PictureBox();
            btnAddPerson = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            cmsPeople.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).BeginInit();
            SuspendLayout();
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToResizeRows = false;
            dgvPeople.BackgroundColor = Color.White;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.ContextMenuStrip = cmsPeople;
            dgvPeople.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPeople.Location = new Point(12, 291);
            dgvPeople.Margin = new Padding(4, 5, 4, 5);
            dgvPeople.MultiSelect = false;
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.Size = new Size(1484, 371);
            dgvPeople.TabIndex = 0;
            dgvPeople.TabStop = false;
            // 
            // cmsPeople
            // 
            cmsPeople.Items.AddRange(new ToolStripItem[] { showDetailsToolStripMenuItem, toolStripSeparator2, toolStripMenuItem1, editToolStripMenuItem, deleteToolStripMenuItem });
            cmsPeople.Name = "contextMenuStrip1";
            cmsPeople.Size = new Size(197, 184);
            // 
            // showDetailsToolStripMenuItem
            // 
            showDetailsToolStripMenuItem.Image = WinForms.Properties.Resources.PersonDetails_32;
            showDetailsToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            showDetailsToolStripMenuItem.Size = new Size(196, 38);
            showDetailsToolStripMenuItem.Text = "&Show Details";
            showDetailsToolStripMenuItem.Click += showDetailsToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(193, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = WinForms.Properties.Resources.AddPerson_32;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(196, 38);
            toolStripMenuItem1.Text = "Add &New Person";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Image = WinForms.Properties.Resources.edit_32;
            editToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(196, 38);
            editToolStripMenuItem.Text = "&Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Image = WinForms.Properties.Resources.Delete_32;
            deleteToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(196, 38);
            deleteToolStripMenuItem.Text = "&Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 255);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "Filter By:";
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Location = new Point(307, 252);
            txtFilterValue.Margin = new Padding(4, 5, 4, 5);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(256, 26);
            txtFilterValue.TabIndex = 5;
            txtFilterValue.TextChanged += txtFilterValue_TextChanged;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "None", "Person ID", "National No.", "First Name", "Second Name", "Third Name", "Last Name", "Nationality", "Gender", "Phone", "Email" });
            cbFilterBy.Location = new Point(90, 252);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(210, 28);
            cbFilterBy.TabIndex = 7;
            cbFilterBy.SelectedIndexChanged += cbFilterBy_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 672);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 8;
            label2.Text = "# Records:";
            // 
            // lblRecordsCount
            // 
            lblRecordsCount.AutoSize = true;
            lblRecordsCount.Location = new Point(116, 672);
            lblRecordsCount.Name = "lblRecordsCount";
            lblRecordsCount.Size = new Size(27, 20);
            lblRecordsCount.TabIndex = 9;
            lblRecordsCount.Text = "??";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(613, 208);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 39);
            lblTitle.TabIndex = 88;
            lblTitle.Text = "Manage People";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbPersonImage
            // 
            pbPersonImage.BackgroundImageLayout = ImageLayout.Zoom;
            pbPersonImage.Image = WinForms.Properties.Resources.People_400;
            pbPersonImage.InitialImage = null;
            pbPersonImage.Location = new Point(627, 14);
            pbPersonImage.Margin = new Padding(4, 5, 4, 5);
            pbPersonImage.Name = "pbPersonImage";
            pbPersonImage.Size = new Size(220, 189);
            pbPersonImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbPersonImage.TabIndex = 86;
            pbPersonImage.TabStop = false;
            // 
            // btnAddPerson
            // 
            btnAddPerson.FlatStyle = FlatStyle.Flat;
            btnAddPerson.Image = WinForms.Properties.Resources.Add_Person_40;
            btnAddPerson.Location = new Point(1408, 228);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(88, 55);
            btnAddPerson.TabIndex = 91;
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = WinForms.Properties.Resources.Close_32;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(1361, 672);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 36);
            btnClose.TabIndex = 92;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmListPeople
            // 
            AcceptButton = btnAddPerson;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnClose;
            ClientSize = new Size(1520, 740);
            Controls.Add(btnClose);
            Controls.Add(btnAddPerson);
            Controls.Add(lblTitle);
            Controls.Add(pbPersonImage);
            Controls.Add(lblRecordsCount);
            Controls.Add(label2);
            Controls.Add(cbFilterBy);
            Controls.Add(txtFilterValue);
            Controls.Add(label1);
            Controls.Add(dgvPeople);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmListPeople";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Manage People";
            Load += frmListPeople_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            cmsPeople.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPersonImage).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordsCount;
        private System.Windows.Forms.ContextMenuStrip cmsPeople;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox pbPersonImage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnClose;
    }
}