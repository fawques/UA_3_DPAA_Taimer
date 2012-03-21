﻿// La función con el número de turnos almacenados no es necesaria. Basta con usar listadeturnos.Count();
// El constructor con código tampoco es necesario, ya que el código se genera automáticamente al ser añadido a una lista de actividades.
// En caso de querer cambiar el código, hay una función para eso.

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Taimer {
    public enum dias { L, M, X, J, V, S, D };

    public class Turno {

        #region PARTE PRIVADA

        private int codigo;
        private Hora horaInicio;
        private Hora horaFin;
        dias diasemana;
        private string ubicacion;
        private Actividad actividad;        // Un turno pertenece a (1,1) actividades

        public static int proximoId; // guarda el siguiente turno (mantener de momento, hasta que haya un autoincremento)
        #endregion

        #region PARTE PÚBLICA


        // Constructor SIN ACTIVIDAD NI CÓDIGO (borrar al terminar, hecho por compatibilidad) ######################################
        public Turno(Hora horaI_, Hora horaF_, dias dia_, string ubic_) {
            codigo = proximoId; //HAY QUE AUTOGENERALO!!!
            proximoId++;
            if (horaI_ < horaF_) {
                horaInicio = horaI_;
                horaFin = horaF_;
            }
            else
                throw new Exception("La hora de inicio es la misma o más tarde que la hora de finalización");

            diasemana = dia_;
            ubicacion = ubic_;
        }
        // ESTE CONSTRUCTOR SE DEBE BORRAR AL TERMINAR #############################################################################


        // Constructor
        public Turno(int cod_, Hora horaI_, Hora horaF_, dias dia_, string ubic_, Actividad act_) {
            codigo = cod_;    // Autogenerado (se debe incrementar el código de usuario después de esto)


            if (horaI_ < horaF_) {
                horaInicio = horaI_;
                horaFin = horaF_;
            }
            else
                throw new Exception("La hora de inicio es la misma o más tarde que la hora de finalización");


            diasemana = dia_;
            ubicacion = ubic_;
            actividad = act_;
        }


        // Constructor de copia
        public Turno(Turno t) {
            codigo = t.codigo;
            horaInicio = new Hora(t.horaInicio);
            horaFin = new Hora(t.horaFin);
            diasemana = t.diasemana;
            ubicacion = t.ubicacion;
            actividad = t.actividad;
        }


        // Comparar si dos turnos son iguales (exceptuando su código y asignatura).
        // He preferido no usar el operador igualdad, dado que no son 100% iguales.
        public bool TurnoSimilar(Turno t)
        {
            if (horaInicio == t.horaInicio)
                if (horaFin == t.horaFin)
                    if (diasemana == t.diasemana)
                        if (ubicacion == t.ubicacion)
                            return true;

            return false;
        }


        // Cambiar/obtener actividad
        public Actividad Actividad
        {
            set { actividad = value; }
            get { return actividad; }
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
            set { diasemana = value; }
        }


        // Cambiar día de la semana con string
        public void CambiarDiaSemana(string s)
        {
            char d = s.ToString().ToUpper().ToCharArray()[0];
            switch (d) {
                    case 'L':
                        diasemana = dias.L;
                        break;
                    case 'M':
                        diasemana = dias.M;
                        break;
                    case 'X':
                        diasemana = dias.X;
                        break;
                    case 'J':
                        diasemana = dias.J;
                        break;
                    case 'V':
                        diasemana = dias.V;
                        break;
                    case 'S':
                        diasemana = dias.S;
                        break;
                    case 'D':
                        diasemana = dias.D;
                        break;
                    default:
                        throw new Exception("Día de la semana inexistente.");
                }
            }


        // Cambiar/Obtener ubicacion
        public string Ubicacion {
            set { ubicacion = value; }
            get { return ubicacion; }
        }


        // Comprobar superposición de turnos
        // Devuelve TRUE si se superponen los turnos, FALSE si no se solapan.
        public bool Superpone(Turno t)
        {
            // Si se superponen...
            if (Dia.Equals(t.Dia))
            {
                if ((HoraFin > t.HoraInicio && HoraFin <= t.HoraFin) ||
                    (t.HoraFin > HoraInicio && t.HoraFin <= HoraFin) ||
                    (HoraInicio >= t.HoraInicio && HoraInicio < t.HoraFin) ||
                    (t.HoraInicio >= HoraInicio && t.HoraInicio < HoraFin))
                {
                    return true;
                }
            }

            return false;
        }


        // Comprobar superposición y lanzar excepción si se superponen
        public void SuperponeExcepcion(Turno t)
        {
            // Si se superponen...
            if (Dia.Equals(t.Dia))
            {
                if ((HoraFin > t.HoraInicio && HoraFin <= t.HoraFin) ||
                    (t.HoraFin > HoraInicio && t.HoraFin <= HoraFin) ||
                    (HoraInicio >= t.HoraInicio && HoraInicio < t.HoraFin) ||
                    (t.HoraInicio >= HoraInicio && t.HoraInicio < HoraFin))
                {
                    NotSupportedException ex = new NotSupportedException("Turnos solapados.");
                    throw ex;
                }
            }
        }

        #endregion
    }
}