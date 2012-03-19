// La función con el número de turnos almacenados no es necesaria. Basta con usar listadeturnos.Count();
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



        // Constructor SIN ACTIVIDAD NI CÓDIGO (borrar al terminar, hecho por compatibilidad)
        public Turno(Hora horaI_, Hora horaF_, dias dia_, string ubic_) {
            codigo = proximoId; //HAY QUE AUTOGENERALO!!!
            proximoId++;
            if (horaI_ < horaF_) {
                horaInicio = horaI_;
                horaFin = horaF_;
            }
            else
                throw new Exception("horaI >  horaF");

            diasemana = dia_;
            ubicacion = ubic_;
        }


        // Constructor
        public Turno(int cod_, Hora horaI_, Hora horaF_, dias dia_, string ubic_, Actividad act_) {
            codigo = cod_;    // Autogenerado (se debe incrementar el código de usuario después de esto)


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
            set { char d = value.ToString().ToUpper().ToCharArray()[0];
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
        }


        // Cambiar/Obtener ubicacion
        public string Ubicacion {
            set { ubicacion = value; }
            get { return ubicacion; }
        }

        #endregion
    }


    // Comparador de turnos (para saber qué turno empieza antes)
    public class TurnoComparer : IComparer<Turno>
    {
        public int Compare(Turno x, Turno y)
        {
            if (x.HoraInicio < y.HoraInicio)
                return -1;                   // x es "menor", empieza antes.
            else if (x.HoraInicio == y.HoraInicio)
                return 0;                    // x e y son "iguales", empiezan a la misma hora.

            return 1;   // x es "mayor", empieza después.
        }
    }
}