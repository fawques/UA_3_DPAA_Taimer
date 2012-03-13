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
        private List<Turno> turnos = new List<Turno>();     // Un horario tiene (0,N) turnos
        private User usuario;                             // Un horario es creado por (1,1) usuarios

        #endregion

        #region PARTE PÚBLICA 

        // Constructor
        public Horario(int id_, string nom_, User usu_) {
            id = id_;
            nombre = nom_;
            usuario = usu_;
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


        // Añadir turno
        public void AddTurno(Turno turno) {
            turnos.Add(turno);
        }

        // Cambiar/Obtener turnos
        public List<Turno> Turnos {
            set { turnos = value; }
            get { return turnos; }
        }

        // Borrar turno (a partir de su código, si se encuentra)
        public bool BorraTurno(int codigobuscado) {

            foreach (Turno t in turnos) {
                if (t.Codigo == codigobuscado) 
                    return turnos.Remove(t);
            }
            return false;
        }

        #endregion
    }
}
