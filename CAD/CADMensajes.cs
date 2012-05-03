using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections;

namespace CAD {

    class CADMensajes {
        private static string conexionTBD;

        public CADMensajes() {
            conexionTBD = Conection.Conect.ConectionString;
        }

        public void CrearMensaje(string codEmisor, string codReceptor, string texto, DateTime date, bool leido) {
            string comando = "INSERT INTO [Mensajes](emisor,receptor,texto,fecha,leido) VALUES('" + codEmisor + "', '" + codReceptor + "', '" + texto + "', '" + date + "','"+ leido +"')";
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

        public int getNumNoRead(int id) {
            return 0;
        }
    }
}
