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
    public partial class Meal44Form : Form
    {
        public Meal44Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TryAgainForm tryAgainForm = new TryAgainForm();
            tryAgainForm.Show();
            this.Hide();

        }

        private void Meal44Form_Load(object sender, EventArgs e)
        {

        }
    }
}
