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
    public partial class MealList8Form : Form
    {
        public MealList8Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealList7Form mealList7Form = new MealList7Form();
            mealList7Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealList9Form mealList9Form = new MealList9Form();
            mealList9Form.Show();
            this.Hide();
        }
    }
}
