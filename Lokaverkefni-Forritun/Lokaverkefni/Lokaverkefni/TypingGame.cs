using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Lokaverkefni
 * Vor 2017
 * Erla Óskarsdóttir
 * Hrafnkell Þorri Þrastarson */

namespace Lokaverkefni
{
    public partial class TypingGame : Form
    {
        //Sótt er í klasann Gagnagrunnur sem inniheldur allar aðferðir til að tengjast gagnagrunninum og sem innihalda skipanir til að setja uppýsingar í töflu
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();
        //username breyta
        string username = "";

        //formið tekur inn username
        public TypingGame(string user)
        {
            InitializeComponent();

            //usernameið sett í breytu
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

        //const int wordcount breyta búin til fyrir fylki, const þýir að ekki er hægt að breyta value
        const int wordCount = 210;

        //Random skilgreint
        Random random = new Random();

        //Breytur skilgreindar
        int timeleft = 30, number = 0, points = 0, comboCounter = 0, words = 0;

        //Fylki með fullt af orðum búið til, orðin eru sett beint í fylkið
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

        //Sótt í klasann Aðferðir sem inniheldur ýmsar aðferðir fyrir forritið
        Adferdir adferdir = new Adferdir();

        //Kemur upp þegar formið hleður
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

        //Takki sem birtir leiðbeiningar í messageboxi
        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //Sótt er í aðferð í klasa sem inniheldur leiðbeiningarnar
            MessageBox.Show(adferdir.instructionsTyping());
        }

        //Takki sem fer aftur í valmyndina
        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide(); //felur þetta form
            Adalform menu = new Adalform(username); //náð í valmyndina
            menu.Show(); //Sýnt vamynd
        }

        //Start takki er nauðsynlegur í öllum leikjum, hér er hann í TypingGame
        private void btnStart_Click(object sender, EventArgs e)
        {
            //label sem sýnir hvað mikill tími er eftir
            lblTimer.Text = "Time left: 30";
            //Tíminn byrjar í 30 sek
            timeleft = 30;
            //Hér er stilltur hraði á timer, við höfum 1 sek hraða
            timer1.Interval = 1000;
            //tíminn látinn telja niður
            timer1.Start();
            //words counter endurstilltur
            words = 0;

            //Focus() notað til gera notanda kleift á að skrifa strax í textbox
            tbWord.Focus();
            //Enabled = true - notandi getur skrifað í textaboxið
            tbWord.Enabled = true;
            //combocounter byrjar í 0
            comboCounter = 0;
            lblCombo.Text = "";

            //stig byrja i 0
            points = 0;
            lblPoints.Text = "0 points";

            //Takkar faldnir
            btnMenu.Hide();
            btnInstructions.Hide();

            //Hér er sett upp random orð sem notandi á svo að skrifa í textaboxið, notað er Random fallið
            number = random.Next(0, wordCount);
            //forritið skrifar orðið í label
            lblWord.Text = basicWords[number];

            //Start takkinn falinn
            btnStart.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Breytur skilgreindar
            int OldHScore = 0, userID = 0;
            bool highScore = false;

            //if setning, kemur upp ef tíminn er búinn
            if (timeleft == 0)
            {
                //tíminn stoppar
                timer1.Stop();
                //textaboxið gert óvirkt
                tbWord.Enabled = false;
                //Takkarnir sýnir aftur
                btnStart.Visible = true;
                btnMenu.Show();
                btnInstructions.Show();
                //textaboxið hreinsað
                tbWord.Clear();
                //stigið skrifuð í label
                lblPoints.Text = points + " points";

                //önnur if setning inn í if setningu, kemur upp ef að notandi er ekki Gestur
                if (username != "Guest")
                {
                    userID = gagnagrunnur.FindUser_ID(username);
                    OldHScore = gagnagrunnur.FindHighscore(username, 2);

                    if (points > OldHScore)
                    {
                        highScore = true;
                    }

                    GameOver gameOver = new GameOver(highScore, points, 30, "TypingGame", words, "");
                    gameOver.Show();

                    if (OldHScore == 0)
                    {
                        gagnagrunnur.InsertHighscore(userID, points, 2);
                    }
                    else if (points > OldHScore && OldHScore != 0)
                    {
                        gagnagrunnur.UpdateHighscore(userID, points, 2);
                    }
                }
                else
                {
                    GameOver gameOver = new GameOver(highScore, points, 30, "TypingGame", words, "");
                    gameOver.Show();
                }
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
                    words++;
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

