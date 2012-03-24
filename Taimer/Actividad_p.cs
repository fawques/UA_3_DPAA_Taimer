using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class Actividad_p : Actividad {

        #region PARTE PRIVADA
        // (Nombre, descripción y código vienen de la clase Actividad)

        private User usuario;                               // Usuario de la actividad personal

        #endregion

        #region PARTE PUBLICA

        // Constructor básico (sin lista de turnos)
        public Actividad_p(string nom_, string desc_, string cod_, User usu_)
            : base(nom_, desc_, cod_) {
                usuario = usu_;
        }


        // Constructor avanzado (con lista de turnos)
        public Actividad_p(string nom_, string desc_, string cod_, string responsable_, List<Turno> turnos_, User usu_)
            : base(nom_, desc_, cod_, turnos_) {

            usuario = usu_;
        }

        // Constructor de copia
        public Actividad_p(Actividad_p act)
            : base(act) {
                usuario = act.usuario; 
        }

        // Cambiar/obtener usuario
        public User Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }


        // Añadir turno a una actividad personal (SÍ se comprueba solapamiento)
       /* public void AddTurno(Turno turnonuevo)
        {
            bool insertado = false;
            
            for (int i = 0; i < turnos.Count; i++) {

                if (turnos[i].HoraInicio > turnonuevo.HoraInicio) {
                    foreach (Turno item in turnos) { //¿¿??
                        // Comprobar si se superponen y lanzar excepción si así es
                        item.Superpone(turnonuevo);
                    }

                    AsignarCodigo(turnonuevo);
                    turnonuevo.Actividad = this;
                    turnos.Insert(i, turnonuevo);
                    insertado = true;
                    break;
                }
            }

            if (!insertado) {
                // Comprobar si se superponen y lanzar excepción si así es
                if(turnos.Count > 0)
                    turnonuevo.Superpone(turnos[(turnos.Count - 1)]);

                turnonuevo.Actividad = this;
                AsignarCodigo(turnonuevo);
                

                turnos.Add(turnonuevo);
            }
        }*/

        public void AddTurno(Turno turnonuevo) {
            bool insertado = false;

            turnonuevo.Actividad = this;
            AsignarCodigo(turnonuevo);

            for (int i = 0; i < turnos.Count; i++) {
                turnonuevo.Superpone(turnos[i]); //compruebo si se solapan los turnos
                if (turnos[i].HoraInicio > turnonuevo.HoraInicio) {
                    turnos.Insert(i, turnonuevo);
                    insertado = true;
                    break;
                }
            }

            if (!insertado)
                turnos.Add(turnonuevo);
        }

        // Cambiar/obtener lista de turnos
        new public List<Turno> Turnos {
            set {
                foreach (Turno t in value) {
                    AddTurno(t); //Para que los meta con codigo correcto y ordenados
                }
            }
            get { return turnos; }
        }

        #endregion
    }
}
