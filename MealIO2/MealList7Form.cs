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
    public partial class MealList7Form : Form
    {
        public MealList7Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealList8Form mealList8Form = new MealList8Form();
            mealList8Form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealList6Form mealList6Form = new MealList6Form();
            mealList6Form.Show();
            this.Hide();
        }
    }
}
