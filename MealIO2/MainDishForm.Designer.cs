namespace MealIO2
{
    partial class MainDishForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.chicken = new System.Windows.Forms.Button();
            this.fish = new System.Windows.Forms.Button();
            this.vegetables = new System.Windows.Forms.Button();
            this.pork = new System.Windows.Forms.Button();
            this.beef = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MealIO2.Properties.Resources._7;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1503, 843);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.back.Image = global::MealIO2.Properties.Resources.MEALIO_LAYOUT__2_;
            this.back.Location = new System.Drawing.Point(-1, -1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(148, 145);
            this.back.TabIndex = 7;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // chicken
            // 
            this.chicken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.chicken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chicken.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chicken.ForeColor = System.Drawing.Color.White;
            this.chicken.Location = new System.Drawing.Point(297, 319);
            this.chicken.Name = "chicken";
            this.chicken.Size = new System.Drawing.Size(453, 65);
            this.chicken.TabIndex = 8;
            this.chicken.Text = "Chicken";
            this.chicken.UseVisualStyleBackColor = false;
            this.chicken.Click += new System.EventHandler(this.chicken_Click);
            // 
            // fish
            // 
            this.fish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.fish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fish.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fish.ForeColor = System.Drawing.Color.White;
            this.fish.Location = new System.Drawing.Point(297, 406);
            this.fish.Name = "fish";
            this.fish.Size = new System.Drawing.Size(453, 65);
            this.fish.TabIndex = 9;
            this.fish.Text = "Fish";
            this.fish.UseVisualStyleBackColor = false;
            this.fish.Click += new System.EventHandler(this.fish_Click);
            // 
            // vegetables
            // 
            this.vegetables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.vegetables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vegetables.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vegetables.ForeColor = System.Drawing.Color.White;
            this.vegetables.Location = new System.Drawing.Point(297, 576);
            this.vegetables.Name = "vegetables";
            this.vegetables.Size = new System.Drawing.Size(453, 65);
            this.vegetables.TabIndex = 11;
            this.vegetables.Text = "Vegetables";
            this.vegetables.UseVisualStyleBackColor = false;
            this.vegetables.Click += new System.EventHandler(this.vegetables_Click);
            // 
            // pork
            // 
            this.pork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.pork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pork.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pork.ForeColor = System.Drawing.Color.White;
            this.pork.Location = new System.Drawing.Point(297, 662);
            this.pork.Name = "pork";
            this.pork.Size = new System.Drawing.Size(453, 65);
            this.pork.TabIndex = 12;
            this.pork.Text = "Pork";
            this.pork.UseVisualStyleBackColor = false;
            this.pork.Click += new System.EventHandler(this.pork_Click);
            // 
            // beef
            // 
            this.beef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.beef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beef.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beef.ForeColor = System.Drawing.Color.White;
            this.beef.Location = new System.Drawing.Point(297, 492);
            this.beef.Name = "beef";
            this.beef.Size = new System.Drawing.Size(453, 65);
            this.beef.TabIndex = 14;
            this.beef.Text = "Beef";
            this.beef.UseVisualStyleBackColor = false;
            this.beef.Click += new System.EventHandler(this.beef_Click);
            // 
            // MainDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 796);
            this.Controls.Add(this.beef);
            this.Controls.Add(this.pork);
            this.Controls.Add(this.vegetables);
            this.Controls.Add(this.fish);
            this.Controls.Add(this.chicken);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.BurlyWood;
            this.Name = "MainDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainDishForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button chicken;
        private System.Windows.Forms.Button fish;
        private System.Windows.Forms.Button vegetables;
        private System.Windows.Forms.Button pork;
        private System.Windows.Forms.Button beef;
    }
}