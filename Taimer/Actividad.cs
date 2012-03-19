using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    abstract public class Actividad {

        #region PARTE PROTECTED

        protected int codigo;                                     // Clave principal
        protected string nombre;
        protected string descripcion;
        protected List<Turno> turnos = new List<Turno>();

        #endregion

        #region PARTE PÚBLICA

        // Constructor
        public Actividad(string nom_, string desc_, int cod_) {
            nombre = nom_;
            descripcion = desc_;
            codigo = cod_;
        }


        // Constructor
        public Actividad(string nom_, string desc_, int cod_, List<Turno> turnos_)
        {
            nombre = nom_;
            descripcion = desc_;
            codigo = cod_;
            turnos = turnos_;
        }

        // Constructor de copia
        public Actividad(Actividad act) {
            nombre = act.nombre;
            descripcion = act.descripcion;
            codigo = act.codigo;
            turnos = act.turnos;
        }


        // Cambiar/obtener nombre
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        // Cambiar/obtener descripción
        public string Descripcion {
            get { return descripcion; }
            set { descripcion = value; }
        }


        // Cambiar/obtener código
        public int Codigo {
            get { return codigo; }
            set { codigo = value; }
        }




        // *** FUNCIONES SOBRE LA LISTA DE TURNOS ***


        // Cambiar/obtener lista de turnos
        public List<Turno> Turnos
        {
            set { turnos = value; }
            get { return turnos; }
        }


        // Añadir turno a la lista de turnos
        public void AddTurno(Turno turnonuevo)
        {
            turnos.Add(turnonuevo);                 // Añade el turno a la lista, ...
            OrdenarTurnos(turnos);                  // ...y la ordena por hora de inicio.
        }


        // Borrar turno
        public bool BorraTurno(Turno turno)
        {
            return Turnos.Remove(turno);
        }


        // Borrar turno (a partir de su código, si se encuentra)
        public bool BorraTurno(int codigobuscado)
        {
            foreach (Turno t in turnos)
            {
                if (t.Codigo == codigobuscado)
                    return Turnos.Remove(t);
            }
            return false;
        }


        // Ordenar lista de turnos
        public void OrdenarTurnos(List<Turno> listaturnos)
        {
            TurnoComparer tc = new TurnoComparer();     // La definición de esta clase está en Turno.cs
            listaturnos.Sort(tc);
        }

        #endregion
    }
}
