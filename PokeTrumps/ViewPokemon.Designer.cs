namespace PokeTrumps
{
    partial class ViewPokemon
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pokemonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.defenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialAttackDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialDefenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pokemonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pokemonDataSet = new PokeTrumps.PokemonDataSet();
            this.pokemonTableAdapter = new PokeTrumps.PokemonDataSetTableAdapters.PokemonTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pokemonIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.attackDataGridViewTextBoxColumn,
            this.defenceDataGridViewTextBoxColumn,
            this.specialAttackDataGridViewTextBoxColumn,
            this.specialDefenceDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.pokemonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 75;
            this.dataGridView1.Size = new System.Drawing.Size(869, 346);
            this.dataGridView1.TabIndex = 0;
            // 
            // pokemonIDDataGridViewTextBoxColumn
            // 
            this.pokemonIDDataGridViewTextBoxColumn.DataPropertyName = "PokemonID";
            this.pokemonIDDataGridViewTextBoxColumn.HeaderText = "PokemonID";
            this.pokemonIDDataGridViewTextBoxColumn.Name = "pokemonIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // attackDataGridViewTextBoxColumn
            // 
            this.attackDataGridViewTextBoxColumn.DataPropertyName = "Attack";
            this.attackDataGridViewTextBoxColumn.HeaderText = "Attack";
            this.attackDataGridViewTextBoxColumn.Name = "attackDataGridViewTextBoxColumn";
            // 
            // defenceDataGridViewTextBoxColumn
            // 
            this.defenceDataGridViewTextBoxColumn.DataPropertyName = "Defence";
            this.defenceDataGridViewTextBoxColumn.HeaderText = "Defence";
            this.defenceDataGridViewTextBoxColumn.Name = "defenceDataGridViewTextBoxColumn";
            // 
            // specialAttackDataGridViewTextBoxColumn
            // 
            this.specialAttackDataGridViewTextBoxColumn.DataPropertyName = "SpecialAttack";
            this.specialAttackDataGridViewTextBoxColumn.HeaderText = "SpecialAttack";
            this.specialAttackDataGridViewTextBoxColumn.Name = "specialAttackDataGridViewTextBoxColumn";
            // 
            // specialDefenceDataGridViewTextBoxColumn
            // 
            this.specialDefenceDataGridViewTextBoxColumn.DataPropertyName = "SpecialDefence";
            this.specialDefenceDataGridViewTextBoxColumn.HeaderText = "SpecialDefence";
            this.specialDefenceDataGridViewTextBoxColumn.Name = "specialDefenceDataGridViewTextBoxColumn";
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "Speed";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // ViewPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 485);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewPokemon";
            this.Text = "ViewPokemon";
            this.Load += new System.EventHandler(this.ViewPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PokemonDataSet pokemonDataSet;
        private System.Windows.Forms.BindingSource pokemonBindingSource;
        private PokemonDataSetTableAdapters.PokemonTableAdapter pokemonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pokemonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn defenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialAttackDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialDefenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
    }
}