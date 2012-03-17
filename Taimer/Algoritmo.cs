using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer
{
    public class Algoritmo
    {
        #region PARTE PRIVADA
        private List<Horario> posibles;
        private List<Actividad_a> seleccionadas_a;
        private List<Actividad_p> seleccionadas_p;
        #endregion

        #region PARTE PÚBLICA

        public Algoritmo(List<Actividad_a> sel_a, List<Actividad_p> sel_p)
        {
            seleccionadas_a = sel_a;
            seleccionadas_p = sel_p;
            // posibles = new List<Horario>();
        }

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
        public Horario generarHorarioVoraz(string nombre)
        {

            // el user será el 1er elemento de la lista de users de Program
            User usertest = new User("Aitor Tilla", "12345678X", "bill_gates@hotmail.com", "password", 1, "Ingeniería de Magisterio");
            Horario h = new Horario(nombre, /*Program.Usuarios[0]*/usertest);
            foreach (Actividad_p personal in seleccionadas_p)
            {
                foreach (Turno item in personal.Turnos)
                {
                    try
                    {
                        h.AddTurno(item);
                    }
                    catch (NotSupportedException)
                    {
                        throw new NotSupportedException("La actividad " + personal.Nombre + " no se puede insertar");
                    }
                }

            }
            bool asignado;
            foreach (Actividad_a asig in seleccionadas_a)
            {
                asignado = false;
                foreach (Turno item in asig.Turnos)
                {
                    if (asignado)
                        break;
                    try
                    {
                        h.AddTurno(item);
                        asignado = true;
                    }
                    catch (NotSupportedException)
                    {
                        asignado = false;
                    }
                }
                if (!asignado)
                    throw new NotSupportedException("La asignatura " + asig.Nombre + " no se puede insertar");
            }

            return h;
        }

        public Horario generarHorarioBT(string nombre)
        {
            Queue<Horario> nodos_vivos = new Queue<Horario>();
            Queue<Horario> nodos_vivos_aux = new Queue<Horario>();
            Queue<Horario> soluciones = new Queue<Horario>();
            // el user será el 1er elemento de la lista de users de Program
            User usertest = new User("Aitor Tilla", "12345678X", "bill_gates@hotmail.com", "password", 1, "Ingeniería de Magisterio");
            Horario optimo = new Horario(nombre, /*Program.Usuarios[0]*/usertest);

            int cant_p = 0;

            // como las personales siempre tienen que estar, se meten directamente en el óptimo
            foreach (Actividad_p personal in seleccionadas_p)
            {
                foreach (Turno item in personal.Turnos)
                {
                    try
                    {
                        optimo.AddTurno(item);
                        cant_p++;
                    }
                    catch (NotSupportedException)
                    {
                        throw new NotSupportedException("La actividad " + personal.Nombre + " no se puede insertar");
                    }
                }
            }

            nodos_vivos.Enqueue(optimo);
            Horario temp;

            // como las académicas tienen que tener un único turno, se mete cada vez en un horario distinto
            bool asignado = false;

            try
            {
                foreach (Actividad_a academica in seleccionadas_a)
                {
                    while (nodos_vivos.Count > 0)
                    {
                        optimo = nodos_vivos.Dequeue();
                        foreach (Turno item in academica.Turnos)
                        {
                            temp = new Horario(optimo);
                            try
                            {
                                temp.AddTurno(item);
                                if (temp.Count() - cant_p < seleccionadas_a.Count)
                                    nodos_vivos_aux.Enqueue(temp);
                                else
                                    soluciones.Enqueue(temp);
                                asignado = true;
                            }
                            catch (NotSupportedException)
                            { }

                        }
                    }
                    nodos_vivos = new Queue<Horario>(nodos_vivos_aux);
                    nodos_vivos_aux.Clear();
                    if (!asignado)
                        throw new NotSupportedException("La asignatura " + academica.Nombre + " no se puede insertar");


                }
                posibles = new List<Horario>(soluciones.ToList());
                optimo = soluciones.Dequeue();
                
            }
            catch (NotSupportedException)
            {

                throw;
            }

            // aquí habría que comprobar las restricciones


            return optimo;
        }
        #endregion

    }
}
