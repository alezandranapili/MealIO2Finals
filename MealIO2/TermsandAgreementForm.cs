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
    public partial class TermsandAgreementForm : Form
    {
        public TermsandAgreementForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
            

                NoticeForm noticeForm = new NoticeForm();
                noticeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please check the box to proceed.");
            }
        }
    }
}
