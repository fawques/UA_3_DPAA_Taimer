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
        private ArrayList turnos = new ArrayList();

        //PARTE PUBLICA

        //Constructor
        public Horario(string nom_, int id_) {
            nom = nom_;
            id = id_;
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
            if (turno.getNom() == "turno4") //TODO: si el turno se solapa con lo que ya está en la lista
            {
                Exception ex = new Exception("Turnos solapados");
                throw ex;
            }

            turnos.Add(turno);
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
        public ArrayList getTurnos() {
            return turnos;
        }

        //Prueba de generar Horarios
        public bool generarHorario1() {
            bool correcto = true;

            Turno t1 = new Turno(new Hora(10, 30), new Hora(12, 30), 'L', "turno1", "L04", 1);
            Turno t2 = new Turno(new Hora(11, 30), new Hora(13, 30), 'L', "turno2", "L04", 1);
            Turno t3 = new Turno(new Hora(12, 30), new Hora(14, 30), 'L', "turno3", "L04", 1);

            Actividad_p actP = new Actividad_p("nombre","descripcion",6,"pepito");
            actP.AddTurno(t1);
            actP.AddTurno(t3);
            Actividad_a actP2 = new Actividad_a("nombre2", "descripcion2", 7, 1);
            actP2.AddTurnoTeoria(t2);
            ArrayList arrayP = new ArrayList();
            ArrayList arrayA = new ArrayList();
            arrayP.Add(actP);
            arrayA.Add(actP2);

            

            foreach (Actividad_p personal in arrayP)
            {
                foreach (Turno item in personal.getTurnos())
                {
                    try 
	                {
                        AddTurno(item);
	                }
	                catch (Exception)
	                {
                        return false;
                    }
                    

                }
                
            }
            bool asignado;
            foreach (Actividad_a asig in arrayA)
            {
                asignado = false;
                foreach (Turno item in asig.getTurnosTeoria())
                {
                    if (asignado)
                        break;
                    try
                    {
                        AddTurno(item);
                        asignado = true;
                    }
                    catch (Exception)
                    {
                        asignado = false;
                    }
                }
                if (!asignado)
                {
                    return false;
                }

            }

            return true;
        }
    }
}
