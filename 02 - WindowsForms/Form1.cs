using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02___WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFrm1_Click(object sender, EventArgs e)
        {
            FormFiglia1 frm1 = new FormFiglia1();
            frm1.MdiParent = this;
            frm1.Text = "Figlia 1";
            frm1.Size = new Size(210, 150);
            frm1.StartPosition = FormStartPosition.Manual;
            frm1.Location = new Point(10, 120);
            frm1.Show();
        }

        private void btnFrm2_Click(object sender, EventArgs e)
        {
            FormFiglia2 frm1 = new FormFiglia2();
            frm1.MdiParent = this;
            frm1.Text = "Figlia 2";
            frm1.Size = new Size(210, 150);
            frm1.StartPosition = FormStartPosition.Manual;
            frm1.Location = new Point(225, 120);
            frm1.Show();
        }

        private void btnFinestreAperte_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sono state aperte " + this.MdiChildren.Length + " fineste figlie");
            foreach (Form f in this.MdiChildren)
            {
                MessageBox.Show("Finestra '" + f.Text + "' aperta");
            }
        }

        private void apriForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Premuto Apri Form 1";
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Premuto Apri Form 2";
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormEsci frmEsci = new FormEsci();
            frmEsci.Text = "Esci?";

            if (frmEsci.ShowDialog() == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormInfo fi = new FormInfo();
            fi.ShowDialog();
        }
    }
}
