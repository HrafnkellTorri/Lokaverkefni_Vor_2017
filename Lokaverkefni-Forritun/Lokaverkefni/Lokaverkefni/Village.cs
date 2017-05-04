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
   FOR2C3U Vorönn 2017 Tækniskólinn */

namespace Lokaverkefni
{
    public partial class Village : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        string username = "";

        public Village(string user)
        {
            InitializeComponent();

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

        int wood = 0, steel = 0, meat = 100, coal = 100, coins = 80, level = 1, coinsmulty = 1, depcoal = 4, hunger = 5, canbuysteel = 20, canbuywood = 190, year = 0,coalinventory = 10, meatinventory = 10;

        Adferdir adferdir = new Adferdir();

        private void Village_Load(object sender, EventArgs e)
        {
            btnmeat.Enabled = false;
            btncoal.Enabled = false;
            btnwood.Enabled = false;
            btnsteel.Enabled = false;
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
        private void btnMenu_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();

            this.Hide();
            Adalform menu = new Adalform(username);
            menu.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblcoins.Text = coins.ToString();
            timer1.Interval = 1000;
            timer2.Interval = 80;
            timer3.Interval = 250;
            timer1.Start();
            timer2.Start();
            timer3.Start();
            showsorces();

            btnStart.Hide();
            btnMenu.Hide();

            btnmeat.Enabled = true;
            btncoal.Enabled = true;
            btnwood.Enabled = true;
            btnsteel.Enabled = true;
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            MessageBox.Show(adferdir.instructionsVillage());
        }

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
            if (meat <= 3 || coal <= 3)
            {
                endgame();
            }
            else if(meat <= 80 && coins > 8)
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
            if (meat <= 3 || coal <= 3)
            {
                endgame();
            }
            else if(coal <= 80 && coins > 9)
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

        private void hidehouses()
        {
            picHouse_1.Hide(); picHouse_2.Hide(); picHouse_3.Hide();
        }

        private void hideprgsbars()
        {
            prbcoal.Hide(); prbmeat.Hide(); prbsteel.Hide(); prbwood.Hide();
        }

        private void showruins()
        {
            if(level == 2)
            {
                hidehouses();
                picBurnedhouse_1.Show(); 
            }
            else if (level == 3)
            {
                hidehouses();
                picBurnedhouse_1.Show(); picBurnedhouse_2.Show();
            }
            else
            {
                hidehouses();
                picBurnedhouse_1.Show(); picBurnedhouse_2.Show(); picBurnedhouse_3.Show();
            }
        }

        private void endgame()
        {
            hideprgsbars();
            timer1.Stop(); timer2.Stop(); meat = 0; coal = 0;
            hidebtns();
            showruins();
                
            if (meat <= 8)
            {
                prbmeat.Value = 0;
                MessageBox.Show("You have lost! \nYour people ran out of food and starved to death!");
            }
            else if (coal <= 6)
            {
                prbcoal.Value = 0;
                MessageBox.Show("You have lost! \nYour people ran out of coal and froze to death!");
            }
        }

        private void wingame()
        {
            hideprgsbars();
            timer1.Stop(); timer2.Stop(); meat = 0; coal = 0;
            hidebtns();
            MessageBox.Show("THE MODERN AGE! You are victorius!");
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
                canbuysteel = 40; canbuywood = 150;
                picHouse_1.Show();
            }
            if (steel >= 50 && wood >= 160 && level == 2)
            {
                level++;
                lbllevel.Text = "Level " + level.ToString();
                lbllevel.Text += " : Castle Age";
                steel = 0; wood = 0; coins = 40;
                depcoal++; hunger++; meatinventory += 4; coalinventory += 3;
                coinsmulty = coinsmulty + 2;
                prbsteel.Maximum = 90; prbwood.Maximum = 260;
                canbuysteel = 80; canbuywood = 250;
                picHouse_2.Show();
            }
            if (steel >= 90 && wood >= 260 && level == 3)
            {
                level++;
                lbllevel.Text = "Level " + level.ToString();
                lbllevel.Text += " : Imperial Age";
                steel = 0; wood = 0;  coins = 50;
                depcoal++; hunger++; meatinventory += 4; coalinventory += 3;
                coinsmulty = coinsmulty + 3;
                prbsteel.Maximum = 160; prbwood.Maximum = 330;
                canbuysteel = 150; canbuywood = 320;
                picHouse_3.Show();
            }
            if(steel >= 160 && wood >= 330 && level == 4)
            {
                wingame();
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
