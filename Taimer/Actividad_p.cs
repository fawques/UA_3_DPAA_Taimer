using CAD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    /// <summary>
    /// Clase Actividad_p: esta clase hereda de Actividad y representa cualquier otro tipo de actividad idependiente del ambito academico.
    /// Estas actividades son propias de cada usuario
    /// </summary>
    public class Actividad_p : Actividad {

        #region PARTE PRIVADA
        // (Nombre, descripción y código vienen de la clase Actividad)

        /// <summary>
        /// Usuario de la actividad personal
        /// </summary>
        private User usuario;

        #endregion

        #region PARTE PUBLICA

        /// <summary>
        /// Constructor básico (sin lista de turnos)
        /// </summary>
        /// <param name="nom_">Nombre de la Actividad_p</param>
        /// <param name="desc_">Descripción de la Actividad_p</param>
        /// <param name="cod_">Código de la Actividad_p</param>
        /// <param name="usu_">Usuario de la Activiad_p</param>
        public Actividad_p(string nom_, string desc_, int cod_, User usu_)
            : base(nom_, desc_, cod_) {
                usuario = usu_;
        }


        /// <summary>
        ///  Constructor avanzado (con lista de turnos)
        /// </summary>
        /// <param name="nom_">Nombre de la Actividad_p</param>
        /// <param name="desc_">Descripción de la Actividad_p</param>
        /// <param name="cod_">Código de la Actividad_p</param>
        /// <param name="turnos_">Listas de turnos en los que se realiza la Actividad_p </param>
        /// <param name="usu_">Usuario al que pertenece esta Actividad_p</param>
        public Actividad_p(string nom_, string desc_, int cod_, List<Turno> turnos_, User usu_)
            : base(nom_, desc_, cod_, turnos_) {

            usuario = usu_;
        }

        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="act">Actividad_p que se desea copiar</param>
        public Actividad_p(Actividad_p act)
            : base(act) {
                usuario.CodActPers--;
                act.Codigo = usuario.CodActPers;
                usuario = act.usuario; 
        }

        /// <summary>
        /// Asigna/Devuelve el usuario de la Actividad_p
        /// </summary>
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

        /// <summary>
        /// Añade un turno a la Actividad_p
        ///  Los turnos están ordenados de forma creciente
        /// </summary>
        /// <param name="turnonuevo"> Turno que se desea añadir </param>
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

        /// <summary>
        /// Asigna/Devuelve la lista de Turnos
        /// </summary>
        new public List<Turno> Turnos {
            set {
                foreach (Turno t in value) {
                    AddTurno(t); //Para que los meta con codigo correcto y ordenados
                }
            }
            get { return turnos; }
        }

        /// <summary>
        /// Añade la Actividad Personal a la base de datos
        /// </summary>
        public void Agregar() {
            CADActividad_p act = new CADActividad_p();

            act.CrearActivida_pAll(nombre, descripcion, codigo, usuario.DNI);
        }

        /// <summary>
        /// Borra la actividad personal de la base de datos
        /// </summary>
        public void Borrar() {
            CADActividad_p act = new CADActividad_p();

            act.BorrarActividad_p(codigo);
        }


        /// <summary>
        /// Devuelve el ultimo codigo de activdades personales añadido a la base de datos
        /// </summary>
        public static int UltimoCodigo {
            get {
                CADActividad_p act = new CADActividad_p();
                return int.Parse(act.LastCode().Tables[0].Rows[0].ItemArray[0].ToString());
            }
        }

        #endregion
    }
}
