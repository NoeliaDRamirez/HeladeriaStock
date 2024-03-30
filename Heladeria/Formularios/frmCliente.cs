using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.Data;
using Heladeria.Data.EntityFramework;
using Heladeria.Data.EntityFramework.Filtros;
using Heladeria.Data.EntityFramework.Entidades;

namespace Heladeria
{
    public partial class frmCliente : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroCliente Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroCliente();
        private Repositorio<Cliente> Repositorio = new Repositorio<Cliente>(new ClienteIdentificador());
        private Repositorio<CondicionFiscal> repCondicionFiscal = new Repositorio<CondicionFiscal>(new CondicionFiscalIdentificador());
        private bool Editando = false;
        public frmCliente()
        {
            InitializeComponent();
        }

        private void ActualizaGrilla()
        {
            ClienteBindingSource.DataSource = null;
            ClienteBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
        }
        private void CargarCondicionFiscals()
        {
            List<CondicionFiscal> CondicionesFiscales = new List<CondicionFiscal>();
            CondicionesFiscales.AddRange(repCondicionFiscal.Listar(new FiltroCondicionFiscal(), out _));
            CondicionFiscalBindingSource.DataSource = CondicionesFiscales;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            PaletaColores(grvCliente);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            ClienteBindingSource1.DataSource = new Cliente();
            Editando = false;
            HabilitarControles(true);
            CargarCondicionFiscals();
        }

        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de Clientes";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos de la nueva Cliente";
                }
                else
                {
                    pnlFiltro.Text = "Datos de la Cliente";
                }
            }
            //lblCF.Visible = !filtro;
            //cbCondicionFiscal.Visible = !filtro;
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtCliente.Enabled = filtro;
           // txtIdCondicionFiscal.Enabled = filtro;
            btnEliminar.Visible = !filtro && !nuevo;
            btnGuardar.Visible = !filtro;

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ClienteBindingSource1.DataSource = new Cliente();
            Editando = true;
            HabilitarControles(false, true);
            try
            {
                cbCondicionFiscal.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen tipoes de Clientes", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.IdCliente = null;
            Filtro.IdCondicionFiscal = null;
            Filtro.CUIT = null;
            Filtro.Direccion = null;
            Filtro.Nombre = null;
            Cliente actual = ClienteBindingSource1.DataSource as Cliente;
            if (actual == null)
            {
                MessageBox.Show("No se esta editando una entidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(actual.Nombre))
            {
                MessageBox.Show("El nombre es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(actual.Direccion))
            {
                MessageBox.Show("La direccion es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(actual.CUIT))
            {
                MessageBox.Show("El CUIT es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((actual.IdCondicionFiscal == 0))
            {
                MessageBox.Show("La condicion fiscal es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            bool nuevo = actual.IdCliente == 0;
            try
            {
                Repositorio.Guardar(actual);
            }
            catch
            {
                MessageBox.Show("CUIT repetido", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            Editando = false;
            ClienteBindingSource1.DataSource = new Cliente();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.IdCliente = null;
            Filtro.IdCondicionFiscal = null;
            Filtro.CUIT = null;
            Filtro.Direccion = null;
            Filtro.Nombre = null;
            Editando = false;
            ClienteBindingSource1.DataSource = new Cliente();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.IdCliente = null;
            Filtro.IdCondicionFiscal = null;
            Filtro.CUIT = null;
            Filtro.Direccion = null;
            Filtro.Nombre = null;
            if (MessageBox.Show("Esta seguro que desea eliminar este Cliente?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Cliente actual = ClienteBindingSource1.DataSource as Cliente;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("cliente en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }

        private void grvCliente_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void ClienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Cliente actual = ClienteBindingSource.Current as Cliente;
            if (Editando)
            {
                HabilitarControles(false, false);
                ClienteBindingSource1.DataSource = actual;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente actual = ClienteBindingSource1.DataSource as Cliente;

            Filtro.Direccion = actual.Direccion;
            Filtro.CUIT = actual.CUIT;
            Filtro.Nombre = actual.Nombre;
            if (actual.IdCliente != 0)
            {
                Filtro.IdCliente = actual.IdCliente;
            }
            else
            {
                Filtro.IdCliente = null;
            }
            if (actual.IdCondicionFiscal != 0)
            {
                Filtro.IdCondicionFiscal = actual.IdCondicionFiscal;
            }
            else
            {
                Filtro.IdCondicionFiscal = null;
            }
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cliente actual = ClienteBindingSource.Current as Cliente;
            Editando = actual != null;
            if (Editando)
            {
                HabilitarControles(false, false);
                ClienteBindingSource1.DataSource = actual;
                var CondicionFiscal = repCondicionFiscal.Listar(new FiltroCondicionFiscal() { IdCondicionFiscal = actual.IdCondicionFiscal }, out _).FirstOrDefault();
                if (CondicionFiscal != null)
                {
                    List<CondicionFiscal> tm = CondicionFiscalBindingSource.DataSource as List<CondicionFiscal>;
                    if (CondicionFiscal != null)
                    {
                        cbCondicionFiscal.SelectedItem = tm.FirstOrDefault(x => x.IdCondicionFiscal == CondicionFiscal.IdCondicionFiscal);
                    }
                }
            }
        }

        private void nupPagina_ValueChanged(object sender, EventArgs e)
        {
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
        }

        private void nupTamanioPagina_ValueChanged(object sender, EventArgs e)
        {
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
        }

        private const string up = " ↑";
        private const string down = " ↓";

        private string LimpiarNombre(string nombre)
        {
            if (nombre.Contains(up) || nombre.Contains(down))
            {
                nombre = nombre.Replace(up, string.Empty).Replace(down, string.Empty);
            }
            return nombre;
        }

        private void LimpiarOrdenamiento(string nombrecampo)
        {
            if (Filtro.Orden != null && Filtro.Orden != nombrecampo)
            {
                for (int i = 0; i < grvCliente.Columns.Count; i++)
                {
                    var columna = grvCliente.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }
        private void grvCliente_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = grvCliente.Columns[e.ColumnIndex];
            string nombrecampo = columna.DataPropertyName;
            if (!string.IsNullOrWhiteSpace(nombrecampo) && nombrecampo != nameof(Cliente.Direccion))
            {
                LimpiarOrdenamiento(nombrecampo);
                var texto = LimpiarNombre(columna.HeaderText);
                Filtro.Descendente = Filtro.Orden == nombrecampo ? !Filtro.Descendente : false;
                texto += Filtro.Descendente ? down : up;
                columna.HeaderText = texto;
                Filtro.Orden = nombrecampo;
                ActualizaGrilla();
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PaletaColores(DataGridView grv)
        {
            //panel pricipal

            pnlFiltro.ForeColor = Color.FromArgb(15, 6, 51);
            pnlFiltro.BackColor = Color.FromArgb(15, 6, 51);
            grv.BackgroundColor = Color.FromArgb(15, 6, 51);
            grv.GridColor = Color.Black;
            //data grid
            grv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grv.BorderStyle = BorderStyle.None;
            //grv.RowsDefaultCellStyle.Font{ "Century Gothic"; 9,75pt};
            grv.RowsDefaultCellStyle.ForeColor = Color.White;
            grv.RowsDefaultCellStyle.BackColor = Color.FromArgb(30, 11, 99);
            grv.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            grv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //cabecera superior
            grv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 20, 179);
            grv.EnableHeadersVisualStyles = false;
            grv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            grv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grv.ColumnHeadersHeight = 30;
            //cabecera lateral
            grv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grv.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 11, 99);
            grv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            grv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        }

        private void pnlFiltro_Enter(object sender, EventArgs e)
        {

        }
    }
}
