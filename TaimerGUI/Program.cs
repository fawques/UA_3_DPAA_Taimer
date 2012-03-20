using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Taimer;

namespace TaimerGUI {
    static class Program {

        public static LoginForm loginForm;

        public static List<Actividad_a> asignaturas;
        public static List<User> usuarios;
        public static List<Algoritmo> generados;
        // Estadistica estadistica;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            asignaturas = new List<Actividad_a>();
            usuarios = new List<User>();
            generados = new List<Algoritmo>();

            loginForm = new LoginForm();
            Application.Run(loginForm);

        }
    }
}
