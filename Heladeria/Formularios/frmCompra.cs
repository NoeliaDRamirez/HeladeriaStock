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

namespace Heladeria
{
    public partial class frmCompra : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroCompra Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroCompra();
        private Repositorio<Compra> Repositorio = new Repositorio<Compra>(new CompraIdentificador());
        private Repositorio<Articulo> repArticulo = new Repositorio<Articulo>(new ArticuloIdentificador());
        private Repositorio<DetalleCompra> repDetalleCompra = new Repositorio<DetalleCompra>(new DetalleCompraIdentificador());
        private bool Editando = false;

        List<Articulo> listaArt = new List<Articulo>();
        public frmCompra()
        {
            InitializeComponent();
        }

        private void ActualizaGrilla()
        {
            CompraBindingSource.DataSource = null;
            CompraBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
        }
        private List<Articulo> CargarArticulos()
        {
            List<Articulo> Articulos = new List<Articulo>();
            Articulos.AddRange(repArticulo.Listar(new FiltroArticulo(), out _));
            ArticuloBindingSource.DataSource = Articulos;
            return Articulos;
        }
        private void CargarDetalleCompra()
        {
            List<DetalleCompra> detalles = new List<DetalleCompra>();
            detalles.AddRange(repDetalleCompra.Listar(new FiltroDetalleCompra(), out _));
            DetalleCompraBindingSource.DataSource = detalles;
        }
        private void frmCompra_Load(object sender, EventArgs e)
        {
            PaletaColores(grvCompra);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            CompraBindingSource1.DataSource = new Compra();
            Editando = false;
            HabilitarControles(true);

            listaArt = CargarArticulos();
            CargarDetalleCompra();
        }

        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de Compras";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos de la nueva Compra";
                }
                else
                {
                    pnlFiltro.Text = "Datos de la Compra";
                }
            }
            //lblIdDetalleCompra.Visible = !filtro;
            //cbIdDetalleCompra.Visible = !filtro;
            //lblTCompra.Visible = !filtro;
            //cbArticulo.Visible = !filtro;
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtCompra.Enabled = filtro;
            btnEliminar.Visible = !filtro && !nuevo;
            btnGuardar.Visible = !filtro;

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CompraBindingSource1.DataSource = new Compra();
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
            try
            {
                cbIdDetalleCompra.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen Detalles de Compras", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.Cantidad = null;
            Filtro.IdArticulo = null;
            Filtro.IdCompra = null;
            Filtro.IdDetalleCompra = null;

            Compra actual = CompraBindingSource1.DataSource as Compra;
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
            if (actual.IdDetalleCompra == 0)
            {
                MessageBox.Show("El Detalle de Compra es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if ((actual.IdArticulo == 0))
            {
                MessageBox.Show("El articulo es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Articulo articulo = new Articulo();
            foreach(Articulo art in listaArt)
            {
                if (art.IdArticulo == actual.IdArticulo)
                { 
                    if (art.Cantidad + actual.Cantidad > art.Maximo)
                    {
                        MessageBox.Show("La cantidad exede el limite maximo de este articulo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        art.Cantidad = art.Cantidad + actual.Cantidad;
                        articulo = art;
                        repArticulo.Guardar(art);
                    }
                       
                }
                  
            }
            actual.Total = articulo.PrecioCompra * actual.Cantidad;

            Repositorio.Guardar(actual);
            Editando = false;
            CompraBindingSource1.DataSource = new Compra();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.Cantidad = null;
            Filtro.IdArticulo = null;
            Filtro.IdCompra = null;
            Filtro.IdDetalleCompra = null;
            Editando = false;
            CompraBindingSource1.DataSource = new Compra();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.Cantidad = null;
            Filtro.IdArticulo = null;
            Filtro.IdCompra = null;
            Filtro.IdDetalleCompra = null;
            if (MessageBox.Show("Esta seguro que desea eliminar esta Compra?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Compra actual = CompraBindingSource1.DataSource as Compra;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("compra en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }

        private void grvCompra_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void CompraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Compra actual = CompraBindingSource.Current as Compra;
            if (Editando)
            {
                HabilitarControles(false, false);
                CompraBindingSource1.DataSource = actual;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Compra actual = CompraBindingSource1.DataSource as Compra;
            if(nudCantidad.Value != 0)
                Filtro.Cantidad = (int)nudCantidad.Value;
            
            if (actual.IdCompra != 0)
            {
                Filtro.IdCompra = actual.IdCompra;
            }
            else
            {
                Filtro.IdCompra = null;
            }
            if (actual.IdDetalleCompra != 0)
            {
                Filtro.IdDetalleCompra = actual.IdDetalleCompra;
            }
            else
            {
                Filtro.IdDetalleCompra = null;
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
            Compra actual = CompraBindingSource.Current as Compra;
            Editando = actual != null;
            if (Editando)
            {
                HabilitarControles(false, false);
                CompraBindingSource1.DataSource = actual;
                var Articulo = repArticulo.Listar(new FiltroArticulo() { IdArticulo = actual.IdArticulo }, out _).FirstOrDefault();
                if (Articulo != null)
                {
                    List<Articulo> tm = ArticuloBindingSource.DataSource as List<Articulo>;
                    if (Articulo != null)
                    {
                        cbArticulo.SelectedItem = tm.FirstOrDefault(x => x.IdArticulo == Articulo.IdArticulo);
                    }
                }
                var IdDetalleCompra = repDetalleCompra.Listar(new FiltroDetalleCompra() { IdDetalleCompra = actual.IdDetalleCompra }, out _).FirstOrDefault();
                if (IdDetalleCompra != null)
                {
                    List<DetalleCompra> detalleCompras = DetalleCompraBindingSource.DataSource as List<DetalleCompra>;
                    if (IdDetalleCompra != null)
                    {
                        cbIdDetalleCompra.SelectedItem = detalleCompras.FirstOrDefault(x => x.IdDetalleCompra == IdDetalleCompra.IdDetalleCompra);
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
                for (int i = 0; i < grvCompra.Columns.Count; i++)
                {
                    var columna = grvCompra.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }
        private void grvCompra_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = grvCompra.Columns[e.ColumnIndex];
            string nombrecampo = columna.DataPropertyName;
            if (!string.IsNullOrWhiteSpace(nombrecampo) && nombrecampo != nameof(Compra.IdDetalleCompra))
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
