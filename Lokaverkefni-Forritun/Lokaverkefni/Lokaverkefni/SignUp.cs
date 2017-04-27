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
        public fSignUp()
        {
            InitializeComponent();
        }

        string username = "", passw1 = "", passw2 = "", email = "", country = "";

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            passw1 = tbPassword.Text;
            passw2 = tbPassword2.Text;
            email = tbEmail.Text;
            country = cbCountry.Text;
        }
    }
}
