using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lokaverkefni_Klasasafn;

/* Lokaverkefni
 * Vor 2017
 * Erla Óskarsdóttir
 * Hrafnkell Þorri Þrastarson */

namespace Lokaverkefni
{
    public partial class GameOver : Form
    {
        int newScore = 0, Totaltime = 0, words = 0;
        string gameTitle = "", age = "";
        bool newHighScore = false;

        public GameOver(bool highScore, int score, int time, string title, int wordCount, string a)
        {
            InitializeComponent();

            newHighScore = highScore;
            newScore = score;
            Totaltime = time;
            gameTitle = title;
            words = wordCount;
            age = a;
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            if (gameTitle == "SpaceBar")
            {
                SpaceBarKlasi space = new SpaceBarKlasi(gameTitle, newScore, Totaltime);
                lblInfo.Text = space.ToString();
            }
            else if (gameTitle == "TypingGame")
            {
                TypingGameKlasi type = new TypingGameKlasi(gameTitle, words, newScore, Totaltime);
                lblInfo.Text = type.ToString();
            }
            else if (gameTitle == "Village")
            {
                VillageKlasi village = new VillageKlasi(gameTitle, age, newScore, Totaltime);
                lblInfo.Text = village.ToString();
            }

            if (newHighScore == true)
            {
                pbHighScore.Show();
            }
        }
    }
}
