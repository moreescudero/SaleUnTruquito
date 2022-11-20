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
            CargarFondo();
        }
        public Frm_Sala (Object obj) : this ()
        {
            try
            {
                presentador = new PresentadorSala(this, obj);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message); 
            }
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
                ModificarIntervalo();
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
        /// utilizado para simular el tiempo que se toma el usuario en jugar
        /// </summary>
        private void ModificarIntervalo()
        {
            Random random = new Random();
            tmr_Partida.Interval = random.Next(500, 500 /*3000*/);
        }

        public void MostrarError(string? mensaje)
        {
            MessageBox.Show(mensaje);
        }

        /// <summary>
        /// Vuelve a setear todos los atributos para poder jugar nuevamente otra vuelta
        /// </summary>
        public void LimpiarVuelta()
        {
            hayEnvido = true;

            lbl_CartasJugador1.Text = String.Empty;
            lbl_CartasJugador2.Text = String.Empty;
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

        public void LimpiarMesa()
        {
            pic_CartaJugada1Jug1.Image = null;
            pic_CartaJugada1Jug2.Image = null;
            pic_CartaJugada2Jug1.Image = null;
            pic_CartaJugada2Jug2.Image = null;
            pic_CartaJugada3Jug1.Image = null;
            pic_CartaJugada3Jug2.Image = null;

            pic_Carta1Jug1.Visible = true;
            pic_Carta2Jug1.Visible = true;
            pic_Carta3Jug1.Visible = true;
            pic_Carta1Jug2.Visible = true;
            pic_Carta2Jug2.Visible = true;
            pic_Carta3Jug2.Visible = true;
        }

        private void SubirCarta(Bitmap imagen, int jug)
        {
            if (jug == 1)
            {
                if(pic_CartaJugada1Jug1.Image is null)
                {
                    pic_CartaJugada1Jug1.Image = imagen;
                    pic_Carta1Jug1.Visible = false;
                }
                else if(pic_CartaJugada2Jug1.Image is null)
                {
                    pic_CartaJugada2Jug1.Image = imagen;
                    pic_Carta2Jug1.Visible = false;
                }
                else if (pic_CartaJugada3Jug1.Image is null)
                {
                    pic_CartaJugada3Jug1.Image = imagen;
                    pic_Carta3Jug1.Visible = false;
                }
            }
            else
            {
                if (pic_CartaJugada1Jug2.Image is null)
                {
                    pic_CartaJugada1Jug2.Image = imagen;
                    pic_Carta1Jug2.Visible = false;
                }
                else if (pic_CartaJugada2Jug2.Image is null)
                {
                    pic_CartaJugada2Jug2.Image = imagen;
                    pic_Carta2Jug2.Visible = false;
                }
                else if (pic_CartaJugada3Jug2.Image is null)
                {
                    pic_CartaJugada3Jug2.Image = imagen;
                    pic_Carta3Jug2.Visible = false;
                }
            }
        }

        public void TirarCartaEnMesa(string? carta, int jug)
        {
            switch (carta)
            {
                case "1 Espada":
                    SubirCarta(Resources._1_DE_ESPADA, jug);
                    break;
                case "2 Espada":
                    SubirCarta(Resources._2_ESPADA, jug);
                    break;
                case "3 Espada":
                    SubirCarta(Resources._3_ESPADA, jug);
                    break;
                case "4 Espada":
                    SubirCarta(Resources._4_ESPADA, jug);
                    break;
                case "5 Espada":
                    SubirCarta(Resources._5_ESPADA, jug);
                    break;
                case "6 Espada":
                    SubirCarta(Resources._6_ESPADA, jug);
                    break;
                case "7 Espada":
                    SubirCarta(Resources._7_ESPADA, jug);
                    break;
                case "10 Espada":
                    SubirCarta(Resources._10_ESPADA, jug);
                    break;
                case "11 Espada":
                    SubirCarta(Resources._11_ESPADA, jug);
                    break;
                case "12 Espada":
                    SubirCarta(Resources._12_ESPADA, jug);
                    break;
                case "1 Oro":
                    SubirCarta(Resources._1_DE_ORO, jug);
                    break;
                case "2 Oro":
                    SubirCarta(Resources._2_ORO, jug);
                    break;
                case "3 Oro":
                    SubirCarta(Resources._3_ORO, jug);
                    break;
                case "4 Oro":
                    SubirCarta(Resources._4_ORO, jug);
                    break;
                case "5 Oro":
                    SubirCarta(Resources._5_ORO, jug);
                    break;
                case "6 Oro":
                    SubirCarta(Resources._6_ORO, jug);
                    break;
                case "7 Oro":
                    SubirCarta(Resources._7_ORO, jug);
                    break;
                case "10 Oro":
                    SubirCarta(Resources._10_ORO, jug);
                    break;
                case "11 Oro":
                    SubirCarta(Resources._11_ORO, jug);
                    break;
                case "12 Oro":
                    SubirCarta(Resources._12_ORO, jug);
                    break;
                case "1 Basto":
                    SubirCarta(Resources._1_DE_BASTO, jug);
                    break;
                case "2 Basto":
                    SubirCarta(Resources._2_BASTO, jug);
                    break;
                case "3 Basto":
                    SubirCarta(Resources._3_BASTO, jug);
                    break;
                case "4 Basto":
                    SubirCarta(Resources._4_BASTO, jug);
                    break;
                case "5 Basto":
                    SubirCarta(Resources._5_BASTO, jug);
                    break;
                case "6 Basto":
                    SubirCarta(Resources._6_BASTO, jug);
                    break;
                case "7 Basto":
                    SubirCarta(Resources._7_BASTO, jug);
                    break;
                case "10 Basto":
                    SubirCarta(Resources._10_BASTO, jug);
                    break;
                case "11 Basto":
                    SubirCarta(Resources._11_BASTO, jug);
                    break;
                case "12 Basto":
                    SubirCarta(Resources._12_BASTO, jug);
                    break;
                case "1 Copa":
                    SubirCarta(Resources._1_DE_COPA, jug);
                    break;
                case "2 Copa":
                    SubirCarta(Resources._2_COPA, jug);
                    break;
                case "3 Copa":
                    SubirCarta(Resources._3_COPA, jug);
                    break;
                case "4 Copa":
                    SubirCarta(Resources._4_COPA, jug);
                    break;
                case "5 Copa":
                    SubirCarta(Resources._5_COPA, jug);
                    break;
                case "6 Copa":
                    SubirCarta(Resources._6_COPA, jug);
                    break;
                case "7 Copa":
                    SubirCarta(Resources._7_COPA, jug);
                    break;
                case "10 Copa":
                    SubirCarta(Resources._10_COPA, jug);
                    break;
                case "11 Copa":
                    SubirCarta(Resources._11_COPA, jug);
                    break;
                case "12 Copa":
                    SubirCarta(Resources._12_COPA, jug);
                    break;
            }
        }
    }
}
