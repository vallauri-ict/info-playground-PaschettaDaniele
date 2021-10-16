using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04___OPP1
{
    public partial class Form1 : Form
    {
        Rectangle r;
        Rectangle s = new Rectangle();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCrea_Click(object sender, EventArgs e)
        {
            r = new Rectangle();
            r.side1 = Convert.ToInt32(txtBase.Text);
            r.side2 = Convert.ToInt32(txtAltezza.Text);

            MessageBox.Show("Oggettto r\nBase: " + r.side1 + " - Altezza:" + r.side2);

            s.side1 = Convert.ToInt32(txtBase.Text);
            s.side2 = Convert.ToInt32(txtAltezza.Text);

            MessageBox.Show("Oggettto s\nBase: " + s.side1 + " - Altezza: " + s.side2);


            Rectangle t;
            t = r; //passa il puntatore all'oggetto r, quindi anche t diventa l'oggetto r

            MessageBox.Show("Oggettto t\nBase: " + t.side1 + " - Altezza: " + t.side2);
        }
    }
}
