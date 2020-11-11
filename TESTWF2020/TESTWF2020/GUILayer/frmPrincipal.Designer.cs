namespace TESTWF2020
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inmueblesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planesFinanciacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediosDeConocimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viaDeConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeInmuebleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteInmuebleXConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaFinanciadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMedioConocimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsultarVentas = new System.Windows.Forms.Button();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblUsuarioLogeado = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPlanes = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnInmuebles = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.midPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::TESTWF2020.Properties.Resources.icons8_salida_96;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(1176, 4);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(89, 85);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soporteToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1811, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inmueblesToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.planesFinanciacionToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.mediosDeConocimientoToolStripMenuItem,
            this.viaDeConsultasToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.ventaGeneralToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(78, 26);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // inmueblesToolStripMenuItem
            // 
            this.inmueblesToolStripMenuItem.Name = "inmueblesToolStripMenuItem";
            this.inmueblesToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.inmueblesToolStripMenuItem.Text = "Inmuebles";
            this.inmueblesToolStripMenuItem.Click += new System.EventHandler(this.inmueblesToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // planesFinanciacionToolStripMenuItem
            // 
            this.planesFinanciacionToolStripMenuItem.Name = "planesFinanciacionToolStripMenuItem";
            this.planesFinanciacionToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.planesFinanciacionToolStripMenuItem.Text = "Planes Financiacion";
            this.planesFinanciacionToolStripMenuItem.Click += new System.EventHandler(this.planesFinanciacionToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // mediosDeConocimientoToolStripMenuItem
            // 
            this.mediosDeConocimientoToolStripMenuItem.Name = "mediosDeConocimientoToolStripMenuItem";
            this.mediosDeConocimientoToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.mediosDeConocimientoToolStripMenuItem.Text = "Medios de Conocimiento";
            this.mediosDeConocimientoToolStripMenuItem.Click += new System.EventHandler(this.mediosDeConocimientoToolStripMenuItem_Click);
            // 
            // viaDeConsultasToolStripMenuItem
            // 
            this.viaDeConsultasToolStripMenuItem.Name = "viaDeConsultasToolStripMenuItem";
            this.viaDeConsultasToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.viaDeConsultasToolStripMenuItem.Text = "Via de consultas";
            this.viaDeConsultasToolStripMenuItem.Click += new System.EventHandler(this.viaDeConsultasToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // ventaGeneralToolStripMenuItem
            // 
            this.ventaGeneralToolStripMenuItem.Name = "ventaGeneralToolStripMenuItem";
            this.ventaGeneralToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.ventaGeneralToolStripMenuItem.Text = "VentaGeneral";
            this.ventaGeneralToolStripMenuItem.Click += new System.EventHandler(this.ventaGeneralToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeInmuebleToolStripMenuItem,
            this.reporteDeVentasToolStripMenuItem,
            this.reporteInmuebleXConsultaToolStripMenuItem,
            this.cuotasToolStripMenuItem,
            this.empleadosToolStripMenuItem1,
            this.ventaFinanciadaToolStripMenuItem,
            this.vendedoresToolStripMenuItem,
            this.consultaMedioConocimientoToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(86, 26);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeInmuebleToolStripMenuItem
            // 
            this.reporteDeInmuebleToolStripMenuItem.Name = "reporteDeInmuebleToolStripMenuItem";
            this.reporteDeInmuebleToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.reporteDeInmuebleToolStripMenuItem.Text = "Reporte de inmueble";
            this.reporteDeInmuebleToolStripMenuItem.Click += new System.EventHandler(this.reporteDeInmuebleToolStripMenuItem_Click);
            // 
            // reporteDeVentasToolStripMenuItem
            // 
            this.reporteDeVentasToolStripMenuItem.Name = "reporteDeVentasToolStripMenuItem";
            this.reporteDeVentasToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.reporteDeVentasToolStripMenuItem.Text = "Reporte de ventas";
            this.reporteDeVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasToolStripMenuItem_Click);
            // 
            // reporteInmuebleXConsultaToolStripMenuItem
            // 
            this.reporteInmuebleXConsultaToolStripMenuItem.Name = "reporteInmuebleXConsultaToolStripMenuItem";
            this.reporteInmuebleXConsultaToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.reporteInmuebleXConsultaToolStripMenuItem.Text = "Reporte Inmueble x Consulta";
            this.reporteInmuebleXConsultaToolStripMenuItem.Click += new System.EventHandler(this.reporteInmuebleXConsultaToolStripMenuItem_Click);
            // 
            // cuotasToolStripMenuItem
            // 
            this.cuotasToolStripMenuItem.Name = "cuotasToolStripMenuItem";
            this.cuotasToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.cuotasToolStripMenuItem.Text = "Cuotas";
            this.cuotasToolStripMenuItem.Click += new System.EventHandler(this.cuotasToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem1
            // 
            this.empleadosToolStripMenuItem1.Name = "empleadosToolStripMenuItem1";
            this.empleadosToolStripMenuItem1.Size = new System.Drawing.Size(302, 26);
            this.empleadosToolStripMenuItem1.Text = "Empleados";
            this.empleadosToolStripMenuItem1.Click += new System.EventHandler(this.empleadosToolStripMenuItem1_Click);
            // 
            // ventaFinanciadaToolStripMenuItem
            // 
            this.ventaFinanciadaToolStripMenuItem.Name = "ventaFinanciadaToolStripMenuItem";
            this.ventaFinanciadaToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.ventaFinanciadaToolStripMenuItem.Text = "venta financiada";
            this.ventaFinanciadaToolStripMenuItem.Click += new System.EventHandler(this.ventaFinanciadaToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // consultaMedioConocimientoToolStripMenuItem
            // 
            this.consultaMedioConocimientoToolStripMenuItem.Name = "consultaMedioConocimientoToolStripMenuItem";
            this.consultaMedioConocimientoToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.consultaMedioConocimientoToolStripMenuItem.Text = "Consulta Medio Conocimiento";
            this.consultaMedioConocimientoToolStripMenuItem.Click += new System.EventHandler(this.consultaMedioConocimientoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(65)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.btnConsultarVentas);
            this.panel1.Controls.Add(this.lblLegajo);
            this.panel1.Controls.Add(this.lblUsuarioLogeado);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnPlanes);
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnConsultas);
            this.panel1.Controls.Add(this.btnInmuebles);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 892);
            this.panel1.TabIndex = 4;
            // 
            // btnConsultarVentas
            // 
            this.btnConsultarVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultarVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultarVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarVentas.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsultarVentas.Image = global::TESTWF2020.Properties.Resources.icons8_price_tag_48;
            this.btnConsultarVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarVentas.Location = new System.Drawing.Point(16, 478);
            this.btnConsultarVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultarVentas.Name = "btnConsultarVentas";
            this.btnConsultarVentas.Size = new System.Drawing.Size(387, 60);
            this.btnConsultarVentas.TabIndex = 10;
            this.btnConsultarVentas.Text = "Consultar Ventas";
            this.btnConsultarVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarVentas.UseVisualStyleBackColor = false;
            this.btnConsultarVentas.Click += new System.EventHandler(this.btnConsultarVentas_Click);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegajo.ForeColor = System.Drawing.Color.White;
            this.lblLegajo.Location = new System.Drawing.Point(113, 291);
            this.lblLegajo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(55, 25);
            this.lblLegajo.TabIndex = 9;
            this.lblLegajo.Text = "Perfil";
            this.lblLegajo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuarioLogeado
            // 
            this.lblUsuarioLogeado.AutoSize = true;
            this.lblUsuarioLogeado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogeado.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioLogeado.Location = new System.Drawing.Point(113, 250);
            this.lblUsuarioLogeado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioLogeado.Name = "lblUsuarioLogeado";
            this.lblUsuarioLogeado.Size = new System.Drawing.Size(117, 29);
            this.lblUsuarioLogeado.TabIndex = 8;
            this.lblUsuarioLogeado.Text = "Usuario :";
            this.lblUsuarioLogeado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Transparent;
            this.btnClientes.Image = global::TESTWF2020.Properties.Resources.icons8_mano_amiga_961;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(16, 612);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(387, 55);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPlanes
            // 
            this.btnPlanes.BackColor = System.Drawing.Color.Transparent;
            this.btnPlanes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlanes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanes.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlanes.Image = global::TESTWF2020.Properties.Resources.icons8_tarjeta_de_fidelidad_961;
            this.btnPlanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlanes.Location = new System.Drawing.Point(16, 675);
            this.btnPlanes.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlanes.Name = "btnPlanes";
            this.btnPlanes.Size = new System.Drawing.Size(387, 79);
            this.btnPlanes.TabIndex = 5;
            this.btnPlanes.Text = "Planes de \r\nFinanciacion";
            this.btnPlanes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlanes.UseVisualStyleBackColor = false;
            this.btnPlanes.Click += new System.EventHandler(this.btnPlanes_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Image = global::TESTWF2020.Properties.Resources.icons8_administrador_del_hombre_48;
            this.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Location = new System.Drawing.Point(16, 825);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(387, 55);
            this.btnEmpleados.TabIndex = 6;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TESTWF2020.Properties.Resources.business_costume_male_man_office_user_icon_1320196264882354682;
            this.pictureBox2.Location = new System.Drawing.Point(95, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 203);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.ForeColor = System.Drawing.Color.Transparent;
            this.btnConsultas.Image = global::TESTWF2020.Properties.Resources.icons8_repositorio_961;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(16, 342);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(387, 59);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnInmuebles
            // 
            this.btnInmuebles.BackColor = System.Drawing.Color.Transparent;
            this.btnInmuebles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnInmuebles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInmuebles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInmuebles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInmuebles.ForeColor = System.Drawing.Color.Transparent;
            this.btnInmuebles.Image = global::TESTWF2020.Properties.Resources.icons8_ciudad_96;
            this.btnInmuebles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInmuebles.Location = new System.Drawing.Point(16, 409);
            this.btnInmuebles.Margin = new System.Windows.Forms.Padding(4);
            this.btnInmuebles.Name = "btnInmuebles";
            this.btnInmuebles.Size = new System.Drawing.Size(387, 61);
            this.btnInmuebles.TabIndex = 0;
            this.btnInmuebles.Text = "Inmuebles";
            this.btnInmuebles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInmuebles.UseVisualStyleBackColor = false;
            this.btnInmuebles.Click += new System.EventHandler(this.btnInmuebles_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.Transparent;
            this.btnReportes.Image = global::TESTWF2020.Properties.Resources.icons8_gráfico_combinado_48;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.Location = new System.Drawing.Point(16, 762);
            this.btnReportes.Margin = new System.Windows.Forms.Padding(4);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(387, 55);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportes.UseVisualStyleBackColor = false;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.Transparent;
            this.btnVentas.Image = global::TESTWF2020.Properties.Resources.icons8_vender_propiedad_961;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(16, 546);
            this.btnVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(387, 58);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Agregar Venta";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(423, 828);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1388, 94);
            this.panel2.TabIndex = 5;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(152, 37);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(134, 29);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "Dia y Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::TESTWF2020.Properties.Resources.icons8_cerrar_ventana_96;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(1289, 4);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 85);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TESTWF2020.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // midPanel
            // 
            this.midPanel.BackColor = System.Drawing.Color.Transparent;
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(423, 30);
            this.midPanel.Margin = new System.Windows.Forms.Padding(4);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(1388, 798);
            this.midPanel.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::TESTWF2020.Properties.Resources.fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1811, 922);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inmobiliaria Casa Feliz";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inmueblesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planesFinanciacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediosDeConocimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viaDeConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInmuebles;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnPlanes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnClientes;
        public System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Label lblUsuarioLogeado;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.ToolStripMenuItem reporteDeInmuebleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteInmuebleXConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ventaFinanciadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaMedioConocimientoToolStripMenuItem;
        private System.Windows.Forms.Button btnConsultarVentas;
    }
}

