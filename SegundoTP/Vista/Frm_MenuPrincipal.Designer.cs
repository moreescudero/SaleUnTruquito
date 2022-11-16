namespace Vista
{
    partial class Frm_MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_JugadoresDisponibles = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartidasGanadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartidasPerdidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_AbirSala = new System.Windows.Forms.Button();
            this.btn_CrearSala = new System.Windows.Forms.Button();
            this.btn_Estadistica = new System.Windows.Forms.Button();
            this.lbl_BienvenidoJugador = new System.Windows.Forms.Label();
            this.lbl_UsuariosCargados = new System.Windows.Forms.Label();
            this.dgv_Salas = new System.Windows.Forms.DataGridView();
            this.JugadorUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JugadorDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnl_ErrorPartidas = new System.Windows.Forms.Panel();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_ErrorPartidasBaseDeDatos = new System.Windows.Forms.Label();
            this.tmr_Partidas = new System.Windows.Forms.Timer(this.components);
            this.btn_Reglas = new System.Windows.Forms.Button();
            this.pnl_Reglas = new System.Windows.Forms.Panel();
            this.rtx_Reglas = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JugadoresDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.pnl_ErrorPartidas.SuspendLayout();
            this.pnl_Reglas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_JugadoresDisponibles
            // 
            this.dgv_JugadoresDisponibles.AllowUserToAddRows = false;
            this.dgv_JugadoresDisponibles.AllowUserToDeleteRows = false;
            this.dgv_JugadoresDisponibles.AllowUserToResizeRows = false;
            this.dgv_JugadoresDisponibles.AutoGenerateColumns = false;
            this.dgv_JugadoresDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_JugadoresDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_JugadoresDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_JugadoresDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.PartidasGanadas,
            this.PartidasPerdidas});
            this.dgv_JugadoresDisponibles.DataSource = this.usuarioBindingSource;
            this.dgv_JugadoresDisponibles.Location = new System.Drawing.Point(62, 309);
            this.dgv_JugadoresDisponibles.Name = "dgv_JugadoresDisponibles";
            this.dgv_JugadoresDisponibles.ReadOnly = true;
            this.dgv_JugadoresDisponibles.RowTemplate.Height = 25;
            this.dgv_JugadoresDisponibles.Size = new System.Drawing.Size(667, 129);
            this.dgv_JugadoresDisponibles.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // PartidasGanadas
            // 
            this.PartidasGanadas.DataPropertyName = "PartidasGanadas";
            this.PartidasGanadas.HeaderText = "Partidas Ganadas";
            this.PartidasGanadas.Name = "PartidasGanadas";
            this.PartidasGanadas.ReadOnly = true;
            // 
            // PartidasPerdidas
            // 
            this.PartidasPerdidas.DataPropertyName = "PartidasPerdidas";
            this.PartidasPerdidas.HeaderText = "Partidas Perdidas";
            this.PartidasPerdidas.Name = "PartidasPerdidas";
            this.PartidasPerdidas.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(Entidades.Modelo.Usuario);
            // 
            // btn_AbirSala
            // 
            this.btn_AbirSala.Enabled = false;
            this.btn_AbirSala.Location = new System.Drawing.Point(109, 105);
            this.btn_AbirSala.Name = "btn_AbirSala";
            this.btn_AbirSala.Size = new System.Drawing.Size(99, 23);
            this.btn_AbirSala.TabIndex = 1;
            this.btn_AbirSala.Text = "Abrir Sala";
            this.btn_AbirSala.UseVisualStyleBackColor = true;
            this.btn_AbirSala.Click += new System.EventHandler(this.btn_AbirSala_Click);
            // 
            // btn_CrearSala
            // 
            this.btn_CrearSala.Location = new System.Drawing.Point(109, 177);
            this.btn_CrearSala.Name = "btn_CrearSala";
            this.btn_CrearSala.Size = new System.Drawing.Size(99, 23);
            this.btn_CrearSala.TabIndex = 2;
            this.btn_CrearSala.Text = "Crear Sala";
            this.btn_CrearSala.UseVisualStyleBackColor = true;
            this.btn_CrearSala.Click += new System.EventHandler(this.btn_CrearSala_Click);
            // 
            // btn_Estadistica
            // 
            this.btn_Estadistica.Location = new System.Drawing.Point(109, 248);
            this.btn_Estadistica.Name = "btn_Estadistica";
            this.btn_Estadistica.Size = new System.Drawing.Size(99, 23);
            this.btn_Estadistica.TabIndex = 3;
            this.btn_Estadistica.Text = "Estadistica";
            this.btn_Estadistica.UseVisualStyleBackColor = true;
            this.btn_Estadistica.Click += new System.EventHandler(this.btn_Estadistica_Click);
            // 
            // lbl_BienvenidoJugador
            // 
            this.lbl_BienvenidoJugador.AutoSize = true;
            this.lbl_BienvenidoJugador.Location = new System.Drawing.Point(24, 30);
            this.lbl_BienvenidoJugador.Name = "lbl_BienvenidoJugador";
            this.lbl_BienvenidoJugador.Size = new System.Drawing.Size(69, 15);
            this.lbl_BienvenidoJugador.TabIndex = 4;
            this.lbl_BienvenidoJugador.Text = "Bienvenido ";
            // 
            // lbl_UsuariosCargados
            // 
            this.lbl_UsuariosCargados.AutoSize = true;
            this.lbl_UsuariosCargados.Location = new System.Drawing.Point(307, 217);
            this.lbl_UsuariosCargados.Name = "lbl_UsuariosCargados";
            this.lbl_UsuariosCargados.Size = new System.Drawing.Size(38, 15);
            this.lbl_UsuariosCargados.TabIndex = 5;
            this.lbl_UsuariosCargados.Text = "asdad";
            // 
            // dgv_Salas
            // 
            this.dgv_Salas.AllowUserToAddRows = false;
            this.dgv_Salas.AllowUserToDeleteRows = false;
            this.dgv_Salas.AllowUserToResizeRows = false;
            this.dgv_Salas.AutoGenerateColumns = false;
            this.dgv_Salas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Salas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Salas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JugadorUno,
            this.JugadorDos});
            this.dgv_Salas.DataSource = this.partidaBindingSource;
            this.dgv_Salas.Location = new System.Drawing.Point(422, 30);
            this.dgv_Salas.Name = "dgv_Salas";
            this.dgv_Salas.RowTemplate.Height = 25;
            this.dgv_Salas.Size = new System.Drawing.Size(307, 273);
            this.dgv_Salas.TabIndex = 6;
            this.dgv_Salas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Salas_RowHeaderMouseClick);
            // 
            // JugadorUno
            // 
            this.JugadorUno.DataPropertyName = "JugadorUno";
            this.JugadorUno.HeaderText = "Jugador Uno";
            this.JugadorUno.Name = "JugadorUno";
            this.JugadorUno.ReadOnly = true;
            // 
            // JugadorDos
            // 
            this.JugadorDos.DataPropertyName = "JugadorDos";
            this.JugadorDos.HeaderText = "Jugador Dos";
            this.JugadorDos.Name = "JugadorDos";
            this.JugadorDos.ReadOnly = true;
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Entidades.Modelo.Partida);
            // 
            // pnl_ErrorPartidas
            // 
            this.pnl_ErrorPartidas.Controls.Add(this.btn_Volver);
            this.pnl_ErrorPartidas.Controls.Add(this.lbl_ErrorPartidasBaseDeDatos);
            this.pnl_ErrorPartidas.Location = new System.Drawing.Point(296, 162);
            this.pnl_ErrorPartidas.Name = "pnl_ErrorPartidas";
            this.pnl_ErrorPartidas.Size = new System.Drawing.Size(255, 100);
            this.pnl_ErrorPartidas.TabIndex = 7;
            this.pnl_ErrorPartidas.Visible = false;
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(90, 74);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 1;
            this.btn_Volver.Text = "ok";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_ErrorPartidasBaseDeDatos
            // 
            this.lbl_ErrorPartidasBaseDeDatos.AutoSize = true;
            this.lbl_ErrorPartidasBaseDeDatos.Location = new System.Drawing.Point(11, 40);
            this.lbl_ErrorPartidasBaseDeDatos.Name = "lbl_ErrorPartidasBaseDeDatos";
            this.lbl_ErrorPartidasBaseDeDatos.Size = new System.Drawing.Size(38, 15);
            this.lbl_ErrorPartidasBaseDeDatos.TabIndex = 0;
            this.lbl_ErrorPartidasBaseDeDatos.Text = "label1";
            // 
            // tmr_Partidas
            // 
            this.tmr_Partidas.Interval = 3500;
            this.tmr_Partidas.Tick += new System.EventHandler(this.tmr_Partidas_Tick);
            // 
            // btn_Reglas
            // 
            this.btn_Reglas.Location = new System.Drawing.Point(734, 12);
            this.btn_Reglas.Name = "btn_Reglas";
            this.btn_Reglas.Size = new System.Drawing.Size(54, 28);
            this.btn_Reglas.TabIndex = 8;
            this.btn_Reglas.Text = "Reglas";
            this.btn_Reglas.UseVisualStyleBackColor = true;
            this.btn_Reglas.Click += new System.EventHandler(this.btn_Reglas_Click);
            // 
            // pnl_Reglas
            // 
            this.pnl_Reglas.Controls.Add(this.rtx_Reglas);
            this.pnl_Reglas.Location = new System.Drawing.Point(62, 48);
            this.pnl_Reglas.Name = "pnl_Reglas";
            this.pnl_Reglas.Size = new System.Drawing.Size(667, 326);
            this.pnl_Reglas.TabIndex = 9;
            this.pnl_Reglas.Visible = false;
            // 
            // rtx_Reglas
            // 
            this.rtx_Reglas.Location = new System.Drawing.Point(46, 27);
            this.rtx_Reglas.Name = "rtx_Reglas";
            this.rtx_Reglas.ReadOnly = true;
            this.rtx_Reglas.Size = new System.Drawing.Size(577, 277);
            this.rtx_Reglas.TabIndex = 0;
            this.rtx_Reglas.Text = "";
            // 
            // Frm_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Reglas);
            this.Controls.Add(this.btn_Reglas);
            this.Controls.Add(this.pnl_ErrorPartidas);
            this.Controls.Add(this.dgv_Salas);
            this.Controls.Add(this.lbl_UsuariosCargados);
            this.Controls.Add(this.lbl_BienvenidoJugador);
            this.Controls.Add(this.btn_Estadistica);
            this.Controls.Add(this.btn_CrearSala);
            this.Controls.Add(this.btn_AbirSala);
            this.Controls.Add(this.dgv_JugadoresDisponibles);
            this.Name = "Frm_MenuPrincipal";
            this.Text = "Frm_MenuPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.Frm_MenuPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JugadoresDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Salas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.pnl_ErrorPartidas.ResumeLayout(false);
            this.pnl_ErrorPartidas.PerformLayout();
            this.pnl_Reglas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_JugadoresDisponibles;
        private Button btn_AbirSala;
        private Button btn_CrearSala;
        private Button btn_Estadistica;
        private BindingSource usuarioBindingSource;
        private Label lbl_BienvenidoJugador;
        private Label lbl_UsuariosCargados;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn PartidasGanadas;
        private DataGridViewTextBoxColumn PartidasPerdidas;
        private DataGridView dgv_Salas;
        private BindingSource partidaBindingSource;
        private DataGridViewTextBoxColumn JugadorUno;
        private DataGridViewTextBoxColumn JugadorDos;
        private Panel pnl_ErrorPartidas;
        private Label lbl_ErrorPartidasBaseDeDatos;
        private Button btn_Volver;
        private System.Windows.Forms.Timer tmr_Partidas;
        private Button btn_Reglas;
        private Panel pnl_Reglas;
        private RichTextBox rtx_Reglas;
    }
}