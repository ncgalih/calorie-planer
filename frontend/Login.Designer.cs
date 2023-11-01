namespace frontend
{
    partial class Login
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
            btnLogin = new Button();
            btnClose = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(227, 254);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(375, 254);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(227, 142);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(242, 27);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(227, 196);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(242, 27);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(118, 145);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(82, 20);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username :";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(123, 199);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password :";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(290, 71);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(103, 41);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 359);
            Controls.Add(lblLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnClose;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblLogin;
    }
}