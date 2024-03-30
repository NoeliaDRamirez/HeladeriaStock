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
    public partial class frmInformeMasVendidos : Form
    {
        DateTime fecha = DateTime.Parse(DateTime.Today.ToString().Substring(0, 10) + " 00:00:00");
       
        DateTime fecha2 = DateTime.Parse(DateTime.Today.ToString().Substring(0, 10) + " 23:59:59");
        Heladeria.Data.EntityFramework.Filtros.FiltroInformeMasVendidos Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroInformeMasVendidos();
        private Repositorio<InformeMasVendidos> Repositorio = new Repositorio<InformeMasVendidos>(new InformeMasVendidosIdentificador());
        public frmInformeMasVendidos()
        {
            InitializeComponent();
        }

        private void ActualizaGrilla()
        {
            InformeMasVendidosBindingSource.DataSource = null;
            InformeMasVendidosBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
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
        private void frmInformeMasVendidos_Load(object sender, EventArgs e)
        {
            PaletaColores(dgvInformeMasVendidos);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            InformeMasVendidosBindingSource1.DataSource = new InformeMasVendidos();
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
                if (venta.Fecha >= fecha && venta.Fecha <= fecha2)
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
                if(venta.Fecha >= fecha && venta.Fecha <= fecha2)
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
        
        private Dictionary<int, int> FiltrarArticulos(List<DetalleVenta> detalles , List<Pedido> p )
        {
            Dictionary<int, int> idCantidad = new Dictionary<int, int>();
            foreach (DetalleVenta detal in detalles)
            {
                int id = detal.IdArticulo, cantidad = detal.Cantidad;
                try
                {
                    idCantidad.Add(id, cantidad);
                }
                catch (System.ArgumentException)
                {
                    idCantidad[id] += detal.Cantidad;
                }
            }
            foreach (Pedido detal in p)
            {
                int id = detal.IdArticulo, cantidad = detal.Cantidad;
                try
                {
                    idCantidad.Add(id, cantidad);
                }
                catch (System.ArgumentException)
                {
                    idCantidad[id] += detal.Cantidad;
                }
            }
            return idCantidad;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = true;
            InformeMasVendidosBindingSource1.DataSource = new InformeMasVendidos();
            var Lista = FiltrarArticulos(FiltrarDetalleVenta(FiltrarVentas(CargarVentas()), CargarDetalles()), FiltrarPedido(CargarPedidos())).ToList();

            Lista.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            List<Articulo> articulos = CargarArticulos();
            string nombre = "";
            fecha = dtpFecha.Value;
            fecha2 = dtpFecha1.Value;
            fecha = DateTime.Parse(fecha.ToString().Substring(0, 10) + " 00:00:00");
            fecha2 = DateTime.Parse(fecha2.ToString().Substring(0, 10) + " 23:59:59");
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

                lblTitulo.Text = "Articulo mas vendido desde el " + fecha.ToString() + " hasta " + fecha2.ToString();
                txtNombre.Text = nombre;
                txtCantidad.Text = Lista[Lista.Count - 1].Value.ToString();
            }
            catch
            {
                lblTitulo.Text = "No hay articulos vendidos desde el " + fecha.ToString() + " hasta " + fecha2.ToString();
            }
            
            ActualizaGrilla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InformeMasVendidos actual = new InformeMasVendidos();
            actual.Cantidad = int.Parse(txtCantidad.Text);

            actual.Desde = DateTime.Parse(fecha.ToShortDateString());
            actual.Hasta = DateTime.Parse(fecha2.ToShortDateString());
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
            if (actual.Cantidad == 0)
            {
                MessageBox.Show("El Cantidad es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
           
            Repositorio.Guardar(actual);
            InformeMasVendidosBindingSource1.DataSource = new InformeMasVendidos();
            ActualizaGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este Informe?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InformeMasVendidos actual = new InformeMasVendidos();
                actual.Id = int.Parse( txtId.Text);
                actual.Nombre = txtNombre.Text;
                actual.Cantidad = int.Parse(txtCantidad.Text);
                actual.Desde = fecha;
                actual.Hasta = fecha2;
                Repositorio.Eliminar(actual);
                ActualizaGrilla();
            }
        }

        private void InformeMasVendidosBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            InformeMasVendidos actual = InformeMasVendidosBindingSource.Current as InformeMasVendidos;
            //InformeMasVendidosBindingSource1.DataSource = actual;
            
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
                for (int i = 0; i < dgvInformeMasVendidos.Columns.Count; i++)
                {
                    var columna = dgvInformeMasVendidos.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }

        private void dgvInformeMasVendidos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = dgvInformeMasVendidos.Columns[e.ColumnIndex];
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

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            InformeMasVendidosBindingSource1.DataSource = new InformeMasVendidos();
            ActualizaGrilla();
        }

        private void dgvInformeMasVendidos_ColumnHeadersBorderStyleChanged(object sender, EventArgs e)
        {

        }

        private void dgvInformeMasVendidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvInformeMasVendidos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = Convert.ToString(dgvInformeMasVendidos.CurrentRow.Cells[1].Value);
            txtCantidad.Text = Convert.ToString(dgvInformeMasVendidos.CurrentRow.Cells[2].Value);
            fecha = (DateTime) dgvInformeMasVendidos.CurrentRow.Cells[3].Value;
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
            if (dgvInformeMasVendidos.Rows.Count > 0)
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
                            PdfPTable pTable = new PdfPTable(dgvInformeMasVendidos.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvInformeMasVendidos.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvInformeMasVendidos.Rows)
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
                                document.Add(new Paragraph("Reporte de productos mas vendidos por periodos"));
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

