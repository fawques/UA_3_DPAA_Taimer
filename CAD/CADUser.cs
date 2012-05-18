using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections;
using System.Windows.Forms;

namespace CAD
{
    
    public class CADUser
    {
        private static string conexionTBD;
        
        public CADUser()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio

        }
        /// <summary>
        /// Método para crear un nuevo usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void CrearUserBasic(string dni, string nombre, string email, string password)
        {
            string comando = "INSERT INTO [User](dni,nombre,email,password) VALUES('" + dni + "', '" + nombre + "', '" + email + "', '" + password + "')";
            SqlConnection c=null;
            SqlCommand comandoTBD;
            
            try
            {
                c = new SqlConnection(conexionTBD);
                comandoTBD = new SqlCommand(comando, c);
                c.Open();
                comandoTBD.CommandType = CommandType.Text;
                comandoTBD.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }
        /// <summary>
        /// Método para crear un nuevo usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="curso"></param>
        /// <param name="tit"></param>
        /// <param name="codH"></param>
        public void CrearUserAll(string dni, string nombre, string email, string password, int curso, string codTit,int codH, string avat, string frase)
        {
            CADTitulacion tit = new CADTitulacion();
            if (!tit.Exists(codTit))
            {
                tit.CrearTitulacion(codTit);
            }
            string comando = "INSERT INTO [User] VALUES('" + dni + "', '" + nombre + "', '" + email + "', '" + password + "','" + curso + "','" + codTit + "','" + codH + "','" + avat + "','" + frase + "')";
            SqlConnection c = null;
            SqlCommand comandoTBD;

            try
            {
                c = new SqlConnection(conexionTBD);
                comandoTBD = new SqlCommand(comando, c);
                c.Open();
                comandoTBD.CommandType = CommandType.Text;
                comandoTBD.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        /// <summary>
        /// Borra un usuario
        /// </summary>
        /// <param name="id"></param>
        public void BorrarUser(string id)
        {
            SqlConnection c = null;
            string comando = "DELETE FROM [User] WHERE dni= '" + id + "'";
            
            CADActividad_p actp = new CADActividad_p();
            CADActividad act = new CADActividad();

            List<int> codes = actp.CodesToList(actp.GetCodesByUser(id));
                
            try
            {
                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comando, c);
                cmd.ExecuteNonQuery();
                foreach(int i in codes)
                {
                    act.BorrarActividad(i);
                }
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        /// <summary>
        /// Obtenemos un dataset con los datos de los usuarios
        /// </summary>
        /// <returns></returns>
        public DataSet GetUsers()
        {
            SqlConnection con = null;
            DataSet listUsers = null;
            string comando = "Select * from [User]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listUsers = new DataSet();
                sqlAdaptador.Fill(listUsers);
                return listUsers;

            }
            catch (SqlException)
            {
                //return null;
                throw;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
         /// <summary>
        /// Obtenemos los datos de un usuario según su dni
         /// </summary>
         /// <param name="dni"></param>
         /// <returns></returns>
        public DataSet GetDatosUser(string dni)
        {
            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [User] where dni='"+dni+"'";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                datos = new DataSet();
                sqlAdaptador.Fill(datos);
                return datos;
            }
            catch (SqlException)
            {
                //return null;
                throw;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }



        /// <summary>
        /// Sólo obtiene el nombre del usuario a partir del DNI
        /// </summary>
        /// <param name="dni"></param>
        public DataSet GetDatosUserQuick(string dni)
        {
            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select dni, nombre, email from [User] where dni='" + dni + "'";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                datos = new DataSet();
                sqlAdaptador.Fill(datos);
                return datos;
            }
            catch (SqlException)
            {
                //return null;
                throw;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }


        /// <summary>
        /// Obtiene los datos de un usuario a partir de un email y un password (datos de login)
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public DataSet GetDatosUserByLogin(string email, string pass=null)
        {            
            SqlConnection con = null;
            DataSet datos = null;
            string comando;

            if(pass!=null)
               comando = "Select * from [User] where email='" + email + "' and password='" + pass + "'";
            
            else
               comando = "Select * from [User] where email='" + email + "'";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                datos = new DataSet();
                sqlAdaptador.Fill(datos);
                return datos;
            }
            catch (SqlException)
            {
                //return null;
                throw;
                
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
        /// <summary>
        /// Actualizar datos de un Usuario cuyo dni sea el que pasan como parámetro
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="tit"></param>
        public void ModificaUser(string dni, string nombre, string email, string password, string tit, int codHorarios, string avat, string frase)
        {
            CADTitulacion titu = new CADTitulacion();
            if (!titu.Exists(tit))
            {
                titu.CrearTitulacion(tit);
            }        
            string comando = "UPDATE [User] SET nombre = '" + nombre + "', email = '" + email + "', password = '" + password + "', titulacion = '" + tit + "', codHorarios = '"+ codHorarios + "', avatar = '" + avat + "', frase = '" + frase + "' WHERE dni = '" + dni + "'";
            SqlConnection c = null;
            SqlCommand comandoTBD;

            try
            {
                c = new SqlConnection(conexionTBD);
                comandoTBD = new SqlCommand(comando, c);
                c.Open();
                comandoTBD.CommandType = CommandType.Text;
                comandoTBD.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }
        /// <summary>
        /// Aqui matriculamos a un user en una actividad_a 
        /// </summary>
        /// <param name="dni">Dni del usuario que queremos matricular en una actividad</param>
        /// <param name="codigo">Código de la asignatura que queremos matricular</param>
        public void Matricular(string dni, int codigo)
        {
            string comando = "INSERT INTO [User_Actividad_a](usuario,codigo_act) VALUES('" + dni + "', '" +codigo+ "')";
            SqlConnection c = null;
            SqlCommand comandoTBD;
            try
            {
                c = new SqlConnection(conexionTBD);
                comandoTBD = new SqlCommand(comando, c);
                c.Open();
                comandoTBD.CommandType = CommandType.Text;
                comandoTBD.ExecuteNonQuery();

            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        
        }
        /// <summary>
        /// En este método desmatriculamos a un User de una Actividad_a
        /// </summary>
        /// <param name="dni">Dni del usuario</param>
        /// <param name="cod">Codigo de la actividad</param>
        public void Desmatricular(string dni, int cod)
        {
            SqlConnection c = null;
            string comand = "DELETE FROM [User_Actividad_a] WHERE usuario= '" + dni + "' and codigo_act= '" + cod + "'";
            try
            {

                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comand, c);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        
        }
        /// <summary>
        /// Devuelve los codigos de las actividades que esta matriculado un usuario
        /// </summary>
        /// <param name="dni">Dni del usuario</param>
        /// <returns></returns>
        public DataSet GetMatriculadas(string dni)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select codigo_act from [User_Actividad_a] where usuario='" + dni + "'";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                datos = new DataSet();                
                sqlAdaptador.Fill(datos);
                return datos;

            }
            catch (SqlException)
            {
                // Captura la condición general y la reenvía.
                throw;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }

        /// <summary>
        /// Lanza una excepción si el login es incorrecto.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public void Login(string email, string pass)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [User] where email='" + email + "' and password='" + pass + "'";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                datos = new DataSet();
                sqlAdaptador.Fill(datos);
                if (datos.Tables[0].Rows.Count == 0)
                    throw new InvalidDataException("Usuario o contraseña incorrectos");

            }
            catch (SqlException)
            {
                // Captura la condición general y la reenvía.
                throw;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }


        /// <summary>
        /// Obtenemos un dataset con los datos de los usuarios (excepto uno, el del DNI buscado, que suele ser el usuario que ha iniciado sesión)
        /// </summary>
        /// <returns></returns>
        public DataSet GetUsersExceptoUno(string dnipropio)
        {
            SqlConnection con = null;
            DataSet listUsers = null;
            string comando = "Select * from [User] where dni <> '" + dnipropio + "' order by nombre";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listUsers = new DataSet();
                sqlAdaptador.Fill(listUsers);
                return listUsers;

            }
            catch (SqlException)
            {
                //return null;
                throw;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }


        /// <summary>
        /// Obtenemos un dataset con los datos de los usuarios (filtrado) y exceptuando el DNI del usuario
        /// </summary>
        /// <returns></returns>
        public DataSet GetUsersFiltro(string filtro, string dnipropio)
        {
            SqlConnection con = null;
            DataSet listUsers = null;
            string comando = "Select * from [User] where nombre like '%" + filtro + "%' and dni <> '" + dnipropio + "' order by nombre";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listUsers = new DataSet();
                sqlAdaptador.Fill(listUsers);
                return listUsers;

            }
            catch (SqlException)
            {
                //return null;
                throw;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public DataSet GetUserByDNI(string dni)
        {
            SqlConnection con = null;
            DataSet datos = null;
            string comando;

                comando = "Select * from [User] where dni='" + dni + "'";

            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                datos = new DataSet();
                sqlAdaptador.Fill(datos);
                return datos;
            }
            catch (SqlException)
            {
                //return null;
                throw;

            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
    }
}