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
    public partial class FormModaleFiglia2 : Form
    {
        public FormModaleFiglia2()
        {
            InitializeComponent();
        }

        public FormModaleFiglia2(string durata, string colore)
        {
            InitializeComponent();

            if(durata != "" && colore != "")
            {
                label1.Text = "La partita " + durata + " con il colore " + colore + " sta per iniziare";
            }
            else
            {
                label1.Text = "Bisogna prima selezionare tutte le informazioni correttamente";
            }

        }

        private void FormModaleFiglia2_Load(object sender, EventArgs e)
        {

        }
    }
}
