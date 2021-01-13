using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {

                const int SIZE = 5;
                int[] numbers = new int[SIZE];
                int index = 0;
                StreamReader inputFile;
                inputFile = File.OpenText("Values1.txt");

                //Read file.
                while(index < numbers.Length-1 && !inputFile.EndOfStream)
                {
                    numbers[index] = int.Parse(inputFile.ReadLine());
                    

                    txtValue.Text += numbers[index]+ "\r\n";
                    index++;


                } 
                

                inputFile.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
