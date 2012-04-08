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
    class CADTitulacion
    {
        private static string conexionTBD;
        
        public CADTitulacion()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio

        }
        /// <summary>
        /// Insertamos una titulación
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nom"></param>
        public void CrearTitulacion(string cod, string nom)
        {
            string comando = "INSERT INTO [Titulacion](codigo,nombre) VALUES('"+cod+"','"+nom+"')";
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
        /// <summary>
        /// Borramos una titulación
        /// </summary>
        /// <param name="cod"></param>
        public void BorrarTitulacion(string cod)
        {   
            SqlConnection c = null;
            string comando = "DELETE FROM [Titulacion] WHERE codigo='"+cod+"'";

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

        /// <summary>
        /// Devolvemos la lista de titulaciones de la BD
        /// </summary>
        /// <returns></returns>
        public DataSet GetTitulaciones()
        {

            SqlConnection con = null;
            DataSet listTitulacions = null;
            string comando = "SELECT * FROM [Titulacion]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listTitulacions = new DataSet();
                sqlAdaptador.Fill(listTitulacions);
                return listTitulacions;

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
         /// <summary>
        /// Obtenemos los datos de una titulación 
         /// </summary>
         /// <param name="cod"></param>
         /// <returns></returns>
        public DataSet GetDatos(string cod)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "SELECT * FROM [Titulacion] where codigo='"+cod+"'";
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
        /// <summary>
        /// Actualizar datos de una titulación
        /// </summary>
        /// <param name="cod"></param>
        /// <param name="nom"></param>

        public void ModificaTitulacion(string cod, string nom)
        {

            string comando = "UPDATE [Titulacion] SET codigo = '" + cod + "', nombre = '" + nom + "' WHERE codigo = '"+cod+"'";
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

        /// <summary>
        /// Devuelve true si una titulación existe
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public bool Exists(string cod)
        {
            DataSet data = GetDatos(cod);

            if (data.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }
    }
}
