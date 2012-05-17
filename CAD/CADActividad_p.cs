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
    public class CADActividad_p
    {
        private static string conexionTBD;

         public CADActividad_p ()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio

        }
        /// <summary>
        /// Insertar una actividad personal en la BD
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="desc"></param>
        /// <param name="codigo"></param>
        /// <param name="idUser"></param>
        public void CrearActivida_pAll(string nombre,string desc,int codigo,string idUser){

            string comando = "INSERT INTO [Actividad_p](autor,codigo) VALUES('" + idUser + "', '" + codigo + "')";
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
        /// <summary>
        /// Inserta una actividad en la BD pero solo los atributos obligatorios
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="codigo"></param>
        /// <param name="idUser"></param>
        public void CrearActividadpBasic(string nombre, int codigo, string idUser)
        {

            string comando = "INSERT INTO [Actividad_p](autor,codigo) VALUES('" + idUser + "', '" + codigo + "')";
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
        /// Borra una actividad personal
        /// </summary>
        /// <param name="codigo"></param>
        public void BorrarActividad_p(int codigo) {

            SqlConnection c = null;
            string comand = "DELETE FROM [Actividad_p] WHERE codigo= '" + codigo + "'";
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

        public void ModificaActividad_p(string Nombre, string Descripcion, int cod, int Codigoturno, string autor)
        {
            string comando = "UPDATE [Actividad_p] SET autor = '" + autor +  "' WHERE codigo = " + cod;
            string comando2 = "UPDATE [Actividad] SET nombre = '" + Nombre + "', descripcion = '" + Descripcion + "', codigoturno = '" + Codigoturno + "' WHERE codigo = " + cod;
            SqlConnection c = null;
            SqlCommand comandoTBD;

            try
            {
                c = new SqlConnection(conexionTBD);
                comandoTBD = new SqlCommand(comando2, c);
                c.Open();
                comandoTBD.CommandType = CommandType.Text;
                comandoTBD.ExecuteNonQuery();
                comandoTBD = new SqlCommand(comando, c);
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
        /// Coge los datos de una actividad concreta
        /// </summary>
        /// <param name="cod"></param>
        /// <returns></returns>
        public DataSet GetDatosActividad_p(int cod)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Actividad_p] where codigo='"+cod+"'";
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
        /// Devuelve toda la lista de actividades personales
        /// </summary>
        /// <returns></returns>
        public DataSet GetActividades_p()
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select * from [Actividad_p]";
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
        /// Devuelve el código de la última actividad generada
        /// </summary>
        /// <returns></returns>
        public DataSet LastCode()
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select min(codigo) from [Actividad_p]";
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
        ///  Devuelve los códigos de las actividades personales de un usuario concreto
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public DataSet GetCodesByUser(string dni)
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select codigo from [Actividad_p] where autor='" + dni +"'";
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
        /// Convierte un DataSet (que será una lista de códigos de actividades) en una lista de enteros
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<int> CodesToList(DataSet data)
        {
            DataRowCollection rows = data.Tables[0].Rows;
            List<int> list = new List<int>();

            for (int i = 0; i < rows.Count; i++)
            {
                list.Add((int)rows[i].ItemArray[0]);
            }
            return list;
        }

        /// <summary>
        /// Obtiene las actividades personales creadas por un usuario
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public DataSet GetActividades_pByUser(string dni)
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select * from [Actividad_p] where autor='" + dni + "'";
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
