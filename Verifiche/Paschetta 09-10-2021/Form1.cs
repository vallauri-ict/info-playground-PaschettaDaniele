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
    public partial class Form1 : Form
    {
        public bool aperto1 = false;
        public bool aperto2 = false;
        public string durata = "";

        FormFiglia1 ff1;
        FormFiglia2 ff2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ssLabel.Text = "Benvenuto";        
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!aperto1)
            {
                ff1 = new FormFiglia1(ssLabel, ff2, this);
                this.AddOwnedForm(ff1);
                ff1.MdiParent = this;
                ff1.Text = "Durata: ";
                ff1.StartPosition = FormStartPosition.Manual;
                ff1.Location = new Point(0, 0);
                ff1.Show();
                aperto1 = true;
            }
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aperto1 && !aperto2)
            {
                ff2 = new FormFiglia2(ssLabel, ff1.durata, ff1, this);
                this.AddOwnedForm(ff2);
                ff2.MdiParent = this;
                ff2.Text = "Giocatore: ";
                ff2.StartPosition = FormStartPosition.Manual;
                ff2.Location = new Point(250, 0);
                ff2.Show();
                aperto2 = true;
            }
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormEsci fe = new FormEsci();
            if (fe.ShowDialog() == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormInfo fi = new FormInfo();
            fi.Text = "Informazioni sul programma";
            fi.ShowDialog();
        }
    }
}
