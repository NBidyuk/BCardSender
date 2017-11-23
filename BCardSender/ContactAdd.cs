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
    public partial class ContactAdd : Form
    {

        private bool dataChanged;
       
        private MainForm parent;

        public ContactAdd(MainForm F)
        {
            InitializeComponent();
            parent = F;
            dataChanged = false;
            //this.FormClosing += Form3_Closing;
            this.Load += Form3_Load;
            // textBox1.TextChanged += ControlsChanged;
            // textBox2.TextChanged += ControlsChanged;
            // textBox6.TextChanged += ControlsChanged;
            this.CancelButton = Cancel;
            this.Cancel.Click += Cancel_Click;
         

        }


        public TextBox TextBox1
        {
            get
            {
                return this.textBox1;

            }

        }

        public TextBox TextBox2
        {
            get
            {
                return this.textBox2;

            }

        }
        public TextBox TextBox6
        {
            get
            {
                return this.textBox6;

            }

        }


        public DateTimePicker DateTimePicker1
        {
            get
            {
                return this.dateTimePicker1;

            }


        }

        public CheckedListBox CheckedListBox1
        {
            get
            {
                return this.checkedListBox1;
            }

            set
            {
                this.checkedListBox1 = value;

            }
        }

        public CheckedListBox CheckedListBox2
        {
            get
            {
                return this.checkedListBox2;
            }
        }

        public ComboBox ComboBox1
        {
            get
            {
                return this.ComboBox1 ;
            }
        }

        public PictureBox PictureBox1
        {
            get
            {
                return this.pictureBox1;
            }
        }

        public MainForm Par
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

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void ControlsChanged(object sender, EventArgs e)
        {
            if (!dataChanged)
                dataChanged = true;
        }

        private void button1_Click(object sender, EventArgs e)// press Add contact button
        {
            if (dataChanged == true)
            {
                Contact c = new Contact(this);
                Program.Contacts.AddLast(c);
                parent.ListBox1.Items.Add(c.Name + ' ' + c.Surname + ' ' + c.Birthday.ToString() + '.' + c.Birthmonth.ToString());
                /* Label g = new Label();
                  g.Text = this.TextBox1.Text;
                  parent.Panel1.Controls.Add(g);*/
                if (this.checkedListBox2.GetItemChecked(0))
                {
                    if (Program.emailLogged == false)
                    {
                        EmailLogin Myform = new EmailLogin(this);
                        Myform.Owner = this;
                        Myform.ShowDialog();

                    }
                }
                this.Close();

            }
            else
            MessageBox.Show("Please enter data", "Error", MessageBoxButtons.OK);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!dataChanged)
                dataChanged = true;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!dataChanged)
                dataChanged = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!dataChanged)
                dataChanged = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.checkedListBox2.SetItemChecked(1, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Form4 Myform = new Form4(this);
            Myform.Owner = this;
            Myform.Par = this;
            Myform.ShowDialog();
            

        }



      /* private void Form3_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dataChanged==true) // Determine if text has changed in the textbox by comparing to original text.
            { if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;

                    // Call method to save file...
                }
            }
            else
                this.Close();
        }*/


        private void Cancel_Click(object sender, EventArgs e)// press Cancel button
        {

            if (dataChanged == true)
            { if (MessageBox.Show("Do you want to cancel?", "My Application",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                   
                }
                else
                {
                    return;

                }
            }
                /* // Display a MsgBox asking the user to save changes or abort.
                 if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                 {

                 }*/

                /*{
                DialogResult cancel = new DialogResult();
                cancel = MessageBox.Show("Do you want to cancel?", "Cancel",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Warning,
                         MessageBoxDefaultButton.Button2);
                if (cancel == DialogResult.Yes)
                    this.Close();
                else
                {
                    this.Show();

                }
            }*/

            else
            this.Close();
            
        }



        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)// add a photo
        {


            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    Image image = new Bitmap(open_dialog.FileName);
                    pictureBox1.Image = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Cursor = Cursors.Hand;
                    
                    pictureBox1.Invalidate();

                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

       

    }
}





