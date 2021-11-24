using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Card_Game_Solution_MrB
{
    public partial class frmMainForm : Form
    {
        string[] cardNumbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        string[] cardColours = { "red", "black", "yellow" };

        string[] cards = new string[30];

        Random rng = new Random();

        public frmMainForm()
        {
            // Login Players

            InitializeComponent();
            FillDeck();
            string[] shuffledDeck = Shuffle(cards);
            ListCards(shuffledDeck);
        }

        private string[] Shuffle(string[] items)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                int j = rng.Next(i, cards.Length);
                string temp = items[i];
                items[i] = items[j];
                items[j] = temp;
            }
            return items;
        }

        private void FillDeck()
        {
            // fill the deck with cards
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cards[count] = cardColours[i] + " " + cardNumbers[j];
                    count++;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMainForm_KeyDown(object sender, KeyEventArgs e)

        {

            if (e.Control && e.KeyCode == Keys.X)

            {
                Application.Exit();
            }

        }

        private void showDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCards(cards);
        }

        private void ListCards(string[] deck)
        {
            for (int i = 0; i < 30; i++)
            {
                MessageBox.Show(deck[i]);
            }
        }
    }
}
