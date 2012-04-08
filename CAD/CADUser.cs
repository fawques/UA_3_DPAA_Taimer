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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
        public void CrearUserAll(string dni, string nombre, string email, string password, int curso, string codTit,int codH)
        {
            CADTitulacion tit = new CADTitulacion();
            /*if(!tit.Exists(codTit))
                "No existe la titulacion*/      
            string comando = "INSERT INTO [User] VALUES('" + dni + "', '" + nombre + "', '" + email + "', '" + password + "','"+ curso+"','"+ codTit +"','"+codH+"')";
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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return null;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return null;
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
        public DataSet GetDatosUser(string email, string pass)
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
                return datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return null;
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
        public void ModificaUser(string dni, string nombre, string email, string password, string tit)
        {
            string comando = "UPDATE [User] SET nombre = '" + nombre + "', email = '" + email + "', password = '" + password + "', titulacion = '" + tit + "' WHERE dni = '" + dni + "'";
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
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }
    }
}
