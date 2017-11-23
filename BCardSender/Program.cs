using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;

namespace BCardSender
{
    static class Program
    {


       

        #region Глобальные перечисления
        public enum VkontakteScopeList
        {
            /// <summary>
            /// Пользователь разрешил отправлять ему уведомления. 
            /// </summary>
            notify = 1,
            /// <summary>
            /// Доступ к друзьям.
            /// </summary>
            friends = 2,
            /// <summary>
            /// Доступ к фотографиям. 
            /// </summary>
            photos = 4,
            /// <summary>
            /// Доступ к аудиозаписям. 
            /// </summary>
            audio = 8,
            /// <summary>
            /// Доступ к видеозаписям. 
            /// </summary>
            video = 16,
            /// <summary>
            /// Доступ к предложениям (устаревшие методы). 
            /// </summary>
            offers = 32,
            /// <summary>
            /// Доступ к вопросам (устаревшие методы). 
            /// </summary>
            questions = 64,
            /// <summary>
            /// Доступ к wiki-страницам. 
            /// </summary>
            pages = 128,
            /// <summary>
            /// Добавление ссылки на приложение в меню слева.
            /// </summary>
            link = 256,
            /// <summary>
            /// Доступ заметкам пользователя. 
            /// </summary>
            notes = 2048,
            /// <summary>
            /// (для Standalone-приложений) Доступ к расширенным методам работы с сообщениями. 
            /// </summary>
            messages = 4096,
            /// <summary>
            /// Доступ к обычным и расширенным методам работы со стеной. 
            /// </summary>
            wall = 8192,
            /// <summary>
            /// Доступ к документам пользователя.
            /// </summary>
            docs = 131072
        }
        #endregion

        public static ApplicationContext applicationContext;

        /// <summary>
        /// Идентификатор приложения.
        /// Cм. в параметрах приложения на сайте вконтакте
        /// </summary>
        //public static int appId = 2419779;
        public static int appId = 5607790;
 
        //T2PyAOTIW2vgLiISWZTC
        /// <summary>
        /// Права, необходимые приложению - запрашиваются у пользователя
        /// </summary>
        //public static int scope = (int)(VkontakteScopeList.audio | VkontakteScopeList.docs | VkontakteScopeList.friends | VkontakteScopeList.link | VkontakteScopeList.messages | VkontakteScopeList.notes | VkontakteScopeList.notify | VkontakteScopeList.offers | VkontakteScopeList.pages | VkontakteScopeList.photos | VkontakteScopeList.questions | VkontakteScopeList.video | VkontakteScopeList.wall);
        public static int scope = (int)(VkontakteScopeList.friends | VkontakteScopeList.link | VkontakteScopeList.messages | VkontakteScopeList.photos |  VkontakteScopeList.wall);

        /// <summary>
        /// Глобальная переменная для доступа к API ВКонтакте
        /// </summary>
        public static VkApi API = null;
        public static string email = "";
        public static string password ="";
        //public static string email = "tashik@ukr.net";
       // public static string password ="BADbOyS";
        public static LinkedList<Contact> Contacts;
        public static bool emailLogged = false;
        public static string emailLogin ="";
        public static string emailPassword ="";
        public static string host = "";
        public static int port = 0;
        public static string senderName = "";
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Contacts = new LinkedList<Contact>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            applicationContext = new ApplicationContext(new MainForm());
            Application.Run(applicationContext);
            
        }
    }

}
