using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCardSender
{
    public partial class EmailLogin : Form
    {
        Form parent;
        public EmailLogin(Form c)
        {
            InitializeComponent();
            this.parent = c;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Program.emailLogin = Login.Text + Service_CB.Text;
            Program.emailPassword = label2.Text;
            Program.senderName = label1.Text;

            if (Service_CB.SelectedIndex == 0)
            {
                Program.host = "smtp.gmail.com";
                Program.port = 465;

            }
            else if (Service_CB.SelectedIndex == 1)
            {
                Program.host = "smtp.yandex.ru";
                Program.port = 465;
                
            }
            else if (Service_CB.SelectedIndex == 2)
            {
                Program.host = "smtp.mail.ru";
                Program.port = 465;

            }
            else if (Service_CB.SelectedIndex == 3)
            {
                Program.host = "smtp.ukr.net";
                Program.port = 465;

            }
            Program.emailLogged = true;
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
