using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;


namespace PlayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //playing the sound
            SoundPlayer bellPlayer = new SoundPlayer(Properties.Resources.Door_Bell_SoundBible_com_1986366504);
            bellPlayer.Play();
            Refresh();
            Thread.Sleep(1000);

            //get rid of start button
            startButton.Visible = false;

            //countdown 3 label and sound
            countdownLabel.Text = "Game will begin in 3...";
            SoundPlayer countdown1Player = new SoundPlayer(Properties.Resources.Door_Bell_SoundBible_com_1986366504);
            countdown1Player.Play();
            Refresh();
            Thread.Sleep(1000);

           //countdown 2 label and sound
            countdownLabel.Text = "Game will begin in 2...";
            SoundPlayer countdown2Player = new SoundPlayer(Properties.Resources.Door_Bell_SoundBible_com_1986366504);
            countdown2Player.Play();
            Refresh();
            Thread.Sleep(1000);

            //countdown 1 Label and sound
            countdownLabel.Text = "Game will begin in 1...";
            SoundPlayer countdown3Player = new SoundPlayer(Properties.Resources.Door_Bell_SoundBible_com_1986366504);
            countdown3Player.Play();
            Refresh();
            Thread.Sleep(1000);

            //start and backround colour
            countdownLabel.Text = "STARTING GAME !!!";
            this.BackColor = Color.SpringGreen; 
            SoundPlayer startPlayer = new SoundPlayer(Properties.Resources.Boxing_Bell_Start_Round_SoundBible_com_1691615580);
            startPlayer.Play();
            Refresh();
            Thread.Sleep(1000);




        }
    }
}
