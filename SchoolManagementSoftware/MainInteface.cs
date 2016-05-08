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
    public partial class MainInteface : Form
    {
        
        public MainInteface()
        {
            InitializeComponent();
        }

        
        private void MainInteface_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            AboutSMS about = new AboutSMS();
            about.ShowDialog();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            LoginDialog login = new LoginDialog();
            login.Show();
            this.Hide();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AddStudent nuevoEstudiante = new AddStudent();
            nuevoEstudiante.Show();
            nuevoEstudiante.MdiParent = this;
        }
    }
}
