using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGNumbers_Click(object sender, EventArgs e)
        {
            //array to hold random numbers.
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];

            //generate random numbers.
            Random rand = new Random();

            //fill in the array with random numbers ranges from 0 to 99.

            for(int i =0; i < lotteryNumbers.Length; i++)
            {
                lotteryNumbers[i] = rand.Next(100);
            }
            //display the arrays.
            textBox1.Text = lotteryNumbers[0].ToString();
            textBox2.Text = lotteryNumbers[1].ToString();
            textBox3.Text = lotteryNumbers[2].ToString();
            textBox4.Text = lotteryNumbers[3].ToString();
            textBox5.Text = lotteryNumbers[4].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
