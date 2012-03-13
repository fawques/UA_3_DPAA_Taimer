using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer
{
    public class Comentario {

        #region PARTE PRIVADA

        int id;                                 // Clave principal
        string mensaje;                         // Comentario en sí (mensaje).
        Actividad_a actividadAcademica;        // Un comentario es contenido por (1,1) actividades académicas
        User usuario;                         // Un comentario es escrito por (1,1) usuarios

        #endregion

        #region  PARTE PÚBLICA

        // Constructor
        public Comentario(int id_, string mens_, Actividad_a actcod_, User usu_) {
            id = id_;
            mensaje = mens_;
            actividadAcademica = actcod_;
            usuario = usu_;
        }

        //Constructor de copia
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
        #endregion
    }
}
