using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ButtonExitCreeaza_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonBackCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 backToMenu = new Form2();
            backToMenu.ShowDialog();
        }

        private void TextBoxCNP_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBoxCNP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Only numbers please!");
            }
        }
    }
}
