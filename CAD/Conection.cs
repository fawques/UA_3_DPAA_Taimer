using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAD
{
    public sealed class Conection
    {
        private string conectionString;
        private static Conection conect=new Conection();

        public Conection()
        {
            conectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Taimer\\CAD\\BDTaimer.mdf;Integrated Security=True;User Instance=True";
            //conectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\BDTaimer.mdf;Integrated Security=True;User Instance=True";
        }

        public string ConectionString
        {
            get { return conectionString; }
        }

        public static Conection Conect
        {
            get { return conect; }
        }
    }
}
