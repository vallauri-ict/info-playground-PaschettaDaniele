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
    public partial class FormInfo : Form
    {
        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            label1.Text = "Programma creato da Paschetta Daniele\n4B INFO\nin data 09/10/2021\n\ncon l'obbiettivo: Verifica Informatica MultiForm";
        }
    }
}
