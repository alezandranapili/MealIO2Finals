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
    public partial class MealList14Form : Form
    {
        public MealList14Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealList13Form mealList13Form = new MealList13Form();
            mealList13Form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealList15Form mealList15Form = new MealList15Form();
            mealList15Form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
