﻿using System;
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
    public partial class Meal68Form : Form
    {
        public Meal68Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TryAgainForm tryAgainForm = new TryAgainForm();
            tryAgainForm.Show();
            this.Hide();

        }
    }
}
