namespace Vista
{
    partial class Frm_Estadistica
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
            this.dgv_PartidasGanadas = new System.Windows.Forms.DataGridView();
            this.partidaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_CantPartidasGanadas = new System.Windows.Forms.Label();
            this.lbl_CantFaltaEnvido = new System.Windows.Forms.Label();
            this.lbl_CantPartidasPerdidas = new System.Windows.Forms.Label();
            this.lbl_UsuarioActivo = new System.Windows.Forms.Label();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_CantAnchosEspada = new System.Windows.Forms.Label();
            this.ganadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perdedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PartidasGanadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PartidasGanadas
            // 
            this.dgv_PartidasGanadas.AllowUserToAddRows = false;
            this.dgv_PartidasGanadas.AllowUserToDeleteRows = false;
            this.dgv_PartidasGanadas.AllowUserToResizeRows = false;
            this.dgv_PartidasGanadas.AutoGenerateColumns = false;
            this.dgv_PartidasGanadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PartidasGanadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PartidasGanadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ganadorDataGridViewTextBoxColumn,
            this.Perdedor,
            this.fechaDataGridViewTextBoxColumn});
            this.dgv_PartidasGanadas.DataSource = this.partidaBindingSource;
            this.dgv_PartidasGanadas.Location = new System.Drawing.Point(305, 47);
            this.dgv_PartidasGanadas.Name = "dgv_PartidasGanadas";
            this.dgv_PartidasGanadas.RowTemplate.Height = 25;
            this.dgv_PartidasGanadas.Size = new System.Drawing.Size(369, 287);
            this.dgv_PartidasGanadas.TabIndex = 0;
            // 
            // partidaBindingSource
            // 
            this.partidaBindingSource.DataSource = typeof(Entidades.Modelo.Partida);
            // 
            // lbl_CantPartidasGanadas
            // 
            this.lbl_CantPartidasGanadas.AutoSize = true;
            this.lbl_CantPartidasGanadas.Location = new System.Drawing.Point(29, 117);
            this.lbl_CantPartidasGanadas.Name = "lbl_CantPartidasGanadas";
            this.lbl_CantPartidasGanadas.Size = new System.Drawing.Size(169, 15);
            this.lbl_CantPartidasGanadas.TabIndex = 1;
            this.lbl_CantPartidasGanadas.Text = "Cantidad de partidas ganadas: ";
            // 
            // lbl_CantFaltaEnvido
            // 
            this.lbl_CantFaltaEnvido.AutoSize = true;
            this.lbl_CantFaltaEnvido.Location = new System.Drawing.Point(29, 216);
            this.lbl_CantFaltaEnvido.Name = "lbl_CantFaltaEnvido";
            this.lbl_CantFaltaEnvido.Size = new System.Drawing.Size(187, 15);
            this.lbl_CantFaltaEnvido.TabIndex = 2;
            this.lbl_CantFaltaEnvido.Text = "Cantidad de falta envido jugados: ";
            // 
            // lbl_CantPartidasPerdidas
            // 
            this.lbl_CantPartidasPerdidas.AutoSize = true;
            this.lbl_CantPartidasPerdidas.Location = new System.Drawing.Point(29, 167);
            this.lbl_CantPartidasPerdidas.Name = "lbl_CantPartidasPerdidas";
            this.lbl_CantPartidasPerdidas.Size = new System.Drawing.Size(170, 15);
            this.lbl_CantPartidasPerdidas.TabIndex = 3;
            this.lbl_CantPartidasPerdidas.Text = "Cantidad de partidas perdidas: ";
            // 
            // lbl_UsuarioActivo
            // 
            this.lbl_UsuarioActivo.AutoSize = true;
            this.lbl_UsuarioActivo.Location = new System.Drawing.Point(29, 30);
            this.lbl_UsuarioActivo.Name = "lbl_UsuarioActivo";
            this.lbl_UsuarioActivo.Size = new System.Drawing.Size(88, 15);
            this.lbl_UsuarioActivo.TabIndex = 4;
            this.lbl_UsuarioActivo.Text = "Usuario activo: ";
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(321, 381);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 5;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_CantAnchosEspada
            // 
            this.lbl_CantAnchosEspada.AutoSize = true;
            this.lbl_CantAnchosEspada.Location = new System.Drawing.Point(29, 268);
            this.lbl_CantAnchosEspada.Name = "lbl_CantAnchosEspada";
            this.lbl_CantAnchosEspada.Size = new System.Drawing.Size(174, 15);
            this.lbl_CantAnchosEspada.TabIndex = 6;
            this.lbl_CantAnchosEspada.Text = "Cantidad de anchos de espada: ";
            // 
            // ganadorDataGridViewTextBoxColumn
            // 
            this.ganadorDataGridViewTextBoxColumn.DataPropertyName = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.HeaderText = "Ganador";
            this.ganadorDataGridViewTextBoxColumn.Name = "ganadorDataGridViewTextBoxColumn";
            // 
            // Perdedor
            // 
            this.Perdedor.DataPropertyName = "Perdedor";
            this.Perdedor.HeaderText = "Perdedor";
            this.Perdedor.Name = "Perdedor";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // Frm_Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 416);
            this.Controls.Add(this.lbl_CantAnchosEspada);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.lbl_UsuarioActivo);
            this.Controls.Add(this.lbl_CantPartidasPerdidas);
            this.Controls.Add(this.lbl_CantFaltaEnvido);
            this.Controls.Add(this.lbl_CantPartidasGanadas);
            this.Controls.Add(this.dgv_PartidasGanadas);
            this.Name = "Frm_Estadistica";
            this.Text = "Frm_Estadisticas";
            this.Load += new System.EventHandler(this.Frm_Estadistica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PartidasGanadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partidaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_PartidasGanadas;
        private Label lbl_CantPartidasGanadas;
        private Label lbl_CantFaltaEnvido;
        private Label lbl_CantPartidasPerdidas;
        private Label lbl_UsuarioActivo;
        private Button btn_Volver;
        private Label lbl_CantAnchosEspada;
        private DataGridViewTextBoxColumn jugadorUnoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jugadorDosDataGridViewTextBoxColumn;
        private BindingSource partidaBindingSource;
        private DataGridViewTextBoxColumn ganadorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Perdedor;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
    }
}