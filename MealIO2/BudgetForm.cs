using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealIO2
{
    public partial class BudgetForm : Form
    {
        public BudgetForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
            this.Hide();
        }
        public static bool lowbudgetClicked = false;
        public static bool midbudgetClicked = false;
        public static bool highbudgetClicked = false;

        public void lowbudget_Click(object sender, EventArgs e)
        {
            lowbudgetClicked = true;
            AppetiteLevelForm appetiteLevelForm = new AppetiteLevelForm();
            appetiteLevelForm.Show();
            this.Hide();
        }

        public void midbudget_Click(object sender, EventArgs e)
        {
            midbudgetClicked = true;
            AppetiteLevelForm appetiteLevelForm = new AppetiteLevelForm();
            appetiteLevelForm.Show();
            this.Hide();
        }

        public void highbudget_Click(object sender, EventArgs e)
        {
            highbudgetClicked = true;
            AppetiteLevelForm appetiteLevelForm = new AppetiteLevelForm();
            appetiteLevelForm.Show();
            this.Hide();
        }
    }
}
