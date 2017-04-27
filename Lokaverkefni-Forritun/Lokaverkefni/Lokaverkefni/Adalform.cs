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
    public partial class Adalform : Form
    {
        public Adalform()
        {
            InitializeComponent();
        }

        private void Adalform_Load(object sender, EventArgs e)
        {

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
            typinggame.Show();
            this.Hide();
        }

        private void btnSpaceBar_Click(object sender, EventArgs e)
        {
            SpaceBar spacebar = new SpaceBar();
            spacebar.Show();
            this.Hide();
        }

        private void btnvillage_Click(object sender, EventArgs e)
        {
            Village village = new Village();
            village.Show();
            this.Hide();
        }
    }
}
