﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ButtonExitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMenuCreeaza_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Create = new Form3();
            Create.ShowDialog();
        }

        private void ButtonBackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 backToLogin = new Form1();
            backToLogin.ShowDialog();
        }
    }
}
