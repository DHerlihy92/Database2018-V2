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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (PokemonEntities context = new PokemonEntities())
            {
                int check;

                check = context.getValidTName(tbUsername.Text);

                if (check == 1)
                {
                    MessageBox.Show("This username already exists");
                    return;
                    tbUsername.Focus();
                }

                var max = context.Trainers.DefaultIfEmpty().Max(r => r == null ? 0 : r.TrainerID);
                max = Convert.ToInt16(max) + 1;

                short NextID = Convert.ToInt16(max);

                Trainer trainer = new Trainer
                {
                    TrainerID = NextID,
                    TName = tbUsername.Text,
                    Password = tbPassword.Text,
                    Email = tbEmail.Text,
                    CreationDate = DateTime.Now
                };

                context.Trainers.Add(trainer);
                context.SaveChanges();

                for (int i = 0; i < 5; i++)
                {
                    context.getNewPokemon(NextID);
                    context.SaveChanges();
                }

            }
        }
    }
}
