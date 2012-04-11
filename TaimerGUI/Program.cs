using Taimer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace TaimerGUI {
    static class Program {

        #region PARTE PRIVADA
        
        private static List<Actividad_a> asignaturas = new List<Actividad_a>();
        private static List<User> usuarios = new List<User>();
        private static List<Algoritmo> algoritmos = new List<Algoritmo>();

        private static void Init()
        {
            //Aqui hay que rellenar todos los atributos privados de esta clase desde el cad
            //Esta función se llama en el main.
            SetDatos();
        }

        #endregion

        #region PARTE PUBLICA

        //Obtiene/Modifica la lista de asignaturas
        public static List<Actividad_a> Asignaturas {
            set { asignaturas = value; }
            get { return asignaturas; }
        }

        //Obtiene/Modifica los usuarios
        public static List<User> Usuarios {
            set { usuarios = value; }
            get { return usuarios; }
        }

        //Obtiene/Modifica los algoritmos
        public static List<Algoritmo> Algoritmos {
            set { algoritmos = value; }
            get { return algoritmos; }
        }

        /// <summary>
        /// Añade una Asignatura (tambien en la BD)
        /// </summary>
        /// <param name="a">Asignatura que se quiere añadir</param>
        public static void AddAsignatura(Actividad_a a) {
            a.Agregar();
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
                throw new MissingMemberException("La asignatura no existe");
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


        //Devuelve una actividad ya sea academica o personal a partir de código
        public static Actividad getActividad(int codigo) 
        {
                        
        }

            throw new ArgumentException("No existe una activida con ese código");
        }      

        /// <summary>
        /// Rellena las listas de usuarios, actividades y algoritmos
        /// </summary>
        public static void SetDatos()
        {
            usuarios = User.GetAllUsers();
            asignaturas = Actividad_a.GetAllActividades_a();
        }

        public static LoginForm loginForm;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Init();
            loginForm = new LoginForm();
            Application.Run(loginForm);

        }
        #endregion
    }
}
