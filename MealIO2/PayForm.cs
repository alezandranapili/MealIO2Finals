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
    public partial class PayForm : Form
    {
        public PayForm()
        {
            InitializeComponent();
        }

        private void PayForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            LogInForm form4 = new LogInForm();
            form4.Show();
        }

        private void Back6_Click(object sender, EventArgs e)
        {
            this.Hide();

            TermsandAgreementForm form7 = new TermsandAgreementForm();
            form7.Show();
        }
    }
}
