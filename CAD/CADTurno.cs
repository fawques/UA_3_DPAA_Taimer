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
    public class CADTurno
    {
        private static string conexionTBD;

        public CADTurno()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio
        }

       /// <summary>
        ///  Método para crear un Turno con todos los parametros
       /// </summary>
       /// <param name="codigo"></param>
       /// <param name="horai"></param>
       /// <param name="horaf"></param>
       /// <param name="dia"></param>
       /// <param name="ubi"></param>
       /// <param name="cod_a"></param>
        public void CrearTurno(int codigo, string horai, string horaf, char dia, string ubi, int cod_a)
        {
            string comando = "INSERT INTO [Turno](codigo,horaInicio,horaFin,dia,ubicacion,pertenece_aAct) VALUES('" + codigo + "', '" + horai + "', '" + horaf + "', '" +dia + "', '" + ubi + "', '" + cod_a +"')";
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
        /// Borra Turno con su id
       /// </summary>
       /// <param name="codigo"></param>
       /// <param name="cod_a"></param>
        public void BorrarTurno(int codigo,int cod_a)
        {
            SqlConnection c = null;
            string comand = "DELETE FROM [Turno] WHERE codigo= '" + codigo + "' and pertenece_aAct= '"+ cod_a + "'";
            try
            {
                
                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comand, c);
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
        /// Obtenemos los datos de un Turno según su id
       /// </summary>
       /// <param name="cod"></param>
       /// <param name="act"></param>
       /// <returns></returns>
        public DataSet GetDatosTurno(int cod,int act)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Turno] where codigo='"+cod+"' and pertenece_aAct='"+act+"'";
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
        /// Modificar el Turno dia horai horaf ubicacion
        /// </summary>
        /// <param name="dia"></param>
        /// <param name="horai"></param>
        /// <param name="horaf"></param>
        /// <param name="ubi"></param>
        /// <param name="cod"></param>
        public void ModificarTurno(char dia, string horai, string horaf, string ubi,int cod,int act)
        {
            string comando = "UPDATE [Turno] SET dia = '" + dia + "', horaInicio = '" + horai +"', horaFin = '" +horaf+"', ubicacion = '"+ubi+"' WHERE codigo = '" + cod + "' and pertenece_aAct='"+act+"'";
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
        /// Devuelve la lista de turnos de una actividad
        /// </summary>
        /// <returns></returns>
        public DataSet GetTurnosByAct(int act)
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select * from [Turno] where pertenece_aAct='"+act+"'";
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
                // Captura la condición general y la reenvía.
                throw;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }

        /// <summary>
        /// Obtiene un conjunto de (código turno, código actividad), que serán claves principales de turnos pertenecientes a un determinado horario
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public DataSet GetTurnosByHorario(int id, string user)
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select turnoCod,turnoAct from [Horario_Turno] where horarioId='" + id + "' and horarioUser='" + user + "'";
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
