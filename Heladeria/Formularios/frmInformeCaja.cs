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
    public partial class frmInformeCaja : Form
    {
        int ventasLocal = 0, ventasAplicacion = 0;
        decimal efectivo = 0, otroMedio = 0;
        DateTime fecha1 = DateTime.Parse(DateTime.Today.ToString().Substring(0, 10) + " 23:59:59");
        DateTime fecha = DateTime.Parse(DateTime.Today.ToString().Substring(0, 10) + " 00:00:00");
        DateTime fechaI = DateTime.Now;
        Heladeria.Data.EntityFramework.Filtros.FiltroInformeCaja Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroInformeCaja();
        private Repositorio<InformeCaja> Repositorio = new Repositorio<InformeCaja>(new InformeCajaIdentificador());
        public frmInformeCaja()
        {
            InitializeComponent();
        }

        private void ActualizaGrilla()
        {
            InformeCajaBindingSource.DataSource = null;
            InformeCajaBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
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
        private void frmInformeCaja_Load(object sender, EventArgs e)
        {
            PaletaColores(dgvInformeCaja);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            InformeCajaBindingSource1.DataSource = new InformeCaja();
        }
        private Repositorio<Venta> repVenta = new Repositorio<Venta>(new VentaIdentificador());
        private Repositorio<Pedido> repPedido = new Repositorio<Pedido>(new PedidoIdentificador());

        private List<Venta> CargarVentas()
        {
            List<Venta> ventas = new List<Venta>();
            ventas.AddRange(repVenta.Listar(new FiltroVenta(), out _));
            return ventas;
        }
        private List<Pedido> CargarPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            pedidos.AddRange(repPedido.Listar(new FiltroPedido(), out _));
            return pedidos;
        }

        private List<Venta> FiltrarVentas(List<Venta> ventas)
        {
            
            List<Venta> ventasFiltradas = new List<Venta>();
            foreach (Venta venta in ventas)
            {
                if (venta.Fecha >= fecha && venta.Fecha <= fecha1)
                {
                    ventasFiltradas.Add(venta);
                    ventasLocal += 1;    
                }
            }
            return ventasFiltradas;
        }
        private List<Pedido> FiltrarPedidos(List<Pedido> pedidos)
        {
            List<Pedido> PFiltradas = new List<Pedido>();
            foreach (Pedido p in pedidos)
            {
                if(p.Fecha >= fecha && p.Fecha <= fecha1)
                {
                    PFiltradas.Add(p);
                    ventasAplicacion += 1;
                }          
            }
            return PFiltradas;
        }
        private void FiltrarPagos(List<Venta> ventas)
        {

            foreach (Venta venta in ventas)
            {
                if (venta.IdTipoPago == 1)
                    efectivo += venta.Total;
                else
                    otroMedio += venta.Total;
            }
        }
        private void FiltrarPagosP(List<Pedido> ventas)
        {           
            foreach (Pedido venta in ventas)
            {
                if (venta.IdTipoPago == 1)
                    efectivo += (int)venta.Total;
                else
                    otroMedio += (int)venta.Total;
            }
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            fecha = dtpFecha.Value;
            fecha1 = dtpFecha.Value;
            fecha = DateTime.Parse(fecha.ToString().Substring(0, 10) + " 00:00:00");
            fecha1 = DateTime.Parse(fecha1.ToString().Substring(0, 10) + " 23:59:59");
            efectivo = 0;
            otroMedio = 0;
            ventasAplicacion = 0;
            ventasLocal = 0;
            lblTitulo.Visible = true;
            InformeCajaBindingSource1.DataSource = new InformeCaja();
            FiltrarPagos(FiltrarVentas(CargarVentas()));
            FiltrarPagosP(FiltrarPedidos(CargarPedidos()));
            lblTitulo.Text = "Informe caja del: " + fecha.ToString();
            txtLocal.Text = ventasLocal.ToString();
            txtAplicacion.Text = ventasAplicacion.ToString();
            txtEfectivo.Text = efectivo.ToString();
            txtOtroMedio.Text = otroMedio.ToString();
            ActualizaGrilla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InformeCaja actual = new InformeCaja();;
            try
            {
                actual.Aplicacion = int.Parse(txtAplicacion.Text);
            }
            catch
            {
                MessageBox.Show("No hay datos para guardar", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            actual.Fecha = fecha;
            actual.Local = int.Parse(txtLocal.Text);
            actual.Efectivo = efectivo;
            actual.OtroMedio = otroMedio;
            if (actual == null)
            {
                MessageBox.Show("No se esta editando una entidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (actual.Local + actual.Aplicacion == 0)
            {
                MessageBox.Show("No se relizaron ventas", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Repositorio.Guardar(actual);
            InformeCajaBindingSource1.DataSource = new InformeCaja();
            ActualizaGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar este Informe?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InformeCaja actual = new InformeCaja();
                actual.Id = int.Parse( txtId.Text);
                actual.Local = int.Parse(txtLocal.Text);
                actual.Aplicacion = int.Parse(txtAplicacion.Text);
                actual.Efectivo = decimal.Parse(txtEfectivo.Text);
                actual.OtroMedio = decimal.Parse(txtOtroMedio.Text);
                actual.Fecha = fecha1;
                Repositorio.Eliminar(actual);
                ActualizaGrilla();
            }
        }

        private void InformeCajaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            InformeCaja actual = InformeCajaBindingSource.Current as InformeCaja;
            //InformeCajaBindingSource1.DataSource = actual;
            
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
                for (int i = 0; i < dgvInformeCaja.Columns.Count; i++)
                {
                    var columna = dgvInformeCaja.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }

        private void dgvInformeCaja_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = dgvInformeCaja.Columns[e.ColumnIndex];
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

        private void nupTamanioPagina_ValueChanged(object sender, EventArgs e)
        {
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            lblTitulo.Visible = false;
            InformeCajaBindingSource1.DataSource = new InformeCaja();
            ActualizaGrilla();
        }

        private void dgvInformeCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvInformeCaja.CurrentRow.Cells[0].Value.ToString();
            txtLocal.Text = Convert.ToString(dgvInformeCaja.CurrentRow.Cells[1].Value);
            txtAplicacion.Text = Convert.ToString(dgvInformeCaja.CurrentRow.Cells[2].Value);
            txtEfectivo.Text = Convert.ToString(dgvInformeCaja.CurrentRow.Cells[3].Value);
            txtOtroMedio.Text = Convert.ToString(dgvInformeCaja.CurrentRow.Cells[4].Value);
            fecha1 = (DateTime)dgvInformeCaja.CurrentRow.Cells[5].Value;
        }

        private void nupPagina_ValueChanged(object sender, EventArgs e)
        {
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgvInformeCaja.Rows.Count > 0)
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
                            PdfPTable pTable = new PdfPTable(dgvInformeCaja.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            foreach (DataGridViewColumn col in dgvInformeCaja.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
                                pTable.AddCell(pCell);
                            }
                            foreach (DataGridViewRow viewRow in dgvInformeCaja.Rows)
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
                                DateTime fechax = DateTime.Now;
                                document.Add(new Paragraph("Informe de caja por dia"));
                                document.Add(new Paragraph("documento generado el " + fechax.ToString("dd/MM/yyyy")));
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

