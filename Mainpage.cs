using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySqlConnect2
{
    public partial class Mainpage : Form
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void Signinup_button(object sender, EventArgs e)

        {
            Signin showSigninForm = new Signin();
            showSigninForm.Show();     

        }

        private void Signupbtn_button(object sender, EventArgs e)
        {
            Signup showSignupForm = new Signup();
            showSignupForm.Show();
        }
    }
}

    