using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_03___Preparazione_Verifica_MultiForm
{
    public partial class Form1 : Form
    {
        bool pelleIsChecked = false;
        bool stoffaIsChecked = false;
        int marcaIndex = 0;
        string[] marche = new string[] { "BMW", "FIAT", "SEAT", "OPEL" };
        bool aperto = false;

        FormFiglia1 ff1;
        public Form1()
        {
            InitializeComponent();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormEsci fe = new FormEsci();
            if(fe.ShowDialog() == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void apri1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aperto)
            {
                pelleIsChecked = ff1.pelleIsChecked;
                stoffaIsChecked = ff1.stoffaIsChecked;
                marcaIndex = ff1.marcaIndex;
            }

            ff1 = new FormFiglia1(pelleIsChecked, stoffaIsChecked, marcaIndex, Tssl1);
            ff1.MdiParent = this;
            ff1.Text = "Sedili e Marca";
            ff1.Show();
            aperto = true;
        }

        private void apri2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (aperto)
            {
                pelleIsChecked = ff1.pelleIsChecked;
                stoffaIsChecked = ff1.stoffaIsChecked;
                marcaIndex = ff1.marcaIndex;
            }

            FormFiglia2 ff2 = new FormFiglia2(pelleIsChecked, stoffaIsChecked, marcaIndex);
            ff2.MdiParent = this;
            ff2.Text = "Macchina selezionata";
            ff2.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormInfo ffi = new FormInfo();
            ffi.Text = "informazioni";
            ffi.ShowDialog();
        }
    }
}
