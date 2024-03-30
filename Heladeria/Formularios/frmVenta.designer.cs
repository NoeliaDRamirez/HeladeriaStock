namespace Heladeria.Formularios
{
    partial class frmVenta
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
            this.label8 = new System.Windows.Forms.Label();
            this.cbTotal = new System.Windows.Forms.TextBox();
            this.VentaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.TipoPagoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RepartidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbIdDetalleVenta = new System.Windows.Forms.ComboBox();
            this.DetalleVentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupTamanioPagina = new System.Windows.Forms.NumericUpDown();
            this.lbltotalPaginas = new System.Windows.Forms.Label();
            this.nupPagina = new System.Windows.Forms.NumericUpDown();
            this.cerrar = new System.Windows.Forms.Button();
            this.lblIdDetalle = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.grvVenta = new System.Windows.Forms.DataGridView();
            this.idVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRepartidorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTipoPagoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VentaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoPagoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepartidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlFiltro.Controls.Add(this.label8);
            this.pnlFiltro.Controls.Add(this.cbTotal);
            this.pnlFiltro.Controls.Add(this.txtComentario);
            this.pnlFiltro.Controls.Add(this.lblTipo);
            this.pnlFiltro.Controls.Add(this.cbTipoPago);
            this.pnlFiltro.Controls.Add(this.label3);
            this.pnlFiltro.Controls.Add(this.cbIdDetalleVenta);
            this.pnlFiltro.Controls.Add(this.panel1);
            this.pnlFiltro.Controls.Add(this.cerrar);
            this.pnlFiltro.Controls.Add(this.lblIdDetalle);
            this.pnlFiltro.Controls.Add(this.lblCliente);
            this.pnlFiltro.Controls.Add(this.label1);
            this.pnlFiltro.Controls.Add(this.cbCliente);
            this.pnlFiltro.Controls.Add(this.txtVenta);
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
            this.pnlFiltro.Size = new System.Drawing.Size(836, 262);
            this.pnlFiltro.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(128, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Ventas";
            // 
            // cbTotal
            // 
            this.cbTotal.BackColor = System.Drawing.Color.Navy;
            this.cbTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VentaBindingSource1, "Total", true));
            this.cbTotal.Enabled = false;
            this.cbTotal.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTotal.ForeColor = System.Drawing.Color.White;
            this.cbTotal.Location = new System.Drawing.Point(450, 179);
            this.cbTotal.Name = "cbTotal";
            this.cbTotal.Size = new System.Drawing.Size(205, 27);
            this.cbTotal.TabIndex = 42;
            // 
            // VentaBindingSource1
            // 
            this.VentaBindingSource1.DataSource = typeof(Heladeria.Data.EntityFramework.Venta);
            // 
            // txtComentario
            // 
            this.txtComentario.BackColor = System.Drawing.Color.Navy;
            this.txtComentario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VentaBindingSource1, "Comentario", true));
            this.txtComentario.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentario.ForeColor = System.Drawing.Color.White;
            this.txtComentario.Location = new System.Drawing.Point(130, 55);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(225, 27);
            this.txtComentario.TabIndex = 41;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTipo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(12, 151);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(93, 17);
            this.lblTipo.TabIndex = 40;
            this.lblTipo.Text = "Tipo de pago";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.BackColor = System.Drawing.Color.Navy;
            this.cbTipoPago.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.VentaBindingSource1, "IdTipoPago", true));
            this.cbTipoPago.DataSource = this.TipoPagoBindingSource;
            this.cbTipoPago.DisplayMember = "Nombre";
            this.cbTipoPago.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPago.ForeColor = System.Drawing.Color.White;
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(130, 147);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(224, 24);
            this.cbTipoPago.TabIndex = 39;
            this.cbTipoPago.ValueMember = "IdTipoPago";
            // 
            // TipoPagoBindingSource
            // 
            this.TipoPagoBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.TipoPago);
            // 
            // RepartidorBindingSource
            // 
            this.RepartidorBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Repartidor);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Comentario";
            // 
            // cbIdDetalleVenta
            // 
            this.cbIdDetalleVenta.BackColor = System.Drawing.Color.Navy;
            this.cbIdDetalleVenta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.VentaBindingSource1, "IdDetalle", true));
            this.cbIdDetalleVenta.DataSource = this.DetalleVentaBindingSource;
            this.cbIdDetalleVenta.DisplayMember = "IdDetalleVenta";
            this.cbIdDetalleVenta.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdDetalleVenta.ForeColor = System.Drawing.Color.White;
            this.cbIdDetalleVenta.FormattingEnabled = true;
            this.cbIdDetalleVenta.Location = new System.Drawing.Point(130, 117);
            this.cbIdDetalleVenta.Name = "cbIdDetalleVenta";
            this.cbIdDetalleVenta.Size = new System.Drawing.Size(225, 24);
            this.cbIdDetalleVenta.TabIndex = 32;
            this.cbIdDetalleVenta.ValueMember = "IdDetalleVenta";
            // 
            // DetalleVentaBindingSource
            // 
            this.DetalleVentaBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.DetalleVenta);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nupTamanioPagina);
            this.panel1.Controls.Add(this.lbltotalPaginas);
            this.panel1.Controls.Add(this.nupPagina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(677, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 262);
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
            // lblIdDetalle
            // 
            this.lblIdDetalle.AutoSize = true;
            this.lblIdDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblIdDetalle.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdDetalle.ForeColor = System.Drawing.Color.White;
            this.lblIdDetalle.Location = new System.Drawing.Point(12, 124);
            this.lblIdDetalle.Name = "lblIdDetalle";
            this.lblIdDetalle.Size = new System.Drawing.Size(112, 17);
            this.lblIdDetalle.TabIndex = 28;
            this.lblIdDetalle.Text = "Id Detalle Venta";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(12, 89);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(70, 17);
            this.lblCliente.TabIndex = 27;
            this.lblCliente.Text = "Id Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdVenta";
            // 
            // cbCliente
            // 
            this.cbCliente.BackColor = System.Drawing.Color.Navy;
            this.cbCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.VentaBindingSource1, "IdCliente", true));
            this.cbCliente.DataSource = this.ClienteBindingSource;
            this.cbCliente.DisplayMember = "Nombre";
            this.cbCliente.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCliente.ForeColor = System.Drawing.Color.White;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(130, 85);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(225, 24);
            this.cbCliente.TabIndex = 26;
            this.cbCliente.ValueMember = "IdCliente";
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Cliente);
            // 
            // txtVenta
            // 
            this.txtVenta.BackColor = System.Drawing.Color.Navy;
            this.txtVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VentaBindingSource1, "IdVenta", true));
            this.txtVenta.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenta.ForeColor = System.Drawing.Color.White;
            this.txtVenta.Location = new System.Drawing.Point(130, 25);
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(225, 27);
            this.txtVenta.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(382, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Navy;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(110, 222);
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
            this.btnNuevo.Location = new System.Drawing.Point(25, 222);
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
            this.btnBuscar.Location = new System.Drawing.Point(195, 222);
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
            this.btnGuardar.Location = new System.Drawing.Point(280, 222);
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
            this.btnCancelar.Location = new System.Drawing.Point(365, 222);
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
            this.btnEliminar.Location = new System.Drawing.Point(450, 222);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // grvVenta
            // 
            this.grvVenta.AllowUserToAddRows = false;
            this.grvVenta.AllowUserToDeleteRows = false;
            this.grvVenta.AutoGenerateColumns = false;
            this.grvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.grvVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvVenta.ColumnHeadersHeight = 30;
            this.grvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVentaDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.idRepartidorDataGridViewTextBoxColumn,
            this.idTipoPagoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.idDetalleDataGridViewTextBoxColumn});
            this.grvVenta.DataSource = this.VentaBindingSource;
            this.grvVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvVenta.EnableHeadersVisualStyles = false;
            this.grvVenta.GridColor = System.Drawing.Color.Black;
            this.grvVenta.Location = new System.Drawing.Point(0, 262);
            this.grvVenta.Name = "grvVenta";
            this.grvVenta.ReadOnly = true;
            this.grvVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.grvVenta.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvVenta.Size = new System.Drawing.Size(836, 263);
            this.grvVenta.TabIndex = 4;
            this.grvVenta.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvVenta_ColumnHeaderMouseClick);
            // 
            // idVentaDataGridViewTextBoxColumn
            // 
            this.idVentaDataGridViewTextBoxColumn.DataPropertyName = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.HeaderText = "IdVenta";
            this.idVentaDataGridViewTextBoxColumn.Name = "idVentaDataGridViewTextBoxColumn";
            this.idVentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idVentaDataGridViewTextBoxColumn.Width = 80;
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            this.comentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.comentarioDataGridViewTextBoxColumn.Width = 110;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 88;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaDataGridViewTextBoxColumn.Width = 73;
            // 
            // idRepartidorDataGridViewTextBoxColumn
            // 
            this.idRepartidorDataGridViewTextBoxColumn.DataPropertyName = "IdRepartidor";
            this.idRepartidorDataGridViewTextBoxColumn.HeaderText = "IdRepartidor";
            this.idRepartidorDataGridViewTextBoxColumn.Name = "idRepartidorDataGridViewTextBoxColumn";
            this.idRepartidorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idRepartidorDataGridViewTextBoxColumn.Width = 112;
            // 
            // idTipoPagoDataGridViewTextBoxColumn
            // 
            this.idTipoPagoDataGridViewTextBoxColumn.DataPropertyName = "IdTipoPago";
            this.idTipoPagoDataGridViewTextBoxColumn.HeaderText = "IdTipoPago";
            this.idTipoPagoDataGridViewTextBoxColumn.Name = "idTipoPagoDataGridViewTextBoxColumn";
            this.idTipoPagoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idTipoPagoDataGridViewTextBoxColumn.Width = 107;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 65;
            // 
            // idDetalleDataGridViewTextBoxColumn
            // 
            this.idDetalleDataGridViewTextBoxColumn.DataPropertyName = "IdDetalle";
            this.idDetalleDataGridViewTextBoxColumn.HeaderText = "IdDetalle";
            this.idDetalleDataGridViewTextBoxColumn.Name = "idDetalleDataGridViewTextBoxColumn";
            this.idDetalleDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDetalleDataGridViewTextBoxColumn.Width = 88;
            // 
            // VentaBindingSource
            // 
            this.VentaBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Venta);
            this.VentaBindingSource.CurrentChanged += new System.EventHandler(this.VentaBindingSource_CurrentChanged);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 525);
            this.Controls.Add(this.grvVenta);
            this.Controls.Add(this.pnlFiltro);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TipoPagoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepartidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleVentaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.ComboBox cbIdDetalleVenta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupTamanioPagina;
        private System.Windows.Forms.Label lbltotalPaginas;
        private System.Windows.Forms.NumericUpDown nupPagina;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label lblIdDetalle;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView grvVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.BindingSource TipoPagoBindingSource;
        private System.Windows.Forms.BindingSource RepartidorBindingSource;
        private System.Windows.Forms.BindingSource DetalleVentaBindingSource;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private System.Windows.Forms.TextBox cbTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepartidorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTipoPagoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource VentaBindingSource;
        private System.Windows.Forms.BindingSource VentaBindingSource1;
    }
}