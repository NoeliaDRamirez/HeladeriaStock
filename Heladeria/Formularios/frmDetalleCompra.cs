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
    public partial class frmDetalleCompra : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroDetalleCompra Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroDetalleCompra();
        private Repositorio<DetalleCompra> Repositorio = new Repositorio<DetalleCompra>(new DetalleCompraIdentificador());
        private Repositorio<Proveedor> repProveedor = new Repositorio<Proveedor>(new ProveedorIdentificador());
        private bool Editando = false;
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void ActualizaGrilla()
        {
            DetalleCompraBindingSource.DataSource = null;
            DetalleCompraBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
        }
        private void CargarProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            proveedores.AddRange(repProveedor.Listar(new FiltroProveedor(), out _));
            ProveedorBindingSource.DataSource = proveedores;
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            PaletaColores(grvDetalleCompra);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            DetalleCompraBindingSource1.DataSource = new DetalleCompra();
            Editando = false;
            HabilitarControles(true);
            CargarProveedores();
        }

        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de DetalleCompras";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos del nuevo DetalleCompra";
                }
                else
                {
                    pnlFiltro.Text = "Datos del DetalleCompra";
                }
            }
            //cbProveedor.Visible = !filtro;
            //lblProveedor.Visible = !filtro;
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtDetalleCompra.Enabled = filtro;
            //txtIdProveedor.Enabled = filtro;
            btnEliminar.Visible = !filtro && !nuevo;
            btnGuardar.Visible = !filtro;

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DetalleCompraBindingSource1.DataSource = new DetalleCompra();
            Editando = true;
            HabilitarControles(false, true);
            try
            {
                cbProveedor.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen proveedores", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.IdDetalleCompra = null;
            Filtro.IdProveedor = null;
            Filtro.Lote = null;
            DateTime fecha =  DateTime.Today;
            DetalleCompra actual = DetalleCompraBindingSource1.DataSource as DetalleCompra;
            actual.Fecha = fecha;
            if (actual == null)
            {
                MessageBox.Show("No se esta editando una entidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.Lote == 0)
            {
                MessageBox.Show("El lote es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.IdProveedor == 0)
            {
                MessageBox.Show("El provedor es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                Repositorio.Guardar(actual);
            }
            catch
            {
                MessageBox.Show("lote repetido", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            Editando = false;
            DetalleCompraBindingSource1.DataSource = new DetalleCompra();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.IdDetalleCompra = null;
            Filtro.IdProveedor = null;
            Filtro.Lote = null;
            Editando = false;
            DetalleCompraBindingSource1.DataSource = new DetalleCompra();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.IdDetalleCompra = null;
            Filtro.IdProveedor = null;
            Filtro.Lote = null;
            if (MessageBox.Show("Esta seguro que desea eliminar este Detalle de Compra?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DetalleCompra actual = DetalleCompraBindingSource1.DataSource as DetalleCompra;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("detalle de compra en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }

        private void grvDetalleCompra_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void DetalleCompraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DetalleCompra actual = DetalleCompraBindingSource.Current as DetalleCompra;
            if (Editando)
            {
                HabilitarControles(false, false);
                DetalleCompraBindingSource1.DataSource = actual;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DetalleCompra actual = DetalleCompraBindingSource1.DataSource as DetalleCompra;
            if(nudLote.Value != 0)
                Filtro.Lote = actual.Lote;
            if (actual.IdDetalleCompra != 0)
            {
                Filtro.IdDetalleCompra = actual.IdDetalleCompra;
            }
            else
            {
                Filtro.IdDetalleCompra = null;
            }
            if (actual.IdProveedor != 0)
            {
                Filtro.IdProveedor = actual.IdProveedor;
            }
            else
            {
                Filtro.IdProveedor = null;
            }
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DetalleCompra actual = DetalleCompraBindingSource.Current as DetalleCompra;
            Editando = actual != null;
            if (Editando)
            {
                HabilitarControles(false, false);
                DetalleCompraBindingSource1.DataSource = actual;
                var Proveedor = repProveedor.Listar(new FiltroProveedor() { IdProveedor = actual.IdProveedor }, out _).FirstOrDefault();
                if (Proveedor != null)
                {
                    List<Proveedor> tm = ProveedorBindingSource.DataSource as List<Proveedor>;
                    if (Proveedor != null)
                    {
                        cbProveedor.SelectedItem = tm.FirstOrDefault(x => x.IdProveedor == Proveedor.IdProveedor);
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
                for (int i = 0; i < grvDetalleCompra.Columns.Count; i++)
                {
                    var columna = grvDetalleCompra.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }
        private void grvDetalleCompra_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = grvDetalleCompra.Columns[e.ColumnIndex];
            string nombrecampo = columna.DataPropertyName;
            if (!string.IsNullOrWhiteSpace(nombrecampo) && nombrecampo != nameof(DetalleCompra.Lote))
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
