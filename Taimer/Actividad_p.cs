using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    class Actividad_p : Actividad {

        // PARTE PRIVADA ******************************************************************

        // (Nombre, descripción y código vienen de la clase Actividad)

        private string responsable;

        private List<string> turnos = new List<string>();



        // PARTE PÚBLICA ******************************************************************

        // Constructor básico (sin lista de turnos)
        public Actividad_p(string nom_, string desc_, int cod_, string responsable_)
            : base(nom_, desc_, cod_)
        {
            responsable = responsable_;
        }


        // Constructor avanzado (con lista de turnos)
        public Actividad_p(string nom_, string desc_, int cod_, string responsable_, List<string> turnos_)
            : base(nom_, desc_, cod_) {

            responsable = responsable_;
            turnos = turnos_;
        }


        // Cambiar/obtener responsable
        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }


        // Añadir turno
        public void AddTurno(string turno) {
            turnos.Add(turno);
        }


        // Borrar turno (a partir de su código, si se encuentra)
        public bool BorraTurno(string codigobuscado)
        {
            foreach (string tur in turnos)
            {
                if (tur == codigobuscado)
                {
                    turnos.Remove(tur);
                    return true;
                }
            }

            return false;
        }
    }
}
