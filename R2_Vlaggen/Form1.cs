using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace R2_Vlaggen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        Random rnd = new Random();

        int flagIndex;
        int[] flagRnd = new int[4];
        Button[] btnArray; 
        string countryCorrect;



        private void Form1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"landen.txt");
            lbLanden.Items.AddRange(lines);
            lbLanden.SelectedIndex = 0;
        }

        private void lbLanden_SelectedIndexChanged(object sender, EventArgs e)
        {
            pbVlag.Image = Image.FromFile(@"png/" + lbLanden.SelectedIndex + ".png");
        }



        public void quizMode()
        {
            lbLanden.Visible = false;
            pbVlag.Visible = false;

            lblCaption.Visible = true;
            btnA.Visible = true;
            btnB.Visible = true;
            btnC.Visible = true;
            btnD.Visible = true;
            pbFlagQuiz.Visible = true;

            btnArray = new Button[4] { btnA, btnB, btnC, btnD };
            flagIndex = rnd.Next(0, 196);
            countryCorrect = File.ReadAllLines("landen.txt").Skip(flagIndex).Take(1).First();

            int btnIndex = rnd.Next(0, 4);
            string[] rndCountries = new string[4];

            for (int b = 0; b < 4; b++)
            {
                btnArray[b].Text = "";
            }

            pbFlagQuiz.Image = Image.FromFile(@"png/" + flagIndex + ".png");

            btnArray[btnIndex].Text = countryCorrect;

            

            for (int i = 0; i < 4; i++)
                if (btnArray[i].Text == "")
                {
                    flagRnd[i] = rnd.Next(0, 196);
                    btnArray[i].Text = File.ReadAllLines("landen.txt").Skip(flagRnd[i]).Take(1).First();
                }

        }

        public void flagQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {

            quizMode();

           
        }

        private void btnQuiz(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (b.Text == countryCorrect)
            {
                System.Media.SystemSounds.Asterisk.Play();
                MessageBox.Show("Well done!");

                quizMode();
            }
            else
            {
                var soundPlayer = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                soundPlayer.Play();

                MessageBox.Show("Give it another try!");
            }
        }
    }
}
