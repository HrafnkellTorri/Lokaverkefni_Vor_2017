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
    public partial class fSpaceBar : Form
    {
        //Sótt er í klasann Gagnagrunnur sem inniheldur allar aðferðir til að tengjast gagnagrunninum og sem innihalda skipanir til að setja uppýsingar í töflu
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        //username breyta
        string username = "";

        //forritið tekur inn username
        public fSpaceBar(string user)
        {
            InitializeComponent();

            //username-ið sett í breytu
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

        //Breytur skilgreindar
        int timeleft = 10, count = 0;

        //Sótt í klasann Aðferðir sem inniheldur ýmsar aðferðir fyrir forritið
        Adferdir adferdir = new Adferdir();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int userID = 0, OldHScore = 0;
            bool highScore = false;

            if (timeleft == 0)
            {
                timer1.Stop();
                btnStart.Enabled = true;
                btnInstructions.Enabled = true;
                btnMenu.Enabled = true;
                btnStart.Focus();

                if (username != "Guest")
                {
                    userID = gagnagrunnur.FindUser_ID(username);
                    OldHScore = gagnagrunnur.FindHighscore(username, 1);

                    if (count > OldHScore)
                    {
                        highScore = true;
                    }

                    GameOver gameOver = new GameOver(highScore, count, 10, "SpaceBar", 0, "");
                    gameOver.Show();

                    if (OldHScore == 0)
                    {
                        gagnagrunnur.InsertHighscore(userID, count, 1);
                    }
                    else if (count > OldHScore && OldHScore != 0)
                    {
                        gagnagrunnur.UpdateHighscore(userID, count, 1);
                    }
                }
                else
                {
                    GameOver gameOver = new GameOver(highScore, count, 10, "SpaceBar", 0, "");
                    gameOver.Show();
                }
            }
            else
            {
                timeleft = timeleft - 1;
            }
            lblMain_Timer.Text = "Time left: " + timeleft.ToString();
        }

        //Þetta er til þess að loka forritinu alveg þegar ýtt er á takkann X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adalform menu = new Adalform(username);
            menu.Show();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show(adferdir.instructionsSpaceBar());
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            count = 0;
            lblclicks.Text = "0 : Clicks";

            timeleft = 10;
            lblMain_Timer.Text = "Time left: 10";
            timer1.Interval = 1000;
            timer1.Start();

            btnStart.Enabled = false;
            btnMenu.Enabled = false;
            btnInstructions.Enabled = false;

            this.Focus();
        }

        private void fSpaceBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (timeleft == 0)
            {
                btnStart.Enabled = true;
                btnInstructions.Enabled = true;
                btnMenu.Enabled = true;
            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    count++;
                    lblclicks.Text = count.ToString() + " : Clicks";
                }
            }
        }
    }

    }

