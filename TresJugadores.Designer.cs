namespace PruebaLudo
{
    partial class TresJugadores
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            botonVolveraJugar = new Button();
            numDado = new Label();
            turnoColor = new Label();
            label1 = new Label();
            dadoBoton = new Button();
            pieza4Rojo = new Button();
            pieza3Rojo = new Button();
            pieza2Rojo = new Button();
            pieza1Rojo = new Button();
            pieza2Verde = new Button();
            pieza1Verde = new Button();
            pieza4Verde = new Button();
            pieza3Verde = new Button();
            pieza4Azul = new Button();
            pieza1Azul = new Button();
            pieza2Azul = new Button();
            pieza3Azul = new Button();
            contadorAzul = new Label();
            contadorRojo = new Label();
            contadorVerde = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1024px_Ludo_board;
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(596, 595);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.unnamed;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(623, 415);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 159);
            pictureBox2.TabIndex = 44;
            pictureBox2.TabStop = false;
            // 
            // botonVolveraJugar
            // 
            botonVolveraJugar.Font = new Font("Unispace", 9F, FontStyle.Regular, GraphicsUnit.Point);
            botonVolveraJugar.Location = new Point(631, 333);
            botonVolveraJugar.Name = "botonVolveraJugar";
            botonVolveraJugar.Size = new Size(134, 43);
            botonVolveraJugar.TabIndex = 43;
            botonVolveraJugar.Text = "Volver a jugar";
            botonVolveraJugar.UseVisualStyleBackColor = true;
            botonVolveraJugar.Click += botonVolveraJugar_Click;
            // 
            // numDado
            // 
            numDado.BackColor = Color.Transparent;
            numDado.Font = new Font("Unispace", 15F, FontStyle.Regular, GraphicsUnit.Point);
            numDado.ForeColor = SystemColors.ActiveCaptionText;
            numDado.Location = new Point(612, 251);
            numDado.Name = "numDado";
            numDado.Size = new Size(166, 24);
            numDado.TabIndex = 42;
            numDado.Text = "Lance el dado";
            numDado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // turnoColor
            // 
            turnoColor.BackColor = Color.Green;
            turnoColor.Font = new Font("Unispace", 15F, FontStyle.Regular, GraphicsUnit.Point);
            turnoColor.ForeColor = SystemColors.ButtonFace;
            turnoColor.Location = new Point(636, 140);
            turnoColor.Name = "turnoColor";
            turnoColor.Size = new Size(116, 61);
            turnoColor.TabIndex = 41;
            turnoColor.Text = "Turno: VERDE";
            turnoColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(684, 114);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 40;
            label1.Text = "--";
            // 
            // dadoBoton
            // 
            dadoBoton.BackgroundImage = Properties.Resources.dado;
            dadoBoton.BackgroundImageLayout = ImageLayout.Zoom;
            dadoBoton.Location = new Point(664, 51);
            dadoBoton.Name = "dadoBoton";
            dadoBoton.Size = new Size(57, 52);
            dadoBoton.TabIndex = 39;
            dadoBoton.UseVisualStyleBackColor = true;
            dadoBoton.Click += dadoBoton_Click;
            // 
            // pieza4Rojo
            // 
            pieza4Rojo.BackColor = Color.Red;
            pieza4Rojo.BackgroundImageLayout = ImageLayout.Center;
            pieza4Rojo.Location = new Point(460, 65);
            pieza4Rojo.Name = "pieza4Rojo";
            pieza4Rojo.Size = new Size(33, 30);
            pieza4Rojo.TabIndex = 45;
            pieza4Rojo.UseVisualStyleBackColor = false;
            pieza4Rojo.Click += pieza1Rojo_Click;
            // 
            // pieza3Rojo
            // 
            pieza3Rojo.BackColor = Color.Red;
            pieza3Rojo.BackgroundImageLayout = ImageLayout.Center;
            pieza3Rojo.Location = new Point(501, 106);
            pieza3Rojo.Name = "pieza3Rojo";
            pieza3Rojo.Size = new Size(33, 30);
            pieza3Rojo.TabIndex = 46;
            pieza3Rojo.UseVisualStyleBackColor = false;
            pieza3Rojo.Click += pieza1Rojo_Click;
            // 
            // pieza2Rojo
            // 
            pieza2Rojo.BackColor = Color.Red;
            pieza2Rojo.BackgroundImageLayout = ImageLayout.Center;
            pieza2Rojo.Location = new Point(460, 145);
            pieza2Rojo.Name = "pieza2Rojo";
            pieza2Rojo.Size = new Size(33, 30);
            pieza2Rojo.TabIndex = 47;
            pieza2Rojo.UseVisualStyleBackColor = false;
            pieza2Rojo.Click += pieza1Rojo_Click;
            // 
            // pieza1Rojo
            // 
            pieza1Rojo.BackColor = Color.Red;
            pieza1Rojo.BackgroundImageLayout = ImageLayout.Center;
            pieza1Rojo.Location = new Point(422, 106);
            pieza1Rojo.Name = "pieza1Rojo";
            pieza1Rojo.Size = new Size(33, 30);
            pieza1Rojo.TabIndex = 48;
            pieza1Rojo.UseVisualStyleBackColor = false;
            pieza1Rojo.Click += pieza1Rojo_Click;
            // 
            // pieza2Verde
            // 
            pieza2Verde.BackColor = Color.Green;
            pieza2Verde.BackgroundImageLayout = ImageLayout.Zoom;
            pieza2Verde.Location = new Point(145, 106);
            pieza2Verde.Name = "pieza2Verde";
            pieza2Verde.Size = new Size(33, 30);
            pieza2Verde.TabIndex = 49;
            pieza2Verde.UseVisualStyleBackColor = false;
            pieza2Verde.Click += pieza2Verde_Click;
            // 
            // pieza1Verde
            // 
            pieza1Verde.BackColor = Color.Green;
            pieza1Verde.BackgroundImageLayout = ImageLayout.Zoom;
            pieza1Verde.Location = new Point(106, 145);
            pieza1Verde.Name = "pieza1Verde";
            pieza1Verde.Size = new Size(33, 30);
            pieza1Verde.TabIndex = 50;
            pieza1Verde.UseVisualStyleBackColor = false;
            pieza1Verde.Click += pieza2Verde_Click;
            // 
            // pieza4Verde
            // 
            pieza4Verde.BackColor = Color.Green;
            pieza4Verde.BackgroundImageLayout = ImageLayout.Zoom;
            pieza4Verde.Location = new Point(66, 106);
            pieza4Verde.Name = "pieza4Verde";
            pieza4Verde.Size = new Size(33, 30);
            pieza4Verde.TabIndex = 51;
            pieza4Verde.UseVisualStyleBackColor = false;
            pieza4Verde.Click += pieza2Verde_Click;
            // 
            // pieza3Verde
            // 
            pieza3Verde.BackColor = Color.Green;
            pieza3Verde.BackgroundImageLayout = ImageLayout.Zoom;
            pieza3Verde.Location = new Point(106, 65);
            pieza3Verde.Name = "pieza3Verde";
            pieza3Verde.Size = new Size(33, 30);
            pieza3Verde.TabIndex = 52;
            pieza3Verde.UseVisualStyleBackColor = false;
            pieza3Verde.Click += pieza2Verde_Click;
            // 
            // pieza4Azul
            // 
            pieza4Azul.BackColor = Color.Blue;
            pieza4Azul.BackgroundImageLayout = ImageLayout.Center;
            pieza4Azul.Location = new Point(462, 421);
            pieza4Azul.Name = "pieza4Azul";
            pieza4Azul.Size = new Size(33, 30);
            pieza4Azul.TabIndex = 53;
            pieza4Azul.UseVisualStyleBackColor = false;
            pieza4Azul.Click += pieza1Azul_Click;
            // 
            // pieza1Azul
            // 
            pieza1Azul.BackColor = Color.Blue;
            pieza1Azul.BackgroundImageLayout = ImageLayout.Center;
            pieza1Azul.Location = new Point(501, 460);
            pieza1Azul.Name = "pieza1Azul";
            pieza1Azul.Size = new Size(33, 30);
            pieza1Azul.TabIndex = 54;
            pieza1Azul.UseVisualStyleBackColor = false;
            pieza1Azul.Click += pieza1Azul_Click;
            // 
            // pieza2Azul
            // 
            pieza2Azul.BackColor = Color.Blue;
            pieza2Azul.BackgroundImageLayout = ImageLayout.Center;
            pieza2Azul.Location = new Point(462, 500);
            pieza2Azul.Name = "pieza2Azul";
            pieza2Azul.Size = new Size(33, 30);
            pieza2Azul.TabIndex = 55;
            pieza2Azul.UseVisualStyleBackColor = false;
            pieza2Azul.Click += pieza1Azul_Click;
            // 
            // pieza3Azul
            // 
            pieza3Azul.BackColor = Color.Blue;
            pieza3Azul.BackgroundImageLayout = ImageLayout.Center;
            pieza3Azul.Location = new Point(422, 460);
            pieza3Azul.Name = "pieza3Azul";
            pieza3Azul.Size = new Size(33, 30);
            pieza3Azul.TabIndex = 56;
            pieza3Azul.UseVisualStyleBackColor = false;
            pieza3Azul.Click += pieza1Azul_Click;
            // 
            // contadorAzul
            // 
            contadorAzul.AutoSize = true;
            contadorAzul.BackColor = Color.Blue;
            contadorAzul.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            contadorAzul.ForeColor = SystemColors.ButtonHighlight;
            contadorAzul.Location = new Point(324, 280);
            contadorAzul.Name = "contadorAzul";
            contadorAzul.Size = new Size(27, 30);
            contadorAzul.TabIndex = 57;
            contadorAzul.Text = "0";
            // 
            // contadorRojo
            // 
            contadorRojo.AutoSize = true;
            contadorRojo.BackColor = Color.Red;
            contadorRojo.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            contadorRojo.ForeColor = SystemColors.ButtonHighlight;
            contadorRojo.Location = new Point(287, 245);
            contadorRojo.Name = "contadorRojo";
            contadorRojo.Size = new Size(27, 30);
            contadorRojo.TabIndex = 58;
            contadorRojo.Text = "0";
            // 
            // contadorVerde
            // 
            contadorVerde.AutoSize = true;
            contadorVerde.BackColor = Color.Lime;
            contadorVerde.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            contadorVerde.ForeColor = SystemColors.ButtonHighlight;
            contadorVerde.Location = new Point(251, 280);
            contadorVerde.Name = "contadorVerde";
            contadorVerde.Size = new Size(27, 30);
            contadorVerde.TabIndex = 59;
            contadorVerde.Text = "0";
            // 
            // TresJugadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 596);
            Controls.Add(contadorVerde);
            Controls.Add(contadorRojo);
            Controls.Add(contadorAzul);
            Controls.Add(pieza3Azul);
            Controls.Add(pieza2Azul);
            Controls.Add(pieza1Azul);
            Controls.Add(pieza4Azul);
            Controls.Add(pieza3Verde);
            Controls.Add(pieza4Verde);
            Controls.Add(pieza1Verde);
            Controls.Add(pieza2Verde);
            Controls.Add(pieza1Rojo);
            Controls.Add(pieza2Rojo);
            Controls.Add(pieza3Rojo);
            Controls.Add(pieza4Rojo);
            Controls.Add(pictureBox2);
            Controls.Add(botonVolveraJugar);
            Controls.Add(numDado);
            Controls.Add(turnoColor);
            Controls.Add(label1);
            Controls.Add(dadoBoton);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TresJugadores";
            Text = "TresJugadores";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button botonVolveraJugar;
        private Label numDado;
        private Label turnoColor;
        private Label label1;
        private Button dadoBoton;
        private Button pieza4Rojo;
        private Button pieza3Rojo;
        private Button pieza2Rojo;
        private Button pieza1Rojo;
        private Button pieza2Verde;
        private Button pieza1Verde;
        private Button pieza4Verde;
        private Button pieza3Verde;
        private Button pieza4Azul;
        private Button pieza1Azul;
        private Button pieza2Azul;
        private Button pieza3Azul;
        private Label contadorAzul;
        private Label contadorRojo;
        private Label contadorVerde;
    }
}