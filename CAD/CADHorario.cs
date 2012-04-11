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
    public class CADHorario
    {
        private static string conexionTBD;
        
        public CADHorario()
        {
            // Adquiere la cadena de conexión desde un único sitio
            conexionTBD = Conection.Conect.ConectionString;
        }
        /// <summary>
        /// Creamos un nuevo horario en BD
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tit"></param>
        /// <param name="user"></param>
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
        /// Borramos un horario
        /// </summary>
        /// <param name="id"></param>
        public void BorrarHorario(int id,string usuario)
        {
            SqlConnection c = null;
            string comando = "DELETE FROM [Horario] WHERE id= '" + id + "' and usuario='"+usuario+"'";
            try
            {
                
                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comando, c);
                cmd.ExecuteNonQuery();
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
        /// Devolvemos la lista de horarios
        /// </summary>
        /// <returns></returns>
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
        /// Devolvemos los datos de un horario
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataSet GetDatosHorario(int id,string usuario)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Horario] where id='"+id+"' and usuario='"+usuario+"'";
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
        /// Devuelve los horarios de un usuario concreto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public DataSet GetDatosHorarioUser(string  idUser)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Horario] where usuario='"+idUser+"'";
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
        /// Modificamos un horario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tit"></param>
        /// <param name="user"></param>
        public void ModificaHorario(int id, string tit, string user)
        {
            string comando = "UPDATE [Horario] SET id = '" + id + "', titulo = '" + tit + "',  usuario = '" + user + "' WHERE id = '" + id + "' and usuario='"+user+"'";
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
        /// Añadimos los turnos a la tabla Horario_Turno
        /// </summary>
        /// <param name="idho"></param>
        /// <param name="iduser"></param>
        /// <param name="cod_turno"></param>
        /// < param name="cod_ac"></param>
        public void AddTurnoHo(int idho, string iduser, int cod_turno, int cod_ac)
        {
            string comando = "INSERT INTO [Horario_Turno](horarioId,horarioUser,turnoCod,turnoAct) VALUES('" + idho + "', '" + iduser + "', '" + cod_turno + "', '" + cod_ac+"')";
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
        /// Borramos un turno de la tabla Horario_turno
        /// </summary>
        /// <param name="idho"></param>
        /// <param name="iduser"></param>
        /// <param name="cod_turno"></param>
        /// <param name="cod_ac"></param>
        public void BorrarTurnoEspecifico(int idho, string iduser, int cod_turno, int cod_ac)
        {
            string comando = "DELETE FROM [Horario_Turno] WHERE horarioId='" + idho + "' and horarioUser='" + iduser + "' and turnoCod='" + cod_turno + "' and turnoAct='" + cod_ac + "'";
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
                throw ;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }
        /// <summary>
        /// Borramos los turnos de un horario especifico
        /// </summary>
        /// <param name="horarioId"></param>
        /// <param name="user"></param>
        public void BorrarTurnosHo(int horarioId, string user)
        {
            string comando = "DELETE FROM [Horario_Turno] WHERE horarioId='" + horarioId + "' and horarioUser='" + user + "'";
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
        ///Devuelve los codigos de Turno de un Horario
        /// </summary>
        /// <returns></returns>
        public DataSet GetTurnos(int id,string idUser)
        {
            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select turnoCod,turnoAct from [Horario_Turno] where horarioId='" + id + "' and horarioUser='"+idUser+"'";
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
    }
}
