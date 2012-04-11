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
    public class CADTitulacion
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
        /// <param name="nom"></param>
        public void CrearTitulacion(string nom)
        {
            string comando = "INSERT INTO [Titulacion](nombre) VALUES('"+nom+"')";
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
        /// Borramos una titulación
        /// </summary>
        /// <param name="nombre"></param>
        public void BorrarTitulacion(string nombre)
        {   
            SqlConnection c = null;
            string comando = "DELETE FROM [Titulacion] WHERE nombre='"+nombre+"'";
            try
            {

                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comando, c);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException )
            {
                throw;
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
            catch (SqlException)
            {
                // Captura la condición general y la reenvía.
                throw ;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
         /// <summary>
        /// Obtenemos los datos de una titulación 
         /// </summary>
         /// <param name="nombre"></param>
         /// <returns></returns>
        public DataSet GetDatos(string nombre)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "SELECT * FROM [Titulacion] where nombre='"+nombre+"'";
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
        /// Devuelve true si una titulación existe
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public bool Exists(string nombre)
        {
            DataSet data = GetDatos(nombre);

            if (data.Tables[0].Rows.Count == 0)
                return false;
            else
                return true;
        }
    }
}
