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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calorieText = new System.Windows.Forms.TextBox();
            this.carboText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fatText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.foodname = new System.Windows.Forms.Label();
            this.addFood = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(243, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Food Nutrition Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(199, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calorie";
            // 
            // calorieText
            // 
            this.calorieText.Location = new System.Drawing.Point(398, 151);
            this.calorieText.Name = "calorieText";
            this.calorieText.Size = new System.Drawing.Size(197, 31);
            this.calorieText.TabIndex = 2;
            // 
            // carboText
            // 
            this.carboText.Location = new System.Drawing.Point(398, 215);
            this.carboText.Name = "carboText";
            this.carboText.Size = new System.Drawing.Size(197, 31);
            this.carboText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(199, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Carbohydrate";
            // 
            // fatText
            // 
            this.fatText.Location = new System.Drawing.Point(398, 278);
            this.fatText.Name = "fatText";
            this.fatText.Size = new System.Drawing.Size(197, 31);
            this.fatText.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(199, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fat";
            // 
            // foodname
            // 
            this.foodname.AutoSize = true;
            this.foodname.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.foodname.Location = new System.Drawing.Point(318, 78);
            this.foodname.Name = "foodname";
            this.foodname.Size = new System.Drawing.Size(166, 38);
            this.foodname.TabIndex = 7;
            this.foodname.Text = "Food Name";
            // 
            // addFood
            // 
            this.addFood.Location = new System.Drawing.Point(589, 368);
            this.addFood.Name = "addFood";
            this.addFood.Size = new System.Drawing.Size(169, 40);
            this.addFood.TabIndex = 8;
            this.addFood.Text = "Add To Daily";
            this.addFood.UseVisualStyleBackColor = true;
            this.addFood.Click += new System.EventHandler(this.addFood_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FoodInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addFood);
            this.Controls.Add(this.foodname);
            this.Controls.Add(this.fatText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.carboText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.calorieText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FoodInfo";
            this.Text = "FoodInfo";
            this.Load += new System.EventHandler(this.FoodInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}