using Taimer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebTaimer.TabHorariosPublicos
{
    public partial class HorariosPublicos : System.Web.UI.Page
    {
        List<Horario> horarios;
        protected string _horas;
        protected string _columnas;

        protected int getMaxHora(Horario h) {
            Hora maxHora =  new Hora(0, 1);
            foreach (List<Turno> turnosDia in h.ArrayTurnos) {
                foreach (Turno turno in turnosDia) {
                    if (turno.HoraFin > maxHora)
                        maxHora = turno.HoraFin;
                }
            }

            int mh = maxHora.Hor;
            if (maxHora.Min > 0)
                mh++;

            return mh;
        }

        protected Horario horarioPrueba() {
            Horario h;
            User user = new User("user", "12345678A", "email@email.com", "password", 1, "II");
            h = new Horario("horario", user);
            Actividad_a act = new Actividad_a("Actividad_a", "descripción", "pepe", "II");
            h.AddTurno(new Turno(new Hora(9, 0), new Hora(10, 0), dias.L, "ua", act));
            h.AddTurno(new Turno(new Hora(21, 0), new Hora(22, 0), dias.L, "ua", act));
            h.AddTurno(new Turno(new Hora(13, 30), new Hora(15, 30), dias.L, "ua", act));
            h.AddTurno(new Turno(new Hora(9, 30), new Hora(10, 45), dias.M, "ua", act));
            h.AddTurno(new Turno(new Hora(16, 30), new Hora(20, 0), dias.M, "ua", act));
            h.AddTurno(new Turno(new Hora(9, 0), new Hora(11, 20), dias.J, "ua", act));
            h.AddTurno(new Turno(new Hora(12, 30), new Hora(13, 45), dias.J, "ua", act));
            h.AddTurno(new Turno(new Hora(12, 0), new Hora(14, 30), dias.V, "ua", act));
            h.AddTurno(new Turno(new Hora(21, 0), new Hora(23, 0), dias.V, "ua", act));
            h.AddTurno(new Turno(new Hora(13, 30), new Hora(16, 0), dias.S, "ua", act));
            h.AddTurno(new Turno(new Hora(16, 0), new Hora(20, 0), dias.S, "ua", act));

            return h;
        }
        
        protected string setHoras(Horario h) {
            int minHora = h.minHora().Hor;
            int maxHora = getMaxHora(h);

            string horas = "";
            for(int i = minHora; i <= maxHora; i++) {
                if(i == minHora)
                    horas += "<p class='horas' style='margin-top: 5px;'> " + i.ToString() + ":00 </p>";
                else
                    horas += "<p class='horas'> " + i.ToString() + ":00 </p>";
            }

            return horas;
        }

        protected string setColums(Horario h) {
            int minHora = h.minHora().Hor;
            int maxHora = getMaxHora(h);
            string columnas = "";

            foreach(List<Turno> turnoDia in h.ArrayTurnos){
                columnas += "<div class='columnas' style='height: " + (maxHora - minHora)*40 + "px;' >";
                int antH = minHora;
                int antM = 0;
                foreach (Turno turno in turnoDia) {

                    int height = (turno.HoraFin.toMin() - turno.HoraInicio.toMin())* 40 / 60; //calculamos el tamaño del cuadro
                    int top = (turno.HoraInicio.Hor - antH)*40;   //calculo de desplazamiento (horas)
                    top += (turno.HoraInicio.Min - antM) * 40 / 60;  //calculo de desplazamiento (minutos)

                    columnas += "<div class='Asignatura' style='height: " + height + "px; margin-top: " + top + "px'>";
                        columnas += "<p class='asigText'>" + turno.Actividad.Nombre + "</p>";
                    columnas += "</div>";

                    antH = turno.HoraFin.Hor;
                    antM = turno.HoraFin.Min;
                }
                columnas += "</div>";
            }

            return columnas;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session.Count > 0) {
                User user = (User)Session["usuario"];
                horarios = user.Horarios;

                ArrayList listHorarios = new ArrayList();

                foreach (Horario horario in horarios) {
                    listHorarios.Add(horario.Nombre);
                }

                //if (horarios.Count > 0)
                listaHorarios.DataSource = listHorarios;
                listaHorarios.DataBind();

                _horas = setHoras(horarios[0]);
                _columnas = setColums(horarios[0]);
            }


        }

        protected void listaHorarios_SelectedIndexChanged(object sender, EventArgs e) {
            int i = listaHorarios.SelectedIndex;
            _horas = setHoras(horarios[i]);
            _columnas = setColums(horarios[i]);
            Response.Redirect("~/TabHorariosPublicos/HorariosPublicos.aspx.cs");
        }
        
    }
}