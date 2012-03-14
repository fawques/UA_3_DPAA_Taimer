using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Taimer {
    public class Actividad_a : Actividad {

        #region  PARTE PRIVADA

        // (Nombre, descripción y código vienen de la clase Actividad)

        private int codCoord;                 // Código del coordinador de la asignatura
        private bool tipo;                    // Nos dirá si la actividad/asignatura es de prácticas o de teoria (formará parte de la PK en la BD)
        private List<Turno> turnos = new List<Turno>();

        #endregion

        #region PARTE PÚBLICA

        // Constructor
        public Actividad_a(string nom_, string desc_, int cod_, int codCoord_, bool tipo_, List<Turno> turnos_)
            : base(nom_, desc_, cod_) {

            codCoord = codCoord_;
            tipo = tipo_;
            turnos = turnos_;
        }

        public Actividad_a(string nom_, string desc_, int cod_, int codCoord_, bool tipo_)
            : base(nom_, desc_, cod_)
        {

            codCoord = codCoord_;
            tipo = tipo_;
            turnos = new List<Turno>();
        }

        // Constructor de copia
        public Actividad_a(Actividad_a act)
            : base(act) {
            codCoord = act.codCoord;
            tipo = act.tipo;
            turnos = act.turnos;
        }

        // Cambiar/obtener código del coordinador
        public int CodCoord {
            get { return codCoord; }
            set { codCoord = value; }
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

        public bool Tipo {
            set { tipo = value; }
            get { return tipo; }
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
