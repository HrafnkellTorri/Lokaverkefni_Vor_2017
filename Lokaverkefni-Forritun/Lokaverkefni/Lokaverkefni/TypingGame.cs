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
        public TypingGame()
        {
            InitializeComponent();
        }

        Random random = new Random();

        int timeleft = 30, number = 0, word = 0;

        string[] basicWords = new string[210] { "apple", "above", "again", "age", "agree", "after", "air", "alone", "army", "attack", "away", 
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
                "page", "paint", "parent", "parnter", "party", "plane", "popular", "promise", "please", 
                "queen", "question", "quick", "quiet", "quite", 
                "radio", "rainy", "read", "record", "report", "rubber", "rush", "remind", "repair", "rule", 
                "safe", "salt", "school", "search", "second", "shout", "sleep", "sound", "station", 
                "time", "table", "taxi", "thick", "travel", "train", "three", "tennis", "today", "toe", 
                "ugly", "uncle", "under", "unit", "until", "use", "useful", "usual", "usually", 
                "vegetable", "very", "village", "voice", "visit", 
                "wait", "walk", "wedding", "welcome", "water", "window", "world", "winter", "while", 
                "yard", "yell", "yet", "you", "young", "your", "zero", "zoo"};

        private void TypingGame_Load(object sender, EventArgs e)
        {
            
        }

        //Þetta er til þess að loka forritinu alveg þegar ýtt er á takkann X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            tbWord.Focus();

            number = random.Next(0, 211);
            lblWord.Text = basicWords[number];

            btnStart.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft == 0)
            {
                timer1.Stop();
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
                    number = random.Next(0, 211);
                    lblWord.Text = basicWords[number];
                    lblRorW.ForeColor = System.Drawing.Color.Green;
                    lblRorW.Text = "Right!";
                }
                else
                {
                    lblRorW.ForeColor = System.Drawing.Color.Red;
                    lblRorW.Text = "Wrong!";
                }
            }

            if (timeleft == 0)
            {
                tbWord.Hide();
                tbWord.Enabled = false;
            }
            
        }

        }

        

}

