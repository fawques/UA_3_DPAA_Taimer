using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class Actividad_p : Actividad {

        #region PARTE PRIVADA
        // (Nombre, descripción y código vienen de la clase Actividad)

        private User usuario;                               // Usuario de la actividad personal

        #endregion

        #region PARTE PUBLICA

        // Constructor básico (sin lista de turnos)
        public Actividad_p(string nom_, string desc_, int cod_, User usu_)
            : base(nom_, desc_, cod_) {
                usuario = usu_;
        }


        // Constructor avanzado (con lista de turnos)
        public Actividad_p(string nom_, string desc_, int cod_, string responsable_, List<Turno> turnos_, User usu_)
            : base(nom_, desc_, cod_, turnos_) {

            usuario = usu_;
        }

        // Constructor de copia
        public Actividad_p(Actividad_p act)
            : base(act) {
                usuario = act.usuario;
            turnos = act.turnos;    
        }

        // Cambiar/obtener usuario
        public User Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }





        #endregion
    }
}
