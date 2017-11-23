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
    public partial class Form4 : Form
    {
        private ContactAdd parent;
        private bool dataChanged;

        public Form4(ContactAdd F)
        {
            InitializeComponent();
           // parent = new Form3();
           parent = F;
            //this.Owner = parent;
            dataChanged = false;
        }


        public ContactAdd Par
        {
            set
            {
                parent = value;
            }
            get
            {
                return parent;
            }

        }
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataChanged==false)
                  this.Close();

            else
            {
                this.parent.CheckedListBox1.Items.Add(this.textBox6.Text, true);

                parent.CheckedListBox1.Visible = true;
                parent.CheckedListBox1.Update();
                this.Close();
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataChanged = true;
        }

    }
}
