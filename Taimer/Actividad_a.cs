using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Taimer {
    public class Actividad_a : Actividad {

        #region  PARTE PRIVADA

        // (Nombre, descripción y código vienen de la clase Actividad)

        private string nombreCoordinador;     // Nombre del profesor coordinador de la asignatura
        private List<Turno> turnos = new List<Turno>();
        int curso;                              // Indica el curso al que pertenece la asignatura

        #endregion

        #region PARTE PÚBLICA


        // Constructor básico (sin lista de turnos ni número de curso)
        public Actividad_a(string nom_, string desc_, int cod_, string nomCoord_)
            : base(nom_, desc_, cod_)
        {

            nombreCoordinador = nomCoord_;
            turnos = new List<Turno>();
            curso = 0;                      // Por defecto se asigna el número de curso a 0
        }


        // Constructor básico (sin lista de turnos, pero sí con número de curso)
        public Actividad_a(string nom_, string desc_, int cod_, string nomCoord_, int curso_)
            : base(nom_, desc_, cod_)
        {

            nombreCoordinador = nomCoord_;
            turnos = new List<Turno>();
            curso = curso_;
        }


        // Constructor avanzado (con lista de turnos y curso)
        public Actividad_a(string nom_, string desc_, int cod_, string nomCoord_, List<Turno> turnos_, int curso_)
            : base(nom_, desc_, cod_) {

            nombreCoordinador = nomCoord_;
            turnos = turnos_;
            curso = curso_;
        }


        // Constructor de copia
        public Actividad_a(Actividad_a act)
            : base(act) {
            nombreCoordinador = act.nombreCoordinador;
            turnos = act.turnos;
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


        // Añadir turno a la lista
        public void AddTurno(Turno tur) {
            turnos.Add(tur);
        }


        //Cambiar/obtener turnos
        public List<Turno> Turnos {
            set { turnos = value; }
            get { return turnos; }
        }


        // Borrar turno de la lista (a partir de su código)
        // Devuelve TRUE si consigue encontrarla y borrarla, FALSE en caso contrario.
        public bool BorraTurno(int codigobuscado) {
            
            foreach(Turno t in turnos){
                if(t.Codigo == codigobuscado)
                    return Turnos.Remove(t);
            }
            return false;
        }
        #endregion
    }
}
