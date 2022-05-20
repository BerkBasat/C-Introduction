using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_TahminEt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int userGuess;
        int guess;
        int guessAmount = 5;
        int level = 1;
        int guessPerLevel = 10;

        private void Form1_Load(object sender, EventArgs e)
        {

            userGuess = rnd.Next(1, 11);
            this.Text = userGuess.ToString();
            lblTahmin.Text = guessAmount.ToString();
            lblSeviye.Text = level.ToString();
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {


            if (guessAmount > 0)
            {
                guess = int.Parse(txtTahmin.Text);

                if (userGuess == guess)
                {
                    lblSonuc.Text = "You guessed right!";
                    level++;
                    lblSeviye.Text = level.ToString();
                    guessAmount = 5;
                    lblTahmin.Text = guessAmount.ToString();
                    userGuess = rnd.Next(1, (level *guessPerLevel+1));
                    this.Text = userGuess.ToString();
                }
                else if (userGuess < guess)
                {
                    lblSonuc.Text = "Guess a lower number!";
                    guessAmount--;
                    lblTahmin.Text = guessAmount.ToString();

                }
                else if (userGuess > guess)
                {
                    lblSonuc.Text = "Guess a higher number!";
                    guessAmount--;
                    lblTahmin.Text = guessAmount.ToString();
                }
            }
            else
            {
                MessageBox.Show("You lost!");
            }

            

           
        }
    }
}
