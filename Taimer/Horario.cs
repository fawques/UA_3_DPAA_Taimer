//TODO: ajustar gets y sets

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Taimer {
    public class Horario {

        #region PARTE PRIVADA
        private int id;                                     // Clave principal
        private string nombre;
        private List<Turno>[] arrayTurnos = new List<Turno>[7];     // Un horario tiene (0,N) turnos
        private User usuario;                             // Un horario es creado por (1,1) usuarios
        #endregion

    #region PARTE PÚBLICA 

        // Constructor
        public Horario(int id_, string nom_, User usu_) {
            id = id_;
            nombre = nom_;
            usuario = usu_;

            for (int i = 0; i < 7; i++)
            {
                arrayTurnos[i] = new List<Turno>();
            }
        }

        // Constructor de copia
        public Horario(Horario h) {
            id = h.id;
            nombre = h.nombre;
            usuario = h.usuario;
        }

        // Ajustar/obtener nombre
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        // Ajustar/obtener id
        public int ID {
            get { return id; }
            set { id = value; }
        }


        // Ajustar/obtener usuario
        public User Usuario {
            get { return usuario; }
            set { usuario = value; }
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
                if (item.Dia.Equals(turno.Dia))
                {
                    // si se superponen
                    if ((item.HoraFin > turno.HoraInicio && item.HoraFin <= turno.HoraFin) ||
                        (turno.HoraFin > item.HoraInicio && turno.HoraFin <= item.HoraFin) ||
                        (item.HoraInicio >= turno.HoraInicio && item.HoraInicio < turno.HoraFin) ||
                        (turno.HoraInicio >= item.HoraInicio && turno.HoraInicio < item.HoraFin))
                    {
                        NotSupportedException ex = new NotSupportedException("Turnos solapados");
                        throw ex;
                    }
                }
            }
        }

        // Cambiar/Obtener turnos
        public List<Turno>[] ArrayTurnos {
            set { arrayTurnos = value; }
            get { return arrayTurnos; }
        }

        // Borrar turno (a partir de su código, si se encuentra)
        public bool BorraTurno(int codigobuscado) {

            foreach (Turno t in turnos) {
                if (t.Codigo == codigobuscado) 
                    return turnos.Remove(t);
            }
            return false;
        }

        
        #region ALGORITMO


        // Puntuar un horario según el número de días. Puntuará de 0 a 7, añadirá uno por cada día en el que haya turnos.
        public static int puntuarDias(Horario horario)
        {
            int puntuacion = 0;
            for (int i = 0; i < 7; i++)
            {
                if (horario.Turnos[i].Count() > 0)
                    puntuacion++;
            }

            return puntuacion;
        }

        // Puntuar un horario según el número de horas de hueco. Añadirá uno por cada hora en la que haya huecos entre turnos.
        public static int puntuarHorasHueco(Horario horario)
        {
            int puntuacion = 0;

            foreach (ArrayList dia in horario.Turnos)
            {
                try
                {
                    // WARNING! Para que esto funcione bien, los turnos tienen que estar ordenados
                    Hora mindia = new Hora(99, 99);
                    Hora maxdia = new Hora(0, 0);
                    Horario.horasLimitesDia(dia, ref mindia, ref maxdia);

                    Hora initHueco = new Hora(0, 0);
                    Hora finHueco = new Hora(0, 0);
                    Turno aux = (Turno)dia[0];
                    initHueco = aux.HoraInicio;
                    foreach (Turno item in dia)
                    {
                        finHueco = item.HoraFin;

                        //TODO: sumar la diferencia a puntuacion --> hacer funcion operator-
                    }
                }
                catch(IndexOutOfRangeException)
                {}

            }
            return puntuacion;
        }

        //Devuelve por referencia la primera hora del día y la última de una lista de Turnos
        public static void horasLimitesDia(ArrayList dia, ref Hora horaini, ref Hora horafin)
        {
            horaini.Hor = horaini.Min = 99;
            horafin.Hor = horafin.Min = 0;
            foreach (Turno item in dia)
            {
                if (item.HoraInicio < horaini)
                    horaini = item.HoraInicio;
                if (item.HoraFin > horafin)
                    horafin = item.HoraFin;
            }

            if (horaini.Hor == 99)
                throw new IndexOutOfRangeException("Día vacío");
        }

        //Generación de un Horario de forma Voraz
        public bool generarHorarioVoraz()
        {

            Turno t1 = new Turno(1,new Hora(10, 30), new Hora(12, 30), 'L', "turno1", "L04");
            Turno t2 = new Turno(2,new Hora(11, 30), new Hora(13, 30), 'L', "turno2", "L04");
            Turno t3 = new Turno(3,new Hora(12, 30), new Hora(14, 30), 'L', "turno3", "L04");

            Turno t4 = new Turno(new Hora(10, 30), new Hora(12, 30), 'X', "turno4", "L04");
            Turno t5 = new Turno(new Hora(12, 30), new Hora(14, 30), 'X', "turno5", "L04");
            Turno t6 = new Turno(new Hora(14, 30), new Hora(16, 30), 'X', "turno6", "L04");

            Turno t7 = new Turno(new Hora(10, 30), new Hora(14, 30), 'M', "turno7", "L04");
            Turno t8 = new Turno(new Hora(11, 30), new Hora(14, 30), 'M', "turno8", "L04");
            Turno t9 = new Turno(new Hora(12, 30), new Hora(14, 30), 'M', "turno9", "L04");

            Actividad_p actP = new Actividad_p("nombre", "descripcion", 6, "pepito");
            actP.AddTurno(t1);

            Actividad_p actP2 = new Actividad_p("nombre", "descripcion", 6, "pepito");
            actP2.AddTurno(t4);
            actP2.AddTurno(t5);
            actP2.AddTurno(t6);

            Actividad_a actA = new Actividad_a("nombre2", "descripcion2", 7, 1);
            actA.AddTurno(t3);
            actA.AddTurno(t2);

            Actividad_a actA2 = new Actividad_a("nombre2", "descripcion2", 7, 1);
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

        public bool generarHorarioBT()
        {
            throw new NotImplementedException();
            return true;
        }
        #endregion
        #endregion
    }
}
