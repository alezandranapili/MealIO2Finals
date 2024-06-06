using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MealIO2
{
    public partial class BuyNowForm : Form
    {
        public BuyNowForm()
        {
            InitializeComponent();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void BuyNowForm_Load(object sender, EventArgs e)
        {

        }

        private void Next1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || address.Text == "" || !birthdate.MaskCompleted || billingmethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all the needed information!");
            }
            else
            {
                this.Hide();

                TermsandAgreementForm form7 = new TermsandAgreementForm();
                form7.Show();
            }
            
        }

        private void Back1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthdate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void billingmethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
