namespace PruebaLudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            botonJugar.Enabled = false;
        }

        private void botonJugar_Click(object sender, EventArgs e)
        {
            if (cuatroJugadores.Checked)
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else if (unJugador.Checked)
            {
                LudoUnJugador player = new LudoUnJugador();
                player.Show();
                this.Hide();

            }
            else if (dosJugadores.Checked)
            {
                dosJugadores dosjugadores = new dosJugadores();
                dosjugadores.Show();
                this.Hide();

            }
            else if (tresJugadores.Checked)
            {
                TresJugadores tresjugadores = new TresJugadores();
                tresjugadores.Show();
                this.Hide();

            }
        }

        private void cuatroJugadores_CheckedChanged(object sender, EventArgs e)
        {
            botonJugar.Enabled = true;
            unJugador.Checked = false;
            dosJugadores.Checked = false;
            tresJugadores.Checked = false;
        }

        private void unJugador_CheckedChanged(object sender, EventArgs e)
        {
            botonJugar.Enabled = true;
            cuatroJugadores.Checked = false;
            dosJugadores.Checked = false;
            tresJugadores.Checked = false;
        }

        private void dosJugadores_CheckedChanged(object sender, EventArgs e)
        {
            botonJugar.Enabled = true;
            cuatroJugadores.Checked = false;
            unJugador.Checked = false;
            tresJugadores.Checked = false;
        }

        private void tresJugadores_CheckedChanged(object sender, EventArgs e)
        {
            botonJugar.Enabled = true;
            cuatroJugadores.Checked = false;
            dosJugadores.Checked = false;
            unJugador.Checked = false;

        }
    }
}