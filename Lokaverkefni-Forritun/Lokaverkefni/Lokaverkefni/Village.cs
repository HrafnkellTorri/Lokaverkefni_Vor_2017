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


        int wood = 0, steel = 0, meat = 100, coal = 100, coins = 80, level = 1, coinsmulty = 1, depcoal = 4, hunger = 5, canbuysteel = 20, canbuywood = 190, year = 0,coalinventory = 10, meatinventory = 10;
        
        private void Village_Load(object sender, EventArgs e)
        {
            lblcoins.Text = coins.ToString();
            timer1.Interval = 1000;
            timer2.Interval = 80;
            timer3.Interval = 250;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            showsorces();
        }


        //TIMERS


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (meat <= 5 || coal <= 4)
            {
                endgame();
            }
            else if (meat > 0 && coal > 0)
            {

                lblcoins.Text = coins.ToString();
                meat = meat - hunger; coal = coal - depcoal;
                showsorces();
                coins += 1 * coinsmulty;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (meat <= 5 || coal <= 4)
            {
                endgame();
            }
            else
            {
                showcoins();
                showyear();
                showsorces();
            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            coins += 1 * coinsmulty;
        }


        //TAKKAR

        private void btnsteel_Click(object sender, EventArgs e)
        {
            if (meat <= 0 || coal <= 0)
            {
                endgame();
            }
            else if (coins >= 20 && steel <= canbuysteel)
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
            if (meat <= 0 || coal <= 0)
            {
                endgame();
            }
            else if (coins >= 5 && wood <= canbuywood)
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
                endgame();
            }
            else if(meat <= 90 && coins > 8)
            {
                    coins = coins - 10;
                    meat = meat + meatinventory;
                    prbmeat.Value = meat;
                    lblcoins.Text = coins.ToString();
                    showsorces();
            } 
        }

        private void btncoal_Click(object sender, EventArgs e)
        {
            if (meat <= 0 || coal <= 0)
            {
                endgame();
            }
            else if(coal <= 90 && coins > 9)
            {
                    coins = coins - 9;
                    coal = coal + coalinventory;
                    prbcoal.Value = coal;
                    lblcoins.Text = coins.ToString();
                    showsorces();
           }
        }

        //AÐFERÐIR

        private void showyear()
        {
            year++;
            lblyear.Text = "Year : " + year.ToString();
           
        }
        private void hidebtns()
        {
            btncoal.Hide(); btnmeat.Hide(); btnsteel.Hide(); btnwood.Hide();
        }
        
        private void showcoins()
        {
            lblcoins.Text = coins.ToString();
        }

        private void showsorces()
        {
            prbwood.Value = wood; prbmeat.Value = meat; prbsteel.Value = steel; prbcoal.Value = coal;   
        }
        private void endgame()
        {
               timer1.Stop(); timer2.Stop(); meat = 0; coal = 0;
                hidebtns();
                if (meat <= 5)
                {
                    prbmeat.Value = 0;
                    MessageBox.Show("You have lost! \nYour people ran out of food and starved to death!");
                }
                else if (coal <= 4)
                {
                    prbcoal.Value = 0;
                    MessageBox.Show("You have lost! \nYour people ran out of coal and froze to death!");
                }

        }
        private void checklevelup()
        {
            if (steel >= 30 && wood >= 200 && level == 1)
            {
                level++;
                lbllevel.Text = "Level " + level.ToString();
                lbllevel.Text += " : Feudal Age";
                steel = 0; wood = 0; meat = 100; coal = 100; coins = 30;
                depcoal=depcoal + 2; hunger=hunger + 2; meatinventory += 2; coalinventory += 2;
                coinsmulty = coinsmulty + 2;
                prbsteel.Maximum = 50; prbwood.Maximum = 160;
                canbuysteel = 50; canbuywood = 150;
            }
            if (steel >= 50 && wood >= 150 && level == 2)
            {
                level++;
                lbllevel.Text = "Level " + level.ToString();
                lbllevel.Text += " : Castle Age";
                steel = 0; wood = 0; meat = 100; coal = 100; coins = 40;
                depcoal++; hunger++; meatinventory += 4; coalinventory += 3;
                coinsmulty = coinsmulty + 2;
                prbsteel.Maximum = 90; prbwood.Maximum = 260;
                canbuysteel = 90; canbuywood = 260;
            }
            if (steel >= 90 && wood >= 260 && level == 3)
            {
                level++;
                lbllevel.Text = "Level " + level.ToString();
                lbllevel.Text += " : Imperial Age";
                steel = 0; wood = 0; meat = 100; coal = 100; coins = 50;
                depcoal++; hunger++; meatinventory += 4; coalinventory += 3;
                coinsmulty = coinsmulty + 3;
                prbsteel.Maximum = 160; prbwood.Maximum = 330;
                canbuysteel = 160; canbuywood = 330;
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
