using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAD;

namespace Taimer
{
    public class Mensaje
    {
        #region PARTE PRIVADA

        /// <summary>
        /// Identificador del mensaje
        /// </summary>
        private int id;                 
        
        /// <summary>
        /// //Texto del mensaje
        /// </summary>
        private string texto;         

        /// <summary>
        /// Usuario que envía el mensaje
        /// </summary>
        private User emisor;            
        
        /// <summary>
        /// Usuario destinatario
        /// </summary>
        private User receptor;          

        /// <summary>
        /// Fecha en la que se envía el mensaje
        /// </summary>
        DateTime fecha;

        /// <summary>
        /// Booleano que indica si un mensaje ha sido leído o no
        /// </summary>
        bool leido;

        #endregion

        #region PARTE PÚBLICA

        /// <summary>
        /// Constructor con todos los atributos como parámetro
        /// </summary>
        /// <param name="id_"></param>
        /// <param name="mensaje_"></param>
        /// <param name="emisor_"></param>
        /// <param name="receptor_"></param>
        /// <param name="hora_"></param>
        /// <param name="fecha_"></param>
        public Mensaje(int id_, string texto_, User emisor_, User receptor_, DateTime fecha_)
        {
            id = id_;
            texto = texto_;
            emisor = emisor_;
            receptor = receptor_;            
            fecha = fecha_;
            leido = false;
        }

        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="msj"></param>
        public Mensaje(Mensaje msj)
        {
            id = msj.id;
            texto = msj.texto;
            emisor = msj.emisor;
            receptor = msj.receptor;
            fecha = msj.fecha;
            leido = msj.leido;
        }

        /// <summary>
        /// Modifica/obtiene el id del mensaje
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Modifica/obtiene el texto del mensaje
        /// </summary>
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        /// <summary>
        /// Modifica/obtiene el usuario emisor del mensaje
        /// </summary>
        public User Emisor
        {
            get { return emisor; }
            set { emisor = value; }
        }

        /// <summary>
        /// Modifica/obtiene el usuario receptor del mensaje
        /// </summary>
        public User Receptor
        {
            get { return receptor; }
            set { receptor = value; }
        }

        /// <summary>
        /// Asigna la fecha y hora de un mensaje a las actuales
        /// </summary>
        public void SetFechaHora()
        {
            fecha = DateTime.Today;            
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

            dia = fecha.ToString("dd/MM/yyyy");
            hora = fecha.ToShortTimeString();
            fecha_s = dia + " " + hora;

            return fecha_s;
        }


       /*Funciones de borrado e insertado en la BD, comentadas para que no de error (hasta que CADMensajes sea pública)
        /// <summary>
        /// Añade el mensaje a la base de datos
        /// </summary>
        public void Agregar()
        {
            CADMensajes mens = new CADMensajes();
            mens.CrearMensaje(emisor.DNI, receptor.DNI, texto, fecha, leido);
        }

        /// <summary>
        /// Elimina el mensaje de la base de datos
        /// </summary>
        public void Borrar()
        {
            CADMensajes mens = new CADMensajes();
            mens.BorrarMensaje(id);
        }*/

        #endregion
   } 
}
