namespace DVLD.WinForms.Forms
{
    partial class frmLogin
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            chkRememberMe = new Guna.UI2.WinForms.Guna2CheckBox();
            btnlogin = new Guna.UI2.WinForms.Guna2Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.CustomizableEdges = customizableEdges1;
            txtEmail.DefaultText = "";
            txtEmail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmail.FillColor = Color.FromArgb(30, 30, 45);
            txtEmail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Font = new Font("Segoe UI", 9F);
            txtEmail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmail.Location = new Point(50, 50);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderForeColor = Color.White;
            txtEmail.PlaceholderText = "Email";
            txtEmail.SelectedText = "";
            txtEmail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmail.Size = new Size(250, 30);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(30, 30, 45);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(50, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderForeColor = Color.White;
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(250, 30);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.BackColor = Color.Transparent;
            chkRememberMe.CheckedState.BorderRadius = 0;
            chkRememberMe.CheckedState.BorderThickness = 0;
            chkRememberMe.CheckMarkColor = Color.FromArgb(30, 30, 45);
            chkRememberMe.ForeColor = Color.White;
            chkRememberMe.Location = new Point(50, 130);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(104, 19);
            chkRememberMe.TabIndex = 0;
            chkRememberMe.Text = "Remember Me";
            chkRememberMe.UncheckedState.BorderRadius = 0;
            chkRememberMe.UncheckedState.BorderThickness = 0;
            chkRememberMe.UseVisualStyleBackColor = false;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(70, 70, 100);
            btnlogin.CustomizableEdges = customizableEdges5;
            btnlogin.DisabledState.BorderColor = Color.DarkGray;
            btnlogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnlogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnlogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnlogin.FillColor = Color.FromArgb(70, 70, 100);
            btnlogin.Font = new Font("Segoe UI", 9F);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(50, 150);
            btnlogin.Name = "btnlogin";
            btnlogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnlogin.Size = new Size(250, 35);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "Login";
            btnlogin.Click += btnlogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(50, 201);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 4;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 45);
            ClientSize = new Size(334, 261);
            Controls.Add(lblError);
            Controls.Add(btnlogin);
            Controls.Add(chkRememberMe);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2CheckBox chkRememberMe;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnlogin;
        private Label lblError;
    }
}