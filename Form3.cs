using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
                MessageBox.Show("Only numbers are permitted in the CNP field!");
            }
        }

        private void TextBoxNoIDContract_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Only numbers are permitted in the No. ID field!");
            }
        }

        private void ButtonRegisterContract_Click(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(TextBoxBeneficiary.Text))
                {
                    MessageBox.Show("Beneficiary cannot be empty!");
                    TextBoxBeneficiary.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(richTextBoxAdressContract.Text))
                {
                    MessageBox.Show("Adress cannot be empty!");
                    richTextBoxAdressContract.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(TextBoxCNP.Text))
                {
                    MessageBox.Show("CNP cannot be empty!");
                    TextBoxCNP.Focus();
                    return;
                }
            else
            {
                MessageBox.Show("Great! You've registered a contract");
            }
            } 
        }
    }