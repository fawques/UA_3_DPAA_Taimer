using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taimer;
using CAD;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Taimer {

    /// <summary>
    /// Clase User: Representa al usuario de la aplicación
    /// </summary>
    public class User {

        #region PARTE PRIVADA

        /// <summary>
        /// Nombre del usuario
        /// </summary>
        private string nombre;

        /// <summary>
        /// DNI del usuario
        /// También es la clavi primaria de la base de datos
        /// </summary>
        private string dni;

        /// <summary>
        /// e-Mail del usuario
        /// </summary>
        private string email;

        /// <summary>
        /// Contraseña del usuario
        /// </summary>
        private string password;

        /// <summary>
        /// Cusro en el que se encuentra el usuario
        /// </summary>
        private int curso;

        /// <summary>
        /// Titulación en la que está matriculado el usuario
        /// </summary>
        private string titulacion;

        /// <summary>
        /// Último código de horario asignado
        /// </summary>
        private int codHorarios;

        /// <summary>
        /// Lista de Actividades academicas en la que está matriculado el usuario
        /// </summary>
        private List<Actividad_a> actAcademicas = new List<Actividad_a>();          // Un usuario tiene (0,N) actividades académicas

        /// <summary>
        /// Listas de Actividades personales que realiza el usuario
        /// </summary>
        private List<Actividad_p> actPersonales = new List<Actividad_p>();          // Un usuario tiene (0,N) actividades personales

        /// <summary>
        /// Lista de Horarios que tiene guardados el usuario
        /// </summary>
        private List<Horario> horarios = new List<Horario>();                       // Un usuario tiene (0,N) horarios

        /// <summary>
        /// Frase personal del usuario
        /// </summary>
        private string frase;

        /// <summary>
        /// Imagen de perfil del usuario
        /// </summary>
        private string imagen;

        /// <summary>
        /// Asigna un código un horario
        /// </summary>
        /// <param name="h">Horario al que se le quiere dar un código</param>
        private void AsignarCodigo(Horario h) {
            h.ID = codHorarios;
            codHorarios++;
        }

        #endregion

        #region PARTE PÚBLICA

        /// <summary>
        ///  Constructor básico (sin listas)
        /// </summary>
        /// <param name="nom_">Nombre del Usuario</param>
        /// <param name="dni_">DNI del usuario</param>
        /// <param name="email_">e-Mail del usuario</param>
        /// <param name="pass_">Constraseña del usuario</param>
        /// <param name="curso_">Curso del usuario</param>
        /// <param name="tit_">Titulación del usuario</param>
        public User(string nom_, string dni_, string email_, string pass_, int curso_, string tit_,int codH_ = 0, string imagen_="",string frase_ = "") {
            nombre = nom_;
            dni = dni_;
            password = pass_;
            email = email_;
            curso = curso_;
            titulacion = tit_;
            codHorarios = codH_;
            imagen = imagen_;
            frase = frase_;
        }


        /// <summary>
        /// Constructor completo
        /// Uso exclusivo de los CADs
        /// </summary>
        /// <param name="nom_">Nombre del usuario</param>
        /// <param name="dni_">DNI del usuario</param>
        /// <param name="email_">e-Mail del usuario</param>
        /// <param name="pass_">Contraseña del usuario</param>
        /// <param name="curso_">Curso del usuario</param>
        /// <param name="tit_">Titulación del usuario</param>
        /// <param name="acta_">Lista de actividades academicas en las que está matriculado el usuario</param>
        /// <param name="actp_">Lista de actividades personales que realiza el usuario</param>
        /// <param name="hor_">Lista de horarios que tiene alamacenados el usuario</param>
        public User(string nom_, string dni_, string email_, string pass_, int curso_, string tit_, List<Actividad_a> acta_, List<Actividad_p> actp_, List<Horario> hor_, string imagen_ = "", string frase_ = "") {
            if(hor_ != null)
                codHorarios = hor_.Count;
            /* -- Al meterle las listas, sobre todo si vienen de los CAD, ya tienen su código puesto
            for (int i = 0; i < actp_.Count; i++)
                actp_[i].Codigo = i;

            for (int i = 0; i < hor_.Count; i++)
                hor_[i].ID = i;
            */

            codHorarios = 0;
            nombre = nom_;
            dni = dni_;
            password = pass_;
            email = email_;
            curso = curso_;
            titulacion = tit_;
            actAcademicas = acta_;
            actPersonales = actp_;
            horarios = hor_;
            imagen = imagen_;
            frase = frase_;
            //codActPers = (-1 * actPersonales.Count) + 1;
        }
     
        /// <summary>
        /// Consturctor de copia
        /// </summary>
        /// <param name="u">User que se quiere copiar</param>
        public User(User u) {
            codHorarios = u.codHorarios;
            dni = u.dni;
            nombre = u.nombre;
            email = u.email;
            password = u.password;
            curso = u.curso;
            actAcademicas = new List<Actividad_a>(u.ActAcademicas.Count);
            foreach (Actividad_a act_a in u.ActAcademicas)
            {
                ActAcademicas.Add(act_a);
            }
            
            actPersonales = new List<Actividad_p>(u.actPersonales.Count);
            foreach (Actividad_p act_p in u.ActPersonales)
            {
                ActPersonales.Add(act_p);
            }
            horarios = new List<Horario>(u.Horarios.Count);
            foreach (Horario h in u.Horarios)
            {
                Horarios.Add(h);
            }

            //codActPers = u.codActPers;
            titulacion = u.titulacion;

            imagen = u.imagen;
            frase = u.frase;
        }


        /// <summary>
        /// Asigna/Devuelve el nombre del usuario
        /// </summary>
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        /// <summary>
        /// Asigna/Devuelve el DNI del usuario
        /// </summary>
        public string DNI {
            get { return dni; }
            set { dni = value; }
        }


        /// <summary>
        /// Asinga/Devuelve el e-Mail del usuario
        /// </summary>
        public string Email {
            get { return email; }
            set { email = value; }
        }


        /// <summary>
        /// Asigna/Devuelve la contraseña del usuario
        /// </summary>
        public string Password {
            get { return password; }
            set { password = value; }
        }


        /// <summary>
        /// Asigna/Devuelve el curso del usuario
        /// </summary>
        public int Curso {
            get { return curso; }
            set { curso = value; }
        }

        /// <summary>
        /// Asigna/Devuelve la titulación del usuario
        /// </summary>
        public string Titulacion {
            set { titulacion = value; }
            get { return titulacion; }
        }

        /// <summary>
        /// Asigna/Devuelve el último código de Horario asignado
        /// </summary>
        public int CodHorarios {
            set { codHorarios = value; }
            get { return codHorarios; }
        }

        /// <summary>
        /// Asigna/Devuelve la lista de Actividad_a a las que está matriculado el usuario
        /// </summary>
        public List<Actividad_a> ActAcademicas {
            set { actAcademicas = value; }
            get { return actAcademicas; }
        }


        /// <summary>
        /// Asigna/Devuelve la lista de Actividad_p que realiza el usuario
        /// </summary>
        public List<Actividad_p> ActPersonales
        {
            set { actPersonales = value; }
            get { return actPersonales; }
        }

        public string Frase {
            set { frase = value; }
            get { return frase; }
        }

        public string Imagen {
            set { imagen = value; }
            get { return imagen; }
        }


        /// <summary>
        /// Añade una Actividad Academica, y lo matricula en la base de datos (el Usurio debe estar en la BD);
        /// </summary>
        /// <param name="act">Actividad_a que se desea añadir</param>
        public void AddActAcademica(Actividad_a act) {
            //CADUser usr = new CADUser();
            //usr.Matricular(dni, act.Codigo);
            actAcademicas.Add(act);
        }

        //Para matricularse en las que no estaba y desmatricularse en las que ya no esta
        //Actualiza su lista de matriculadas a la lista pasada por parametros
        public void UpdateMatricula(List<Actividad_a> actAc) {
            CADUser usr = new CADUser();

            List<Actividad_a> actAcademicasAux = new List<Actividad_a>();
            foreach (Actividad_a act_a in actAcademicas) {
                actAcademicasAux.Add(act_a);
            }

            foreach (Actividad_a act in actAcademicasAux) {
                if (!actAc.Contains(act)) {
                    actAcademicas.Remove(act);
                    usr.Desmatricular(dni, act.Codigo);
                }
            }

            foreach (Actividad_a act in actAc) {
                if (!actAcademicas.Contains(act)) {
                    actAcademicas.Add(act);
                    usr.Matricular(dni, act.Codigo);
                }
            }
            
        }

        /// <summary>
        ///  Borra una actividad académica (si existe). Devuelve valor booleano.
        ///  La Borra también de la BD.
        /// </summary>
        /// <param name="act">Activdad que se desea borrar</param>
        /// <returns>Devuelve TRUE si se ha borrado y FALSE en caso contrario</returns>
        public bool BorraActAcademicaBool(Actividad_a act) {

            try {
                CADUser usr = new CADUser();
                usr.Desmatricular(dni, act.Codigo);
            }
            catch {
                return false;
            }
            return actAcademicas.Remove(act);
        }
        

        /// <summary>
        ///  Borra una actividad académica (si existe). Lanza excepción.
        ///  La Borra también de la BD.
        /// </summary>
        /// <param name="act">Actividad que se desea borrar</param>
        public void BorraActAcademica(Actividad_a act)
        {
            if(!actAcademicas.Remove(act))
                throw new MissingMemberException("No existe la actividad académica que se desea borrar.");
            //CADUser usr = new CADUser();
            //usr.Desmatricular(dni, act.Codigo);
        }


        /// <summary>
        /// Añade una actividad personal (también a la BD)
        /// </summary>
        /// <param name="act">Actividad personal que se desa añadir</param>
        public void AddActPersonal(Actividad_p act) {
            act.Usuario = this;
            act.Agregar();
            actPersonales.Add(act);
        }

        /// <summary>
        ///  Borra una actividad personal (si existe). Devuelve valor booleano.
        /// </summary>
        /// <param name="act">Actividad personal que se desea borrar</param>
        /// <returns>Devuelve TRUE si se ha borrado y FALSE en caso contrario</returns>
        public bool BorraActPersonalBool(Actividad_p act)
        {
            try {
                act.Borrar();
            }
            catch {
                return false;
            }
            return actPersonales.Remove(act);
        }

        /// <summary>
        /// Borra una actividad personal (si existe). Lanza excepción.
        /// </summary>
        /// <param name="act">Actividad personal que se desea borrar</param>
        public void BorraActPersonal(Actividad_p act)
        {
            if(!actPersonales.Remove(act))
                throw new MissingMemberException("No existe la actividad personal que se desea borrar.");
            act.Borrar();
        }

        /// <summary>
        /// Devolver una actividad, ya sea académica o personal, a partir de su código
        /// </summary>
        public Actividad GetActividad(int cod)
        {
            if (cod >= 0)     // Si el código es un número positivo, es una actividad académica
            {
                foreach (Actividad act in actAcademicas)
                {
                    if (act.Codigo == cod)
                        return act;
                }
            }
            else
            {
                foreach (Actividad act in actPersonales)
                {
                    if (act.Codigo == cod)
                        return act;
                }
            }

            throw new MissingMemberException("No existe ninguna actividad con ese código.");
        }

        /// <summary>
        /// Añade un Horario a la lista de horarios y a la BD
        /// </summary>
        /// <param name="horario">Horaio que se desea añadir</param>
        public void AddHorario(Horario horario) {
            //AsignarCodigo(horario);
            horario.ID = codHorarios;
            horario.Agregar();
            codHorarios++;
            CADUser usr = new CADUser();
            usr.ModificaUser(dni, nombre, email, password, titulacion, codHorarios, imagen, frase);
            horarios.Add(horario);
        }

        /// <summary>
        /// Asigna/Devuelve la lista de horarios del usuario
        /// </summary>
        public List<Horario> Horarios {
            set {
                foreach (Horario h in horarios) {
                    AddHorario(h);
                }
            }
            get { return horarios; }
        }

        /// <summary>
        /// Borrar horario (booleano)
        /// </summary>
        /// <param name="hor">Horario que se desea borrar</param>
        /// <returns>TRUE si borra el horario, FALSE en caso contrario.</returns>
        public bool BorraHorarioBool(Horario hor) {
            try {
                hor.Borrar();
            }
            catch {
                return false;
            }
            return horarios.Remove(hor);
        }


        /// <summary>
        /// Borrar horario (excepción)
        /// </summary>
        /// <param name="hor">Horario que se desea borrar</param>
        public void BorraHorario(Horario hor) {
            if(!horarios.Remove(hor))
                throw new MissingMemberException("No existe el horario que se desea borrar.");
            hor.Borrar();
        }



        /// <summary>
        /// Borrar horario a partir de su identificador ID (booleano)
        /// </summary>
        /// <param name="idbuscado">Identificador del Horario que se desea borrar</param>
        /// <returns>TRUE si consigue borrarlo, FALSE en caso contrario</returns>
        public bool BorraHorarioBool (int idbuscado) {
            foreach (Horario hor in horarios) {
                if (hor.ID == idbuscado) {
                    try {
                        hor.Borrar();
                    }
                    catch {
                        return false;
                    }
                    return horarios.Remove(hor);
                }
            }
            return false;
        }


        /// <summary>
        /// Borrar horario a partir de su ID (excepción)
        /// </summary>
        /// <param name="idbuscado">Identificador del Horario que se desea borrar</param>
        public void BorraHorario(int idbuscado)
        {
            if(!BorraHorarioBool(idbuscado))
                throw new MissingMemberException("No existe el horario que se desea borrar.");

            foreach (Horario h in horarios) {
                if (h.ID == idbuscado)
                    h.Borrar();
            }
        }


        /// <sumary>
        /// Añade el User a la base de datos
        /// </sumary>
        public void Agregar()
        {
            CADUser user = new CADUser();
            user.CrearUserAll(dni, nombre, email, password, curso, titulacion, codHorarios,imagen,frase);
        }

        /// <summary>
        /// Guarda los cambios del usuario en la base de datos
        /// </summary>
        public void Modificar() {
            CADUser user = new CADUser();            
            user.ModificaUser(dni, nombre, email, password, titulacion, codHorarios, imagen, frase);
        }

        ///<summary>
        ///Borra el usuario de la base de datos
        ///</summary>
        public void Borrar() {
            CADUser user = new CADUser();
            user.BorrarUser(dni);
        }

        /// <summary>
        /// Convierte un DataSet (que tendrá filas de usuarios) en una lista de usuarios
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static List<User> UsersToList(DataSet data)
        {
            if (data != null)
            {
                List<User> list = new List<User>();
                string dni, nom, email, pass, tit = "",img="",frs = "";
                int curso = 0, codH = 0;
                DataRowCollection rows = data.Tables[0].Rows;
                
                for (int i = 0; i < rows.Count; i++)
                {
                    dni = rows[i].ItemArray[0].ToString();
                    nom = rows[i].ItemArray[1].ToString();
                    email = rows[i].ItemArray[2].ToString();
                    pass = rows[i].ItemArray[3].ToString();

                    if (rows[i].ItemArray[4].ToString() != "")
                        curso = (int)rows[i].ItemArray[4];

                    if (rows[i].ItemArray[5].ToString() != "")
                        tit = rows[i].ItemArray[5].ToString();

                    if (rows[i].ItemArray[6].ToString() != "")
                        codH = (int)rows[i].ItemArray[6];

                    img = rows[i].ItemArray[7].ToString();

                    frs = rows[i].ItemArray[8].ToString();

                    User user = new User(nom, dni, email, pass, curso, tit, codH, frs);
                    user.SetDatos();
                    list.Add(user);
                }
                return list;
            }
            return null;
        }

        /// <summary>
        /// Convierte un DataSet(será un usuario) en un objeto User
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static User UserToObject(DataSet data)
        {         
            if (data != null)
            {
                string dni, nom, email, pass, tit = "", img = "", frs = "";
                int curso = 0, codH = 0;
                DataRowCollection rows = data.Tables[0].Rows;

                if (rows.Count != 0)
                {
                    dni = rows[0].ItemArray[0].ToString();
                    nom = rows[0].ItemArray[1].ToString();
                    email = rows[0].ItemArray[2].ToString();
                    pass = rows[0].ItemArray[3].ToString();

                    if (rows[0].ItemArray[4].ToString() != "")
                        curso = (int)rows[0].ItemArray[4];

                    if (rows[0].ItemArray[5].ToString() != "")
                        tit = rows[0].ItemArray[5].ToString();

                    if (rows[0].ItemArray[6].ToString() != "")
                        codH = (int)rows[0].ItemArray[6];


                    img = rows[0].ItemArray[7].ToString();

                    frs = rows[0].ItemArray[8].ToString();

                    User user = new User(nom, dni, email, pass, curso, tit,codH,img,frs);
                    user.SetDatos();
                    return user;
                }                
            }
            return null;
        }

        /// <summary>
        /// Convierte un DataSet (será un usuario) en un objeto User (sólo con nombre y DNI)
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static User UserToObjectQuick(DataSet data)
        {
            if (data != null)
            {
                string dni, nom, email;
                DataRowCollection rows = data.Tables[0].Rows;

                if (rows.Count != 0)
                {
                    dni = rows[0].ItemArray[0].ToString();
                    nom = rows[0].ItemArray[1].ToString();
                    email = rows[0].ItemArray[2].ToString();

                    User user = new User(nom, dni, email, null, 0, null, null, null, null);
                    return user;
                }
            }
            return null;
        }

        /// <summary>
        /// Comprueba que el login de un determinado usuario es correcto
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static User CheckLoginUser(string email, string pass)
        {
            CADUser userCAD = new CADUser();
            userCAD.Login(email, pass);
            User user = UserToObject(userCAD.GetDatosUserByLogin(email, pass));
            return user;                      
        }

        /// <summary>
        /// Comprueba que el login de un determinado admin es correcto
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static List<User> CheckLoginAdmin(string email, string pass)
        {
            CADAdmin adminCAD = new CADAdmin();
            adminCAD.Login(email, pass);
            return GetAllUsers();
        }

        /// <summary>
        /// Relleno del campo Horarios desde la BD
        /// </summary>
        private void SetHorarios()
        {
            CAD.CADHorario hor = new CADHorario();
            DataSet data = hor.GetDatosHorarioUser(dni);            
            horarios = Horario.HorariosToList(data, this);
            /*foreach (Horario h in horarios)
            {
                MessageBox.Show(h.ID + ": " + h.ArrayTurnos[0].Count + " lunes " +
                                          h.ArrayTurnos[1].Count + " martes " +
                                          h.ArrayTurnos[2].Count + " miercoles " +
                                          h.ArrayTurnos[3].Count + " jueves " +
                                          h.ArrayTurnos[4].Count + " viernes ");
            }*/
        }

        /// <summary>
        /// Completa la lista de actividades académicas matriculadas de un usuario
        /// </summary>
        private void SetActAcademicas()
        {
            CADUser user = new CADUser();
            DataSet data=user.GetMatriculadas(this.dni);                
            actAcademicas = Actividad_a.CodesToList(data);
            /*foreach (Actividad_a acta in actAcademicas)
            {
                MessageBox.Show(acta.Codigo + ": " + acta.Turnos.Count + " turnos");
            }*/
        }

        /// <summary>
        /// Completa la lista de actividades personales creadas por un usuario
        /// </summary>
        private void SetActPersonales()
        {
            CADActividad_p act = new CADActividad_p();
            actPersonales = Actividad_p.Actividades_pToList(act.GetActividades_pByUser(this.dni),this);
            /*foreach (Actividad_p actp in actPersonales)
            {
                MessageBox.Show(actp.Codigo + ": " + actp.Turnos.Count + " turnos");
            }*/
        }

        /// <summary>
        /// Completa las listas de actividades académicas, de actividades personales y de horarios de un usuario
        /// </summary>
        public void SetDatos()
        {
            SetActAcademicas();
            SetActPersonales();
            SetHorarios();
        }

        /// <summary>
        /// Obtiene la lista de todos los usuarios actuales
        /// </summary>
        /// <returns></returns>
        public static List<User> GetAllUsers()
        {
            CADUser userCAD = new CADUser();
            DataSet users = userCAD.GetUsers();
            List<User> list = UsersToList(users);
            
            return list;
        }


        /// <summary>
        /// Obtiene la lista de todos los usuarios actuales excepto el de cierto DNI
        /// </summary>
        /// <returns></returns>
        public static List<User> GetAllUsersExceptoUno(string dnibuscado)
        {
            CADUser userCAD = new CADUser();
            DataSet users = userCAD.GetUsersExceptoUno(dnibuscado);
            List<User> list = UsersToList(users);

            return list;
        }


        /// <summary>
        /// Obtiene la lista de todos los usuarios a los que se les aplica el filtro en el nombre y el DNI es distinto del enviado
        /// </summary>
        public static List<User> GetUsersFiltro(string filtro, string dnipropio)
        {
            CADUser userCAD = new CADUser();
            DataSet users = userCAD.GetUsersFiltro(filtro, dnipropio);
            List<User> list = UsersToList(users);

            return list;
        }


        /// <summary>
        /// Pide al usuario que abra un archivo para su imagen personal, y la copia al directorio Images
        /// </summary>
        public void InsertaFoto()
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif)|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    int index = NameExists();
                    string[] path = openFileDialog1.FileName.Split('.');
                    string name = nombre;

                    index = 1;
                    if(index>0)
                        name += index;

                    name +=  '.' + path[path.Length - 1];                    
                    File.Copy(openFileDialog1.FileName, "C:\\Taimer\\WebTaimer\\Images\\"+name, true);

                    //imagen = name;
                }
            }

        }

        /// <summary>
        /// Cambia la imagen de perfil del usuario, a partir de un nombre de archivo parasdo por parámetro
        /// </summary>
        public void InsertaFoto(string file)
        {
            int index = NameExists();
            string[] path = file.Split('.');
            string name = nombre;
            
            if (index > 0)
                name += index;

            name += '.' + path[path.Length - 1];                    
                       
            //File.Delete(imagen);
            imagen = name;           
        }

        /// <summary>
        /// Obtiene un objeto User a partir de su email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static User GetUserByEmail(string email)
        {            
            CADUser cad=new CADUser();
            return UserToObject(cad.GetDatosUserByLogin(email));
        }


        public static User GetUserByDNI(string dni)
        {
            CADUser cad = new CADUser();
            return UserToObject(cad.GetUserByDNI(dni));
        }

        public static User GetUserByDNIQuick(string dni)
        {
            CADUser cad = new CADUser();
            return UserToObjectQuick(cad.GetDatosUserQuick(dni));
        }

        /// <summary>
        /// Comprueba si el nombre del usuario está repetido, devolviendo el número del resto de usuarios con dicho nombre
        /// </summary>
        /// <returns></returns>
        public int NameExists()
        {
            CADUser cad=new CADUser();
            List<User> users = UsersToList(cad.GetUsers());
            int index = 0;

            foreach (User u in users)
            {
                if (u.Nombre == Nombre && u.Email != Email)
                    index++;
            }
            return index;
        }

        #endregion
    }
}

