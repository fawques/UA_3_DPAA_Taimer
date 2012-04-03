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
    public class CADUser
    {
        private static string conexionTBD;
        
        public CADUser()
        {
            conexionTBD = Conection.Conect.ConectionString;
            // Adquiere la cadena de conexión desde un único sitio

        }
        //Método para crear un nuevo usu
        public void CrearUserBasic(string dni, string nombre, string email, string password)
        {
            string comando = "INSERT INTO [User](dni,nombre,email,password) VALUES('" + dni + "', '" + nombre + "', '" + email + "', '" + password + "')";
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
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public void CrearUserAll(string dni, string nombre, string email, string password, int curso, string tit,int codH)
        {
            string comando = "INSERT INTO [User] VALUES('" + dni + "', '" + nombre + "', '" + email + "', '" + password + "','"+ curso+"','"+tit+"','"+codH+"')";
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
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public void BorrarUser(string id)
        {
            SqlConnection c = null;
            string comando = "DELETE FROM [User] WHERE dni= '" + id + "'";
            CADActividad_p actp = new CADActividad_p();
            CADActividad act = new CADActividad();
            List<int> codes = DataSetToList(actp.GetActividadesPByUser(id));
                
            try
            {
                c = new SqlConnection(conexionTBD);
                c.Open();
                SqlCommand cmd = new SqlCommand(comando, c);
                cmd.ExecuteNonQuery();
                foreach(int i in codes)
                {
                    act.BorrarActividad(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        //Obtenemos un dataset con los datos de los usuarios
        public DataSet GetUsers()
        {

            SqlConnection con = null;
            DataSet listUsers = null;
            string comando = "Select * from [User]";
            try
            {
                con = new SqlConnection(conexionTBD);
                SqlDataAdapter sqlAdaptador = new SqlDataAdapter(comando, con);
                listUsers = new DataSet();
                sqlAdaptador.Fill(listUsers);
                return listUsers;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return null;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
         //Obtenemos los datos de un usuario según su dni
        public DataSet GetDatosUser(string dni)
        {

            SqlConnection con = null;
            DataSet datos = null;
            string comando = "Select * from [User] where dni='"+dni+"'";
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
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return null;
            }
            finally
            {
                if (con != null) con.Close(); // Se asegura de cerrar la conexión.
            }
        }
        //Actualizar datos de un Usuario cuyo dni sea el que pasan como parámetro
        public void ModificaUser(string dni, string nombre, string email, string password,string tit)
        {
            string comando = "UPDATE [User] SET nombre = '" + nombre + "', email = '" + email + "', password = '" + password + "', titulacion = '" +tit+ "' WHERE dni = '" + dni + "'";
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
                MessageBox.Show(ex.Message, "Error en la acción", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                if (c != null) c.Close(); // Se asegura de cerrar la conexión.
            }
        }

        public List<int> DataSetToList(DataSet data)
        {
            DataRowCollection rows=data.Tables[0].Rows;
            List<int> list = new List<int>();
            for (int i = 0; i < rows.Count; i++)
            {
                list.Add((int)rows[i].ItemArray[0]);
            }
            return list;
        }
    }
}
