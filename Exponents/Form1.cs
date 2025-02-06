﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name:Shaun Hasson
 * Date:02/04/2025
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int num;

            // INPUT
            num = Convert.ToInt32(UxInputTextBox.Text);
            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            int squareAnswer = Square(num);
            UxOutputLabel.Text = "Square is " + squareAnswer.ToString();

            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */

            // OUTPUT
            // set the output to visible

            // turn the Go button off
        }

        public int Square(int num) // square(3)
        {
            // we will create this code in class
           return num * num;
        }

        //public int Cube(int num)
        //{
        //    // we will create this code in class
        //}

        private void xResetButton_Click(object sender, EventArgs e)
        {
            UxOutputLabel.Visible = true;
        }

    }
}
