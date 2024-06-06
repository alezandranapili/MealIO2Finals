namespace MealIO2
{
    partial class MethodForm
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
            this.fried = new System.Windows.Forms.Button();
            this.soup = new System.Windows.Forms.Button();
            this.steamed = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fried
            // 
            this.fried.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.fried.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fried.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fried.ForeColor = System.Drawing.Color.White;
            this.fried.Location = new System.Drawing.Point(302, 375);
            this.fried.Name = "fried";
            this.fried.Size = new System.Drawing.Size(453, 81);
            this.fried.TabIndex = 14;
            this.fried.Text = "Fried";
            this.fried.UseVisualStyleBackColor = false;
            this.fried.Click += new System.EventHandler(this.fried_Click);
            // 
            // soup
            // 
            this.soup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.soup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soup.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soup.ForeColor = System.Drawing.Color.White;
            this.soup.Location = new System.Drawing.Point(302, 604);
            this.soup.Name = "soup";
            this.soup.Size = new System.Drawing.Size(453, 81);
            this.soup.TabIndex = 16;
            this.soup.Text = "Soup";
            this.soup.UseVisualStyleBackColor = false;
            this.soup.Click += new System.EventHandler(this.soup_Click);
            // 
            // steamed
            // 
            this.steamed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.steamed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.steamed.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steamed.ForeColor = System.Drawing.Color.White;
            this.steamed.Location = new System.Drawing.Point(302, 489);
            this.steamed.Name = "steamed";
            this.steamed.Size = new System.Drawing.Size(453, 81);
            this.steamed.TabIndex = 17;
            this.steamed.Text = "Steamed";
            this.steamed.UseVisualStyleBackColor = false;
            this.steamed.Click += new System.EventHandler(this.steamed_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.back.Image = global::MealIO2.Properties.Resources.MEALIO_LAYOUT__2_;
            this.back.Location = new System.Drawing.Point(0, -1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(148, 145);
            this.back.TabIndex = 13;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MealIO2.Properties.Resources.MEALIO_LAYOUT__3_;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1486, 800);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 796);
            this.Controls.Add(this.steamed);
            this.Controls.Add(this.soup);
            this.Controls.Add(this.fried);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MethodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MethodForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button fried;
        private System.Windows.Forms.Button soup;
        private System.Windows.Forms.Button steamed;
    }
}