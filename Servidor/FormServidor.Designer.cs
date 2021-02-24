namespace Servidor
{
    partial class FormServidor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCajerosConectados = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCajero = new System.Windows.Forms.TabPage();
            this.btnAutorizarCajero = new System.Windows.Forms.Button();
            this.txtCajeroCaja = new System.Windows.Forms.TextBox();
            this.txtCajeroUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCajeros = new System.Windows.Forms.DataGridView();
            this.btnMostrarCajeros = new System.Windows.Forms.Button();
            this.tabPageCateg_Prod = new System.Windows.Forms.TabPage();
            this.btnInsertarProd = new System.Windows.Forms.Button();
            this.txtProdCodCateg = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProdCantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProdPrecio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtProdDescrip = new System.Windows.Forms.TextBox();
            this.txtProdCod = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInsertarCateg = new System.Windows.Forms.Button();
            this.txtCategDescrip = new System.Windows.Forms.TextBox();
            this.txtCategCod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageConsultProdCateg = new System.Windows.Forms.TabPage();
            this.btnMostrarProd = new System.Windows.Forms.Button();
            this.btnMostrarCateg = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPageActProd = new System.Windows.Forms.TabPage();
            this.btnActPrecio = new System.Windows.Forms.Button();
            this.btnActDescrip = new System.Windows.Forms.Button();
            this.btnActCantidad = new System.Windows.Forms.Button();
            this.txtActProdPrecio = new System.Windows.Forms.TextBox();
            this.txtActProdDescrip = new System.Windows.Forms.TextBox();
            this.txtActProdCant = new System.Windows.Forms.TextBox();
            this.txtActProdCod = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageConsultarVentas = new System.Windows.Forms.TabPage();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.btnMostrarVentas = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBitacora = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageCajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).BeginInit();
            this.tabPageCateg_Prod.SuspendLayout();
            this.tabPageConsultProdCateg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.tabPageActProd.SuspendLayout();
            this.tabPageConsultarVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCajerosConectados
            // 
            this.lbCajerosConectados.AutoSize = true;
            this.lbCajerosConectados.Location = new System.Drawing.Point(755, 79);
            this.lbCajerosConectados.Name = "lbCajerosConectados";
            this.lbCajerosConectados.Size = new System.Drawing.Size(105, 13);
            this.lbCajerosConectados.TabIndex = 2;
            this.lbCajerosConectados.Text = "Cajeros Conectados:";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageCajero);
            this.tabControlMain.Controls.Add(this.tabPageCateg_Prod);
            this.tabControlMain.Controls.Add(this.tabPageConsultProdCateg);
            this.tabControlMain.Controls.Add(this.tabPageActProd);
            this.tabControlMain.Controls.Add(this.tabPageConsultarVentas);
            this.tabControlMain.Location = new System.Drawing.Point(12, 26);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(726, 332);
            this.tabControlMain.TabIndex = 3;
            // 
            // tabPageCajero
            // 
            this.tabPageCajero.Controls.Add(this.btnAutorizarCajero);
            this.tabPageCajero.Controls.Add(this.txtCajeroCaja);
            this.tabPageCajero.Controls.Add(this.txtCajeroUsuario);
            this.tabPageCajero.Controls.Add(this.label3);
            this.tabPageCajero.Controls.Add(this.label2);
            this.tabPageCajero.Controls.Add(this.label1);
            this.tabPageCajero.Controls.Add(this.dgvCajeros);
            this.tabPageCajero.Controls.Add(this.btnMostrarCajeros);
            this.tabPageCajero.Location = new System.Drawing.Point(4, 22);
            this.tabPageCajero.Name = "tabPageCajero";
            this.tabPageCajero.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCajero.Size = new System.Drawing.Size(718, 306);
            this.tabPageCajero.TabIndex = 0;
            this.tabPageCajero.Text = "Autorizar Cajeros";
            this.tabPageCajero.UseVisualStyleBackColor = true;
            // 
            // btnAutorizarCajero
            // 
            this.btnAutorizarCajero.Location = new System.Drawing.Point(549, 149);
            this.btnAutorizarCajero.Name = "btnAutorizarCajero";
            this.btnAutorizarCajero.Size = new System.Drawing.Size(112, 30);
            this.btnAutorizarCajero.TabIndex = 8;
            this.btnAutorizarCajero.Text = "Autorizar Cajero";
            this.btnAutorizarCajero.UseVisualStyleBackColor = true;
            this.btnAutorizarCajero.Click += new System.EventHandler(this.btnAutorizarCajero_Click);
            // 
            // txtCajeroCaja
            // 
            this.txtCajeroCaja.Location = new System.Drawing.Point(599, 89);
            this.txtCajeroCaja.Name = "txtCajeroCaja";
            this.txtCajeroCaja.Size = new System.Drawing.Size(100, 20);
            this.txtCajeroCaja.TabIndex = 7;
            // 
            // txtCajeroUsuario
            // 
            this.txtCajeroUsuario.Location = new System.Drawing.Point(599, 41);
            this.txtCajeroUsuario.Name = "txtCajeroUsuario";
            this.txtCajeroUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtCajeroUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caja Asignada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ususario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autorizar Cajeros";
            // 
            // dgvCajeros
            // 
            this.dgvCajeros.AllowUserToAddRows = false;
            this.dgvCajeros.AllowUserToDeleteRows = false;
            this.dgvCajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCajeros.Location = new System.Drawing.Point(6, 6);
            this.dgvCajeros.Name = "dgvCajeros";
            this.dgvCajeros.ReadOnly = true;
            this.dgvCajeros.Size = new System.Drawing.Size(477, 257);
            this.dgvCajeros.TabIndex = 2;
            // 
            // btnMostrarCajeros
            // 
            this.btnMostrarCajeros.Location = new System.Drawing.Point(178, 269);
            this.btnMostrarCajeros.Name = "btnMostrarCajeros";
            this.btnMostrarCajeros.Size = new System.Drawing.Size(122, 23);
            this.btnMostrarCajeros.TabIndex = 1;
            this.btnMostrarCajeros.Text = "Mostrar Cajeros";
            this.btnMostrarCajeros.UseVisualStyleBackColor = true;
            this.btnMostrarCajeros.Click += new System.EventHandler(this.btnMostrarCajeros_Click);
            // 
            // tabPageCateg_Prod
            // 
            this.tabPageCateg_Prod.Controls.Add(this.btnInsertarProd);
            this.tabPageCateg_Prod.Controls.Add(this.txtProdCodCateg);
            this.tabPageCateg_Prod.Controls.Add(this.label12);
            this.tabPageCateg_Prod.Controls.Add(this.txtProdCantidad);
            this.tabPageCateg_Prod.Controls.Add(this.label11);
            this.tabPageCateg_Prod.Controls.Add(this.txtProdPrecio);
            this.tabPageCateg_Prod.Controls.Add(this.label10);
            this.tabPageCateg_Prod.Controls.Add(this.txtProdDescrip);
            this.tabPageCateg_Prod.Controls.Add(this.txtProdCod);
            this.tabPageCateg_Prod.Controls.Add(this.label9);
            this.tabPageCateg_Prod.Controls.Add(this.label8);
            this.tabPageCateg_Prod.Controls.Add(this.btnInsertarCateg);
            this.tabPageCateg_Prod.Controls.Add(this.txtCategDescrip);
            this.tabPageCateg_Prod.Controls.Add(this.txtCategCod);
            this.tabPageCateg_Prod.Controls.Add(this.label7);
            this.tabPageCateg_Prod.Controls.Add(this.label6);
            this.tabPageCateg_Prod.Controls.Add(this.label5);
            this.tabPageCateg_Prod.Controls.Add(this.label4);
            this.tabPageCateg_Prod.Location = new System.Drawing.Point(4, 22);
            this.tabPageCateg_Prod.Name = "tabPageCateg_Prod";
            this.tabPageCateg_Prod.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCateg_Prod.Size = new System.Drawing.Size(718, 306);
            this.tabPageCateg_Prod.TabIndex = 1;
            this.tabPageCateg_Prod.Text = "Agregar Categoria/Producto";
            this.tabPageCateg_Prod.UseVisualStyleBackColor = true;
            // 
            // btnInsertarProd
            // 
            this.btnInsertarProd.Location = new System.Drawing.Point(510, 249);
            this.btnInsertarProd.Name = "btnInsertarProd";
            this.btnInsertarProd.Size = new System.Drawing.Size(108, 29);
            this.btnInsertarProd.TabIndex = 17;
            this.btnInsertarProd.Text = "Agregar Producto";
            this.btnInsertarProd.UseVisualStyleBackColor = true;
            this.btnInsertarProd.Click += new System.EventHandler(this.btnInsertarProd_Click);
            // 
            // txtProdCodCateg
            // 
            this.txtProdCodCateg.Location = new System.Drawing.Point(574, 204);
            this.txtProdCodCateg.Name = "txtProdCodCateg";
            this.txtProdCodCateg.Size = new System.Drawing.Size(100, 20);
            this.txtProdCodCateg.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(441, 211);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Código de Categoría";
            // 
            // txtProdCantidad
            // 
            this.txtProdCantidad.Location = new System.Drawing.Point(574, 162);
            this.txtProdCantidad.Name = "txtProdCantidad";
            this.txtProdCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtProdCantidad.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Cantidad";
            // 
            // txtProdPrecio
            // 
            this.txtProdPrecio.Location = new System.Drawing.Point(574, 123);
            this.txtProdPrecio.Name = "txtProdPrecio";
            this.txtProdPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtProdPrecio.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(441, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Precio";
            // 
            // txtProdDescrip
            // 
            this.txtProdDescrip.Location = new System.Drawing.Point(574, 83);
            this.txtProdDescrip.Name = "txtProdDescrip";
            this.txtProdDescrip.Size = new System.Drawing.Size(100, 20);
            this.txtProdDescrip.TabIndex = 10;
            // 
            // txtProdCod
            // 
            this.txtProdCod.Location = new System.Drawing.Point(574, 44);
            this.txtProdCod.Name = "txtProdCod";
            this.txtProdCod.Size = new System.Drawing.Size(100, 20);
            this.txtProdCod.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(441, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Descripción";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Código";
            // 
            // btnInsertarCateg
            // 
            this.btnInsertarCateg.Location = new System.Drawing.Point(65, 140);
            this.btnInsertarCateg.Name = "btnInsertarCateg";
            this.btnInsertarCateg.Size = new System.Drawing.Size(108, 29);
            this.btnInsertarCateg.TabIndex = 6;
            this.btnInsertarCateg.Text = "Agregar Categoría";
            this.btnInsertarCateg.UseVisualStyleBackColor = true;
            this.btnInsertarCateg.Click += new System.EventHandler(this.btnInsertarCateg_Click);
            // 
            // txtCategDescrip
            // 
            this.txtCategDescrip.Location = new System.Drawing.Point(114, 83);
            this.txtCategDescrip.Name = "txtCategDescrip";
            this.txtCategDescrip.Size = new System.Drawing.Size(100, 20);
            this.txtCategDescrip.TabIndex = 5;
            // 
            // txtCategCod
            // 
            this.txtCategCod.Location = new System.Drawing.Point(114, 44);
            this.txtCategCod.Name = "txtCategCod";
            this.txtCategCod.Size = new System.Drawing.Size(100, 20);
            this.txtCategCod.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Descripción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Código";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Agregar Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Agregar Categoría";
            // 
            // tabPageConsultProdCateg
            // 
            this.tabPageConsultProdCateg.Controls.Add(this.btnMostrarProd);
            this.tabPageConsultProdCateg.Controls.Add(this.btnMostrarCateg);
            this.tabPageConsultProdCateg.Controls.Add(this.dgvProductos);
            this.tabPageConsultProdCateg.Controls.Add(this.dgvCategorias);
            this.tabPageConsultProdCateg.Controls.Add(this.label14);
            this.tabPageConsultProdCateg.Controls.Add(this.label13);
            this.tabPageConsultProdCateg.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultProdCateg.Name = "tabPageConsultProdCateg";
            this.tabPageConsultProdCateg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultProdCateg.Size = new System.Drawing.Size(718, 306);
            this.tabPageConsultProdCateg.TabIndex = 2;
            this.tabPageConsultProdCateg.Text = "Consultar Categorías/Productos";
            this.tabPageConsultProdCateg.UseVisualStyleBackColor = true;
            // 
            // btnMostrarProd
            // 
            this.btnMostrarProd.Location = new System.Drawing.Point(438, 262);
            this.btnMostrarProd.Name = "btnMostrarProd";
            this.btnMostrarProd.Size = new System.Drawing.Size(124, 23);
            this.btnMostrarProd.TabIndex = 5;
            this.btnMostrarProd.Text = "Mostrar Productos";
            this.btnMostrarProd.UseVisualStyleBackColor = true;
            this.btnMostrarProd.Click += new System.EventHandler(this.btnMostrarProd_Click);
            // 
            // btnMostrarCateg
            // 
            this.btnMostrarCateg.Location = new System.Drawing.Point(50, 262);
            this.btnMostrarCateg.Name = "btnMostrarCateg";
            this.btnMostrarCateg.Size = new System.Drawing.Size(124, 23);
            this.btnMostrarCateg.TabIndex = 4;
            this.btnMostrarCateg.Text = "Mostrar Categorías";
            this.btnMostrarCateg.UseVisualStyleBackColor = true;
            this.btnMostrarCateg.Click += new System.EventHandler(this.btnMostrarCateg_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(270, 28);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(442, 228);
            this.dgvProductos.TabIndex = 3;
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.AllowUserToDeleteRows = false;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(6, 28);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.Size = new System.Drawing.Size(240, 228);
            this.dgvCategorias.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(469, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Productos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Categorías";
            // 
            // tabPageActProd
            // 
            this.tabPageActProd.Controls.Add(this.btnActPrecio);
            this.tabPageActProd.Controls.Add(this.btnActDescrip);
            this.tabPageActProd.Controls.Add(this.btnActCantidad);
            this.tabPageActProd.Controls.Add(this.txtActProdPrecio);
            this.tabPageActProd.Controls.Add(this.txtActProdDescrip);
            this.tabPageActProd.Controls.Add(this.txtActProdCant);
            this.tabPageActProd.Controls.Add(this.txtActProdCod);
            this.tabPageActProd.Controls.Add(this.label18);
            this.tabPageActProd.Controls.Add(this.label17);
            this.tabPageActProd.Controls.Add(this.label16);
            this.tabPageActProd.Controls.Add(this.label15);
            this.tabPageActProd.Location = new System.Drawing.Point(4, 22);
            this.tabPageActProd.Name = "tabPageActProd";
            this.tabPageActProd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageActProd.Size = new System.Drawing.Size(718, 306);
            this.tabPageActProd.TabIndex = 3;
            this.tabPageActProd.Text = "Actualizar Productos";
            this.tabPageActProd.UseVisualStyleBackColor = true;
            // 
            // btnActPrecio
            // 
            this.btnActPrecio.Location = new System.Drawing.Point(452, 234);
            this.btnActPrecio.Name = "btnActPrecio";
            this.btnActPrecio.Size = new System.Drawing.Size(107, 23);
            this.btnActPrecio.TabIndex = 10;
            this.btnActPrecio.Text = "Actualizar Precio";
            this.btnActPrecio.UseVisualStyleBackColor = true;
            this.btnActPrecio.Click += new System.EventHandler(this.btnActPrecio_Click);
            // 
            // btnActDescrip
            // 
            this.btnActDescrip.Location = new System.Drawing.Point(307, 234);
            this.btnActDescrip.Name = "btnActDescrip";
            this.btnActDescrip.Size = new System.Drawing.Size(127, 23);
            this.btnActDescrip.TabIndex = 9;
            this.btnActDescrip.Text = "Actualizar Descripción";
            this.btnActDescrip.UseVisualStyleBackColor = true;
            this.btnActDescrip.Click += new System.EventHandler(this.btnActDescrip_Click);
            // 
            // btnActCantidad
            // 
            this.btnActCantidad.Location = new System.Drawing.Point(184, 234);
            this.btnActCantidad.Name = "btnActCantidad";
            this.btnActCantidad.Size = new System.Drawing.Size(107, 23);
            this.btnActCantidad.TabIndex = 8;
            this.btnActCantidad.Text = "Actualizar Cantidad";
            this.btnActCantidad.UseVisualStyleBackColor = true;
            this.btnActCantidad.Click += new System.EventHandler(this.btnActCantidad_Click);
            // 
            // txtActProdPrecio
            // 
            this.txtActProdPrecio.Location = new System.Drawing.Point(184, 159);
            this.txtActProdPrecio.Name = "txtActProdPrecio";
            this.txtActProdPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtActProdPrecio.TabIndex = 7;
            // 
            // txtActProdDescrip
            // 
            this.txtActProdDescrip.Location = new System.Drawing.Point(184, 114);
            this.txtActProdDescrip.Name = "txtActProdDescrip";
            this.txtActProdDescrip.Size = new System.Drawing.Size(100, 20);
            this.txtActProdDescrip.TabIndex = 6;
            // 
            // txtActProdCant
            // 
            this.txtActProdCant.Location = new System.Drawing.Point(184, 67);
            this.txtActProdCant.Name = "txtActProdCant";
            this.txtActProdCant.Size = new System.Drawing.Size(100, 20);
            this.txtActProdCant.TabIndex = 5;
            // 
            // txtActProdCod
            // 
            this.txtActProdCod.Location = new System.Drawing.Point(184, 23);
            this.txtActProdCod.Name = "txtActProdCod";
            this.txtActProdCod.Size = new System.Drawing.Size(100, 20);
            this.txtActProdCod.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Nuevo Precio";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 121);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "Nueva Descripción";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Cantidad en inventario";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(32, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Código del producto";
            // 
            // tabPageConsultarVentas
            // 
            this.tabPageConsultarVentas.Controls.Add(this.dgvVentas);
            this.tabPageConsultarVentas.Controls.Add(this.btnMostrarVentas);
            this.tabPageConsultarVentas.Controls.Add(this.label19);
            this.tabPageConsultarVentas.Location = new System.Drawing.Point(4, 22);
            this.tabPageConsultarVentas.Name = "tabPageConsultarVentas";
            this.tabPageConsultarVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConsultarVentas.Size = new System.Drawing.Size(718, 306);
            this.tabPageConsultarVentas.TabIndex = 4;
            this.tabPageConsultarVentas.Text = "Consultar Ventas";
            this.tabPageConsultarVentas.UseVisualStyleBackColor = true;
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Location = new System.Drawing.Point(21, 28);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(674, 241);
            this.dgvVentas.TabIndex = 3;
            // 
            // btnMostrarVentas
            // 
            this.btnMostrarVentas.Location = new System.Drawing.Point(259, 275);
            this.btnMostrarVentas.Name = "btnMostrarVentas";
            this.btnMostrarVentas.Size = new System.Drawing.Size(124, 23);
            this.btnMostrarVentas.TabIndex = 2;
            this.btnMostrarVentas.Text = "Mostrar Ventas";
            this.btnMostrarVentas.UseVisualStyleBackColor = true;
            this.btnMostrarVentas.Click += new System.EventHandler(this.btnMostrarVentas_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(297, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Ventas";
            // 
            // txtBitacora
            // 
            this.txtBitacora.Location = new System.Drawing.Point(758, 108);
            this.txtBitacora.Multiline = true;
            this.txtBitacora.Name = "txtBitacora";
            this.txtBitacora.ReadOnly = true;
            this.txtBitacora.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBitacora.Size = new System.Drawing.Size(257, 246);
            this.txtBitacora.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(843, 54);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Bitácora";
            // 
            // FormServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 370);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtBitacora);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.lbCajerosConectados);
            this.Name = "FormServidor";
            this.Text = "Servidor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ServidorForm_FormClosing);
            this.Load += new System.EventHandler(this.FormServidor_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCajero.ResumeLayout(false);
            this.tabPageCajero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCajeros)).EndInit();
            this.tabPageCateg_Prod.ResumeLayout(false);
            this.tabPageCateg_Prod.PerformLayout();
            this.tabPageConsultProdCateg.ResumeLayout(false);
            this.tabPageConsultProdCateg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.tabPageActProd.ResumeLayout(false);
            this.tabPageActProd.PerformLayout();
            this.tabPageConsultarVentas.ResumeLayout(false);
            this.tabPageConsultarVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbCajerosConectados;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCajero;
        private System.Windows.Forms.TabPage tabPageCateg_Prod;
        private System.Windows.Forms.Button btnMostrarCajeros;
        private System.Windows.Forms.DataGridView dgvCajeros;
        private System.Windows.Forms.TextBox txtCajeroCaja;
        private System.Windows.Forms.TextBox txtCajeroUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAutorizarCajero;
        private System.Windows.Forms.TabPage tabPageConsultProdCateg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCategDescrip;
        private System.Windows.Forms.TextBox txtCategCod;
        private System.Windows.Forms.Button btnInsertarCateg;
        private System.Windows.Forms.TextBox txtProdCod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProdDescrip;
        private System.Windows.Forms.TextBox txtProdPrecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProdCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProdCodCateg;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnInsertarProd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnMostrarCateg;
        private System.Windows.Forms.Button btnMostrarProd;
        private System.Windows.Forms.TabPage tabPageActProd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtActProdCod;
        private System.Windows.Forms.TextBox txtActProdCant;
        private System.Windows.Forms.TextBox txtActProdDescrip;
        private System.Windows.Forms.TextBox txtActProdPrecio;
        private System.Windows.Forms.Button btnActCantidad;
        private System.Windows.Forms.Button btnActDescrip;
        private System.Windows.Forms.Button btnActPrecio;
        private System.Windows.Forms.TabPage tabPageConsultarVentas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnMostrarVentas;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.TextBox txtBitacora;
        private System.Windows.Forms.Label label20;
    }
}

