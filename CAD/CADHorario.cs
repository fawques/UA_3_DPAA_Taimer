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
    class CADHorario
    {
        private static string conexionTBD;
        private static SqlConnection cnBD;
        public CADHorario()
        {
            // Adquiere la cadena de conexión desde un único sitio
            conexionTBD = Conection.Conect.ConectionString;
        }
        //Método para crear un nuevo usu
        public void CrearHorarioBasic(int id, string tit, string user)
        {
            string comando = "INSERT INTO [Horario](id,titulo,usuario) VALUES('" + id + "', '" + tit + "', '" + user + "')";
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

        public void BorrarHorario(int id)
        {
            SqlConnection c = null;
            string comando = "DELETE FROM [Horario] WHERE id= '" + id + "'";

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
        public DataSet GetHorarios()
        {

            SqlConnection con = null;
            DataSet listComments = null;
            string comando = "Select * from [Horario]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listComments = new DataSet();
                sqlAdaptador.Fill(listComments);
                return listComments;

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
        public DataSet GetDatosHorario(int id)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Horario] where id='"+id+"'";
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
        public void ModificaComment(int id, string tit, string user)
        {
            string comando = "UPDATE [Horario] SET id = '" + id + "', titulo = '" + tit + "',  usuario = '" + user + "' WHERE id = '" + id + "'";
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
