﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_roombutton_Click(object sender, EventArgs e)
        {
            AddRoomRec Check = new AddRoomRec();
            Check.Show();
        }

        private void add_roombut_Click(object sender, EventArgs e)
        {
            AddRoomRec Check = new AddRoomRec();
            Check.Show();
        }
    }
}
