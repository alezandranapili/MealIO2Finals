using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace MealIO2
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();

            UserInfo.Add("admin", "123");
            UserInfo.Add("marie", "123");
        }

        public IDictionary<string, string> UserInfo = new Dictionary<string, string>();

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usernameText = username.Text.Trim();
            string passwordText = password.Text.Trim();

            if (string.IsNullOrEmpty(usernameText) || string.IsNullOrEmpty(passwordText))
            {
                MessageBox.Show("Please fill in all the required information!");
                return;
            }

            if (UserInfo.TryGetValue(usernameText, out string storedPassword) && storedPassword == passwordText)
            {
                MessageBox.Show($"Welcome back, {usernameText}!");
                BudgetForm budgetForm = new BudgetForm();
                budgetForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Account doesn't exist or incorrect password!");
            }
            /*
            foreach (KeyValuePair<string, string> kvp in UserInfo)
            {
                if (kvp.Key == username.ToString() && kvp.Value == password.ToString()) 
                {
                    MessageBox.Show($"Welcome back {username.Text}!");
                    BudgetForm budgetForm = new BudgetForm();
                    budgetForm.Show();
                    this.Hide();
                }
                else if(username.ToString() == "" && password.ToString() == "")
                {
                    MessageBox.Show("Please fill in all the required information!");
                }
                else
                {
                    MessageBox.Show("Account doesn't exist!");
                }
            
            }**/
        }
        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserPassword_TextChanged(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
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
    }
}
