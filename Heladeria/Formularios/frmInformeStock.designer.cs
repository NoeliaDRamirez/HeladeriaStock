namespace Heladeria.Formularios
{
    partial class frmInformeStock
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
            this.lblInforme = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.ArticuloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.ProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nupTamanioPagina = new System.Windows.Forms.NumericUpDown();
            this.lbltotalPaginas = new System.Windows.Forms.Label();
            this.nupPagina = new System.Windows.Forms.NumericUpDown();
            this.cerrar = new System.Windows.Forms.Button();
            this.lblTArticulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.CategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtArticulo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ArticuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvArticulo = new System.Windows.Forms.DataGridView();
            this.idArticuloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFiltro
            // 
            this.pnlFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnlFiltro.Controls.Add(this.btnPdf);
            this.pnlFiltro.Controls.Add(this.lblInforme);
            this.pnlFiltro.Controls.Add(this.btnCancelar);
            this.pnlFiltro.Controls.Add(this.label4);
            this.pnlFiltro.Controls.Add(this.numericUpDown2);
            this.pnlFiltro.Controls.Add(this.label10);
            this.pnlFiltro.Controls.Add(this.label11);
            this.pnlFiltro.Controls.Add(this.textBox2);
            this.pnlFiltro.Controls.Add(this.label12);
            this.pnlFiltro.Controls.Add(this.textBox3);
            this.pnlFiltro.Controls.Add(this.lblProveedor);
            this.pnlFiltro.Controls.Add(this.cbProveedor);
            this.pnlFiltro.Controls.Add(this.panel1);
            this.pnlFiltro.Controls.Add(this.cerrar);
            this.pnlFiltro.Controls.Add(this.lblTArticulo);
            this.pnlFiltro.Controls.Add(this.label1);
            this.pnlFiltro.Controls.Add(this.cbCategoria);
            this.pnlFiltro.Controls.Add(this.txtArticulo);
            this.pnlFiltro.Controls.Add(this.btnBuscar);
            this.pnlFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnlFiltro.Name = "pnlFiltro";
            this.pnlFiltro.Size = new System.Drawing.Size(800, 287);
            this.pnlFiltro.TabIndex = 3;
            // 
            // btnPdf
            // 
            this.btnPdf.BackColor = System.Drawing.Color.Navy;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(474, 239);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(130, 25);
            this.btnPdf.TabIndex = 53;
            this.btnPdf.Text = "Guardar PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // lblInforme
            // 
            this.lblInforme.AutoSize = true;
            this.lblInforme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInforme.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInforme.ForeColor = System.Drawing.Color.White;
            this.lblInforme.Location = new System.Drawing.Point(150, 210);
            this.lblInforme.Name = "lblInforme";
            this.lblInforme.Size = new System.Drawing.Size(116, 17);
            this.lblInforme.TabIndex = 52;
            this.lblInforme.Text = "Informe de stock";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Navy;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(261, 239);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 25);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.Navy;
            this.numericUpDown2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ArticuloBindingSource1, "Cantidad", true));
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.White;
            this.numericUpDown2.Location = new System.Drawing.Point(153, 175);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 44;
            // 
            // ArticuloBindingSource1
            // 
            this.ArticuloBindingSource1.DataSource = typeof(Heladeria.Data.EntityFramework.Articulo);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(88, 127);
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
            this.label11.Location = new System.Drawing.Point(94, 156);
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
            this.textBox2.Location = new System.Drawing.Point(153, 117);
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
            this.label12.Location = new System.Drawing.Point(81, 180);
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
            this.textBox3.Location = new System.Drawing.Point(153, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(205, 27);
            this.textBox3.TabIndex = 38;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.Location = new System.Drawing.Point(73, 94);
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
            this.cbProveedor.Location = new System.Drawing.Point(153, 87);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(205, 24);
            this.cbProveedor.TabIndex = 31;
            this.cbProveedor.ValueMember = "IdProveedor";
            // 
            // ProveedorBindingSource
            // 
            this.ProveedorBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Proveedor);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nupTamanioPagina);
            this.panel1.Controls.Add(this.lbltotalPaginas);
            this.panel1.Controls.Add(this.nupPagina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(641, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 287);
            this.panel1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(40, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 67);
            this.button1.TabIndex = 50;
            this.button1.Text = "Generar Codigo QR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 219);
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
            this.label5.Location = new System.Drawing.Point(4, 156);
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
            this.nupTamanioPagina.Location = new System.Drawing.Point(7, 192);
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
            this.lbltotalPaginas.Location = new System.Drawing.Point(73, 239);
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
            this.nupPagina.Location = new System.Drawing.Point(7, 238);
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
            // lblTArticulo
            // 
            this.lblTArticulo.AutoSize = true;
            this.lblTArticulo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTArticulo.ForeColor = System.Drawing.Color.White;
            this.lblTArticulo.Location = new System.Drawing.Point(73, 70);
            this.lblTArticulo.Name = "lblTArticulo";
            this.lblTArticulo.Size = new System.Drawing.Size(71, 17);
            this.lblTArticulo.TabIndex = 27;
            this.lblTArticulo.Text = "Categoria";
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
            // cbCategoria
            // 
            this.cbCategoria.BackColor = System.Drawing.Color.Navy;
            this.cbCategoria.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ArticuloBindingSource1, "IDCategoria", true));
            this.cbCategoria.DataSource = this.CategoriaBindingSource;
            this.cbCategoria.DisplayMember = "Nombre";
            this.cbCategoria.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.ForeColor = System.Drawing.Color.White;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(153, 63);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(205, 24);
            this.cbCategoria.TabIndex = 26;
            this.cbCategoria.ValueMember = "IdCategoria";
            // 
            // CategoriaBindingSource
            // 
            this.CategoriaBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Categoria);
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
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Navy;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(153, 239);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 25);
            this.btnBuscar.TabIndex = 14;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ArticuloBindingSource
            // 
            this.ArticuloBindingSource.DataSource = typeof(Heladeria.Data.EntityFramework.Articulo);
            this.ArticuloBindingSource.CurrentChanged += new System.EventHandler(this.ArticuloBindingSource_CurrentChanged);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvArticulo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grvArticulo.ColumnHeadersHeight = 30;
            this.grvArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grvArticulo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArticuloDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.IDCategoria,
            this.idProveedorDataGridViewTextBoxColumn});
            this.grvArticulo.DataSource = this.ArticuloBindingSource;
            this.grvArticulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grvArticulo.EnableHeadersVisualStyles = false;
            this.grvArticulo.GridColor = System.Drawing.Color.Black;
            this.grvArticulo.Location = new System.Drawing.Point(0, 287);
            this.grvArticulo.Name = "grvArticulo";
            this.grvArticulo.ReadOnly = true;
            this.grvArticulo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grvArticulo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.grvArticulo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.grvArticulo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvArticulo.Size = new System.Drawing.Size(800, 163);
            this.grvArticulo.TabIndex = 4;
            this.grvArticulo.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grvArticulo_ColumnHeaderMouseClick);
            // 
            // idArticuloDataGridViewTextBoxColumn
            // 
            this.idArticuloDataGridViewTextBoxColumn.DataPropertyName = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.HeaderText = "IdArticulo";
            this.idArticuloDataGridViewTextBoxColumn.Name = "idArticuloDataGridViewTextBoxColumn";
            this.idArticuloDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArticuloDataGridViewTextBoxColumn.Width = 92;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 86;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 90;
            // 
            // IDCategoria
            // 
            this.IDCategoria.DataPropertyName = "IDCategoria";
            this.IDCategoria.HeaderText = "IDCategoria";
            this.IDCategoria.Name = "IDCategoria";
            this.IDCategoria.ReadOnly = true;
            this.IDCategoria.Width = 110;
            // 
            // idProveedorDataGridViewTextBoxColumn
            // 
            this.idProveedorDataGridViewTextBoxColumn.DataPropertyName = "IdProveedor";
            this.idProveedorDataGridViewTextBoxColumn.HeaderText = "IdProveedor";
            this.idProveedorDataGridViewTextBoxColumn.Name = "idProveedorDataGridViewTextBoxColumn";
            this.idProveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProveedorDataGridViewTextBoxColumn.Width = 112;
            // 
            // frmInformeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grvArticulo);
            this.Controls.Add(this.pnlFiltro);
            this.Name = "frmInformeStock";
            this.Text = "frmInformeStock";
            this.Load += new System.EventHandler(this.frmInformeStock_Load);
            this.pnlFiltro.ResumeLayout(false);
            this.pnlFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedorBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupTamanioPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPagina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArticuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupTamanioPagina;
        private System.Windows.Forms.Label lbltotalPaginas;
        private System.Windows.Forms.NumericUpDown nupPagina;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label lblTArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.TextBox txtArticulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView grvArticulo;
        private System.Windows.Forms.BindingSource ArticuloBindingSource;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.BindingSource ArticuloBindingSource1;
        private System.Windows.Forms.BindingSource CategoriaBindingSource;
        private System.Windows.Forms.BindingSource ProveedorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArticuloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblInforme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPdf;
    }
}