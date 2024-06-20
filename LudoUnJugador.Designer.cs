namespace PruebaLudo
{
    partial class LudoUnJugador
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
            dadoBoton = new Button();
            label2 = new Label();
            turnoColor = new Label();
            numDado = new Label();
            pictureBox1 = new PictureBox();
            botonVolveraJugar = new Button();
            pictureBox2 = new PictureBox();
            pieza2Azul = new Button();
            pieza1Azul = new Button();
            pieza4Azul = new Button();
            pieza3Azul = new Button();
            contadorAzul = new Label();
            pieza1Verde = new Button();
            pieza2Verde = new Button();
            pieza3Verde = new Button();
            pieza4Verde = new Button();
            contadorVerde = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dadoBoton
            // 
            dadoBoton.BackgroundImage = Properties.Resources.dado;
            dadoBoton.BackgroundImageLayout = ImageLayout.Zoom;
            dadoBoton.Location = new Point(676, 54);
            dadoBoton.Name = "dadoBoton";
            dadoBoton.Size = new Size(57, 52);
            dadoBoton.TabIndex = 24;
            dadoBoton.UseVisualStyleBackColor = true;
            dadoBoton.Click += dadoBoton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(695, 121);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 25;
            label2.Text = "--";
            // 
            // turnoColor
            // 
            turnoColor.BackColor = Color.Blue;
            turnoColor.Font = new Font("Unispace", 15F, FontStyle.Regular, GraphicsUnit.Point);
            turnoColor.Location = new Point(633, 135);
            turnoColor.Name = "turnoColor";
            turnoColor.Size = new Size(143, 108);
            turnoColor.TabIndex = 26;
            turnoColor.Text = "Turno: JUGADOR";
            turnoColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numDado
            // 
            numDado.BackColor = SystemColors.ButtonFace;
            numDado.Font = new Font("Unispace", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numDado.Location = new Point(623, 255);
            numDado.Name = "numDado";
            numDado.Size = new Size(173, 57);
            numDado.TabIndex = 27;
            numDado.Text = "Lance el dado";
            numDado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1024px_Ludo_board;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(596, 595);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // botonVolveraJugar
            // 
            botonVolveraJugar.Font = new Font("Unispace", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botonVolveraJugar.Location = new Point(642, 330);
            botonVolveraJugar.Name = "botonVolveraJugar";
            botonVolveraJugar.Size = new Size(134, 43);
            botonVolveraJugar.TabIndex = 38;
            botonVolveraJugar.Text = "Volver a jugar";
            botonVolveraJugar.UseVisualStyleBackColor = true;
            botonVolveraJugar.Click += botonVolveraJugar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.unnamed;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(633, 421);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 159);
            pictureBox2.TabIndex = 39;
            pictureBox2.TabStop = false;
            // 
            // pieza2Azul
            // 
            pieza2Azul.BackColor = Color.Blue;
            pieza2Azul.BackgroundImageLayout = ImageLayout.Center;
            pieza2Azul.Location = new Point(462, 500);
            pieza2Azul.Name = "pieza2Azul";
            pieza2Azul.Size = new Size(33, 30);
            pieza2Azul.TabIndex = 40;
            pieza2Azul.UseVisualStyleBackColor = false;
            pieza2Azul.Click += pieza1Azul_Click;
            // 
            // pieza1Azul
            // 
            pieza1Azul.BackColor = Color.Blue;
            pieza1Azul.BackgroundImageLayout = ImageLayout.Center;
            pieza1Azul.Location = new Point(501, 460);
            pieza1Azul.Name = "pieza1Azul";
            pieza1Azul.Size = new Size(33, 30);
            pieza1Azul.TabIndex = 41;
            pieza1Azul.UseVisualStyleBackColor = false;
            pieza1Azul.Click += pieza1Azul_Click;
            // 
            // pieza4Azul
            // 
            pieza4Azul.BackColor = Color.Blue;
            pieza4Azul.BackgroundImageLayout = ImageLayout.Center;
            pieza4Azul.Location = new Point(462, 421);
            pieza4Azul.Name = "pieza4Azul";
            pieza4Azul.Size = new Size(33, 30);
            pieza4Azul.TabIndex = 42;
            pieza4Azul.UseVisualStyleBackColor = false;
            pieza4Azul.Click += pieza1Azul_Click;
            // 
            // pieza3Azul
            // 
            pieza3Azul.BackColor = Color.Blue;
            pieza3Azul.BackgroundImageLayout = ImageLayout.Center;
            pieza3Azul.Location = new Point(422, 460);
            pieza3Azul.Name = "pieza3Azul";
            pieza3Azul.Size = new Size(33, 30);
            pieza3Azul.TabIndex = 43;
            pieza3Azul.UseVisualStyleBackColor = false;
            pieza3Azul.Click += pieza1Azul_Click;
            // 
            // contadorAzul
            // 
            contadorAzul.AutoSize = true;
            contadorAzul.BackColor = Color.Blue;
            contadorAzul.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            contadorAzul.ForeColor = SystemColors.ButtonHighlight;
            contadorAzul.Location = new Point(327, 284);
            contadorAzul.Name = "contadorAzul";
            contadorAzul.Size = new Size(27, 30);
            contadorAzul.TabIndex = 44;
            contadorAzul.Text = "0";
            // 
            // pieza1Verde
            // 
            pieza1Verde.BackColor = Color.Green;
            pieza1Verde.BackgroundImageLayout = ImageLayout.Zoom;
            pieza1Verde.Location = new Point(106, 145);
            pieza1Verde.Name = "pieza1Verde";
            pieza1Verde.Size = new Size(33, 30);
            pieza1Verde.TabIndex = 45;
            pieza1Verde.UseVisualStyleBackColor = false;
            // 
            // pieza2Verde
            // 
            pieza2Verde.BackColor = Color.Green;
            pieza2Verde.BackgroundImageLayout = ImageLayout.Zoom;
            pieza2Verde.Location = new Point(145, 106);
            pieza2Verde.Name = "pieza2Verde";
            pieza2Verde.Size = new Size(33, 30);
            pieza2Verde.TabIndex = 46;
            pieza2Verde.UseVisualStyleBackColor = false;
            // 
            // pieza3Verde
            // 
            pieza3Verde.BackColor = Color.Green;
            pieza3Verde.BackgroundImageLayout = ImageLayout.Zoom;
            pieza3Verde.Location = new Point(106, 65);
            pieza3Verde.Name = "pieza3Verde";
            pieza3Verde.Size = new Size(33, 30);
            pieza3Verde.TabIndex = 47;
            pieza3Verde.UseVisualStyleBackColor = false;
            // 
            // pieza4Verde
            // 
            pieza4Verde.BackColor = Color.Green;
            pieza4Verde.BackgroundImageLayout = ImageLayout.Zoom;
            pieza4Verde.Location = new Point(66, 106);
            pieza4Verde.Name = "pieza4Verde";
            pieza4Verde.Size = new Size(33, 30);
            pieza4Verde.TabIndex = 48;
            pieza4Verde.UseVisualStyleBackColor = false;
            // 
            // contadorVerde
            // 
            contadorVerde.AutoSize = true;
            contadorVerde.BackColor = Color.Lime;
            contadorVerde.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            contadorVerde.ForeColor = SystemColors.ButtonHighlight;
            contadorVerde.Location = new Point(249, 284);
            contadorVerde.Name = "contadorVerde";
            contadorVerde.Size = new Size(27, 30);
            contadorVerde.TabIndex = 49;
            contadorVerde.Text = "0";
            // 
            // LudoUnJugador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 596);
            Controls.Add(contadorVerde);
            Controls.Add(pieza4Verde);
            Controls.Add(pieza3Verde);
            Controls.Add(pieza2Verde);
            Controls.Add(pieza1Verde);
            Controls.Add(contadorAzul);
            Controls.Add(pieza3Azul);
            Controls.Add(pieza4Azul);
            Controls.Add(pieza1Azul);
            Controls.Add(pieza2Azul);
            Controls.Add(pictureBox2);
            Controls.Add(botonVolveraJugar);
            Controls.Add(pictureBox1);
            Controls.Add(numDado);
            Controls.Add(turnoColor);
            Controls.Add(label2);
            Controls.Add(dadoBoton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LudoUnJugador";
            Text = "LudoUnJugador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dadoBoton;
        private Label label2;
        private Label turnoColor;
        private Label numDado;
        private PictureBox pictureBox1;
        private Button botonVolveraJugar;
        private PictureBox pictureBox2;
        private Button pieza2Azul;
        private Button pieza1Azul;
        private Button pieza4Azul;
        private Button pieza3Azul;
        private Label contadorAzul;
        private Button pieza1Verde;
        private Button pieza2Verde;
        private Button pieza3Verde;
        private Button pieza4Verde;
        private Label contadorVerde;
    }
}