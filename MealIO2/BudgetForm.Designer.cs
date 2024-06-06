namespace MealIO2
{
    partial class BudgetForm
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
            this.lowbudget = new System.Windows.Forms.Button();
            this.midbudget = new System.Windows.Forms.Button();
            this.highbudget = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MealIO2.Properties.Resources._5;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1503, 843);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Back
            // 
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(137)))), ((int)(((byte)(104)))));
            this.Back.Image = global::MealIO2.Properties.Resources.MEALIO_LAYOUT__2_;
            this.Back.Location = new System.Drawing.Point(-1, -1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(148, 145);
            this.Back.TabIndex = 1;
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // lowbudget
            // 
            this.lowbudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.lowbudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lowbudget.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowbudget.ForeColor = System.Drawing.Color.White;
            this.lowbudget.Location = new System.Drawing.Point(306, 377);
            this.lowbudget.Name = "lowbudget";
            this.lowbudget.Size = new System.Drawing.Size(445, 85);
            this.lowbudget.TabIndex = 2;
            this.lowbudget.Text = "Low level \r\n(Php100 - Php200)";
            this.lowbudget.UseVisualStyleBackColor = false;
            this.lowbudget.Click += new System.EventHandler(this.lowbudget_Click);
            // 
            // midbudget
            // 
            this.midbudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.midbudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.midbudget.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.midbudget.ForeColor = System.Drawing.Color.White;
            this.midbudget.Location = new System.Drawing.Point(306, 496);
            this.midbudget.Name = "midbudget";
            this.midbudget.Size = new System.Drawing.Size(445, 85);
            this.midbudget.TabIndex = 3;
            this.midbudget.Text = "Mid level\r\n(Php200 - Php350)\r\n";
            this.midbudget.UseVisualStyleBackColor = false;
            this.midbudget.Click += new System.EventHandler(this.midbudget_Click);
            // 
            // highbudget
            // 
            this.highbudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(128)))), ((int)(((byte)(89)))));
            this.highbudget.Cursor = System.Windows.Forms.Cursors.Default;
            this.highbudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highbudget.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highbudget.ForeColor = System.Drawing.Color.White;
            this.highbudget.Location = new System.Drawing.Point(306, 613);
            this.highbudget.Margin = new System.Windows.Forms.Padding(0);
            this.highbudget.Name = "highbudget";
            this.highbudget.Size = new System.Drawing.Size(445, 85);
            this.highbudget.TabIndex = 4;
            this.highbudget.Text = "High level \r\n(Php350 - Php 500)\r\n";
            this.highbudget.UseVisualStyleBackColor = false;
            this.highbudget.Click += new System.EventHandler(this.highbudget_Click);
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 796);
            this.Controls.Add(this.highbudget);
            this.Controls.Add(this.midbudget);
            this.Controls.Add(this.lowbudget);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BudgetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BudgetForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button lowbudget;
        private System.Windows.Forms.Button midbudget;
        private System.Windows.Forms.Button highbudget;
    }
}