using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diouf_Ouleymatou
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listedesvoitureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClient formClient = new FormClient();
            formClient.MdiParent = this;
            formClient.Show();
        }

        private void voitureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVoiture FormVoiture = new FormVoiture ();
            FormVoiture.MdiParent = this;
            FormVoiture.Show();
        }

        private void empruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmprunt FormEmprunt = new FormEmprunt();
            FormEmprunt.MdiParent = this;
            FormEmprunt.Show();
        }
    }
}
