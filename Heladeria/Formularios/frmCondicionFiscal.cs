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

namespace Heladeria
{
    public partial class frmCondicionFiscal : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroCondicionFiscal Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroCondicionFiscal();
        private Repositorio<CondicionFiscal> Repositorio = new Repositorio<CondicionFiscal>(new CondicionFiscalIdentificador());
        private bool Editando = false;
        public frmCondicionFiscal()
        {
            InitializeComponent();
        }

        private void ActualizaGrilla()
        {
            CondicionFiscalBindingSource.DataSource = null;
            CondicionFiscalBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas :  1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
        }



        private void frmCondicionFiscal_Load(object sender, EventArgs e)
        {
            PaletaColores(grvCondicionFiscal);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            CondicionFiscalBindingSource1.DataSource = new CondicionFiscal();
            Editando = false;
            HabilitarControles(true);
        }

        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de CondicionFiscal";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos del nuevo CondicionFiscal";
                }
                else
                {
                    pnlFiltro.Text = "Datos del CondicionFiscal"; 
                }
            }
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtCondicionFiscal.Enabled = filtro;
            btnEliminar.Visible = !filtro && !nuevo;
            btnGuardar.Visible = !filtro;
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            CondicionFiscalBindingSource1.DataSource = new CondicionFiscal();
            Editando = true;
            HabilitarControles(false, true);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.IdCondicionFiscal = null;
            Filtro.Tipo = null;
            CondicionFiscal actual = CondicionFiscalBindingSource1.DataSource as CondicionFiscal;
            if (actual == null)
            {
                MessageBox.Show("No se esta editando una entidad", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(actual.Tipo))
            {
                MessageBox.Show("El tipo es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Repositorio.Guardar(actual);
            Editando = false;
            CondicionFiscalBindingSource1.DataSource = new CondicionFiscal();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.IdCondicionFiscal = null;
            Filtro.Tipo = null;
            Editando = false;
            CondicionFiscalBindingSource1.DataSource  = new CondicionFiscal();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.IdCondicionFiscal = null;
            Filtro.Tipo = null;
            if (MessageBox.Show("Esta seguro que desea eliminar esta CondicionFiscal?", "Eliminacion",MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes)
            {
                CondicionFiscal actual = CondicionFiscalBindingSource1.DataSource as CondicionFiscal;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("condicion fiscal en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }


        private void CondicionFiscalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            CondicionFiscal actual = CondicionFiscalBindingSource.Current as CondicionFiscal;
            if (Editando)
            {
                HabilitarControles(false, false);
                CondicionFiscalBindingSource1.DataSource = actual;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CondicionFiscal actual = CondicionFiscalBindingSource1.DataSource as CondicionFiscal;
            Filtro.Tipo = actual.Tipo;            
            if (actual.IdCondicionFiscal != 0)
            {
                Filtro.IdCondicionFiscal = actual.IdCondicionFiscal;
            }
            else
            {
                Filtro.IdCondicionFiscal = null;
            }
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            CondicionFiscal actual = CondicionFiscalBindingSource.Current as CondicionFiscal;
            Editando = actual != null;            
            if (Editando)            
            {
                HabilitarControles(false, false);
                CondicionFiscalBindingSource1.DataSource = actual;
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
                for (int i = 0; i < grvCondicionFiscal.Columns.Count; i++)
                {
                    var columna = grvCondicionFiscal.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }
        private void grvCondicionFiscal_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = grvCondicionFiscal.Columns[e.ColumnIndex];
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
        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
