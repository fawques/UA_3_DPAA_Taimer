using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    abstract class Actividad {

        // PARTE PRIVADA ******************************************************************

        private int codigo;                                     // Clave principal
        private string nombre;
        private string descripcion;


        // PARTE PÚBLICA ******************************************************************

        // Constructor
        public Actividad(string nom_, string desc_, int cod_) {
            nombre = nom_;
            descripcion = desc_;
            codigo = cod_;
        }


        // Cambiar/obtener nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        // Cambiar/obtener descripción
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        // Cambiar/obtener código
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
    }
}
