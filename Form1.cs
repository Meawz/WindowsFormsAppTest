using System;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using System.Linq;

namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string FromXML_user = "";
        public string FromXML_pass = "";
        public string FromXML_name = "";

        private void ClearTextBoxes()
        {
            textBoxUser.Clear();
            textBoxPass.Clear();
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

            XDocument doc = XDocument.Load(Application.StartupPath.ToString() + @"\LoginInfo.xml");
            var selected_user = from x in doc.Descendants("users").Where
                                (x => (string)x.Element("username") == textBoxUser.Text)
                                select new
                                {
                                    XMLuser = x.Element("username").Value,
                                    XMLpass = x.Element("password").Value,
                                    XMLname = x.Element("name").Value
                                };

                        foreach( var x in selected_user)
                         {
                            FromXML_user = x.XMLuser;
                            FromXML_pass = x.XMLpass;
                            FromXML_name = x.XMLname;
                         }


            if (textBoxUser.Text == string.Empty || textBoxPass.Text == string.Empty)
            {
                MessageBox.Show("Enter credentials!");
            }
            
            else if (textBoxUser.Text != FromXML_user)
            {
                MessageBox.Show("Invalid username!");
                ClearTextBoxes();
            }
            else if (textBoxPass.Text != FromXML_pass)
            {
                MessageBox.Show("Invalid password");
                ClearTextBoxes();
            }
            else if (textBoxUser.Text == FromXML_user && textBoxPass.Text == FromXML_pass)
            {
                this.Hide();
                Form2 Menu = new Form2();
                Menu.ShowDialog();
            }
        }
    }
}
