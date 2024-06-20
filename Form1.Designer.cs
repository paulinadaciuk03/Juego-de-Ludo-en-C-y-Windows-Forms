namespace PruebaLudo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            botonJugar = new Button();
            cuatroJugadores = new CheckBox();
            unJugador = new CheckBox();
            pictureBox1 = new PictureBox();
            dosJugadores = new CheckBox();
            tresJugadores = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // botonJugar
            // 
            botonJugar.BackColor = SystemColors.ButtonHighlight;
            botonJugar.Font = new Font("Unispace", 20F, FontStyle.Regular, GraphicsUnit.Point);
            botonJugar.Location = new Point(182, 648);
            botonJugar.Name = "botonJugar";
            botonJugar.Size = new Size(123, 43);
            botonJugar.TabIndex = 4;
            botonJugar.Text = "Jugar";
            botonJugar.UseVisualStyleBackColor = false;
            botonJugar.Click += botonJugar_Click;
            // 
            // cuatroJugadores
            // 
            cuatroJugadores.AutoSize = true;
            cuatroJugadores.Font = new Font("Unispace", 20F, FontStyle.Bold, GraphicsUnit.Point);
            cuatroJugadores.Location = new Point(279, 593);
            cuatroJugadores.Name = "cuatroJugadores";
            cuatroJugadores.Size = new Size(210, 37);
            cuatroJugadores.TabIndex = 5;
            cuatroJugadores.Text = "4 Jugadores";
            cuatroJugadores.UseVisualStyleBackColor = true;
            cuatroJugadores.CheckedChanged += cuatroJugadores_CheckedChanged;
            // 
            // unJugador
            // 
            unJugador.AutoSize = true;
            unJugador.Font = new Font("Unispace", 20F, FontStyle.Bold, GraphicsUnit.Point);
            unJugador.Location = new Point(12, 540);
            unJugador.Name = "unJugador";
            unJugador.Size = new Size(258, 37);
            unJugador.TabIndex = 6;
            unJugador.Text = "Modo Solitario";
            unJugador.UseVisualStyleBackColor = true;
            unJugador.CheckedChanged += unJugador_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveBorder;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(-2, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(511, 511);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dosJugadores
            // 
            dosJugadores.AutoSize = true;
            dosJugadores.Font = new Font("Unispace", 20F, FontStyle.Bold, GraphicsUnit.Point);
            dosJugadores.Location = new Point(279, 540);
            dosJugadores.Name = "dosJugadores";
            dosJugadores.Size = new Size(210, 37);
            dosJugadores.TabIndex = 8;
            dosJugadores.Text = "2 Jugadores";
            dosJugadores.UseVisualStyleBackColor = true;
            dosJugadores.CheckedChanged += dosJugadores_CheckedChanged;
            // 
            // tresJugadores
            // 
            tresJugadores.AutoSize = true;
            tresJugadores.Font = new Font("Unispace", 20F, FontStyle.Bold, GraphicsUnit.Point);
            tresJugadores.Location = new Point(12, 593);
            tresJugadores.Name = "tresJugadores";
            tresJugadores.Size = new Size(210, 37);
            tresJugadores.TabIndex = 9;
            tresJugadores.Text = "3 Jugadores";
            tresJugadores.UseVisualStyleBackColor = true;
            tresJugadores.CheckedChanged += tresJugadores_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(501, 703);
            Controls.Add(tresJugadores);
            Controls.Add(dosJugadores);
            Controls.Add(pictureBox1);
            Controls.Add(unJugador);
            Controls.Add(cuatroJugadores);
            Controls.Add(botonJugar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button botonJugar;
        private CheckBox cuatroJugadores;
        private CheckBox unJugador;
        private PictureBox pictureBox1;
        private CheckBox dosJugadores;
        private CheckBox tresJugadores;
    }
}