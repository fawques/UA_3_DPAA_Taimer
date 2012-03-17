using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections;
using Taimer;

namespace CAD
{
    public class CADUser
    {
        string conexionTBD="Data Source=localhost\\SQLEXPRESS;InitialCatalog=BDTAIMER;Integrated Security=True;";
        private static SqlConnection cnBD;
        public CADUser()
        {
            // Adquiere la cadena de conexión desde un único sitio

        }
        //Método para crear un nuevo usu
        public bool CrearUser(string dni, string nombre, string email, string password, int curso, string titulacion, int cod_Ac, int cod_Ho)
        {
            
            string comando = "INSERT INTO User(dni,nombre,email,password,curso,titulacion,codAct,codHorarios) VALUES('"+dni+"', '"+nombre+"', '"+email+"', '"+password+"', '"+curso+"', '"+titulacion+"', '"+cod_Ac+"', '"+cod_Ho+"')";
            SqlConnection c=null;
            SqlCommand comandoTBD;
            bool insertado = false;
            try
            {
                c = new SqlConnection(conexionTBD);
                comandoTBD = new SqlCommand(comando, c);
                c.Open();
                comandoTBD.CommandType = CommandType.Text;
                comandoTBD.ExecuteNonQuery();
                insertado = true;
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
            return insertado;
        }
        public bool BorrarUser(string id){
            
            bool borrado=false;
            SqlConnection c = null;
            string comando = "DELETE FROM User WHERE dni= '" + id + "'";

            try
            {

                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comando,c);
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

            return borrado;
        }

         //Obtenemos un dataset con los datos de los usuarios
        public DataSet ObtenerListadoUsuarios()
        {

            SqlConnection con = null;
            DataSet listUsers = null;
            string comando = "Select * from User";
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
                // Captura la condición general y la reenvía.
                throw ex;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
         //Obtenemos los datos de un usuario según su dni
        public DataSet ObtenerDatos(string dni)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from User where dni="+dni;
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
        public bool modificaUser(string dni, string nombre, string email, string password, int curso, string titulacion, int cod_Ac, int cod_Ho)
        {

            string comando = "UPDATE User SET dni = '" + dni + "', nombre = '" + nombre + "', email = '" + email + "', password = '" + password + "', curso = '" + curso + "', titulacion = '" + titulacion + "' WHERE dni = '" + dni + "'";
            SqlConnection c = null;
            SqlCommand comandoTBD;
            bool insertado = false;
            try
            {
                c = new SqlConnection(conexionTBD);
                comandoTBD = new SqlCommand(comando, c);
                c.Open();
                comandoTBD.CommandType = CommandType.Text;
                comandoTBD.ExecuteNonQuery();
                insertado = true;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
            return insertado;
        }

    }
}
