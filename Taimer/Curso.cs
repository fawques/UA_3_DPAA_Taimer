using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    class Curso {

        //PARTE PRIVADA

        private int num;
        ArrayList asig = new ArrayList();

        //PARTE PUBLICA

        //Constructor
        public Curso(int num_) {
            num = num_;
        }

        //Cambiar numero de curso
        public void setNum(int num_) {
            num = num_;
        }

        //Añadir asignatura
        public void AddAsig(Actividad_a act) {
            asig.Add(act);
        }

        //Obtener numero de curso
        public int getNum() {
            return num;
        }

        //Obtener ArrayList de asignaturas
        public ArrayList getAsig() {
            return asig;
        }
    }
}
