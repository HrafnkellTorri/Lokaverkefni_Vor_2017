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
    public partial class fSpaceBar : Form
    {
        public fSpaceBar()
        {
            InitializeComponent();
        }

        int timeleft = 10, count = 0;

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
            Adalform menu = new Adalform();
            menu.Show();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
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

        private void fSpaceBar_KeyDown(object sender, KeyEventArgs e)
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

