using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Höfundar : Erla Óskarsdóttir & Hrafnkell Þorri Þrastarson
   FOR2C3U Vorönn 2017 tækniskólinn */

namespace Lokaverkefni
{
    public partial class Adalform : Form
    {
        string username = ""; 
        public Adalform(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void Adalform_Load(object sender, EventArgs e)
        {
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
            TypingGame typinggame = new TypingGame();
            typinggame.Show(); //synt form fyrir typing game
            this.Hide();
        }

        private void btnSpaceBar_Click(object sender, EventArgs e)
        {
            fSpaceBar spacebar = new fSpaceBar();
            spacebar.Show(); //synt form fyrir spacebar 
            this.Hide(); //falið valmynd
        }

        private void btnvillage_Click(object sender, EventArgs e)
        {
            Village village = new Village();
            village.Show(); //synt form fyrir Village
            this.Hide(); // falið valmynd
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://188.166.169.15/");
        }
    }
}
