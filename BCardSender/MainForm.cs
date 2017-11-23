using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet.Enums.Filters;
using VkNet;
using VkNet.Model;
using VkNet.Enums;

namespace BCardSender
{   

   
    public partial class MainForm : Form
    {
      
       

        public MainForm()
        {
            InitializeComponent();


        }


         /*public Panel Panel1
         {
             get
             {
                 return this.panel1;
             }
         }

         public void UpdatePanel ()
         {
             int X = this.panel1.Location.X + 1;
             int Y = this.panel1.Location.Y + 3;
             foreach  (Contact c in Program.Contacts)
             {
                 MyGroupBox newGB = new MyGroupBox(c);
                 newGB.Location = new Point(X + 3, Y + 78);
                 this.Panel1.Controls.Add(newGB);


             }

         }*/

        public ListBox ListBox1
        {
            get
            {
                return this.listBox1 ;
            }
        }

       public void UpdateList()
        {
       
            foreach (Contact c in Program.Contacts)
            {

                this.ListBox1.Items.Add(c.Name + ' ' + c.Surname + ' '+ c.Birthday.ToString() + '.' + c.Birthmonth.ToString());
             }

        }
        

        public void startTimer()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Elapsed += new System.Timers.ElapsedEventHandler(TimerEvent);
            timer.Interval = 5000;
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Start();


        }

       


        protected void TimerEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (DateTime.Now.Hour == 9)
            { 
                foreach (Contact c in Program.Contacts)
                {

                    if (c.Birthmonth == DateTime.Now.Month && c.Birthday == DateTime.Now.Day)
                    {
                        if (c.ID!=0)
                        c.SendCard();
                       // MessageBox.Show("A card was posted on {0} {1}'s wall!", "Birthday card was sent", MessageBoxButtons.OK, MessageBoxIcon.None, c.Name, c.Surname);

                    else if (c.Mail!=null && c.Send_mail==true)
                        {
                            if (Program.emailLogged == false)//если не введен логин и пароль почты
                            {
                                EmailLogin Myform = new EmailLogin(this);
                                Myform.Owner = this;
                                Myform.ShowDialog();
                                c.SendMail();
                            }
                            else
                            c.SendMail();


                        }
                    }
                }
               
            }
        }

        private void new_c_Click(object sender, EventArgs e)
        {
            ContactAdd Myform = new ContactAdd(this);
            Myform.Par = this;
            Myform.Owner = this;

            Myform.ShowDialog();
                       
        }

        private void VK_Click(object sender, EventArgs e)
        {
           // Program.API = new VkNet.VkApi();
            //Program.API.Authorize(Program.appId, Program.email, Program.password, Settings.All);
            //frmVK f = new frmVK((long)Program.API.UserId,this);
           // f.Par = this;
           // f.Owner = this;
           // f.Show();
            if (Program.API == null)
            {
                frmSigninSafe VKform = new frmSigninSafe(this);
                VKform.Show();
            }
            else
            {

                frmVK f = new frmVK((long)Program.API.UserId,this);
                f.Par = this;
                f.Show();
            }

        }

        private void FB_Click(object sender, EventArgs e)
        {
            Form2 FBform = new Form2();
            FBform.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


   
}
