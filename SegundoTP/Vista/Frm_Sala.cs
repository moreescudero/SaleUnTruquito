using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Properties;
using Entidades.Modelo;
using Entidades.Presentador;
using System.Resources;

namespace Vista
{
    public partial class Frm_Sala : Form, ISala
    {
        PresentadorSala presentador;
        bool hayEnvido = true;

        public Frm_Sala ()
        {
            InitializeComponent();
        }
        public Frm_Sala (Object obj) : this ()
        {
            presentador = new PresentadorSala(this, obj);
            CargarFondo();
        }
        
        public string? UsuarioJugador1 { set { lbl_Jugador1.Text = value; } }
        public string? UsuarioJugador2 { set { lbl_Jugador2.Text = value; } }
        public string? Chat { get { return rtx_ChatJugadores.Text; } set { rtx_ChatJugadores.Text = value; } }
        public string? Ganador { get { return lbl_Ganador.Text; } set { lbl_Ganador.Text = value; } }
        public string? PuntosJug1 { set { lbl_PuntosJug1.Text = value; } }
        public string? PuntosJug2 { set { lbl_PuntosJug2.Text = value; } }
        public string? CartasJug1 { get { return lbl_CartasJugador1.Text; } set { lbl_CartasJugador1.Text = value; } }
        public string? CartasJug2 { get { return lbl_CartasJugador2.Text; } set { lbl_CartasJugador2.Text = value; } }
        public bool HayEnvido { get { return hayEnvido; } set { hayEnvido = value; } }

        private void Frm_Sala_Load(object sender, EventArgs e)
        {
            presentador.delTerminarVuelta();
            tmr_Partida.Start();
        }

        private void tmr_Partida_Tick(object sender, EventArgs e)
        {
            try
            {
                if (hayEnvido)
                {
                    presentador.JugarEnvido();
                }
                else
                {
                    presentador.Jugar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Detiene el timer una vez que la partida terminó
        /// </summary>
        public void FrenarTimer()
        {
            tmr_Partida.Stop();
        }

        /// <summary>
        /// Guarda el chat de la partida en un archivo txt
        /// </summary>
        public void GuardarPartida(string? ganador)
        {
            DialogResult dr = MessageBox.Show("¿Desea guardar el chat de la partida?", "Guardar partida", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    ManejadorArchivos.EscribirArchivo(rtx_ChatJugadores.Text, "Partida " + ganador);
                }
                catch(Exception)
                {
                    MessageBox.Show("Ocurrio un error");
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Vuelve a setear todos los atributos para poder jugar nuevamente otra vuelta
        /// </summary>
        public void LimpiarVuelta()
        {
            hayEnvido = true;

            lbl_CartasJugador1.Text = String.Empty;
            lbl_CartasJugador2.Text = String.Empty;
            lbl_ChatJug1.Text = String.Empty;
            lbl_ChatJug2.Text = String.Empty;
            lbl_Ganador.Text = String.Empty;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rtx_ChatJugadores_TextChanged(object sender, EventArgs e)
        {
            rtx_ChatJugadores.SelectionStart = rtx_ChatJugadores.Text.Length;
            rtx_ChatJugadores.ScrollToCaret();
        }

        public void CargarFondo()
        {
            Random random = new Random();
            int rnd = random.Next(0, 2);

            if(rnd == 1)
            {
                this.BackgroundImage = Resources.barsito;
                rtx_ChatJugadores.BackColor = Color.SaddleBrown;
                rtx_ChatJugadores.ForeColor = Color.OldLace;
            }
            else
            {
                this.BackgroundImage = Resources.pastito;
                rtx_ChatJugadores.BackColor = Color.OliveDrab;
                rtx_ChatJugadores.ForeColor = Color.Black;
            }
        }
    }
}
