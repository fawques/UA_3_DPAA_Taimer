﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections;


namespace CAD
{
    public class CADAdmin
    {
        private static string conexionTBD;
        
        public CADAdmin()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio

        }
        /// <summary>
        /// Creamos un nuevo admin
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void CrearAdminBasic(string dni, string nombre, string email, string password)
        {
            string comando = "INSERT INTO [Admin](dni,nombre,email,password) VALUES('" + dni + "', '" + nombre + "', '" + email + "', '" + password + "')";
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
        /// Borramos un admin
        /// </summary>
        /// <param name="id"></param>
        public void BorrarAdmin(string id)
        {
            SqlConnection c = null;
            string comando = "DELETE FROM [Admin] WHERE dni= '" + id + "'";

            try
            {
                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comando, c);
                cmd.ExecuteNonQuery();
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
        /// Obtenemos a todos los admin de la base de datos
        /// </summary>
        /// <returns></returns>
        public DataSet GetAdmins()
        {

            SqlConnection con = null;
            DataSet listAdmins = null;
            string comando = "Select * from [Admin]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listAdmins = new DataSet();
                sqlAdaptador.Fill(listAdmins);
                return listAdmins;

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
        /// Obtenemos los datos de un admin concreto
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public DataSet GetDatosAdmin(string dni)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Admin] where dni='"+dni+"'";
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
        /// Obtiene los datos de un admin a partir de un email y un password (datos de login)
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public DataSet GetDatosAdmin(string email, string pass)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Admin] where email='" + email + "' and password='" + pass + "'";
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
        /// Modifica un admin
        /// </summary>
        /// <param name="dni"></param>
        /// <param name="nombre"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public void ModificaAdmin(string dni, string nombre, string email, string password)
        {
            string comando = "UPDATE [Admin] SET dni = '" + dni + "', nombre = '" + nombre + "', email = '" + email + "', password = '" + password + "' WHERE dni = '" + dni + "'";
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
        /// Lanza una excepción si el login es incorrecto.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public void Login(string email, string pass)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [Admin] where email='" + email + "' and password='" + pass + "'";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                datos = new DataSet();
                sqlAdaptador.Fill(datos);
                if (datos.Tables[0].Rows.Count == 0)
                    throw new InvalidDataException("Usuario o contraseña incorrectos");

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
