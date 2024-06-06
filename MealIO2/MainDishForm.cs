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
    public partial class MainDishForm : Form
    {
        public MainDishForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
       
        private void back_Click(object sender, EventArgs e)
        {
            AppetiteLevelForm appetiteLevelForm = new AppetiteLevelForm();
            appetiteLevelForm.Show();
            this.Hide();
        }

        public static bool chickenClicked = false;
        public static bool fishClicked = false;
        public static bool beefClicked = false;
        public static bool vegetablesClicked = false;
        public static bool porkClicked = false;
        public void chicken_Click(object sender, EventArgs e)
        {
            chickenClicked = true;
            MethodForm methodForm = new MethodForm();
            methodForm.Show();
            this.Hide();
        }

        public void fish_Click(object sender, EventArgs e)
        {
            fishClicked = true;
            MethodForm methodForm = new MethodForm();
            methodForm.Show();
            this.Hide();
        }


        public void beef_Click(object sender, EventArgs e)
        {
            beefClicked = true;
            MethodForm methodForm = new MethodForm();
            methodForm.Show();
            this.Hide();
        }

        public void vegetables_Click(object sender, EventArgs e)
        {
            vegetablesClicked = true;
            MethodForm methodForm = new MethodForm();
            methodForm.Show();
            this.Hide();
        }

        public void pork_Click(object sender, EventArgs e)
        {
            porkClicked = true;
            MethodForm methodForm = new MethodForm();
            methodForm.Show();
            this.Hide();
        }

        
    }
}
