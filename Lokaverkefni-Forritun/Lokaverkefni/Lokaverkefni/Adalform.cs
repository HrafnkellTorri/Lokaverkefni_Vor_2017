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
    public partial class Adalform : Form
    {
        //username breyta
        string username = "";

        //formið tekur inn username 
        public Adalform(string user)
        {
            InitializeComponent();

            username = user; //username-ið sett í breytu
        }

        //Þetta kemur upp þegar formið hleður sig
        private void Adalform_Load(object sender, EventArgs e)
        {
            //username skrifað í label og gert sýnilegt fyrir notanda
            lblPlaying.Text += " " + username;
        }

        //Þetta er til þess að loka forritinu alveg þegar ýtt er á takkann X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }//End á OnFormClosing()

        private void btnTypingGame_Click(object sender, EventArgs e)
        {
            TypingGame typinggame = new TypingGame(username);
            typinggame.Show(); //synt form fyrir typing game
            this.Hide(); //falið valmynd
        }

        private void btnSpaceBar_Click(object sender, EventArgs e)
        {
            fSpaceBar spacebar = new fSpaceBar(username);
            spacebar.Show(); //synt form fyrir spacebar 
            this.Hide(); //falið valmynd
        }

        private void btnvillage_Click(object sender, EventArgs e)
        {
            Village village = new Village(username);
            village.Show(); //synt form fyrir Village
            this.Hide(); // falið valmynd
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://188.166.169.15/leaderboard");
        }
    }
}
