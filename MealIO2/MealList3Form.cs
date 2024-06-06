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
    public partial class MealList3Form : Form
    {
        public MealList3Form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealList4Form mealList4Form = new MealList4Form();
            mealList4Form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealList2Form mealList2Form = new MealList2Form();
            mealList2Form.Show();
            this.Hide();
        }
    }
}
