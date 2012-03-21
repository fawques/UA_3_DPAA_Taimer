using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Taimer;

namespace rubenDesign
{
    static class Program
    {
        // Lista que contiene todas las actividades académicas
        public static List<Actividad_a> actividadesAcademicas = new List<Actividad_a>();

        // Lista que almacena los usuarios
        // En modo administrador, tiene todos los usuarios.
        // En modo usuario, sólo tiene su propio usuario.
        public static List<User> usuarios = new List<User>();

        // Lista de algoritmos
        public static List<Algoritmo> generados = new List<Algoritmo>();

        // Estadística (hay que crearla)
        // Estadistica estadistica;



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
