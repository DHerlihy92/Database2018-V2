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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccount nextForm = new CreateAccount(this);
            nextForm.Show();
        }

        private void btnViewPokemon_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewPokemon nextForm = new ViewPokemon(this);
            nextForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login nextForm = new Login(this);
            nextForm.Show();
        }
    }
}
