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
    
    public partial class FormFiglia1 : Form
    {
        public bool pelleIsChecked;
        public bool stoffaIsChecked;
        public int marcaIndex;
        ToolStripStatusLabel Tssl;

        string[] marche = new string[] { "BMW", "FIAT", "SEAT", "OPEL" };
        public FormFiglia1(bool pelleIsChecked, bool stoffaIsChecked, int marcaIndex, ToolStripStatusLabel Tssl1)
        {   
            InitializeComponent();
            this.pelleIsChecked = pelleIsChecked;
            this.stoffaIsChecked = stoffaIsChecked;
            this.marcaIndex = marcaIndex;
            this.Tssl = Tssl1;

            ChbSediliPelle.Checked = pelleIsChecked;
            ChbSediliStoffa.Checked = stoffaIsChecked;
            comboBox1.SelectedIndex = marcaIndex;
        }

        private void FormFiglia1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.marcaIndex = comboBox1.SelectedIndex;
            Tssl.Text = "La tua auto è una " + marche[marcaIndex];
        }

        private void ChbSediliPelle_CheckedChanged(object sender, EventArgs e)
        {
            this.pelleIsChecked = ChbSediliPelle.Checked;
            if (ChbSediliPelle.Checked == true)
            {
                ChbSediliStoffa.Checked = false;
                this.stoffaIsChecked = ChbSediliStoffa.Checked;
            }
        }

        private void ChbSediliStoffa_CheckedChanged(object sender, EventArgs e)
        {
            this.stoffaIsChecked = ChbSediliStoffa.Checked;
            if (ChbSediliStoffa.Checked == true)
            {
                ChbSediliPelle.Checked = false;
                this.pelleIsChecked = ChbSediliPelle.Checked;
            }
        }
    }
}
