﻿using System;
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
    public partial class Add_Emp : Form
    {
        public Add_Emp()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            A_Dashboard AD = new A_Dashboard();
            this.Hide();
            AD.Show();
        }
    }
}
