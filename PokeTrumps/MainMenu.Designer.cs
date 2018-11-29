namespace PokeTrumps
{
    partial class MainMenu
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
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnViewPokemon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Location = new System.Drawing.Point(230, 78);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(99, 23);
            this.btnCreateAcc.TabIndex = 0;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(230, 145);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnViewPokemon
            // 
            this.btnViewPokemon.Location = new System.Drawing.Point(230, 207);
            this.btnViewPokemon.Name = "btnViewPokemon";
            this.btnViewPokemon.Size = new System.Drawing.Size(99, 23);
            this.btnViewPokemon.TabIndex = 2;
            this.btnViewPokemon.Text = "View Pokemon";
            this.btnViewPokemon.UseVisualStyleBackColor = true;
            this.btnViewPokemon.Click += new System.EventHandler(this.btnViewPokemon_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 323);
            this.Controls.Add(this.btnViewPokemon);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateAcc);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnViewPokemon;
    }
}

