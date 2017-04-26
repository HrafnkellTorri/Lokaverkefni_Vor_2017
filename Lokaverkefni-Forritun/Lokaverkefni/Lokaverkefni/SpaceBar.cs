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
    public partial class SpaceBar : Form
    {
        public SpaceBar()
        {
            InitializeComponent();
        }


        int timeleft = 10;
        int count = 0;
        
        private void SpaceBar_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
         
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
            lblMain_Timer.Text = "Time Left: " + timeleft.ToString();
        }

        private void SpaceBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (timeleft == 0)
            {

            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    count++;
                    lblclicks.Text = count.ToString();
              
                }
            }
        }

        //Þetta er til þess að loka forritinu alveg þegar ýtt er á takkann X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();

        }

        private void lblMain_Timer_Click(object sender, EventArgs e)
        {

        }

        }

    }

