using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class Actividad_p : Actividad {

        #region PARTE PRIVADA
        // (Nombre, descripción y código vienen de la clase Actividad)

        private List<Turno> turnos = new List<Turno>();
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
            : base(nom_, desc_, cod_) {

            usuario = usu_;
            turnos = turnos_;
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


        //Cambiar/obtener turnos
        public List<Turno> Turnos
        {
            set { turnos = value; }
            get { return turnos; }
        }


        // Añadir turno
        public void AddTurno(Turno turno) {
            turnos.Add(turno);
        }


        // Borrar turno
        public bool BorraTurno(Turno turno)
        {
                    return Turnos.Remove(turno);
        }


        // Borrar turno (a partir de su código, si se encuentra)
        public bool BorraTurno(int codigobuscado) {
            foreach (Turno t in turnos) {
                if (t.Codigo == codigobuscado)
                    return Turnos.Remove(t);
            }
            return false;
        }


        #endregion
    }
}
