using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Taimer;

namespace TaimerGUI
{
    public partial class ClientCrearHor2 : Form
    {
        ClientCrearHor1 formBack = null;
        User usrAux = null;
        Horario hAux = null;
        bool[] listaDias = new bool[7];

        public ClientCrearHor2(User usr)
        {
            InitializeComponent();
            usrAux = usr;
        }

        public void setBackForm(ClientCrearHor1 form)
        {
            formBack = form;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formBack != null)
            {
                Hide();
                formBack.Show();
                ClientForm pare = (ClientForm)this.MdiParent;
                pare.positionAllChilds();
                btnGuardar.Visible = false;
                btnCrear.Visible = true;
            }
        }

        private void chkBxAll_CheckedChanged(object sender, EventArgs e)
        {
            switchCheckAllDays();
        }
        void switchCheckAllDays()
        {
            
            foreach (Control c in groubBoxDias.Controls)
            {
                if (c is CheckBox && ((CheckBox)c).Name != "chkBxAll")
                {
                    ((CheckBox)c).Checked = chkBxAll.Checked;
                }
            }

        }


        private void initPanelHorario(int minHor, int maxHor)
        {
            pnlHoras.Controls.Clear();
            Hora hora = new Hora(0, 0);
            int posY = 0;
            int horAux = minHor;
            while (horAux <= maxHor)
            {
                Label lblHora = new Label();
                if (horAux >= 24) {
                    lblHora.Text = "24:00";
                } else {
                    hora.setTiempo(horAux, 0);
                    lblHora.Text = hora.toString();
                }
                lblHora.Location = new Point(20, posY);
                lblHora.ForeColor = Color.White;
                posY += 60;
                horAux++;
                pnlHoras.Controls.Add(lblHora);
            }
            pnlHoras.Height = 1460;
            pnlLunes.Height = 1460;
            pnlMartes.Height = 1460;
            pnlMiercoles.Height = 1460;
            pnlJueves.Height = 1460;
            pnlViernes.Height = 1460;
            pnlSabado.Height = 1460;
            pnlDomingo.Height = 1460;
        }
        //Para redimensionar los panales de los dias con minimos y maximos
        private void reducirPanelHorarios(int minHor, int maxHor)
        {
            int recorteArriba = (minHor) * 60;

            int recorteAbajo = (24 - maxHor) * 60;

            pnlHoras.Height -= (recorteArriba + recorteAbajo);
            pnlLunes.Height -= (recorteArriba + recorteAbajo);
            pnlMartes.Height -= (recorteArriba + recorteAbajo);
            pnlMiercoles.Height -= (recorteArriba + recorteAbajo);
            pnlJueves.Height -= (recorteArriba + recorteAbajo);
            pnlViernes.Height -= (recorteArriba + recorteAbajo);
            pnlSabado.Height -= (recorteArriba + recorteAbajo);
            pnlDomingo.Height -= (recorteArriba + recorteAbajo);

        }

        private void loadHorario(Horario hor)
        {
            //Pasar maximos y minimos de horas (solo horas, tampoco vamos a recortar al minuto)
            int minimo = 0;
            int maximo = 23;
            try {
                minimo = hor.minHora().Hor;
                maximo = hor.maxHora().Hor;
                if (hor.maxHora().Hor < 23 && hor.maxHora().Min > 0) {
                    maximo++;
                }
            } catch (Exception) {
                //MessageBox.Show(exc.Message);
            }
            int recorteArriba = (minimo) * 60;
            try{
                
                if (hor.maxHora().Hor == 23)
                {
                    initPanelHorario(minimo, 24);
                }
                else
                {
                    initPanelHorario(minimo, maximo);
                }

                if (!(hor.maxHora().Hor == 23 && hor.maxHora().Min > 0))
                {
                    reducirPanelHorarios(minimo, maximo);
                }
            }
            catch (NullReferenceException ex)
            {
                initPanelHorario(minimo, maximo);
                MessageBox.Show(ex.Message);
            }

            for (int i = 0; i < hor.ArrayTurnos.Length; i++)
            {
                foreach (Turno item in hor.ArrayTurnos[i])
                {
                    int posi = (item.HoraInicio.Hor * 60 + item.HoraInicio.Min) - recorteArriba;
                    int duracion = (item.HoraFin.Hor - item.HoraInicio.Hor) * 60 + item.HoraFin.Min;
                    Button b = new Button();
                    b.Height = duracion;
                    b.Width = 90;
                    b.BackColor = Color.Khaki;

                    b.Text = item.Actividad.Nombre + Environment.NewLine + item.Ubicacion;
                    b.Location = new Point(0, posi);
                    b.Tag = item;
                    b.Anchor = AnchorStyles.Left;
                    b.FlatStyle = FlatStyle.Flat;
                    b.Cursor = Cursors.Hand;

                    addActividad(b);
                }
            }

        }
        private void addActividad(Button b)
        {
            if (b.Tag is Turno)
            {
                Turno auxt = (Turno)b.Tag;
                switch (auxt.Dia)
                {
                    case dias.L:
                        pnlLunes.Controls.Add(b);
                        break;
                    case dias.M:
                        pnlMartes.Controls.Add(b);
                        break;
                    case dias.X:
                        pnlMiercoles.Controls.Add(b);
                        break;
                    case dias.J:
                        pnlJueves.Controls.Add(b);
                        break;
                    case dias.V:
                        pnlViernes.Controls.Add(b);
                        break;
                    case dias.S:
                        pnlSabado.Controls.Add(b);
                        break;
                    case dias.D:
                        pnlDomingo.Controls.Add(b);
                        break;
                }
            }
        }

        private void ClientCrearHor2_Load(object sender, EventArgs e)
        {

        }

        private void rellenarListaDias()
        {
            listaDias[0] = chkBxLunes.Checked;
            listaDias[1] = chkBxMartes.Checked;
            listaDias[2] = chkBoxMiercoles.Checked;
            listaDias[3] = chkBoxJueves.Checked;
            listaDias[4] = chkBoxViernes.Checked;
            listaDias[5] = chkBoxSabado.Checked;
            listaDias[6] = chkBoxDomingo.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!chkBxLunes.Checked && !chkBxMartes.Checked && !chkBoxMiercoles.Checked &&
                !chkBoxJueves.Checked && !chkBoxViernes.Checked && !chkBoxSabado.Checked && !chkBoxDomingo.Checked) // si no hay ningún día seleccionado
                lbErrDias.Visible = true;
            else
            {
                rellenarListaDias();
                lbErrDias.Visible = false;
                if (MessageBox.Show("Esta operación puede tomar varios minutos. ¿Seguro que desea continuar?",
               "¿Crear horario?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    //Algoritmos guay con una ventana de "Estmos en ello"
                    //ClientCreandoAlgoritmo aux = new ClientCreandoAlgoritmo();
                    //aux.ShowDialog();
                    hAux = generarHorario();
                    if (hAux != null)
                    {
                        loadHorario(hAux);
                        btnCrear.Visible = false;
                        btnGuardar.Visible = true;
                        btnAtras.Visible = false;
                        btnDescartar.Visible = true;
                        pnlHorario.Visible = true;
                        grpBoxRestric.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Error desconocido. No se ha podido generar el horario");
                    }
                }
            }

        }

        private Horario generarHorario()
        {
            Horario h = null;

            try
            {   
                Algoritmo alg = new Algoritmo(formBack.getActividadesA(), formBack.getActividadesP(), Program.Usuarios[0]);
                h = alg.generarHorarioBT(formBack.getNameHorario(), radioButton2.Checked, listaDias);
                Program.AddAlgoritmo(alg);
            }
            catch (NotSupportedException exc)
            {
                MessageBox.Show(exc.Message);
            }
            
            return h;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (hAux != null)
            {
                if (MessageBox.Show("¿Seguro que desea guardar el horario " + hAux.Nombre + "?",
                 "¿Guardar horario?",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    try
                    {
                        Program.Usuarios[0].AddHorario(hAux);
                        MessageBox.Show("Guardado con éxito");
                        //hAux.Agregar();
                    } catch (Exception ex) {
                        if (ex.Message.Contains("CAlt"))
                            MessageBox.Show("Violación de clave alternativa.");
                        else if (ex.Message.Contains("PRIMARY KEY"))
                            MessageBox.Show("El id del horario que intenta introducir ya existe.");
                        else
                            MessageBox.Show(ex.Message);
                    }
                    ((ClientForm)this.MdiParent).loadLastHorarios();
                    this.reiniciar();
                    formBack.reiniciar();
                    ((ClientForm)this.MdiParent).verHorarios_Click(null, null);
                }

            }

        }

        public void reiniciar()
        {
            btnCrear.Visible = true;
            btnGuardar.Visible = false;
            btnAtras.Visible = true;
            btnDescartar.Visible = false;
            pnlHorario.Visible = false;
            grpBoxRestric.Visible = true;
            chkBxAll.Checked = true;
            chkBxLunes.Checked = true;
            chkBxMartes.Checked = true;
            chkBoxMiercoles.Checked = true;
            chkBoxJueves.Checked = true;
            chkBoxViernes.Checked = true;
            chkBoxSabado.Checked = true;
            chkBoxDomingo.Checked = true;
            clearAllHorarioAct();
            initPanelHorario(0, 23);
        }

        public void clearAllHorarioAct()
        {
            pnlLunes.Controls.Clear();
            pnlMartes.Controls.Clear();
            pnlMiercoles.Controls.Clear();
            pnlJueves.Controls.Clear();
            pnlViernes.Controls.Clear();
            pnlSabado.Controls.Clear();
            pnlDomingo.Controls.Clear();
        }

        private void ClientCrearHor2_Activated(object sender, EventArgs e)
        {
            this.reiniciar();
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (hAux != null)
            {
                if (MessageBox.Show("¿Seguro que desea descartar el horario " + hAux.Nombre + "?",
                     "¿Descartar horario?",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Question,
                     MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    ((ClientForm)this.MdiParent).verHorarios_Click(null, null);
                }
            }
        }

        private void pnlHorario_MouseEnter(object sender, EventArgs e) {
            ((Panel)sender).Focus();
        }

    }
}
