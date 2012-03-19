using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {

    public class Hora {
        #region PARTE PRIVADA

        private int hora;
        private int min;

        #endregion

        #region PARTE PÚBLICA

        //Constructor por defecto
        public Hora() {
            hora = 0;
            min = 0;
        }

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
        public void setTiempo(int hora_, int min_) {
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


        // Saber cuántos minutos de diferencia hay de la hora 1 a la hora 2
        public int MinutosDeDiferencia(Hora h1, Hora h2) {
            int minutos1 = h1.Hor * 60 + h1.Min;
            int minutos2 = h2.Hor * 60 + h2.Min;
            return (minutos2 - minutos1);
        }


        // Operador ==
        public static bool operator ==(Hora hor1, Hora hor2) {
            return (hor1.hora == hor2.hora && hor1.min == hor2.min);
        }


        //Operador !=
        public static bool operator !=(Hora hor1, Hora hor2) {
            return !(hor1 == hor2);
        }


        //Operador <
        public static bool operator <(Hora hor1, Hora Hor2) {
            bool menor = false;
            if (hor1.hora < Hor2.hora) {
                menor = true;
            }
            else if (hor1.hora == Hor2.hora && hor1.min < Hor2.min) {
                menor = true;
            }
            return menor;
        }


        //Operador >
        public static bool operator >(Hora hor1, Hora Hor2) {
            bool mayor = false;
            if (hor1.hora > Hor2.hora) {
                mayor = true;
            }
            else if (hor1.hora == Hor2.hora && hor1.min > Hor2.min) {
                mayor = true;
            }
            return mayor;
        }


        //Operador <=
        public static bool operator <=(Hora h1, Hora h2) {
            if (h1 < h2 || h1 == h2)
                return true;
            else
                return false;
        }


        //Operador >=
        public static bool operator >=(Hora h1, Hora h2) {
            if (h1 > h2 || h1 == h2)
                return true;
            else
                return false;
        }


        //Operator -
        public static Hora operator -(Hora h1, Hora h2) {
            Hora resultado = new Hora(0, 0);
            if (h1 < h2)
                throw new Exception("Orden de los operandos invertido");
            else {
                //throw new NotImplementedException();
                resultado.Hor = h1.Hor - h2.Hor;
                resultado.Min = h1.Min - h2.Min;
            }
            return resultado;
        }

        // Devuelve el tiempo en minutos entre h1 y h2, h1-h2
        public static int diff(Hora h1, Hora h2)
        {
            int resultado = 0;
            if (h1 < h2)
                throw new Exception("Orden de los operandos invertido");
            else
            {
                //throw new NotImplementedException();
                resultado += (h1.Hor - h2.Hor)*60;
                resultado += h1.Min - h2.Min;
            }
            return resultado;
        }

        //Operator +
        public static Hora operator +(Hora h1, Hora h2) {
            Hora h = new Hora();
            h.Hor = h1.hora + h2.hora;
            h.Min = h1.min + h2.min;
            return h;
        }

        //Convertir a minutos
        public int toMin() {
            return hora * 60 + min;
        }

        //Convertir a string
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
}
