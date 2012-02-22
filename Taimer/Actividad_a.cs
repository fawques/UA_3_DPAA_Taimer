using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Taimer {
    class Actividad_a : Actividad {
        
        //PARTE PRIVADA
       
        private int codCoord;
        private ArrayList teoria = new ArrayList();     //será de tipo turno
        private ArrayList practica = new ArrayList();   //será de tipo turno

        //PARTE PUBLICA

        //NO LO PONGO POR SEGURIDAD DEL LOS ARRAYLIST
        /*//Constructor
        public Actividad_a(string nom_, string desc_, int cod_, int codCoord_, ArrayList teoria_, ArrayList practica_) 
            : base(nom_, desc_, cod_) {

            codCoord = codCoord_;
            teoria = teoria_;
            practica = practica_;
        }*/ 

        //Constructor
        public Actividad_a(string nom_, string desc_, int cod_, int codCoord_)
            : base(nom_, desc_, cod_) {

            codCoord = codCoord_;
        }
        
        //Cambia el codigo del coordinador
        public void setCodCoord(int codCoord_) {
            codCoord = codCoord_;
        }

        //Añade un turno de teoria
        public void AddTurnoTeoria(Turno turno) {
            teoria.Add(turno);
        }

        //Añade un turno de practica
        public void AddTurnoPractica(Turno turno) {
            practica.Add(turno);
        }

        //Obtener el codigo del coordinador
        public int getCodCoord() {
            return codCoord;
        }

        //Obtener el ArrayList de teoria
        public ArrayList getTurnosTeoria() {
            return teoria;
        }

        //Obtener el ArrayList de practica
        public ArrayList getTurnosPractica() {
            return practica;
        }

    }
}
