namespace frontend
{
    partial class FoodInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodInfo));
            label1 = new Label();
            label2 = new Label();
            calorieText = new TextBox();
            carboText = new TextBox();
            label3 = new Label();
            fatText = new TextBox();
            label4 = new Label();
            addFood = new Button();
            button1 = new Button();
            proteinText = new TextBox();
            label5 = new Label();
            tbFoodName = new TextBox();
            btnSearch = new Button();
            label6 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(114, 73);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(294, 30);
            label1.TabIndex = 0;
            label1.Text = "Food Nutrition Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(142, 117);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 21);
            label2.TabIndex = 1;
            label2.Text = "Calorie";
            // 
            // calorieText
            // 
            calorieText.BackColor = SystemColors.Control;
            calorieText.Location = new Point(282, 118);
            calorieText.Margin = new Padding(2);
            calorieText.Name = "calorieText";
            calorieText.Size = new Size(139, 23);
            calorieText.TabIndex = 2;
            // 
            // carboText
            // 
            carboText.BackColor = SystemColors.Control;
            carboText.Location = new Point(282, 158);
            carboText.Margin = new Padding(2);
            carboText.Name = "carboText";
            carboText.Size = new Size(139, 23);
            carboText.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(142, 155);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 3;
            label3.Text = "Carbohydrate";
            // 
            // fatText
            // 
            fatText.BackColor = SystemColors.Control;
            fatText.Location = new Point(282, 195);
            fatText.Margin = new Padding(2);
            fatText.Name = "fatText";
            fatText.Size = new Size(139, 23);
            fatText.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(142, 194);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(33, 21);
            label4.TabIndex = 5;
            label4.Text = "Fat";
            // 
            // addFood
            // 
            addFood.Location = new Point(452, 280);
            addFood.Margin = new Padding(2);
            addFood.Name = "addFood";
            addFood.Size = new Size(118, 24);
            addFood.TabIndex = 8;
            addFood.Text = "Add To Daily";
            addFood.UseVisualStyleBackColor = true;
            addFood.Click += addFood_Click;
            // 
            // button1
            // 
            button1.Location = new Point(39, 280);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(75, 24);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // proteinText
            // 
            proteinText.BackColor = SystemColors.Control;
            proteinText.Location = new Point(282, 235);
            proteinText.Margin = new Padding(3, 2, 3, 2);
            proteinText.Name = "proteinText";
            proteinText.Size = new Size(139, 23);
            proteinText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(142, 232);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 11;
            label5.Text = "Protein";
            // 
            // tbFoodName
            // 
            tbFoodName.BackColor = SystemColors.Control;
            tbFoodName.Location = new Point(39, 44);
            tbFoodName.Margin = new Padding(2);
            tbFoodName.Name = "tbFoodName";
            tbFoodName.Size = new Size(407, 23);
            tbFoodName.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(452, 36);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 31);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Cari Makanan";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(473, 93);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 14;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(491, 164);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 15;
            // 
            // FoodInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(598, 320);
            Controls.Add(linkLabel1);
            Controls.Add(label6);
            Controls.Add(btnSearch);
            Controls.Add(tbFoodName);
            Controls.Add(label5);
            Controls.Add(proteinText);
            Controls.Add(button1);
            Controls.Add(addFood);
            Controls.Add(fatText);
            Controls.Add(label4);
            Controls.Add(carboText);
            Controls.Add(label3);
            Controls.Add(calorieText);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "FoodInfo";
            Text = "FoodInfo";
            Load += FoodInfo_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox calorieText;
        private TextBox carboText;
        private Label label3;
        private TextBox fatText;
        private Label label4;
        private Button addFood;
        private Button button1;
        private TextBox proteinText;
        private Label label5;
        private TextBox tbFoodName;
        private Button btnSearch;
        private Label label6;
        private LinkLabel linkLabel1;
    }
}