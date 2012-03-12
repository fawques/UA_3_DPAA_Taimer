using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer
{
    public class Comentario
    {
        // PARTE PRIVADA ******************************************************************

        int id;                                 // Clave principal
        string mensaje;                      // Comentario en sí (mensaje).
        string codigoActividadAcademica;        // Un comentario es contenido por (1,1) actividades académicas
        string usuario;                         // Un comentario es escrito por (1,1) usuarios


        // PARTE PÚBLICA ******************************************************************
        
        // Constructor
        public Comentario(int id_, string mens_, string actcod_, string usu_) {
            id = id_;
            mensaje = mens_;
            codigoActividadAcademica = actcod_;
            usuario = usu_;
        }


        // Ajustar/obtener identificador
        public int Id
        {
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
        public string CodigoActividadAcademica
        {
            get { return codigoActividadAcademica; }
            set { codigoActividadAcademica = value; }
        }


        // Ajustar/obtener usuario
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
    }
}
