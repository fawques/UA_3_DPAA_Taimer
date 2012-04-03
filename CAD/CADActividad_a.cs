using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections;


namespace CAD {

    public class CADActividad_a
    {
        private static string conexionTBD;

         public CADActividad_a ()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio

        }
        //Método para crear una Actividad con todos sus parametros
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
            catch (SqlException ex)
            {
                throw ex;
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
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }

        }

        //Borrar una actividad
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
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }

        }
        
        //Modificar una actividad
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
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }


        }
        //Obtenemos los datos de un Actividad según su id
        public DataSet GetDatosActividad_a(string user,int cod)
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
        //Devuelve la lista de Actividades
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

