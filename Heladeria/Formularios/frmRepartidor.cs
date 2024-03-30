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

namespace Heladeria.Formularios
{
    public partial class frmRepartidor : Form
    {
        Heladeria.Data.EntityFramework.Filtros.FiltroRepartidor Filtro = new Heladeria.Data.EntityFramework.Filtros.FiltroRepartidor();
        private Repositorio<Repartidor> Repositorio = new Repositorio<Repartidor>(new RepartidorIdentificador());
        private bool Editando = false;
        public frmRepartidor()
        {
            InitializeComponent();
        }
        private void ActualizaGrilla()
        {
            RepartidorBindingSource.DataSource = null;
            RepartidorBindingSource.DataSource = Repositorio.Listar(Filtro, out var total);
            int cantidadpaginas = (int)Math.Ceiling(total / nupTamanioPagina.Value);
            nupPagina.Maximum = cantidadpaginas > 0 ? cantidadpaginas : 1;
            lbltotalPaginas.Text = "/ " + nupPagina.Maximum.ToString();
            nupPagina.Minimum = 1;
        }
        private void HabilitarControles(bool filtro, bool nuevo = false)
        {
            if (filtro)
            {
                pnlFiltro.Text = "Busqueda de Repartidor";
            }
            else
            {
                if (nuevo)
                {
                    pnlFiltro.Text = "Datos de nuevo Repartidor";
                }
                else
                {
                    pnlFiltro.Text = "Datos de Repartidor";
                }
            }
            btnEditar.Visible = filtro;
            btnBuscar.Visible = filtro;
            btnNuevo.Visible = filtro;
            txtRepartidor.Enabled = filtro;
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
        private void frmRepartidor_Load(object sender, EventArgs e)
        {
            PaletaColores(dgvRepartidor);
            Filtro.TamanioPagina = (int)nupTamanioPagina.Value;
            Filtro.NumeroPagina = (int)(nupPagina.Value - 1);
            ActualizaGrilla();
            RepartidorBindingSource1.DataSource = new Repartidor();
            Editando = false;
            HabilitarControles(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            RepartidorBindingSource1.DataSource = new Repartidor();
            Editando = true;
            HabilitarControles(false, true);
            // ActualizaGrilla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Filtro.IdRepartidor = null;
            Filtro.Celular = null;
            Filtro.DNI = null;
            Filtro.Nombre = null;
            Repartidor actual = RepartidorBindingSource1.DataSource as Repartidor;
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
            if (string.IsNullOrWhiteSpace(actual.Celular))
            {
                MessageBox.Show("El celular es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrWhiteSpace(actual.DNI))
            {
                MessageBox.Show("El DNI es un campo requerido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                Repositorio.Guardar(actual);
            }
            catch
            {
                MessageBox.Show("DNI repetido", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            Editando = false;
            RepartidorBindingSource1.DataSource = new Repartidor();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Filtro.IdRepartidor = null;
            Filtro.Celular = null;
            Filtro.DNI = null;
            Filtro.Nombre = null;
            Editando = false;
            RepartidorBindingSource1.DataSource = new Repartidor();
            ActualizaGrilla();
            HabilitarControles(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Filtro.IdRepartidor = null;
            Filtro.Celular = null;
            Filtro.DNI = null;
            Filtro.Nombre = null;
            if (MessageBox.Show("Esta seguro que desea eliminar este Repartidor?", "Eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Repartidor actual = RepartidorBindingSource1.DataSource as Repartidor;
                try
                {
                    Repositorio.Eliminar(actual);
                }
                catch
                {
                    MessageBox.Show("repartidor en uso", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Editando = false;
                ActualizaGrilla();
                HabilitarControles(true);
            }
        }

        private void RepartidorBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            Repartidor actual = RepartidorBindingSource.Current as Repartidor;
            if (Editando)
            {
                HabilitarControles(false, false);
                RepartidorBindingSource1.DataSource = actual;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Repartidor actual = RepartidorBindingSource1.DataSource as Repartidor;
            Filtro.Nombre = actual.Nombre;
            Filtro.Celular = actual.Celular;
            Filtro.DNI=actual.DNI;

            if (actual.IdRepartidor != 0)
            {
                Filtro.IdRepartidor = actual.IdRepartidor;
            }
            else
            {
                Filtro.IdRepartidor = null;
            }
            nupPagina.Value = 1;
            Filtro.NumeroPagina = 0;
            ActualizaGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Repartidor actual = RepartidorBindingSource.Current as Repartidor;
            Editando = actual != null;
            if (Editando)
            {
                HabilitarControles(false, false);
                RepartidorBindingSource1.DataSource = actual;
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
                for (int i = 0; i < dgvRepartidor.Columns.Count; i++)
                {
                    var columna = dgvRepartidor.Columns[i];
                    if (columna.DataPropertyName == Filtro.Orden)
                    {
                        columna.HeaderText = LimpiarNombre(columna.HeaderText);
                    }
                }
            }
        }

        private void dgvRepartidor_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var columna = dgvRepartidor.Columns[e.ColumnIndex];
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
    }
}
