using Taimer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace TaimerGUI {
    static class Program {

        #region PARTE PRIVADA
        
        private static List<Actividad_a> asignaturas;
        private static List<User> usuarios;
        private static List<Algoritmo> algoritmos;
        private static int codAsignaturas = Actividad_a.UltimoCodigo;

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

        //Obtiene/Cambia el último codigo de la asignatura
        public static int CodAsignaturas {
            set { codAsignaturas = value; }
            get { return codAsignaturas; }
        }

        //Añade una asignatura
        public static void AddAsignatura(Actividad_a a) {
            /*codAsignaturas++;
            a.Codigo = codAsignaturas;*/
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
        //CAMBIAR CUANDO SE INTEGREN LOS CADs SERÁ MÁS RÁPIDO
        public static Actividad getActividad(int codigo) {

            foreach (Actividad_a aa in asignaturas) {
                if (aa.Codigo == codigo)
                    return aa;
            }

            foreach (User u in Usuarios) {
                List<Actividad_p> act = u.ActPersonales;
                foreach (Actividad ap in act) {
                    if (ap.Codigo == codigo)
                        return ap;
                }
            }

            throw new ArgumentException("No existe una activida con ese código");
        }

        public static void setUsers()
        {
            CAD.CADUser user = new CAD.CADUser();
            CAD.CADActividad_p pers=new CAD.CADActividad_p();

            DataSet users = user.GetUsers();
            string dni, nom, email, pass, tit="";
            int curso = 0;
            List<Actividad_a> acta;
            List<Actividad_p> actp;
            List<Horario> hor;
            DataRowCollection rows=users.Tables[0].Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                dni = rows[i].ItemArray[0].ToString();
                nom = rows[i].ItemArray[1].ToString();
                email = rows[i].ItemArray[2].ToString();
                pass = rows[i].ItemArray[3].ToString();
                curso =  (int)rows[i].ItemArray[4];
                tit = rows[i].ItemArray[5].ToString();
                //actp = pers.GetActividadesP_FromUser(dni);

            }
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
