using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public abstract class Actividad {
        // PARTE PRIVADA

        private string nom;     // Nombre
        private string desc;    // Descripción
        private int cod;        // Código


        //PARTE PUBLICA

        //Constructor
        public Actividad(string nom_, string desc_, int cod_) {
            nom = nom_;
            desc = desc_;
            cod = cod_;
        }

        // Cambiar nombre
        public void setNom(string nom_) {
            nom = nom_;
        }

        // Cambiar descripción
        public void setDesc(string desc_) {
            desc = desc_;
        }

        // Cambiar código
        public void setCod(int cod_) {
            cod = cod_;
        }

        // Devolver nombre
        public string getNom() {
            return nom;
        }

        // Devolver descripción
        public string getDesc() {
            return desc;
        }

        // Devolver código
        public int getCod() {
            return cod;
        }
    }
}
