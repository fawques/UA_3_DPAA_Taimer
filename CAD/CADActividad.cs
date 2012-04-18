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
    public class CADActividad
    {

        private static string conexionTBD;

         public CADActividad ()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio

        }
        //Método para crear una Actividad con todos sus parametros
        public void CrearActividadAll(string nombre,string desc,int codigo){

            string comando = "INSERT INTO [Actividad](codigo,nombre,descripcion) VALUES('" + codigo + "', '" + nombre + "', '" + desc + "')";
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
        //Método para insertar sin campos obligatorios
        public void CrearActividadBasic(string nombre, int codigo)
        {

            string comando = "INSERT INTO [Actividad](codigo,nombre) VALUES('" + codigo + "', '" + nombre + "')";
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

        //Borrar una actividad
        public void BorrarActividad(int codigo) {

            SqlConnection c = null;
            string comand = "DELETE FROM [Actividad] WHERE codigo= '" + codigo + "'";
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
        //Modificar una actividad
        public void ModificaActividad(string nombre,string desc,int cod,int codTurno) 
        {
            string comando = "UPDATE [Actividad] SET nombre = '" + nombre + "', descripcion = '" + desc +"', codigoTurno = '" + codTurno + "' WHERE codigo = '" + cod + "'";
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
        //Obtenemos los datos de un Actividad según su id
        public DataSet GetDatosActividad(int cod)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Actividad] where  codigo='"+cod+"'";
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
        //Devuelve la lista de Actividades
        public DataSet GetActividades()
        {
            SqlConnection con = null;
            DataSet listAct = null;
            string comando = "Select * from [Actividad]";
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
