using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class User {

        // PARTE PRIVADA ******************************************************************

        private string nombre;
        private string dni;
        private string email;
        private string password;
        private int curso;
        private string codTitulacion;                                   // Un usuario tiene (1,1) titulaciones
        private List<string> actividades = new List<string>();          // Un usuario tiene (0,N) actividades
        private List<string> comentarios = new List<string>();          // Un usuario escribe (0,N) comentarios
        private List<int> horarios = new List<int>();                   // Un usuario tiene (0,N) horarios


        // PARTE PÚBLICA ******************************************************************
        
        // Constructor
        public User(string nom_, string dni_, string email_, string pass_, string codTitulacion_, int curso_) {
            nombre = nom_;
            dni = dni_;
            password = pass_;
            email = email_;
            codTitulacion = codTitulacion_;
            curso = curso_;
        }


        // Cambiar/obtener nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        // Cambiar/obtener DNI
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }


        // Cambiar/obtener e-mail
        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        // Cambiar/obtener contraseña
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        // Cambiar/obtener código de la titulación
        public string CodTitulacion
        {
            get { return codTitulacion; }
            set { codTitulacion = value; }
        }


        // Cambiar/obtener número de curso
        public int Curso
        {
            get { return curso; }
            set { curso = value; }
        }


        // Añadir actividad
        public void AddActividad(string actividad) {
            actividades.Add(actividad);
        }


        // Borrar actividad (a partir de su código, si se encuentra)
        public bool BorraActividad(string codigobuscado) {
            foreach (string act in actividades) {
                if(act == codigobuscado) {
                    actividades.Remove(act);
                    return true;
                }
            }

            return false;
        }


        // Añadir comentario
        public void AddComentario(string comentario)
        {
            comentarios.Add(comentario);
        }


        // Borrar comentario (a partir de su código, si se encuentra)
        public bool BorraComentario(string codigobuscado)
        {
            foreach (string com in comentarios)
            {
                if (com == codigobuscado)
                {
                    comentarios.Remove(com);
                    return true;
                }
            }

            return false;
        }




        // Añadir horario
        public void AddHorario(int horario) {
            horarios.Add(horario);
        }


        // Borrar horario (a partir de su identificador ID)
        public bool BorrarHorario (int idbuscado) {
            foreach (int hor in horarios) {
                if(hor == idbuscado) {
                    horarios.Remove(hor);
                    return true;
                }
            }

            return false;
        }
    }
}
