using Taimer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaimerGUI {
    static class Program {

        #region PARTE PRIVADA
        
        private static List<Actividad_a> asignaturas;
        private static List<User> usuarios;

        #endregion

        #region PARTE PUBLICA

        //Añade/Modifica la lista de asignaturas
        public static List<Actividad_a> Asignaturas {
            set { asignaturas = value; }
            get { return asignaturas; }
        }

        //Añade/Modifica los usuarios
        public static List<User> Usuarios {
            set { usuarios = value; }
            get { return usuarios; }
        }

        public static LoginForm loginForm;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginForm = new LoginForm();
            Application.Run(loginForm);

        }
        #endregion
    }
}
