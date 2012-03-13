using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class Titulacion {

        #region PARTE PRIVADA

        private string codigo;                                              // Clave principal
        private string nombre;
        private List<Actividad_a> actividadesAcademicas = new List<Actividad_a>();    // Una titulación tiene (0,N) act. académicas
        private List<User> usuarios = new List<User>();                             // Una titulación tiene (0,N) usuarios


        #endregion

        #region PARTE PUBLICA

        // Constructor básico
        public Titulacion(string nom_, string cod_) {
            nombre = nom_;
            codigo = cod_;
        }

        // Constructor avanzado
        public Titulacion(string nom_, string cod_, List<Actividad_a> actAcam_, List<User> usu_) {
            nombre = nom_;
            codigo = cod_;
            actividadesAcademicas = actAcam_;
            usuarios = usu_;
        }

        // Constructor por defecto
        public Titulacion(Titulacion t) {
            codigo = t.codigo;
            nombre = t.nombre;
            actividadesAcademicas = t.actividadesAcademicas;
            usuarios = t.usuarios;
        }


        // Ajustar/obtener nombre
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        // Ajustar/obtener código
        public string Codigo {
            get { return codigo; }
            set { codigo = value; }
        }


        //Cambiar/Obetener Actividades academicas

        public List<Actividad_a> ActividadesAcademicas {
            set { actividadesAcademicas = value; }
            get { return actividadesAcademicas; }
        }

        // Añadir actividad académica a la lista
        public void AddActividadAcademica(Actividad_a activ) {
            actividadesAcademicas.Add(activ);
        }


        // Borrar actividad académica de la lista (a partir de su código)
        // Devuelve TRUE si consigue encontrarla y borrarla, FALSE en caso contrario.
        public bool BorraActividadAcademica(int codigobuscado) {
            foreach (Actividad_a act in actividadesAcademicas) {
                if (act.Codigo == codigobuscado)
                    return actividadesAcademicas.Remove(act);
            }

            return false;
        }


        //Cambiar/Obetner Usuarios
        public List<User> Usuarios {
            set { usuarios = value; }
            get { return usuarios; }
        }

        // Añadir usuario a la lista
        public void AddUsuario(User usu) {
            usuarios.Add(usu);
        }


        // Borrar usuario de la lista (a partir de su código)
        // Devuelve TRUE si consigue encontrarla y borrarla, FALSE en caso contrario.
        public bool BorraUsuario(string dni) {
            foreach (User usu in usuarios) {
                if (usu.DNI == dni)
                    return usuarios.Remove(usu);
            }
            return false;
        }

        #endregion
    }
}
