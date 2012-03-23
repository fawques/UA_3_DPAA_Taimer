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
        private static List<Algoritmo> algoritmos;

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

        //Añade/Modifica los algoritmos
        public static List<Algoritmo> Algoritmos {
            set { algoritmos = value; }
            get { return algoritmos; }
        }

        //Añade una asignatura
        public static void AddAsignatura(Actividad_a a) {
            asignaturas.Add(a);
        }

        //Borrar una asignatura
        public static bool BorrarAsignaturaBool(int codigo) {
            foreach(Actividad_a a in asignaturas){
                if (a.Codigo == codigo)
                    return asignaturas.Remove(a);
            }
            return false;
        }

        //Borrar una asignatura
        public static void BorrarAsignatura(int codigo)
        {
            bool borrado = false;
            foreach (Actividad_a a in asignaturas)
            {
                if (a.Codigo == codigo)
                    borrado = asignaturas.Remove(a);
            }
            if(!borrado)
                throw new MissingMemberException("La actividad no existe");
        }

        //Añade un usuario
        public static void AddUsuario(User u) {
            usuarios.Add(u);
        }

        //Borrar un usuario
        public static bool BorrarUsuarioBool(string dni) {
            foreach (User u in usuarios) {
                if (u.DNI == dni)
                    return usuarios.Remove(u);
            }
            return false;
        }

        //Borrar un usuario
        public static void BorrarUsuario(string dni)
        {
            bool borrado = false;
            foreach (User u in usuarios)
            {
                if (u.DNI == dni)
                    borrado = usuarios.Remove(u);
            }
            if(!borrado)
                throw new MissingMemberException("El usuario no existe");
        }


        //Añade un algoritmo
        public static void AddAlgoritmo(Algoritmo a) {
            algoritmos.Add(a);
        }

        //Borrar un algoritmo                                   NO HAY NADA QUE LOS IDENTIFIQUE
        /*public static bool BorrarAsignatura(int codigo) { 
            foreach (Algoritmo a in algoritmos) {
                if (a.Codigo == codigo)
                    return algoritmos.Remove(a);
            }
            return false;
        }*/

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
