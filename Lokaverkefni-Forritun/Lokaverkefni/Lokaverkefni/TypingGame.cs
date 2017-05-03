using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokaverkefni
{
    public partial class TypingGame : Form
    {

        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        string username = "";

        public TypingGame(string user)
        {
            InitializeComponent();

            username = user;

            //Hér er reynt að tengjast við gagnagrunnin sjálfan, sett í try/catch svo hægt sé að grípa villu ef hún kemur upp án þess að forritið krassar
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {
                //MessageBox kemur upp ef upp kemur villa
                MessageBox.Show(ex.ToString());
            }
        }

        const int wordCount = 210;
        Random random = new Random();

        int timeleft = 30, number = 0, points = 0, comboCounter = 0;

        string[] basicWords = new string[wordCount] { "apple", "above", "again", "age", "agree", "after", "air", "alone", "army", "attack", "away", 
                "baby", "back", "behind", "black", "better", "beer", "bridge", "born", "begin", 
                "cake", "call", "candle", "card", "class", "cold", "clean", "colour", "corner", 
                "dance", "dark", "day", "dead", "dirty", "duck", "draw", "dog", "drink", 
                "early", "east", "effect", "eight", "empty", "enter", "except", "enjoy", "enemy", 
                "face", "fact", "false", "family", "finger", "freeze", "friend", "flour", "forest", 
                "game", "garden", "gift", "glass", "ground", "grow", "grave", "great", "goat", 
                "hair", "hammer", "happen", "hate", "head", "height", "horse", "hotel", "hungry", "hostel", "hoard",
                "ice", "idea", "inside", "into", "invent", "iron", "invite", "island", 
                "jelly", "job", "join", "juice", "jump", "just", 
                "keep", "key", "kill", "kind", "king", "kitchen", "knee", "knife", "knock", "know", 
                "ladder", "lady", "lamp", "lately", "lazy", "light", "length", "lesson", "library", 
                "male", "mark", "matter", "meal", "mother", "move", "music", "monkey", "million", 
                "name", "number", "next", "night", "noise", "north", "nothing", "nation", "needle", 
                "object", "ocean", "outside", "over", "order", "open", "orange", "only", "opposite", 
                "page", "paint", "parent", "partner", "party", "plane", "popular", "promise", "please", 
                "queen", "question", "quick", "quiet", "quite", 
                "radio", "rainy", "read", "record", "report", "rubber", "rush", "remind", "repair", "rule", 
                "safe", "salt", "school", "search", "second", "shout", "sleep", "sound", "station", 
                "time", "table", "taxi", "thick", "travel", "train", "three", "tennis", "today", "toe", 
                "ugly", "uncle", "under", "unit", "until", "use", "useful", "usual", "usually", 
                "vegetable", "very", "village", "voice", "visit", 
                "wait", "walk", "wedding", "welcome", "water", "window", "world", "winter", "while", 
                "yard", "yell", "yet", "you", "young", "your", "zero", "zoo"};

        Adferdir adferdir = new Adferdir();

        private void TypingGame_Load(object sender, EventArgs e)
        {
            tbWord.Enabled = false;
        }

        //Þetta er til þess að loka forritinu alveg þegar ýtt er á takkann X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show(adferdir.instructionsTyping());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adalform menu = new Adalform("");
            menu.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblTimer.Text = "Time left: 30";
            timeleft = 30;
            timer1.Interval = 1000;
            timer1.Start();

            tbWord.Focus();
            tbWord.Enabled = true;
            comboCounter = 0;
            lblCombo.Text = "";

            points = 0;
            lblPoints.Text = "0 points";

            btnMenu.Hide();
            btnInstructions.Hide();

            number = random.Next(0, wordCount);
            lblWord.Text = basicWords[number];

            btnStart.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int score = 0, userID = 0;

            if (timeleft == 0)
            {
                timer1.Stop();
                tbWord.Enabled = false;
                btnStart.Visible = true;
                btnMenu.Show();
                btnInstructions.Show();
                tbWord.Clear();
            }
            else
            {
                timeleft = timeleft - 1;
            }
            lblTimer.Text = "Time left: " + timeleft.ToString();
        }

        private void tbWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string word = tbWord.Text;

                tbWord.Clear();

                if (lblWord.Text == word)
                {
                    number = random.Next(0, wordCount);

                    lblWord.Text = basicWords[number];
                    lblRorW.ForeColor = System.Drawing.Color.Green;
                    lblRorW.Text = "Right!";
                    points += 10;
                    lblPoints.Text = points + " points";
                    comboCounter++;
                }
                else
                {
                    lblRorW.ForeColor = System.Drawing.Color.Red;
                    lblRorW.Text = "Wrong!";
                    points += -5;
                    lblPoints.Text = points + " points";
                    comboCounter = 0;
                    lblCombo.Text = "Combo Lost";
                }
            }

            if (comboCounter < 5)
            {
                lblCombo.ForeColor = System.Drawing.Color.DarkSalmon;
                lblCombo.Text = "1x Combo";
            }
            else if (comboCounter >= 5 && comboCounter < 10)
            {
                points += 10;
                lblCombo.ForeColor = System.Drawing.Color.DarkTurquoise;
                lblCombo.Text = "2x Combo!";
            }
            else if (comboCounter >= 10 && comboCounter < 15)
            {
                points += 20;
                lblCombo.ForeColor = System.Drawing.Color.DodgerBlue;
                lblCombo.Text = "3x Combo!";
            }
            else if (comboCounter >= 15)
            {
                points += 40;
                lblCombo.ForeColor = System.Drawing.Color.DarkMagenta;
                lblCombo.Text = "5x Combo!";
            }

            


        }

        }

        

}

