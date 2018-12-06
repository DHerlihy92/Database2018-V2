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
        short trainerID;

        public ViewTeam()
        {
            InitializeComponent();
        }

        public ViewTeam(short TrainerID, MainMenu Parent)
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
                            where t.TrainerID == trainerID && t.Team == true
                            select new { t.PokemonID, p.Name, p.Attack, p.Defence, p.SpecialAttack, p.SpecialDefence, p.Speed, p.Image }).ToList();

                dataGridView1.DataSource = result;

                var result2 = (from t in context.TrainerPokemons
                               join p in context.Pokemons on t.PokemonID equals p.PokemonID
                               where t.TrainerID == trainerID && t.Team == false
                               select new { t.PokemonID, p.Name, p.Attack, p.Defence, p.SpecialAttack, p.SpecialDefence, p.Speed, p.Image }).ToList();

                dataGridView2.DataSource = result2;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            short PokeOut = Convert.ToInt16(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            short PokeIn = Convert.ToInt16(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells[0].Value);

            
            using (PokemonEntities context = new PokemonEntities())
            {
                context.updateTeam(trainerID, PokeOut, PokeIn);

                var result = (from t in context.TrainerPokemons
                              join p in context.Pokemons on t.PokemonID equals p.PokemonID
                              where t.TrainerID == trainerID && t.Team == true
                              select new { t.PokemonID, p.Name, p.Attack, p.Defence, p.SpecialAttack, p.SpecialDefence, p.Speed, p.Image }).ToList();

                dataGridView1.DataSource = result;

                //dataGridView2.DataSource = context.getTeam(Convert.ToInt16(txtID.Text));
                dataGridView2.Rows[0].Cells[0].Selected = false;

                var result2 = (from t in context.TrainerPokemons
                               join p in context.Pokemons on t.PokemonID equals p.PokemonID
                               where t.TrainerID == trainerID && t.Team == false
                               select new { t.PokemonID, p.Name, p.Attack, p.Defence, p.SpecialAttack, p.SpecialDefence, p.Speed, p.Image }).ToList();

                dataGridView2.DataSource = result2;

                //dataGridView1.DataSource = context.getCollection(Convert.ToInt16(txtID.Text));


                if (dataGridView1.Rows.Count >= 2)
                    dataGridView1.Rows[0].Cells[0].Selected = false;

                context.SaveChanges();
            }
        }
    }
}
