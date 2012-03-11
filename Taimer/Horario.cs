using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class Horario {
        
        //PARTE PRIVADA

        private string nom;
        private int id;
        private ArrayList[] arrayTurnos = new ArrayList[7];
        

        //PARTE PUBLICA

        //Constructor
        public Horario(string nom_, int id_) {
            nom = nom_;
            id = id_;

            for (int i = 0; i < 7; i++)
            {
                arrayTurnos[i] = new ArrayList();
            }

        }

        //Cambiar el nombre
        public void setNom(string nom_) {
            nom = nom_;
        }

        //Cambiar la id
        public void setId(int id_) {
            id = id_;
        }

        //Añadir turnos
        public void AddTurno(Turno turno) {
            switch (turno.getDia())
            {
                case 'L': arrayTurnos[0].Add(turno);
                    break;
                case 'M': arrayTurnos[1].Add(turno);
                    break;
                case 'X': arrayTurnos[2].Add(turno);
                    break;
                case 'J': arrayTurnos[3].Add(turno);
                    break;
                case 'V': arrayTurnos[4].Add(turno);
                    break;
                case 'S': arrayTurnos[5].Add(turno);
                    break;
                case 'D': arrayTurnos[6].Add(turno);
                    break;
            }
        }

        //Obtener nombre
        public string getNom() {
            return nom;
        }

        //Obtener id
        public int getId() {
            return id;
        }

        //Obtener ArrayList de turnos
        public ArrayList[] getTurnos() {
            return arrayTurnos;
        }

        //Prueba de generar Horarios
        public Horario generarHorario1() {
            Horario probando = new Horario("prueba",1);
            bool correcto = true;

            Actividad_p actP = new Actividad_p("nombre","descripcion",6,"pepito");
            Actividad_p actP2 = new Actividad_p("nombre2", "descripcion2", 7, "pepito2");
            ArrayList arrayP = new ArrayList();
            arrayP.Add(actP);
            arrayP.Add(actP2);

            foreach (Actividad_p personal in arrayP)
            {

                foreach (Turno item in personal.getTurnos())
                {
                    if (item.getNom() != "hola")
                    {
                        ArithmeticException ex = new ArithmeticException("prueba de que funciona");
                        throw ex;
                    }
                }
                
            }
            return probando;
        }
    }
}
