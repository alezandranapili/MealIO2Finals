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
    public partial class AppetiteLevelForm : Form
    {
        public AppetiteLevelForm()
        {
            InitializeComponent();
        }        
        private void Back_Click(object sender, EventArgs e)
        {
            BudgetForm budgetForm = new BudgetForm();
            budgetForm.Show();
            this.Hide();
        }

        public static bool lowappetiteClicked = false;
        public static bool midappetiteClicked = false;
        public static bool highappetiteClicked = false;

        public void lowappetite_Click(object sender, EventArgs e)
        {
            lowappetiteClicked = true;
            MainDishForm mainDishForm = new MainDishForm();
            mainDishForm.Show();
            this.Hide();
        }

        public void midappetite_Click(object sender, EventArgs e)
        {
            midappetiteClicked = true;
            MainDishForm mainDishForm = new MainDishForm();
            mainDishForm.Show();
            this.Hide();
        }

        public void highappetite_Click(object sender, EventArgs e)
        {
            highappetiteClicked = true;
            MainDishForm mainDishForm = new MainDishForm();
            mainDishForm.Show();
            this.Hide();
        }

        private void AppetiteLevelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
