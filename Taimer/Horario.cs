using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer
{
    public class Horario
    {

        //PARTE PRIVADA

        private string nom;
        private int id;
        private ArrayList[] arrayTurnos = new ArrayList[7];


        //PARTE PUBLICA

        //Constructor
        public Horario(string nom_, int id_)
        {
            nom = nom_;
            id = id_;

            for (int i = 0; i < 7; i++)
            {
                arrayTurnos[i] = new ArrayList();
            }
        }

        //Cambiar el nombre
        public void setNom(string nom_)
        {
            nom = nom_;
        }

        //Cambiar la id
        public void setId(int id_)
        {
            id = id_;
        }

        //Añadir turnos
        public void AddTurno(Turno turno)
        {
            switch (turno.getDia())
            {
                case 'L':
                    CheckSolapamiento(turno, 0);
                    arrayTurnos[0].Add(turno);
                    break;
                case 'M':
                    CheckSolapamiento(turno, 1);
                    arrayTurnos[1].Add(turno);
                    break;
                case 'X':
                    CheckSolapamiento(turno, 2);
                    arrayTurnos[2].Add(turno);
                    break;
                case 'J':
                    CheckSolapamiento(turno, 3);
                    arrayTurnos[3].Add(turno);
                    break;
                case 'V':
                    CheckSolapamiento(turno, 4);
                    arrayTurnos[4].Add(turno);
                    break;
                case 'S':
                    CheckSolapamiento(turno, 5);
                    arrayTurnos[5].Add(turno);
                    break;
                case 'D':
                    CheckSolapamiento(turno, 6);
                    arrayTurnos[6].Add(turno);
                    break;
            }
        }

        public void CheckSolapamiento(Turno turno, int dia)
        {
            foreach (Turno item in arrayTurnos[dia])
            {
                if (item.getDia().Equals(turno.getDia()))
                {
                    // si se superponen
                    if ((item.getHoraF() > turno.getHoraI() && item.getHoraF() <= turno.getHoraF()) ||
                        (turno.getHoraF() > item.getHoraI() && turno.getHoraF() <= item.getHoraF()) ||
                        (item.getHoraI() >= turno.getHoraI() && item.getHoraI() < turno.getHoraF()) ||
                        (turno.getHoraI() >= item.getHoraI() && turno.getHoraI() < item.getHoraF()))
                    {
                        Exception ex = new Exception("Turnos solapados");
                        throw ex;
                    }
                }
            }
        }

        //Obtener nombre
        public string getNom()
        {
            return nom;
        }

        //Obtener id
        public int getId()
        {
            return id;
        }

        //Obtener ArrayList de turnos
        public ArrayList[] getTurnos()
        {
            return arrayTurnos;
        }

        // Puntuar un horario según el número de días. Puntuará de 0 a 7, añadirá uno por cada día en el que haya turnos.
        public static int puntuarDias(Horario horario)
        {
            int puntuacion = 0;
            for (int i = 0; i < 7; i++)
            {
                if (horario.getTurnos()[i].Count > 0)
                    puntuacion++;
            }

            return puntuacion;
        }

        // Puntuar un horario según el número de horas de hueco. Añadirá uno por cada hora en la que haya huecos entre turnos.
        public static int puntuarHorasHueco(Horario horario)
        {
            int puntuacion = 0;

            foreach (ArrayList dia in horario.getTurnos())
            {
                foreach (Turno item in dia)
                {
                    // hacer cosas
                }

            }
            return puntuacion;
        }

        //Generación de un Horario de forma Voraz
        public bool generarHorarioVoraz()
        {

            Turno t1 = new Turno(new Hora(10, 30), new Hora(12, 30), 'L', "turno1", "L04", 1);
            Turno t2 = new Turno(new Hora(11, 30), new Hora(13, 30), 'L', "turno2", "L04", 1);
            Turno t3 = new Turno(new Hora(12, 30), new Hora(14, 30), 'L', "turno3", "L04", 1);

            Turno t4 = new Turno(new Hora(10, 30), new Hora(12, 30), 'X', "turno4", "L04", 1);
            Turno t5 = new Turno(new Hora(12, 30), new Hora(14, 30), 'X', "turno5", "L04", 1);
            Turno t6 = new Turno(new Hora(14, 30), new Hora(16, 30), 'X', "turno6", "L04", 1);

            Turno t7 = new Turno(new Hora(10, 30), new Hora(14, 30), 'M', "turno7", "L04", 1);
            Turno t8 = new Turno(new Hora(11, 30), new Hora(14, 30), 'M', "turno8", "L04", 1);
            Turno t9 = new Turno(new Hora(12, 30), new Hora(14, 30), 'M', "turno9", "L04", 1);

            Actividad_p actP = new Actividad_p("nombre", "descripcion", 6, "pepito");
            actP.AddTurno(t1);

            Actividad_p actP2 = new Actividad_p("nombre", "descripcion", 6, "pepito");
            actP2.AddTurno(t4);
            actP2.AddTurno(t5);
            actP2.AddTurno(t6);

            Actividad_a actA = new Actividad_a("nombre2", "descripcion2", 7, 1);
            actA.AddTurnoTeoria(t3);
            actA.AddTurnoTeoria(t2);

            Actividad_a actA2 = new Actividad_a("nombre2", "descripcion2", 7, 1);
            actA2.AddTurnoTeoria(t7);
            actA2.AddTurnoTeoria(t8);
            actA2.AddTurnoTeoria(t9);

            ArrayList arrayP = new ArrayList();
            ArrayList arrayA = new ArrayList();
            arrayP.Add(actP);
            arrayP.Add(actP2);
            arrayA.Add(actA);
            arrayA.Add(actA2);



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
                    return false;
            }

            return true;
        }

        public bool generarHorarioBT()
        {

            return true;
        }

    }
}
