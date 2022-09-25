using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void newGameBtn_Click(object sender, EventArgs e)
        {
            GameLogic.NewGame(1, 200);
            statusLbl.ForeColor = Color.Black;
            statusLbl.Text = $"I thought of a number between {GameLogic.Min} and {GameLogic.Max}!";
            resultsLbx.Items.Clear(); 
        }

        private void GuessBtn_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(guessInputTxb.Text))
            {
            int userGuess = Convert.ToInt32(guessInputTxb.Text);
            GuessResult result = GameLogic.Guess(userGuess);
                switch (result)
            {
                case GuessResult.SmallerThanThought:
                    statusLbl.Text = "The guess is smaller than the thought number!";
                    statusLbl.ForeColor = Color.Blue;
                    break;
                case GuessResult.BiggerThanThought:
                    statusLbl.Text = "The guess is bigger than the thought number!";
                    statusLbl.ForeColor = Color.Red;
                    break;
                case GuessResult.Found:
                    statusLbl.Text = "You won!";
                    statusLbl.ForeColor = Color.Green;
                    break;
                default:
                    break;
            }
            resultsLbx.Items.Add(userGuess + " - " + statusLbl.Text);
            guessInputTxb.Clear();
            guessInputTxb.Focus();
            }
            else
            {
                MessageBox.Show("You didn't write a number!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void guessInputTxb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
