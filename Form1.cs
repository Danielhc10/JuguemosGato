using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuguemosGato
{
    public partial class Form1 : Form
    {

        public enum Player
        {
            X, O
        }

        
        List<Button> buttons;
        Random rand = new Random();

        string nombre = "";
        string PlayerJuego = "X"; //ingnora la X es la seleccion de ficha
        string IAJuego = "O"; //La ficha que le toca a Michi
        int playerWins = 0;
        int IAWins = 0;

        public Form1()
        {
            InitializeComponent();
            resetGame();
            this.reset.Enabled = false;
            panel2.Visible = true; //XO
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void playerClick(object sender, EventArgs e)
        {
            if (buttons.Count > 0) { 
                var button = (Button)sender;
                //jugadorActual = Player.X;
                button.Text = PlayerJuego; //xo
                button.Enabled = false;
                button.BackColor = System.Drawing.Color.Cyan;
                buttons.Remove(button);
                Check();
                IA.Start();
            }
        }
        private void IAmoves(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); 
                buttons[index].Enabled = false; 
                //jugadorActual = Player.O; // set the AI with O
                buttons[index].Text = IAJuego; // show O on the button xo
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon; // change the background of the button dark salmon colour
                buttons.RemoveAt(index); // remove that button from the list
                Check(); // check if the AI won anything
                IA.Stop(); // stop the AI timer
            }
        }
        private void loadbuttons()
        {
            buttons = new List<Button> { a1, a2, a3, b1, b2, b3, c1, c2, c3 };

        }
        private void resetGame()
        {
            a1.Text = "";
            a2.Text = "";
            a3.Text = "";
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            c1.Text = "";
            c2.Text = "";
            c3.Text = "";
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            c1.Enabled = true;
            c2.Enabled = true;
            c3.Enabled = true;
            a1.BackColor = default(Color);
            a2.BackColor = default(Color);
            a3.BackColor = default(Color);
            b1.BackColor = default(Color);
            b2.BackColor = default(Color);
            b3.BackColor = default(Color);
            c1.BackColor = default(Color);
            c2.BackColor = default(Color);
            c3.BackColor = default(Color);

            loadbuttons();   
        }
        private void Check()
        {
            if (a1.Text == PlayerJuego && a2.Text == PlayerJuego && a3.Text == PlayerJuego
               || b1.Text == PlayerJuego && b2.Text == PlayerJuego && b3.Text == PlayerJuego
               || c1.Text == PlayerJuego && c2.Text == PlayerJuego && c3.Text == PlayerJuego
               || a1.Text == PlayerJuego && b1.Text == PlayerJuego && c1.Text == PlayerJuego
               || a2.Text == PlayerJuego && b2.Text == PlayerJuego && c2.Text == PlayerJuego
               || a3.Text == PlayerJuego && b3.Text == PlayerJuego && c3.Text == PlayerJuego
               || a1.Text == PlayerJuego && b2.Text == PlayerJuego && c3.Text == PlayerJuego
               || a3.Text == PlayerJuego && b2.Text == PlayerJuego && c1.Text == PlayerJuego)//XO
            {
                
                IA.Stop(); //stop the timer
                MessageBox.Show(nombre + " Ganó! "); // show a message to the player
                playerWins++; // increase the player wins 
                txtPlayer.Text = (nombre + " Puntos: " + playerWins); // update player label
                resetGame(); // run the reset game function
            }
            // below if statement is for when the AI wins the game
            else if (a1.Text == IAJuego && a2.Text == IAJuego && a3.Text == IAJuego
                   || b1.Text == IAJuego && b2.Text == IAJuego && b3.Text == IAJuego
                   || c1.Text == IAJuego && c2.Text == IAJuego && c3.Text == IAJuego
                   || a1.Text == IAJuego && b1.Text == IAJuego && c1.Text == IAJuego
                   || a2.Text == IAJuego && b2.Text == IAJuego && c2.Text == IAJuego
                   || a3.Text == IAJuego && b3.Text == IAJuego && c3.Text == IAJuego
                   || a1.Text == IAJuego && b2.Text == IAJuego && c3.Text == IAJuego
                   || a3.Text == IAJuego && b2.Text == IAJuego && c1.Text == IAJuego)//XO
            {

                IA.Stop(); // stop the timer
                MessageBox.Show("Michi Ganó"); // show a message box to say computer won
                IAWins++; // increase the computer wins score number
                txtMichi.Text = "Michi Puntos:" + IAWins; // update the label 2 for computer wins
                resetGame(); // run the reset game
            }else if (buttons.Count == 0)
            {
                //empate Xo
                MessageBox.Show("¡Empate!", "Oh!, No", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }

        }
        
        private void iniciarJuego(object sender, EventArgs e)
        {

            if (namePlayer.Text == "")
            {
                MessageBox.Show("¿Contra quien voy a jugar?", "Ingresa un nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (namePlayer.Text != "" && (radioButton1.Checked || radioButton2.Checked))
            {
                nombre = namePlayer.Text;
                txtPlayer.Text = (nombre + " Puntos: " + playerWins);
                reset.Enabled = true;
                resetGame();
                panel1.Visible = true;//XO
                if (radioButton1.Checked)
                {
                    PlayerJuego = "X";
                    IAJuego = "O";
                }
                else
                {
                    PlayerJuego = "O";
                    IAJuego = "X";
                }
            }
            else
            {
                MessageBox.Show("Elige X o O para jugar", "Selecciona una ficha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void reiniciarJuego(object sender, EventArgs e)
        {
            resetGame();
            panel2.Visible = true;//nombre x o
            panel1.Visible = false;// juego
            txtMichi.Text = "Michi Puntos: 0";
            txtPlayer.Text = "Player Puntos: 0";
            IAWins = 0;
            playerWins = 0;
        }

        private void Foto_gato_Click(object sender, EventArgs e)
        {
            resetGame();
            //txtMichi.Text = "Michi Puntos: 0";
            //txtPlayer.Text = "Player Puntos: 0";
        }
    }
}

