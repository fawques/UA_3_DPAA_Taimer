using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    abstract public class Actividad {

        #region PARTE PROTECTED

        protected int codigo;                                     // Clave principal
        protected string nombre;
        protected string descripcion;

        #endregion

        #region PARTE PÚBLICA

        // Constructor
        public Actividad(string nom_, string desc_, int cod_) {
            nombre = nom_;
            descripcion = desc_;
            codigo = cod_;
        }

        public Actividad(Actividad act) {
            nombre = act.nombre;
            descripcion = act.descripcion;
            codigo = act.codigo;
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
        public int Codigo {
            get { return codigo; }
            set { codigo = value; }
        }

        #endregion
    }
}
