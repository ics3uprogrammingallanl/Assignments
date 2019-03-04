/*
 * Created by: Allan L
 * Created on: February 19 2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Name of Program
 * This program calculates the amount of time it takes for an object hit the ground.
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

namespace FallingObjectsAllanL
{
    public partial class frmFallingObjects : Form
    {
        public frmFallingObjects()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            String userIn = txtTime.Text;

            if (0 == 1)
            {
                lblAnswer.Text = "Input a number!";
            }
            else
            {
                lblAnswer.Text = Convert.ToString(100 - 0.5 * 9.81 * Math.Pow(Double.Parse(userIn), 2));
            }

        }

        private void frmFallingObjects_Load(object sender, EventArgs e)
        {

        }
    }
}
