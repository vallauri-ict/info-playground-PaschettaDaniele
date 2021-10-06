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
    public partial class FormFiglia2 : Form
    {
        bool pelleIsChecked;
        bool stoffaIsChecked;
        int marcaIndex;
        string[] marche = new string[] {"BMW", "FIAT", "SEAT", "OPEL"};
        public FormFiglia2(bool pelleIsChecked, bool stoffaIsChecked, int marcaIndex)
        {
            InitializeComponent();
            this.pelleIsChecked = pelleIsChecked;
            this.stoffaIsChecked = stoffaIsChecked;
            this.marcaIndex = marcaIndex;

        }

        private void FormFiglia2_Load(object sender, EventArgs e)
        {
            string marca;
            string sedili = "";

            if (pelleIsChecked)
            {
                sedili = "sedili di pelle";
            }
            else if(stoffaIsChecked)
            {
                sedili = "sedili di stoffa";
            }

            if(sedili != "")
            {
                marca = marche[marcaIndex];

                lbl1.Text = "Hai selezionato una " + marca + " con " + sedili;
            }
            else
            {
                lbl1.Text = "Devi prima selezionare una macchina dalla pagina 1";
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
