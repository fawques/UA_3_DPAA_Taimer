using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class Hora {
        public int hora;
        public int min;
        public Hora(int hora_, int min_) {
            hora = hora_;
            min = min_;
        }

        public static bool operator >(Hora h1, Hora h2)
        {
            if(h1.hora > h2.hora)
                return true;
            else if (h1.hora == h2.hora)
            {
                if(h1.min > h2.min)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator ==(Hora h1, Hora h2)
        {
            if (h1.hora == h2.hora){
                if (h1.min == h2.min)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public static bool operator !=(Hora h1, Hora h2)
        {
            if (h1 == h2)
                return false;
            else
                return true;
        }

        public static bool operator <(Hora h1, Hora h2)
        {
            if (h1 > h2 || h1 == h2)
                return false;
            else
                return true;
        }

        public static bool operator <=(Hora h1, Hora h2)
        {
            if (h1 < h2 || h1 == h2)
                return true;
            else
                return false;
        }

        public static bool operator >=(Hora h1, Hora h2)
        {
            if (h1 > h2 || h1 == h2)
                return true;
            else
                return false;
        }

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

    }

    public class Turno {
        
        //PARTE PRIVADA

        private Hora horaI;
        private Hora horaF;
        char dia;
        string nom;
        string ubic;

        //PARTE PUBLICA

        //Constructor
        public Turno(Hora horaI_, Hora horaF_, char dia_, string nom_, string ubic_)
        {
            horaI = horaI_;
            horaF = horaF_;
            dia = dia_;
            nom = nom_;
            ubic = ubic_;
        }

        //Cambiar Hora Inicio
        public void setHoraI(Hora horaI_) {
            horaI = horaI_;
        }

        //Cambiar Hora Inicio
        public void setHoraI(int hora, int min) {
            horaI = new Hora(hora, min);
        }

        //Cambiar Hora Fin
        public void setHoraF(Hora horaF_) {
            horaF = horaF_;
        }

        //Cambiar Hora Fin
        public void setHoraF(int hora, int min) {
            horaF = new Hora(hora, min);
        }

        //Cambiar día de la semana
        public void setDia(char dia_) {
            dia = dia_;
        }

        //Cambiar nombre
        public void setNom(string nom_) {
            nom = nom_;
        }

        //Cambiar ubicacion
        public void setUbic(string ubic_) {
            ubic = ubic_;
        }

        //Obtener Hora de inicio
        public Hora getHoraI() {
            return horaI;
        }

        //Obtener Hora de fin
        public Hora getHoraF() {
            return horaF;
        }

        //Obtener dia de la semana
        public char getDia() {
            return dia;
        }

        //Obtener nombre
        public string getNom() {
            return nom;
        }

        //Obtener nombre del profesor
        public string getNomProf() {    //Cuando este la base de datos se accederá
            string nomProf = "";        // y con el código obtendremos el nombre
            return nomProf;
        }
    }
}