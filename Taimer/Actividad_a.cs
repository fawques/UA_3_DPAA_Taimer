using CAD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Taimer {

    /// <summary>
    /// Clase Actividad_a: esta clase hereda de Actividad y representa las asignaturas
    /// </summary>
    public class Actividad_a : Actividad {

        #region  PARTE PRIVADA

        // (Nombre, descripción, código y lista de turnos vienen de la clase Actividad)

        /// <summary>
        /// Nombre del profesor coordinador de la asignatura
        /// </summary>
        private string nombreCoordinador;

        /// <summary>
        /// Indica el curso al que pertenece la asignatura
        /// </summary>
        private int curso;

        /// <summary>
        /// Titulacion en la que se encuentra esta actividad
        /// </summary>
        private string titulacion;        

        #endregion

        #region PARTE PÚBLICA


        /// <summary>
        /// Constructor básico (sin lista de turnos ni número de curso)
        /// </summary>
        /// <param name="nom_"> Nombre de la Actividad_a</param>
        /// <param name="desc_"> Descripción de la Actividad_a</param>
        /// <param name="cod_"> Código de la Actividad_a </param>
        /// <param name="nomCoord_"> Nómbre del coordinador de la Actividad_a</param>
        /// <param name="titulacion">Tilación de la Actividad_a</param>
        public Actividad_a(string nom_, string desc_, int cod_, string nomCoord_, string titulacion)
            : base(nom_, desc_, cod_) {

            nombreCoordinador = nomCoord_;
            curso = 0;                      // Por defecto se asigna el número de curso a 0
        }


        /// <summary>
        /// Constructor básico (sin lista de turnos, pero sí con número de curso)
        /// </summary>
        /// <param name="nom_"> Nombre de la Actividad_a</param>
        /// <param name="desc_"> Descripción de la Activiad_a</param>
        /// <param name="cod_"> Código de la Activiad_a </param>
        /// <param name="nomCoord_"> Nombre del coordinador de la Actividad_a </param>
        /// <param name="curso_"> Curso al que pertenece la Actividad_a </param>
        /// <param name="titulacion">Tilación de la Actividad_a</param>
        public Actividad_a(string nom_, string desc_, int cod_, string nomCoord_, int curso_, string titulacion)
            : base(nom_, desc_, cod_) {

            nombreCoordinador = nomCoord_;
            Curso = curso_;
        }


        /// <summary>
        /// Constructor avanzado (con lista de turnos y curso)
        /// </summary>
        /// <param name="nom_"> Nombre de la Actividad_a</param>
        /// <param name="desc_"> Descripción de la Actividad_a</param>
        /// <param name="cod_"> Código de la Actividad_a</param>
        /// <param name="nomCoord_"> Nombre del coordinador de la Actividad_a</param>
        /// <param name="turnos_"> Listas de turnos en los que se realiza la Actividad_a</param>
        /// <param name="curso_"> Curso ql que pertence la Actividad_a</param>
        /// <param name="titulacion">Tilación de la Actividad_a</param>
        public Actividad_a(string nom_, string desc_, int cod_, string nomCoord_, List<Turno> turnos_, int curso_, string titulacion)
            : base(nom_, desc_, cod_, turnos_) {

            nombreCoordinador = nomCoord_;
            Curso = curso_;
        }


        /// <summary>
        /// Constructor de copia
        /// </summary>
        /// <param name="act">Actividad_a que se desea copiar</param>
        public Actividad_a(Actividad_a act)
            : base(act) {
            nombreCoordinador = act.nombreCoordinador;
            curso = act.curso;
        }

        /// <summary>
        /// Asigna/Devuelve el curso de la Actividad_a
        /// </summary>
        public int Curso {
            get { return curso; }
            set { 
                if(value >= 1)
                    curso = value;
                else
                    throw new ArgumentOutOfRangeException("El número de curso debe ser mayor o igual que 1");
            }
        }


        /// <summary>
        /// Asigna/Devuelve el coordinador de la Actividad_a
        /// </summary>
        public string NombreCoordinador {
            get { return nombreCoordinador; }
            set { nombreCoordinador = value; }
        }


        /// <summary>
        /// Añade un Turno a la Actividad_a
        /// Los turnos están ordenados de forma creciente
        /// </summary>
        /// <param name="turnonuevo">Turno que se desea añadir</param>
        public void AddTurno(Turno turnonuevo) {
            bool insertado = false;

            turnonuevo.Actividad = this;
            AsignarCodigo(turnonuevo);

            for (int i = 0; i < turnos.Count; i++) {
                if (turnos[i].HoraInicio > turnonuevo.HoraInicio) {
                    turnos.Insert(i, turnonuevo);
                    insertado = true;
                    break;
                }
            }

            if (!insertado)
                turnos.Add(turnonuevo);
        }

        /// <summary>
        /// Asigna/Devuelve la titulación de la Actividad_a
        /// </summary>
        public string Titulacion {
            set { titulacion = value; }
            get { return titulacion; }
        }

        /// <summary>
        /// Añade la actividad academica a la base de datos
        /// </summary>
        public void Agregar() {
            CADActividad_a act = new CADActividad_a();

            if (titulacion == "")
                titulacion = null;

            if (descripcion == "")
                descripcion = null;

            if (nombreCoordinador == "")
                nombreCoordinador = null;

            act.CrearActivida_aAll(nombre, descripcion, codigo, nombreCoordinador, titulacion);

        }

        /// <summary>
        /// Borra la actividad academica de la base de datos
        /// </summary>
        public void Borrar() {
            CADActividad_a act = new CADActividad_a();

            act.BorrarActividad_a(codigo);
        }

        /// <summary>
        /// Guarda los cambios que ha recibido la actividad en la base de datos
        /// </summary>
        public void Modificar() {
            CADActividad_a act = new CADActividad_a();

            act.ModificaActividad_a(nombreCoordinador, codigo);
        }

        /// <summary>
        /// Devuelve el ultimo codigo de Actividades Academicas introducido en la base de datos
        /// </summary>
        public static int UltimoCodigo {
            get {
                CADActividad_a act = new CADActividad_a();
                return int.Parse(act.LastCode().Tables[0].Rows[0].ItemArray[0].ToString());
            }
        }

        #endregion
    }
}
