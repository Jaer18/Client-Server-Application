namespace Cliente
{
    partial class FormCliente
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageRegCajero = new System.Windows.Forms.TabPage();
            this.btnRegistrarCajero = new System.Windows.Forms.Button();
            this.cmbCajeroActivo = new System.Windows.Forms.ComboBox();
            this.txtCajeroCaja = new System.Windows.Forms.TextBox();
            this.txtCajeroSegundoAp = new System.Windows.Forms.TextBox();
            this.txtCajeroPrimerAp = new System.Windows.Forms.TextBox();
            this.txtCajeroNombre = new System.Windows.Forms.TextBox();
            this.txtCajeroUsuario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageRegVenta = new System.Windows.Forms.TabPage();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.txtVentaCantProd = new System.Windows.Forms.TextBox();
            this.txtVentaCodProd = new System.Windows.Forms.TextBox();
            this.dtpVentaFecha = new System.Windows.Forms.DateTimePicker();
            this.txtVentaUsuario = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInicioSesion = new System.Windows.Forms.TextBox();
            this.btnInicioSesion = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageRegCajero.SuspendLayout();
            this.tabPageRegVenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageRegCajero);
            this.tabControlMain.Controls.Add(this.tabPageRegVenta);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(634, 323);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPageRegCajero
            // 
            this.tabPageRegCajero.Controls.Add(this.btnInicioSesion);
            this.tabPageRegCajero.Controls.Add(this.txtInicioSesion);
            this.tabPageRegCajero.Controls.Add(this.label12);
            this.tabPageRegCajero.Controls.Add(this.label10);
            this.tabPageRegCajero.Controls.Add(this.btnRegistrarCajero);
            this.tabPageRegCajero.Controls.Add(this.cmbCajeroActivo);
            this.tabPageRegCajero.Controls.Add(this.txtCajeroCaja);
            this.tabPageRegCajero.Controls.Add(this.txtCajeroSegundoAp);
            this.tabPageRegCajero.Controls.Add(this.txtCajeroPrimerAp);
            this.tabPageRegCajero.Controls.Add(this.txtCajeroNombre);
            this.tabPageRegCajero.Controls.Add(this.txtCajeroUsuario);
            this.tabPageRegCajero.Controls.Add(this.label6);
            this.tabPageRegCajero.Controls.Add(this.label5);
            this.tabPageRegCajero.Controls.Add(this.label4);
            this.tabPageRegCajero.Controls.Add(this.label3);
            this.tabPageRegCajero.Controls.Add(this.label2);
            this.tabPageRegCajero.Controls.Add(this.label1);
            this.tabPageRegCajero.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegCajero.Name = "tabPageRegCajero";
            this.tabPageRegCajero.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegCajero.Size = new System.Drawing.Size(626, 297);
            this.tabPageRegCajero.TabIndex = 0;
            this.tabPageRegCajero.Text = "Registrar Cajero/Iniciar Sesión";
            this.tabPageRegCajero.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarCajero
            // 
            this.btnRegistrarCajero.Location = new System.Drawing.Point(33, 261);
            this.btnRegistrarCajero.Name = "btnRegistrarCajero";
            this.btnRegistrarCajero.Size = new System.Drawing.Size(151, 30);
            this.btnRegistrarCajero.TabIndex = 12;
            this.btnRegistrarCajero.Text = "Registrar Cajero";
            this.btnRegistrarCajero.UseVisualStyleBackColor = true;
            this.btnRegistrarCajero.Click += new System.EventHandler(this.btnRegistrarCajero_Click);
            // 
            // cmbCajeroActivo
            // 
            this.cmbCajeroActivo.FormattingEnabled = true;
            this.cmbCajeroActivo.Items.AddRange(new object[] {
            "True",
            "False"});
            this.cmbCajeroActivo.Location = new System.Drawing.Point(109, 220);
            this.cmbCajeroActivo.Name = "cmbCajeroActivo";
            this.cmbCajeroActivo.Size = new System.Drawing.Size(121, 21);
            this.cmbCajeroActivo.TabIndex = 11;
            // 
            // txtCajeroCaja
            // 
            this.txtCajeroCaja.Location = new System.Drawing.Point(109, 176);
            this.txtCajeroCaja.Name = "txtCajeroCaja";
            this.txtCajeroCaja.Size = new System.Drawing.Size(172, 20);
            this.txtCajeroCaja.TabIndex = 10;
            // 
            // txtCajeroSegundoAp
            // 
            this.txtCajeroSegundoAp.Location = new System.Drawing.Point(109, 132);
            this.txtCajeroSegundoAp.Name = "txtCajeroSegundoAp";
            this.txtCajeroSegundoAp.Size = new System.Drawing.Size(172, 20);
            this.txtCajeroSegundoAp.TabIndex = 9;
            // 
            // txtCajeroPrimerAp
            // 
            this.txtCajeroPrimerAp.Location = new System.Drawing.Point(109, 87);
            this.txtCajeroPrimerAp.Name = "txtCajeroPrimerAp";
            this.txtCajeroPrimerAp.Size = new System.Drawing.Size(172, 20);
            this.txtCajeroPrimerAp.TabIndex = 8;
            // 
            // txtCajeroNombre
            // 
            this.txtCajeroNombre.Location = new System.Drawing.Point(109, 47);
            this.txtCajeroNombre.Name = "txtCajeroNombre";
            this.txtCajeroNombre.Size = new System.Drawing.Size(172, 20);
            this.txtCajeroNombre.TabIndex = 7;
            // 
            // txtCajeroUsuario
            // 
            this.txtCajeroUsuario.Location = new System.Drawing.Point(109, 10);
            this.txtCajeroUsuario.Name = "txtCajeroUsuario";
            this.txtCajeroUsuario.Size = new System.Drawing.Size(172, 20);
            this.txtCajeroUsuario.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Activo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Caja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de usuario";
            // 
            // tabPageRegVenta
            // 
            this.tabPageRegVenta.Controls.Add(this.btnRegistrarVenta);
            this.tabPageRegVenta.Controls.Add(this.txtVentaCantProd);
            this.tabPageRegVenta.Controls.Add(this.txtVentaCodProd);
            this.tabPageRegVenta.Controls.Add(this.dtpVentaFecha);
            this.tabPageRegVenta.Controls.Add(this.txtVentaUsuario);
            this.tabPageRegVenta.Controls.Add(this.label11);
            this.tabPageRegVenta.Controls.Add(this.label9);
            this.tabPageRegVenta.Controls.Add(this.label8);
            this.tabPageRegVenta.Controls.Add(this.label7);
            this.tabPageRegVenta.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegVenta.Name = "tabPageRegVenta";
            this.tabPageRegVenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegVenta.Size = new System.Drawing.Size(626, 297);
            this.tabPageRegVenta.TabIndex = 1;
            this.tabPageRegVenta.Text = "Registrar Venta";
            this.tabPageRegVenta.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(111, 214);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(111, 36);
            this.btnRegistrarVenta.TabIndex = 10;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // txtVentaCantProd
            // 
            this.txtVentaCantProd.Location = new System.Drawing.Point(187, 129);
            this.txtVentaCantProd.Name = "txtVentaCantProd";
            this.txtVentaCantProd.Size = new System.Drawing.Size(200, 20);
            this.txtVentaCantProd.TabIndex = 9;
            // 
            // txtVentaCodProd
            // 
            this.txtVentaCodProd.Location = new System.Drawing.Point(187, 86);
            this.txtVentaCodProd.Name = "txtVentaCodProd";
            this.txtVentaCodProd.Size = new System.Drawing.Size(200, 20);
            this.txtVentaCodProd.TabIndex = 7;
            // 
            // dtpVentaFecha
            // 
            this.dtpVentaFecha.Location = new System.Drawing.Point(187, 51);
            this.dtpVentaFecha.Name = "dtpVentaFecha";
            this.dtpVentaFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpVentaFecha.TabIndex = 6;
            this.dtpVentaFecha.Value = new System.DateTime(2020, 8, 21, 0, 0, 0, 0);
            // 
            // txtVentaUsuario
            // 
            this.txtVentaUsuario.Location = new System.Drawing.Point(187, 18);
            this.txtVentaUsuario.Name = "txtVentaUsuario";
            this.txtVentaUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtVentaUsuario.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cantidad del producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Código del producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código de usuario";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(125, 341);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(119, 23);
            this.btnConectar.TabIndex = 13;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(274, 341);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(119, 23);
            this.btnDesconectar.TabIndex = 14;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(432, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Iniciar Sesión";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(339, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Código de usuario autorizado";
            // 
            // txtInicioSesion
            // 
            this.txtInicioSesion.Location = new System.Drawing.Point(489, 62);
            this.txtInicioSesion.Name = "txtInicioSesion";
            this.txtInicioSesion.Size = new System.Drawing.Size(131, 20);
            this.txtInicioSesion.TabIndex = 15;
            // 
            // btnInicioSesion
            // 
            this.btnInicioSesion.Location = new System.Drawing.Point(400, 108);
            this.btnInicioSesion.Name = "btnInicioSesion";
            this.btnInicioSesion.Size = new System.Drawing.Size(151, 30);
            this.btnInicioSesion.TabIndex = 16;
            this.btnInicioSesion.Text = "Iniciar Sesión";
            this.btnInicioSesion.UseVisualStyleBackColor = true;
            this.btnInicioSesion.Click += new System.EventHandler(this.btnInicioSesion_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 374);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormCliente";
            this.Text = "Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCliente_FormClosing);
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageRegCajero.ResumeLayout(false);
            this.tabPageRegCajero.PerformLayout();
            this.tabPageRegVenta.ResumeLayout(false);
            this.tabPageRegVenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageRegCajero;
        private System.Windows.Forms.TabPage tabPageRegVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCajeroUsuario;
        private System.Windows.Forms.TextBox txtCajeroNombre;
        private System.Windows.Forms.TextBox txtCajeroPrimerAp;
        private System.Windows.Forms.TextBox txtCajeroSegundoAp;
        private System.Windows.Forms.TextBox txtCajeroCaja;
        private System.Windows.Forms.ComboBox cmbCajeroActivo;
        private System.Windows.Forms.Button btnRegistrarCajero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVentaUsuario;
        private System.Windows.Forms.DateTimePicker dtpVentaFecha;
        private System.Windows.Forms.TextBox txtVentaCodProd;
        private System.Windows.Forms.TextBox txtVentaCantProd;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.TextBox txtInicioSesion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInicioSesion;
    }
}

