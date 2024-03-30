
namespace Heladeria
{

    partial class frmArticulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cerrar = new System.Windows.Forms.Button();
            this.ArticuloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.lblTArticulo = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.CategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDCategoria = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupTamanioPagina = new System.Windows.Forms.NumericUpDown();
            this.lbltotalPaginas = new System.Windows.Forms.Label();
            this.nupPagina = new System.Windows.Forms.NumericUpDown();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grvArticulo = new System.Windows.Forms.DataGridView();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlFiltro = new System.Windows.Forms.Panel();
            this.txtMinimo = new System.Windows.Forms.TextBox();
            this.txtMaximo = new System.Windows.Forms.TextBox();
            this.txtPCompra = new System.Windows.Forms.TextBox();
            this.txtPVenta = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.ProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.opfImagen = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).BeginInit();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            // ArticuloBindingSource1
            // 
            this.ArticuloBindingSource1.DataSource = typeof(Heladeria.Data.EntityFramework.Articulo);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(91, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Minimo";
            // 
            // lblTArticulo
            // 
            this.lblTArticulo.AutoSize = true;
            this.lblTArticulo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTArticulo.ForeColor = System.Drawing.Color.White;
            this.lblTArticulo.Location = new System.Drawing.Point(394, 42);
            this.lblTArticulo.Name = "lblTArticulo";
            this.lblTArticulo.Size = new System.Drawing.Size(71, 17);
            this.lblTArticulo.TabIndex = 27;
            this.lblTArticulo.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Navy;
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ArticuloBindingSource1, "IDCategoria", true));
            this.cbCategoria.DataSource = this.CategoriaBindingSource;
            this.cbCategoria.DisplayMember = "Nombre";
            this.cbCategoria.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.ForeColor = System.Drawing.Color.White;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(529, 35);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(140, 24);
            this.cbCategoria.TabIndex = 26;
            this.cbCategoria.ValueMember = "IDCategoria";
            // 
            // CategoriaBindingSource
            // 
            this.CategoriaBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Categoria);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(582, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Id Categoria";
            this.label7.Visible = false;
            // 
            // txtIDCategoria
            // 
            this.txtIDCategoria.BackColor = System.Drawing.Color.Navy;
            this.txtIDCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "IDCategoria", true));
            this.txtIDCategoria.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDCategoria.ForeColor = System.Drawing.Color.White;
            this.txtIDCategoria.Location = new System.Drawing.Point(568, 166);
            this.txtIDCategoria.Name = "txtIDCategoria";
            this.txtIDCategoria.Size = new System.Drawing.Size(39, 27);
            this.txtIDCategoria.TabIndex = 25;
            this.txtIDCategoria.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nupTamanioPagina);
            this.panel1.Controls.Add(this.lbltotalPaginas);
            this.panel1.Controls.Add(this.nupPagina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(713, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 347);
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
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Navy;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(104, 320);
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
            this.btnNuevo.Location = new System.Drawing.Point(19, 320);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 25);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Navy;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(274, 320);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 25);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Visible = false;
            this.btnGuardar.Enter += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Navy;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(444, 320);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 25);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(359, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Navy;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(189, 320);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Maximo";
            // 
            // txtArticulo
            // 
            this.txtArticulo.BackColor = System.Drawing.Color.Navy;
            this.txtArticulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "IdArticulo", true));
            this.txtArticulo.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulo.ForeColor = System.Drawing.Color.White;
            this.txtArticulo.Location = new System.Drawing.Point(153, 30);
            this.txtArticulo.Name = "txtArticulo";
            this.txtArticulo.Size = new System.Drawing.Size(205, 27);
            this.txtArticulo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(77, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdArticulo";
            // 
            // grvArticulo
            // 
            this.grvArticulo.AllowUserToAddRows = false;
            this.grvArticulo.AllowUserToDeleteRows = false;
            this.grvArticulo.AutoGenerateColumns = false;
            this.grvArticulo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grvArticulo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvArticulo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(64)))));
            this.grvArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grvArticulo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.grvArticulo.ColumnHeadersHeight = 30;
            this.grvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdArticulo,
            this.IDCategoriaDataGridViewTextBoxColumn,
            this.IdProveedor,
            this.nombreDataGridViewTextBoxColumn,
            this.Codigo,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.Minimo,
            this.Maximo});
            this.grvArticulo.DataSource = this.ArticuloBindingSource;
            this.grvArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvArticulo.EnableHeadersVisualStyles = false;
            this.grvArticulo.GridColor = System.Drawing.Color.Black;
            this.grvArticulo.Location = new System.Drawing.Point(0, 0);
            this.grvArticulo.Name = "grvArticulo";
            this.grvArticulo.ReadOnly = true;
            this.grvArticulo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvArticulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.grvArticulo.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.grvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvArticulo.Size = new System.Drawing.Size(872, 174);
            this.grvArticulo.TabIndex = 1;
            this.grvArticulo.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvArticulo_ColumnHeaderMouseClick);
            this.grvArticulo.SelectionChanged += new System.EventHandler(this.grvArticulo_SelectionChanged);
            // 
            // IdArticulo
            // 
            this.IdArticulo.DataPropertyName = "IdArticulo";
            this.IdArticulo.HeaderText = "IdArticulo";
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            this.IdArticulo.Width = 92;
            // 
            // IDCategoriaDataGridViewTextBoxColumn
            // 
            this.IDCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IDCategoria";
            this.IDCategoriaDataGridViewTextBoxColumn.FillWeight = 200F;
            this.IDCategoriaDataGridViewTextBoxColumn.HeaderText = "IDCategoria";
            this.IDCategoriaDataGridViewTextBoxColumn.Name = "IDCategoriaDataGridViewTextBoxColumn";
            this.IDCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.IDCategoriaDataGridViewTextBoxColumn.Width = 110;
            // 
            // IdProveedor
            // 
            this.IdProveedor.DataPropertyName = "IdProveedor";
            this.IdProveedor.HeaderText = "IdProveedor";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Width = 112;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 86;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 80;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.DataPropertyName = "PrecioCompra";
            this.PrecioCompra.HeaderText = "PrecioCompra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Width = 129;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.DataPropertyName = "PrecioVenta";
            this.PrecioVenta.HeaderText = "PrecioVenta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 112;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 90;
            // 
            // Minimo
            // 
            this.Minimo.DataPropertyName = "Minimo";
            this.Minimo.HeaderText = "Minimo";
            this.Minimo.Name = "Minimo";
            this.Minimo.ReadOnly = true;
            this.Minimo.Width = 81;
            // 
            // Maximo
            // 
            this.Maximo.DataPropertyName = "Maximo";
            this.Maximo.HeaderText = "Maximo";
            this.Maximo.Name = "Maximo";
            this.Maximo.ReadOnly = true;
            this.Maximo.Width = 85;
            // 
            // ArticuloBindingSource
            // 
            this.ArticuloBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Articulo);
            this.ArticuloBindingSource.CurrentChanged += new System.EventHandler(this.ArticuloBindingSource_CurrentChanged);
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlFiltro.Controls.Add(this.txtMinimo);
            this.pnlFiltro.Controls.Add(this.txtMaximo);
            this.pnlFiltro.Controls.Add(this.txtPCompra);
            this.pnlFiltro.Controls.Add(this.txtPVenta);
            this.pnlFiltro.Controls.Add(this.txtCantidad);
            this.pnlFiltro.Controls.Add(this.btnImagen);
            this.pnlFiltro.Controls.Add(this.pbImagen);
            this.pnlFiltro.Controls.Add(this.label4);
            this.pnlFiltro.Controls.Add(this.label13);
            this.pnlFiltro.Controls.Add(this.label10);
            this.pnlFiltro.Controls.Add(this.label11);
            this.pnlFiltro.Controls.Add(this.textBox2);
            this.pnlFiltro.Controls.Add(this.label12);
            this.pnlFiltro.Controls.Add(this.textBox3);
            this.pnlFiltro.Controls.Add(this.label9);
            this.pnlFiltro.Controls.Add(this.txtIdProveedor);
            this.pnlFiltro.Controls.Add(this.lblProveedor);
            this.pnlFiltro.Controls.Add(this.cbProveedor);
            this.pnlFiltro.Controls.Add(this.panel1);
            this.pnlFiltro.Controls.Add(this.cerrar);
            this.pnlFiltro.Controls.Add(this.label8);
            this.pnlFiltro.Controls.Add(this.lblTArticulo);
            this.pnlFiltro.Controls.Add(this.label1);
            this.pnlFiltro.Controls.Add(this.cbCategoria);
            this.pnlFiltro.Controls.Add(this.txtArticulo);
            this.pnlFiltro.Controls.Add(this.label7);
            this.pnlFiltro.Controls.Add(this.label2);
            this.pnlFiltro.Controls.Add(this.txtIDCategoria);
            this.pnlFiltro.Controls.Add(this.label3);
            this.pnlFiltro.Controls.Add(this.btnEditar);
            this.pnlFiltro.Controls.Add(this.btnNuevo);
            this.pnlFiltro.Controls.Add(this.btnBuscar);
            this.pnlFiltro.Controls.Add(this.btnGuardar);
            this.pnlFiltro.Controls.Add(this.btnCancelar);
            this.pnlFiltro.Controls.Add(this.btnEliminar);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(872, 347);
            this.pnlFiltro.TabIndex = 2;
            // 
            // txtMinimo
            // 
            this.txtMinimo.BackColor = System.Drawing.Color.Navy;
            this.txtMinimo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "Minimo", true));
            this.txtMinimo.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinimo.ForeColor = System.Drawing.Color.White;
            this.txtMinimo.Location = new System.Drawing.Point(153, 158);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(205, 27);
            this.txtMinimo.TabIndex = 55;
            this.txtMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMinimo_KeyPress);
            // 
            // txtMaximo
            // 
            this.txtMaximo.BackColor = System.Drawing.Color.Navy;
            this.txtMaximo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "Maximo", true));
            this.txtMaximo.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaximo.ForeColor = System.Drawing.Color.White;
            this.txtMaximo.Location = new System.Drawing.Point(153, 190);
            this.txtMaximo.Name = "txtMaximo";
            this.txtMaximo.Size = new System.Drawing.Size(205, 27);
            this.txtMaximo.TabIndex = 54;
            this.txtMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaximo_KeyPress);
            // 
            // txtPCompra
            // 
            this.txtPCompra.BackColor = System.Drawing.Color.Navy;
            this.txtPCompra.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "PrecioCompra", true));
            this.txtPCompra.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPCompra.ForeColor = System.Drawing.Color.White;
            this.txtPCompra.Location = new System.Drawing.Point(153, 222);
            this.txtPCompra.Name = "txtPCompra";
            this.txtPCompra.Size = new System.Drawing.Size(205, 27);
            this.txtPCompra.TabIndex = 53;
            this.txtPCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPCompra_KeyPress);
            // 
            // txtPVenta
            // 
            this.txtPVenta.BackColor = System.Drawing.Color.Navy;
            this.txtPVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "PrecioVenta", true));
            this.txtPVenta.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPVenta.ForeColor = System.Drawing.Color.White;
            this.txtPVenta.Location = new System.Drawing.Point(153, 254);
            this.txtPVenta.Name = "txtPVenta";
            this.txtPVenta.Size = new System.Drawing.Size(205, 27);
            this.txtPVenta.TabIndex = 52;
            this.txtPVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPVenta_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Navy;
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "Cantidad", true));
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.Location = new System.Drawing.Point(153, 126);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(205, 27);
            this.txtCantidad.TabIndex = 51;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.Navy;
            this.btnImagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImagen.ForeColor = System.Drawing.Color.White;
            this.btnImagen.Location = new System.Drawing.Point(385, 241);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(202, 25);
            this.btnImagen.TabIndex = 50;
            this.btnImagen.Text = "Seleccionar imagen";
            this.btnImagen.UseVisualStyleBackColor = false;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(385, 103);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(159, 132);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 49;
            this.pbImagen.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(150, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Articulos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(58, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 17);
            this.label13.TabIndex = 41;
            this.label13.Text = "Precio venta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(88, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(94, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 35;
            this.label11.Text = "Codigo";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Navy;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "Nombre", true));
            this.textBox2.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(153, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 27);
            this.textBox2.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(81, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 17);
            this.label12.TabIndex = 37;
            this.label12.Text = "Cantidad";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Navy;
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "Codigo", true));
            this.textBox3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(153, 94);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 27);
            this.textBox3.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(580, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Id proveedor";
            this.label9.Visible = false;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BackColor = System.Drawing.Color.Navy;
            this.txtIdProveedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ArticuloBindingSource1, "IdProveedor", true));
            this.txtIdProveedor.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.ForeColor = System.Drawing.Color.White;
            this.txtIdProveedor.Location = new System.Drawing.Point(598, 127);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(71, 27);
            this.txtIdProveedor.TabIndex = 34;
            this.txtIdProveedor.Visible = false;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.Location = new System.Drawing.Point(394, 72);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(74, 17);
            this.lblProveedor.TabIndex = 32;
            this.lblProveedor.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.BackColor = System.Drawing.Color.Navy;
            this.cbProveedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ArticuloBindingSource1, "IdProveedor", true));
            this.cbProveedor.DataSource = this.ProveedorBindingSource;
            this.cbProveedor.DisplayMember = "Nombre";
            this.cbProveedor.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProveedor.ForeColor = System.Drawing.Color.White;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(529, 65);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(140, 24);
            this.cbProveedor.TabIndex = 31;
            this.cbProveedor.ValueMember = "IdProveedor";
            // 
            // ProveedorBindingSource
            // 
            this.ProveedorBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Proveedor);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnlFiltro);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grvArticulo);
            this.splitContainer1.Size = new System.Drawing.Size(872, 525);
            this.splitContainer1.SplitterDistance = 347;
            this.splitContainer1.TabIndex = 3;
            // 
            // opfImagen
            // 
            this.opfImagen.FileName = "ofdImagen";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(872, 525);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmArticulo";
            this.Text = "Articulo";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).EndInit();
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grvArticulo;
        private System.Windows.Forms.BindingSource ArticuloBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ArticuloBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltotalPaginas;
        private System.Windows.Forms.NumericUpDown nupPagina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupTamanioPagina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDCategoria;
        private System.Windows.Forms.Label lblTArticulo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.BindingSource CategoriaBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource ProveedorBindingSource;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maximo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.OpenFileDialog opfImagen;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtMinimo;
        private System.Windows.Forms.TextBox txtMaximo;
        private System.Windows.Forms.TextBox txtPCompra;
        private System.Windows.Forms.TextBox txtPVenta;
        private System.Windows.Forms.TextBox txtCantidad;
    }
}