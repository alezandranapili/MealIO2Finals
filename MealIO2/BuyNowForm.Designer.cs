namespace MealIO2
{
    partial class BuyNowForm
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
            this.Next1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.billingmethod = new System.Windows.Forms.ComboBox();
            this.birthdate = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Next1
            // 
            this.Next1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(27)))));
            this.Next1.FlatAppearance.BorderSize = 0;
            this.Next1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next1.ForeColor = System.Drawing.Color.White;
            this.Next1.Location = new System.Drawing.Point(986, 628);
            this.Next1.Name = "Next1";
            this.Next1.Size = new System.Drawing.Size(288, 46);
            this.Next1.TabIndex = 7;
            this.Next1.Text = "Confirm Free Trial";
            this.Next1.UseVisualStyleBackColor = false;
            this.Next1.Click += new System.EventHandler(this.Next1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MealIO2.Properties.Resources._3;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1487, 798);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Back1
            // 
            this.Back1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(27)))));
            this.Back1.FlatAppearance.BorderSize = 0;
            this.Back1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back1.ForeColor = System.Drawing.Color.White;
            this.Back1.Location = new System.Drawing.Point(-2, -1);
            this.Back1.Name = "Back1";
            this.Back1.Size = new System.Drawing.Size(88, 33);
            this.Back1.TabIndex = 8;
            this.Back1.Text = "Back";
            this.Back1.UseVisualStyleBackColor = false;
            this.Back1.Click += new System.EventHandler(this.Back1_Click_1);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(883, 228);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(473, 34);
            this.name.TabIndex = 9;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(883, 417);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(473, 34);
            this.address.TabIndex = 11;
            this.address.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // billingmethod
            // 
            this.billingmethod.FormattingEnabled = true;
            this.billingmethod.Items.AddRange(new object[] {
            "Maya",
            "Gcash",
            "Credit Card"});
            this.billingmethod.Location = new System.Drawing.Point(883, 507);
            this.billingmethod.Name = "billingmethod";
            this.billingmethod.Size = new System.Drawing.Size(473, 24);
            this.billingmethod.TabIndex = 13;
            this.billingmethod.SelectedIndexChanged += new System.EventHandler(this.billingmethod_SelectedIndexChanged);
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(883, 328);
            this.birthdate.Mask = "00/00/0000";
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(473, 22);
            this.birthdate.TabIndex = 14;
            this.birthdate.ValidatingType = typeof(System.DateTime);
            this.birthdate.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.birthdate_MaskInputRejected);
            // 
            // BuyNowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 796);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.billingmethod);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Back1);
            this.Controls.Add(this.Next1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BuyNowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuyNowForm";
            this.Load += new System.EventHandler(this.BuyNowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Next1;
        private System.Windows.Forms.Button Back1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.ComboBox billingmethod;
        private System.Windows.Forms.MaskedTextBox birthdate;
    }
}