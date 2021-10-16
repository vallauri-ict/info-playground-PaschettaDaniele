using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paschetta
{
    public partial class FormFiglia2 : Form
    {
        Random rnd = new Random();

        ToolStripLabel ssLabel;
        FormFiglia1 ff1;
        Form1 f;
        string[] colori = new string[] { "Nero", "Bianco"};
        int indColore;
        string durata;
        public FormFiglia2()
        {
            InitializeComponent();
        }

        public FormFiglia2(ToolStripLabel ssLabel1, string durata, FormFiglia1 ff, Form1 f1)
        {
            InitializeComponent();

            this.ssLabel = ssLabel1;
            this.durata = durata;
            this.ff1 = ff;
            this.f = f1;
        }

        private void FormFiglia2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnInizia_Click(object sender, EventArgs e)
        {
            FormModaleFiglia2 fmf2 = new FormModaleFiglia2(this.durata, colori[indColore]);
            fmf2.Text = "Partita";
            fmf2.ShowDialog();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormFiglia2_FormClosing(object sender, FormClosingEventArgs e)
        {
            ff1.Enabled = true;
            f.aperto2 = false;
        }


        private void rbNero_Click(object sender, EventArgs e)
        {
            indColore = 0;
            this.ssLabel.Text = this.durata + " con colore " + colori[indColore];
        }

        private void rbBianco_Click(object sender, EventArgs e)
        {
            indColore = 1;
            this.ssLabel.Text = this.durata + " con colore " + colori[indColore];
        }

        private void rbCasuale_Click(object sender, EventArgs e)
        {
            indColore = rnd.Next(0, 1 + 1);
            this.ssLabel.Text = this.durata + " con colore " + colori[indColore];
        }
    }
}
