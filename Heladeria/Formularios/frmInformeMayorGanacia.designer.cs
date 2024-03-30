namespace Heladeria.Formularios
{
    partial class frmInformeMayorGanacia
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
            this.btnPdf = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupTamanioPagina = new System.Windows.Forms.NumericUpDown();
            this.lbltotalPaginas = new System.Windows.Forms.Label();
            this.nupPagina = new System.Windows.Forms.NumericUpDown();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInformeMasVendidos = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvInformeMayorGanancia = new System.Windows.Forms.DataGridView();
            this.InformeMayorGananciaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InformeMayorGananciaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlFiltro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeMayorGanancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformeMayorGananciaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformeMayorGananciaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlFiltro.Controls.Add(this.txtCantidad);
            this.pnlFiltro.Controls.Add(this.label8);
            this.pnlFiltro.Controls.Add(this.btnPdf);
            this.pnlFiltro.Controls.Add(this.label4);
            this.pnlFiltro.Controls.Add(this.label3);
            this.pnlFiltro.Controls.Add(this.dtpFecha1);
            this.pnlFiltro.Controls.Add(this.dtpFecha);
            this.pnlFiltro.Controls.Add(this.label7);
            this.pnlFiltro.Controls.Add(this.btnCancelar);
            this.pnlFiltro.Controls.Add(this.lblTitulo);
            this.pnlFiltro.Controls.Add(this.panel1);
            this.pnlFiltro.Controls.Add(this.txtMonto);
            this.pnlFiltro.Controls.Add(this.cerrar);
            this.pnlFiltro.Controls.Add(this.label1);
            this.pnlFiltro.Controls.Add(this.lblInformeMasVendidos);
            this.pnlFiltro.Controls.Add(this.btnGenerar);
            this.pnlFiltro.Controls.Add(this.txtId);
            this.pnlFiltro.Controls.Add(this.btnGuardar);
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Controls.Add(this.btnEliminar);
            this.pnlFiltro.Controls.Add(this.txtNombre);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(800, 254);
            this.pnlFiltro.TabIndex = 5;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.Navy;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(438, 196);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(130, 30);
            this.btnPdf.TabIndex = 61;
            this.btnPdf.Text = "Guardar PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(296, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 60;
            this.label4.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(296, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 59;
            this.label3.Text = "Hasta";
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Location = new System.Drawing.Point(394, 67);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(192, 20);
            this.dtpFecha1.TabIndex = 58;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(394, 35);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(192, 20);
            this.dtpFecha.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(81, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 17);
            this.label7.TabIndex = 52;
            this.label7.Text = "Informe mayor ganancia";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(329, 196);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 30);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(81, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(20, 17);
            this.lblTitulo.TabIndex = 36;
            this.lblTitulo.Text = "Id";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nupTamanioPagina);
            this.panel1.Controls.Add(this.lbltotalPaginas);
            this.panel1.Controls.Add(this.nupPagina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(641, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 254);
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
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Elementos Por Pagina:";
            // 
            // nupTamanioPagina
            // 
            this.nupTamanioPagina.BackColor = System.Drawing.Color.Navy;
            this.nupTamanioPagina.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.nupTamanioPagina.Size = new System.Drawing.Size(120, 28);
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
            this.lbltotalPaginas.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalPaginas.ForeColor = System.Drawing.Color.White;
            this.lbltotalPaginas.Location = new System.Drawing.Point(72, 140);
            this.lbltotalPaginas.Name = "lbltotalPaginas";
            this.lbltotalPaginas.Size = new System.Drawing.Size(26, 17);
            this.lbltotalPaginas.TabIndex = 21;
            this.lbltotalPaginas.Text = "/ 0";
            // 
            // nupPagina
            // 
            this.nupPagina.BackColor = System.Drawing.Color.Navy;
            this.nupPagina.ForeColor = System.Drawing.Color.White;
            this.nupPagina.Location = new System.Drawing.Point(6, 139);
            this.nupPagina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPagina.Name = "nupPagina";
            this.nupPagina.Size = new System.Drawing.Size(60, 20);
            this.nupPagina.TabIndex = 20;
            this.nupPagina.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupPagina.ValueChanged += new System.EventHandler(this.nupPagina_ValueChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.Navy;
            this.txtMonto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InformeMayorGananciaBindingSource1, "Monto", true));
            this.txtMonto.Enabled = false;
            this.txtMonto.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.ForeColor = System.Drawing.Color.White;
            this.txtMonto.Location = new System.Drawing.Point(84, 99);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(127, 27);
            this.txtMonto.TabIndex = 33;
            // 
            // cerrar
            // 
            this.cerrar.BackColor = System.Drawing.Color.Red;
            this.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cerrar.ForeColor = System.Drawing.Color.White;
            this.cerrar.Location = new System.Drawing.Point(0, 0);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(56, 23);
            this.cerrar.TabIndex = 31;
            this.cerrar.Text = "X";
            this.cerrar.UseVisualStyleBackColor = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Monto";
            // 
            // lblInformeMasVendidos
            // 
            this.lblInformeMasVendidos.AutoSize = true;
            this.lblInformeMasVendidos.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformeMasVendidos.ForeColor = System.Drawing.Color.White;
            this.lblInformeMasVendidos.Location = new System.Drawing.Point(12, 47);
            this.lblInformeMasVendidos.Name = "lblInformeMasVendidos";
            this.lblInformeMasVendidos.Size = new System.Drawing.Size(20, 17);
            this.lblInformeMasVendidos.TabIndex = 0;
            this.lblInformeMasVendidos.Text = "Id";
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.Navy;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(12, 197);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 30);
            this.btnGenerar.TabIndex = 24;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.Navy;
            this.txtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InformeMayorGananciaBindingSource1, "Id", true));
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.White;
            this.txtId.Location = new System.Drawing.Point(84, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(127, 27);
            this.txtId.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(123, 196);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Navy;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(226, 196);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Navy;
            this.txtNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InformeMayorGananciaBindingSource1, "Nombre", true));
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(84, 66);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(178, 27);
            this.txtNombre.TabIndex = 3;
            // 
            // dgvInformeMayorGanancia
            // 
            this.dgvInformeMayorGanancia.AllowUserToAddRows = false;
            this.dgvInformeMayorGanancia.AllowUserToDeleteRows = false;
            this.dgvInformeMayorGanancia.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformeMayorGanancia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInformeMayorGanancia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformeMayorGanancia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.Cantidad,
            this.montoDataGridViewTextBoxColumn,
            this.Desde,
            this.Hasta});
            this.dgvInformeMayorGanancia.DataSource = this.InformeMayorGananciaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInformeMayorGanancia.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInformeMayorGanancia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInformeMayorGanancia.Location = new System.Drawing.Point(0, 254);
            this.dgvInformeMayorGanancia.Name = "dgvInformeMayorGanancia";
            this.dgvInformeMayorGanancia.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformeMayorGanancia.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInformeMayorGanancia.Size = new System.Drawing.Size(800, 196);
            this.dgvInformeMayorGanancia.TabIndex = 6;
            this.dgvInformeMayorGanancia.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformeMayorGanancia_CellClick);
            this.dgvInformeMayorGanancia.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInformeMayorGanancia_ColumnHeaderMouseClick);
            // 
            // InformeMayorGananciaBindingSource
            // 
            this.InformeMayorGananciaBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.InformeMayorGanancia);
            this.InformeMayorGananciaBindingSource.CurrentChanged += new System.EventHandler(this.InformeMayorGananciaBindingSource_CurrentChanged);
            // 
            // InformeMayorGananciaBindingSource1
            // 
            this.InformeMayorGananciaBindingSource1.DataSource = typeof(Heladeria.Data.EntityFramework.InformeMayorGanancia);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // montoDataGridViewTextBoxColumn
            // 
            this.montoDataGridViewTextBoxColumn.DataPropertyName = "Monto";
            this.montoDataGridViewTextBoxColumn.HeaderText = "Monto";
            this.montoDataGridViewTextBoxColumn.Name = "montoDataGridViewTextBoxColumn";
            this.montoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Desde
            // 
            this.Desde.DataPropertyName = "Desde";
            this.Desde.HeaderText = "Desde";
            this.Desde.Name = "Desde";
            this.Desde.ReadOnly = true;
            // 
            // Hasta
            // 
            this.Hasta.DataPropertyName = "Hasta";
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.Name = "Hasta";
            this.Hasta.ReadOnly = true;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Navy;
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InformeMayorGananciaBindingSource1, "Cantidad", true));
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(84, 129);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(127, 27);
            this.txtCantidad.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Cantidad";
            // 
            // frmInformeMayorGanacia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvInformeMayorGanancia);
            this.Controls.Add(this.pnlFiltro);
            this.Name = "frmInformeMayorGanacia";
            this.Text = "frmInformeMayorGancia";
            this.Load += new System.EventHandler(this.frmInformeMayorGancia_Load);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformeMayorGanancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformeMayorGananciaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InformeMayorGananciaBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupTamanioPagina;
        private System.Windows.Forms.Label lbltotalPaginas;
        private System.Windows.Forms.NumericUpDown nupPagina;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInformeMasVendidos;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvInformeMayorGanancia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource InformeMayorGananciaBindingSource;
        private System.Windows.Forms.BindingSource InformeMayorGananciaBindingSource1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
    }
}