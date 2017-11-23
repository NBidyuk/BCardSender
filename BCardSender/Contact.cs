using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace BCardSender
{

    class Contact
    {
        private String name;
        private String surname;
        private long id;
        private String mail;
        private int birthday;
        private int birthmonth;
        private string birthDate;
        private Image photo;
        private List<string> holidays;
        private bool send_mail;
        private bool remind;
        private DateTime remindDate;
        private MyGroupBox GbRef;

        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }

        public String Surname
        {
            get
            {
                return surname;
            }

            set
            {
                this.surname = value;
            }
        }

        public String Mail
        {
            get
            {
                return mail;
            }

        }

        public string BirthDate
        { get
            {
                return birthDate;
            }

            set
            {

                this.birthDate = value;
            }
        }


        public int Birthday
        {
            get
            {
                return birthday;
            }

            set
            {

                this.birthday = value;
            }
        }

        public int Birthmonth
        {
            get
            {
                return birthmonth;
            }

            set
            {

                this.birthday = value;
            }
        }

        public Image Photo
        {
            get
            {
                return photo;
            }
        }

        public long ID
        {
            get
            {
                return id;
            }

            set
            {
                this.id = value;
            }
        }

        public bool Send_mail
        {

            get
            {
                return send_mail;
            }

        }
        public List<string> Holidays
        {
            get
            {
                return holidays;
            }
        }

        /* public bool send_mail;
         public bool remind;
         public DateTime remindDate;*/
        public MyGroupBox GBRef
        {
            set
            {
                GbRef = value;
            }
        }

        public Contact()
        {
            name = "";
            surname = "";
            id = 0;

        }
        public Contact(long id, string n, string sn, string date)
        {

            name = n;
            surname = sn;
            this.id = id;
            birthDate = date;
            this.DateFromString(date);
            //birthday = Convert.ToInt32(date.Substring(0,1));
        }

        public Contact(ContactAdd form)
        {


            name = form.TextBox1.Text;
            surname = form.TextBox2.Text;
            id = 0;
            mail = form.TextBox6.Text;

            birthday = form.DateTimePicker1.Value.Day;
            birthmonth = form.DateTimePicker1.Value.Month;
            //photo = new Bitmap(form.PictureBox1.Image);
            holidays = new List<string>();
            foreach (var item in form.CheckedListBox1.CheckedItems)
            {
                holidays.Add(item.ToString());
            }
            //ActionCheck(form);

        }

        /*public void ActionCheck(Form3 form) // checks what actions to do and when
        {

            if (form.CheckedListBox2.GetItemChecked(0))
                send_mail = true;
            else
                send_mail = false;


            if (form.CheckedListBox2.GetItemChecked(1))
                remind = true;
            else
                remind = false;

            if (form.ComboBox1.SelectedIndex == 0)
                remindDate = new DateTime(birthday.Ticks - (TimeSpan.TicksPerHour * 4)); //"08:00 p.m. previous day"
            else if (form.ComboBox1.SelectedIndex == 1)
                remindDate = new DateTime(birthday.Ticks + (TimeSpan.TicksPerHour * 9)); //"09:00 a.m. this day",
            else if (form.ComboBox1.SelectedIndex == 2)
                remindDate = new DateTime(birthday.Ticks - (TimeSpan.TicksPerDay * 3)+ (TimeSpan.TicksPerHour * 9)); //"3 days before",
            else if (form.ComboBox1.SelectedIndex == 3)
                remindDate = new DateTime(birthday.Ticks - (TimeSpan.TicksPerDay * 7) + (TimeSpan.TicksPerHour * 9));//"a week before"
        }*/


        public void DateFromString(string date)
        {
            if (date.Length > 6)

            {
                if (date.IndexOf('.') == 1 && date.LastIndexOf('.') == 3)
                {
                    birthday = Convert.ToInt32(date.Substring(0, 1));
                    birthmonth = Convert.ToInt32(date.Substring(2, 1));

                }
                else if (date.IndexOf('.') == 2 && date.LastIndexOf('.') == 5)
                {
                    birthday = Convert.ToInt32(date.Substring(0, 2));
                    birthmonth = Convert.ToInt32(date.Substring(3, 2));
                }
                else if (date.IndexOf('.') == 1 && date.LastIndexOf('.') == 4)
                {
                    birthday = Convert.ToInt32(date.Substring(0, 1));
                    birthmonth = Convert.ToInt32(date.Substring(2, 2));
                }
                else if (date.IndexOf('.') == 2 && date.LastIndexOf('.') == 4)
                {
                    birthday = Convert.ToInt32(date.Substring(0, 2));
                    birthmonth = Convert.ToInt32(date.Substring(3, 1));
                }

            }
            else if (date.Length == 3)
            {
                birthday = Convert.ToInt32(date.Substring(0, 1));
                birthmonth = Convert.ToInt32(date.Substring(2, 1));

            }
            else if (date.Length == 5)
            {

                birthday = Convert.ToInt32(date.Substring(0, 2));
                birthmonth = Convert.ToInt32(date.Substring(3, 2));
            }

            else if (date.Length == 4)
            {
                if (date.IndexOf('.') == 1)
                {
                    birthday = Convert.ToInt32(date.Substring(0, 1));
                    birthmonth = Convert.ToInt32(date.Substring(2, 2));
                }
                else if (date.IndexOf('.') == 2)
                {
                    birthday = Convert.ToInt32(date.Substring(0, 2));
                    birthmonth = Convert.ToInt32(date.Substring(3, 1));
                }

            }
        }

        public void SendCard()
        {
            Program.API.Wall.Post(this.ID, false, false, "Happy Birthday! Желаю счастья, мира и добра!");


        }

        public void SendMail()
        {
            using (MailMessage mm = new MailMessage(Program.senderName + "<" + Program.emailLogin + ">", this.Mail))
            {
                mm.Subject = "Happy birthday!";
                mm.Body = this.Congrat();
                using (SmtpClient sc = new SmtpClient(Program.host, Program.port))
                {
                    sc.EnableSsl = true;
                    sc.DeliveryMethod = SmtpDeliveryMethod.Network;
                    sc.UseDefaultCredentials = false;
                    sc.Timeout = 30000;
                    sc.Credentials = new NetworkCredential(Program.emailLogin, Program.emailPassword);
                    sc.Send(mm);
                }
                   
            }
               
        }


       
        public string Congrat()
        {
            string text = string.Format(" Dear {0}, I congratulate you on your birthday! May you be happy and lucky!/t {1}", this.Name, Program.senderName);
            return text;
        }
    }
}
 

