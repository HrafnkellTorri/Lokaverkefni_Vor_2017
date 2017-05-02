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
    public partial class fLokaverkefni : Form
    {

        //Klasinn gagnagrunnur opnaður til þess að sækja aðferðir til að tengjast við Töflur í gagnagrunni
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        public fLokaverkefni()
        {
            InitializeComponent();

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

        private void Form1_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '♦';
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //string breytur búnar til, sett er í þær texta úr textaboxum
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string passw = null;

            //try/catch notað hér
            try
            {
                //Fundið er út lykilorð notanda sem er að reyna skrá sig inn
                passw = gagnagrunnur.FindPassword(username);

                //Notað er if til að finna út hvort notandi skrifaði rétt lykilorð
                if (passw == password)
                {
                    //Ef lykilorðið er rétt opnast annað form
                    Adalform adalform = new Adalform(username);
                    adalform.Show();
                    //Login formið hverfur
                    Hide();
                }
                else
                {
                    //Ef lykilorðið er vitlaust kemur upp mesasgeBox sem lætur vita
                    MessageBox.Show("Wrong username or password");
                }
            }
            catch (Exception ex)
            {
                //Ef villa kemur upp birtist messagebox sem segir hvað er að
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnGestur_Click(object sender, EventArgs e)
        {
            Adalform adalform = new Adalform("Guest");
            adalform.Show(); //Sýnt form
            Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            fSignUp signup = new fSignUp(); 
            signup.Show(); //sýnt signup formið
        }
    }
}
