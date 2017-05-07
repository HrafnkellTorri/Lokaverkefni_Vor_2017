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
    public partial class fSignUp : Form
    {
        //Klasinn gagnagrunnur opnaður til þess að sækja aðferðir til að tengjast við Töflur í gagnagrunni
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();

        public fSignUp()
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

        string username = "", passw1 = "", passw2 = "", email = "", country = "", month = "", date = "";

        private void fSignUp_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '♦';
            tbPassword2.PasswordChar = '♦';
        }

        int day = 0, year = 0;

        Adferdir adferdir = new Adferdir();

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            passw1 = tbPassword.Text;
            passw2 = tbPassword2.Text;
            email = tbEmail.Text;
            country = cbCountry.Text;
            day = Convert.ToInt32(cbDay.Text);
            month = cbMonth.Text;
            year = Convert.ToInt32(cbYear.Text);

            date = adferdir.FindDate(day, month, year);

            //Hér er athugað hvort að vanti nokkuð í textaboxin, notað er if/else til þess
            //MessageBox kemur upp ef að vantar lykilorð, notendanafn eða bæði
            if (username == "" && passw1 == "")
            {
                MessageBox.Show("username and password are required");
            }
            else if (passw1 == "")
            {
                MessageBox.Show("password is required");
            }
            else if (username == "")
            {
                MessageBox.Show("username is required");
            }
            else if (cbDay.Text == "" || cbMonth.Text == "" || cbYear.Text == "")
            {
                MessageBox.Show("date is required");
            }
            else if (email == "")
            {
                MessageBox.Show("email is required");
            }
            //Ef ekkert vantar þá förum við inn í else
            else
            {
                if (passw1 == passw2)
                {
                    //Hér er notað try/catch til að grípa villu
                    try
                    {
                        //Hérna er sótt aðferð í klasanum Gagnagrunnur, aðferðin setur nafnið og lykilorðið í sql töflu
                        gagnagrunnur.SignUpUser(username, passw1, date, email, country);
                        //Ef allt fór vel kemur upp messagebox sem segir til um það
                        MessageBox.Show("Signup Successful! \nWelcome to the group");
                        this.Hide();
                    }
                    catch (Exception) //ef upp kemur villa
                    {
                        //Hérna er sótt aðferð í gagnagrunn, þessi aðferð lokar fyrir tengingu við gagnagrunn svo notandi geti reynt aftur
                        gagnagrunnur.CloseConnection();
                        //MeassageBox segir afh upp kom villa
                        MessageBox.Show("Username not available");
                    }
                }
                else
                {
                    MessageBox.Show("passwords don't match");
                }
            }
        }
    }
}
