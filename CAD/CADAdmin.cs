using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections;


namespace CAD
{
    class CADAdmin
    {
        private static string conexionTBD;
        
        public CADAdmin()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio

        }
        //Método para crear un nuevo usu
        public void CrearAdminBasic(string dni, string nombre, string email, string password)
        {
            string comando = "INSERT INTO [Admin](dni,nombre,email,password) VALUES('" + dni + "', '" + nombre + "', '" + email + "', '" + password + "')";
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
                throw ex;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public void BorrarAdmin(string id)
        {
            SqlConnection c = null;
            string comando = "DELETE FROM [Admin] WHERE dni= '" + id + "'";

            try
            {
                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comando, c);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        //Obtenemos un dataset con los datos de los usuarios
        public DataSet GetAdmins()
        {

            SqlConnection con = null;
            DataSet listAdmins = null;
            string comando = "Select * from [Admin]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listAdmins = new DataSet();
                sqlAdaptador.Fill(listAdmins);
                return listAdmins;

            }
            catch (Exception ex)
            {
                // Captura la condición general y la reenvía.
                throw ex;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
         //Obtenemos los datos de un usuario según su dni
        public DataSet GetDatosAdmin(string dni)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Admin] where dni="+dni;
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
                // Captura la condición general y la reenvía.
                throw ex;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
        //Actualizar datos de un Usuario cuyo dni sea el que pasan como parámetro
        public void ModificaAdmin(string dni, string nombre, string email, string password)
        {
            string comando = "UPDATE [Admin] SET dni = '" + dni + "', nombre = '" + nombre + "', email = '" + email + "', password = '" + password + "' WHERE dni = '" + dni + "'";
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
                throw ex;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }
    }
}
