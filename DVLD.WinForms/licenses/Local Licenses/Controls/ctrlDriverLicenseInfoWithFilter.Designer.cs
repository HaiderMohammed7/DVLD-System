namespace DVLD.Licenses.Controls
{
    partial class ctrlDriverLicenseInfoWithFilter
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
            gbFilters = new GroupBox();
            btnFind = new Button();
            txtLicenseID = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ctrlDriverLicenseInfo1 = new DVLD.DriverLicense.ctrlDriverLicenseInfo();
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(txtLicenseID);
            gbFilters.Controls.Add(label1);
            gbFilters.Location = new Point(0, 32);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(472, 63);
            gbFilters.TabIndex = 17;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnFind
            // 
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Image = WinForms.Properties.Resources.License_View_32;
            btnFind.Location = new Point(404, 18);
            btnFind.Margin = new Padding(4, 3, 4, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(51, 43);
            btnFind.TabIndex = 18;
            btnFind.UseVisualStyleBackColor = true;
            // 
            // txtLicenseID
            // 
            txtLicenseID.BorderStyle = BorderStyle.FixedSingle;
            txtLicenseID.Location = new Point(132, 30);
            txtLicenseID.Margin = new Padding(5, 6, 5, 6);
            txtLicenseID.Name = "txtLicenseID";
            txtLicenseID.Size = new Size(249, 23);
            txtLicenseID.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 19;
            label1.Text = "LicenseID:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlDriverLicenseInfo1
            // 
            ctrlDriverLicenseInfo1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlDriverLicenseInfo1.Location = new Point(0, 129);
            ctrlDriverLicenseInfo1.Margin = new Padding(4, 5, 4, 5);
            ctrlDriverLicenseInfo1.Name = "ctrlDriverLicenseInfo1";
            ctrlDriverLicenseInfo1.Size = new Size(867, 335);
            ctrlDriverLicenseInfo1.TabIndex = 0;
            // 
            // ctrlDriverLicenseInfoWithFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(gbFilters);
            Controls.Add(ctrlDriverLicenseInfo1);
            Name = "ctrlDriverLicenseInfoWithFilter";
            Size = new Size(868, 464);
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private DriverLicense.ctrlDriverLicenseInfo ctrlDriverLicenseInfo1;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtLicenseID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
