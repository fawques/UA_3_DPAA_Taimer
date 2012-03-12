using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    class Horario {

        // PARTE PRIVADA ******************************************************************

        private int id;                                     // Clave principal
        private string nombre;
        private List<string> turnos = new List<string>();   // Un horario tiene (0,N) turnos
        private string usuario;                             // Un horario es creado por (1,1) usuarios


        // PARTE PÚBLICA ******************************************************************

        // Constructor
        public Horario(string nom_, int id_, string usu_) {
            nombre = nom_;
            id = id_;
            usuario = usu_;
        }


        // Ajustar/obtener nombre
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        // Ajustar/obtener id
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        // Ajustar/obtener usuario
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        // Añadir turno
        public void AddTurno(string turno) {
            turnos.Add(turno);
        }


        // Borrar turno (a partir de su código, si se encuentra)
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
