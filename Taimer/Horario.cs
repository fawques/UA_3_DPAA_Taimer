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

        public Horario( string nom_, User usu_)
        {
            id = 0;
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
            switch (turno.Dia)
            {
                case dias.L:
                    CheckSolapamiento(turno, 0);
                    arrayTurnos[0].Add(turno);
                    break;
                case dias.M:
                    CheckSolapamiento(turno, 1);
                    arrayTurnos[1].Add(turno);
                    break;
                case dias.X:
                    CheckSolapamiento(turno, 2);
                    arrayTurnos[2].Add(turno);
                    break;
                case dias.J:
                    CheckSolapamiento(turno, 3);
                    arrayTurnos[3].Add(turno);
                    break;
                case dias.V:
                    CheckSolapamiento(turno, 4);
                    arrayTurnos[4].Add(turno);
                    break;
                case dias.S:
                    CheckSolapamiento(turno, 5);
                    arrayTurnos[5].Add(turno);
                    break;
                case dias.D:
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

            for (int i = 0; i < 7; i++)
            {
                foreach (Turno t in arrayTurnos[i])
                {
                    if (t.Codigo == codigobuscado)
                        return arrayTurnos[i].Remove(t);
                }
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
        #endregion
    }
}
