namespace frontend
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            label3 = new Label();
            addFood = new Button();
            label4 = new Label();
            tbTotalCalorie = new TextBox();
            dgvFood = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(251, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(226, 41);
            label1.TabIndex = 0;
            label1.Text = "Daily Food List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(380, 62);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 2;
            // 
            // addFood
            // 
            addFood.BackColor = SystemColors.Control;
            addFood.Location = new Point(577, 362);
            addFood.Margin = new Padding(2);
            addFood.Name = "addFood";
            addFood.Size = new Size(135, 32);
            addFood.TabIndex = 9;
            addFood.Text = "Add Food";
            addFood.UseVisualStyleBackColor = false;
            addFood.Click += addFood_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 359);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 10;
            label4.Text = "Daily Total Calorie :";
            // 
            // tbTotalCalorie
            // 
            tbTotalCalorie.BackColor = SystemColors.Control;
            tbTotalCalorie.Location = new Point(234, 362);
            tbTotalCalorie.Margin = new Padding(2);
            tbTotalCalorie.Name = "tbTotalCalorie";
            tbTotalCalorie.Size = new Size(154, 27);
            tbTotalCalorie.TabIndex = 11;
            tbTotalCalorie.TextChanged += tbTotalCalorie_TextChanged;
            // 
            // dgvFood
            // 
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(43, 62);
            dgvFood.Margin = new Padding(2);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 62;
            dgvFood.RowTemplate.Height = 33;
            dgvFood.Size = new Size(669, 275);
            dgvFood.TabIndex = 12;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(751, 423);
            Controls.Add(dgvFood);
            Controls.Add(tbTotalCalorie);
            Controls.Add(label4);
            Controls.Add(addFood);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button addFood;
        private Label label4;
        private TextBox tbTotalCalorie;
        private DataGridView dgvFood;
    }
}