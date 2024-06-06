using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;

namespace MealIO2
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> userCredentials;
        private const string credentialsFilePath = "credentials.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void BuynowbtnClick_Click_1(object sender, EventArgs e)
        {
            BuyNowForm form2 = new BuyNowForm();
            form2.Show();
            this.Hide();
        }
        private IDictionary<string, string> UserInfo;

        private void SignUpbtnClick_Click(object sender, EventArgs e)
        {
            string usernameText = username.Text.Trim(); 
            string passwordText = password.Text.Trim();
            string password2Text = password2.Text.Trim();

            if (string.IsNullOrEmpty(usernameText) || string.IsNullOrEmpty(passwordText) || string.IsNullOrEmpty(password2Text))
            {
                MessageBox.Show("Please fill in all the needed information!");
                return;
            }

            if (passwordText != password2Text)
            {
                MessageBox.Show("Please make sure that both your passwords are the same");
                return;
            }

            MessageBox.Show($"You have logged in successfully, {usernameText}!");
            LogInForm logInForm = new LogInForm();
            logInForm.UserInfo.Add(usernameText, passwordText);

            logInForm.Show();
            this.Hide();
        }

            private void LogInbtnClick_Click(object sender, EventArgs e)
        {
            LogInForm form4 = new LogInForm();
            form4.Show();
            this.Hide();
        }
        
        

        private void GuestbtnClick_Click(object sender, EventArgs e)
        {
            GuestForm form5 = new GuestForm();  
            form5.Show();
            this.Hide();
        }
        
        private void hidepass_CheckedChanged(object sender, EventArgs e)
        {
            if (!hidepass.Checked)
            {
                password.PasswordChar = '*'; 
            }
            else
            {
                password.PasswordChar = '\0';   
            }
        }

        private void hidepass2_CheckedChanged(object sender, EventArgs e)
        {
            if (!hidepass2.Checked)
            {
                password2.PasswordChar = '*'; 
            }
            else
            {
                password2.PasswordChar = '\0';  
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            password2.PasswordChar = '*';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TutorialForm tutorialForm = new TutorialForm();
            tutorialForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealList1Form mealList1Form = new MealList1Form();
            mealList1Form.Show();
            this.Hide();
        }
    }
}
