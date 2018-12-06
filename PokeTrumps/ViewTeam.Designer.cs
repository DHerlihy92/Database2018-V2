namespace PokeTrumps
{
    partial class ViewTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonDataSet = new PokeTrumps.PokemonDataSet();
            this.pokemonTableAdapter = new PokeTrumps.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.pokemonDataSet1 = new PokeTrumps.PokemonDataSet1();
            this.pokemonDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainerPokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainerPokemonTableAdapter = new PokeTrumps.PokemonDataSet1TableAdapters.TrainerPokemonTableAdapter();
            this.pokemonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonTableAdapter1 = new PokeTrumps.PokemonDataSet1TableAdapters.PokemonTableAdapter();
            this.pokemonBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerPokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1072, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 27);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 75;
            this.dataGridView1.Size = new System.Drawing.Size(909, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // pokemonBindingSource
            // 
            this.pokemonBindingSource.DataMember = "Pokemon";
            this.pokemonBindingSource.DataSource = this.pokemonDataSet;
            // 
            // pokemonDataSet
            // 
            this.pokemonDataSet.DataSetName = "PokemonDataSet";
            this.pokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokemonTableAdapter
            // 
            this.pokemonTableAdapter.ClearBeforeFill = true;
            // 
            // pokemonDataSet1
            // 
            this.pokemonDataSet1.DataSetName = "PokemonDataSet1";
            this.pokemonDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pokemonDataSet1BindingSource
            // 
            this.pokemonDataSet1BindingSource.DataSource = this.pokemonDataSet1;
            this.pokemonDataSet1BindingSource.Position = 0;
            // 
            // trainerPokemonBindingSource
            // 
            this.trainerPokemonBindingSource.DataMember = "TrainerPokemon";
            this.trainerPokemonBindingSource.DataSource = this.pokemonDataSet1BindingSource;
            // 
            // trainerPokemonTableAdapter
            // 
            this.trainerPokemonTableAdapter.ClearBeforeFill = true;
            // 
            // pokemonBindingSource1
            // 
            this.pokemonBindingSource1.DataMember = "Pokemon";
            this.pokemonBindingSource1.DataSource = this.pokemonDataSet1BindingSource;
            // 
            // pokemonTableAdapter1
            // 
            this.pokemonTableAdapter1.ClearBeforeFill = true;
            // 
            // pokemonBindingSource2
            // 
            this.pokemonBindingSource2.DataMember = "Pokemon";
            this.pokemonBindingSource2.DataSource = this.pokemonDataSet1BindingSource;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(84, 264);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 75;
            this.dataGridView2.Size = new System.Drawing.Size(909, 244);
            this.dataGridView2.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(491, 514);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Team";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ViewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 559);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewTeam";
            this.Text = "ViewTeam";
            this.Load += new System.EventHandler(this.ViewTeam_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainerPokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.BindingSource pokemonDataSet1BindingSource;
        private PokemonDataSet1 pokemonDataSet1;
        private System.Windows.Forms.BindingSource trainerPokemonBindingSource;
        private PokemonDataSet1TableAdapters.TrainerPokemonTableAdapter trainerPokemonTableAdapter;
        private System.Windows.Forms.BindingSource pokemonBindingSource1;
        private PokemonDataSet1TableAdapters.PokemonTableAdapter pokemonTableAdapter1;
        private System.Windows.Forms.BindingSource pokemonBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnUpdate;
    }
}