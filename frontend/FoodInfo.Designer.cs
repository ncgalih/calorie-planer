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
            label1 = new Label();
            label2 = new Label();
            calorieText = new TextBox();
            carboText = new TextBox();
            label3 = new Label();
            fatText = new TextBox();
            label4 = new Label();
            foodname = new Label();
            addFood = new Button();
            button1 = new Button();
            proteinText = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(194, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 28);
            label1.TabIndex = 0;
            label1.Text = "Food Nutrition Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(159, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 1;
            label2.Text = "Calorie";
            // 
            // calorieText
            // 
            calorieText.Location = new Point(318, 121);
            calorieText.Margin = new Padding(2);
            calorieText.Name = "calorieText";
            calorieText.Size = new Size(158, 27);
            calorieText.TabIndex = 2;
            // 
            // carboText
            // 
            carboText.Location = new Point(318, 172);
            carboText.Margin = new Padding(2);
            carboText.Name = "carboText";
            carboText.Size = new Size(158, 27);
            carboText.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(159, 170);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 3;
            label3.Text = "Carbohydrate";
            // 
            // fatText
            // 
            fatText.Location = new Point(318, 222);
            fatText.Margin = new Padding(2);
            fatText.Name = "fatText";
            fatText.Size = new Size(158, 27);
            fatText.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(159, 220);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 28);
            label4.TabIndex = 5;
            label4.Text = "Fat";
            // 
            // foodname
            // 
            foodname.AutoSize = true;
            foodname.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            foodname.Location = new Point(254, 62);
            foodname.Margin = new Padding(2, 0, 2, 0);
            foodname.Name = "foodname";
            foodname.Size = new Size(140, 32);
            foodname.TabIndex = 7;
            foodname.Text = "Food Name";
            // 
            // addFood
            // 
            addFood.Location = new Point(514, 336);
            addFood.Margin = new Padding(2);
            addFood.Name = "addFood";
            addFood.Size = new Size(135, 32);
            addFood.TabIndex = 8;
            addFood.Text = "Add To Daily";
            addFood.UseVisualStyleBackColor = true;
            addFood.Click += addFood_Click;
            // 
            // button1
            // 
            button1.Location = new Point(42, 336);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 9;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // proteinText
            // 
            proteinText.Location = new Point(318, 275);
            proteinText.Name = "proteinText";
            proteinText.Size = new Size(158, 27);
            proteinText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(159, 271);
            label5.Name = "label5";
            label5.Size = new Size(78, 28);
            label5.TabIndex = 11;
            label5.Text = "Protein";
            // 
            // FoodInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 393);
            Controls.Add(label5);
            Controls.Add(proteinText);
            Controls.Add(button1);
            Controls.Add(addFood);
            Controls.Add(foodname);
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
            Load += FoodInfo_Load;
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
        private Label foodname;
        private Button addFood;
        private Button button1;
        private TextBox proteinText;
        private Label label5;
    }
}