using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Taimer {
    public class Actividad_a : Actividad {

        // PARTE PRIVADA ******************************************************************

        // (Nombre, descripción y código vienen de la clase Actividad)

        private int codCoord;                                           // Código del coordinador de la asignatura

        private List<string> turnos = new List<string>();


        // PARTE PÚBLICA ******************************************************************

        // Constructor
        public Actividad_a(string nom_, string desc_, int cod_, int codCoord_, List<string> turnos_)
            : base(nom_, desc_, cod_) {

            codCoord = codCoord_;
            turnos = turnos_;
        }
        

        // Cambiar/obtener código del coordinador
        public int CodCoord
        {
            get { return codCoord; }
            set { codCoord = value; }
        }


        // Añadir turno a la lista
        public void AddTurno(string tur)
        {
            turnos.Add(tur);
        }


        // Borrar turno de la lista (a partir de su código)
        // Devuelve TRUE si consigue encontrarla y borrarla, FALSE en caso contrario.
        public bool BorraTurno(string codigobuscado)
        {
            foreach (string tur in turnos)
            {
                if (tur == codigobuscado)
                {
                    turnos.Remove(tur);
                    return true;
                }
            }

            return false;
        }
    }
}
