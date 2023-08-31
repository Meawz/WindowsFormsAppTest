using System;
using System.Windows.Forms;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == " ")
            {
                MessageBox.Show("Enter User!");
            }
            else if (textBoxPass.Text == " ")
            {
                MessageBox.Show("Enter Password!");
            }
            else if (textBoxUser.Text == "Test" && textBoxPass.Text == "123")
            {
                this.Hide();
                Form2 Menu = new Form2();
                Menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Credentials!");
            }
        }
    }
}
