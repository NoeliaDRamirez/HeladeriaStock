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
using System.Threading;

namespace Heladeria.Formularios
{
    public partial class frmInformeTotalVentas : Form
    {
        Dictionary<int, decimal> totalVentas = new Dictionary<int, decimal>();
        int total = 0;


        Heladeria.Data.EntityFramework.Filtros.FiltroArticulo Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroArticulo();
        private Repositorio<Venta> repVenta = new Repositorio<Venta>(new VentaIdentificador());
        private Repositorio<Pedido> repPedido = new Repositorio<Pedido>(new PedidoIdentificador());
        private Repositorio<Articulo> repArticulo = new Repositorio<Articulo>(new ArticuloIdentificador());
        private Repositorio<DetalleVenta> repDetalleVenta = new Repositorio<DetalleVenta>(new DetalleVentaIdentificador());
        DateTime fecha2 = DateTime.Parse(DateTime.Today.ToString().Substring(0,10) + " 00:00:00");
        DateTime fecha3 = DateTime.Parse(DateTime.Today.ToString().Substring(0, 10) + " 23:59:59");
        private List<Venta> CargarVentas()
        {
            List<Venta> ventas = new List<Venta>();
            ventas.AddRange(repVenta.Listar(new FiltroVenta(), out _));
            return ventas;
        }
        private List<Pedido> CargarPedido()
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

        private List<Venta> FiltrarVentas(List<Venta> ventas , DateTime fecha)
        {
            List<Venta> ventasFiltradas = new List<Venta>();
            string a = fecha.ToString().Substring(0, 10) + " 00:00:00";
            fecha2 = DateTime.Parse(a);
            foreach (Venta venta in ventas)
            {
                if (venta.Fecha >= fecha2 && venta.Fecha <= fecha3)
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
                if(venta.Fecha >= fecha2 && venta.Fecha <= fecha3)
                    ventasFiltradas.Add(venta);
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
                    }
                }
            }
            return detallesFiltrados;
        }
        Dictionary<int, int> idCantidad = new Dictionary<int, int>();
        Dictionary<int, int> idPrecio = new Dictionary<int, int>();
        private void FiltrarArticulos(List<DetalleVenta> detalles , List<Pedido> p)
        {
            foreach (DetalleVenta detal in detalles)
            {
                int id = detal.IdArticulo, precio = detal.Cantidad * (int)detal.PrecioUnitario;
                int id2 = detal.IdArticulo, cantidad = detal.Cantidad ;
                try
                {
                    idPrecio.Add(id, precio);
                    idCantidad.Add(id2, cantidad);
                }
                catch (System.ArgumentException)
                {
                    idPrecio[id] += detal.Cantidad * (int)detal.PrecioUnitario;
                    idCantidad[id2] += detal.Cantidad;
                }
            }
            foreach (Pedido detal in p)
            {

                int id = detal.IdArticulo, precio = 0 , pU = 0;
                foreach (Articulo a in CargarArticulos())
                {
                    if (a.IdArticulo == id)
                    {
                        precio = detal.Cantidad * (int)a.PrecioVenta;
                        pU = (int)a.PrecioVenta;
                    }
                        
                }
                int id2 = detal.IdArticulo, cantidad = detal.Cantidad;
                try
                {
                    idPrecio.Add(id, precio);
                    idCantidad.Add(id2, cantidad);
                }
                catch (System.ArgumentException)
                {
                    idPrecio[id] += detal.Cantidad * pU;
                    idCantidad[id2] += detal.Cantidad;
                }
            }
        }
        public frmInformeTotalVentas()
        {
            InitializeComponent();
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

        private void ActualizaGrilla()
        {      
            grvArticulo.DataSource = null;
            BindingSource db = new BindingSource();
            db.DataSource = ventas;
            grvArticulo.DataSource = db.DataSource;
        }

        private void frmInformeTotalVentas_Load(object sender, EventArgs e)
        {
            PaletaColores(grvArticulo);
            ActualizaGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.Nombre = null;
            Filtro.Cantidad = null;
            Filtro.Codigo = null;
            Filtro.IdArticulo = null;
            ActualizaGrilla();
            //HabilitarControles(true);
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

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        class informeVentas
        {
            public int Id { get; set; }
            public string nombre { get; set; }
            public int cantidad { get; set; }
            public string monto { get; set; }
        }
        List<informeVentas> ventas = new List<informeVentas>();
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            idCantidad.Clear();
            idPrecio.Clear();
            ventas.Clear();
            total = 0;
            fecha2 = dtpFecha.Value;
            fecha3 = dtpFecha1.Value;
            fecha3 = DateTime.Parse(fecha3.ToString().Substring(0, 10) + " 23:59:59");
            List<Articulo> articulos = CargarArticulos();
            fecha2 = DateTime.Parse(fecha2.ToString().Substring(0, 10) + " 00:00:00");
            FiltrarArticulos(FiltrarDetalleVenta(FiltrarVentas(CargarVentas(), fecha2), CargarDetalles()) , FiltrarPedido(CargarPedido()));
            var ListaCantidad = idCantidad;      
            
            foreach (KeyValuePair<int , int> articulo in idPrecio)
            {
                informeVentas venta = new informeVentas();
                total += articulo.Value;
                venta.Id = articulo.Key;
                venta.monto = "$" + articulo.Value;
                venta.cantidad = idCantidad[articulo.Key];
                foreach(Articulo art in articulos)
                {
                    if (art.IdArticulo == articulo.Key)
                        venta.nombre = art.Nombre;
                }
                ventas.Add(venta);
            }
            ventas.Sort((pair1, pair2) => pair1.monto.CompareTo(pair2.monto));
            lblTotal.Text = "total de ingresos desde " + fecha2 + " hasta " + fecha3 + ": $" + total;
            ActualizaGrilla();
        }

        private void grvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvArticulo_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void grvArticulo_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (grvArticulo.Rows.Count > 0)
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
                            PdfPTable pTable = new PdfPTable(grvArticulo.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in grvArticulo.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in grvArticulo.Rows)
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

                                document.Open();
                                document.Add(new Paragraph("Reporte de total de ventas desde el " + fecha2.ToString("dd/MM/yyyy") + " hasta " + fecha3.ToString() + ": " + total));
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

