namespace MealIO2
{
    partial class AppetiteLevelForm
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
            this.Back = new System.Windows.Forms.Button();
            this.lowappetite = new System.Windows.Forms.Button();
            this.midappetite = new System.Windows.Forms.Button();
            this.highappetite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MealIO2.Properties.Resources._6;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1503, 843);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Back
            // 
            this.Back.AllowDrop = true;
            this.Back.BackColor = System.Drawing.Color.DarkGray;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.Back.Image = global::MealIO2.Properties.Resources.MEALIO_LAYOUT__2_;
            this.Back.Location = new System.Drawing.Point(-1, -1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(148, 145);
            this.Back.TabIndex = 5;
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // lowappetite
            // 
            this.lowappetite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.lowappetite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowappetite.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowappetite.ForeColor = System.Drawing.Color.White;
            this.lowappetite.Location = new System.Drawing.Point(304, 378);
            this.lowappetite.Name = "lowappetite";
            this.lowappetite.Size = new System.Drawing.Size(446, 82);
            this.lowappetite.TabIndex = 6;
            this.lowappetite.Text = "Low level";
            this.lowappetite.UseVisualStyleBackColor = false;
            this.lowappetite.Click += new System.EventHandler(this.lowappetite_Click);
            // 
            // midappetite
            // 
            this.midappetite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.midappetite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.midappetite.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midappetite.ForeColor = System.Drawing.Color.White;
            this.midappetite.Location = new System.Drawing.Point(304, 497);
            this.midappetite.Name = "midappetite";
            this.midappetite.Size = new System.Drawing.Size(446, 82);
            this.midappetite.TabIndex = 7;
            this.midappetite.Text = "Mid level";
            this.midappetite.UseVisualStyleBackColor = false;
            this.midappetite.Click += new System.EventHandler(this.midappetite_Click);
            // 
            // highappetite
            // 
            this.highappetite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.highappetite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highappetite.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highappetite.ForeColor = System.Drawing.Color.White;
            this.highappetite.Location = new System.Drawing.Point(304, 616);
            this.highappetite.Name = "highappetite";
            this.highappetite.Size = new System.Drawing.Size(446, 82);
            this.highappetite.TabIndex = 8;
            this.highappetite.Text = "High level";
            this.highappetite.UseVisualStyleBackColor = false;
            this.highappetite.Click += new System.EventHandler(this.highappetite_Click);
            // 
            // AppetiteLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 796);
            this.Controls.Add(this.highappetite);
            this.Controls.Add(this.midappetite);
            this.Controls.Add(this.lowappetite);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AppetiteLevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppetiteLevelForm";
            this.Load += new System.EventHandler(this.AppetiteLevelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button lowappetite;
        private System.Windows.Forms.Button midappetite;
        private System.Windows.Forms.Button highappetite;
    }
}