using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        private string mensaje;                        

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

        // Constructor
        public Comentario(int id_, string mens_, Actividad_a acta_, User usu_,DateTime fecha_) {
            id = id_;
            mensaje = mens_;
            actividadAcademica = acta_;
            usuario = usu_;
            fecha = fecha_;
        }

        // Constructor de copia
        public Comentario(Comentario c) {
            id = c.id;
            mensaje = c.mensaje;
            actividadAcademica = c.actividadAcademica;
            usuario = c.usuario;
        }


        // Ajustar/obtener identificador
        public int ID {
            get { return id; }
            set { id = value; }
        }

        
        // Ajustar/obtener comentario (mensaje)
        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }


        // Ajustar/obtener código de actividad académica
        public Actividad_a ActividadAcademica
        {
            get { return actividadAcademica; }
            set { actividadAcademica = value; }
        }


        // Ajustar/obtener usuario
        public User Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

       

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
        public string Fecha_String()
        {
            string fecha_s;
            string dia;
            string hora;

            dia=fecha.ToString("dd/MM/yyyy");
            hora=fecha.ToShortTimeString();
            fecha_s = dia + " " + hora;
            return fecha_s;
        }
        #endregion
    }
}
