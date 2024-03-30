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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Heladeria.Formularios
{
    public partial class frmInformeMayorGanacia : Form
    {
        int cantidad = 0;
        DateTime fecha = DateTime.Parse(DateTime.Today.ToString().Substring(0, 10) + " 00:00:00");
        DateTime fecha1 = DateTime.Parse(DateTime.Today.ToString().Substring(0, 10) + " 23:59:59");
        Heladeria.Data.EntityFramework.Filtros.FiltroInformeMayorGanacia Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroInformeMayorGanacia();
        private Repositorio<InformeMayorGanancia> Repositorio = new Repositorio<InformeMayorGanancia>(new InformeMayorGananciaIdentificador());
        public frmInformeMayorGanacia()
        {
            InitializeComponent();
        }
        private void ActualizaGrilla()
        {
            InformeMayorGananciaBindingSource.DataSource = null;
            InformeMayorGananciaBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
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
        private void frmInformeMayorGancia_Load(object sender, EventArgs e)
        {
            PaletaColores(dgvInformeMayorGanancia);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            InformeMayorGananciaBindingSource1.DataSource = new InformeMayorGanancia();
        }
        private Repositorio<Venta> repVenta = new Repositorio<Venta>(new VentaIdentificador());
        private Repositorio<Articulo> repArticulo = new Repositorio<Articulo>(new ArticuloIdentificador());
        private Repositorio<DetalleVenta> repDetalleVenta = new Repositorio<DetalleVenta>(new DetalleVentaIdentificador());
        private Repositorio<Pedido> repPedido = new Repositorio<Pedido>(new PedidoIdentificador());
        private List<Venta> CargarVentas()
        {
            List<Venta> ventas = new List<Venta>();
            ventas.AddRange(repVenta.Listar(new FiltroVenta(), out _));
            return ventas;
        }
        private List<Pedido> CargarPedidos()
        {
            List<Pedido> ventas = new List<Pedido>();
            ventas.AddRange(repPedido.Listar(new FiltroPedido(), out _));
            return ventas;
        }
        private List<DetalleVenta> CargarDetalles()
        {
            List<DetalleVenta> DetalleVentas = new List<DetalleVenta>();
            DetalleVentas.AddRange(repDetalleVenta.Listar(new FiltroDetalleVenta(), out _));
            return DetalleVentas;
        }
        private List<Articulo> CargarArticulos()
        {
            List<Articulo> articulos = new List<Articulo>();
            articulos.AddRange(repArticulo.Listar(new FiltroArticulo(), out _));
            return articulos;
        }
        private List<Venta> FiltrarVentas(List<Venta> ventas)
        {
            List<Venta> ventasFiltradas = new List<Venta>();
            foreach (Venta venta in ventas)
            {
                if (venta.Fecha >= fecha && venta.Fecha <= fecha1)
                {
                    ventasFiltradas.Add(venta);
                }
            }
            return ventasFiltradas;
        }
        private List<Pedido> FiltrarPedido(List<Pedido> ventas)
        {
            List<Pedido> ventasFiltradas = new List<Pedido>();
            foreach (Pedido venta in ventas)
            {
                if(venta.Fecha >= fecha && venta.Fecha <= fecha1)
                {
                    ventasFiltradas.Add(venta);
                    cantidad += venta.Cantidad;
                }
            }
            return ventasFiltradas;
        }


        private List<DetalleVenta> FiltrarDetalleVenta(List<Venta> ventas, List<DetalleVenta> detalles)
        {
            List<DetalleVenta> detallesFiltrados = new List<DetalleVenta>();
            foreach (Venta venta in ventas)
            {
                foreach (DetalleVenta detal in detalles)
                {
                    if (venta.IdDetalle == detal.IdDetalleVenta)
                    {
                        detallesFiltrados.Add(detal);
                        cantidad += detal.Cantidad;
                    }
                }
            }
            return detallesFiltrados;
        }
        private Dictionary<int, decimal> FiltrarArticulos(List<DetalleVenta> detalles , List<Pedido> p)
        {
            Dictionary<int, decimal> idMonto = new Dictionary<int, decimal>();
            foreach (DetalleVenta detal in detalles)
            {
                int id = detal.IdArticulo;
                decimal monto = detal.PrecioUnitario;
                try
                {
                    idMonto.Add(id, monto* detal.Cantidad);
                }
                catch (System.ArgumentException)
                {
                    idMonto[id] += detal.PrecioUnitario * detal.Cantidad;
                }
            }
            
            foreach (Pedido detal in p)
            {
                decimal monto = 0.0M; 
                int id = detal.IdArticulo;
                foreach( Articulo a in CargarArticulos()){
                    if(a.IdArticulo == id)
                        monto = a.PrecioVenta;
                }  
                try
                {
                    idMonto.Add(id, monto * detal.Cantidad);
                }
                catch (System.ArgumentException)
                {
                    idMonto[id] += monto * detal.Cantidad;
                }
            }
            return idMonto;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            cantidad = 0;
            lblTitulo.Visible = true;
            fecha = dtpFecha.Value;
            fecha1 = dtpFecha1.Value;
            fecha = DateTime.Parse(fecha.ToString().Substring(0, 10) + " 00:00:00");
            fecha1 = DateTime.Parse(fecha1.ToString().Substring(0, 10) + " 23:59:59");
            InformeMayorGananciaBindingSource1.DataSource = new InformeMayorGanancia();
            var Lista = FiltrarArticulos(FiltrarDetalleVenta(FiltrarVentas(CargarVentas()), CargarDetalles()), FiltrarPedido(CargarPedidos())).ToList();

            Lista.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            List<Articulo> articulos = CargarArticulos();
            string nombre = "";
            try
            {
                int id = Lista[Lista.Count - 1].Key;
                foreach (Articulo art in articulos)
                {
                    if (art.IdArticulo == id)
                    {
                        nombre = art.Nombre;
                        break;
                    }
                }

                lblTitulo.Text = "Articulo que con mayor ganancia desde el " + fecha.ToString() + " hasta " + fecha1.ToString();
                txtNombre.Text = nombre;
                txtMonto.Text = Lista[Lista.Count - 1].Value.ToString();
                txtCantidad.Text = cantidad.ToString();
            }
            catch
            {
                lblTitulo.Text = "No hay articulos vendidos desde el " + fecha.ToString() + " hasta " + fecha1.ToString();
            }

            ActualizaGrilla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InformeMayorGanancia actual = new InformeMayorGanancia();
            actual.Monto = decimal.Parse(txtMonto.Text);
            actual.Cantidad = cantidad;
            actual.Desde = fecha;
            actual.Hasta = fecha1;
            actual.Nombre = txtNombre.Text;
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
            if (actual.Monto == 0)
            {
                MessageBox.Show("El monto es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Repositorio.Guardar(actual);
            InformeMayorGananciaBindingSource1.DataSource = new InformeMayorGanancia();
            ActualizaGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este Informe?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InformeMayorGanancia actual = new InformeMayorGanancia();
                actual.Id = int.Parse(txtId.Text);
                actual.Nombre = txtNombre.Text;
                actual.Monto = decimal.Parse(txtMonto.Text);
                actual.Desde = fecha;
                actual.Hasta = fecha1;
                actual.Cantidad = int.Parse(txtCantidad.Text);
                Repositorio.Eliminar(actual);
                ActualizaGrilla();
            }
        }

        private void InformeMayorGananciaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            InformeMayorGanancia actual = InformeMayorGananciaBindingSource.Current as InformeMayorGanancia;

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
                for (int i = 0; i < dgvInformeMayorGanancia.Columns.Count; i++)
                {
                    var columna = dgvInformeMayorGanancia.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }

        private void dgvInformeMayorGanancia_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = dgvInformeMayorGanancia.Columns[e.ColumnIndex];
            string nombrecampo = columna.DataPropertyName;
            if (!string.IsNullOrWhiteSpace(nombrecampo))
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            InformeMayorGananciaBindingSource1.DataSource = new InformeMayorGanancia();
            ActualizaGrilla();
        }

        private void dgvInformeMayorGanancia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvInformeMayorGanancia.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = Convert.ToString(dgvInformeMayorGanancia.CurrentRow.Cells[1].Value);
            txtCantidad.Text = Convert.ToString(dgvInformeMayorGanancia.CurrentRow.Cells[2].Value);
            txtMonto.Text = Convert.ToString(dgvInformeMayorGanancia.CurrentRow.Cells[3].Value);
            fecha = (DateTime)dgvInformeMayorGanancia.CurrentRow.Cells[4].Value;
            fecha1 = (DateTime)dgvInformeMayorGanancia.CurrentRow.Cells[5].Value;
        }

        private void nupTamanioPagina_ValueChanged(object sender, EventArgs e)
        {
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
        }

        private void nupPagina_ValueChanged(object sender, EventArgs e)
        {
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgvInformeMayorGanancia.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";

                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Error de guardado" + ex.Message);
                        }
                    }

                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgvInformeMayorGanancia.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvInformeMayorGanancia.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvInformeMayorGanancia.Rows)
                            {
                                foreach (DataGridViewCell dcell in viewRow.Cells)
                                {
                                    pTable.AddCell(dcell.Value.ToString());
                                }
                            }
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                DateTime fechax = DateTime.Now;
                                document.Open();
                                document.Add(new Paragraph("Informe de productos con mayor monto de ganancias por periodos"));
                                document.Add(new Paragraph("Documento generado el " + fechax.ToString("dd/MM/yyyy")));
                                document.Add(new Paragraph(" "));
                                //document.Add(Chunk.NEWLINE);
                                document.Add(pTable);
                                document.Close();

                                fileStream.Close();
                            }
                            MessageBox.Show("PDF guardado", "info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No encontrado", "Info");
            }

        }
    }


}
