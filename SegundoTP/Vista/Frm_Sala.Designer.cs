namespace Vista
{
    partial class Frm_Sala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Sala));
            this.btn_Volver = new System.Windows.Forms.Button();
            this.lbl_Jugador2 = new System.Windows.Forms.Label();
            this.lbl_Jugador1 = new System.Windows.Forms.Label();
            this.tmr_Partida = new System.Windows.Forms.Timer(this.components);
            this.lbl_PuntosJug1 = new System.Windows.Forms.Label();
            this.lbl_PuntosJug2 = new System.Windows.Forms.Label();
            this.rtx_ChatJugadores = new System.Windows.Forms.RichTextBox();
            this.pic_Carta3Jug1 = new System.Windows.Forms.PictureBox();
            this.pic_Carta2Jug1 = new System.Windows.Forms.PictureBox();
            this.pic_Carta1Jug1 = new System.Windows.Forms.PictureBox();
            this.pic_Carta1Jug2 = new System.Windows.Forms.PictureBox();
            this.pic_Carta2Jug2 = new System.Windows.Forms.PictureBox();
            this.pic_Carta3Jug2 = new System.Windows.Forms.PictureBox();
            this.pic_CartaJugada1Jug1 = new System.Windows.Forms.PictureBox();
            this.pic_CartaJugada2Jug1 = new System.Windows.Forms.PictureBox();
            this.pic_CartaJugada3Jug1 = new System.Windows.Forms.PictureBox();
            this.pic_CartaJugada1Jug2 = new System.Windows.Forms.PictureBox();
            this.pic_CartaJugada2Jug2 = new System.Windows.Forms.PictureBox();
            this.pic_CartaJugada3Jug2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta3Jug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta2Jug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta1Jug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta1Jug2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta2Jug2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta3Jug2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada1Jug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada2Jug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada3Jug1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada1Jug2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada2Jug2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada3Jug2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(510, 752);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(103, 29);
            this.btn_Volver.TabIndex = 1;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // lbl_Jugador2
            // 
            this.lbl_Jugador2.AutoSize = true;
            this.lbl_Jugador2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Jugador2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Jugador2.Location = new System.Drawing.Point(34, 170);
            this.lbl_Jugador2.Name = "lbl_Jugador2";
            this.lbl_Jugador2.Size = new System.Drawing.Size(107, 25);
            this.lbl_Jugador2.TabIndex = 2;
            this.lbl_Jugador2.Text = "Jugador 2:";
            // 
            // lbl_Jugador1
            // 
            this.lbl_Jugador1.AutoSize = true;
            this.lbl_Jugador1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Jugador1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Jugador1.Location = new System.Drawing.Point(34, 566);
            this.lbl_Jugador1.Name = "lbl_Jugador1";
            this.lbl_Jugador1.Size = new System.Drawing.Size(107, 25);
            this.lbl_Jugador1.TabIndex = 3;
            this.lbl_Jugador1.Text = "Jugador 1:";
            // 
            // tmr_Partida
            // 
            this.tmr_Partida.Interval = 1000;
            this.tmr_Partida.Tick += new System.EventHandler(this.tmr_Partida_Tick);
            // 
            // lbl_PuntosJug1
            // 
            this.lbl_PuntosJug1.AutoSize = true;
            this.lbl_PuntosJug1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PuntosJug1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PuntosJug1.Location = new System.Drawing.Point(34, 484);
            this.lbl_PuntosJug1.Name = "lbl_PuntosJug1";
            this.lbl_PuntosJug1.Size = new System.Drawing.Size(19, 21);
            this.lbl_PuntosJug1.TabIndex = 7;
            this.lbl_PuntosJug1.Text = "0";
            // 
            // lbl_PuntosJug2
            // 
            this.lbl_PuntosJug2.AutoSize = true;
            this.lbl_PuntosJug2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PuntosJug2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PuntosJug2.Location = new System.Drawing.Point(34, 244);
            this.lbl_PuntosJug2.Name = "lbl_PuntosJug2";
            this.lbl_PuntosJug2.Size = new System.Drawing.Size(19, 21);
            this.lbl_PuntosJug2.TabIndex = 8;
            this.lbl_PuntosJug2.Text = "0";
            // 
            // rtx_ChatJugadores
            // 
            this.rtx_ChatJugadores.BackColor = System.Drawing.Color.OliveDrab;
            this.rtx_ChatJugadores.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtx_ChatJugadores.Location = new System.Drawing.Point(774, 207);
            this.rtx_ChatJugadores.Name = "rtx_ChatJugadores";
            this.rtx_ChatJugadores.ReadOnly = true;
            this.rtx_ChatJugadores.Size = new System.Drawing.Size(290, 290);
            this.rtx_ChatJugadores.TabIndex = 11;
            this.rtx_ChatJugadores.Text = "";
            this.rtx_ChatJugadores.TextChanged += new System.EventHandler(this.rtx_ChatJugadores_TextChanged);
            // 
            // pic_Carta3Jug1
            // 
            this.pic_Carta3Jug1.BackColor = System.Drawing.Color.Transparent;
            this.pic_Carta3Jug1.Image = global::Vista.Properties.Resources.revero_carta;
            this.pic_Carta3Jug1.Location = new System.Drawing.Point(484, 566);
            this.pic_Carta3Jug1.Name = "pic_Carta3Jug1";
            this.pic_Carta3Jug1.Size = new System.Drawing.Size(105, 158);
            this.pic_Carta3Jug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Carta3Jug1.TabIndex = 13;
            this.pic_Carta3Jug1.TabStop = false;
            // 
            // pic_Carta2Jug1
            // 
            this.pic_Carta2Jug1.BackColor = System.Drawing.Color.Transparent;
            this.pic_Carta2Jug1.Image = global::Vista.Properties.Resources.revero_carta;
            this.pic_Carta2Jug1.Location = new System.Drawing.Point(372, 566);
            this.pic_Carta2Jug1.Name = "pic_Carta2Jug1";
            this.pic_Carta2Jug1.Size = new System.Drawing.Size(106, 158);
            this.pic_Carta2Jug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Carta2Jug1.TabIndex = 14;
            this.pic_Carta2Jug1.TabStop = false;
            // 
            // pic_Carta1Jug1
            // 
            this.pic_Carta1Jug1.BackColor = System.Drawing.Color.Transparent;
            this.pic_Carta1Jug1.Image = global::Vista.Properties.Resources.revero_carta;
            this.pic_Carta1Jug1.Location = new System.Drawing.Point(259, 566);
            this.pic_Carta1Jug1.Name = "pic_Carta1Jug1";
            this.pic_Carta1Jug1.Size = new System.Drawing.Size(107, 158);
            this.pic_Carta1Jug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Carta1Jug1.TabIndex = 15;
            this.pic_Carta1Jug1.TabStop = false;
            // 
            // pic_Carta1Jug2
            // 
            this.pic_Carta1Jug2.BackColor = System.Drawing.Color.Transparent;
            this.pic_Carta1Jug2.Image = global::Vista.Properties.Resources.revero_carta;
            this.pic_Carta1Jug2.Location = new System.Drawing.Point(259, 37);
            this.pic_Carta1Jug2.Name = "pic_Carta1Jug2";
            this.pic_Carta1Jug2.Size = new System.Drawing.Size(107, 158);
            this.pic_Carta1Jug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Carta1Jug2.TabIndex = 18;
            this.pic_Carta1Jug2.TabStop = false;
            // 
            // pic_Carta2Jug2
            // 
            this.pic_Carta2Jug2.BackColor = System.Drawing.Color.Transparent;
            this.pic_Carta2Jug2.Image = global::Vista.Properties.Resources.revero_carta;
            this.pic_Carta2Jug2.Location = new System.Drawing.Point(372, 37);
            this.pic_Carta2Jug2.Name = "pic_Carta2Jug2";
            this.pic_Carta2Jug2.Size = new System.Drawing.Size(106, 158);
            this.pic_Carta2Jug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Carta2Jug2.TabIndex = 17;
            this.pic_Carta2Jug2.TabStop = false;
            // 
            // pic_Carta3Jug2
            // 
            this.pic_Carta3Jug2.BackColor = System.Drawing.Color.Transparent;
            this.pic_Carta3Jug2.Image = global::Vista.Properties.Resources.revero_carta;
            this.pic_Carta3Jug2.Location = new System.Drawing.Point(484, 37);
            this.pic_Carta3Jug2.Name = "pic_Carta3Jug2";
            this.pic_Carta3Jug2.Size = new System.Drawing.Size(105, 158);
            this.pic_Carta3Jug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Carta3Jug2.TabIndex = 16;
            this.pic_Carta3Jug2.TabStop = false;
            // 
            // pic_CartaJugada1Jug1
            // 
            this.pic_CartaJugada1Jug1.BackColor = System.Drawing.Color.Transparent;
            this.pic_CartaJugada1Jug1.Location = new System.Drawing.Point(259, 395);
            this.pic_CartaJugada1Jug1.Name = "pic_CartaJugada1Jug1";
            this.pic_CartaJugada1Jug1.Size = new System.Drawing.Size(107, 158);
            this.pic_CartaJugada1Jug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CartaJugada1Jug1.TabIndex = 21;
            this.pic_CartaJugada1Jug1.TabStop = false;
            // 
            // pic_CartaJugada2Jug1
            // 
            this.pic_CartaJugada2Jug1.BackColor = System.Drawing.Color.Transparent;
            this.pic_CartaJugada2Jug1.Location = new System.Drawing.Point(372, 395);
            this.pic_CartaJugada2Jug1.Name = "pic_CartaJugada2Jug1";
            this.pic_CartaJugada2Jug1.Size = new System.Drawing.Size(106, 158);
            this.pic_CartaJugada2Jug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CartaJugada2Jug1.TabIndex = 20;
            this.pic_CartaJugada2Jug1.TabStop = false;
            // 
            // pic_CartaJugada3Jug1
            // 
            this.pic_CartaJugada3Jug1.BackColor = System.Drawing.Color.Transparent;
            this.pic_CartaJugada3Jug1.Location = new System.Drawing.Point(484, 395);
            this.pic_CartaJugada3Jug1.Name = "pic_CartaJugada3Jug1";
            this.pic_CartaJugada3Jug1.Size = new System.Drawing.Size(105, 158);
            this.pic_CartaJugada3Jug1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CartaJugada3Jug1.TabIndex = 19;
            this.pic_CartaJugada3Jug1.TabStop = false;
            // 
            // pic_CartaJugada1Jug2
            // 
            this.pic_CartaJugada1Jug2.BackColor = System.Drawing.Color.Transparent;
            this.pic_CartaJugada1Jug2.Location = new System.Drawing.Point(259, 207);
            this.pic_CartaJugada1Jug2.Name = "pic_CartaJugada1Jug2";
            this.pic_CartaJugada1Jug2.Size = new System.Drawing.Size(107, 158);
            this.pic_CartaJugada1Jug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CartaJugada1Jug2.TabIndex = 24;
            this.pic_CartaJugada1Jug2.TabStop = false;
            // 
            // pic_CartaJugada2Jug2
            // 
            this.pic_CartaJugada2Jug2.BackColor = System.Drawing.Color.Transparent;
            this.pic_CartaJugada2Jug2.Location = new System.Drawing.Point(372, 207);
            this.pic_CartaJugada2Jug2.Name = "pic_CartaJugada2Jug2";
            this.pic_CartaJugada2Jug2.Size = new System.Drawing.Size(106, 158);
            this.pic_CartaJugada2Jug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CartaJugada2Jug2.TabIndex = 23;
            this.pic_CartaJugada2Jug2.TabStop = false;
            // 
            // pic_CartaJugada3Jug2
            // 
            this.pic_CartaJugada3Jug2.BackColor = System.Drawing.Color.Transparent;
            this.pic_CartaJugada3Jug2.Location = new System.Drawing.Point(484, 207);
            this.pic_CartaJugada3Jug2.Name = "pic_CartaJugada3Jug2";
            this.pic_CartaJugada3Jug2.Size = new System.Drawing.Size(105, 158);
            this.pic_CartaJugada3Jug2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_CartaJugada3Jug2.TabIndex = 22;
            this.pic_CartaJugada3Jug2.TabStop = false;
            // 
            // Frm_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1124, 793);
            this.ControlBox = false;
            this.Controls.Add(this.pic_CartaJugada1Jug2);
            this.Controls.Add(this.pic_CartaJugada2Jug2);
            this.Controls.Add(this.pic_CartaJugada3Jug2);
            this.Controls.Add(this.pic_CartaJugada1Jug1);
            this.Controls.Add(this.pic_CartaJugada2Jug1);
            this.Controls.Add(this.pic_CartaJugada3Jug1);
            this.Controls.Add(this.pic_Carta1Jug2);
            this.Controls.Add(this.pic_Carta2Jug2);
            this.Controls.Add(this.pic_Carta3Jug2);
            this.Controls.Add(this.pic_Carta1Jug1);
            this.Controls.Add(this.pic_Carta2Jug1);
            this.Controls.Add(this.pic_Carta3Jug1);
            this.Controls.Add(this.rtx_ChatJugadores);
            this.Controls.Add(this.lbl_PuntosJug2);
            this.Controls.Add(this.lbl_PuntosJug1);
            this.Controls.Add(this.lbl_Jugador1);
            this.Controls.Add(this.lbl_Jugador2);
            this.Controls.Add(this.btn_Volver);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Sala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Frm_Sala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta3Jug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta2Jug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta1Jug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta1Jug2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta2Jug2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Carta3Jug2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada1Jug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada2Jug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada3Jug1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada1Jug2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada2Jug2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_CartaJugada3Jug2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Volver;
        private Label lbl_Jugador2;
        private Label lbl_Jugador1;
        private System.Windows.Forms.Timer tmr_Partida;
        private Label lbl_PuntosJug1;
        private Label lbl_PuntosJug2;
        private RichTextBox rtx_ChatJugadores;
        private PictureBox pic_Carta3Jug1;
        private PictureBox pic_Carta2Jug1;
        private PictureBox pic_Carta1Jug1;
        private PictureBox pic_Carta1Jug2;
        private PictureBox pic_Carta2Jug2;
        private PictureBox pic_Carta3Jug2;
        private PictureBox pic_CartaJugada1Jug1;
        private PictureBox pic_CartaJugada2Jug1;
        private PictureBox pic_CartaJugada3Jug1;
        private PictureBox pic_CartaJugada1Jug2;
        private PictureBox pic_CartaJugada2Jug2;
        private PictureBox pic_CartaJugada3Jug2;
    }
}