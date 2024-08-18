using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrifindoLeaveMS
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin U = new UserLogin();
            this.Hide();
            U.Show();
        }

        private void btnALogin_Click(object sender, EventArgs e)
        {
            // Check if username or password text boxes are empty
            if (string.IsNullOrWhiteSpace(txtAuser.Text) || string.IsNullOrWhiteSpace(txtApw.Text))
            {
                MessageBox.Show("Username and password are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method
            }

            // Valid username and password
            string username = "admin";
            string password = "12345";

            if (username == txtAuser.Text && password == txtApw.Text)
            {
                MessageBox.Show("Login successful. Welcome!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                A_Dashboard AD = new A_Dashboard();
                this.Hide();
                AD.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
