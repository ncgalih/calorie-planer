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
            btnRegister.Location = new Point(226, 260);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(82, 22);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(361, 260);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(82, 22);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(226, 70);
            tbFirstName.Margin = new Padding(3, 2, 3, 2);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(218, 23);
            tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(226, 107);
            tbLastName.Margin = new Padding(3, 2, 3, 2);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(218, 23);
            tbLastName.TabIndex = 3;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(226, 144);
            tbUsername.Margin = new Padding(3, 2, 3, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(218, 23);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(226, 183);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(218, 23);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.Location = new Point(226, 220);
            tbConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(218, 23);
            tbConfirmPassword.TabIndex = 6;
            tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(115, 73);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(70, 15);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name :";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(115, 110);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(72, 15);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Last Name : ";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(118, 144);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(69, 15);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username : ";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(122, 185);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(63, 15);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password :";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(71, 225);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(113, 15);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password : ";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.Location = new Point(269, 19);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(112, 32);
            lblRegister.TabIndex = 12;
            lblRegister.Text = "REGISTER";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 328);
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
            Margin = new Padding(3, 2, 3, 2);
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