using System;
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
    public partial class ViewTeam : Form
    {
        MainMenu parent;
        int trainerID;

        public ViewTeam()
        {
            InitializeComponent();
        }

        public ViewTeam(int TrainerID, MainMenu Parent)
        {
            InitializeComponent();
            trainerID = TrainerID;
            parent = Parent;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void ViewTeam_Load(object sender, EventArgs e)
        {
            using (PokemonEntities context = new PokemonEntities())
            {
               
                /*dataGridView1.DataSource = (from TrainerPokemon in PokemonEntities
                                            join Pokemon in PokemonEntities
                                            on Pokemon.PokemonID equals TrainerPokemon.PokemonID
                                            where Tr)*/

            }
        }

    }
}
