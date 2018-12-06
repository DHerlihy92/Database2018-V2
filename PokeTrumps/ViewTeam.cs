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
                


                 
                    var result = (from t in context.TrainerPokemons
                            join p in context.Pokemons on t.PokemonID equals p.PokemonID
                            where t.TrainerID == 77 && t.Team == true
                            select new { t.PokemonID, p.Name, p.Attack, p.Defence, p.SpecialAttack, p.SpecialDefence, p.Speed, p.Image }).ToList();

                dataGridView1.DataSource = result;

                var result2 = (from t in context.TrainerPokemons
                                            join p in context.Pokemons on t.PokemonID equals p.PokemonID
                                            where t.TrainerID == 77 && t.Team == false
                                            select new { t.PokemonID, p.Name, p.Attack, p.Defence, p.SpecialAttack, p.SpecialDefence, p.Speed, p.Image }).ToList();

                dataGridView2.DataSource = result2;

            }
        }

    }
}
