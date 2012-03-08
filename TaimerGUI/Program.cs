using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaimerGUI {
    static class Program {

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
    }
}
