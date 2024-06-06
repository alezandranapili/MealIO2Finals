namespace MealIO2
{
    partial class Form1
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
            this.BuynowbtnClick = new System.Windows.Forms.Button();
            this.LogInbtnClick = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password2 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SignUpbtnClick = new System.Windows.Forms.Button();
            this.hidepass = new System.Windows.Forms.CheckBox();
            this.hidepass2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BuynowbtnClick
            // 
            this.BuynowbtnClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(27)))));
            this.BuynowbtnClick.FlatAppearance.BorderSize = 0;
            this.BuynowbtnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuynowbtnClick.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuynowbtnClick.ForeColor = System.Drawing.Color.White;
            this.BuynowbtnClick.Location = new System.Drawing.Point(80, 551);
            this.BuynowbtnClick.Name = "BuynowbtnClick";
            this.BuynowbtnClick.Size = new System.Drawing.Size(196, 70);
            this.BuynowbtnClick.TabIndex = 6;
            this.BuynowbtnClick.Text = "Start Free Trial";
            this.BuynowbtnClick.UseVisualStyleBackColor = false;
            this.BuynowbtnClick.Click += new System.EventHandler(this.BuynowbtnClick_Click_1);
            // 
            // LogInbtnClick
            // 
            this.LogInbtnClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(27)))));
            this.LogInbtnClick.FlatAppearance.BorderSize = 0;
            this.LogInbtnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInbtnClick.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInbtnClick.ForeColor = System.Drawing.Color.White;
            this.LogInbtnClick.Location = new System.Drawing.Point(776, 570);
            this.LogInbtnClick.Name = "LogInbtnClick";
            this.LogInbtnClick.Size = new System.Drawing.Size(468, 55);
            this.LogInbtnClick.TabIndex = 8;
            this.LogInbtnClick.Text = "I already have an account";
            this.LogInbtnClick.UseVisualStyleBackColor = false;
            this.LogInbtnClick.Click += new System.EventHandler(this.LogInbtnClick_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(666, 260);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(684, 34);
            this.username.TabIndex = 10;
            // 
            // password2
            // 
            this.password2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password2.Location = new System.Drawing.Point(666, 437);
            this.password2.Multiline = true;
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(684, 34);
            this.password2.TabIndex = 11;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(666, 348);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(684, 34);
            this.password.TabIndex = 12;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // SignUpbtnClick
            // 
            this.SignUpbtnClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(27)))));
            this.SignUpbtnClick.FlatAppearance.BorderSize = 0;
            this.SignUpbtnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpbtnClick.Font = new System.Drawing.Font("Century", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpbtnClick.ForeColor = System.Drawing.Color.White;
            this.SignUpbtnClick.Location = new System.Drawing.Point(776, 494);
            this.SignUpbtnClick.Name = "SignUpbtnClick";
            this.SignUpbtnClick.Size = new System.Drawing.Size(468, 55);
            this.SignUpbtnClick.TabIndex = 13;
            this.SignUpbtnClick.Text = "Sign Up";
            this.SignUpbtnClick.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SignUpbtnClick.UseVisualStyleBackColor = false;
            this.SignUpbtnClick.Click += new System.EventHandler(this.SignUpbtnClick_Click);
            // 
            // hidepass
            // 
            this.hidepass.AutoSize = true;
            this.hidepass.Location = new System.Drawing.Point(1321, 357);
            this.hidepass.Name = "hidepass";
            this.hidepass.Size = new System.Drawing.Size(18, 17);
            this.hidepass.TabIndex = 14;
            this.hidepass.UseVisualStyleBackColor = true;
            this.hidepass.CheckedChanged += new System.EventHandler(this.hidepass_CheckedChanged);
            // 
            // hidepass2
            // 
            this.hidepass2.AutoSize = true;
            this.hidepass2.Location = new System.Drawing.Point(1321, 446);
            this.hidepass2.Name = "hidepass2";
            this.hidepass2.Size = new System.Drawing.Size(18, 17);
            this.hidepass2.TabIndex = 15;
            this.hidepass2.UseVisualStyleBackColor = true;
            this.hidepass2.CheckedChanged += new System.EventHandler(this.hidepass2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(27)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(80, 643);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 70);
            this.button1.TabIndex = 16;
            this.button1.Text = "Tutorial";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(72)))), ((int)(((byte)(27)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(776, 650);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(468, 55);
            this.button2.TabIndex = 17;
            this.button2.Text = "Explore MealIO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MealIO2.Properties.Resources._110;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1486, 799);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1485, 796);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hidepass2);
            this.Controls.Add(this.hidepass);
            this.Controls.Add(this.SignUpbtnClick);
            this.Controls.Add(this.password);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.LogInbtnClick);
            this.Controls.Add(this.BuynowbtnClick);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BuynowbtnClick;
        private System.Windows.Forms.Button LogInbtnClick;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button SignUpbtnClick;
        private System.Windows.Forms.CheckBox hidepass;
        private System.Windows.Forms.CheckBox hidepass2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

