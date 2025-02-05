namespace Diouf_Ouleymatou
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listedesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listedesvoitureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listedesEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.rapportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.voitureToolStripMenuItem,
            this.empruntToolStripMenuItem});
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            // 
            // rapportToolStripMenuItem
            // 
            this.rapportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listedesClientToolStripMenuItem,
            this.listedesvoitureToolStripMenuItem,
            this.listedesEmpruntToolStripMenuItem});
            this.rapportToolStripMenuItem.Name = "rapportToolStripMenuItem";
            this.rapportToolStripMenuItem.Size = new System.Drawing.Size(93, 29);
            this.rapportToolStripMenuItem.Text = "Rapport";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // voitureToolStripMenuItem
            // 
            this.voitureToolStripMenuItem.Name = "voitureToolStripMenuItem";
            this.voitureToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.voitureToolStripMenuItem.Text = "Voiture";
            this.voitureToolStripMenuItem.Click += new System.EventHandler(this.voitureToolStripMenuItem_Click);
            // 
            // empruntToolStripMenuItem
            // 
            this.empruntToolStripMenuItem.Name = "empruntToolStripMenuItem";
            this.empruntToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.empruntToolStripMenuItem.Text = "Emprunt";
            this.empruntToolStripMenuItem.Click += new System.EventHandler(this.empruntToolStripMenuItem_Click);
            // 
            // listedesClientToolStripMenuItem
            // 
            this.listedesClientToolStripMenuItem.Name = "listedesClientToolStripMenuItem";
            this.listedesClientToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listedesClientToolStripMenuItem.Text = "Liste-des-Client";
            // 
            // listedesvoitureToolStripMenuItem
            // 
            this.listedesvoitureToolStripMenuItem.Name = "listedesvoitureToolStripMenuItem";
            this.listedesvoitureToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listedesvoitureToolStripMenuItem.Text = "Liste-des-Voiture";
            this.listedesvoitureToolStripMenuItem.Click += new System.EventHandler(this.listedesvoitureToolStripMenuItem_Click);
            // 
            // listedesEmpruntToolStripMenuItem
            // 
            this.listedesEmpruntToolStripMenuItem.Name = "listedesEmpruntToolStripMenuItem";
            this.listedesEmpruntToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.listedesEmpruntToolStripMenuItem.Text = "Liste-des-Emprunt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listedesClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listedesvoitureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listedesEmpruntToolStripMenuItem;
    }
}

