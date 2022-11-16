using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Modelo;
using Entidades.Presentador;

namespace Vista
{
    public partial class Frm_Sala : Form, ISala
    {
        DateTime segundos;
        PresentadorSala presentador;
        bool hayEnvido = true;

        //bool gano = false;

        public Frm_Sala ()
        {
            InitializeComponent();
        }
        public Frm_Sala (Object obj) : this ()
        {
            presentador = new PresentadorSala(this, obj);
        }
        
        public string? UsuarioJugador1 { set { lbl_Jugador1.Text = value; } }
        public string? UsuarioJugador2 { set { lbl_Jugador2.Text = value; } }
        public string? Chat { get { return rtx_ChatJugadores.Text; } set { rtx_ChatJugadores.Text = value; } }
        //public string? ChatJug1 { get { return lbl_ChatJug1.Text; } set { lbl_ChatJug1.Text = value; } }
        //public string? ChatJug2 { get { return lbl_ChatJug2.Text; } set { lbl_ChatJug2.Text = value; } }
        public string? Ganador { get { return lbl_Ganador.Text; } set { lbl_Ganador.Text = value; } }
        public string? PuntosJug1 {/* get { return lbl_PuntosJug1.Text; }*/ set { lbl_PuntosJug1.Text = value; } }
        public string? PuntosJug2 {/* get { return lbl_PuntosJug2.Text; }*/ set { lbl_PuntosJug2.Text = value; } }
        public string? CartasJug1 { get { return lbl_CartasJugador1.Text; } set { lbl_CartasJugador1.Text = value; } }
        public string? CartasJug2 { get { return lbl_CartasJugador2.Text; } set { lbl_CartasJugador2.Text = value; } }
        //public int EnvidoJug1 { get { return envidoJug1; } set { envidoJug1 = value; } }
        //public int EnvidoJug2 { get { return envidoJug2; } set { envidoJug2 = value; } }
        //public bool PrimeraMano { get { return primeraMano; } set { primeraMano = value; } }
        public bool HayEnvido { get { return hayEnvido; } set { hayEnvido = value; } }
        //public bool SeCantoTruco { get { return seCantoTruco; } set { seCantoTruco = value; } }
        //public bool SeCantoRetruco { get { return seCantoRetruco; } set { seCantoRetruco = value; } }
        //public bool SeCantoQuieroVale4 { get { return seCantoQuieroVale4; } set { seCantoQuieroVale4 = value; } }
        //public bool DecirEnvido { get { return decirEnvido; } set { decirEnvido = value; } }
        //public bool SeContestoTruco { get { return seContestoTruco; } set { seContestoTruco = value; } }
        //public bool TerminoVuelta { get { return terminoVuelta; } set { terminoVuelta = value; } }

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
                //using (FolderBrowserDialog elegirCarpeta = new FolderBrowserDialog())
                //{
                //    if(elegirCarpeta.ShowDialog() == DialogResult.OK)
                //    {
                //        ManejadorArchivos.EscribirArchivo(rtx_ChatJugadores.Text, "Partida");
                //    }
                //}
                //FolderBrowserDialog buscarCarpeta = new FolderBrowserDialog();
                //try
                //{
                //    if (buscarCarpeta.ShowDialog() == DialogResult.OK)
                //    {
                //        ManejadorArchivos.EscribirArchivo(rtx_ChatJugadores.Text, buscarCarpeta.SelectedPath, "Partida");
                //    }
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("Ocurrio un error");
                //}
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
    }
}
