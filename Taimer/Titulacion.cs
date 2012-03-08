using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taimer {
    public class Titulacion {

        //PARTE PRIVADA
        
        private string nom;
        private string cod;
        private ArrayList opt = new ArrayList();
        private ArrayList cursos = new ArrayList();

        //PARTE PUBLICA

        //Constructor
        public Titulacion(string nom_, string cod_) {
            nom = nom_;
            cod =  cod_;
        }

        //Cambiar nombre
        public void setNom(string nom_) {
            nom = nom_;
        }

        //Cambiar codigo
        public void setCod(string cod_) {
            cod = cod_;
        }

        //Añadir optativa
        public void AddOpt(Actividad_a activ) {
            opt.Add(activ);
        }

        //Añadir cursos
        public void AddCursos(Curso curso) {
            cursos.Add(curso);
        }

        //Obtener nombre
        public string getNom() {
            return nom;
        }

        //Obtener codigo
        public string getCod() {
            return cod;
        }

        //Obtener ArrayList de actividades academicas
        public ArrayList getOpt() {
            return opt;
        }

        //Obtener ArrayList de cursos
        public ArrayList getCursos() {
            return cursos;
        }
    }
}
