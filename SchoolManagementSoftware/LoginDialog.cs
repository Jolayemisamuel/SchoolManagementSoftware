using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSoftware
{
    public partial class LoginDialog : Form
    {
        public LoginDialog()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Enter your username and password");
            }

            var db = new SMSDataContext();
            var checkuser = from p in db.Users where p.Username == txtUsername.Text && p.Password == txtPassword.Text select p;

            if (checkuser.Count() == 0)
            {
                MessageBox.Show("Invalid username password entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MainInteface mi = new MainInteface();
                this.Close();
                mi.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
