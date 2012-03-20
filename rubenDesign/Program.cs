using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Taimer;

namespace rubenDesign
{
    static class Program
    {
        public static List<Actividad_a> actividadesAcademicas = new List<Actividad_a>();
        public static List<User> usuarios = new List<User>();



        public static Login loginWindow;
        public static Admin adminWindow;
        public static Client clientWindow;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginWindow = new Login();

            //Application.Run(loginWindow);
            Application.Run(new TestEN());
        }
    }
}
