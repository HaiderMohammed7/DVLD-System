namespace DVLD.People
{
    partial class frmShowPersonInfo
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
            btnClose = new Button();
            lblTitle = new Label();
            ctrlPersonCard1 = new DVLD.Controls.ctrlPersonCard();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(714, 381);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(126, 37);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(192, 0, 0);
            lblTitle.Location = new Point(300, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(258, 39);
            lblTitle.TabIndex = 89;
            lblTitle.Text = "Person Details";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ctrlPersonCard1
            // 
            ctrlPersonCard1.BackColor = Color.White;
            ctrlPersonCard1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ctrlPersonCard1.Location = new Point(12, 82);
            ctrlPersonCard1.Margin = new Padding(4, 5, 4, 5);
            ctrlPersonCard1.Name = "ctrlPersonCard1";
            ctrlPersonCard1.Size = new Size(839, 300);
            ctrlPersonCard1.TabIndex = 0;
            // 
            // frmShowPersonInfo
            // 
            AcceptButton = btnClose;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnClose;
            ClientSize = new Size(867, 433);
            Controls.Add(lblTitle);
            Controls.Add(btnClose);
            Controls.Add(ctrlPersonCard1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmShowPersonInfo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Person Details";
            Load += frmShowPersonInfo_Load;
            ResumeLayout(false);

        }

        #endregion

        private Controls.ctrlPersonCard ctrlPersonCard1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
    }
}