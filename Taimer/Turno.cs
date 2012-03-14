// Este archivo define las clases Hora y Turno.

//TODO: funcion de nº de turnos almacenados
//TODO: Constructor con código?

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Taimer {

    #region CLASE HORA
   
    public class Hora {

        #region PARTE PRIVADA

        private int hora;
        private int min;

        #endregion

        #region PARTE PÚBLICA

        // Constructor
        public Hora(int hora_, int min_) {
            Hor = hora_;
            Min = min_;
        }

        // Constructor de copia
        public Hora(Hora h) {
            hora = h.hora;
            min = h.min;
        }

        //Obtener/modificar hora
        public int Hor {
            set {
                if (value >= 0 && value <= 23)
                    hora = value;
                else
                    throw new ArgumentOutOfRangeException(); 
            }
            get { return hora; }
        }

        //Obtener/modificar minutos
        public int Min {
            set {
                if (value >= 0 && value <= 59)
                    min = value;
                else
                    throw new ArgumentOutOfRangeException(); 
            }
            get { return min; }
        }


        // Ajustar hora y minutos
        public void setTiempo(int hora_, int min_){
            Hor = hora_;
            Min = min_;
        }

        //Ajustar hora y minutos a partir de un string
        public Hora(string hora_) {
            string[] vect = hora_.Split(':');
            if (vect.Length == 2) {
               hora = Convert.ToInt32(vect[0]);
               min = Convert.ToInt32(vect[1]);
            }
        }

        // Operador ==
        public static bool operator ==(Hora hor1, Hora hor2) {
            return (hor1.hora == hor2.hora && hor1.min == hor2.min);
        }

        //Operador !=
        public static bool operator !=(Hora hor1, Hora hor2) {
            return !(hor1==hor2);
        }

        //Operador <
        public static bool operator<(Hora hor1,Hora Hor2){
            bool menor = false;
            if (hor1.hora < Hor2.hora) {
                menor = true;
            } else if (hor1.hora == Hor2.hora && hor1.min < Hor2.min) {
                menor = true;
            }
            return menor;
        }

        //Operador >
        public static bool operator >(Hora hor1, Hora Hor2) {
            bool mayor = false;
            if (hor1.hora > Hor2.hora) {
                mayor = true;
            } else if (hor1.hora == Hor2.hora && hor1.min > Hor2.min) {
                mayor = true;
            }
            return mayor;
        }

        //Operador <=
        public static bool operator <=(Hora h1, Hora h2)
        {
            if (h1 < h2 || h1 == h2)
                return true;
            else
                return false;
        }

        //Operador >=
        public static bool operator >=(Hora h1, Hora h2)
        {
            if (h1 > h2 || h1 == h2)
                return true;
            else
                return false;
        }

        //Operator -
        public static Hora operator -(Hora h1, Hora h2)
        {
            Hora resultado = new Hora(0, 0);
            if (h1 < h2)
                throw new Exception("Orden de los operandos invertido");
            else
            {
                throw new NotImplementedException();
            }
        }


        public string toString() {
            string hr = hora.ToString();
            string mn = min.ToString();
            if (hora < 10)
                hr = "0" + hr;
            if (min < 10)
                mn = "0" + mn;
            return hr + ":" + mn;
        }

        #endregion
    }

    #endregion

    #region CLASE TURNO
    public class Turno {

        #region PARTE PRIVADA

        private int codigo;
        private Hora horaInicio;
        private Hora horaFin;
        private char diasemana;
        private string nombre;
        private string ubicacion;

        #endregion

        #region PARTE PÚBLICA

        // Constructor
        public Turno(/*int codigo_,*/ Hora horaI_, Hora horaF_, char dia_, string nom_, string ubic_) {
            //codigo = codigo_;
            codigo = 0;
            horaInicio = horaI_;
            horaFin = horaF_;
            diasemana = dia_;
            nombre = nom_;
            ubicacion = ubic_;
        }

        // Constructor de copia
        public Turno(Turno t) {
            codigo = t.codigo;
            horaInicio = t.horaInicio;
            horaFin = t.horaFin;
            diasemana = t.diasemana;
            nombre = t.nombre;
            ubicacion = t.ubicacion;
        }

        //Cambiar/obtener codigo
        public int Codigo {
            set { codigo = value; }
            get { return codigo; }
        }

        // Cambiar Hora Inicio
        public void HoraI(int hora, int min) {
            horaInicio = new Hora(hora, min);
        }

        // Cambiar Hora Fin
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
            set { horaFin = value; }
            get { return horaFin; }
        }


        //Obtener/Cambiar dia de la semana
        public char Dia{
            get { return diasemana; }
            set {
                char d = value.ToString().ToUpper().ToCharArray()[0];
                if (d == 'L' || d == 'M' || d == 'X' || d == 'J' || d == 'V' || d == 'S' || d == 'D')
                    diasemana = d;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        //Cambiar/Obtener nombre
        public string Nombre {
            set { nombre = value; }
            get { return nombre; }
        }

        // Cambiar/Obtener ubicacion
        public string Ubicacion {
            set { ubicacion = value; }
            get { return ubicacion; }
        }

        // **** EXTRAS (En construcción) ****
        #endregion
    }
    #endregion
}