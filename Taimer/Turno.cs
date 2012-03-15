// Este archivo define las clases Hora y Turno.

//TODO: funcion de nº de turnos almacenados
//TODO: Constructor con código?

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Taimer {
    //Donde lo esta mejor dentro de la clase o fuera ¿?
    public enum dias { L, M, X, J, V, S, D };

    public class Turno {

        #region PARTE PRIVADA

        private int codigo;
        private Hora horaInicio;
        private Hora horaFin;
        dias diasemana;
        private string ubicacion;
        private Actividad actividad;        // Un turno tiene (1,1) actividades

        #endregion

        #region PARTE PÚBLICA

        //public enum dias { L, M, X, J, V, S, D };

        // Constructor SIN ACTIVIDAD (eliminar en breve, creado por compatibilidad)
        public Turno(Hora horaI_, Hora horaF_, dias dia_, string ubic_) {
            codigo = 0; //HAY QUE AUTOGENERALO!!!
            if (horaI_ < horaF_) {
                horaInicio = horaI_;
                horaFin = horaF_;
            }
            else
                throw new Exception("horaI > horaF");
            diasemana = dia_;
            ubicacion = ubic_;
        }


        // Constructor CON ACTIVIDAD
        public Turno(Hora horaI_, Hora horaF_, dias dia_, string ubic_, Actividad act_) {
            codigo = 0; //HAY QUE AUTOGENERALO!!!
            if (horaI_ < horaF_) {
                horaInicio = horaI_;
                horaFin = horaF_;
            }
            else
                throw new Exception("horaI >  horaF");
            diasemana = dia_;
            ubicacion = ubic_;
            actividad = act_;
        }


        // Constructor de copia
        public Turno(Turno t) {
            codigo = t.codigo;
            horaInicio = t.horaInicio;
            horaFin = t.horaFin;
            diasemana = t.diasemana;
            ubicacion = t.ubicacion;
            actividad = t.actividad;
        }


        // Cambiar/obtener codigo
        public int Codigo {
            set { codigo = value; }
            get { return codigo; }
        }


        // Cambiar Hora Inicio con dos Integer
        public void HoraI(int hora, int min) {
            horaInicio = new Hora(hora, min);
        }


        // Cambiar Hora Fin con dos Integer
        public void HoraF(int hora, int min) {
            horaFin = new Hora(hora, min);
        }


        // Obtener/Cambiar Hora de inicio
        public Hora HoraInicio {
            set { horaInicio = value; }
            get { return horaInicio; }
        }


        // Obtener/Cambiar Hora de Fin
        public Hora HoraFin {
            set { 
                    if(value >= HoraInicio)
                        horaFin = value;
                    else
                        throw new ArgumentOutOfRangeException();    // ¿Usar OutOfRangeException si hora fin < hora inicio?
                }

            get { return horaFin; }
        }


        // Obtener/Cambiar dia de la semana
        public dias Dia{
            get { return diasemana; }
            set {
                /*char d = value.ToString().ToUpper().ToCharArray()[0];
                if (d == 'L' || d == 'M' || d == 'X' || d == 'J' || d == 'V' || d == 'S' || d == 'D')
                    diasemana = d;*/
                    diasemana = value;
               /* else
                    throw new ArgumentOutOfRangeException();*/
            }
        }


        // Cambiar/Obtener ubicacion
        public string Ubicacion {
            set { ubicacion = value; }
            get { return ubicacion; }
        }
        #endregion
    }
}