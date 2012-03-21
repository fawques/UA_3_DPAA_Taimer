using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Taimer {
    public class Actividad_a : Actividad {

        #region  PARTE PRIVADA

        // (Nombre, descripción, código y lista de turnos vienen de la clase Actividad)

        private string nombreCoordinador;     // Nombre del profesor coordinador de la asignatura
        int curso;                            // Indica el curso al que pertenece la asignatura

        #endregion

        #region PARTE PÚBLICA


        // Constructor básico (sin lista de turnos ni número de curso)
        public Actividad_a(string nom_, string desc_, int cod_, string nomCoord_)
            : base(nom_, desc_, cod_)
        {

            nombreCoordinador = nomCoord_;
            curso = 0;                      // Por defecto se asigna el número de curso a 0
        }


        // Constructor básico (sin lista de turnos, pero sí con número de curso)
        public Actividad_a(string nom_, string desc_, int cod_, string nomCoord_, int curso_)
            : base(nom_, desc_, cod_)
        {

            nombreCoordinador = nomCoord_;
            curso = curso_;
        }


        // Constructor avanzado (con lista de turnos y curso)
        public Actividad_a(string nom_, string desc_, int cod_, string nomCoord_, List<Turno> turnos_, int curso_)
            : base(nom_, desc_, cod_, turnos_) {

            nombreCoordinador = nomCoord_;
            curso = curso_;
        }


        // Constructor de copia
        public Actividad_a(Actividad_a act)
            : base(act) {
            nombreCoordinador = act.nombreCoordinador;
            curso = act.curso;
        }


        // Cambiar/obtener número de curso de la asignatura
        public int Curso {
            get { return curso; }
            set { curso = value; }
        }


        // Cambiar/obtener nombre del profesor coordinador
        public string NombreCoordinador {
            get { return nombreCoordinador; }
            set { nombreCoordinador = value; }
        }


        // Añadir turno a una actividad académica (no se comprueba solapamiento)
        public void AddTurno(Turno turnonuevo)
        {
            bool insertado = false;

            turnonuevo.Actividad = this;
            AsignarCodigo(turnonuevo);

            for (int i = 0; i < turnos.Count; i++)
            {
                if (turnos[i].HoraInicio > turnonuevo.HoraInicio)
                {
                    turnos.Insert(i, turnonuevo);
                    insertado = true;
                    break;
                }
            }

            if (!insertado)
                turnos.Add(turnonuevo);
        }


        #endregion
    }
}
