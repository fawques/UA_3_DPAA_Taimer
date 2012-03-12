// Este archivo define las clases Hora y Turno.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// ¡BETA!


namespace Taimer {
    class Hora {

        // PARTE PRIVADA ******************************************************************
        private int hora;
        private int min;


        // PARTE PÚBLICA ******************************************************************

        // Constructor
        public Hora(int hora_, int min_) {
            setHora(hora_);
            setMin(min_);
        }

        // Devolver hora
        public int getHora(){
            return hora;
        }

        // Devolver minutos
        public int getMin(){
            return min;
        }

        // Ajustar hora
        public void setHora(int hora_){
            if (hora_ >= 0 && hora_ <= 23)
                hora = hora_;
            else
                throw new ArgumentOutOfRangeException();    // ¿Error?
        }

        // Ajustar minutos
        public void setMin(int min_){
            if (min_ >= 0 && min_ <= 59)
                min = min_;
            else
                throw new ArgumentOutOfRangeException();    // ¿Error?
        }

        // Ajustar hora y minutos
        public void setTiempo(int hora_, int min_){
            setHora(hora_);
            setMin(min_);
        }
    }


    class Turno {

        // PARTE PRIVADA ******************************************************************

        private Hora horaInicio;
        private Hora horaFin;
        int diasemana;                    // Día de la semana: 1 es lunes, 7 es domingo
        string nombre;
        string ubicacion;
        int codigoProfesor;

        // PARTE PÚBLICA ******************************************************************

        // Constructor
        public Turno(Hora horaI_, Hora horaF_, char dia_, string nom_, string ubic_, int codProf_) {
            horaInicio = horaI_;
            horaFin = horaF_;
            diasemana = dia_;
            nombre = nom_;
            ubicacion = ubic_;
            codigoProfesor = codProf_;
        }




        // Cambiar Hora Inicio
        public void setHoraInicio(int hora, int min) {
            horaInicio = new Hora(hora, min);
        }

        // Obtener Hora de inicio
        public Hora getHoraInicio()
        {
            return horaInicio;
        }




        // Cambiar Hora Fin
        public void setHoraFin(int hora, int min) {
            horaFin = new Hora(hora, min);
        }

        // Obtener Hora de fin
        public Hora getHoraFin()
        {
            return horaFin;
        }




        // Cambiar día de la semana
        public void setDia(int dia_) {
            if(dia_ >= 1 && dia_ <= 7)
                diasemana = dia_;
            else
                throw new ArgumentOutOfRangeException();    // ¿Error?
        }

        // Obtener dia de la semana
        public int getDia() {
            return diasemana;
        }




        // Cambiar nombre
        public void setNombre(string nom_) {
            nombre = nom_;
        }

        // Obtener nombre
        public string getNombre()
        {
            return nombre;
        }




        // Cambiar ubicacion
        public void setUbicacion(string ubic_) {
            ubicacion = ubic_;
        }

        // Obtener ubicación
        public string getUbicacion() {
            return ubicacion;
        }




        //Cambiar Codigo del profesor
        public void setCodigoProfesor(int codProf_) {
            codigoProfesor = codProf_;
        }

        //Obtener codigo del profesor
        public int getCodigoProfesor() {
            return codigoProfesor;
        }




        // **** EXTRAS (En construcción) ****

        // Obtener nombre del profesor
        public string getNombreProfesor() {
            return "";
        }
    }
}
