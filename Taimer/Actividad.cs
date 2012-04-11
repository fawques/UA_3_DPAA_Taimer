using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    /// <summary>
    /// Clase Actividad: clase abstracta de la que heredarán Actividad_a y Actividad_p
    /// </summary>
    abstract public class Actividad {

        #region PARTE PROTECTED

        /// <summary>
        /// Código de la Actividad y clave primaria en la base de datos
        /// </summary>
        protected int codigo;   
                                  
        /// <summary>
        /// Nombre de la actividad
        /// </summary>
        protected string nombre;

        /// <summary>
        /// Descripción de la Actividad
        /// </summary>
        protected string descripcion;

        /// <summary>
        /// Lista de turnos que tiene la Actividad
        /// </summary>
        protected List<Turno> turnos = new List<Turno>();

        /// <summary>
        /// Último código de turno asignado
        /// </summary>
        protected int codigoturno;

        /// <summary>
        ///  Codifica el código del un turno
        /// </summary>
        /// <param name="t"> turno a codificar </param>
        protected void AsignarCodigo(Turno t) {
            t.Codigo = codigoturno;
            codigoturno++;
        }

        #endregion

        #region PARTE PÚBLICA

        /// <summary>
        /// Constructor Básio
        /// </summary>
        /// <param name="nom_"> Nombre de la Actividad</param>
        /// <param name="desc_"> Descripción de la Actividad</param>
        /// <param name="cod_"> Código de la Actividad </param>
        public Actividad(string nom_, string desc_, int cod_) {
            nombre = nom_;
            descripcion = desc_;
            codigo = cod_;
            codigoturno = 1;
        }


        /// <summary>
        /// Constructor Avanzado
        /// </summary>
        /// <param name="nom_"> Nombre de la Actividad </param>
        /// <param name="desc_"> Descripción de la Actividad </param>
        /// <param name="cod_"> Código de la Actividad </param>
        /// <param name="turnos_"> Lista de turnos a la que se puede asistir </param>
        public Actividad(string nom_, string desc_, int cod_, List<Turno> turnos_)
        {
            nombre = nom_;
            descripcion = desc_;
            codigo = cod_;
            turnos = new List<Turno>(turnos_);
            codigoturno = 1;
        }

        /// <summary>
        /// Constructor de Copia
        /// </summary>
        /// <param name="act"> Actividad que se desea copiar </param>
        public Actividad(Actividad act) {
            CopiarDesde(act);
        }

        /// <summary>
        /// Copia una actividad en otra, sin necesidad de crearla
        /// </summary>
        /// <param name="act">Actividad que se desea copiar</param>
        /// <returns></returns>
        public virtual void CopiarDesde(Actividad act)
        {
            nombre = act.nombre;
            descripcion = act.descripcion;
            codigo = act.codigo;
            codigoturno = act.codigoturno;

            turnos = new List<Turno>();
            foreach (Turno item in act.turnos)
            {
                turnos.Add(new Turno(item));
            }
        }

        public Actividad()
        {
            // TODO: Complete member initialization
        }

        /// <summary>
        /// Asigna/Devuelve el nombre de la Actividad
        /// </summary>
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        /// <summary>
        /// Asigna/Devuelve la descripción de la Actividad
        /// </summary>
        public string Descripcion {
            get { return descripcion; }
            set { descripcion = value; }
        }


        /// <summary>
        /// Asigna/Devuelve el código de la Actividad
        /// </summary>
        public int Codigo {
            get { return codigo; }
            set { codigo = value; }
        }




        // *** FUNCIONES SOBRE LA LISTA DE TURNOS ***


        /// <summary>
        /// Asigna/Devuelve la lista de turnos
        /// </summary>
        public List<Turno> Turnos {
            set {
                foreach (Turno t in value) {
                    AsignarCodigo(t);
                    turnos.Add(t);
                }
            }
            get { return turnos; }
        }


        /// <summary>
        /// Borrar un turno
        /// </summary>
        /// <param name="turno"> Turno que se quiere borrar </param>
        /// <returns> Devuelve TRUE si se ha borrado FALSE en caso contrario </returns>
        public bool BorraTurnoBool(Turno turno) {
            return Turnos.Remove(turno);
        }


        /// <summary>
        /// Borrar un turno
        /// Lanaza excepción si no se puede borrar el turno
        /// </summary>
        /// <param name="turno"> Turno que se quiere borrar </param>
        public void BorraTurno(Turno turno) {
            bool borrado = Turnos.Remove(turno);

            if (!borrado)
                throw new MissingMemberException("No existe el turno que se desea borrar.");
        }

        /// <summary>
        /// Borrar un turno a partir de su código
        /// </summary>
        /// <param name="codigobuscado"> Código del turno que se desea borrar </param>
        /// <returns>Devuelve TRUE si se ha borrado y FALSE en caso contrario </returns>
        public bool BorraTurnoBool(int codigobuscado) {
            foreach (Turno t in turnos) {
                if (t.Codigo == codigobuscado)
                    return Turnos.Remove(t);
            }
            return false;
        }


        /// <summary>
        /// Borrar un turno a partir de su código
        /// Lanza excepción si no se puede borrar el turno
        /// </summary>
        /// <param name="codigobuscado">Código del turno que se desea borrar </param>
        public void BorraTurno(int codigobuscado) {
            bool borrado = false;

            foreach (Turno t in turnos) {
                if (t.Codigo == codigobuscado) {
                    borrado = Turnos.Remove(t);
                    break;
                }
            }

            if (!borrado)
                throw new MissingMemberException("No existe el turno que se desea borrar.");
        }


        /// <summary>
        /// Indica si la actividad es académica
        /// </summary>
        /// <returns>Devuelve TRUE si es académica y FALSE en caso contrario</returns>
        public bool EsAcademica()
        {
            Type tipo = GetType();
            string s = tipo.ToString();

            if (s == "Taimer.Actividad_a")
                return true;
            else
                return false;
        }


        /// <summary>
        /// Indica si la actividad es personal
        /// </summary>
        /// <returns>Devuelve TRUE si es personal y FALSE en caso contrario </returns>
        public bool EsPersonal()
        {
            Type tipo = GetType();
            string s = tipo.ToString();

            if (s == "Taimer.Actividad_p")
                return true;
            else
                return false;
        }


        #endregion
    }
}
