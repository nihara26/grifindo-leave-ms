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
    public partial class A_Dashboard : Form
    {
        public A_Dashboard()
        {
            InitializeComponent();
        }

        private void btn_AddEmp_Click(object sender, EventArgs e)
        {
            Add_Emp AE= new Add_Emp();
            this.Hide();
            AE.Show();
        }

        private void btn_DefineLeaves_Click(object sender, EventArgs e)
        {
            DefineLeaves DL = new DefineLeaves();
            this.Hide();
            DL.Show();
        }

        private void btn_DefineRoster_Click(object sender, EventArgs e)
        {
            DefineRoster DR = new DefineRoster();
            this.Hide();
            DR.Show();
        }

        private void btn_ManageLeaves_Click(object sender, EventArgs e)
        {
            ManageLeaves ML = new ManageLeaves();
            this.Hide();
            ML.Show();
        }

        private void btn_LeavesReports_Click(object sender, EventArgs e)
        {
            LeaveReports LR = new LeaveReports();
            this.Hide();
            LR.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            UserLogin U = new UserLogin();
            this.Hide();
            U.Show();
        }
    }
}
