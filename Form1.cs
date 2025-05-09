using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olamuchogusto
{
    public partial class Form1 : Form
    {
        Acciones acc = new Acciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void Most_Click(object sender, EventArgs e)
        {
            dgDatos.DataSource = acc.Mostrar();
        }

        private void Exp_Click(object sender, EventArgs e)
        {

        }

        private void Imp_Click(object sender, EventArgs e)
        {

        }
    }
}
