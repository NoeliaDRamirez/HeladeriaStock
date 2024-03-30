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
    public partial class frmPedido : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroPedido Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroPedido();
        private Repositorio<Pedido> Repositorio = new Repositorio<Pedido>(new PedidoIdentificador());
        private Repositorio<Articulo> repArticulo = new Repositorio<Articulo>(new ArticuloIdentificador());
        private Repositorio<Repartidor> repRepartidor = new Repositorio<Repartidor>(new RepartidorIdentificador());
        private Repositorio<Usuario> repUsuario = new Repositorio<Usuario>(new UsuarioIdentificador());
        private Repositorio<AreaEnvio> repAreaEnvio = new Repositorio<AreaEnvio>(new AreaEnvioIdentificador());
        private Repositorio<TipoPago> repTipoPago = new Repositorio<TipoPago>(new TipoPagoIdentificador());

        private bool Editando = false;

        List<Articulo> listaArt = new List<Articulo>();

        List<AreaEnvio> listaAreaEnvio = new List<AreaEnvio>();
        public frmPedido()
        {
            InitializeComponent();
        }

        private void ActualizaGrilla()
        {
            PedidoBindingSource.DataSource = null;
            PedidoBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
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
        private void CargarRepartidor()
        {
            List<Repartidor> detalles = new List<Repartidor>();
            detalles.AddRange(repRepartidor.Listar(new FiltroRepartidor(), out _));
            RepartidorBindingSource.DataSource = detalles;
        }
        private void CargarUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.AddRange(repUsuario.Listar(new FiltroUsuario(), out _));
            UsuarioBindingSource.DataSource = usuarios;
        }
        private List<AreaEnvio> CargarAreaEnvio()
        {
            List<AreaEnvio> areas = new List<AreaEnvio>();
            areas.AddRange(repAreaEnvio.Listar(new FiltroAreaEnvio(), out _));
            AreaEnvioBindingSource.DataSource = areas;
            return areas;
        }
        private void CargarTipoPago()
        {
            List<TipoPago> pagos = new List<TipoPago>();
            pagos.AddRange(repTipoPago.Listar(new FiltroTipoPago(), out _));
            TipoPagoBindingSource.DataSource = pagos;
        }
        private void frmPedido_Load(object sender, EventArgs e)
        {
            PaletaColores(grvPedido);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            PedidoBindingSource1.DataSource = new Pedido();
            Editando = false;
            HabilitarControles(true);
            CargarUsuarios();
            CargarTipoPago();
            listaAreaEnvio = CargarAreaEnvio();
            listaArt = CargarArticulos();
            CargarRepartidor();
        }

        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de Pedidos";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos del nuevo Pedido";
                }
                else
                {
                    pnlFiltro.Text = "Datos del Pedido";
                }
            }
            //lblIdRepartidor.Visible = !filtro;
            //cbIdRepartidor.Visible = !filtro;
            //lblTPedido.Visible = !filtro;
            //cbArticulo.Visible = !filtro;
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtPedido.Enabled = filtro;
            btnEliminar.Visible = !filtro && !nuevo;
            btnGuardar.Visible = !filtro;

        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            PedidoBindingSource1.DataSource = new Pedido();
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
                cbRepartidor.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen repartidores", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            try
            {
                cbUsuario.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen usuarios", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            try
            {
                cbTipoPago.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen tipos de pagos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            try
            {
                cbAreaEnvio.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No existen areas de envio", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.Cantidad = null;
            Filtro.IdArticulo = null;
            Filtro.IdPedido = null;
            Filtro.IdRepartidor = null;
            Filtro.IdTipoPago = null;
            Filtro.IdUsuario = null;
            Filtro.IdAreaEnvio = null;
            
            Pedido actual = PedidoBindingSource1.DataSource as Pedido;
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
            if (actual.IdRepartidor == 0)
            {
                MessageBox.Show("El repartidor es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.IdArticulo == 0)
            {
                MessageBox.Show("El articulo es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.IdAreaEnvio == 0)
            {
                MessageBox.Show("El area de envio es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.IdTipoPago == 0)
            {
                MessageBox.Show("El tipo de pago es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.IdUsuario == 0)
            {
                MessageBox.Show("El usuario es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(actual.Destino))
            {
                MessageBox.Show("El destino es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Articulo articulo = new Articulo();
            foreach(Articulo art in listaArt)
            {
                if (art.IdArticulo == actual.IdArticulo)
                { 
                    if (art.Cantidad - actual.Cantidad < art.Minimo)
                    {
                        MessageBox.Show("La cantidad exede el limite minimo de este articulo", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        AreaEnvio area = new AreaEnvio();
                        foreach(AreaEnvio ar in listaAreaEnvio)
                        {
                            if(actual.IdAreaEnvio == ar.IdAreaEnvio)
                                area = ar;
                        }
                        art.Cantidad = art.Cantidad - actual.Cantidad;
                        articulo = art;
                        actual.Total = (actual.Cantidad * art.PrecioVenta) + area.Precio;
                        repArticulo.Guardar(art);
                    }
                       
                }           
            }

            actual.Fecha = DateTime.Now;
            Repositorio.Guardar(actual);
            Editando = false;
            PedidoBindingSource1.DataSource = new Pedido();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.Cantidad = null;
            Filtro.IdArticulo = null;
            Filtro.IdPedido = null;
            Filtro.IdRepartidor = null;
            Filtro.IdTipoPago = null;
            Filtro.IdUsuario = null;
            Filtro.IdAreaEnvio = null;
            Editando = false;
            PedidoBindingSource1.DataSource = new Pedido();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.Cantidad = null;
            Filtro.IdArticulo = null;
            Filtro.IdPedido = null;
            Filtro.IdRepartidor = null;
            Filtro.IdTipoPago = null;
            Filtro.IdUsuario = null;
            Filtro.IdAreaEnvio = null;
            if (MessageBox.Show("Esta seguro que desea eliminar esta Pedido?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Pedido actual = PedidoBindingSource1.DataSource as Pedido;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("Pedido en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }

        private void grvPedido_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void PedidoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Pedido actual = PedidoBindingSource.Current as Pedido;
            if (Editando)
            {
                HabilitarControles(false, false);
                PedidoBindingSource1.DataSource = actual;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Pedido actual = PedidoBindingSource1.DataSource as Pedido;        
            if (actual.IdPedido != 0)
            {
                Filtro.IdPedido = actual.IdPedido;
            }
            else
            {
                Filtro.IdPedido = null;
            }
            if (actual.IdRepartidor != 0)
            {
                Filtro.IdRepartidor = actual.IdRepartidor;
            }
            else
            {
                Filtro.IdRepartidor = null;
            }
            if (actual.IdArticulo != 0)
            {
                Filtro.IdArticulo = actual.IdArticulo;
            }
            else
            {
                Filtro.IdArticulo = null;
            }
            if (actual.IdAreaEnvio != 0)
            {
                Filtro.IdAreaEnvio = actual.IdAreaEnvio;
            }
            else
            {
                Filtro.IdAreaEnvio = null;
            }
            if (actual.IdTipoPago != 0)
            {
                Filtro.IdTipoPago = actual.IdTipoPago;
            }
            else
            {
                Filtro.IdTipoPago = null;
            }
            if (actual.IdUsuario != 0)
            {
                Filtro.IdUsuario = actual.IdUsuario;
            }
            else
            {
                Filtro.IdUsuario = null;
            }
            if (actual.Leido == false)
            {
                Filtro.Leido = actual.Leido;
            }
            else
            {
                Filtro.Leido = null;
            }
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            Pedido actual = PedidoBindingSource.Current as Pedido;
            
            Editando = actual != null;
            if (Editando)
            {
                HabilitarControles(false, false);
                PedidoBindingSource1.DataSource = actual;
                var Articulo = repArticulo.Listar(new FiltroArticulo() { IdArticulo = actual.IdArticulo }, out _).FirstOrDefault();
                if (Articulo != null)
                {
                    List<Articulo> tm = ArticuloBindingSource.DataSource as List<Articulo>;
                    if (Articulo != null)
                    {
                        cbArticulo.SelectedItem = tm.FirstOrDefault(x => x.IdArticulo == Articulo.IdArticulo);
                    }
                }
                var IdRepartidor = repRepartidor.Listar(new FiltroRepartidor() { IdRepartidor = actual.IdRepartidor }, out _).FirstOrDefault();
                if (IdRepartidor != null)
                {
                    List<Repartidor> Repartidors = RepartidorBindingSource.DataSource as List<Repartidor>;
                    if (IdRepartidor != null)
                    {
                        cbRepartidor.SelectedItem = Repartidors.FirstOrDefault(x => x.IdRepartidor == IdRepartidor.IdRepartidor);
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
                for (int i = 0; i < grvPedido.Columns.Count; i++)
                {
                    var columna = grvPedido.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }
        private void grvPedido_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = grvPedido.Columns[e.ColumnIndex];
            string nombrecampo = columna.DataPropertyName;
            if (!string.IsNullOrWhiteSpace(nombrecampo) && nombrecampo != nameof(Pedido.IdRepartidor))
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
