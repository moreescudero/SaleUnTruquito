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
            this.lbl_CartasJugador2 = new System.Windows.Forms.Label();
            this.lbl_CartasJugador1 = new System.Windows.Forms.Label();
            this.tmr_Partida = new System.Windows.Forms.Timer(this.components);
            this.lbl_Ganador = new System.Windows.Forms.Label();
            this.lbl_PuntosJug1 = new System.Windows.Forms.Label();
            this.lbl_PuntosJug2 = new System.Windows.Forms.Label();
            this.lbl_ChatJug1 = new System.Windows.Forms.Label();
            this.lbl_ChatJug2 = new System.Windows.Forms.Label();
            this.rtx_ChatJugadores = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(451, 565);
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
            this.lbl_Jugador2.Location = new System.Drawing.Point(132, 50);
            this.lbl_Jugador2.Name = "lbl_Jugador2";
            this.lbl_Jugador2.Size = new System.Drawing.Size(61, 15);
            this.lbl_Jugador2.TabIndex = 2;
            this.lbl_Jugador2.Text = "Jugador 2:";
            // 
            // lbl_Jugador1
            // 
            this.lbl_Jugador1.AutoSize = true;
            this.lbl_Jugador1.Location = new System.Drawing.Point(133, 334);
            this.lbl_Jugador1.Name = "lbl_Jugador1";
            this.lbl_Jugador1.Size = new System.Drawing.Size(61, 15);
            this.lbl_Jugador1.TabIndex = 3;
            this.lbl_Jugador1.Text = "Jugador 1:";
            // 
            // lbl_CartasJugador2
            // 
            this.lbl_CartasJugador2.AutoSize = true;
            this.lbl_CartasJugador2.Location = new System.Drawing.Point(111, 131);
            this.lbl_CartasJugador2.Name = "lbl_CartasJugador2";
            this.lbl_CartasJugador2.Size = new System.Drawing.Size(0, 15);
            this.lbl_CartasJugador2.TabIndex = 4;
            // 
            // lbl_CartasJugador1
            // 
            this.lbl_CartasJugador1.AutoSize = true;
            this.lbl_CartasJugador1.Location = new System.Drawing.Point(111, 232);
            this.lbl_CartasJugador1.Name = "lbl_CartasJugador1";
            this.lbl_CartasJugador1.Size = new System.Drawing.Size(0, 15);
            this.lbl_CartasJugador1.TabIndex = 5;
            // 
            // tmr_Partida
            // 
            this.tmr_Partida.Interval = 1000;
            this.tmr_Partida.Tick += new System.EventHandler(this.tmr_Partida_Tick);
            // 
            // lbl_Ganador
            // 
            this.lbl_Ganador.AutoSize = true;
            this.lbl_Ganador.Location = new System.Drawing.Point(32, 180);
            this.lbl_Ganador.Name = "lbl_Ganador";
            this.lbl_Ganador.Size = new System.Drawing.Size(51, 15);
            this.lbl_Ganador.TabIndex = 6;
            this.lbl_Ganador.Text = "ganador";
            // 
            // lbl_PuntosJug1
            // 
            this.lbl_PuntosJug1.AutoSize = true;
            this.lbl_PuntosJug1.Location = new System.Drawing.Point(32, 304);
            this.lbl_PuntosJug1.Name = "lbl_PuntosJug1";
            this.lbl_PuntosJug1.Size = new System.Drawing.Size(13, 15);
            this.lbl_PuntosJug1.TabIndex = 7;
            this.lbl_PuntosJug1.Text = "0";
            // 
            // lbl_PuntosJug2
            // 
            this.lbl_PuntosJug2.AutoSize = true;
            this.lbl_PuntosJug2.Location = new System.Drawing.Point(32, 64);
            this.lbl_PuntosJug2.Name = "lbl_PuntosJug2";
            this.lbl_PuntosJug2.Size = new System.Drawing.Size(13, 15);
            this.lbl_PuntosJug2.TabIndex = 8;
            this.lbl_PuntosJug2.Text = "0";
            // 
            // lbl_ChatJug1
            // 
            this.lbl_ChatJug1.AutoSize = true;
            this.lbl_ChatJug1.Location = new System.Drawing.Point(91, 264);
            this.lbl_ChatJug1.Name = "lbl_ChatJug1";
            this.lbl_ChatJug1.Size = new System.Drawing.Size(43, 15);
            this.lbl_ChatJug1.TabIndex = 9;
            this.lbl_ChatJug1.Text = "asdasd";
            // 
            // lbl_ChatJug2
            // 
            this.lbl_ChatJug2.AutoSize = true;
            this.lbl_ChatJug2.Location = new System.Drawing.Point(68, 107);
            this.lbl_ChatJug2.Name = "lbl_ChatJug2";
            this.lbl_ChatJug2.Size = new System.Drawing.Size(43, 15);
            this.lbl_ChatJug2.TabIndex = 10;
            this.lbl_ChatJug2.Text = "asdasd";
            // 
            // rtx_ChatJugadores
            // 
            this.rtx_ChatJugadores.BackColor = System.Drawing.Color.OliveDrab;
            this.rtx_ChatJugadores.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtx_ChatJugadores.Location = new System.Drawing.Point(707, 137);
            this.rtx_ChatJugadores.Name = "rtx_ChatJugadores";
            this.rtx_ChatJugadores.ReadOnly = true;
            this.rtx_ChatJugadores.Size = new System.Drawing.Size(252, 258);
            this.rtx_ChatJugadores.TabIndex = 11;
            this.rtx_ChatJugadores.Text = "";
            this.rtx_ChatJugadores.TextChanged += new System.EventHandler(this.rtx_ChatJugadores_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(484, 387);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(105, 158);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(372, 387);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 158);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(259, 387);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(107, 158);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(372, 37);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(106, 158);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Location = new System.Drawing.Point(484, 37);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(105, 158);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 16;
            this.pictureBox6.TabStop = false;
            // 
            // Frm_Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Vista.Properties.Resources.pastito;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 606);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.rtx_ChatJugadores);
            this.Controls.Add(this.lbl_ChatJug2);
            this.Controls.Add(this.lbl_ChatJug1);
            this.Controls.Add(this.lbl_PuntosJug2);
            this.Controls.Add(this.lbl_PuntosJug1);
            this.Controls.Add(this.lbl_Ganador);
            this.Controls.Add(this.lbl_CartasJugador1);
            this.Controls.Add(this.lbl_CartasJugador2);
            this.Controls.Add(this.lbl_Jugador1);
            this.Controls.Add(this.lbl_Jugador2);
            this.Controls.Add(this.btn_Volver);
            this.DoubleBuffered = true;
            this.Name = "Frm_Sala";
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.Frm_Sala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_Volver;
        private Label lbl_Jugador2;
        private Label lbl_Jugador1;
        private Label lbl_CartasJugador2;
        private Label lbl_CartasJugador1;
        private System.Windows.Forms.Timer tmr_Partida;
        private Label lbl_Ganador;
        private Label lbl_PuntosJug1;
        private Label lbl_PuntosJug2;
        private Label lbl_ChatJug1;
        private Label lbl_ChatJug2;
        private RichTextBox rtx_ChatJugadores;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}