using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Taimer {

    /// <summary>
    /// Clase Horario: representa la relación entre los días de la semana y los turnos de cada actividad
    /// </summary>
    public class Horario {

        #region PARTE PRIVADA
        
        /// <summary>
        /// Identificador del Horario
        /// También es la clave primaria en la base de datos
        /// </summary>
        private int id;

        /// <summary>
        /// Nombre que el usuario da al horario
        /// </summary>
        private string nombre;

        /// <summary>
        /// Array de listas de Turno que contiene los turnos del Horario
        /// </summary>
        private List<Turno>[] arrayTurnos = new List<Turno>[7];     // Un horario tiene (0,N) turnos

        /// <summary>
        /// Usuario al que pretence el Horario
        /// </summary>
        private User usuario;                             // Un horario es creado por (1,1) usuarios

        /// <summary>
        /// Inserta un turno Ordenado en un determinado dia
        /// </summary>
        /// <param name="item">Turno que se quiere insertar </param>
        /// <param name="dia"> Dia en el que se quiere insertar </param>
        private void insertarOrdenado(Turno item, int dia) {
            int i = 0;
            bool insertado = false;

            for (i = 0; i < arrayTurnos[dia].Count; i++) {
                if (arrayTurnos[dia][i].HoraInicio > item.HoraInicio) {
                    arrayTurnos[dia].Insert(i, item);
                    insertado = true;
                    break;
                }
            }

            if (!insertado)
                arrayTurnos[dia].Add(item);

        }

        /// <summary>
        /// Comprueba si un turno se solapa dado un dia
        /// </summary>
        /// <param name="turno">Turno que se quiere comprobar</param>
        /// <param name="dia">Dia en el que se quiere hacer la comprobación</param>
        private void CheckSolapamiento(Turno turno, int dia) {
            foreach (Turno item in arrayTurnos[dia]) {
                item.Superpone(turno);
            }
        }

        #endregion

        #region PARTE PÚBLICA

        /// <summary>
        /// Constructor Completo
        /// Uso exclusivo de los CADs
        /// </summary>
        /// <param name="id_">Identificador del Horario</param>
        /// <param name="nom_">Nombre del Horario</param>
        /// <param name="usu_">Usuario al que pretenece el Horario</param>
        public Horario(int id_, string nom_, User usu_)
        {
            id = id_;
            nombre = nom_;
            usuario = usu_;

            for (int i = 0; i < 7; i++)
            {
                arrayTurnos[i] = new List<Turno>();
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nom_">Nombre del Horario</param>
        /// <param name="usu_">Usuario al que pertenece el Horario</param>
        public Horario(string nom_, User usu_) {
            id = 0;
            nombre = nom_;
            usuario = usu_;

            for (int i = 0; i < 7; i++) {
                arrayTurnos[i] = new List<Turno>();
            }
        }

        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="h">Horario que se quiere copiar</param>
        public Horario(Horario h) {
            id = h.id;
            nombre = h.nombre;
            usuario = h.usuario;

            for (int i = 0; i < 7; i++) {
                arrayTurnos[i] = new List<Turno>(h.ArrayTurnos[i]);
            }
        }

        /// <summary>
        /// Asigna/Devuelve el nombre del Horario
        /// </summary>
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        /// <summary>
        /// Asigna/Devuelve el identificador del Horario
        /// </summary>
        public int ID {
            get { return id; }
            set { id = value; }
        }


        /// <summary>
        /// Asigna/Devuelve el usuario al que pertenece el Horario
        /// </summary>
        public User Usuario {
            get { return usuario; }
            set { usuario = value; }
        }


        /// <summary>
        /// Devuelve en número de turno que tiene el horario
        /// </summary>
        public int Count {
            get {
                int cantidad = 0;

                for (int i = 0; i < 7; i++) {
                    cantidad += arrayTurnos[i].Count;
                }

                return cantidad;
            }
        }


        /// <summary>
        /// Añade un Turno al Horario
        /// </summary>
        /// <param name="turno">Turno que se desea añadir</param>
        public void AddTurno(Turno turno)
        {
            switch (turno.Dia)
            {
                case dias.L:
                    CheckSolapamiento(turno, 0);
                    insertarOrdenado(turno, 0);
                    break;
                case dias.M:
                    CheckSolapamiento(turno, 1);
                    insertarOrdenado(turno, 1);
                    break;
                case dias.X:
                    CheckSolapamiento(turno, 2);
                    insertarOrdenado(turno, 2);
                    break;
                case dias.J:
                    CheckSolapamiento(turno, 3);
                    insertarOrdenado(turno, 3);
                    break;
                case dias.V:
                    CheckSolapamiento(turno, 4);
                    insertarOrdenado(turno, 4);
                    break;
                case dias.S:
                    CheckSolapamiento(turno, 5);
                    insertarOrdenado(turno, 5);
                    break;
                case dias.D:
                    CheckSolapamiento(turno, 6);
                    insertarOrdenado(turno, 6);
                    break;
            }
        }
        

        /// <summary>
        /// Asigna/Devuelve el array de listas de Turno que contiene los turnos del Horario
        /// </summary>
        public List<Turno>[] ArrayTurnos
        {
            set { arrayTurnos = value; }
            get { return arrayTurnos; }
        }

        /// <summary>
        /// Borrar turno (a partir de su código, si se encuentra)
        /// </summary>
        /// <param name="codigobuscado">Código del turno que se desea borrar</param>
        /// <returns>Devuelve TRUE si se ha borrado y FALSE en caso contrario</returns>
        public bool BorraTurno(int codigobuscado)
        {

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

        /// <summary>
        /// Dice cuál es la primera hora de un día de un horario
        /// </summary>
        /// <param name="dia">Dia del que se quiere su primera hora</param>
        /// <returns>Primera hora del dia</returns>
        public Hora minHoraDia(int dia)
        {
            if(dia > 6 || dia < 0)
                throw new IndexOutOfRangeException("El día no existe (fuera de rango).");

            if(arrayTurnos[dia].Count == 0)
                throw new ArgumentNullException("El día está vacío.");

            Hora minima = new Hora(23,59);

            foreach (Turno item in arrayTurnos[dia])
            {
                if (item.HoraInicio < minima)
                    minima = item.HoraInicio;
            }
            return minima;
        }

        /// <summary>
        /// Dice cuál es la última hora de un día de un horario
        /// </summary>
        /// <param name="dia">Dia del que se quiere su última hora</param>
        /// <returns></returns>
        public Hora maxHoraDia(int dia)
        {
            if (dia > 6 || dia < 0)
                throw new IndexOutOfRangeException("El día no existe (fuera de rango).");

            if (arrayTurnos[dia].Count == 0)
                throw new ArgumentNullException("El día está vacío");

            Hora maxima = new Hora(0, 0);

            foreach (Turno item in arrayTurnos[dia])
            {
                if (item.HoraFin > maxima)
                    maxima = item.HoraFin;
            }
            return maxima;
        }

        /// <summary>
        /// Dice cuál es la hora más temprana del Horario
        /// </summary>
        /// <returns>Devuelve la hora más temprana del Horario</returns>
        public Hora minHora()
        {
            Hora minima = minHoraDia(0);
            for (int i = 1; i < 7; i++)
            {
                try
                {
                    if (minHoraDia(i) < minima)
                        minima = minHoraDia(i);
                }
                catch (ArgumentNullException)
                {}
                
            }
            return minima;
        }

        /// <summary>
        /// Dice cuál es la hora más tradía del Horario
        /// </summary>
        /// <returns>Devuelve la hora más tradía del Horario</returns>
        public Hora maxHora()
        {
            Hora maxima = maxHoraDia(0);
            for (int i = 1; i < 7; i++)
            {
                try
                {
                    if (maxHoraDia(i) > maxima)
                        maxima = maxHoraDia(i);
                }
                catch (ArgumentNullException)
                {}
                
            }
            return maxima;
        }

        #endregion
    }
}
