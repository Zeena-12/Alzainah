using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;


namespace hangman_1
{
    public partial class Form3 : Form
{
      private Image[] hangImages = { hangman_1.Properties.Resources.Hang1, hangman_1.Properties.Resources.Hang2, hangman_1.Properties.Resources.Hang3, hangman_1.Properties.Resources.Hang4, hangman_1.Properties.Resources.Hang5, hangman_1.Properties.Resources.Hang6, hangman_1.Properties.Resources.Hang7 };


        private int wrongGuesses = 0;
        private string[] words;
        private string copyCurrent = "";
        private string current = "";
        public Form3()
        {
            InitializeComponent();
        }

        private string[] words;
        private void loadwords()
        {
            string[] words = new string[4] {"green", "laya" ,"japan" ,"moroco"   };






        }
        int guessIndex;
        private void setupWordChoise()
        {

            wrongGuesses = 0;
            hangImage.Image = hangImages[wrongGuesses];
            int guessIndex=(new Random()).Next(words.Length);
           string  current = words[guessIndex];

            copyCurrent = "";
            for(int index = 0; index < current.Length; index++)
            {
                copyCurrent += "_";
                Console.WriteLine(copyCurrent);
            }

            displayCopy();
        }
        private void displayCopy()
        {
            lblShowWord.Text = "";
            for (int index = 0; index < current.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index, 1);
                lblShowWord.Text += " ";
                   
            }
        }
        private void updateCopy(char guess)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoise();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void cmdA_Click(object sender, EventArgs e)
        {

            Button choice = sender as Button;
            choice.Enabled = false;
                if (current.Contains(choice.Text))
                {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);
               
                for(int index=0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();
            }
            else
            {
             wrongGuesses++;
            }
           
            if(wrongGuesses<7)
            {  
                hangImage.Image = hangImages [wrongGuesses];
            }
            else 
            {
                lblResult.Text = "You Lose!!!";
            }
            if (copyCurrent.Equals(current))
            {
                lblResult.Text = "You win!!!";
            }




        


    }

        private void button24_Click(object sender, EventArgs e)
        {
            setupWordChoise();
            lblResult.Text = "";
            Button choice = sender as Button;
             choice.Enabled =true;
          
        }
    }
}
