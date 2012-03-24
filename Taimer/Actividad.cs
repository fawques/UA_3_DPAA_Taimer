using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    abstract public class Actividad {

        #region PARTE PROTECTED

        protected string codigo;                                     // Clave principal
        protected string nombre;
        protected string descripcion;
        protected List<Turno> turnos = new List<Turno>();
        protected int codigoturno;

        // Codificar turno (asignarle el código correspondiente)
        protected void AsignarCodigo(Turno t) {
            t.Codigo = codigoturno;
            codigoturno++;
        }

        #endregion

        #region PARTE PÚBLICA

        // Constructor
        public Actividad(string nom_, string desc_, string cod_) {
            nombre = nom_;
            descripcion = desc_;
            codigo = cod_;
            codigoturno = 1;
        }


        // Constructor
        public Actividad(string nom_, string desc_, string cod_, List<Turno> turnos_)
        {
            nombre = nom_;
            descripcion = desc_;
            codigo = cod_;
            turnos = new List<Turno>(turnos_);
            codigoturno = 1;
        }

        // Constructor de copia
        public Actividad(Actividad act) {
            nombre = act.nombre;
            descripcion = act.descripcion;
            codigo = act.codigo;
            turnos = new List<Turno>(act.turnos);
            codigoturno = act.codigoturno;
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
        public string Codigo {
            get { return codigo; }
            set { codigo = value; }
        }




        // *** FUNCIONES SOBRE LA LISTA DE TURNOS ***


        // Cambiar/obtener lista de turnos
        public List<Turno> Turnos {
            set {
                foreach (Turno t in value) {
                    AsignarCodigo(t);
                    turnos.Add(t);
                }
            }
            get { return turnos; }
        }


        // Borrar turno (booleano)
        // Devuelve TRUE si consigue borrar el turno, FALSE en caso contrario
        public bool BorraTurnoBool(Turno turno) {
            return Turnos.Remove(turno);
        }


        // Borrar turno (excepción)
        // Lanza una excepción si no consigue borrar el turno
        public void BorraTurno(Turno turno) {
            bool borrado = Turnos.Remove(turno);

            if (!borrado)
                throw new MissingMemberException("No existe el turno que se desea borrar.");
        }

        // Borrar turno (a partir de su código, si se encuentra) (boolean)
        // Devuelve TRUE si consigue borrar el turno, FALSE en caso contrario
        public bool BorraTurnoBool(int codigobuscado) {
            foreach (Turno t in turnos) {
                if (t.Codigo == codigobuscado)
                    return Turnos.Remove(t);
            }
            return false;
        }


        // Borrar turno (a partir de su código, si se encuentra) (excepción)
        // Lanza una excepción si no consigue borrar el turno
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


        // Averiguar si es una actividad académica
        public bool EsAcademica()
        {
            Type tipo = GetType();
            string s = tipo.ToString();

            if (s == "Taimer.Actividad_a")
                return true;
            else
                return false;
        }


        // Averiguar si es una actividad personal
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
