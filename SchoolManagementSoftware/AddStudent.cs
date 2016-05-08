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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtFullName.Clear();
            txtPhone.Clear();
            txtRegNo.Clear();
            cboClass.Text = "";
            cboGender.Text = "";
            cboStream.Text = "";
            nudAge.Value = 0;
            pictureBox1.Image = null;
            txtRegNo.Focus();
        }

        private void btnClearPicture_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnLoadPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtRegNo.Text=="" || txtFullName.Text==""||cboGender.Text==""||cboClass.Text==""||cboStream.Text=="")
            {
                MessageBox.Show("Registration Number, Full Name, Gender, Class and Stream are Required Fields. Complete them to proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
