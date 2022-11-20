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
using Vista.Properties;

namespace Vista
{
    public partial class Frm_Estadistica : Form, IEstadistica
    {
        PresentadorEstadistica presentador;
        public Frm_Estadistica()
        {
            InitializeComponent();
            presentador = new PresentadorEstadistica(this);
        }

        public string PartidasGanadas { get { return lbl_CantPartidasGanadas.Text; } set { lbl_CantPartidasGanadas.Text = value; } }
        public string PartidasPerdidas { get { return lbl_CantPartidasPerdidas.Text; } set { lbl_CantPartidasPerdidas.Text = value; } }
        public string FaltaEnvido { get { return lbl_CantFaltaEnvido.Text; } set { lbl_CantFaltaEnvido.Text = value; } }
        public string AnchoEspada { get { return lbl_CantAnchosEspada.Text; } set { lbl_CantAnchosEspada.Text = value; } }
        public string Activo { get { return lbl_UsuarioActivo.Text; } set { lbl_UsuarioActivo.Text = value; } }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Frm_Estadistica_Load(object sender, EventArgs e)
        {
            presentador.CargarDgv();
            presentador.Cargar();
            CargarFondo();
        }

        public void CargarDgv(Object fuente)
        {
            dgv_PartidasGanadas.DataSource = null;
            dgv_PartidasGanadas.DataSource = fuente;
        }

        public void CargarFondo()
        {
            Random random = new Random();
            int rnd = random.Next(0, 2);

            if (rnd == 1)
            {
                this.BackgroundImage = Resources.barsito;
            }
            else
            {
                this.BackgroundImage = Resources.pastito;
            }
        }
    }
}
