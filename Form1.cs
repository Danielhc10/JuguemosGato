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

        Player jugadorActual;
        List<Button> buttons;
        Random rand = new Random();

        string nombre = "";
        
        int playerWins = 0;
        int IAWins = 0;

        public Form1()
        {
            InitializeComponent();
            resetGame();
            this.reinicio.Enabled = false;
            this.btnO.Visible = false;
            this.btnX.Visible = false;
            this.botoncitos.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnOffBtn(false);
        }

        private void OnOffBtn(bool OnOff)
        {
            a1.Enabled = OnOff;
            a2.Enabled = OnOff;
            a3.Enabled = OnOff;
            b1.Enabled = OnOff;
            b2.Enabled = OnOff;
            b3.Enabled = OnOff;
            c1.Enabled = OnOff;
            c2.Enabled = OnOff;
            c3.Enabled = OnOff;
        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; // find which button was clicked
            jugadorActual = Player.X; // set the player to X
            button.Text = jugadorActual.ToString(); // change the button text to player X
            button.Enabled = false; // disable the button
            button.BackColor = System.Drawing.Color.Cyan; // change the player colour to Cyan
            buttons.Remove(button); //remove the button from the list buttons so the AI can't click it either
            Check(); // check if the player won
            IA.Start(); // stop the AI timer
        }
        private void IAmoves(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); // generate a random number within the number of buttons available
                buttons[index].Enabled = false; // assign the number to the button
                                                // when the random number is generated then we will look into the list
                                                // for what that number is we select that button
                                                // for example if the number is 8
                                                // then we select the 8th button in the listO
                jugadorActual = Player.O; // set the AI with O
                buttons[index].Text = jugadorActual.ToString(); // show O on the button
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
            foreach (Control X in this.Controls)
            {
                if (X is Button && X != playGame && X != reinicio/**&& X.Tag == "play"**/)
                {
                    ((Button)X).Enabled = true; // change them all back to enabled or clickable
                    ((Button)X).Text = "?"; // set the text to question mark
                    ((Button)X).BackColor = default(Color); // change the background colour to default button colors
                }
            }

            loadbuttons();
        }
        private void Check()
        {
            if (a1.Text == "X" && a2.Text == "X" && a3.Text == "X"
               || b1.Text == "X" && b2.Text == "X" && b3.Text == "X"
               || c1.Text == "X" && c2.Text == "X" && c3.Text == "X"
               || a1.Text == "X" && b1.Text == "X" && c1.Text == "X"
               || a2.Text == "X" && b2.Text == "X" && c2.Text == "X"
               || a3.Text == "X" && b3.Text == "X" && c3.Text == "X"
               || a1.Text == "X" && b2.Text == "X" && c3.Text == "X"
               || a3.Text == "X" && b2.Text == "X" && c1.Text == "X")
            {
                // if any of the above conditions are met
                IA.Stop(); //stop the timer
                MessageBox.Show(nombre + " Wins"); // show a message to the player
                playerWins++; // increase the player wins 
                txtPlayer.Text = (nombre + " Wins - " + playerWins); // update player label
                resetGame(); // run the reset game function
            }
            // below if statement is for when the AI wins the game
            else if (a1.Text == "O" && a2.Text == "O" && a3.Text == "O"
                   || b1.Text == "O" && b2.Text == "O" && b3.Text == "O"
                   || c1.Text == "O" && c2.Text == "O" && c3.Text == "O"
                   || a1.Text == "O" && b1.Text == "O" && c1.Text == "O"
                   || a2.Text == "O" && b2.Text == "O" && c2.Text == "O"
                   || a3.Text == "O" && b3.Text == "O" && c3.Text == "O"
                   || a1.Text == "O" && b2.Text == "O" && c3.Text == "O"
                   || a3.Text == "O" && b2.Text == "O" && c1.Text == "O")
            {

                // if any of the conditions are met above then we will do the following
                // this code will run when the AI wins the game
                IA.Stop(); // stop the timer
                MessageBox.Show("Michi Wins"); // show a message box to say computer won
                IAWins++; // increase the computer wins score number
                txtMichi.Text = "Michi wins - " + IAWins; // update the label 2 for computer wins
                resetGame(); // run the reset game
            }

        }
        
        private void iniciarJuego(object sender, EventArgs e)
        {

            if (namePlayer.Text == "")
            {
                MessageBox.Show("¿Contra quien voy a jugar?", "Ingresa un nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (namePlayer.Text != "")
            {
                nombre = namePlayer.Text;
                txtPlayer.Text = (nombre + " Wins - " + playerWins);
                reinicio.Enabled = true;
                resetGame();
            }
        }
        private void reiniciarJuego(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}

