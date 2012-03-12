using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer
{
    public class Profesor
    {
        // PARTE PRIVADA ******************************************************************
        string codigo;              // Clave principal
        string nombre;
        string dni;
        string departamento;
        private List<string> actividadesAcademicas = new List<string>();    // Un prof. pertenece a (0,N) act. acad.

        //private List<string> turnos = new List<string>();                 // Un prof. pertenece a (0,N) turnos (ELIMINADO)

        // PARTE PÚBLICA ******************************************************************
        
        // Constructor
        public Profesor(string cod_, string nom_, string dni_, string dep_) {
            codigo = cod_;
            nombre = nom_;
            dni = dni_;
            departamento = dep_;
        }
        

        // Ajustar/obtener código
        public string Codigo {
            get { return codigo; }
            set { codigo = value; }     // Habrá que hacer una comprobación para que no se repitan (Clave principal)
        }


        // Ajustar/obtener nombre
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        // Ajustar/obtener DNI
        public string Dni {
            get { return dni; }
            set { dni = value; }
        }


        // Ajustar/obtener departamento
        public string Departamento {
            get { return departamento; }
            set { departamento = value; }
        }


        // Añadir actividad académica a la lista
        public void AddActividadAcademica(string activ) {
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



        // Profesores y turnos (ELIMINADO)

        /*
        // Añadir turno a la lista
        public void AddTurno(string turno)
        {
            turnos.Add(turno);
        }


        // Borrar turno de la lista (a partir de su código)
        // Devuelve TRUE si consigue encontrarla y borrarla, FALSE en caso contrario.
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
        */
    }
}
