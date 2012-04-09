using CAD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Taimer
{

    /// <summary>
    /// Clase Horario: representa la relación entre los días de la semana y los turnos de cada actividad
    /// </summary>
    public class Horario
    {

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
        private void insertarOrdenado(Turno item, int dia)
        {
            int i = 0;
            bool insertado = false;

            for (i = 0; i < arrayTurnos[dia].Count; i++)
            {
                if (arrayTurnos[dia][i].HoraInicio > item.HoraInicio)
                {
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
        private void CheckSolapamiento(Turno turno, int dia)
        {
            foreach (Turno item in arrayTurnos[dia])
            {
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
        public Horario(string nom_, User usu_)
        {
            id = 0;
            nombre = nom_;
            usuario = usu_;

            for (int i = 0; i < 7; i++)
            {
                arrayTurnos[i] = new List<Turno>();
            }
        }

        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="h">Horario que se quiere copiar</param>
        public Horario(Horario h)
        {
            id = h.id;
            nombre = h.nombre;
            usuario = h.usuario;

            for (int i = 0; i < 7; i++)
            {
                arrayTurnos[i] = new List<Turno>();
                foreach (Turno item in h.ArrayTurnos[i])
                {
                    ArrayTurnos[i].Add(new Turno(item));
                }
            }
        }

        /// <summary>
        /// Asigna/Devuelve el nombre del Horario
        /// </summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        /// <summary>
        /// Asigna/Devuelve el identificador del Horario
        /// </summary>
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        /// <summary>
        /// Asigna/Devuelve el usuario al que pertenece el Horario
        /// </summary>
        public User Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        /// <summary>
        /// Devuelve en número de turno que tiene el horario
        /// </summary>
        public int Count
        {
            get
            {
                int cantidad = 0;

                for (int i = 0; i < 7; i++)
                {
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
            if (dia > 6 || dia < 0)
                throw new IndexOutOfRangeException("El día no existe (fuera de rango).");

            if (arrayTurnos[dia].Count == 0)
                throw new ArgumentNullException("El día está vacío.");

            Hora minima = new Hora(23, 59);

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
            bool encontrado = false;
            Hora minima = new Hora(0, 0);
            for (int i = 1; i < 7; i++)
            {
                try
                {
                    if (minHoraDia(i) < minima || !encontrado)
                    {
                        minima = minHoraDia(i);
                        encontrado = true;
                    }
                }
                catch (ArgumentNullException)
                { }
            }

            if (!encontrado)
            {
                throw new NullReferenceException("El horario está vacío");
            }
            return minima;
        }

        /// <summary>
        /// Dice cuál es la hora más tradía del Horario
        /// </summary>
        /// <returns>Devuelve la hora más tradía del Horario</returns>
        public Hora maxHora()
        {
            bool encontrado = false;
            Hora maxima = new Hora(23, 59);
            for (int i = 1; i < 7; i++)
            {
                try
                {
                    if (maxHoraDia(i) > maxima || !encontrado)
                    {
                        maxima = maxHoraDia(i);
                        encontrado = true;
                    }
                }
                catch (ArgumentNullException)
                { }

            }
            if (!encontrado)
            {
                throw new NullReferenceException("El horario está vacío");
            }

            return maxima;
        }

        /// <summary>
        /// Añade el horario a la base de datos
        /// </summary>
        public void Agregar()
        {
            CADHorario h = new CADHorario();
            h.CrearHorarioBasic(id, nombre, usuario.DNI);

            foreach (List<Turno> lt in arrayTurnos)
            {
                foreach (Turno t in lt)
                {
                    h.AddTurnoHo(id, usuario.DNI, t.Codigo, t.Actividad.Codigo);
                }
            }

        }

        /// <summary>
        /// Borra el horario de la base de datos
        /// </summary>
        public void Borrar()
        {
            CADHorario h = new CADHorario();

            h.BorrarTurnosHo(id, usuario.DNI);
            h.BorrarHorario(id, usuario.DNI);

        }

        /// <summary>
        /// Borra un turno del horario (tiene que estar previamente en la base de datos)
        /// </summary>
        /// <param name="codigo">Código del turno que se desea borrar</param>
        public void BorrarTurno(int codigo)
        {
            CADHorario h = new CADHorario();

            foreach (List<Turno> lt in arrayTurnos)
            {
                foreach (Turno t in lt)
                {
                    if (t.Codigo == codigo)
                    {
                        lt.Remove(t);
                        h.BorrarTurnoEspecifico(id, usuario.DNI, t.Codigo, t.Actividad.Codigo);
                    }
                }
            }
        }

        /// <summary>
        /// Guarda los cambios que ha recibido el horario en la base de datos
        /// Si el nombre es ahora vacio la BD lanzará excepción
        /// </summary>
        public void Modificar()
        {
            CADHorario h = new CADHorario();

            if (nombre == "")
                nombre = null;

            h.ModificaHorario(id, nombre, usuario.DNI);
        }
        /// <summary>
        /// Convierte un DataSet(será un Horario) en un objeto Horario
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static Horario HorarioToObject(DataSet data)
        {
            if (data != null)
            {
                string titulo, usuario = "";
                int id = 0;
                DataSet aux = new DataSet();
                CADUser user = new CADUser();
                DataRowCollection rows = data.Tables[0].Rows;

                if (rows.Count != 0)
                {
                    id = (int)rows[0].ItemArray[0];
                    titulo = rows[0].ItemArray[1].ToString();
                    usuario = rows[0].ItemArray[2].ToString();
                    aux = user.GetDatosUser(usuario);
                    Horario hor = new Horario(id, titulo, User.UserToObject(aux));
                    return hor;
                }
            }
            return null;
        }
        /// <summary>
        /// Convertimos un Dataset que contiene lista de Horarios en Una lista de Horarios
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static List<Horario> HorariosToList(DataSet data)
        {
            if (data != null)
            {
                List<Horario> list = new List<Horario>();
                DataSet aux = new DataSet();
                CADUser user = new CADUser();
                string titulo, usuario = "";
                int id = 0;
                DataRowCollection rows = data.Tables[0].Rows;

                for (int i = 0; i < rows.Count; i++)
                {

                    id = (int)rows[i].ItemArray[0];
                    titulo = rows[i].ItemArray[1].ToString();
                    usuario = rows[i].ItemArray[2].ToString();
                    aux = user.GetDatosUser(usuario);
                    list.Add(new Horario(id, titulo, User.UserToObject(aux)));
                }
                return list;
            }
            return null;
        }
        #endregion
    }
}
