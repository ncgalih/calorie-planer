namespace frontend
{
    partial class Register
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
            btnRegister = new Button();
            btnClose = new Button();
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbConfirmPassword = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblRegister = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(258, 346);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(413, 346);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(258, 94);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(249, 27);
            tbFirstName.TabIndex = 2;
            tbFirstName.TextChanged += tbFirstName_TextChanged;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(258, 143);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(249, 27);
            tbLastName.TabIndex = 3;
            tbLastName.TextChanged += tbLastName_TextChanged;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(258, 192);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(249, 27);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(258, 244);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(249, 27);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(258, 293);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(249, 27);
            tbConfirmPassword.TabIndex = 6;
            tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(131, 97);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(87, 20);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(131, 146);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(90, 20);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Last Name : ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(135, 192);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(86, 20);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username : ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(140, 247);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(77, 20);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password :";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(81, 300);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(138, 20);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password : ";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.Location = new Point(307, 25);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(140, 41);
            lblRegister.TabIndex = 12;
            lblRegister.Text = "REGISTER";
            lblRegister.Click += lblRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 437);
            Controls.Add(lblRegister);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(tbConfirmPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(btnClose);
            Controls.Add(btnRegister);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Button btnClose;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbConfirmPassword;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblRegister;
    }
}