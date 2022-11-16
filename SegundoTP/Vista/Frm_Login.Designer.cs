namespace Vista
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Autocompletar = new System.Windows.Forms.Button();
            this.lbl_UsuarioIncorrecto = new System.Windows.Forms.Label();
            this.lbl_ContraseñaIncorrecta = new System.Windows.Forms.Label();
            this.lbl_CrearUsuario = new System.Windows.Forms.Label();
            this.chk_MostrarContraseña = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.Location = new System.Drawing.Point(148, 129);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.PlaceholderText = "Ingrese contraseña";
            this.txt_Contraseña.Size = new System.Drawing.Size(121, 23);
            this.txt_Contraseña.TabIndex = 1;
            this.txt_Contraseña.TextChanged += new System.EventHandler(this.txt_Contraseña_TextChanged);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(148, 59);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.PlaceholderText = "Ingrese usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(121, 23);
            this.txt_Usuario.TabIndex = 0;
            this.txt_Usuario.TextChanged += new System.EventHandler(this.txt_Usuario_TextChanged);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(95, 189);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 3;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(253, 189);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Autocompletar
            // 
            this.btn_Autocompletar.Location = new System.Drawing.Point(157, 218);
            this.btn_Autocompletar.Name = "btn_Autocompletar";
            this.btn_Autocompletar.Size = new System.Drawing.Size(100, 23);
            this.btn_Autocompletar.TabIndex = 4;
            this.btn_Autocompletar.Text = "Autocompletar";
            this.btn_Autocompletar.UseVisualStyleBackColor = true;
            // 
            // lbl_UsuarioIncorrecto
            // 
            this.lbl_UsuarioIncorrecto.AutoSize = true;
            this.lbl_UsuarioIncorrecto.Location = new System.Drawing.Point(148, 85);
            this.lbl_UsuarioIncorrecto.Name = "lbl_UsuarioIncorrecto";
            this.lbl_UsuarioIncorrecto.Size = new System.Drawing.Size(0, 15);
            this.lbl_UsuarioIncorrecto.TabIndex = 5;
            // 
            // lbl_ContraseñaIncorrecta
            // 
            this.lbl_ContraseñaIncorrecta.AutoSize = true;
            this.lbl_ContraseñaIncorrecta.Location = new System.Drawing.Point(148, 155);
            this.lbl_ContraseñaIncorrecta.Name = "lbl_ContraseñaIncorrecta";
            this.lbl_ContraseñaIncorrecta.Size = new System.Drawing.Size(0, 15);
            this.lbl_ContraseñaIncorrecta.TabIndex = 6;
            // 
            // lbl_CrearUsuario
            // 
            this.lbl_CrearUsuario.AutoSize = true;
            this.lbl_CrearUsuario.Location = new System.Drawing.Point(112, 259);
            this.lbl_CrearUsuario.Name = "lbl_CrearUsuario";
            this.lbl_CrearUsuario.Size = new System.Drawing.Size(189, 15);
            this.lbl_CrearUsuario.TabIndex = 7;
            this.lbl_CrearUsuario.Text = "¿No tenes cuenta? Crea un usuario";
            this.lbl_CrearUsuario.Click += new System.EventHandler(this.lbl_CrearUsuario_Click);
            // 
            // chk_MostrarContraseña
            // 
            this.chk_MostrarContraseña.AutoSize = true;
            this.chk_MostrarContraseña.Location = new System.Drawing.Point(275, 131);
            this.chk_MostrarContraseña.Name = "chk_MostrarContraseña";
            this.chk_MostrarContraseña.Size = new System.Drawing.Size(130, 19);
            this.chk_MostrarContraseña.TabIndex = 8;
            this.chk_MostrarContraseña.Text = "Mostrar Contraseña";
            this.chk_MostrarContraseña.UseVisualStyleBackColor = true;
            this.chk_MostrarContraseña.Visible = false;
            this.chk_MostrarContraseña.CheckedChanged += new System.EventHandler(this.chk_MostrarContraseña_CheckedChanged);
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 292);
            this.Controls.Add(this.chk_MostrarContraseña);
            this.Controls.Add(this.lbl_CrearUsuario);
            this.Controls.Add(this.lbl_ContraseñaIncorrecta);
            this.Controls.Add(this.lbl_UsuarioIncorrecto);
            this.Controls.Add(this.btn_Autocompletar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_Contraseña);
            this.Name = "Frm_Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_Contraseña;
        private TextBox txt_Usuario;
        private Button btn_Salir;
        private Button btn_Aceptar;
        private Button btn_Autocompletar;
        private Label lbl_UsuarioIncorrecto;
        private Label lbl_ContraseñaIncorrecta;
        private Label lbl_CrearUsuario;
        private CheckBox chk_MostrarContraseña;
    }
}