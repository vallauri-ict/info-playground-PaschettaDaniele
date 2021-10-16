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
    public partial class FormFiglia1 : Form
    {

        public string durata = "";
        ToolStripLabel ssLabel;
        Form1 f;
        FormFiglia2 ff2;
        public FormFiglia1()
        {
            InitializeComponent();
        }

        public FormFiglia1(ToolStripLabel ssLabel1, FormFiglia2 ff2, Form1 f1)
        {
            InitializeComponent();

            this.ssLabel = ssLabel1;
            this.f = f1;
            this.ff2 = ff2;
        }

        private void btnBlitz1_Click(object sender, EventArgs e)
        {
            btnBlitz1.BackColor = Color.Red;

            btnBlitz2.BackColor = Color.White;
            btnBlitz3.BackColor = Color.White;
            btnRapid1.BackColor = Color.White;
            btnRapid2.BackColor = Color.White;
            btnRapid3.BackColor = Color.White;

            this.ssLabel.Text = "Blitz 3 + 2";
            this.durata = "Blitz 3 + 2";

            scelta();
        }

        private void btnBlitz2_Click(object sender, EventArgs e)
        {
            btnBlitz2.BackColor = Color.Red;

            btnBlitz1.BackColor = Color.White;
            btnBlitz3.BackColor = Color.White;
            btnRapid1.BackColor = Color.White;
            btnRapid2.BackColor = Color.White;
            btnRapid3.BackColor = Color.White;

            this.ssLabel.Text = "Blitz 5 + 0";
            this.durata = "Blitz 5 + 0";

            scelta();
        }

        private void btnBlitz3_Click(object sender, EventArgs e)
        {
            btnBlitz3.BackColor = Color.Red;

            btnBlitz1.BackColor = Color.White;
            btnBlitz2.BackColor = Color.White;
            btnRapid1.BackColor = Color.White;
            btnRapid2.BackColor = Color.White;
            btnRapid3.BackColor = Color.White;

            this.ssLabel.Text = "Blitz 5 + 3";
            this.durata = "Blitz 5 + 3";

            scelta();
        }

        private void btnRapid1_Click(object sender, EventArgs e)
        {
            btnRapid1.BackColor = Color.Red;

            btnBlitz1.BackColor = Color.White;
            btnBlitz2.BackColor = Color.White;
            btnBlitz3.BackColor = Color.White;
            btnRapid2.BackColor = Color.White;
            btnRapid3.BackColor = Color.White;

            this.ssLabel.Text = "Rapid 10 + 0";
            this.durata = "Rapid 10 + 0";

            scelta();
        }

        private void btnRapid2_Click(object sender, EventArgs e)
        {
            btnRapid2.BackColor = Color.Red;

            btnBlitz1.BackColor = Color.White;
            btnBlitz2.BackColor = Color.White;
            btnBlitz3.BackColor = Color.White;
            btnRapid1.BackColor = Color.White;
            btnRapid3.BackColor = Color.White;

            this.ssLabel.Text = "Rapid 10 + 5";
            this.durata = "Rapid 10 + 5";

            scelta();
        }

        private void btnRapid3_Click(object sender, EventArgs e)
        {
            btnRapid3.BackColor = Color.Red;

            btnBlitz1.BackColor = Color.White;
            btnBlitz2.BackColor = Color.White;
            btnBlitz3.BackColor = Color.White;
            btnRapid1.BackColor = Color.White;
            btnRapid2.BackColor = Color.White;

            this.ssLabel.Text = "Rapid 15 + 10";
            this.durata = "Rapid 15 + 10";

            scelta();
        }

        private void scelta()
        {
            FormModaleFiglia1 fmf1 = new FormModaleFiglia1();
            if(fmf1.ShowDialog() == DialogResult.OK)
            {
                this.Enabled = false;
                if (!f.aperto2)
                {
                    ff2 = new FormFiglia2(ssLabel, this.durata, this, f);
                    this.AddOwnedForm(ff2);
                    ff2.MdiParent = f;
                    ff2.Text = "Giocatore: ";
                    ff2.StartPosition = FormStartPosition.Manual;
                    ff2.Location = new Point(250, 0);
                    ff2.Show();
                    f.aperto2 = true;
                }
            }
        }

        private void FormFiglia1_FormClosing(object sender, FormClosingEventArgs e)
        {
            f.aperto1 = false;
        }

        private void FormFiglia1_Load(object sender, EventArgs e)
        {

        }
    }
}
