using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    /// <summary>
    /// Clase Hora: representa una hora mediante horas y minutos
    /// </summary>
    public class Hora {
        #region PARTE PRIVADA
        /// <summary>
        /// Horas
        /// </summary>
        private int hora;

        /// <summary>
        /// Minutos
        /// </summary>
        private int min;

        #endregion

        #region PARTE PÚBLICA

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Hora() {
            hora = 0;
            min = 0;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="hora_">Horas</param>
        /// <param name="min_">Minutos</param>
        public Hora(int hora_, int min_) {
            Hor = hora_;
            Min = min_;
        }


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="hora_">Hora (las horas deben estar separadas de los minutos por ':')</param>
        public Hora(string hora_) {
            string[] vect = hora_.Split(':');
            if (vect.Length == 2) {
                Hor = Convert.ToInt32(vect[0]);
                Min = Convert.ToInt32(vect[1]);
            }
        }

        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="h"> Hora que se desea copiar</param>
        public Hora(Hora h) {
            hora = h.hora;
            min = h.min;
        }


        /// <summary>
        /// Asigna/Devuelve las horas
        /// </summary>
        public int Hor {
            set {
                if (value >= 0 && value <= 23)
                    hora = value;
                else
                    throw new ArgumentOutOfRangeException("Hora fuera de rango (debe ser entre 0 y 23).");
            }
            get { return hora; }
        }


        /// <summary>
        /// Asigna/Devuelve los minutos
        /// </summary>
        public int Min {
            set {
                if (value >= 0 && value <= 59)
                    min = value;
                else
                    throw new ArgumentOutOfRangeException("Minutos fuera de rango (deben ser entre 0 y 59).");
            }
            get { return min; }
        }


        /// <summary>
        /// Añade las horas y los minutos a la clase
        /// </summary>
        /// <param name="hora_">Horas</param>
        /// <param name="min_">Minutos</param>
        public void setTiempo(int hora_, int min_) {
            Hor = hora_;
            Min = min_;
        }


        /// <summary>
        /// Devuelve los minutos de diferencia que hay con la hora que se pasa
        /// </summary>
        /// <param name="h2">Hora con la que se quiere obtener la diferencia</param>
        /// <returns></returns>
        public int MinutosDeDiferencia(Hora h2) {
            int minutos1 = Hor * 60 + Min;
            int minutos2 = h2.Hor * 60 + h2.Min;
            return (minutos2 - minutos1);
        }


        /// <summary>
        /// Operador == 
        /// </summary>
        /// <param name="hor1">Primera hora a comparar </param>
        /// <param name="hor2">Segunda hora a comparar</param>
        /// <returns>Devuelve TRUE si son iguales FALSE en caso contrario</returns>
        public static bool operator ==(Hora hor1, Hora hor2) {
            return (hor1.hora == hor2.hora && hor1.min == hor2.min);
        }


        /// <summary>
        /// Operador != 
        /// </summary>
        /// <param name="hor1">Primera hora a comparar </param>
        /// <param name="hor2">Segunda hora a comparar</param>
        /// <returns>Devuelve TRUE si son distintas FALSE en caso contrario</returns>
        public static bool operator !=(Hora hor1, Hora hor2) {
            return !(hor1 == hor2);
        }


        /// <summary>
        /// Operador < 
        /// </summary>
        /// <param name="hor1">Primera hora a comparar </param>
        /// <param name="hor2">Segunda hora a comparar</param>
        /// <returns>Develve TRUE si hor1 es menor que hor2 y FALSE en caso contrario</returns>
        public static bool operator <(Hora hor1, Hora hor2) {
            bool menor = false;
            if (hor1.hora < hor2.hora) {
                menor = true;
            }
            else if (hor1.hora == hor2.hora && hor1.min < hor2.min) {
                menor = true;
            }
            return menor;
        }


        /// <summary>
        /// Operador > 
        /// </summary>
        /// <param name="hor1">Primera hora a comparar </param>
        /// <param name="hor2">Segunda hora a comparar</param>
        /// <returns>Devuelve TRUE si hor1 es mayor que hor2 y FALSE en caso contrario</returns>
        public static bool operator >(Hora hor1, Hora hor2) {
            bool mayor = false;
            if (hor1.hora > hor2.hora) {
                mayor = true;
            }
            else if (hor1.hora == hor2.hora && hor1.min > hor2.min) {
                mayor = true;
            }
            return mayor;
        }


        /// <summary>
        /// Operador <= 
        /// </summary>
        /// <param name="h1">Primera hora a comparar </param>
        /// <param name="h2">Segunda hora a comparar</param>
        /// <returns>Devuelve TRUE si h1 es menor o igual que h2 y FALSE en caso contrario</returns>
        public static bool operator <=(Hora h1, Hora h2) {
            if (h1 < h2 || h1 == h2)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Operador >= 
        /// </summary>
        /// <param name="h1">Primera hora a comparar </param>
        /// <param name="h2">Segunda hora a comparar</param>
        /// <returns>Devuelve TRUE si h1 es mayor o igual que h2 y FALSE en caso contrario</returns>
        public static bool operator >=(Hora h1, Hora h2) {
            if (h1 > h2 || h1 == h2)
                return true;
            else
                return false;
        }


        /// <summary>
        /// Operador -
        /// </summary>
        /// <param name="h1">Minuendo</param>
        /// <param name="h2">Sustraendo</param>
        /// <returns>Hora resultado de la resta</returns>
        public static Hora operator -(Hora h1, Hora h2) {
            Hora resultado = new Hora(0, 0);
            if (h1 < h2)
                throw new InvalidOperationException("Orden de los operandos de la hora invertido");
            else {
                //throw new NotImplementedException();
                resultado.Hor = h1.Hor - h2.Hor;
                resultado.Min = h1.Min - h2.Min;
            }
            return resultado;
        }

        /// <summary>
        /// Resta entre dos Horas, se expresa el resultado en minutos
        /// </summary>
        /// <param name="h1">Minuendo</param>
        /// <param name="h2">Sustraendo</param>
        /// <returns>Resultado expresado en minutos</returns>
        public static int diff(Hora h1, Hora h2)
        {
            int resultado = 0;
            if (h1 < h2)
                throw new InvalidOperationException("Orden de los operandos de la hora invertido");
            else
            {
                //throw new NotImplementedException();
                resultado += (h1.Hor - h2.Hor)*60;
                resultado += h1.Min - h2.Min;
            }
            return resultado;
        }

        /// <summary>
        /// Operador +
        /// </summary>
        /// <param name="h1">Primer sumando</param>
        /// <param name="h2">Segundo sumando</param>
        /// <returns>Hora resultado de la suma</returns>
        public static Hora operator +(Hora h1, Hora h2) {
            Hora h = new Hora();
            h.Hor = h1.hora + h2.hora;
            h.Min = h1.min + h2.min;
            return h;
        }

        /// <summary>
        /// Convierte el objeto Hora a minutos
        /// </summary>
        /// <returns>Hora en minutos</returns>
        public int toMin() {
            return hora * 60 + min;
        }

        /// <summary>
        /// Convierte el objeto Hora en un string
        /// </summary>
        /// <returns>string con la Hora</returns>
        public string toString() {
            string hr = hora.ToString();
            string mn = min.ToString();
            if (hora < 10)
                hr = "0" + hr;
            if (min < 10)
                mn = "0" + mn;
            return hr + ":" + mn;
        }

        // Corrección de advertencias (GetHashCode() y Object.Equals(object))
        public override bool Equals(System.Object obj) {
            // Si el parámetro es nulo, devuelve false.
            if (obj == null) {
                return false;
            }

            // Si el parámetro no puede convertirse a Hora, devuelve falso.
            Hora p = obj as Hora;
            if ((System.Object)p == null) {
                return false;
            }

            // Devuelve TRUE si los campos coinciden:
            return (Hor == p.Hor) && (Min == p.Min);
        }

        public bool Equals(Hora p) {
            // Si el parámetro es nulo, devuelve falso.
            if ((object)p == null) {
                return false;
            }

            // Devuelve TRUE si los campos coinciden:
            return (Hor == p.Hor) && (Min == p.Min);
        }

        public override int GetHashCode() {
            return Hor * 60 + Min;
        }

        #endregion
    }
}
