﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokeTrumps
{
    public partial class CreateAccount : Form
    {
        MainMenu parent;
        public CreateAccount()
        {
            InitializeComponent();
        }

        public CreateAccount(MainMenu Parent)
        {
            InitializeComponent();
            parent = Parent; 
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }
    }
}
