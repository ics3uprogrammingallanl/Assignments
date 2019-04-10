using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simplified21AllanL
{
    public partial class frmSimplified21 : Form
    {
        //Global variables
        const int MAX_NUM = 10;
        const int MIN_NUM = 1;
        int userNum1;
        int userNum2;
        int userNum3;
        int DealNum1;
        int DealNum2;
        int DealNum3;
        int userTotal;
        int DealTotal;
        int winCounter;

        //random number generator
        Random randomNumberGenerator = new Random();

        public frmSimplified21()
        {
            InitializeComponent();

            //hiding picture boxes
            picUserCard3.Hide();

            //Generate random numbers
            userNum1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            userNum2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            DealNum1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            DealNum2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            DealNum3 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //userNum1 images
            if (userNum1 == 1)
            {
                this.picUserCard1.Image = Properties.Resources._1S;
            }
            else if (userNum1 == 2)
            {
                this.picUserCard1.Image = Properties.Resources._2s;
            }
            else if (userNum1 == 3)
            {
                this.picUserCard1.Image = Properties.Resources._3S;
            }
            else if (userNum1 == 4)
            {
                this.picUserCard1.Image = Properties.Resources._4S;
            }
            else if (userNum1 == 5)
            {
                this.picUserCard1.Image = Properties.Resources._5S;
            }
            else if (userNum1 == 6)
            {
                this.picUserCard1.Image = Properties.Resources._6S;
            }
            else if (userNum1 == 7)
            {
                this.picUserCard1.Image = Properties.Resources._7S;
            }
            else if (userNum1 == 8)
            {
                this.picUserCard1.Image = Properties.Resources._8S;
            }
            else if (userNum1 == 9)
            {
                this.picUserCard1.Image = Properties.Resources._9S;
            }
            else if (userNum1 == 10)
            {
                this.picUserCard1.Image = Properties.Resources._10S;
            }

            //userNum2 images
            if (userNum2 == 1)
            {
                this.picUserCard2.Image = Properties.Resources.AS;
            }
            else if (userNum2 == 2)
            {
                this.picUserCard2.Image = Properties.Resources._2S;
            }
            else if (userNum2 == 3)
            {
                this.picUserCard2.Image = Properties.Resources._3S;
            }
            else if (userNum2 == 4)
            {
                this.picUserCard2.Image = Properties.Resources._4S;
            }
            else if (userNum2 == 5)
            {
                this.picUserCard2.Image = Properties.Resources._5S;
            }
            else if (userNum2 == 6)
            {
                this.picUserCard2.Image = Properties.Resources._6S;
            }
            else if (userNum2 == 7)
            {
                this.picUserCard2.Image = Properties.Resources._7S;
            }
            else if (userNum2 == 8)
            {
                this.picUserCard2.Image = Properties.Resources._8S;
            }
            else if (userNum2 == 9)
            {
                this.picUserCard2.Image = Properties.Resources._9S;
            }
            else if (userNum2 == 10)
            {
                this.picUserCard2.Image = Properties.Resources._10S;
            }

            //show the total
            lblUserTotal.Text = Convert.ToString(userNum1 + userNum2);

            //show the front of the cards
            this.picDealCard1.Image = Properties.Resources.Front;
            this.picDealCard2.Image = Properties.Resources.Front;
            this.picDealCard3.Image = Properties.Resources.Front;

            //disable play again
            btnPlayAgain.Enabled = false;
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void frmSimplified21_Load(object sender, EventArgs e)
        {

        }

        private void picUserCard2_Click(object sender, EventArgs e)
        {

        }

        private void picDealCard1_Click(object sender, EventArgs e)
        {

        }

        private void picDealCard2_Click(object sender, EventArgs e)
        {

        }

        private void picDealCard3_Click(object sender, EventArgs e)
        {

        }

        private void picUserCard3_Click(object sender, EventArgs e)
        {

        }

        private void picUserCard1_Click(object sender, EventArgs e)
        {

        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            //Generate a new random number and set it to userNum3
            userNum3 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //check to see who wins
            userTotal = userNum1 + userNum2 + userNum3;
            DealTotal = DealNum1 + DealNum2 + DealNum3;

            //show the picbox
            picUserCard3.Show();

            //userNum3 pictures
            if (userNum3 == 1)
            {
                this.picUserCard3.Image = Properties.Resources.AS;
            }
            else if (userNum3 == 2)
            {
                this.picUserCard3.Image = Properties.Resources._2S;
            }
            else if (userNum3 == 3)
            {
                this.picUserCard3.Image = Properties.Resources._3S;
            }
            else if (userNum3 == 4)
            {
                this.picUserCard3.Image = Properties.Resources._4S;
            }
            else if (userNum3 == 5)
            {
                this.picUserCard3.Image = Properties.Resources._5S;
            }
            else if (userNum3 == 6)
            {
                this.picUserCard3.Image = Properties.Resources._6S;
            }
            else if (userNum3 == 7)
            {
                this.picUserCard3.Image = Properties.Resources._7S;
            }
            else if (userNum3 == 8)
            {
                this.picUserCard3.Image = Properties.Resources._8S;
            }
            else if (userNum3 == 9)
            {
                this.picUserCard3.Image = Properties.Resources._9S;
            }
            else if (userNum3 == 10)
            {
                this.picUserCard3.Image = Properties.Resources._10S;
            }

            //Check to see who won or lost
            if (userTotal == DealTotal)
            {
                this.lblWinner.Text = "Draw";
            }
            else if (userTotal == 21)
            {
                this.lblWinner.Text = "Blackjack! You Win";
                winCounter++;
            }
            else if (DealTotal == 21)
            {
                this.lblWinner.Text = "Blackjack! Dealer Wins";
            }
            else if (userTotal > 21)
            {
                this.lblWinner.Text = "Dealer Wins";
            }
            else if (DealTotal > 21)
            {
                if (userTotal < 21)
                {
                    this.lblWinner.Text = "You Win!";
                    winCounter++;
                }
                else
                {
                    this.lblWinner.Text = "Dealer Wins";
                }
            }
            else if (userTotal > DealTotal)
            {
                this.lblWinner.Text = "You Win";
                winCounter++;
            }
            else if (userTotal < DealTotal)
            {
                this.lblWinner.Text = "Dealer Wins";
            }

            //show the totals
            lblUserTotal.Text = Convert.ToString(userTotal);
            lblDealTotal.Text = Convert.ToString(DealTotal);

            //comp card pics 1
            if (DealNum1 == 1)
            {
                this.picDealCard1.Image = Properties.Resources.AS;
            }
            else if (DealNum1 == 2)
            {
                this.picDealCard1.Image = Properties.Resources._2S;
            }
            else if (DealNum1 == 3)
            {
                this.picDealCard1.Image = Properties.Resources._3S;
            }
            else if (DealNum1 == 4)
            {
                this.picDealCard1.Image = Properties.Resources._4S;
            }
            else if (DealNum1 == 5)
            {
                this.picDealCard1.Image = Properties.Resources._5S;
            }
            else if (DealNum1 == 6)
            {
                this.picDealCard1.Image = Properties.Resources._6S;
            }
            else if (DealNum1 == 7)
            {
                this.picDealCard1.Image = Properties.Resources._7S;
            }
            else if (DealNum1 == 8)
            {
                this.picDealCard1.Image = Properties.Resources._8S;
            }
            else if (DealNum1 == 9)
            {
                this.picDealCard1.Image = Properties.Resources._9S;
            }
            else if (DealNum1 == 10)
            {
                this.picDealCard1.Image = Properties.Resources._10S;
            }

            //comp card pics 2
            if (DealNum2 == 1)
            {
                this.picDealCard2.Image = Properties.Resources.AS;
            }
            else if (DealNum2 == 2)
            {
                this.picDealCard2.Image = Properties.Resources._2S;
            }
            else if (DealNum2 == 3)
            {
                this.picDealCard2.Image = Properties.Resources._3S;
            }
            else if (DealNum2 == 4)
            {
                this.picDealCard2.Image = Properties.Resources._4S;
            }
            else if (DealNum2 == 5)
            {
                this.picDealCard2.Image = Properties.Resources._5S;
            }
            else if (DealNum2 == 6)
            {
                this.picDealCard2.Image = Properties.Resources._6S;
            }
            else if (DealNum2 == 7)
            {
                this.picDealCard2.Image = Properties.Resources._7S;
            }
            else if (DealNum2 == 8)
            {
                this.picDealCard2.Image = Properties.Resources._8S;
            }
            else if (DealNum2 == 9)
            {
                this.picDealCard2.Image = Properties.Resources._9S;
            }
            else if (DealNum2 == 10)
            {
                this.picDealCard2.Image = Properties.Resources._10S;
            }

            //comp card pics 3
            if (DealNum3 == 1)
            {
                this.picDealCard3.Image = Properties.Resources.AS;
            }
            else if (DealNum3 == 2)
            {
                this.picDealCard3.Image = Properties.Resources._2S;
            }
            else if (DealNum3 == 3)
            {
                this.picDealCard3.Image = Properties.Resources._3S;
            }
            else if (DealNum3 == 4)
            {
                this.picDealCard3.Image = Properties.Resources._4S;
            }
            else if (DealNum3 == 5)
            {
                this.picDealCard3.Image = Properties.Resources._5S;
            }
            else if (DealNum3 == 6)
            {
                this.picDealCard3.Image = Properties.Resources._6S;
            }
            else if (DealNum3 == 7)
            {
                this.picDealCard3.Image = Properties.Resources._7S;
            }
            else if (DealNum3 == 8)
            {
                this.picDealCard3.Image = Properties.Resources._8S;
            }
            else if (DealNum3 == 9)
            {
                this.picDealCard3.Image = Properties.Resources._9S;
            }
            else if (DealNum3 == 10)
            {
                this.picDealCard3.Image = Properties.Resources._10S;
            }

            //disable buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            //Add to the wins
            lblNumOfWins.Text = Convert.ToString(winCounter);

            //enable play again
            btnPlayAgain.Enabled = true;
        }

        private void btnStay_Click(object sender, EventArgs e)
        {
            //check to see who wins
            userTotal = userNum1 + userNum2;
            DealTotal = DealNum1 + DealNum2 + DealNum3;

            //Check to see who won or lost
            if (userTotal == DealTotal)
            {
                this.lblWinner.Text = "Draw";
            }
            else if (userTotal == 21)
            {
                this.lblWinner.Text = "Blackjack! You Win";
                winCounter++;
            }
            else if (DealTotal == 21)
            {
                this.lblWinner.Text = "Blackjack! Dealer Wins";
            }
            else if (userTotal > 21)
            {
                this.lblWinner.Text = "Dealer Wins";
            }
            else if (DealTotal > 21)
            {
                if (userTotal < 21)
                {
                    this.lblWinner.Text = "You Win!";
                    winCounter++;
                }
                else
                {
                    this.lblWinner.Text = "Dealer Wins";
                }
            }
            else if (userTotal > DealTotal)
            {
                this.lblWinner.Text = "You Win";
                winCounter++;
            }
            else if (userTotal < DealTotal)
            {
                this.lblWinner.Text = "Dealer Wins";
            }

            //show the totals
            lblUserTotal.Text = Convert.ToString(userTotal);
            lblDealTotal.Text = Convert.ToString(DealTotal);

            //comp card pics 1
            if (DealNum1 == 1)
            {
                this.picDealCard1.Image = Properties.Resources.AS;
            }
            else if (DealNum1 == 2)
            {
                this.picDealCard1.Image = Properties.Resources._2S;
            }
            else if (DealNum1 == 3)
            {
                this.picDealCard1.Image = Properties.Resources._3S;
            }
            else if (DealNum1 == 4)
            {
                this.picDealCard1.Image = Properties.Resources._4S;
            }
            else if (DealNum1 == 5)
            {
                this.picDealCard1.Image = Properties.Resources._5S;
            }
            else if (DealNum1 == 6)
            {
                this.picDealCard1.Image = Properties.Resources._6S;
            }
            else if (DealNum1 == 7)
            {
                this.picDealCard.Image = Properties.Resources._7S;
            }
            else if (DealNum1 == 8)
            {
                this.picComp1.Image = Properties.Resources._8S;
            }
            else if (DealNum1 == 9)
            {
                this.picComp1.Image = Properties.Resources._9S;
            }
            else if (DealNum1 == 10)
            {
                this.picComp1.Image = Properties.Resources._10S;
            }

            //comp card pics 2
            if (compNum2 == 1)
            {
                this.picComp2.Image = Properties.Resources.AS;
            }
            else if (compNum2 == 2)
            {
                this.picComp2.Image = Properties.Resources._2S;
            }
            else if (compNum2 == 3)
            {
                this.picComp2.Image = Properties.Resources._3S;
            }
            else if (compNum2 == 4)
            {
                this.picComp2.Image = Properties.Resources._4S;
            }
            else if (compNum2 == 5)
            {
                this.picComp2.Image = Properties.Resources._5S;
            }
            else if (compNum2 == 6)
            {
                this.picComp2.Image = Properties.Resources._6S;
            }
            else if (compNum2 == 7)
            {
                this.picComp2.Image = Properties.Resources._7S;
            }
            else if (compNum2 == 8)
            {
                this.picComp2.Image = Properties.Resources._8S;
            }
            else if (compNum2 == 9)
            {
                this.picComp2.Image = Properties.Resources._9S;
            }
            else if (compNum2 == 10)
            {
                this.picComp2.Image = Properties.Resources._10S;
            }

            //comp card pics 3
            if (compNum3 == 1)
            {
                this.picComp3.Image = Properties.Resources.AS;
            }
            else if (compNum3 == 2)
            {
                this.picComp3.Image = Properties.Resources._2S;
            }
            else if (compNum3 == 3)
            {
                this.picComp3.Image = Properties.Resources._3S;
            }
            else if (compNum3 == 4)
            {
                this.picComp3.Image = Properties.Resources._4S;
            }
            else if (compNum3 == 5)
            {
                this.picComp3.Image = Properties.Resources._5S;
            }
            else if (compNum3 == 6)
            {
                this.picComp3.Image = Properties.Resources._6S;
            }
            else if (compNum3 == 7)
            {
                this.picComp3.Image = Properties.Resources._7S;
            }
            else if (compNum3 == 8)
            {
                this.picComp3.Image = Properties.Resources._8S;
            }
            else if (compNum3 == 9)
            {
                this.picComp3.Image = Properties.Resources._9S;
            }
            else if (compNum3 == 10)
            {
                this.picComp3.Image = Properties.Resources._10S;
            }

            //disable buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            //Add to the wins
            lblWins.Text = Convert.ToString(winCounter);

            //enable play again
            btnPlayAgain.Enabled = true;

        }
    }
}
