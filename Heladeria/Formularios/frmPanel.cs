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
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
            DisenioPanel();
        }
        private void DisenioPanel()
        {
            panelSubMenu1.Visible = false;  
            panelSubMenu2.Visible = false;
           // panelSubMenu3.Visible = false;
            panelSubMenu4.Visible = false;
            panelSubMenu5.Visible = false;
            panelSubMenu6.Visible = false;
            panelSubMenu7.Visible = false;
            panelSubMenu8.Visible = false;
            panelSubMenu9.Visible = false;

        }
        private void OcultarSubMenu()
        {
            if(panelSubMenu1.Visible == true)
                panelSubMenu1.Visible = false ;
            if (panelSubMenu2.Visible == true)
                panelSubMenu2.Visible = false;
          // if (panelSubMenu3.Visible == true)
             //  panelSubMenu3.Visible = false;
            if (panelSubMenu4.Visible == true)
                panelSubMenu4.Visible = false;
            if (panelSubMenu5.Visible == true)
                panelSubMenu5.Visible = false;
            if (panelSubMenu6.Visible == true)
                panelSubMenu6.Visible = false;
            if (panelSubMenu7.Visible == true)
                panelSubMenu7.Visible = false;
            if (panelSubMenu8.Visible == true)
                panelSubMenu8.Visible = false;
            if (panelSubMenu9.Visible == true)
                panelSubMenu9.Visible = false;
        }
        private void MostrarSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                OcultarSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void frmPanel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmArticulo());
            OcultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCategoria());
            OcultarSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCondicionFiscal());
            OcultarSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmVenta());
            OcultarSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDetalleVenta());
            OcultarSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmTipoPago());
            OcultarSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
           // MostrarSubMenu(panelSubMenu3);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //codigo
            OcultarSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //codigo
            OcultarSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //codigo
            OcultarSubMenu();
        }
        private Form activarFormulario = null;
        private void AbrirFormulario(Form formulario)
        {
            if(activarFormulario != null)
                activarFormulario.Close();
            activarFormulario = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelFormulario.Controls.Add(formulario);
            panelFormulario.Tag = formulario;
            formulario.BringToFront();
            formulario.Show();
        }

        /*private void Menu3_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu3);
        }*/

        private void Menu4_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu4);
        }

        private void Menu5_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu5);
        }

        private void Menu6_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu6);
        }

        private void Menu7_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu7);
        }

        private void Menu8_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu8);
        }

        private void Menu9_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
           // AbrirFormulario(new frmInformeMasVendidos());
            OcultarSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRepartidor());
            OcultarSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCliente());
            OcultarSubMenu();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPedido());
            OcultarSubMenu();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRepartidor());
            OcultarSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCliente());
            OcultarSubMenu();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCompra());
            OcultarSubMenu();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDetalleCompra());
            OcultarSubMenu();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmProveedor());
            OcultarSubMenu();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInformeMasVendidos());
            OcultarSubMenu();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInformeCaja());
            OcultarSubMenu();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInformeMayorGanacia());
            OcultarSubMenu();
        }

        private void button34_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new frmInformeTotalVentas());
            OcultarSubMenu();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInformeStock());
            OcultarSubMenu();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCondicionFiscal());
            OcultarSubMenu();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCliente());
            OcultarSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubMenu9);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAcercaDe());
            OcultarSubMenu();
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario(new frmAreaEnvio());
            OcultarSubMenu();
        }
    }
}

