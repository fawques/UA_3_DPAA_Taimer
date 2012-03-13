using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class Actividad_p : Actividad {

        #region PARTE PRIVADA
        // (Nombre, descripción y código vienen de la clase Actividad)

        private string responsable;
        private List<Turno> turnos = new List<Turno>();

        #endregion

        #region PARTE PUBLICA

        // Constructor básico (sin lista de turnos)
        public Actividad_p(string nom_, string desc_, int cod_, string responsable_)
            : base(nom_, desc_, cod_) {
            responsable = responsable_;
        }


        // Constructor avanzado (con lista de turnos)
        public Actividad_p(string nom_, string desc_, int cod_, string responsable_, List<Turno> turnos_)
            : base(nom_, desc_, cod_) {

            responsable = responsable_;
            turnos = turnos_;
        }

        // Constructor de copia
        public Actividad_p(Actividad_p act)
            : base(act) {
            responsable = act.responsable;
            turnos = act.turnos;    
        }

        // Cambiar/obtener responsable
        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }


        // Añadir turno
        public void AddTurno(Turno turno) {
            turnos.Add(turno);
        }

        //Cambiar/obtener turnos
        public List<Turno> Turnos {
            set { turnos = value; }
            get { return turnos; }
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
