using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Taimer;

namespace Taimer {
    public class User {

        #region PARTE PRIVADA

        private string nombre;
        private string dni;
        private string email;
        private string password;
        private int curso;
        private Titulacion titulacion;                                   // Un usuario tiene (1,1) titulaciones
        private List<Actividad> actividades = new List<Actividad>();          // Un usuario tiene (0,N) actividades
        private List<Comentario> comentarios = new List<Comentario>();          // Un usuario escribe (0,N) comentarios
        private List<Horario> horarios = new List<Horario>();                   // Un usuario tiene (0,N) horarios

        #endregion

        #region PARTE PÚBLICA

        // Constructor
        public User(string nom_, string dni_, string email_, string pass_, Titulacion titulacion_, int curso_) {
            nombre = nom_;
            dni = dni_;
            password = pass_;
            email = email_;
            titulacion = titulacion_;
            curso = curso_;
        }

        // Constructor de copia
        public User(User u) {
            dni = u.dni;
            nombre = u.nombre;
            email = u.email;
            password = u.password;
            curso = u.curso;
            titulacion = u.titulacion;
            actividades = u.actividades;
            comentarios = u.comentarios;
            horarios = u.horarios;
        }


        // Cambiar/obtener nombre
        public string Nombre {
            get { return nombre; }
            set { nombre = value; }
        }


        // Cambiar/obtener DNI
        public string DNI {
            get { return dni; }
            set { dni = value; }
        }


        // Cambiar/obtener e-mail
        public string Email {
            get { return email; }
            set { email = value; }
        }


        // Cambiar/obtener contraseña
        public string Password {
            get { return password; }
            set { password = value; }
        }


        // Cambiar/obtener código de la titulación
        public Titulacion CodTitulacion {
            get { return titulacion; }
            set { titulacion = value; }
        }


        // Cambiar/obtener número de curso
        public int Curso {
            get { return curso; }
            set { curso = value; }
        }


        //Cambiar/obtener actividades
        public List<Actividad> Actividades {
            set { actividades = value; }
            get { return actividades; }
        }

        // Añadir actividad
        public void AddActividad(Actividad actividad) {
            actividades.Add(actividad);
        }


        // Borrar actividad (a partir de su código, si se encuentra)
        public bool BorraActividad(int codigobuscado) {
            foreach (Actividad act in actividades) {
                if(act.Codigo == codigobuscado) 
                    return actividades.Remove(act);
            }
            return false;
        }


        //Cambiar/Obtener Comentarios
        public List<Comentario> Comentarios {
            set { comentarios = value; }
            get { return comentarios; }
        }


        // Añadir comentario
        public void AddComentario(Comentario comentario) {
            comentarios.Add(comentario);
        }


        // Borrar comentario (a partir de su código, si se encuentra)
        public bool BorraComentario(int id) {
            foreach (Comentario com in comentarios) {
                if (com.ID == id) 
                    return comentarios.Remove(com);
            }

            return false;
        }

        //Cambiar/Obtener horarios
        public List<Horario> Horarios {
            set { horarios = value; }
            get { return horarios; }
        }


        // Añadir horario
        public void AddHorario(Horario horario) {
            horarios.Add(horario);
        }


        // Borrar horario (a partir de su identificador ID)
        public bool BorrarHorario (int idbuscado) {
            foreach (Horario hor in horarios) {
                if(hor.ID == idbuscado) 
                    return horarios.Remove(hor);
            }
            return false;
        }

        #endregion
    }
}
