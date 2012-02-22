using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    class User {

        //PARTE PRIVADA

        private string nom;
        private string ape;
        private string dni;
        private string email;
        private string pass;
        private string codTitulacion;
        private int curso;
        private ArrayList activ = new ArrayList();
        private ArrayList horarios = new ArrayList();

        //PARTE PUBLICA
        
        //Constructor
        public User(string nom_, string ape_, string dni_, string email_, string pass_, string codTitulacion_, int curso_) {
            nom = nom_;
            ape =ape_;
            pass = pass_;
            email = email_;
            codTitulacion = codTitulacion_;
            curso = curso_;
        }

        //Cambiar nombre
        public void setNom(string nom_){
            nom =nom_;
        }

        //Cambiar apellidos
        public void setApe(string ape_){
            ape = ape_;
        }

        //Cambiar dni
        public void setDni(string dni_){
            dni = dni_;
        }

        //Cambiar email
        public void setEmail(string email_){
            email = email_;
        }

        //Cambiar contraseña
        public void setPass(string pass_) {
            pass = pass_;
        }

        //Cambiar el codigo de la titulacion
        public void setCodTitulacion(string codTitulacion_) {
            codTitulacion = codTitulacion_;
        }

        //Cambair el curso
        public void setCurso(int curso_) {
            curso = curso_;
        }

        //Añadir Actividad
        public void AddActividad(Actividad actividad) {
            activ.Add(actividad);
        }

        //Añadir Horario
        public void AddHorario(Horario horario) {
            horarios.Add(horario);
        }

        //Obtener nombre
        public string getNom() {
            return nom;
        }

        //Obtener apellidos
        public string getApe() {
            return ape;
        }

        //Obtener dni
        public string getDni() {
            return dni;
        }

        //Obtener email
        public string getEmail() {
            return email;
        }

        //Obtener contraseñas
        public string getPass() {
            return pass;
        }

        //Obtener codigo de titulacion
        public string getCodTitulacio() {
            return codTitulacion;
        }

        //Obtener nombre de la titulacion
        public string getNomTitulacion(){
            string nomTitulacion ="";       //Cuando este la base de datos se accederá
            return nomTitulacion;           // y con el código obtendremos el nombre
        }

        //Obtener Curso
        public int getCurso() {
            return curso;
        }

        //Obtener ArrayList de actividades
        public ArrayList getActiv() {
            return activ;
        }

        //Obtener ArrayList de horarios
        public ArrayList getHorarios() {
            return horarios;
        }
    }
}
