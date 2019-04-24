/*
 * Created by: Allan L
 * Created on: April 4, 2019
 * Created for: ICS3U Programming
 * Assignment 5b - Simple 21
 * This program is a simplified version of Blackjack the card game.
*/

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
        const int MIN_NUM = 2;
        int userNum1;
        int userNum2;
        int userNum3;
        int dealNum1;
        int dealNum2;
        int dealNum3;
        int userTotal;
        int dealTotal;
        int winCounter;

        //random number generator
        Random randomNumberGenerator = new Random();

        public frmSimplified21()
        {
            InitializeComponent();

            UserCards();

            //hiding picture boxes
            picUserCard3.Hide();

        }

        private void UserCards ()
        {

            //Generate random numbers
            userNum1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            userNum2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealNum1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealNum2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealNum3 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //user images 1
            if (userNum1 == 2)
            {

                this.picUserCard1.Image = Properties.Resources._0;

            }
            else if (userNum1 == 2)
            {

                this.picUserCard1.Image = Properties.Resources._1;

            }
            else if (userNum1 == 3)
            {

                this.picUserCard1.Image = Properties.Resources._5;

            }
            else if (userNum1 == 4)
            {

                this.picUserCard1.Image = Properties.Resources._11;

            }
            else if (userNum1 == 7)
            {

                this.picUserCard1.Image = Properties.Resources._20;

            }
            else if (userNum1 == 5)
            {

                this.picUserCard1.Image = Properties.Resources._13;

            }
            else if (userNum1 == 9)
            {

                this.picUserCard1.Image = Properties.Resources._28;

            }
            else if (userNum1 == 10)
            {

                this.picUserCard1.Image = Properties.Resources._46;

            }
            else if (userNum1 == 6)
            {

                this.picUserCard1.Image = Properties.Resources._17;

            }
            else if (userNum1 == 8)
            {

                this.picUserCard1.Image = Properties.Resources._25;

            }

            //user image 2
            if (userNum2 == 2)
            {

                this.picUserCard2.Image = Properties.Resources._2;

            }
            else if (userNum2 == 3)
            {

                this.picUserCard2.Image = Properties.Resources._6;

            }
            else if (userNum2 == 4)
            {

                this.picUserCard2.Image = Properties.Resources._11;

            }
            else if (userNum2 == 5)
            {

                this.picUserCard2.Image = Properties.Resources._15;

            }
            else if (userNum2 == 6)
            {

                this.picUserCard2.Image = Properties.Resources._19;

            }
            else if (userNum2 == 7)
            {

                this.picUserCard2.Image = Properties.Resources._23;

            }
            else if (userNum2 == 8)
            {

                this.picUserCard2.Image = Properties.Resources._27;

            }
            else if (userNum2 == 9)
            {

                this.picUserCard2.Image = Properties.Resources._30;

            }
            else if (userNum2 == 10)
            {

                this.picUserCard2.Image = Properties.Resources._46;

            }
            else if (userNum2 == 4)
            {

                this.picUserCard2.Image = Properties.Resources._10;

            }

            //show the total
            lblUserTotal.Text = Convert.ToString(userNum1 + userNum2);

            //show the Back of the cards
            this.picDealCard1.Image = Properties.Resources.CardBack;
            this.picDealCard2.Image = Properties.Resources.CardBack;
            this.picDealCard3.Image = Properties.Resources.CardBack;

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

        private void picdealCard1_Click(object sender, EventArgs e)
        {

        }

        private void picdealCard2_Click(object sender, EventArgs e)
        {

        }

        private void picdealCard3_Click(object sender, EventArgs e)
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
            userNum3 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //check to see who wins
            userTotal = userNum1 + userNum2 + userNum3;
            dealTotal = dealNum1 + dealNum2 + dealNum3;

            picUserCard3.Show();

            //userNum3 pictures
            if (userNum3 == 5)
            {

                this.picUserCard3.Image = Properties.Resources._14;

            }
            else if (userNum3 == 2)
            {

                this.picUserCard3.Image = Properties.Resources._3;

            }
            else if (userNum3 == 4)
            {

                this.picUserCard3.Image = Properties.Resources._9;

            }
            else if (userNum3 == 10)
            {

                this.picUserCard3.Image = Properties.Resources._47;

            }
            else if (userNum3 == 9)
            {

                this.picUserCard3.Image = Properties.Resources._31;

            }
            else if (userNum3 == 3)
            {

                this.picUserCard3.Image = Properties.Resources._5;

            }
            else if (userNum3 == 8)
            {

                this.picUserCard3.Image = Properties.Resources._26;

            }
            else if (userNum3 == 6)
            {

                this.picUserCard3.Image = Properties.Resources._17;

            }
            else if (userNum3 == 9)
            {

                this.picUserCard3.Image = Properties.Resources._29;

            }
            else if (userNum3 == 7)
            {

                this.picUserCard3.Image = Properties.Resources._22;

            }

            this.Refresh();

            //Check to see who won
            if (userTotal == dealTotal)
            {
                this.lblWinner.Text = "Draw";
            }
            else if (userTotal == 21)
            {
                this.lblWinner.Text = "Blackjack! You Win";
                winCounter++;
            }
            else if (dealTotal == 21)
            {
                this.lblWinner.Text = "Blackjack! dealer Wins";
            }
            else if (userTotal > 21)
            {
                this.lblWinner.Text = "Dealer Wins";
            }
            else if (dealTotal > 21)
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
            else if (userTotal > dealTotal)
            {
                this.lblWinner.Text = "You Win";
                winCounter++;
            }
            else if (userTotal < dealTotal)
            {
                this.lblWinner.Text = "Dealer Wins";
            }

            this.Refresh();

            //show the totals
            lblUserTotal.Text = Convert.ToString(userTotal);
            lblDealTotal.Text = Convert.ToString(dealTotal);

            //dealer card 1 pics
            if (dealNum1 == 5)
            {

                this.picDealCard1.Image = Properties.Resources._13;

            }
            else if (dealNum1 == 2)
            {

                this.picDealCard1.Image = Properties.Resources._3;

            }
            else if (dealNum1 == 3)
            {

                this.picDealCard1.Image = Properties.Resources._7;

            }
            else if (dealNum1 == 4)
            {

                this.picDealCard1.Image = Properties.Resources._10;

            }
            else if (dealNum1 == 5)
            {

                this.picDealCard1.Image = Properties.Resources._14;

            }
            else if (dealNum1 == 6)
            {

                this.picDealCard1.Image = Properties.Resources._18;

            }
            else if (dealNum1 == 7)
            {

                this.picDealCard1.Image = Properties.Resources._22;

            }
            else if (dealNum1 == 8)
            {

                this.picDealCard1.Image = Properties.Resources._25;

            }
            else if (dealNum1 == 9)
            {

                this.picDealCard1.Image = Properties.Resources._30;

            }
            else if (dealNum1 == 10)
            {

                this.picDealCard1.Image = Properties.Resources._47;

            }

            this.Refresh();

            //dealer card 2 pics 
            if (dealNum2 == 7)
            {

                this.picDealCard2.Image = Properties.Resources._23;

            }
            else if (dealNum2 == 2)
            {

                this.picDealCard2.Image = Properties.Resources._2;

            }
            else if (dealNum2 == 3)
            {


                this.picDealCard2.Image = Properties.Resources._7;

            }
            else if (dealNum2 == 4)
            {

                this.picDealCard2.Image = Properties.Resources._9;

            }
            else if (dealNum2 == 5)
            {

                this.picDealCard2.Image = Properties.Resources._13;

            }
            else if (dealNum2 == 6)
            {

                this.picDealCard2.Image = Properties.Resources._16;

            }
            else if (dealNum2 == 7)
            {

                this.picDealCard2.Image = Properties.Resources._21;

            }
            else if (dealNum2 == 8)
            {

                this.picDealCard2.Image = Properties.Resources._24;

            }
            else if (dealNum2 == 9)
            {

                this.picDealCard2.Image = Properties.Resources._29;

            }
            else if (dealNum2 == 10)
            {

                this.picDealCard2.Image = Properties.Resources._44;

            }

            this.Refresh();

            //dealer card 3
            if (dealNum3 == 10)
            {


                this.picDealCard3.Image = Properties.Resources._46;

            }
            else if (dealNum3 == 2)
            {

                this.picDealCard3.Image = Properties.Resources._0;

            }
            else if (dealNum3 == 3)
            {

                this.picDealCard3.Image = Properties.Resources._5;

            }
            else if (dealNum3 == 4)
            {

                this.picDealCard3.Image = Properties.Resources._8;

            }
            else if (dealNum3 == 5)
            {

                this.picDealCard3.Image = Properties.Resources._14;

            }
            else if (dealNum3 == 6)
            {

                this.picDealCard3.Image = Properties.Resources._17;

            }
            else if (dealNum3 == 7)
            {

                this.picDealCard3.Image = Properties.Resources._20;

            }
            else if (dealNum3 == 8)
            {

                this.picDealCard3.Image = Properties.Resources._26;

            }
            else if (dealNum3 == 9)
            {

                this.picDealCard3.Image = Properties.Resources._28;

            }
            else if (dealNum3 == 10)
            {

                this.picDealCard3.Image = Properties.Resources._45;

            }

            this.Refresh();

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
            dealTotal = dealNum1 + dealNum2 + dealNum3;

            if (userTotal == dealTotal)
            {
                this.lblWinner.Text = "Draw";
            }
            else if (userTotal == 21)
            {
                this.lblWinner.Text = "Blackjack! You Win";
                winCounter++;
            }
            else if (dealTotal == 21)
            {
                this.lblWinner.Text = "Blackjack! dealer Wins";
            }
            else if (userTotal > 21)
            {
                this.lblWinner.Text = "Dealer Wins";
            }
            else if (dealTotal > 21)
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
            else if (userTotal > dealTotal)
            {
                this.lblWinner.Text = "You Win";
                winCounter++;
            }
            else if (userTotal < dealTotal)
            {
                this.lblWinner.Text = "Dealer Wins";
            }

            //show the totals
            lblUserTotal.Text = Convert.ToString(userTotal);
            lblDealTotal.Text = Convert.ToString(dealTotal);

            //dealer card 1 pics
            if (dealNum1 == 2)
            {

                this.picDealCard1.Image = Properties.Resources._1;

            }
            else if (dealNum1 == 4)
            {

                this.picDealCard1.Image = Properties.Resources._8;

            }
            else if (dealNum1 == 3)
            {

                this.picDealCard1.Image = Properties.Resources._6;

            }
            else if (dealNum1 == 4)
            {

                this.picDealCard1.Image = Properties.Resources._11;

            }
            else if (dealNum1 == 5)

            {

                this.picDealCard1.Image = Properties.Resources._15;

            }
            else if (dealNum1 == 6)

            {

                this.picDealCard1.Image = Properties.Resources._18;

            }
            else if (dealNum1 == 7)

            {

                this.picDealCard1.Image = Properties.Resources._20;

            }
            else if (dealNum1 == 8)

            {

                this.picDealCard1.Image = Properties.Resources._24;

            }
            else if (dealNum1 == 9)

            {

                this.picDealCard1.Image = Properties.Resources._29;

            }
            else if (dealNum1 == 10)
            {

                this.picDealCard1.Image = Properties.Resources._45;

            }

            this.Refresh();

            //dealer card 2
            if (dealNum2 == 3)
            {

                this.picDealCard2.Image = Properties.Resources._6;

            }
            else if (dealNum2 == 2)
            {

                this.picDealCard2.Image = Properties.Resources._1;

            }
            else if (dealNum2 == 3)
            {

                this.picDealCard2.Image = Properties.Resources._7;

            }
            else if (dealNum2 == 4)
            {

                this.picDealCard2.Image = Properties.Resources._9;

            }
            else if (dealNum2 == 5)
            {

                this.picDealCard2.Image = Properties.Resources._12;

            }
            else if (dealNum2 == 6)
            {

                this.picDealCard2.Image = Properties.Resources._17;

            }
            else if (dealNum2 == 7)
            {

                this.picDealCard2.Image = Properties.Resources._23;

            }
            else if (dealNum2 == 8)
            {

                this.picDealCard2.Image = Properties.Resources._24;

            }
            else if (dealNum2 == 9)
            {

                this.picDealCard2.Image = Properties.Resources._28;

            }
            else if (dealNum2 == 10)
            {

                this.picDealCard2.Image = Properties.Resources._44;

            }

            this.Refresh();

            //Dealer card 3
            if (dealNum3 == 2)
            {

                this.picDealCard3.Image = Properties.Resources._1;

            }
            else if (dealNum3 == 2)
            {

                this.picDealCard3.Image = Properties.Resources._3;

            }
            else if (dealNum3 == 3)
            {

                this.picDealCard3.Image = Properties.Resources._5;

            }
            else if (dealNum3 == 4)
            {

                this.picDealCard3.Image = Properties.Resources._9;

            }
            else if (dealNum3 == 5)
            {

                this.picDealCard3.Image = Properties.Resources._15;

            }
            else if (dealNum3 == 6)
            {

                this.picDealCard3.Image = Properties.Resources._19;

            }
            else if (dealNum3 == 7)
            {

                this.picDealCard3.Image = Properties.Resources._22;

            }
            else if (dealNum3 == 8)
            {

                this.picDealCard3.Image = Properties.Resources._27;

            }
            else if (dealNum3 == 9)
            {

                this.picDealCard3.Image = Properties.Resources._29;

            }
            else if (dealNum3 == 10)
            {

                this.picDealCard3.Image = Properties.Resources._45;

            }

            this.Refresh();

            //disable buttons
            btnHit.Enabled = false;
            btnStay.Enabled = false;

            //Add to the wins
            lblNumOfWins.Text = Convert.ToString(winCounter);

            //enable play again
            btnPlayAgain.Enabled = true;

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            //hiding picture boxes
            picUserCard3.Hide();

            //Generate random numbers
            userNum1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            userNum2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealNum1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealNum2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealNum3 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //user images 1
            if (userNum1 == 6)
            {

                this.picUserCard1.Image = Properties.Resources._18;

            }
            else if (userNum1 == 2)
            {

                this.picUserCard1.Image = Properties.Resources._1;

            }
            else if (userNum1 == 3)
            {

                this.picUserCard1.Image = Properties.Resources._7;

            }
            else if (userNum1 == 4)
            {

                this.picUserCard1.Image = Properties.Resources._11;

            }
            else if (userNum1 == 5)
            {

                this.picUserCard1.Image = Properties.Resources._12;

            }
            else if (userNum1 == 6)
            {

                this.picUserCard1.Image = Properties.Resources._18;

            }
            else if (userNum1 == 7)
            {

                this.picUserCard1.Image = Properties.Resources._23;

            }
            else if (userNum1 == 8)
            {

                this.picUserCard1.Image = Properties.Resources._26;

            }
            else if (userNum1 == 9)
            {

                this.picUserCard1.Image = Properties.Resources._29;

            }
            else if (userNum1 == 10)
            {

                this.picUserCard1.Image = Properties.Resources._47;

            }

            this.Refresh();

            //user images 2
            if (userNum2 == 8)
            {

                this.picUserCard2.Image = Properties.Resources._24;

            }
            else if (userNum2 == 2)
            {

                this.picUserCard2.Image = Properties.Resources._2;

            }
            else if (userNum2 == 3)
            {

                this.picUserCard2.Image = Properties.Resources._4;

            }
            else if (userNum2 == 4)
            {

                this.picUserCard2.Image = Properties.Resources._10;

            }
            else if (userNum2 == 5)
            {

                this.picUserCard2.Image = Properties.Resources._12;

            }
            else if (userNum2 == 6)
            {

                this.picUserCard2.Image = Properties.Resources._18;

            }
            else if (userNum2 == 7)
            {

                this.picUserCard2.Image = Properties.Resources._20;

            }
            else if (userNum2 == 8)
            {

                this.picUserCard2.Image = Properties.Resources._25;

            }
            else if (userNum2 == 9)
            {

                this.picUserCard2.Image = Properties.Resources._31;

            }
            else if (userNum2 == 10)
            {

                this.picUserCard2.Image = Properties.Resources._46;

            }

            this.Refresh();

            //show the total
            lblUserTotal.Text = Convert.ToString(userNum1 + userNum2);
            //hide dealTotal
            lblDealTotal.Text = " ";

            //show the Back of the cards
            this.picDealCard1.Image = Properties.Resources.CardBack;
            this.picDealCard2.Image = Properties.Resources.CardBack;
            this.picDealCard3.Image = Properties.Resources.CardBack;

            //disable play again
            btnPlayAgain.Enabled = false;

            //enable hit and stay btns
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            //make ldlWinner display nothing
            lblWinner.Text = " ";
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniNewGame_Click(object sender, EventArgs e)
        {
            userNum1 = 0;
            userNum2 = 0;
            userNum3 = 0;
            dealNum1 = 0;
            dealNum2 = 0;
            dealNum3 = 0;
           
            //hiding picture boxes
            picUserCard3.Hide();

            //show the Back of the cards
            this.picDealCard1.Image = Properties.Resources.CardBack;
            this.picDealCard2.Image = Properties.Resources.CardBack;
            this.picDealCard3.Image = Properties.Resources.CardBack;

            lblWinner.Text = " ";

            //enable hit and stay buttons
            btnHit.Enabled = true;
            btnStay.Enabled = true;

            //hide dealTotal
            lblDealTotal.Text = " ???";

            //Generate random numbers
            userNum1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            userNum2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealNum1 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealNum2 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);
            dealNum3 = randomNumberGenerator.Next(MIN_NUM, MAX_NUM + 1);

            //user images 1
            if (userNum1 == 6)
            {

                this.picUserCard1.Image = Properties.Resources._18;

            }
            else if (userNum1 == 2)
            {

                this.picUserCard1.Image = Properties.Resources._1;

            }
            else if (userNum1 == 3)
            {

                this.picUserCard1.Image = Properties.Resources._7;

            }
            else if (userNum1 == 4)
            {

                this.picUserCard1.Image = Properties.Resources._11;

            }
            else if (userNum1 == 5)
            {

                this.picUserCard1.Image = Properties.Resources._12;

            }
            else if (userNum1 == 6)
            {

                this.picUserCard1.Image = Properties.Resources._18;

            }
            else if (userNum1 == 7)
            {

                this.picUserCard1.Image = Properties.Resources._23;

            }
            else if (userNum1 == 8)
            {

                this.picUserCard1.Image = Properties.Resources._26;

            }
            else if (userNum1 == 9)
            {

                this.picUserCard1.Image = Properties.Resources._29;

            }
            else if (userNum1 == 10)
            {

                this.picUserCard1.Image = Properties.Resources._47;

            }

            this.Refresh();

            //user images 2
            if (userNum2 == 8)
            {

                this.picUserCard2.Image = Properties.Resources._24;

            }
            else if (userNum2 == 2)
            {

                this.picUserCard2.Image = Properties.Resources._2;

            }
            else if (userNum2 == 3)
            {

                this.picUserCard2.Image = Properties.Resources._4;

            }
            else if (userNum2 == 4)
            {

                this.picUserCard2.Image = Properties.Resources._10;

            }
            else if (userNum2 == 5)
            {

                this.picUserCard2.Image = Properties.Resources._12;

            }
            else if (userNum2 == 6)
            {

                this.picUserCard2.Image = Properties.Resources._18;

            }
            else if (userNum2 == 7)
            {

                this.picUserCard2.Image = Properties.Resources._20;

            }
            else if (userNum2 == 8)
            {

                this.picUserCard2.Image = Properties.Resources._25;

            }
            else if (userNum2 == 9)
            {

                this.picUserCard2.Image = Properties.Resources._31;

            }
            else if (userNum2 == 10)
            {

                this.picUserCard2.Image = Properties.Resources._46;

            }

            this.Refresh();

            //show the total
            lblUserTotal.Text = Convert.ToString(userNum1 + userNum2);

            lblNumOfWins.Text =" 0";

            //Reset Win Counter
            winCounter = 0;
        }
    }
}
