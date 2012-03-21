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
    public class CADTurno
    {
        private static string conexionTBD;

        public CADTurno()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio
        }

        //Método para crear un Turno con todos los parametros
        public void CrearTurno(int codigo, string horai, string horaf, char dia, string ubi, int cod_a, string cod_user)
        {
            string comando = "INSERT INTO [Turno](codigo,horaInicio,horaFin,dia,ubicacion,pertenece_aAct,pertenece_aUser) VALUES('" + codigo + "', '" + horai + "', '" + horaf + "', '" +dia + "', '" + ubi + "', '" + cod_a  + "', '" + cod_user+ "')";
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
        //Borra Turno con su id
        public void BorrarTurno(int codigo)
        {
            SqlConnection c = null;
            string comand = "DELETE FROM [Turno] WHERE codigo= '" + codigo + "'";
            try
            {

                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comand, c);
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

        //Obtenemos los datos de un Turno según su id
        public DataSet GetDatosActividad(string user,int cod)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Turno] where codigo="+cod;
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
        //Modificar el Turno dia horai horaf ubicacion
        public void ModificarTurno(char dia, string horai, string horaf, string ubi,int cod)
        {
            string comando = "UPDATE [Turno] SET dia = '" + dia + "', horaInicio = '" + horai +"', horaFin = '" +horaf+"', ubicacion = '"+ubi+"' WHERE codigo = '" + cod + "'";
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
        //Devuelve la lista de Turnos
        public DataSet GetTurnos()
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select * from [Turno]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listAct = new DataSet();
                sqlAdaptador.Fill(listAct);
                return listAct;

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
        
    }
}
