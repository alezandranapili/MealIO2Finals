using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealIO2
{

    public partial class GuestForm : Form
    {
        private Panel contentPanel;
        private VScrollBar verticalScrollBar;
        
        public GuestForm()
        {
            InitializeComponent();

            Panel contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.AutoScroll = true;
            this.Controls.Add(contentPanel);

            // Add your other controls to the content panel
            for (int i = 0; i < 20; i++)
            {
                label label = new label();
                label.Text = $"Label {i}";
                label.Location = new Point(10, 10 + (i * 30));
                contentPanel.Controls.Add(label1);
            }


        }

        private void Sample(object sender, EventArgs e)
        {
            label1 = new System.Windows.Forms.Label();
            label1.Text = "Hidden Label 1";
            label1.Location = new Point(10, 10);

            label2 = new System.Windows.Forms.Label();
            label2.Text = "Hidden Label 2";
            label2.Location = new Point(10, 30);

            // Add the labels to the form
            this.Controls.Add(label1);
            this.Controls.Add(label2);

            // Set the labels to be hidden
            label1.Visible = false;
            label2.Visible = false;
        }
        private void Back4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form1 = new Form1();
            form1.Show();
        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private void GuestForm_Load(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
            // Create the vertical scrollbar
            verticalScrollBar = new VScrollBar();
            verticalScrollBar.Dock = DockStyle.Right;
            verticalScrollBar.Minimum = 0;
            verticalScrollBar.Maximum = 100; // Set the initial maximum value
            verticalScrollBar.Value = 0;
            verticalScrollBar.SmallChange = 10;
            verticalScrollBar.LargeChange = 50;

        }
    }
}
