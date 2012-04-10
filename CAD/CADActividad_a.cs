using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections;
using System.Windows.Forms;


namespace CAD {

    public class CADActividad_a
    {
        private static string conexionTBD;

         public CADActividad_a ()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio

        }
        /// <summary>
        /// Se insertan actividades en la BD
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="desc"></param>
        /// <param name="codigo"></param>
        /// <param name="profesor"></param>
        /// <param name="titulacion"></param>
        public void CrearActivida_aAll(string nombre,string desc,int codigo,string profesor,string titulacion){

            string comando = "INSERT INTO [Actividad_a](profesor,codigo,titulacion) VALUES('" + profesor + "', '" + codigo +  "', '" + titulacion + "')";
            SqlConnection c = null;
            SqlCommand comandoTBD;
            try
            {
                c = new SqlConnection(conexionTBD);
               
                CADActividad ca =new CADActividad();
                ca.CrearActividadAll(nombre, desc, codigo);
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
        //Método para insertar sin campos obligatorios
        public void CrearActividadaBasic(string nombre, int codigo,string titu)
        {

            string comando = "INSERT INTO [Actividad_a](codigo,titulacion) VALUES('" + codigo + "', '" + titu + "')";
            SqlConnection c = null;
            SqlCommand comandoTBD;
            try
            {
                c = new SqlConnection(conexionTBD);
                CADActividad ca = new CADActividad();
                ca.CrearActividadBasic(nombre, codigo);
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
        /// Borra una actividad especificando su codigo
        /// </summary>
        /// <param name="codigo"></param>
        public void BorrarActividad_a(int codigo) {

            SqlConnection c = null;
            string comand = "DELETE FROM [Actividad_a] WHERE codigo= '" + codigo + "'";
            try
            {

                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comand, c);
                cmd.ExecuteNonQuery();
                CADActividad ca = new CADActividad();
                ca.BorrarActividad(codigo);
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
        /// Modifica una actividad
        /// </summary>
        /// <param name="profesor"></param>
        /// <param name="cod"></param>
        public void ModificaActividad_a(string profesor, int cod)
        {
            string comando = "UPDATE [Actividad_a] SET profesor = '" + profesor + "' WHERE codigo = '" + cod + "'";
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
        /// Devuelve una lista de actividades de una cierta titulación y curso
        /// </summary>
        /// <param name="titu"></param>
        /// <param name="curso"></param>
        /// <returns></returns>
        public DataSet GetActividad_tc(string titu, int curso)
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select * from [Actividad_a] where titulacion='"+titu+"' and curso='"+curso+"'";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listAct = new DataSet();
                sqlAdaptador.Fill(listAct);
                return listAct;

            }
            catch (SqlException)
            {
                throw;
               //return null;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
        /// <summary>
        /// Devuelve una lista de actividades de una cierta titulación
        /// </summary>
        /// <param name="titu"></param>
        /// <returns></returns>
        public DataSet GetActividad_ti(string titu)
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select * from [Actividad_a] where titulacion='" + titu + "'";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listAct = new DataSet();
                sqlAdaptador.Fill(listAct);
                return listAct;

            }
            catch (SqlException)
            {
                throw;
                //return null;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
        /// <summary>
        /// Devuelve los datos de una determinada actividad académica
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public DataSet GetDatosActividad_a(int cod)
        {
            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Actividad_a] where  codigo='"+cod+"'";
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
                throw;
               //return null;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
        /// <summary>
        /// Devuelve todas las actividades académicas de la BD
        /// </summary>
        /// <returns></returns>
        public DataSet GetActividades_a()
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select * from [Actividad_a]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listAct = new DataSet();
                sqlAdaptador.Fill(listAct);
                return listAct;

            }
            catch (SqlException)
            {
                throw;
                //return null;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }

        /// <summary>
        /// Devuelve el único código generado
        /// </summary>
        /// <returns></returns>
        public DataSet LastCode()
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select max(codigo) from [Actividad_a]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listAct = new DataSet();
                sqlAdaptador.Fill(listAct);
                return listAct;
            }
            catch (SqlException)
            {
                throw;
               //return null;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }

    }
}

