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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            btnRegister = new Button();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            lblLogin = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.Control;
            btnLogin.Location = new Point(196, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.Control;
            btnRegister.Location = new Point(344, 253);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = SystemColors.Control;
            tbUsername.Location = new Point(196, 138);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(242, 27);
            tbUsername.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.Control;
            tbPassword.Location = new Point(196, 196);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(242, 27);
            tbPassword.TabIndex = 3;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(78, 138);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 23);
            lblUsername.TabIndex = 4;
            lblUsername.Text = "Username :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(82, 196);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 23);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password :";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.BackColor = Color.Transparent;
            lblLogin.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.ForeColor = SystemColors.Control;
            lblLogin.Location = new Point(257, 74);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(113, 34);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "LOGIN";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(638, 359);
            Controls.Add(lblLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnRegister;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblLogin;
    }
}