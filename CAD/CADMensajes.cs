using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections;

namespace CAD {

    public class CADMensajes {
        private static string conexionTBD;

        public CADMensajes() {
            conexionTBD = Conection.Conect.ConectionString;
        }

        public void CrearMensaje(string codEmisor, string codReceptor, string texto, DateTime date, bool leido) {
            string comando = "INSERT INTO [Mensajes](emisor,receptor,texto,fecha,leido) VALUES('" + codEmisor + "', '" 
                + codReceptor + "', '" + texto + "', '" + date.ToString("yyyy-MM-dd HH:mm:ss")+"','" + leido + "')";
            SqlConnection c = null;
            SqlCommand comandoTBD;

            try {
                c = new SqlConnection(conexionTBD);
                c.Open();
                comandoTBD = new SqlCommand(comando, c);
                comandoTBD.CommandType = CommandType.Text;
                comandoTBD.ExecuteNonQuery();
            } catch (SqlException) {
                throw;
            } finally {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public void BorrarMensaje(int id) {
            SqlConnection c = null;
            string comando = "DELETE FROM [Mensajes] WHERE id= '" + id + "'";

            CADActividad_p actp = new CADActividad_p();
            CADActividad act = new CADActividad();

            try {
                c = new SqlConnection(conexionTBD);
                SqlCommand cmd = new SqlCommand(comando, c);
                c.Open();
                cmd.CommandType = CommandType.Text;//Eso hace falta? TODO
                cmd.ExecuteNonQuery();
            } catch (SqlException) {
                throw;
            } finally {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public DataSet getMensajes() {
            SqlConnection con = null;
            DataSet listComments = null;
            string comando = "Select * from [Mensajes]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listComments = new DataSet();
                sqlAdaptador.Fill(listComments);
                return listComments;

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

        public DataSet getConversacion(string user1, string user2) {
            SqlConnection con = null;
            DataSet listComments = null;
            string comando = "Select * from [Mensajes] WHERE (emisor='"+user1+"' or emisor='"+user2+"') and (receptor='"+
                user1 + "' or receptor = '" + user2+"') ORDER BY fecha";
            try {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listComments = new DataSet();
                sqlAdaptador.Fill(listComments);
                return listComments;

            } catch (SqlException) {
                // Captura la condición general y la reenvía.
                throw;
            } finally {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public int getNumNotRead(string codUser) {

            SqlConnection con = null;
            string comando = "SELECT COUNT(*) FROM [Mensajes] WHERE receptor ='" + codUser + "' AND leido='False'";
            try {
                con = new SqlConnection(conexionTBD);
                con.Open();
                SqlCommand sqlCmnd = new SqlCommand(comando, con);

                return (int)sqlCmnd.ExecuteScalar();

            } catch (SqlException) {
                // Captura la condición general y la reenvía.
                throw;
            } finally {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public void ModificarMensaje(int id, string codEmisor, string codReceptor, string texto, DateTime date, bool leido) {
            string comando = "UPDATE [Mensajes] SET emisor = '" + codEmisor + "',  receptor = '" + codReceptor +
                "', texto = '" + texto + "', fecha = '" + date.ToString("yyyy-MM-dd HH:mm:ss") + "', leido = '" + leido + "' WHERE id = '" + id + "'";
            SqlConnection c = null;
            SqlCommand comandoTBD;

            try {
                c = new SqlConnection(conexionTBD);
                comandoTBD = new SqlCommand(comando, c);
                c.Open();
                comandoTBD.CommandType = CommandType.Text;
                comandoTBD.ExecuteNonQuery();

            } catch (SqlException) {
                throw;
            } finally {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }
    }
}
