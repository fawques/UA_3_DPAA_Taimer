using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using CAD;

namespace Taimer
{
    public class Comentario {

        #region PARTE PRIVADA

        /// <summary>
        /// Identificador del comentario
        /// </summary>
        private int id;
 
        /// <summary>
        /// Texto del comentario
        /// </summary>
        private string texto;                       

        /// <summary>
        /// Actividad académica de la que se realiza el comentario
        /// </summary>
        private Actividad_a actividadAcademica;       

        /// <summary>
        /// Usuario que realiza el comentario
        /// </summary>
        private User usuario;                        
        
        /// <summary>
        /// Fecha que se realiza el comentario
        /// </summary>
        private DateTime fecha;
         
        #endregion

        #region  PARTE PÚBLICA

        /// <summary>
        /// Constructor completo, con todos los atributos como parámetros
        /// </summary>
        /// <param name="id_"></param>
        /// <param name="mens_"></param>
        /// <param name="acta_"></param>
        /// <param name="usu_"></param>
        /// <param name="fecha_"></param>
        public Comentario(int id_, string texto_, Actividad_a acta_, User usu_,DateTime fecha_) {
            id = id_;
            texto = texto_;
            actividadAcademica = acta_;
            usuario = usu_;
            fecha = fecha_;
        }

        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="c"></param>
        public Comentario(Comentario c) {
            id = c.id;
            texto = c.texto;
            actividadAcademica = c.actividadAcademica;
            usuario = c.usuario;
            fecha = c.fecha;
        }

        /// <summary>
        /// Modificar/obtener identificador
        /// </summary>
        
        public int ID {
            get { return id; }
            set { id = value; }
        }


        /// <summary>
        /// Modificar/obtener el texto de un comentario
        /// </summary>
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }


        /// <summary>
        /// Modificar/obtener código de actividad académica
        /// </summary>
        public Actividad_a ActividadAcademica
        {
            get { return actividadAcademica; }
            set { actividadAcademica = value; }
        }


        /// <summary>
        /// Modificar/obtener usuario
        /// </summary>
        public User Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

       /// <summary>
       /// Modificar/obtener la fecha
       /// </summary>
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        /// <summary>
        /// Asigna la fecha de la clase a las actuales
        /// </summary>
        public void SetFechaHora()
        {
            fecha = DateTime.Now;

        }

        /// <summary>
        /// Creamos un string con un formato adecuado de la fecha para mostrarla
        /// </summary>
        /// <returns>string con la fecha en el formato adecuado</returns>
        public string FechaToString()
        {
            string fecha_s;
            string dia;
            string hora;

            dia=fecha.ToString("dd/MM/yyyy");
            hora=fecha.ToShortTimeString();
            fecha_s = dia + " " + hora;

            return fecha_s;
        }

        //FUNCIONES DE LOS CAD
        public void Agregar() {
            CADComentario mens = new CADComentario();
            mens.CrearCommentBasic(texto, actividadAcademica.Codigo, usuario.DNI, fecha);
        }

        public void Borrar() {
            CADComentario mens = new CADComentario();
            mens.BorrarComment(id);
        }

        public void Modificar() {
            CADComentario mens = new CADComentario();
            mens.ModificaComment(id,texto, actividadAcademica.Codigo, usuario.DNI, fecha);
        }

        public static List<Comentario> ComentariosToList(DataSet data) {
            if (data != null) {
                List<Comentario> list = new List<Comentario>();

                CADUser user = new CADUser();
                CADActividad_a actividadA = new CADActividad_a();
                User usuario;
                
                DateTime date;
                int id;
                string text = "";
                Actividad_a actividad;

                DataRowCollection rows = data.Tables[0].Rows;

                for (int i = 0; i < rows.Count; i++) {
                    id = (int)rows[i].ItemArray[0];
                    text = rows[i].ItemArray[1].ToString();
                    actividad = Actividad_a.Actividad_aToObject(actividadA.GetDatosActividad_a((int)rows[i].ItemArray[2]));
                    usuario = User.UserToObject(user.GetDatosUser(rows[i].ItemArray[3].ToString()));
                    date = (DateTime)rows[i].ItemArray[4];

                    Comentario nuevo = new Comentario(id, text,actividad,usuario,date);
                    list.Add(nuevo);

                }
                return list;
            }
            return null; 
        }

        public static Comentario ComentarioToObject(DataSet data) {
            if (data != null) {

                CADUser user = new CADUser();
                CADActividad_a actividadA = new CADActividad_a();
                Comentario com;
                int id;
                string text;
                Actividad_a act;
                User usr;
                DateTime dat;

                DataRowCollection rows = data.Tables[0].Rows;

                if (rows.Count != 0) {
                    id = (int)rows[0].ItemArray[0];
                    text = rows[0].ItemArray[1].ToString();
                    act = Actividad_a.Actividad_aToObject(actividadA.GetDatosActividad_a((int)rows[0].ItemArray[2]));
                    usr = User.UserToObject(user.GetDatosUser(rows[0].ItemArray[3].ToString()));
                    dat = (DateTime)rows[0].ItemArray[4];

                    com = new Comentario(id, text, act, usr, dat);
                    return com;
                }


                
            }
            return null;
        }

        #endregion
    }
}
