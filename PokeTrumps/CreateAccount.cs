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
            using(PokemonEntities context = new PokemonEntities())
            {
                Trainer trainer = new Trainer
                {
                    TName = tbUsername.Text,
                    Password = tbPassword.Text,
                    Email = tbEmail.Text,
                    CreationDate= DateTime.Now
                };

                context.Trainers.Add(trainer);
                context.SaveChanges();
            }
        }
    }
}
