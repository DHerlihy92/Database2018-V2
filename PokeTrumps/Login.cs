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
    public partial class Login : Form
    {
        //int trainerID;
        MainMenu parent;
        public Login()
        {
            InitializeComponent();
        }

        public Login(MainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user;
            using (PokemonEntities context = new PokemonEntities()) {
                user = Convert.ToString(tbUsername.Text);

                var result = context.Trainers
                .Where(t => t.TName == user)
                .Select(t => new { t.TrainerID }).ToList();

                dataGridView1.DataSource = result;




                if (context.Trainers.Any(t => t.TName == user))
                {
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show(user + " does not use the password you have entered");
                        tbPassword.Clear();
                    }
                    else
                    {

                        short trainerID = Convert.ToInt16(dataGridView1.Rows[0].Cells[0].Value);
                        this.Hide();
                        var form2 = new ViewTeam(trainerID, this);
                        form2.Closed += (s, args) => this.Close();
                        form2.Show();
                    }
                }
                else
                    MessageBox.Show(user + " does not exist in the system create an account");
            }



        }

           // this.Hide();
            //ViewTeam nextForm = new ViewTeam(trainerID, this);
        }
    }

