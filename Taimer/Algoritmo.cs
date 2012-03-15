using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taimer;

namespace Taimer
{
    class Algoritmo
    {
        #region PARTE PRIVADA
        List<Horario> posibles;
        List<Actividad_a> seleccionadas_a;
        List<Actividad_p> seleccionadas_p;
        #endregion

        #region PARTE PÚBLICA

        // Puntuar un horario según el número de días. Puntuará de 0 a 7, añadirá uno por cada día en el que haya turnos.
        public static int puntuarDias(Horario horario)
        {
            int puntuacion = 0;
            for (int i = 0; i < 7; i++)
            {
                if (horario.ArrayTurnos[i].Count() > 0)
                    puntuacion++;
            }

            return puntuacion;
        }

        //Generación de un Horario de forma Voraz
        public bool generarHorarioVoraz()
        {
            User usertest = new User("Aitor Tilla", "12345678X", "bill_gates@hotmail.com", "password", 1, "Ingeniería de Magisterio");

            Turno t1 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.L, "L04");
            Turno t2 = new Turno(new Hora(11, 30), new Hora(13, 30), dias.L, "L04");
            Turno t3 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.L, "L04");

            Turno t4 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.X, "L04");
            Turno t5 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.X, "L04");
            Turno t6 = new Turno(new Hora(14, 30), new Hora(16, 30), dias.X, "L04");

            Turno t7 = new Turno(new Hora(10, 30), new Hora(14, 30), dias.M, "L04");
            Turno t8 = new Turno(new Hora(11, 30), new Hora(14, 30), dias.M, "L04");
            Turno t9 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.M, "L04");

            Actividad_p actP = new Actividad_p("nombre", "descripcion", 6, usertest);
            actP.AddTurno(t1);

            Actividad_p actP2 = new Actividad_p("nombre", "descripcion", 6, usertest);
            actP2.AddTurno(t4);
            actP2.AddTurno(t5);
            actP2.AddTurno(t6);

            Actividad_a actA = new Actividad_a("nombre2", "descripcion2", 7, "Un profesor");
            actA.AddTurno(t3);
            actA.AddTurno(t2);

            Actividad_a actA2 = new Actividad_a("nombre2", "descripcion2", 7, "Otro profesor");
            actA2.AddTurno(t7);
            actA2.AddTurno(t8);
            actA2.AddTurno(t9);

            ArrayList arrayP = new ArrayList();
            ArrayList arrayA = new ArrayList();
            arrayP.Add(actP);
            arrayP.Add(actP2);
            arrayA.Add(actA);
            arrayA.Add(actA2);



            foreach (Actividad_p personal in arrayP)
            {
                foreach (Turno item in personal.Turnos)
                {
                    try
                    {
                        AddTurno(item);
                    }
                    catch (NotSupportedException)
                    {
                        return false;
                    }
                }

            }
            bool asignado;
            foreach (Actividad_a asig in arrayA)
            {
                asignado = false;
                foreach (Turno item in asig.Turnos)
                {
                    if (asignado)
                        break;
                    try
                    {
                        AddTurno(item);
                        asignado = true;
                    }
                    catch (NotSupportedException)
                    {
                        asignado = false;
                    }
                }
                if (!asignado)
                    return false;
            }

            return true;
        }
        #endregion

    }
}
