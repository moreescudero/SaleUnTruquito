using Entidades.Modelo;
using Entidades.Presentador;
using Microsoft.VisualBasic.Logging;
using System.Security.Policy;

namespace Vista
{
    public partial class Frm_Login : Form, ILogin
    {
        PresentadorLogin presentador;
        bool creaUnUsuario = false;

        public Frm_Login()
        {
            InitializeComponent();
            presentador = new PresentadorLogin(this);
        }
        public string? NombreUsuario { get { return txt_Usuario.Text; } set { txt_Usuario.Text = value; } }
        public string? Contraseña { get { return txt_Contraseña.Text; } }
        public string? UsuarioIncorrecto { get { return lbl_UsuarioIncorrecto.Text; } set { lbl_UsuarioIncorrecto.Text = value; } }
        public string? ContraseñaIncorrecta { get { return lbl_ContraseñaIncorrecta.Text; } set { lbl_ContraseñaIncorrecta.Text = value; } }


        private void Frm_Login_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    List<Usuario> usuarios = Conexion.ObtenerUsuarios();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        /// <summary>
        /// Vuelve a setear todo el formulario para hacer el log in
        /// </summary>
        public void Ingresar()
        {
            creaUnUsuario = false;
            lbl_ContraseñaIncorrecta.Visible = true;
            txt_Contraseña.Text = String.Empty;
            txt_Usuario.Text = String.Empty;
            btn_Salir.Text = "Salir";
            btn_Autocompletar.Visible = true;
            chk_MostrarContraseña.Visible = false;
            lbl_CrearUsuario.Visible = true;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            if(!creaUnUsuario)
            {
                Application.Exit();
            }
            else
            {
                Ingresar();
            }
        }

        /// <summary>
        /// Ingresa al menu principal
        /// </summary>
        public void IngresarAlMenuPrincipal()
        {
            Frm_MenuPrincipal frm_MenuPrincipal = new Frm_MenuPrincipal();
            this.Hide();
            frm_MenuPrincipal.ShowDialog();
            this.Show();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (!creaUnUsuario)
            {
                presentador.IntentarIngresar();
            }
            else
            {
                if(txt_Usuario.Text != String.Empty && txt_Contraseña.Text != String.Empty && presentador.ComprobarNombreUsuarioUnico(txt_Usuario.Text))
                {
                    if(presentador.AgregarUsuario())
                    {
                        Ingresar();
                    }
                }
                else if(!presentador.ComprobarNombreUsuarioUnico(txt_Usuario.Text))
                {
                    lbl_UsuarioIncorrecto.Text = "Nombre de usuario ya existe";
                }
                else if(txt_Usuario.Text == String.Empty)
                {
                    lbl_UsuarioIncorrecto.Text = "Usuario no puede ser un campo vacio";
                }
                else
                {
                    lbl_ContraseñaIncorrecta.Text = "Contraseña no puede ser un campo vacio";
                }
            }
        }

        private void lbl_CrearUsuario_Click(object sender, EventArgs e)
        {
            creaUnUsuario = true;
            lbl_ContraseñaIncorrecta.Visible = false;
            btn_Salir.Text = "Cancelar";
            btn_Autocompletar.Visible = false;
            chk_MostrarContraseña.Visible = true;
            lbl_CrearUsuario.Visible = false;
        }

        private void chk_MostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_MostrarContraseña.Checked)
            {
                txt_Contraseña.PasswordChar = '\0';
            }
            else
            {
                txt_Contraseña.PasswordChar = '*';
            }
        }

        /// <summary>
        /// Limpia los labels de errores
        /// </summary>
        public void Limpiar()
        {
            if (lbl_UsuarioIncorrecto.Text != String.Empty || lbl_ContraseñaIncorrecta.Text != String.Empty)
            {
                lbl_UsuarioIncorrecto.Text = String.Empty;
                lbl_ContraseñaIncorrecta.Text = String.Empty;
            }
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txt_Contraseña_TextChanged(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}