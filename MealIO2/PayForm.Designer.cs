namespace MealIO2
{
    partial class PayForm
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
            this.Pay1 = new System.Windows.Forms.Button();
            this.Pay2 = new System.Windows.Forms.Button();
            this.Pay3 = new System.Windows.Forms.Button();
            this.Next3 = new System.Windows.Forms.Button();
            this.Back6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Options:";
            // 
            // Pay1
            // 
            this.Pay1.Location = new System.Drawing.Point(129, 128);
            this.Pay1.Name = "Pay1";
            this.Pay1.Size = new System.Drawing.Size(75, 23);
            this.Pay1.TabIndex = 1;
            this.Pay1.Text = "gcash";
            this.Pay1.UseVisualStyleBackColor = true;
            // 
            // Pay2
            // 
            this.Pay2.Location = new System.Drawing.Point(129, 167);
            this.Pay2.Name = "Pay2";
            this.Pay2.Size = new System.Drawing.Size(75, 23);
            this.Pay2.TabIndex = 2;
            this.Pay2.Text = "maya";
            this.Pay2.UseVisualStyleBackColor = true;
            // 
            // Pay3
            // 
            this.Pay3.Location = new System.Drawing.Point(129, 206);
            this.Pay3.Name = "Pay3";
            this.Pay3.Size = new System.Drawing.Size(75, 23);
            this.Pay3.TabIndex = 3;
            this.Pay3.Text = "bank account";
            this.Pay3.UseVisualStyleBackColor = true;
            // 
            // Next3
            // 
            this.Next3.Location = new System.Drawing.Point(622, 358);
            this.Next3.Name = "Next3";
            this.Next3.Size = new System.Drawing.Size(75, 23);
            this.Next3.TabIndex = 4;
            this.Next3.Text = "Next";
            this.Next3.UseVisualStyleBackColor = true;
            this.Next3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Back6
            // 
            this.Back6.Location = new System.Drawing.Point(622, 329);
            this.Back6.Name = "Back6";
            this.Back6.Size = new System.Drawing.Size(75, 23);
            this.Back6.TabIndex = 5;
            this.Back6.Text = "Back";
            this.Back6.UseVisualStyleBackColor = true;
            this.Back6.Click += new System.EventHandler(this.Back6_Click);
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back6);
            this.Controls.Add(this.Next3);
            this.Controls.Add(this.Pay3);
            this.Controls.Add(this.Pay2);
            this.Controls.Add(this.Pay1);
            this.Controls.Add(this.label1);
            this.Name = "PayForm";
            this.Text = "PayForm";
            this.Load += new System.EventHandler(this.PayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pay1;
        private System.Windows.Forms.Button Pay2;
        private System.Windows.Forms.Button Pay3;
        private System.Windows.Forms.Button Next3;
        private System.Windows.Forms.Button Back6;
    }
}