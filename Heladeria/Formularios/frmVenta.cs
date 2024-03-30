using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Heladeria.Data.EntityFramework;
using Heladeria.Data.EntityFramework.Filtros;
using Heladeria.Data.EntityFramework.Entidades;

namespace Heladeria.Formularios
{
    public partial class frmVenta : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroVenta Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroVenta();
        private Repositorio<Venta> Repositorio = new Repositorio<Venta>(new VentaIdentificador());
        private Repositorio<DetalleVenta> repDetalleVenta = new Repositorio<DetalleVenta>(new DetalleVentaIdentificador());
        private Repositorio<Cliente> repCliente = new Repositorio<Cliente>(new ClienteIdentificador());
        private Repositorio<Repartidor> repRepartidor = new Repositorio<Repartidor>(new RepartidorIdentificador());
        private Repositorio<TipoPago> repTipoPago = new Repositorio<TipoPago>(new TipoPagoIdentificador());

        private Repositorio<Articulo> repArticulo = new Repositorio<Articulo>(new ArticuloIdentificador());

        List<Articulo> listaArt = new List<Articulo>();
        List<DetalleVenta> listaDet = new List<DetalleVenta>();

        private bool Editando = false;
        public frmVenta()
        {
            InitializeComponent();
        }

        private void ActualizaGrilla()
        {
            VentaBindingSource.DataSource = null;
            VentaBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
        }
        private void CargarClientes()
        {
            List<Cliente> Clientes = new List<Cliente>();
            Clientes.AddRange(repCliente.Listar(new FiltroCliente(), out _));
            ClienteBindingSource.DataSource = Clientes;
        }
        private List<Articulo> CargarArticulos()
        {
            List<Articulo> Articulos = new List<Articulo>();
            Articulos.AddRange(repArticulo.Listar(new FiltroArticulo(), out _));
            return Articulos;
        }
        private List<DetalleVenta> CargarDetalleVenta()
        {
            List<DetalleVenta> detalles = new List<DetalleVenta>();
            detalles.AddRange(repDetalleVenta.Listar(new FiltroDetalleVenta(), out _));
            DetalleVentaBindingSource.DataSource = detalles;
            return detalles;
        }
        private void CargarRepartidors()
        {
            List<Repartidor> Repartidors = new List<Repartidor>();
            Repartidors.AddRange(repRepartidor.Listar(new FiltroRepartidor(), out _));
            RepartidorBindingSource.DataSource = Repartidors;
        }
        private void CargarTipoPagos()
        {
            List<TipoPago> TipoPagos = new List<TipoPago>();
            TipoPagos.AddRange(repTipoPago.Listar(new FiltroTipoPago(), out _));
            TipoPagoBindingSource.DataSource = TipoPagos;
        }
        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de Ventas";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos de la nueva Venta";
                }
                else
                {
                    pnlFiltro.Text = "Datos de la Venta";
                }
            }
           // lblIdDetalle.Visible = !filtro;
           // cbIdDetalleVenta.Visible = !filtro;
            //lblCliente.Visible = !filtro;
            //lblRepartidor.Visible = !filtro;
           // lblTipo.Visible = !filtro;
            //cbTipoPago.Visible = !filtro;
           // cbRepartidor.Visible = !filtro;
            //cbCliente.Visible = !filtro;
            //cbIdDetalleVenta.Visible = !filtro;
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtVenta.Enabled = filtro;
            //txtCliente.Enabled = filtro;
            //txtDetalle.Enabled = filtro;
            //txtPago.Enabled = filtro;
            //txtRepartidor.Enabled = filtro;
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

        private void frmVenta_Load(object sender, EventArgs e)
        {
            PaletaColores(grvVenta);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            VentaBindingSource1.DataSource = new Venta();
            Editando = false;
            HabilitarControles(true);
            CargarClientes();
            CargarRepartidors();
            CargarTipoPagos();
            listaDet = CargarDetalleVenta();
            listaArt = CargarArticulos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            VentaBindingSource1.DataSource = new Venta();
            Editando = true;
            HabilitarControles(false, true);
            try
            {
                cbCliente.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen clientes", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            try
            {
                cbCliente.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen Clientes", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            try
            {
                cbTipoPago.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen TipoPagos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            try
            {
                cbIdDetalleVenta.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen Detalles de Ventas", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.IdTipoPago = null;
            Filtro.IdCliente = null;
            Filtro.IdVenta = null;
           // Filtro.IdRepartidor = null;
            Filtro.IdDetalle = null;
            Venta actual = VentaBindingSource1.DataSource as Venta;
            DateTime fecha = DateTime.Today;
            actual.Fecha = fecha;
            if (actual == null)
            {
                MessageBox.Show("No se esta editando una entidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.IdTipoPago == 0)
            {
                MessageBox.Show("El tipo de pago es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.IdDetalle == 0)
            {
                MessageBox.Show("El Detalle de Venta es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           /* if ((actual.IdRepartidor == 0))
            {
                MessageBox.Show("El repartidor es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/
            if ((actual.IdCliente == 0))
            {
                MessageBox.Show("El cliente es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DetalleVenta det = new DetalleVenta();
            foreach(DetalleVenta detalle in listaDet)
            {
                if(detalle.IdDetalleVenta == actual.IdDetalle)
                {
                    det = detalle;
                }
            }
            Articulo articulo = new Articulo();
            foreach(Articulo art in listaArt)
            {
                if(art.IdArticulo == det.IdArticulo)
                {
                    articulo = art;
                }
            }
            if(articulo.Cantidad - det.Cantidad < articulo.Minimo)
            {
                MessageBox.Show("La venta exede el limite minimo de este articulo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
            actual.Total = det.Cantidad * det.PrecioUnitario;
            cbTotal.Text = Convert.ToString(actual.Total);
            articulo.Cantidad -= det.Cantidad;
            repArticulo.Guardar(articulo);
            Repositorio.Guardar(actual);
            Editando = false;
            VentaBindingSource1.DataSource = new Venta();
            
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.IdTipoPago = null;
            Filtro.IdCliente = null;
            Filtro.IdVenta = null;
           // Filtro.IdRepartidor = null;
            Filtro.IdDetalle = null;
            Editando = false;
            VentaBindingSource1.DataSource = new Venta();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.IdTipoPago = null;
            Filtro.IdCliente = null;
            Filtro.IdVenta = null;
           // Filtro.IdRepartidor = null;
            Filtro.IdDetalle = null;
            if (MessageBox.Show("Esta seguro que desea eliminar esta Venta?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Venta actual = VentaBindingSource1.DataSource as Venta;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("venta en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }


        private void VentaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Venta actual = VentaBindingSource.Current as Venta;
            if (Editando)
            {
                HabilitarControles(false, false);
                VentaBindingSource1.DataSource = actual;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Venta actual = VentaBindingSource1.DataSource as Venta;
            if (actual.IdVenta != 0)
            {
                Filtro.IdVenta = actual.IdVenta;
            }
            else
            {
                Filtro.IdVenta = null;
            }
            if (actual.IdCliente != 0)
            {
                Filtro.IdCliente = actual.IdCliente;
            }
            else
            {
                Filtro.IdCliente = null;
            }
           /* if (actual.IdRepartidor != 0)
            {
                Filtro.IdRepartidor = actual.IdRepartidor;
            }
            else
            {
                Filtro.IdRepartidor = null;
            }*/
            if (actual.IdTipoPago != 0)
            {
                Filtro.IdTipoPago = actual.IdTipoPago;
            }
            else
            {
                Filtro.IdTipoPago = null;
            }
            if (actual.IdDetalle != 0)
            {
                Filtro.IdDetalle = actual.IdDetalle;
            }
            else
            {
                Filtro.IdDetalle = null;
            }
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Venta actual = VentaBindingSource.Current as Venta;
            Editando = actual != null;
            if (Editando)
            {
                HabilitarControles(false, false);
                VentaBindingSource1.DataSource = actual;
                var Cliente = repCliente.Listar(new FiltroCliente() { IdCliente = actual.IdCliente }, out _).FirstOrDefault();
                if (Cliente != null)
                {
                    List<Cliente> tm = ClienteBindingSource.DataSource as List<Cliente>;
                    if (Cliente != null)
                    {
                        cbCliente.SelectedItem = tm.FirstOrDefault(x => x.IdCliente == Cliente.IdCliente);
                    }
                }
                var TipoPago = repTipoPago.Listar(new FiltroTipoPago() { IdTipoPago = actual.IdTipoPago }, out _).FirstOrDefault();

                if (TipoPago != null)
                {
                    List<TipoPago> tm = TipoPagoBindingSource.DataSource as List<TipoPago>;
                    if (TipoPago != null)
                    {
                        cbTipoPago.SelectedItem = tm.FirstOrDefault(x => x.IdTipoPago == TipoPago.IdTipoPago);
                    }
                }
               // var Repartidor = repRepartidor.Listar(new FiltroRepartidor() { IdRepartidor = actual.IdRepartidor }, out _).FirstOrDefault();

               /* if (Repartidor != null)
                {
                    List<Repartidor> tm = RepartidorBindingSource.DataSource as List<Repartidor>;
                    if (Repartidor != null)
                    {
                        cbRepartidor.SelectedItem = tm.FirstOrDefault(x => x.IdRepartidor == Repartidor.IdRepartidor);
                    }
                }*/
                var IdDetalleVenta = repDetalleVenta.Listar(new FiltroDetalleVenta() { IdDetalleVenta = actual.IdDetalle }, out _).FirstOrDefault();
                if (IdDetalleVenta != null)
                {
                    List<DetalleVenta> detalleVentas = DetalleVentaBindingSource.DataSource as List<DetalleVenta>;
                    if (IdDetalleVenta != null)
                    {
                        cbIdDetalleVenta.SelectedItem = detalleVentas.FirstOrDefault(x => x.IdDetalleVenta == IdDetalleVenta.IdDetalleVenta);
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
                for (int i = 0; i < grvVenta.Columns.Count; i++)
                {
                    var columna = grvVenta.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }

        private void grvVenta_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = grvVenta.Columns[e.ColumnIndex];
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
    }

}
