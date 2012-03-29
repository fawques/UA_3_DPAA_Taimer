// ¡SI SE CAMBIA LA HORA DE INICIO O FIN EN UN TURNO PERSONAL, COMPROBAR SOLAPAMIENTO!

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Taimer {
    /// <summary>
    /// Enum que representa los días de la semana
    /// </summary>
    public enum dias { L, M, X, J, V, S, D };

    //Clase que he creado para funciones de este estilo que vienen muy bien y no se muy bien donde ponerlas
    public static class TaimerLibrary {
        public static string convertToString(dias d) {
            string dia = "";
            switch (d) {
                case dias.L: dia = "Lunes"; break;
                case dias.M: dia = "Martes"; break;
                case dias.X: dia = "Miércoles"; break;
                case dias.J: dia = "Jueves"; break;
                case dias.V: dia = "Viernes"; break;
                case dias.S: dia = "Sábado"; break;
                case dias.D: dia = "Domingo"; break;
            }
            return dia;
        }
        public static int convertToInt(dias d) {
            int dia = 0;
            switch (d) {
                case dias.L: dia = 0; break;
                case dias.M: dia = 1; break;
                case dias.X: dia = 2; break;
                case dias.J: dia = 3; break;
                case dias.V: dia = 4; break;
                case dias.S: dia = 5; break;
                case dias.D: dia = 6; break;
            }
            return dia;
        }
        public static dias convertToDais(string d) {

            switch (d) {
                case "Lunes":
                    return dias.L;
                case "Martes":
                    return dias.M;
                case "Miercoles":
                    return dias.X;
                case "Jueves":
                    return dias.J;
                case "Viernes":
                    return dias.V;
                case "Sabado":
                    return dias.S;
                case "Domingo":
                    return dias.D;
                default:
                    return dias.L;
            }
        }
    }

    /// <summary>
    /// Clase Turno: representa las diversas horas, localizaciones, etc que tiene una Actividad
    /// </summary>
    public class Turno {

        #region PARTE PRIVADA
        
        /// <summary>
        /// Codigo que identifica el Turno
        /// También es la clave primaria en la base de datos
        /// </summary>
        private int codigo;

        /// <summary>
        /// Hora de inicio del Turno
        /// </summary>
        private Hora horaInicio;

        /// <summary>
        /// Hora de finalización del Turno
        /// </summary>
        private Hora horaFin;

        /// <summary>
        /// Dia de la semana en que se da el Turno
        /// </summary>
        private dias diasemana;

        /// <summary>
        /// Ubicación en al que se reliza un Actividad en este Turno
        /// </summary>
        private string ubicacion;

        /// <summary>
        /// Actividad a la que pertenece este turno
        /// </summary>
        private Actividad actividad;        // Un turno pertenece a (1,1) actividades


        /// <summary>
        /// Obtener dia de la semana como string
        /// </summary>
        /// <returns>string con el dia de la semana</returns>
        private string ObtDiaString() {
            string dia = "";
            switch (diasemana) {
                case dias.L: dia = "Lunes"; break;
                case dias.M: dia = "Martes"; break;
                case dias.X: dia = "Miércoles"; break;
                case dias.J: dia = "Jueves"; break;
                case dias.V: dia = "Viernes"; break;
                case dias.S: dia = "Sábado"; break;
                case dias.D: dia = "Domingo"; break;
                default:
                    throw new MissingMemberException("El turno no tiene especificado un día de la semana.");
            }
            return dia;
        }



        /// <summary>
        /// Normaliza una cadena quitandole cualquier tipo de tilde y convirtiendola a mayúsculas
        /// </summary>
        /// <param name="s">Cadena normalizada</param>
        private void NormalizarCadena(ref string s) {
            s = s.ToLower();
            Regex a = new Regex("[á|à|ä|â]", RegexOptions.Compiled);
            Regex e = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex i = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex o = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex u = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);
            s = a.Replace(s, "a");
            s = e.Replace(s, "e");
            s = i.Replace(s, "i");
            s = o.Replace(s, "o");
            s = u.Replace(s, "u");

            s = s.ToUpper();
        }

        /// <summary>
        /// Cambia el dia de la semana del turno a partir de un string
        /// </summary>
        /// <param name="s">Dia de la semana puede ser en formato de un carácter o el nombre completo</param>
        private void CambiarDiaSemana(string s) {
            NormalizarCadena(ref s);
            if (s.Length == 1) {  //Formato de un carácter
                switch (s) {
                    case "L": Dia = dias.L; break;
                    case "M": Dia = dias.M; break;
                    case "X": Dia = dias.X; break;
                    case "J": Dia = dias.J; break;
                    case "V": Dia = dias.V; break;
                    case "S": Dia = dias.S; break;
                    case "D": Dia = dias.D; break;
                    default:
                        throw new MissingMemberException("Día de la semana inexistente.");
                }
            }
            else { //Día completo
                switch (s) {
                    case "LUNES": Dia = dias.L; break;
                    case "MARTES": Dia = dias.M; break;
                    case "MIERCOLES": Dia = dias.X; break;
                    case "JUEVES": Dia = dias.J; break;
                    case "VIERNES": Dia = dias.V; break;
                    case "SABADO": Dia = dias.S; break;
                    case "DOMINGO": Dia = dias.D; break;
                    default:
                        throw new MissingMemberException("Día de la semana inexistente.");
                }
            }
        }

        #endregion

        #region PARTE PÚBLICA


        /// <summary>
        /// Constructor (sin Actividad y sin código)
        /// Su uso es para añadirlo en una Actividad
        /// </summary>
        /// <param name="horaI_">Hora de inicio del turno</param>
        /// <param name="horaF_"> Hora en que finaliza el turno</param>
        /// <param name="dia_"> Día de la semana</param>
        /// <param name="ubic_">Ubicación en la que se realiza el turno</param>
        public Turno(Hora horaI_, Hora horaF_, dias dia_, string ubic_) {
            codigo = 0;
            CambiarHoras(horaI_, horaF_);
            diasemana = dia_;
            ubicacion = ubic_;
            actividad = null;
        }

        /// <summary>
        /// Constructor (sin Actividad y sin código)
        /// Su uso es para añadirlo en una Actividad
        /// (Modificado para admitir días de la semana por string)
        /// </summary>
        /// <param name="horaI_">Hora de inicio del turno</param>
        /// <param name="horaF_">Hora en que finaliza el turno</param>
        /// <param name="dia_">String que representa el día de la semana</param>
        /// <param name="ubic_">Ubicación en la que se realiza el turno</param>
        public Turno(Hora horaI_, Hora horaF_, string dia_, string ubic_)
        {
            codigo = 0;
            CambiarHoras(horaI_, horaF_);
            CambiarDiaSemana(dia_);
            ubicacion = ubic_;
            actividad = null;
        }
 




        /// <summary>
        /// Constructor que vincula el turno a una actividad
        /// </summary>
        /// <param name="horaI_"> Hora de inicio del Turno</param>
        /// <param name="horaF_"> Hora en que finaliza el Turno  </param>
        /// <param name="dia_"> Dia de la semana </param>
        /// <param name="ubic_"> Ubicación en la que se realiza el Turno </param>
        /// <param name="act_"> Actividad a la que pertence el Turno</param>
        public Turno(Hora horaI_, Hora horaF_, dias dia_, string ubic_, Actividad act_) {
            codigo = 0;
            CambiarHoras(horaI_, horaF_);
            diasemana = dia_;
            ubicacion = ubic_;
            actividad = act_;

            if (actividad.EsAcademica())
                ((Actividad_a)actividad).AddTurno(this);
            else 
                ((Actividad_p)actividad).AddTurno(this);
        }

        /// <summary>
        /// Constructor que vincula el turno a una actividad
        /// (Modificado para admitir días de la semana por string)
        /// </summary>
        /// <param name="horaI_"> Hora de inicio del Turno</param>
        /// <param name="horaF_"> Hora en que finaliza el Turno  </param>
        /// <param name="dia_">String que representa el día de la semana</param>
        /// <param name="ubic_"> Ubicación en la que se realiza el Turno </param>
        /// <param name="act_"> Actividad a la que pertence el Turno</param>
        public Turno(Hora horaI_, Hora horaF_, string dia_, string ubic_, Actividad act_)
        {
            codigo = 0;
            CambiarHoras(horaI_, horaF_);
            CambiarDiaSemana(dia_);
            ubicacion = ubic_;
            actividad = act_;

            if (actividad.EsAcademica())
                ((Actividad_a)actividad).AddTurno(this);
            else
                ((Actividad_p)actividad).AddTurno(this);
        }





        /// <summary>
        /// Constructor completo
        /// Uso exclusivo de los CADs
        /// </summary>
        /// <param name="cod_">Código del Turno</param>
        /// <param name="horaI_">Hora de inicio del Turno</param>
        /// <param name="horaF_">Hora en que finaliza el Turno</param>
        /// <param name="dia_">Dia de la semana</param>
        /// <param name="ubic_">Ubicación en la que se realiza el Turno</param>
        /// <param name="act_">Actividad a la que pertenece el Turno</param>
        public Turno(int cod_, Hora horaI_, Hora horaF_, dias dia_, string ubic_, Actividad act_) {
            codigo = cod_;
            CambiarHoras(horaI_, horaF_);
            diasemana = dia_;
            ubicacion = ubic_;
            actividad = act_;
        }

        /// <summary>
        /// Constructor completo
        /// Uso exclusivo de los CADs
        /// (Modificado para admitir días de la semana por string)
        /// </summary>
        /// <param name="cod_">Código del Turno</param>
        /// <param name="horaI_">Hora de inicio del Turno</param>
        /// <param name="horaF_">Hora en que finaliza el Turno</param>
        /// <param name="dia_">String que representa el día de la semana</param>
        /// <param name="ubic_">Ubicación en la que se realiza el Turno</param>
        /// <param name="act_">Actividad a la que pertenece el Turno</param>
        public Turno(int cod_, Hora horaI_, Hora horaF_, string dia_, string ubic_, Actividad act_)
        {
            codigo = cod_;
            CambiarHoras(horaI_, horaF_);
            CambiarDiaSemana(dia_);
            ubicacion = ubic_;
            actividad = act_;
        }


        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="t">Turno que se desea copiar</param>
        public Turno(Turno t) {
            codigo = t.codigo;
            horaInicio = new Hora(t.horaInicio);
            horaFin = new Hora(t.horaFin);
            diasemana = t.diasemana;
            ubicacion = t.ubicacion;
            actividad = t.actividad;
        }


        /// <summary>
        /// Indica si el propio turno es similar con otro
        /// Dos turnos son similares si: tiene la misma hora de inicio y de fin, el mismo día de la semana y la misma ubicación
        /// </summary>
        /// <param name="t">Turno con el que se quiere comparar</param>
        /// <returns>Devuelve TRUE si son similares y FALSE en caso contrario</returns>
        public bool TurnoSimilar(Turno t) {
            if (horaInicio == t.horaInicio)
                if (horaFin == t.horaFin)
                    if (diasemana == t.diasemana)
                        if (ubicacion == t.ubicacion) ///es importante la ubicación para considerarlos similares???
                            return true;

            return false;
        }


        /// <summary>
        /// Asigna/Devuelve la actividad a la que pertene el Turno
        /// </summary>
        public Actividad Actividad {
            set { actividad = value; }
            get { return actividad; }
        }


        /// <summary>
        /// Asigna/Devuelve el codigo del Turno
        /// NO RECOMENDADO USAR LA ASIGNACIÓN el código se autogenera
        /// Lanza una excepción si al asignar el código ya existe
        /// </summary>
        public int Codigo {
            set {
                    foreach (Turno existente in actividad.Turnos) {
                        if (existente.Codigo == value)
                            throw new ArgumentException("El código ya existe.");
                    }

                codigo = value;
                }

            get { return codigo; }
        }


        /// <summary>
        /// Cambia la hora de inicio a partir de dos integer
        /// </summary>
        /// <param name="hora">Horas</param>
        /// <param name="min">Minutos</param>
        public void HoraI(int hora, int min) {
            HoraInicio = new Hora(hora, min);
        }


        /// <summary>
        /// Cambia la hora de fin a partir de dos interger
        /// </summary>
        /// <param name="hora">Horas</param>
        /// <param name="min">Minutos</param>
        public void HoraF(int hora, int min) {
            HoraFin = new Hora(hora, min);
        }

        /// <summary>
        /// Cambiar Hora Inicio con un string
        /// </summary>
        /// <param name="horaI">Las horas tienen que estar separadas por ':' de los minutos</param>
        public void HoraI(string horaI) {
            HoraInicio = new Hora(horaI);
        }

        /// <summary>
        /// Cambiar Hora Fin con un string
        /// </summary>
        /// <param name="horaF">Las horas tienen que estar separadas por ':' de los minutos</param>
        public void HoraF(string horaF) {
            HoraFin = new Hora(horaF);
        }

        /// <summary>
        /// Asigna/Devuelve la Hora de Inicio
        /// </summary>
        public Hora HoraInicio {
            set {
                if (value < HoraFin) {
                    if (actividad != null) {
                        if (actividad.EsAcademica())
                            horaInicio = value;
                        else {
                            Turno test = new Turno(this);
                            test.horaInicio = value;


                            foreach (Turno existente in actividad.Turnos) {
                                if (existente.Codigo != this.Codigo) {
                                    test.Superpone(existente);
                                }
                            }

                            horaInicio = value;
                        }
                    }
                    else {
                        horaInicio = value;
                    }
                }
                else
                    throw new ArgumentOutOfRangeException("La hora de inicio no puede ser posterior a la de fin.");
            }
            get { return horaInicio; }
        }


        /// <summary>
        /// Asigna/Devuelve la Hora de fin
        /// </summary>
        public Hora HoraFin {
            set { 
                    if(value > HoraInicio) {
                        if (actividad != null) {
                            if (actividad.EsAcademica())
                                horaFin = value;
                            else {
                                Turno test = new Turno(this);
                                test.horaFin = value;

                                foreach (Turno existente in actividad.Turnos) {
                                    if (existente.Codigo != this.Codigo) {
                                        test.Superpone(existente);
                                    }
                                }


                                horaFin = value;
                            }
                        }
                        else {
                            horaFin = value;
                        }
                    }
                    else
                        throw new ArgumentOutOfRangeException("La hora de fin no puede ser anterior a la de inicio.");
                }

            get { return horaFin; }
        }

        /// <summary>
        /// Cambia las horas de inicio y de fin
        /// </summary>
        /// <param name="inicio">Hora de inicio</param>
        /// <param name="fin">Hora de fin</param>
        public void CambiarHoras(Hora inicio, Hora fin) {
            if (inicio > fin) {
                throw new ArgumentException("La hora de inicio es mayor que la de fin");
            }
            else if (actividad != null) {
                if (actividad.EsAcademica()) {
                    horaInicio = inicio;
                    horaFin = fin;
                }
                else {
                    Turno test = new Turno(this);
                    test.horaInicio = inicio;
                    test.horaFin = fin;

                    foreach (Turno existente in actividad.Turnos) {
                        if (existente.Codigo != this.Codigo) {
                            test.Superpone(existente);
                        }
                    }

                    horaInicio = inicio;
                    horaFin = fin;
                }
            }
            else {
                horaInicio = inicio;
                horaFin = fin;
            }
        }

        /// <summary>
        /// Cambia las horas de inicio y de fin
        /// </summary>
        /// <param name="horaI">Horas de la Hora de inicio</param>
        /// <param name="minI">Minutos de la Hora de inicio</param>
        /// <param name="horaF">Horas de la Hora de fin</param>
        /// <param name="minF">Minutos de la Hora de fin</param>
        public void CambiarHoras(int horaI, int minI, int horaF, int minF) {
            Hora inicio = new Hora(horaI, minI);
            Hora fin = new Hora(horaF, minF);

            CambiarHoras(inicio, fin);
        }

        /// <summary>
        /// Cambia las horas de inicio y de fin
        /// Los string que se pasan tiene que separa las horas de los minutos por ':'
        /// </summary>
        /// <param name="inicio">Hora de inicio</param>
        /// <param name="fin">Hora de fin</param>
        public void CambiarHoras(string inicio, string fin) {
            Hora i = new Hora(inicio);
            Hora f = new Hora(fin);

            CambiarHoras(i, f);
        }


        /// <summary>
        /// Asigna/Devuelve el dia de la semana
        /// </summary>
        public dias Dia{
            get { return diasemana; }
            set {
                    if (actividad == null)
                    {
                        diasemana = value;
                    }
                    else if (actividad.EsAcademica())
                    {
                        diasemana = value;
                    }
                    else
                    {
                        Turno test = new Turno(this);
                        test.diasemana = value;

                        foreach (Turno existente in actividad.Turnos)
                        {
                            if (existente.Codigo != this.Codigo)
                            {
                                test.Superpone(existente);
                            }
                        }

                        diasemana = value;
                }
            }
        }

        /// <summary>
        /// Asinga/Devuelve el dia de la semana a partir de un string
        /// Para la asignación: el día de la semana puede ser en formato de un carácter o el nombre completo
        /// </summary>
        public string DiaString {
            get { return ObtDiaString(); }
            set { CambiarDiaSemana(value); }
        }


        /// <summary>
        /// Asigna/Devuelve la ubicación en la que se da el Turno
        /// </summary>
        public string Ubicacion {
            set { ubicacion = value; }
            get { return ubicacion; }
        }

        /// <summary>
        /// Comprueba si el turno se superpone con otro
        /// Si se da el caso lanza una excepción
        /// </summary>
        /// <param name="t">Turno con el que puede superponerse</param>
        public void Superpone(Turno t)
        {
            // Si se superponen...
            if (Dia.Equals(t.Dia))
            {
                if ((HoraFin > t.HoraInicio && HoraFin <= t.HoraFin) ||
                    (t.HoraFin > HoraInicio && t.HoraFin <= HoraFin) ||
                    (HoraInicio >= t.HoraInicio && HoraInicio < t.HoraFin) ||
                    (t.HoraInicio >= HoraInicio && t.HoraInicio < HoraFin)) {
                    throw new NotSupportedException("Turnos solapados.");
                }
            }
        }

        /// <summary>
        /// Comprueba si el turno se superpone con otro 
        /// </summary>
        /// <param name="t">Turno con el que puede superponerse</param>
        /// <returns>Devuelve TRUE si se superpone y FALSE en caso contrario</returns>
        public bool SuperponeBool(Turno t) {
            bool superpuesto = false;
            try {
                Superpone(t);
            }
            catch {
                superpuesto = true;
            }

            return superpuesto;
        }


        #endregion
    }
}