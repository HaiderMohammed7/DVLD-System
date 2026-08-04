namespace DVLD.Tests
{
    partial class frmEditTestType
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
            lblTitle = new Label();
            lblTestTypeID = new Label();
            label4 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtFees = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            btnClose = new Button();
            btnSave = new Button();
            pictureBox8 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtDescription = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(64, 30);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(489, 45);
            lblTitle.TabIndex = 149;
            lblTitle.Text = "Update Test Type";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTestTypeID
            // 
            lblTestTypeID.AutoSize = true;
            lblTestTypeID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTestTypeID.Location = new Point(200, 103);
            lblTestTypeID.Margin = new Padding(5, 0, 5, 0);
            lblTestTypeID.Name = "lblTestTypeID";
            lblTestTypeID.Size = new Size(39, 20);
            lblTestTypeID.TabIndex = 148;
            lblTestTypeID.Text = "???";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(96, 103);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 147;
            label4.Text = "ID:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(197, 147);
            txtTitle.Margin = new Padding(5, 6, 5, 6);
            txtTitle.MaxLength = 50;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(328, 23);
            txtTitle.TabIndex = 141;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 147);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 143;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(78, 306);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 144;
            label2.Text = "Fees";
            // 
            // txtFees
            // 
            txtFees.Location = new Point(197, 306);
            txtFees.Margin = new Padding(5, 6, 5, 6);
            txtFees.MaxLength = 50;
            txtFees.Name = "txtFees";
            txtFees.Size = new Size(328, 23);
            txtFees.TabIndex = 142;
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
            btnClose.Location = new Point(223, 340);
            btnClose.Margin = new Padding(5, 6, 5, 6);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 43);
            btnClose.TabIndex = 151;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.Cancel;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Image = WinForms.Properties.Resources.Save_32;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(379, 340);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(147, 43);
            btnSave.TabIndex = 150;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = WinForms.Properties.Resources.ApplicationTitle;
            pictureBox8.Location = new Point(153, 144);
            pictureBox8.Margin = new Padding(4, 3, 4, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(36, 30);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 146;
            pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = WinForms.Properties.Resources.money_32;
            pictureBox3.Location = new Point(153, 305);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(36, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 145;
            pictureBox3.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(197, 181);
            txtDescription.Margin = new Padding(5, 6, 5, 6);
            txtDescription.MaxLength = 500;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(328, 112);
            txtDescription.TabIndex = 152;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 181);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 153;
            label3.Text = "Description:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = WinForms.Properties.Resources.ApplicationTitle;
            pictureBox1.Location = new Point(153, 179);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 154;
            pictureBox1.TabStop = false;
            // 
            // frmEditTestType
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnClose;
            ClientSize = new Size(547, 405);
            Controls.Add(txtDescription);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(lblTitle);
            Controls.Add(lblTestTypeID);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtFees);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmEditTestType";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Test Type";
            Load += frmEditTestType_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTestTypeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}