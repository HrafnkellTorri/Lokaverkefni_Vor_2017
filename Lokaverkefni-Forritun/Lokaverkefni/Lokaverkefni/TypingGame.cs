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

        private void TypingGame_Load(object sender, EventArgs e)
        {
            string[] basicWords = new string[208] { "apple", "above", "again", "age", "agree", "after", "air", "alone", "army", "attack", "away", 
                "baby", "back", "behind", "black", "better", "beer", "bridge", "born", "begin", 
                "cake", "call", "candle", "card", "class", "cold", "clean", "colour", "corner", 
                "dance", "dark", "day", "dead", "dirty", "duck", "draw", "dog", "drink", 
                "early", "east", "effect", "eight", "empty", "enter", "except", "enjoy", "enemy", 
                "face", "fact", "false", "family", "finger", "freeze", "friend", "flour", "forest", 
                "game", "garden", "gift", "glass", "ground", "grow", "grave", "great", "goat", 
                "hair", "hammer", "happen", "hate", "head", "height", "horse", "hotel", "hungry", 
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
                "time", "table", "taxi", "thick", "tavel", "train", "three", "tennis", "today", "toe", 
                "ugly", "uncle", "under", "unit", "until", "use", "useful", "usual", "usually", 
                "vegetable", "very", "village", "voice", "visit", 
                "wait", "walk", "wedding", "welcome", "water", "window", "world", "winter", "while", 
                "yard", "yell", "yet", "you", "young", "your", "zero", "zoo"};
        }

        //Þetta er til þess að loka forritinu alveg þegar ýtt er á takkann X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
<<<<<<< HEAD
        }

       
=======
        }//End á OnFormClosing()
<<<<<<< HEAD
>>>>>>> origin/master
=======
        
>>>>>>> origin/master
    }
}
