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
    public partial class Village : Form
    {
        public Village()
        {
            InitializeComponent();
        }


        int wood = 0, steel = 0, meat = 100, coal = 100, coins = 80, level = 1, coinsmulty = 8, depcoal = 3, hunger = 4, canbuysteel = 20, canbuywood = 90;
        
        private void Village_Load(object sender, EventArgs e)
        {
            lblcoins.Text = coins.ToString();
            timer1.Interval = 1000;
            timer1.Start();
            showsorces();
        }


        //TIMER


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (meat <= 0 || coal <= 0)
            {
                timer1.Stop();
                hidebtns(); 
            }
            else
            {
                lblcoins.Text = coins.ToString();
                meat = meat - hunger; coal = coal - depcoal;
                showsorces();
                coins += 1 * coinsmulty;
            }
           
        }

        //TAKKAR

        private void btnsteel_Click(object sender, EventArgs e)
        {
            if (coins >= 20 && steel <= canbuysteel)
            {
                coins = coins - 20;
                steel = steel + 10;
                prbsteel.Value = steel;
                lblcoins.Text = coins.ToString();
                showsorces();
            }
            checklevelup();
        }

        private void btnwood_Click(object sender, EventArgs e)
        {
            if (coins >= 5 && wood <= canbuywood)
            {
                coins = coins - 5;
                wood = wood + 10;
                prbwood.Value = wood;
                lblcoins.Text = coins.ToString();
                showsorces();
            }
            checklevelup();
        }

        private void btnmeat_Click(object sender, EventArgs e)
        {
            if (meat <= 0 || coal <= 0)
            {
                timer1.Stop();
                hidebtns();

            }
            else if(meat <= 90 && coins > 8)
            {
                    coins = coins - 8;
                    meat = meat + 10;
                    prbmeat.Value = meat;
                    lblcoins.Text = coins.ToString();
                    showsorces();
            }
            else { }
            
        }

        private void btncoal_Click(object sender, EventArgs e)
        {
            if (meat <= 0 || coal <= 0)
            {
                timer1.Stop();
                hidebtns();

            }
            else if(coal <= 90 && coins > 9)
            {
                    coins = coins - 9;
                    coal = coal + 10;
                    prbcoal.Value = coal;
                    lblcoins.Text = coins.ToString();
                    showsorces();
           }
           else { }
        }


        //AÐFERÐIR


        public void hidebtns()
        {
            btncoal.Hide(); btnmeat.Hide(); btnsteel.Hide(); btnwood.Hide();
        }
        private void showsorces()
        {
            
            prbwood.Value = wood; prbmeat.Value = meat; prbsteel.Value = steel; prbcoal.Value = coal;
            
        }
        private void checklevelup()
        {
            if (steel >= 30 && wood >= 100 && level == 1)
            {
                level++;
                lbllevel.Text = level.ToString();
                steel = 0; wood = 0;
                depcoal++; hunger++;
                coinsmulty = coinsmulty + 2;
                prbsteel.Maximum = 50; prbwood.Maximum = 150;
                canbuysteel = 40; canbuywood = 140;
            }
            if (steel >= 50 && wood >= 150 && level == 2)
            {
                level++;
                lbllevel.Text = level.ToString();
                steel = 0; wood = 0;
                depcoal++; hunger++;
                coinsmulty = coinsmulty + 2;
                prbsteel.Maximum = 100; prbwood.Maximum = 260;
                canbuysteel = 90; canbuywood = 240;
            }
            if (steel >= 90 && wood >= 260 && level == 2)
            {
                level++;
                lbllevel.Text = level.ToString();
                steel = 0; wood = 0;
                depcoal++; hunger++;
                coinsmulty = coinsmulty + 2;
                prbsteel.Maximum = 150; prbwood.Maximum = 300;
                canbuysteel = 140; canbuywood = 290;
            }
        }
        //Þetta er til þess að loka forritinu alveg þegar ýtt er á takkann X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();

        }

    }
}
