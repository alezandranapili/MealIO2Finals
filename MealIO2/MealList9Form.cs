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
    public partial class MealList9Form : Form
    {
        public MealList9Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealList10Form mealList10Form = new MealList10Form();
            mealList10Form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealList8Form mealList8Form = new MealList8Form();
            mealList8Form.Show();
            this.Hide();
        }
    }
}
