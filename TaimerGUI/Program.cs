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
        private static List<Algoritmo> algoritmos= new List<Algoritmo>();
        private static int codAsignaturas = Actividad_a.UltimoCodigo;

        private static void Init()
        {
            //Esta función se llama en el main.

            /*
             * 
             *              FUNCIONES DE DATOS POR DEFECTO, CUANDO SE COMPRUEBE QUE FUNCIONAN LOS CAD, BORRAR
             * 
             * 
            asignaturas = new List<Actividad_a>();
            usuarios = new List<User>();
            algoritmos = new List<Algoritmo>();

            // =========== Datos de prueba, aquí tiene que haber un CAD que lo rellene. ============
            User usertest = new User("Aitor Tilla", "12345678X", "bill_gates@hotmail.com", "password", 1, "Ingeniería de Magisterio");

            usuarios.Add(usertest);

            Turno t1 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.M, "L04");
            Turno t2 = new Turno(new Hora(11, 30), new Hora(13, 30), dias.L, "L04");
            Turno t3 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.M, "L04");
            Turno t4 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.X, "L04");
            Turno t5 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.X, "L04");
            Turno t6 = new Turno(new Hora(14, 30), new Hora(16, 30), dias.L, "L04");
            Turno t7 = new Turno(new Hora(10, 30), new Hora(14, 30), dias.M, "L04");
            Turno t8 = new Turno(new Hora(11, 30), new Hora(14, 30), dias.V, "L04");
            Turno t9 = new Turno(new Hora(0, 30), new Hora(1, 30), dias.L, "L04");

            Actividad_p actP = new Actividad_p("EOI", "Escuela Oficial de Idiomas", -1, Usuarios[0]);
            actP.AddTurno(t1);

            Actividad_p actP2 = new Actividad_p("Médico", "Médico", -2, Usuarios[0]);
            actP2.AddTurno(t4);
            actP2.AddTurno(t5);
            actP2.AddTurno(t6);

            Actividad_a actA = new Actividad_a("DPAA", "Diseño y Programación de Aplicaciones Avanzadas", 1, "Irene",3);

            actA.AddTurno(t2);
            actA.AddTurno(t3);

            Actividad_a actA2 = new Actividad_a("LPP", "Lenguajes y Paradigmas de Programación", 2, "Domingo Gallardo",2);
            actA2.AddTurno(t7);
            //actA2.AddTurno(t8);
            actA2.AddTurno(t9);

            asignaturas.Add(actA);
            asignaturas.Add(actA2);

            Usuarios[0].AddActPersonal(actP);
            Usuarios[0].AddActPersonal(actP2);
             * */

            usuarios = new List<User>();
            asignaturas = new List<Actividad_a>();
            algoritmos = new List<Algoritmo>();

            SetDatos();

            /*foreach (User u in usuarios)
            {
                string message = u.Nombre + ": " + u.ActAcademicas.Count + "-" + u.ActPersonales.Count;
                MessageBox.Show(message);
            }*/
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

        //Obtiene/Cambia el último codigo de la asignatura
        public static int CodAsignaturas {
            set { codAsignaturas = value; }
            get { return codAsignaturas; }
        }

        /// <summary>
        /// Añade una Asignatura (tambien en la BD)
        /// </summary>
        /// <param name="a">Asignatura que se quiere añadir</param>
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

        /// <summary>
        /// Borra una asignatura. Lanza MissingMemberException si la asignatura no existe.
        /// </summary>
        /// <param name="codigo">Código de la asignatura a borrar</param>
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

        /// <summary>
        /// Añade un usuario a la lista en Program
        /// </summary>
        /// <param name="u"></param>
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

        /// <summary>
        /// Borra un usuario. Lanza MissingMemberException si el usuario no existe
        /// </summary>
        /// <param name="dni">Dni del usuario a borrar</param>

        public static void BorrarUsuario(string dni)
        {
            bool borrado = false;
            foreach (User u in Usuarios)
            {
                if (u.DNI == dni)
                {
                    borrado = usuarios.Remove(u);
                    break;
                }
            }
            if(!borrado)
                throw new MissingMemberException("El usuario no existe");
        }

        /// <summary>
        /// Comprueba si existe un algoritmo con las actividades que se le pasan. Si existe, lo devuelve, si no, devuelve null.
        /// </summary>
        /// <param name="academicas">Actividades académicas a comprobar</param>
        /// <param name="personales">Actividades personales a comprobar</param>
        /// <returns></returns>
        public static Algoritmo ComprobarAlgoritmo(List<Actividad_a> academicas, List<Actividad_p> personales)
        {
            //bool iguales = true;
            //foreach (Algoritmo item in algoritmos)
            //{
            //    if (item.Seleccionadas_p.Count == personales.Count && item.Seleccionadas_a.Count == academicas.Count)
            //    {
            //        for (int i = 0; i < personales.Count && iguales; i++)
            //        {
            //            if (!item.Seleccionadas_p[i].Equals(personales[i]))
            //            {
            //                iguales = false;
            //            }
            //        }

            //        for (int i = 0; i < academicas.Count && iguales; i++)
            //        {
            //            if (!item.Seleccionadas_a[i].Equals(academicas[i]))
            //            {
            //                iguales = false;
            //            }
            //        }

            //    }
            //    else
            //        iguales = false;


            //     if(iguales)
            //         return item;
            //}
            return null;
        }


        /// <summary>
        /// Añade un algoritmo a la lista
        /// </summary>
        /// <param name="a"></param>

        public static void AddAlgoritmo(Algoritmo a) {
            algoritmos.Add(a);
        }


        //Devuelve una actividad ya sea academica o personal a partir de código
        public static Actividad GetActividad(int codigo) 
        {

            if (codigo > 0)
            {
                foreach (Actividad_a aa in asignaturas)
                {
                    if (aa.Codigo == codigo)
                        return aa;
                }
            }
            else
            {
                foreach (User u in Usuarios)
                {
                    List<Actividad_p> act = u.ActPersonales;
                    foreach (Actividad ap in act)
                    {
                        if (ap.Codigo == codigo)
                            return ap;
                    }
                }
            }

            throw new ArgumentException("No existe una actividad con ese código");
        }

        /// <summary>
        /// Modifica los datos de una actividad, asignándole los que tiene la actividad que se le pasa.
        /// </summary>
        /// <param name="act"></param>
        public static void ModificarActividad(Actividad act)
        {
            bool borrado = false;
            if (act is Actividad_a)
            {
                foreach (Actividad_a item in asignaturas)
                {
                    if (item.Codigo == act.Codigo)
                    {
                        item.CopiarDesde(act);
                        borrado = true;
                        break;
                    }
                }
                if (!borrado)
                    throw new ArgumentException("La Actividad especificada no existe");
            }
            else
            {
                foreach (User item in usuarios)
                {
                    foreach (Actividad_p pers in item.ActPersonales)
                    {
                        if (pers.Codigo == act.Codigo)
                        {
                            pers.CopiarDesde(act);
                            borrado = true;
                            break;
                        }
                    }
                    if (borrado)
                        break;
                    
                }
                if (!borrado)
                    throw new ArgumentException("La Actividad especificada no existe");
            }
        }

        /// <summary>
        /// Rellena las listas de usuarios y actividades
        /// </summary>
        public static void SetDatos()
        {
            //usuarios = User.GetAllUsers();
            /*string message = "";
            foreach (User u in usuarios)
            {
                message = u.DNI + ": " + u.ActAcademicas.Count + " academicas, "+u.ActPersonales.Count+" personales y "+u.Horarios.Count+" horarios";
                MessageBox.Show(message);
            }*/
            //asignaturas=Actividad_a.GetAllActividades_a();
            /*foreach (Actividad_a act in asignaturas)
            {
                message = act.Codigo + ": " + act.Turnos.Count + " turnos , el último es "+act.Codigoturno;
                MessageBox.Show(message);
            }*/
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

            ///prueba 1: Insertar todo en la BD///
            
            /*User usr = new User("Madona", "0000006", "madona@gmail.com", "madonarules", 3, "II");
            usr.Agregar();
            MessageBox.Show("Agrega el USR a la BD");

            List<Turno> lt = new List<Turno>();
            lt.Add(new Turno(new Hora(0, 0), new Hora(1, 0), dias.L, "Hospital"));
            lt.Add(new Turno(new Hora(1, 0), new Hora(2, 0), dias.L, "Hospital"));
            lt.Add(new Turno(new Hora(2, 0), new Hora(3, 0), dias.L, "Hospital"));
            usr.AddActPersonal(new Actividad_p("medico", "dentista", lt));
            MessageBox.Show("Ha metido la actividad medico");

            lt.Clear();
            lt.Add(new Turno(new Hora(0, 0), new Hora(1, 0), dias.M, "Escuela de idiomas"));
            lt.Add(new Turno(new Hora(1, 0), new Hora(2, 0), dias.M, "Escuela de idiomas"));
            lt.Add(new Turno(new Hora(2, 0), new Hora(3, 0), dias.M, "Escuela de idiomas"));
            usr.AddActPersonal(new Actividad_p("Ingles", "preparación para el first", lt));
            MessageBox.Show("Ha metido la actividad Ingles");

            lt.Clear();
            lt.Add(new Turno(new Hora(0, 0), new Hora(1, 0), dias.J, "Tu casa"));
            lt.Add(new Turno(new Hora(1, 0), new Hora(2, 0), dias.J, "Tu casa"));
            lt.Add(new Turno(new Hora(2, 0), new Hora(3, 0), dias.J, "Tu casa"));
            Actividad_a actA = new Actividad_a("Principios de vagueza", "no hacer nada", "Jack Black", lt, 1, "Cualquiera");
           
            actA.Agregar();
            MessageBox.Show("Ha metido la actividad Principios de vagueza");
            usr.AddActAcademica(actA);
            MessageBox.Show("Ha matriculado al usuario");

            Horario h = new Horario("Horario 1", usr);
            h.AddTurno(usr.ActAcademicas[0].Turnos[0]);

            foreach(Actividad_p a in usr.ActPersonales){
                foreach (Turno t in a.Turnos)
                    h.AddTurno(t);
            }

            usr.AddHorario(h);
            MessageBox.Show("Añade el Horario 1");
            Horario h2 = new Horario("Horario 2", usr);
            usr.AddHorario(h2);
            MessageBox.Show("Añade el Horario 2");*/

            ///prueba 2: borrar una Actividad_p///
           /* User usr = new User("Madona", "0000006", "madona@gmail.com", "madonarules", 3, "II");
            usr.Agregar();

            List<Turno> lt = new List<Turno>();
            lt.Add(new Turno(new Hora(0, 0), new Hora(1, 0), dias.L, "Hospital"));
            lt.Add(new Turno(new Hora(1, 0), new Hora(2, 0), dias.L, "Hospital"));
            lt.Add(new Turno(new Hora(2, 0), new Hora(3, 0), dias.L, "Hospital"));
            usr.AddActPersonal(new Actividad_p("medico", "dentista", lt));
            MessageBox.Show("Ha metido la actividad medico");

            usr.BorraActPersonal(usr.ActPersonales[0]);
            MessageBox.Show("Borrada la Actividad_p");*/

            ///prueba 3: borrar un horario///
            /*User usr = new User("Madona", "0000006", "madona@gmail.com", "madonarules", 3, "II");
            usr.Agregar();
            Horario h = new Horario("H 1", usr);
            Horario h2 = new Horario("H 2", usr);
            usr.AddHorario(h);
            usr.AddHorario(h2);
            MessageBox.Show("Añadido los horarios");
            usr.BorraHorario(usr.Horarios[0]);
            MessageBox.Show("Borrado el horario");*/

            ///Prueba 4: borrar una Actividad_a///
            /*List<Turno> lt = new List<Turno>();
            lt.Add(new Turno(new Hora(0, 0), new Hora(1, 0), dias.J, "ua"));
            lt.Add(new Turno(new Hora(1, 0), new Hora(2, 0), dias.J, "ua"));
            lt.Add(new Turno(new Hora(2, 0), new Hora(3, 0), dias.J, "ua"));
            Actividad_a actA = new Actividad_a("Principios de vagueza", "no hacer nada", "Jack Black", lt, 1, "Cualquiera");
            actA.Agregar();
            MessageBox.Show("Añadida la Actividad_a");
            actA.Borrar();
            MessageBox.Show("Borrada la Actividad_a");*/

            ///Prueba 5: borrar un turno de una actividad///
            /*List<Turno> lt = new List<Turno>();
            lt.Add(new Turno(new Hora(0, 0), new Hora(1, 0), dias.J, "ua"));
            lt.Add(new Turno(new Hora(1, 0), new Hora(2, 0), dias.J, "ua"));
            lt.Add(new Turno(new Hora(2, 0), new Hora(3, 0), dias.J, "ua"));
            Actividad_a actA = new Actividad_a("Principios de vagueza", "no hacer nada", "Jack Black", lt, 1, "Cualquiera");
            actA.Agregar();
            MessageBox.Show("Añadida la Actividad_a");
            actA.Turnos[0].Borrar();
            actA.BorraTurno(0);
            MessageBox.Show("Borrado turno");*/


        }
        #endregion
    }
}
