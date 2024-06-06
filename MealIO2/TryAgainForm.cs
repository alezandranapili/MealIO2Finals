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
    public partial class TryAgainForm : Form
    {
       private int tryCount;

        public TryAgainForm()
        {
            InitializeComponent();

        }

        private void TryAgain_Click(object sender, EventArgs e)
        {
                this.Hide();
                BudgetForm budgetForm = new BudgetForm();
                budgetForm.Show();
              
            
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
