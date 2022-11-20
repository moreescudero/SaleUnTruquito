using Entidades;
using Entidades.Modelo;
using Entidades.Presentador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vista
{
    public partial class Frm_MenuPrincipal : Form, IMenuPrincipal
    {
        PresentadorMenuPrincipal presentador;
        List<Task> listaTareas;
        int indice;

        public Frm_MenuPrincipal()
        {
            InitializeComponent();
            presentador = new PresentadorMenuPrincipal(this);
            listaTareas = new List<Task>();
        }

        public string? Bienvenido { get { return lbl_BienvenidoJugador.Text; } set { lbl_BienvenidoJugador.Text = value; } }    
        public string? UsuariosCargados { get { return lbl_UsuariosCargados.Text; } set { lbl_UsuariosCargados.Text = value; } }
        public bool HabilitarBotonAbrirSala { get { return btn_AbirSala.Enabled; } set { btn_AbirSala.Enabled = value; } }
        public bool HabilitarPanel { set { pnl_ErrorPartidas.Enabled = value; } }
        public string? ErrorPanel { set { lbl_ErrorPartidasBaseDeDatos.Text = value; } }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            presentador.MostrarJugadorActivo();
            presentador.CargarDataGridUsuarios();
            presentador.CargarDataGridPartidas();
            tmr_Partidas.Start();
            try
            {
                rtx_Reglas.Text = ManejadorArchivos.LeerArchivo(@"./Reglas", "reglas.txt");
            }
            catch (Exception ex)
            {
                pnl_ErrorPartidas.Visible = true;
                lbl_ErrorPartidasBaseDeDatos.Text = ex.Message;
            }
        }

        private async void btn_AbirSala_Click(object sender, EventArgs e)
        {
            try
            {
                //Object obj = ;
                listaTareas.Add(new Task(() =>
                {
                    try
                    {
                        Frm_Sala frm_sala = new Frm_Sala(presentador.DevolverPartidaElegida(indice));
                        frm_sala.ShowDialog();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                ));
                await CrearPartida();
                presentador.CargarDataGridUsuarios();
            }
            catch (Exception ex)
            {
                pnl_ErrorPartidas.Enabled = true;
                lbl_ErrorPartidasBaseDeDatos.Text = String.Empty;
                lbl_ErrorPartidasBaseDeDatos.Text = ex.Message;
            }
        }

        /// <summary>
        /// Carga el DataGridView según el objeto que le pasa el presentador como parámetro
        /// </summary>
        /// <param name="fuente"></param>
        public void CargarDgvUsuarios(Object fuente)
        {
            dgv_JugadoresDisponibles.DataSource = null;
            dgv_JugadoresDisponibles.DataSource = fuente;
        }
        
        public void CargarDgvPartidas(Object fuente)
        {
            dgv_Salas.DataSource = null;
            dgv_Salas.DataSource = fuente;
        }

        public async Task CrearPartida()
        {
            listaTareas.Last().Start();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            pnl_ErrorPartidas.Enabled = false;
        }

        private void Frm_MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            presentador.GuardarInfoUsuarios();
        }

        private void btn_Estadistica_Click(object sender, EventArgs e)
        {
            Frm_Estadistica frm_Estadistica = new Frm_Estadistica();
            this.Hide();
            frm_Estadistica.ShowDialog();
            this.Show();
        }

        private void btn_CrearSala_Click(object sender, EventArgs e)
        {
        }

        private void dgv_Salas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                indice = e.RowIndex;
                btn_AbirSala.Enabled = true;
            }
        }

        private void tmr_Partidas_Tick(object sender, EventArgs e)
        {
            btn_AbirSala.Enabled = false;
            presentador.CargarDataGridPartidas();
        }

        private void btn_Reglas_Click(object sender, EventArgs e)
        {
            if (!pnl_Reglas.Visible)
            {
                pnl_Reglas.Visible = true;
            }
            else
            {
                pnl_Reglas.Visible = false;
            }
        }
    }
}
