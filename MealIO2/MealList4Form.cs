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
    public partial class MealList4Form : Form
    {
        public MealList4Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MealList3Form form = new MealList3Form();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MealList5Form form5 = new MealList5Form();
            form5.Show();
            this.Hide();
        }
    }
}
