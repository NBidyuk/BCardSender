
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using VkNet.Enums.Filters;
using VkNet;
using VkNet.Model;
using VkNet.Enums;

namespace BCardSender
{
    public partial class frmSigninSafe : Form
    {
        MainForm parent;
        public frmSigninSafe(MainForm F)
        {
            InitializeComponent();
            this.parent = F;
        }

        private void frmSigninSafe_Load(object sender, EventArgs e)
        {
            
            // запускаем главную форму
         
            //webBrowser1.Navigate(String.Format("http://api.vk.com/oauth/authorize?client_id={0}&scope={1}&display=popup&response_type=token", Program.appId, Program.scope));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex myReg = new Regex(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$", RegexOptions.IgnoreCase | RegexOptions.Singleline);//проверка email
            if (!(myReg.IsMatch(this.textBox1.Text)))
            {
                MessageBox.Show("Error! Wrong e-mail.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Text = "";
                return;

            }
            Program.API = new VkNet.VkApi();
            Program.email = this.textBox1.Text;
            Program.password = this.textBox2.Text;
            Program.API.Authorize(Program.appId,Program.email, Program.password, Settings.All);
            
           frmVK f = new frmVK((long)Program.API.UserId,this.parent);
            //Program.applicationContext.MainForm = f;
            this.Close();
            //f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /*private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.ToString().IndexOf("access_token") != -1)
            {
                string accessToken = "";
                int userId = 0;
                Regex myReg = new Regex(@"(?<name>[\w\d\x5f]+)=(?<value>[^\x26\s]+)", RegexOptions.IgnoreCase | RegexOptions.Singleline);
                foreach (Match m in myReg.Matches(e.Url.ToString()))
                {
                    if (m.Groups["name"].Value == "access_token")
                    {
                        accessToken = m.Groups["value"].Value;
                    }
                    else if (m.Groups["name"].Value == "user_id")
                    {
                        userId = Convert.ToInt32(m.Groups["value"].Value);
                    }
                }
                if (String.IsNullOrEmpty(accessToken))
                {
                    MessageBox.Show("Ошибка. Ключ доступа не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // ключ найден, 
                // инициализируем api вконтакте
                Program.API = new VkNet.VkApi();
                Program.API.Authorize(appId,)
                Program.userId = userId;
                // запускаем главную форму
                frmVK f = new frmVK (userId);
                Program.applicationContext.MainForm = f;
                // this.Close();
                f.Show();

            }
            else if (e.Url.ToString().IndexOf("user_denied") != -1)
            {
                // пользователь отказался входить
                Program.applicationContext.MainForm = new frmSigninSafe();
                Program.applicationContext.MainForm.Show();
                this.Close();
            }*/
    }
    }


