namespace Heladeria.Formularios
{
    partial class frmDetalleVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DetalleVentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupTamanioPagina = new System.Windows.Forms.NumericUpDown();
            this.lbltotalPaginas = new System.Windows.Forms.Label();
            this.nupPagina = new System.Windows.Forms.NumericUpDown();
            this.cerrar = new System.Windows.Forms.Button();
            this.lblIdDetalleCompra = new System.Windows.Forms.Label();
            this.lbArticulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbArticulo = new System.Windows.Forms.ComboBox();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDetalleVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grvDetalleVenta = new System.Windows.Forms.DataGridView();
            this.idDetalleVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlFiltro.Controls.Add(this.label4);
            this.pnlFiltro.Controls.Add(this.numericUpDown1);
            this.pnlFiltro.Controls.Add(this.nudCantidad);
            this.pnlFiltro.Controls.Add(this.panel1);
            this.pnlFiltro.Controls.Add(this.cerrar);
            this.pnlFiltro.Controls.Add(this.lblIdDetalleCompra);
            this.pnlFiltro.Controls.Add(this.lbArticulo);
            this.pnlFiltro.Controls.Add(this.label1);
            this.pnlFiltro.Controls.Add(this.cbArticulo);
            this.pnlFiltro.Controls.Add(this.txtDetalleVenta);
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Controls.Add(this.btnEditar);
            this.pnlFiltro.Controls.Add(this.btnNuevo);
            this.pnlFiltro.Controls.Add(this.btnBuscar);
            this.pnlFiltro.Controls.Add(this.btnGuardar);
            this.pnlFiltro.Controls.Add(this.btnCancelar);
            this.pnlFiltro.Controls.Add(this.btnEliminar);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(852, 231);
            this.pnlFiltro.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Navy;
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.DetalleVentaBindingSource1, "PrecioUnitario", true));
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(145, 105);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(205, 22);
            this.numericUpDown1.TabIndex = 32;
            // 
            // DetalleVentaBindingSource1
            // 
            this.DetalleVentaBindingSource1.DataSource = typeof(Heladeria.Data.EntityFramework.DetalleVenta);
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.Color.Navy;
            this.nudCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.DetalleVentaBindingSource1, "Cantidad", true));
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.ForeColor = System.Drawing.Color.White;
            this.nudCantidad.Location = new System.Drawing.Point(145, 70);
            this.nudCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(205, 22);
            this.nudCantidad.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nupTamanioPagina);
            this.panel1.Controls.Add(this.lbltotalPaginas);
            this.panel1.Controls.Add(this.nupPagina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(693, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 231);
            this.panel1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pagina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Elementos Por Pagina:";
            // 
            // nupTamanioPagina
            // 
            this.nupTamanioPagina.BackColor = System.Drawing.Color.Navy;
            this.nupTamanioPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTamanioPagina.ForeColor = System.Drawing.Color.White;
            this.nupTamanioPagina.Location = new System.Drawing.Point(6, 93);
            this.nupTamanioPagina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nupTamanioPagina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupTamanioPagina.Name = "nupTamanioPagina";
            this.nupTamanioPagina.Size = new System.Drawing.Size(120, 21);
            this.nupTamanioPagina.TabIndex = 22;
            this.nupTamanioPagina.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nupTamanioPagina.ValueChanged += new System.EventHandler(this.nupTamanioPagina_ValueChanged);
            // 
            // lbltotalPaginas
            // 
            this.lbltotalPaginas.AutoSize = true;
            this.lbltotalPaginas.ForeColor = System.Drawing.Color.White;
            this.lbltotalPaginas.Location = new System.Drawing.Point(72, 140);
            this.lbltotalPaginas.Name = "lbltotalPaginas";
            this.lbltotalPaginas.Size = new System.Drawing.Size(21, 13);
            this.lbltotalPaginas.TabIndex = 21;
            this.lbltotalPaginas.Text = "/ 0";
            // 
            // nupPagina
            // 
            this.nupPagina.BackColor = System.Drawing.Color.Navy;
            this.nupPagina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPagina.ForeColor = System.Drawing.Color.White;
            this.nupPagina.Location = new System.Drawing.Point(6, 139);
            this.nupPagina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPagina.Name = "nupPagina";
            this.nupPagina.Size = new System.Drawing.Size(60, 21);
            this.nupPagina.TabIndex = 20;
            this.nupPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPagina.ValueChanged += new System.EventHandler(this.nupPagina_ValueChanged);
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.Red;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cerrar.ForeColor = System.Drawing.Color.White;
            this.cerrar.Location = new System.Drawing.Point(0, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(56, 23);
            this.cerrar.TabIndex = 30;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // lblIdDetalleCompra
            // 
            this.lblIdDetalleCompra.AutoSize = true;
            this.lblIdDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblIdDetalleCompra.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDetalleCompra.ForeColor = System.Drawing.Color.White;
            this.lblIdDetalleCompra.Location = new System.Drawing.Point(25, 107);
            this.lblIdDetalleCompra.Name = "lblIdDetalleCompra";
            this.lblIdDetalleCompra.Size = new System.Drawing.Size(105, 17);
            this.lblIdDetalleCompra.TabIndex = 28;
            this.lblIdDetalleCompra.Text = "Precio Unitario";
            // 
            // lbArticulo
            // 
            this.lbArticulo.AutoSize = true;
            this.lbArticulo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArticulo.ForeColor = System.Drawing.Color.White;
            this.lbArticulo.Location = new System.Drawing.Point(374, 40);
            this.lbArticulo.Name = "lbArticulo";
            this.lbArticulo.Size = new System.Drawing.Size(58, 17);
            this.lbArticulo.TabIndex = 27;
            this.lbArticulo.Text = "Articulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdDetalleVenta";
            // 
            // cbArticulo
            // 
            this.cbArticulo.BackColor = System.Drawing.Color.Navy;
            this.cbArticulo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.DetalleVentaBindingSource1, "IdArticulo", true));
            this.cbArticulo.DataSource = this.articuloBindingSource;
            this.cbArticulo.DisplayMember = "Nombre";
            this.cbArticulo.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArticulo.ForeColor = System.Drawing.Color.White;
            this.cbArticulo.FormattingEnabled = true;
            this.cbArticulo.Location = new System.Drawing.Point(442, 35);
            this.cbArticulo.Name = "cbArticulo";
            this.cbArticulo.Size = new System.Drawing.Size(225, 24);
            this.cbArticulo.TabIndex = 26;
            this.cbArticulo.ValueMember = "IdArticulo";
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Articulo);
            // 
            // txtDetalleVenta
            // 
            this.txtDetalleVenta.BackColor = System.Drawing.Color.Navy;
            this.txtDetalleVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DetalleVentaBindingSource1, "IdDetalleVenta", true));
            this.txtDetalleVenta.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalleVenta.ForeColor = System.Drawing.Color.White;
            this.txtDetalleVenta.Location = new System.Drawing.Point(145, 35);
            this.txtDetalleVenta.Name = "txtDetalleVenta";
            this.txtDetalleVenta.Size = new System.Drawing.Size(205, 27);
            this.txtDetalleVenta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Navy;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(102, 168);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 25);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Navy;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(17, 168);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Navy;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(187, 168);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(272, 168);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(357, 168);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Navy;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(442, 168);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grvDetalleVenta
            // 
            this.grvDetalleVenta.AllowUserToAddRows = false;
            this.grvDetalleVenta.AllowUserToDeleteRows = false;
            this.grvDetalleVenta.AutoGenerateColumns = false;
            this.grvDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvDetalleVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.grvDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvDetalleVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvDetalleVenta.ColumnHeadersHeight = 30;
            this.grvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalleVentaDataGridViewTextBoxColumn,
            this.idArticuloDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn});
            this.grvDetalleVenta.DataSource = this.DetalleVentaBindingSource;
            this.grvDetalleVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvDetalleVenta.EnableHeadersVisualStyles = false;
            this.grvDetalleVenta.GridColor = System.Drawing.Color.Black;
            this.grvDetalleVenta.Location = new System.Drawing.Point(0, 231);
            this.grvDetalleVenta.Name = "grvDetalleVenta";
            this.grvDetalleVenta.ReadOnly = true;
            this.grvDetalleVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.grvDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grvDetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvDetalleVenta.Size = new System.Drawing.Size(852, 219);
            this.grvDetalleVenta.TabIndex = 4;
            this.grvDetalleVenta.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvDetalleVenta_ColumnHeaderMouseClick);
            // 
            // idDetalleVentaDataGridViewTextBoxColumn
            // 
            this.idDetalleVentaDataGridViewTextBoxColumn.DataPropertyName = "IdDetalleVenta";
            this.idDetalleVentaDataGridViewTextBoxColumn.HeaderText = "IdDetalleVenta";
            this.idDetalleVentaDataGridViewTextBoxColumn.Name = "idDetalleVentaDataGridViewTextBoxColumn";
            this.idDetalleVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDetalleVentaDataGridViewTextBoxColumn.Width = 125;
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArticuloDataGridViewTextBoxColumn.Width = 92;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 90;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "PrecioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioUnitarioDataGridViewTextBoxColumn.Width = 126;
            // 
            // DetalleVentaBindingSource
            // 
            this.DetalleVentaBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.DetalleVenta);
            this.DetalleVentaBindingSource.CurrentChanged += new System.EventHandler(this.DetalleVentaBindingSource_CurrentChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(142, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 51;
            this.label4.Text = "Detalle de venta";
            // 
            // frmDetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 450);
            this.Controls.Add(this.grvDetalleVenta);
            this.Controls.Add(this.pnlFiltro);
            this.Name = "frmDetalleVenta";
            this.Text = "frmDetalleVenta";
            this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupTamanioPagina;
        private System.Windows.Forms.Label lbltotalPaginas;
        private System.Windows.Forms.NumericUpDown nupPagina;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label lblIdDetalleCompra;
        private System.Windows.Forms.Label lbArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbArticulo;
        private System.Windows.Forms.TextBox txtDetalleVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView grvDetalleVenta;
        private System.Windows.Forms.BindingSource DetalleVentaBindingSource1;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private System.Windows.Forms.BindingSource DetalleVentaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
    }
}