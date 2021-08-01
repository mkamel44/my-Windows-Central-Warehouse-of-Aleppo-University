using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace مستودع
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            Close();
        }

    }
}