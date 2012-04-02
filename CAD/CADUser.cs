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
        //Método para crear un nuevo usu
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

        public void CrearUserAll(string dni, string nombre, string email, string password, int curso, string tit, int codA, int codH)
        {
            string comando = "INSERT INTO [User] VALUES('" + dni + "', '" + nombre + "', '" + email + "', '" + password + "','"+tit+"','"+codA+"','"+codH+"')";
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

        public void BorrarUser(string id)
        {
            SqlConnection c = null;
           // string comando = "DELETE FROM [User] WHERE dni= '" + id + "'";
            string comando = "DELETE FROM [Actividad_p] WHERE autor= '" + id + "'";

            try
            {

                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comando, c);
                cmd.ExecuteNonQuery();
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

        //Obtenemos un dataset con los datos de los usuarios
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
         //Obtenemos los datos de un usuario según su dni
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
        //Actualizar datos de un Usuario cuyo dni sea el que pasan como parámetro
        public void ModificaUser(string dni, string nombre, string email, string password)
        {
            string comando = "UPDATE [User] SET dni = '" + dni + "', nombre = '" + nombre + "', email = '" + email + "', password = '" + password + "' WHERE dni = '" + dni + "'";
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
