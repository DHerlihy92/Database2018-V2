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
    public partial class ViewPokemon : Form
    {
        public ViewPokemon()
        {
            InitializeComponent();
        }


        private void ViewPokemon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pokemonDataSet.Pokemon' table. You can move, or remove it, as needed.
            this.pokemonTableAdapter.Fill(this.pokemonDataSet.Pokemon);

        }
    }
}