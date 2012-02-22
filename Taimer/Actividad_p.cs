using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    class Actividad_p : Actividad {

        //PARTE PRIVADA
        
        private string responsable;
        private ArrayList turnos = new ArrayList();

        //PARTE PUBLICA

        //NO LO PONGO POR SEGURIDAD DEL LOS ARRAYLIST
        /*//Constructor
        public Actividad_p(string nom_, string desc_, int cod_, string responsable_, ArrayList turnos_)
            : base(nom_, desc_, cod_) {

            responsable = responsable_;
            turnos = turnos_;         
        }*/

        //Constructor
        public Actividad_p(string nom_, string desc_, int cod_, string responsable_)
            : base(nom_, desc_, cod_) {

            responsable = responsable_;
        }

        //Cambiar responsable
        public void setResponsable(string responsable_) {
            responsable = responsable_;
        }

        //Añadir turno
        public void AddTurno(Turno turno) {
            turnos.Add(turno);
        }

        //Obtener responsable
        public string getResponsable() {
            return responsable;
        }

        //Obtener turnos
        public ArrayList getTurnos() {
            return turnos;
        }
    }
}
