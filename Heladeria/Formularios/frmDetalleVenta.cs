using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Heladeria.Data;
using Heladeria.Data.EntityFramework;
using Heladeria.Data.EntityFramework.Filtros;
using Heladeria.Data.EntityFramework.Entidades;

namespace Heladeria.Formularios
{
    public partial class frmDetalleVenta : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroDetalleVenta Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroDetalleVenta();
        private Repositorio<DetalleVenta> Repositorio = new Repositorio<DetalleVenta>(new DetalleVentaIdentificador());
        private Repositorio<Articulo> repArticulo = new Repositorio<Articulo>(new ArticuloIdentificador());
        private bool Editando = false;

        public frmDetalleVenta()
        {
            InitializeComponent();
        }
        List<Articulo> listaArt = new List<Articulo>();
        private void ActualizaGrilla()
        {
            DetalleVentaBindingSource.DataSource = null;
            DetalleVentaBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
        }
        private List<Articulo> CargarArticulos()
        {
            List<Articulo> Articulos = new List<Articulo>();
            Articulos.AddRange(repArticulo.Listar(new FiltroArticulo(), out _));
            articuloBindingSource.DataSource = Articulos;
            return Articulos;
        }
        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de DetalleVenta";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos del nuevo DetalleVenta";
                }
                else
                {
                    pnlFiltro.Text = "Datos del DetalleVenta";
                }
            }
            //cbArticulo.Visible = !filtro;
           // lbArticulo.Visible = !filtro;
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtDetalleVenta.Enabled = filtro;
            //txtArticulo.Enabled = filtro;
            btnEliminar.Visible = !filtro && !nuevo;
            btnGuardar.Visible = !filtro;

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
        private void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            PaletaColores(grvDetalleVenta);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            DetalleVentaBindingSource1.DataSource = new DetalleVenta();
            Editando = false;
            HabilitarControles(true);
            listaArt = CargarArticulos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Filtro.IdDetalleVenta = null;
            Filtro.IdArticulo = null;
            Filtro.Cantidad = null;
            DetalleVentaBindingSource1.DataSource = new DetalleVenta();
            Editando = true;
            HabilitarControles(false, true);
            try
            {
                cbArticulo.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen articulos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.IdDetalleVenta = null;
            Filtro.IdArticulo = null;
            Filtro.Cantidad = null;
            DetalleVenta actual = DetalleVentaBindingSource1.DataSource as DetalleVenta;
            if (actual == null)
            {
                MessageBox.Show("No se esta editando una entidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.Cantidad == 0)
            {
                MessageBox.Show("La cantidad es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.IdArticulo == 0)
            {
                MessageBox.Show("El articulo es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Articulo articulo = new Articulo();
            foreach(Articulo art in listaArt)
            {
                if(art.IdArticulo == actual.IdArticulo)
                {
                    articulo = art;
                }
            }
            actual.PrecioUnitario = articulo.PrecioVenta;
            
            Repositorio.Guardar(actual);
            Editando = false;
            DetalleVentaBindingSource1.DataSource = new DetalleVenta();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.IdDetalleVenta = null;
            Filtro.IdArticulo = null;
            Filtro.Cantidad = null;
            Editando = false;
            DetalleVentaBindingSource1.DataSource = new DetalleVenta();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.IdDetalleVenta = null;
            Filtro.IdArticulo = null;
            Filtro.Cantidad = null;
            if (MessageBox.Show("Esta seguro que desea eliminar este Detalle de venta?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DetalleVenta actual = DetalleVentaBindingSource1.DataSource as DetalleVenta;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("detalle de venta en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }

        private void DetalleVentaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DetalleVenta actual = DetalleVentaBindingSource.Current as DetalleVenta;
            if (Editando)
            {
                HabilitarControles(false, false);
                DetalleVentaBindingSource1.DataSource = actual;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DetalleVenta actual = DetalleVentaBindingSource1.DataSource as DetalleVenta;
            if(nudCantidad.Value != 0)
                Filtro.Cantidad = actual.Cantidad;
            if (actual.IdDetalleVenta != 0)
            {
                Filtro.IdDetalleVenta = actual.IdDetalleVenta;
            }
            else
            {
                Filtro.IdDetalleVenta = null;
            }
            if (actual.IdArticulo != 0)
            {
                Filtro.IdArticulo = actual.IdArticulo;
            }
            else
            {
                Filtro.IdArticulo = null;
            }
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DetalleVenta actual = DetalleVentaBindingSource.Current as DetalleVenta;
            Editando = actual != null;
            if (Editando)
            {
                HabilitarControles(false, false);
                DetalleVentaBindingSource1.DataSource = actual;
                var Articulo = repArticulo.Listar(new FiltroArticulo() { IdArticulo = actual.IdArticulo }, out _).FirstOrDefault();
                if (Articulo != null)
                {
                    List<Articulo> tm = articuloBindingSource.DataSource as List<Articulo>;
                    if (Articulo != null)
                    {
                        cbArticulo.SelectedItem = tm.FirstOrDefault(x => x.IdArticulo == Articulo.IdArticulo);
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
                for (int i = 0; i < grvDetalleVenta.Columns.Count; i++)
                {
                    var columna = grvDetalleVenta.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }

        private void grvDetalleVenta_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = grvDetalleVenta.Columns[e.ColumnIndex];
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

        private void cbPrecioUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == (',')))
            {
                MessageBox.Show("Debe ingresar un valor numerico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

    }
}
