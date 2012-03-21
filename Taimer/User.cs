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
        private string titulacion;
        int codActP;
        int codHorarios;
        private List<Actividad_a> actAcademicas = new List<Actividad_a>();          // Un usuario tiene (0,N) actividades académicas
        private List<Actividad_p> actPersonales = new List<Actividad_p>();          // Un usuario tiene (0,N) actividades personales
        private List<Horario> horarios = new List<Horario>();                       // Un usuario tiene (0,N) horarios

        #endregion

        #region PARTE PÚBLICA

        // Constructor básico (sin listas)
        public User(string nom_, string dni_, string email_, string pass_, int curso_, string tit_) {
            codActP = 0;
            codHorarios = 0;
            nombre = nom_;
            dni = dni_;
            password = pass_;
            email = email_;
            curso = curso_;
            titulacion = tit_;
        }


        // Constructor avanzado (con listas)
        public User(string nom_, string dni_, string email_, string pass_, int curso_, string tit_, List<Actividad_a> acta_, List<Actividad_p> actp_, List<Horario> hor_){
            codActP = actp_.Count;
            codHorarios = hor_.Count;

            for (int i = 0; i < actp_.Count; i++)
                actp_[i].Codigo = i;

            for (int i = 0; i < hor_.Count; i++)
                hor_[i].ID = i;

            codHorarios = 0;
            nombre = nom_;
            dni = dni_;
            password = pass_;
            email = email_;
            curso = curso_;
            titulacion = tit_;
            actAcademicas = acta_;
            actPersonales = actp_;
            horarios = hor_;
        }


        // Constructor de copia
        public User(User u) {
            codActP = u.codActP;
            codHorarios = u.codHorarios;
            dni = u.dni;
            nombre = u.nombre;
            email = u.email;
            password = u.password;
            curso = u.curso;
            actAcademicas = new List<Actividad_a>(u.actAcademicas);
            actPersonales = new List<Actividad_p>(u.actPersonales);
            horarios = new List<Horario>(u.horarios);
            titulacion = u.titulacion;
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


        // Cambiar/obtener número de curso
        public int Curso {
            get { return curso; }
            set { curso = value; }
        }

        //Cambiar/Obtener titulacion
        public string Titulacion {
            set { titulacion = value; }
            get { return titulacion; }
        }

        //Cambiar/Obtener último codigo de actividad personal
        public int CodActP {
            set { codActP = value; }
            get { return codActP; }
        }

        //Cambiar/Obtener último codigo de los horarios guardados
        public int CodHorarios {
            set { codHorarios = value; }
            get { return codHorarios; }
        }

        //Cambiar/obtener lista de actividades académicas
        public List<Actividad_a> ActAcademicas {
            set { actAcademicas = value; }
            get { return actAcademicas; }
        }


        //Cambiar/obtener lista de actividades personales
        public List<Actividad_p> ActPersonales
        {
            set { actPersonales = value; }
            get { return actPersonales; }
        }


        // Añadir actividad académica
        public void AddActAcademica(Actividad_a act) {
            actAcademicas.Add(act);
        }


        // Borrar actividad académica (si existe). Devuelve valor booleano.
        public bool BorraActAcademica(Actividad_a act) {
            return actAcademicas.Remove(act);
        }


        // Añadir actividad personal
        public void AddActPersonal(Actividad_p act)
        {
            actPersonales.Add(act);
        }


        // Borrar actividad personal (si existe). Devuelve valor booleano.
        public bool BorraActPersonal(Actividad_p act)
        {
            return actPersonales.Remove(act);
        }


        // Cambiar/Obtener horarios
        public List<Horario> Horarios {
            set { horarios = value; }
            get { return horarios; }
        }


        // Añadir horario
        public void AddHorario(Horario horario) {
            horarios.Add(horario);
        }


        // Borrar horario
        public bool BorraHorario(Horario hor)
        {
            return horarios.Remove(hor);
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
