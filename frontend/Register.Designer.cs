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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
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
            btnRegister.BackColor = SystemColors.Control;
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(198, 359);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.Control;
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(353, 359);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // tbFirstName
            // 
            tbFirstName.BackColor = SystemColors.Control;
            tbFirstName.Location = new Point(198, 94);
            tbFirstName.Margin = new Padding(3, 2, 3, 2);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(260, 27);
            tbFirstName.TabIndex = 2;
            // 
            // tbLastName
            // 
            tbLastName.BackColor = SystemColors.Control;
            tbLastName.Location = new Point(198, 141);
            tbLastName.Margin = new Padding(3, 2, 3, 2);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(260, 27);
            tbLastName.TabIndex = 3;
            // 
            // tbUsername
            // 
            tbUsername.BackColor = SystemColors.Control;
            tbUsername.Location = new Point(198, 192);
            tbUsername.Margin = new Padding(3, 2, 3, 2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(260, 27);
            tbUsername.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.Control;
            tbPassword.Location = new Point(198, 240);
            tbPassword.Margin = new Padding(3, 2, 3, 2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(260, 27);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BackColor = SystemColors.Control;
            tbConfirmPassword.Location = new Point(198, 292);
            tbConfirmPassword.Margin = new Padding(3, 2, 3, 2);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.Size = new Size(260, 27);
            tbConfirmPassword.TabIndex = 6;
            tbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.ForeColor = SystemColors.Window;
            lblFirstName.Location = new Point(78, 98);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(107, 23);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name :";
            lblFirstName.Click += lblFirstName_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.ForeColor = SystemColors.Window;
            lblLastName.Location = new Point(80, 141);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(109, 23);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Last Name : ";
            lblLastName.Click += lblLastName_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = SystemColors.Window;
            lblUsername.Location = new Point(84, 192);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(104, 23);
            lblUsername.TabIndex = 9;
            lblUsername.Text = "Username : ";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = SystemColors.Window;
            lblPassword.Location = new Point(87, 241);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(95, 23);
            lblPassword.TabIndex = 10;
            lblPassword.Text = "Password :";
            lblPassword.Click += lblPassword_Click;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfirmPassword.ForeColor = SystemColors.Window;
            lblConfirmPassword.Location = new Point(16, 296);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(171, 23);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Confirm Password : ";
            lblConfirmPassword.Click += lblConfirmPassword_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.ForeColor = SystemColors.Control;
            lblRegister.Location = new Point(248, 32);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(171, 34);
            lblRegister.TabIndex = 12;
            lblRegister.Text = "REGISTER";
            lblRegister.Click += lblRegister_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(705, 438);
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
            ForeColor = SystemColors.Window;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
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