using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class Titulacion {

        // PARTE PRIVADA

        private string codigo;                                              // Clave principal
        private string nombre;
        private List<string> actividadesAcademicas = new List<string>();    // Una titulación tiene (0,N) act. académicas
        private List<string> usuarios = new List<string>();                 // Una titulación tiene (0,N) usuarios


        // PARTE PUBLICA

        // Constructor básico
        public Titulacion(string nom_, string cod_)
        {
            nombre = nom_;
            codigo = cod_;
        }


        // Constructor avanzado
        public Titulacion(string nom_, string cod_, List<string> actAcam_, List<string> usu_) {
            nombre = nom_;
            codigo = cod_;
            actividadesAcademicas = actAcam_;
            usuarios = usu_;
        }


        // Ajustar/obtener nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        // Ajustar/obtener código
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        // Añadir actividad académica a la lista
        public void AddActividadAcademica(string activ)
        {
            actividadesAcademicas.Add(activ);
        }


        // Borrar actividad académica de la lista (a partir de su código)
        // Devuelve TRUE si consigue encontrarla y borrarla, FALSE en caso contrario.
        public bool BorraActividadAcademica(string codigobuscado)
        {
            foreach (string act in actividadesAcademicas)
            {
                if (act == codigobuscado)
                {
                    actividadesAcademicas.Remove(act);
                    return true;
                }
            }

            return false;
        }


        // Añadir usuario a la lista
        public void AddUsuario(string usu)
        {
            usuarios.Add(usu);
        }


        // Borrar usuario de la lista (a partir de su código)
        // Devuelve TRUE si consigue encontrarla y borrarla, FALSE en caso contrario.
        public bool BorraUsuario(string codigobuscado)
        {
            foreach (string usu in usuarios)
            {
                if (usu == codigobuscado)
                {
                    usuarios.Remove(usu);
                    return true;
                }
            }

            return false;
        }
    }
}
