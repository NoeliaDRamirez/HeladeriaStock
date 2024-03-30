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
using System.Security.Cryptography;
using iTextSharp.text.pdf;
using System.IO;
using iTextSharp.text;

namespace Heladeria.Formularios
{
    public partial class frmInformeStock : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroArticulo Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroArticulo();
        private Repositorio<Articulo> Repositorio = new Repositorio<Articulo>(new ArticuloIdentificador());
        private Repositorio<Categoria> repCategoria = new Repositorio<Categoria>(new CategoriaIdentificador());
        private Repositorio<Proveedor> repProveedor = new Repositorio<Proveedor>(new ProveedorIdentificador());

        DateTime fecha1 = DateTime.Now;
        public frmInformeStock()
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
            ArticuloBindingSource.DataSource = null;
            ArticuloBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
            //ArticuloBindingSource1.DataSource = null;
            ArticuloBindingSource1.DataSource = new Articulo();
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
        private void frmInformeStock_Load(object sender, EventArgs e)
        {
            PaletaColores(grvArticulo);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            ArticuloBindingSource1.DataSource = new Articulo();
            //HabilitarControles(true);
            CargarCategorias();
            CargarProveedores();
            
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.Nombre = null;
            Filtro.Cantidad = null;
            Filtro.Codigo = null;
            Filtro.IdArticulo = null;
            ArticuloBindingSource1.DataSource = new Articulo();
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

        private void ArticuloBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Articulo actual = ArticuloBindingSource.Current as Articulo;
            try
            {
                ArticuloBindingSource1.DataSource = actual;
            }
            catch { }
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
        private List<Articulo> CargarArticulos()
        {
            List<Articulo> Articulos = new List<Articulo>();
            Articulos.AddRange(Repositorio.Listar(new Data.EntityFramework.Filtros.FiltroArticulo(), out _));
            return Articulos;
        }
        List<Articulo> listaArt = new List<Articulo>();
        private void button1_Click(object sender, EventArgs e)
        {
            string la= " ";
            string las= "MENU \n";
            listaArt = CargarArticulos();
            Articulo articulo = new Articulo();
            foreach (Articulo art in listaArt)
            {
                la = art.Nombre + " $ " + art.PrecioVenta + " \n";
                las = las + la;
            }

                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4);
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "pdf (*.pdf)|*.pdf";
               //string ruta=DialogResult.ToString();
                //string ruta= dialog.FileName;
                if (dialog.ShowDialog() == DialogResult.OK) {
                    string ruta = dialog.FileName;

                    PdfWriter.GetInstance(doc, new FileStream(@ruta, FileMode.Create));
                
                    //PdfWriter.GetInstance(doc, new FileStream(@"C:\Users\goya\Desktop\qr.pdf", FileMode.Create));
                    doc.Open();

                    BarcodeQRCode bqr = new BarcodeQRCode(las, 1000, 1000, null);
                    iTextSharp.text.Image bqrimage = bqr.GetImage();
                    bqrimage.ScaleAbsolute(200, 200);
                    doc.Add(new Paragraph("Menu"));
                    doc.Add(bqrimage);
                    MessageBox.Show("QR GENERADO", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    doc.Close();
                }
            

            //doc.Close();

            //MessageBox.Show("QR GENERADO", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                                document.Add(new Paragraph("Reporte de Stock: "+ fecha1));
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
