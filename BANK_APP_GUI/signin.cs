﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK_APP_GUI
{
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newframe = new customerSignin();
            newframe.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newframe = new employee_signin();
            newframe.Show();
            Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var newframe = new admin_interface();
            newframe.Show();
            Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var newframe = new homePage();
            newframe.Show();
            Visible = false;
        }
    }
}
