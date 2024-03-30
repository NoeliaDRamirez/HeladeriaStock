using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heladeria.Formularios
{
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }
        private void PaletaColores()
        {
            //panel pricipal

            pnlFiltro.ForeColor = Color.FromArgb(15, 6, 51);
            pnlFiltro.BackColor = Color.FromArgb(15, 6, 51);
            //grv.BackgroundColor = Color.FromArgb(15, 6, 51);
            //grv.GridColor = Color.Black;
        }
        private void frmAcercaDe_Load(object sender, EventArgs e)
        {
            PaletaColores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
