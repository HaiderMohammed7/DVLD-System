namespace DVLD.Controls
{
    partial class ctrlPersonCardWithFilter
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
            errorProvider1 = new ErrorProvider(components);
            gbFilters = new GroupBox();
            btnAddNewPerson = new Button();
            btnFind = new Button();
            cbFilterBy = new ComboBox();
            txtFilterValue = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            gbFilters.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // gbFilters
            // 
            gbFilters.Controls.Add(btnAddNewPerson);
            gbFilters.Controls.Add(btnFind);
            gbFilters.Controls.Add(cbFilterBy);
            gbFilters.Controls.Add(txtFilterValue);
            gbFilters.Controls.Add(label1);
            gbFilters.Location = new Point(10, 13);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(819, 77);
            gbFilters.TabIndex = 16;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filter";
            // 
            // btnAddNewPerson
            // 
            btnAddNewPerson.FlatStyle = FlatStyle.Popup;
            btnAddNewPerson.Image = WinForms.Properties.Resources.AddPerson_32;
            btnAddNewPerson.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddNewPerson.Location = new Point(594, 20);
            btnAddNewPerson.Margin = new Padding(4, 5, 4, 5);
            btnAddNewPerson.Name = "btnAddNewPerson";
            btnAddNewPerson.Size = new Size(44, 37);
            btnAddNewPerson.TabIndex = 20;
            btnAddNewPerson.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Image = WinForms.Properties.Resources.SearchPerson;
            btnFind.Location = new Point(543, 20);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(44, 37);
            btnFind.TabIndex = 18;
            btnFind.UseVisualStyleBackColor = true;
            // 
            // cbFilterBy
            // 
            cbFilterBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterBy.FormattingEnabled = true;
            cbFilterBy.Items.AddRange(new object[] { "National No.", "Person ID" });
            cbFilterBy.Location = new Point(96, 25);
            cbFilterBy.Name = "cbFilterBy";
            cbFilterBy.Size = new Size(210, 28);
            cbFilterBy.TabIndex = 16;
            // 
            // txtFilterValue
            // 
            txtFilterValue.BorderStyle = BorderStyle.FixedSingle;
            txtFilterValue.Location = new Point(313, 25);
            txtFilterValue.Margin = new Padding(4, 5, 4, 5);
            txtFilterValue.Name = "txtFilterValue";
            txtFilterValue.Size = new Size(214, 26);
            txtFilterValue.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 28);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 19;
            label1.Text = "Find By:";
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.White;
            ctrlPersonCard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(0, 101);
            ctrlPersonCard1.Margin = new Padding(6, 8, 6, 8);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(836, 299);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.White;
            Controls.Add(gbFilters);
            Controls.Add(ctrlPersonCard1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(837, 399);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbFilters;
        private System.Windows.Forms.Button btnAddNewPerson;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Label label1;
    }
}
