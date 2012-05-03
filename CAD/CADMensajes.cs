using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;
using System.Collections;

namespace CAD {

    class CADMensajes {
        private static string conexionTBD;

        public CADMensajes() {
            conexionTBD = Conection.Conect.ConectionString;
        }

        public void CrearMensajeBasic(string codEmisor, string codReceptor, string texto, DateTime date) {

        }
    }
}
