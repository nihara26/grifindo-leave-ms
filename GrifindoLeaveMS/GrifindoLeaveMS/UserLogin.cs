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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin A = new FrmAdmin();
            this.Hide();
            A.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee E = new FrmEmployee();
            this.Hide();
            E.Show();
        }
    }
}
