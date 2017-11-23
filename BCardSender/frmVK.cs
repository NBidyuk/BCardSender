using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Threading;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Enums;
using Newtonsoft.Json;

namespace BCardSender
{
    public partial class frmVK : Form
    {
        public long UserId = 0;
        MainForm parent;

        public frmVK(long userId, MainForm F)
        {
            InitializeComponent();
            this.UserId = userId;
            this.parent = F;
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
        // Program.API.GetFriends(this.UserId));


        /* XmlDocument wall = Program.API.GetWall(this.UserId);
         foreach (XmlNode n in wall.SelectNodes("/response/post"))
         {
           if (!string.IsNullOrEmpty(tbWall.Text)) { tbWall.Text += "\r\n\r\n"; }
           tbWall.Text += String.Format("Сообщение #{0}\r\n{1}", n.SelectSingleNode("id").InnerText, n.SelectSingleNode("text").InnerText);
         } */

        private void button1_Click(object sender, EventArgs e)
        {
            var friends = Program.API.Friends.Get((long)Program.API.UserId, ProfileFields.Uid | ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.BirthDate);


            for (int i = 0; i < friends.Count; i++)
            {
                if (friends[i].BirthDate != null)
                {

                    checkedListBox1.Items.Add(friends[i].FirstName + ' ' + friends[i].LastName + ", " + friends[i].BirthDate);
                }
            }

            checkedListBox1.Update();
            this.button2.Visible = true;
            this.button3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var friends = Program.API.Friends.Get((long)Program.API.UserId, ProfileFields.Uid | ProfileFields.FirstName | ProfileFields.LastName | ProfileFields.BirthDate);
         
            /*for (int j = 0; j < friends.Count; j++)
            {
                if (friends[j].BirthDate != null)
                {
                    
                    Program.Contacts.AddLast(new Contact(friends[j].Id, friends[j].FirstName, friends[j].LastName, friends[j].BirthDate));
                }

            }*/
            
          


            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)// перебираем выбранных друзей

         {
             for (int j = 0; j < friends.Count; j++)
             {   
                 if (friends[j].BirthDate != null)
                 {
                     string temp = friends[j].FirstName + ' ' + friends[j].LastName + ", " + friends[j].BirthDate;
                     if (checkedListBox1.GetItemText(checkedListBox1.CheckedItems[i]).Equals(temp))             
                     {

                            Program.Contacts.AddLast(new Contact(friends[j].Id, friends[j].FirstName, friends[j].LastName, friends[j].BirthDate));
                        }
                 }
            }

         }

            parent.UpdateList();
            Thread thread = new Thread(new ThreadStart(parent.startTimer));
            thread.IsBackground = true;
            thread.Name = "startTimer";
            thread.Start();
            this.Close();

        }


        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                this.checkedListBox1.SetItemChecked(i, true);
        }

        



    }




}




