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


namespace Heladeria.Formularios
{
    public partial class frmProveedor : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroProveedor Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroProveedor();
        private Repositorio<Proveedor> Repositorio = new Repositorio<Proveedor>(new ProveedorIdentificador());
        private Repositorio<CondicionFiscal> repCondicionFiscal = new Repositorio<CondicionFiscal>(new CondicionFiscalIdentificador());

        private bool Editando = false;
        public frmProveedor()
        {
            InitializeComponent();
        }
        private void ActualizaGrilla()
        {
            proveedorBindingSource.DataSource = null;
            proveedorBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
        }
        private void CargarCondicionFiscals()
        {
            List<CondicionFiscal> CondicionesFiscales = new List<CondicionFiscal>();
            CondicionesFiscales.AddRange(repCondicionFiscal.Listar(new FiltroCondicionFiscal(), out _));
            condicionFiscalBindingSource.DataSource = CondicionesFiscales;
        }
        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de Proveedores";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos del nuevo proveedor";
                }
                else
                {
                    pnlFiltro.Text = "Datos del proveedor";
                }
            }
           // lblCondFiscal.Visible = !filtro;
            //cbCondFiscal.Visible = !filtro;
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtProveedor.Enabled = filtro;
            //txtIdCondicionFiscal.Enabled = filtro;
            btnEliminar.Visible = !filtro && !nuevo;
            btnGuardar.Visible = !filtro;

        }
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            PaletaColores(dgvProveedor);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            proveedorBindingSource1.DataSource = new Proveedor();
            Editando = false;
            HabilitarControles(true);
            CargarCondicionFiscals();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            proveedorBindingSource1.DataSource = new Proveedor();
            Editando = true;
            HabilitarControles(false, true);
            try
            {
                cbCondFiscal.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen tipos de Proveedores", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.Direccion = null;
            Filtro.CUIT = null;
            Filtro.Nombre = null;
            Filtro.Telefono = null;
            Filtro.Pais = null;
            Filtro.Ciudad = null;
            Filtro.Codigo = null;
            Filtro.IdProveedor = null;
            Filtro.IdCondicionFiscal = null;
            try
            {
                Proveedor actual = proveedorBindingSource1.DataSource as Proveedor;
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
                if (string.IsNullOrWhiteSpace(actual.Codigo))
                {
                    MessageBox.Show("El codigo es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                if (string.IsNullOrWhiteSpace(actual.Telefono))
                {
                    MessageBox.Show("El telefono es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (string.IsNullOrWhiteSpace(actual.Pais))
                {
                    MessageBox.Show("El pais es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (string.IsNullOrWhiteSpace(actual.Ciudad))
                {
                    MessageBox.Show("La ciudad es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if ((actual.IdCondicionFiscal == 0))
                {
                    MessageBox.Show("La condicion fiscal es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                bool nuevo = actual.IdProveedor == 0;


                Repositorio.Guardar(actual);
                Editando = false;
                proveedorBindingSource1.DataSource = new Proveedor();
                ActualizaGrilla();
                HabilitarControles(true);
            }
            catch
            {              
                MessageBox.Show("Codigo o CUIT repetido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.Direccion = null;
            Filtro.CUIT = null;
            Filtro.Nombre = null;
            Filtro.Telefono = null;
            Filtro.Pais = null;
            Filtro.Ciudad = null;
            Filtro.Codigo = null;
            Filtro.IdProveedor = null;
            Filtro.IdCondicionFiscal = null;
            Editando = false;
            proveedorBindingSource1.DataSource = new Proveedor();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.Direccion = null;
            Filtro.CUIT = null;
            Filtro.Nombre = null;
            Filtro.Telefono = null;
            Filtro.Pais = null;
            Filtro.Ciudad = null;
            Filtro.Codigo = null;
            Filtro.IdProveedor = null;
            Filtro.IdCondicionFiscal = null;
            if (MessageBox.Show("Esta seguro que desea eliminar este proveedor?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Proveedor actual = proveedorBindingSource1.DataSource as Proveedor;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("proveedor en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }

        private void proveedorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Proveedor actual = proveedorBindingSource.Current as Proveedor;
            if (Editando)
            {
                HabilitarControles(false, false);
                proveedorBindingSource1.DataSource = actual;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Proveedor actual = proveedorBindingSource1.DataSource as Proveedor;

            Filtro.Direccion = actual.Direccion;
            Filtro.CUIT = actual.CUIT;
            Filtro.Nombre = actual.Nombre;
            Filtro.Telefono= actual.Telefono;
            Filtro.Pais = actual.Pais;
            Filtro.Ciudad = actual.Ciudad;
            Filtro.Codigo = actual.Codigo;

            if (actual.IdProveedor != 0)
            {
                Filtro.IdProveedor = actual.IdProveedor;
            }
            else
            {
                Filtro.IdProveedor = null;
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
            Proveedor actual = proveedorBindingSource.Current as Proveedor;
            Editando = actual != null;
            if (Editando)
            {
                HabilitarControles(false, false);
                proveedorBindingSource1.DataSource = actual;
                var CondicionFiscal = repCondicionFiscal.Listar(new FiltroCondicionFiscal() { IdCondicionFiscal = actual.IdCondicionFiscal }, out _).FirstOrDefault();
                if (CondicionFiscal != null)
                {
                    List<CondicionFiscal> tm = condicionFiscalBindingSource.DataSource as List<CondicionFiscal>;
                    if (CondicionFiscal != null)
                    {
                        cbCondFiscal.SelectedItem = tm.FirstOrDefault(x => x.IdCondicionFiscal == CondicionFiscal.IdCondicionFiscal);
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
                for (int i = 0; i < dgvProveedor.Columns.Count; i++)
                {
                    var columna = dgvProveedor.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }

        private void dgvProveedor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = dgvProveedor.Columns[e.ColumnIndex];
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
            grv.RowsDefaultCellStyle.BackColor = Color.FromArgb(0, 10, 64);
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
    }
}
