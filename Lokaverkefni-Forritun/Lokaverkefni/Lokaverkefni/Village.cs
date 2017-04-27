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


        int wood = 0, steel = 0, meat = 100, coal = 100, coins = 80, level = 1;
        
        private void Village_Load(object sender, EventArgs e)
        {
            lblcoins.Text = coins.ToString();
            timer1.Interval = 1000;
            timer1.Start();
            showsorces();
        }

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
                meat = meat - 4; coal = coal - 3;
                showsorces();
                coins = coins + 8;
            }
           
        }

        private void btnsteel_Click(object sender, EventArgs e)
        {
            coins = coins - 20;
            steel = steel + 10;
            prbsteel.Value = steel;
            lblcoins.Text = coins.ToString();
            showsorces();

            if (steel >= 100 && wood >= 100)
            {
                level++;
            }
        }

        private void btnwood_Click(object sender, EventArgs e)
        {
            coins = coins - 5;
            wood = wood + 10;
            prbwood.Value = wood;
            lblcoins.Text = coins.ToString();
            showsorces();
            if (steel >= 100 && wood >= 100)
            {
                level++;
            }
        }

        private void btnmeat_Click(object sender, EventArgs e)
        {
            if (meat <= 90 && coins > 8)
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
            if (coal <= 90 && coins > 9)
            {
                coins = coins - 9;
                coal = coal + 10;
                prbcoal.Value = coal;
                lblcoins.Text = coins.ToString();
                showsorces();
            }
            else { }
        }


        public void hidebtns()
        {
            btncoal.Hide(); btnmeat.Hide(); btnsteel.Hide(); btnwood.Hide();
        }
        private void showsorces()
        {
            prbwood.Value = wood; prbmeat.Value = meat; prbsteel.Value = steel; prbcoal.Value = coal;
            
        }
        

        //Þetta er til þess að loka forritinu alveg þegar ýtt er á takkann X
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();

        }

    }
}
