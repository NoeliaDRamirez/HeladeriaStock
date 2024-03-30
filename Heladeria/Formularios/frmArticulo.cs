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
using System.IO;
using System.Data.Entity.Infrastructure;

namespace Heladeria
{
    public partial class frmArticulo : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroArticulo Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroArticulo();
        private Repositorio<Articulo> Repositorio = new Repositorio<Articulo>(new ArticuloIdentificador());
        private Repositorio<Categoria> repCategoria = new Repositorio<Categoria>(new CategoriaIdentificador());
        private Repositorio<Proveedor> repProveedor = new Repositorio<Proveedor>(new ProveedorIdentificador());
        private bool Editando = false;

        private string imagen;

        public frmArticulo()
        {
            InitializeComponent();
        }

        private void ActualizaGrilla()
        {
            ArticuloBindingSource.DataSource = null;
            ArticuloBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
            pbImagen.Image = null;
        }
        private void CargarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias.AddRange(repCategoria.Listar(new FiltroCategoria(), out _));
            CategoriaBindingSource.DataSource = categorias;
        }
        private void CargarProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            proveedores.AddRange(repProveedor.Listar(new FiltroProveedor(), out _));
            ProveedorBindingSource.DataSource = proveedores;
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            PaletaColores(grvArticulo);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            ArticuloBindingSource1.DataSource = new Articulo();
            Editando = false;
            HabilitarControles(true);
            CargarCategorias();
            CargarProveedores();
        }

        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de Articulos";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos del nuevo Articulo";
                }
                else
                {
                    pnlFiltro.Text = "Datos del Articulo";
                }
            }
            //lblTArticulo.Visible = !filtro;
            //cbCategoria.Visible = !filtro;
            //cbProveedor.Visible = !filtro;
            //lblProveedor.Visible = !filtro;
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtArticulo.Enabled = filtro;
            txtIDCategoria.Enabled = filtro;
            txtIdProveedor.Enabled = filtro;
            btnEliminar.Visible = !filtro && !nuevo;
            btnGuardar.Visible = !filtro;
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Filtro.Nombre = null;
            Filtro.Cantidad = null;
            Filtro.Codigo = null;
            Filtro.IdArticulo = null;
            Editando = false;
            ArticuloBindingSource1.DataSource = new Articulo();
            Editando = true;
            HabilitarControles(false, true);
            try
            {
                cbCategoria.SelectedIndex = 0;
                cbProveedor.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen tipos de categorias o proveedores", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.Nombre = null;
            Filtro.Cantidad = null;
            Filtro.Codigo = null;
            Filtro.IdArticulo = null;
            Articulo actual = ArticuloBindingSource1.DataSource as Articulo;
            if (actual == null)
            {
                MessageBox.Show("No se esta editando una entidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                actual.Cantidad = int.Parse(txtCantidad.Text);
                actual.PrecioVenta = int.Parse(txtPVenta.Text);
                actual.PrecioCompra = int.Parse(txtPCompra.Text);
                actual.Maximo = int.Parse(txtMaximo.Text);
                actual.Minimo = int.Parse(txtMinimo.Text);
            }
            catch
            {
               // MessageBox.Show("los precios, el minimo y el maximo deben ser valores numericos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            if (actual.IDCategoria == 0)
            {
                MessageBox.Show("La categoria es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.IdProveedor == 0)
            {
                MessageBox.Show("El provedor es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.Minimo == 0)
            {
                MessageBox.Show("El minimo es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.Maximo == 0)
            {
                MessageBox.Show("El maximo es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.PrecioVenta == 0)
            {
                MessageBox.Show("El precio de venta es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.PrecioCompra == 0)
            {
                MessageBox.Show("El precio de compra es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool nuevo = actual.IdArticulo == 0;
            if (nuevo)
                actual.Cantidad = 0;
            byte[] im = null;
            try
            {
                Stream stream = openFileDialog1.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    im = ms.ToArray();
                }

                actual.Imagen = im;
            }
            catch
            {

            }
            try
            {
                Repositorio.Guardar(actual);
            }
            catch
            {
                MessageBox.Show("codigo repetido", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Editando = false;
            ArticuloBindingSource1.DataSource = new Articulo();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.Nombre = null;
            Filtro.Cantidad = null;
            Filtro.Codigo = null;
            Filtro.IdArticulo = null;
            Editando = false;
            ArticuloBindingSource1.DataSource = new Articulo();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.Nombre = null;
            Filtro.Cantidad = null;
            Filtro.Codigo = null;
            Filtro.IdArticulo = null;
            if (MessageBox.Show("Esta seguro que desea eliminar este Articulo?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Articulo actual = ArticuloBindingSource1.DataSource as Articulo;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("articulo en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }

        private void grvArticulo_SelectionChanged(object sender, EventArgs e)
        {

        }
        private void ArticuloBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Articulo actual = ArticuloBindingSource.Current as Articulo;
            if (Editando)
            {
                HabilitarControles(false, false);
               
                ArticuloBindingSource1.DataSource = actual;
                pbImagen.Image = null;
                if (actual.Imagen != null)
                {
                    int id = actual.IdArticulo;
                  
                    using (Heladeria.Data.EntityFramework.HeladeriaEntities bd = new Heladeria.Data.EntityFramework.HeladeriaEntities())
                    {
                        var oImagen = bd.Articulo.Find(id);
                        MemoryStream ms = new MemoryStream(oImagen.Imagen);
                        Bitmap bmp = new Bitmap(ms);
                        pbImagen.Image = bmp;
                    }
                }     
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Articulo actual = ArticuloBindingSource1.DataSource as Articulo;

            Filtro.Codigo = actual.Codigo;

            Filtro.Nombre = actual.Nombre;
            if (actual.IdArticulo != 0)
            {
                Filtro.IdArticulo = actual.IdArticulo;
            }
            else
            {
                Filtro.IdArticulo = null;
            }
            if (actual.IDCategoria != 0)
            {
                Filtro.IDCategoria = actual.IDCategoria;
            }
            else
            {
                Filtro.IDCategoria = null;
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
            Articulo actual = ArticuloBindingSource.Current as Articulo;
            Editando = actual != null;
            if (Editando)
            {
                HabilitarControles(false, false);
                ArticuloBindingSource1.DataSource = actual;
                pbImagen.Image = null;
                if (actual.Imagen != null)
                {
                    int id = actual.IdArticulo;

                    using (Heladeria.Data.EntityFramework.HeladeriaEntities bd = new Heladeria.Data.EntityFramework.HeladeriaEntities())
                    {
                        var oImagen = bd.Articulo.Find(id);
                        MemoryStream ms = new MemoryStream(oImagen.Imagen);
                        Bitmap bmp = new Bitmap(ms);
                        pbImagen.Image = bmp;
                    }
                }
                var Categoria = repCategoria.Listar(new FiltroCategoria() { IdCategoria = actual.IDCategoria }, out _).FirstOrDefault();
                var Proveedor = repProveedor.Listar(new FiltroProveedor() { IdProveedor = actual.IdProveedor }, out _).FirstOrDefault();
                if (Categoria != null)
                {
                    List<Categoria> tm = CategoriaBindingSource.DataSource as List<Categoria>;
                    if (Categoria != null)
                    {
                        cbCategoria.SelectedItem = tm.FirstOrDefault(x => x.IdCategoria == Categoria.IdCategoria);
                    }
                }
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
                for (int i = 0; i < grvArticulo.Columns.Count; i++)
                {
                    var columna = grvArticulo.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }
        private void grvArticulo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = grvArticulo.Columns[e.ColumnIndex];
            string nombrecampo = columna.DataPropertyName;
            if (!string.IsNullOrWhiteSpace(nombrecampo) && nombrecampo != nameof(Articulo.Codigo))
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

        private void btnImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Imagenes | *.JPG;*.PNG; *.JPEG";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagen = openFileDialog1.FileName;
                pbImagen.Image = Image.FromFile(imagen);
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == ('.')))
            {
                MessageBox.Show("Debe ingresar un valor numerico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == ('.')))
            {
                MessageBox.Show("Debe ingresar un valor numerico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == ('.')))
            {
                MessageBox.Show("Debe ingresar un valor numerico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtPCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == (',')))
            {
                MessageBox.Show("Debe ingresar un valor numerico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtPVenta_KeyPress(object sender, KeyPressEventArgs e)
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
