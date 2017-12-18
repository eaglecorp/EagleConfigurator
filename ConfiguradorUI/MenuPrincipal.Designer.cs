namespace ConfiguradorUI
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.tabPanel = new MetroFramework.Controls.MetroTabControl();
            this.tabPagProductos = new MetroFramework.Controls.MetroTabPage();
            this.btnComboGrupo = new System.Windows.Forms.Button();
            this.btnComboVariable = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnReceta = new System.Windows.Forms.Button();
            this.btnPrecio = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnGrupoProducto = new System.Windows.Forms.Button();
            this.btnSubFamilia = new System.Windows.Forms.Button();
            this.btnClaseProducto = new System.Windows.Forms.Button();
            this.btnFamilia = new System.Windows.Forms.Button();
            this.btnTipoProducto = new System.Windows.Forms.Button();
            this.btnModelo = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.tabPagPersonas = new MetroFramework.Controls.MetroTabPage();
            this.btnClaseEmp = new System.Windows.Forms.Button();
            this.btnCategoriaEmp = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.tabPagMaestros = new MetroFramework.Controls.MetroTabPage();
            this.btnTurno = new System.Windows.Forms.Button();
            this.btnEstadoMesa = new System.Windows.Forms.Button();
            this.btnMesa = new System.Windows.Forms.Button();
            this.btnCaja = new System.Windows.Forms.Button();
            this.btnImpresora = new System.Windows.Forms.Button();
            this.btnTipoImpresora = new System.Windows.Forms.Button();
            this.btnParametro = new System.Windows.Forms.Button();
            this.btnTipoLocation = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnMedioPago = new System.Windows.Forms.Button();
            this.btnImpuesto = new System.Windows.Forms.Button();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.btnRazon = new System.Windows.Forms.Button();
            this.btnTipoOrden = new System.Windows.Forms.Button();
            this.btnCanalVenta = new System.Windows.Forms.Button();
            this.tabPagReportes = new MetroFramework.Controls.MetroTabPage();
            this.btnCategoriaReporte = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dtpFechaCronologia = new System.Windows.Forms.DateTimePicker();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lnkBackup = new MetroFramework.Controls.MetroLink();
            this.lnkConnection = new MetroFramework.Controls.MetroLink();
            this.StatusStripEagle = new System.Windows.Forms.StatusStrip();
            this.toolStripUsername = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFechaCronologica = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPanel.SuspendLayout();
            this.tabPagProductos.SuspendLayout();
            this.tabPagPersonas.SuspendLayout();
            this.tabPagMaestros.SuspendLayout();
            this.tabPagReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.StatusStripEagle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Controls.Add(this.tabPagProductos);
            this.tabPanel.Controls.Add(this.tabPagPersonas);
            this.tabPanel.Controls.Add(this.tabPagMaestros);
            this.tabPanel.Controls.Add(this.tabPagReportes);
            this.tabPanel.Location = new System.Drawing.Point(31, 161);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(681, 264);
            this.tabPanel.TabIndex = 0;
            this.tabPanel.UseSelectable = true;
            // 
            // tabPagProductos
            // 
            this.tabPagProductos.Controls.Add(this.btnComboGrupo);
            this.tabPagProductos.Controls.Add(this.btnComboVariable);
            this.tabPagProductos.Controls.Add(this.btnCombo);
            this.tabPagProductos.Controls.Add(this.btnReceta);
            this.tabPagProductos.Controls.Add(this.btnPrecio);
            this.tabPagProductos.Controls.Add(this.btnProducto);
            this.tabPagProductos.Controls.Add(this.btnGrupoProducto);
            this.tabPagProductos.Controls.Add(this.btnSubFamilia);
            this.tabPagProductos.Controls.Add(this.btnClaseProducto);
            this.tabPagProductos.Controls.Add(this.btnFamilia);
            this.tabPagProductos.Controls.Add(this.btnTipoProducto);
            this.tabPagProductos.Controls.Add(this.btnModelo);
            this.tabPagProductos.Controls.Add(this.btnMarca);
            this.tabPagProductos.ForeColor = System.Drawing.Color.White;
            this.tabPagProductos.HorizontalScrollbarBarColor = true;
            this.tabPagProductos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagProductos.HorizontalScrollbarSize = 10;
            this.tabPagProductos.Location = new System.Drawing.Point(4, 38);
            this.tabPagProductos.Name = "tabPagProductos";
            this.tabPagProductos.Size = new System.Drawing.Size(673, 222);
            this.tabPagProductos.TabIndex = 0;
            this.tabPagProductos.Text = "Productos";
            this.tabPagProductos.VerticalScrollbarBarColor = true;
            this.tabPagProductos.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagProductos.VerticalScrollbarSize = 10;
            // 
            // btnComboGrupo
            // 
            this.btnComboGrupo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnComboGrupo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComboGrupo.FlatAppearance.BorderSize = 0;
            this.btnComboGrupo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnComboGrupo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnComboGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComboGrupo.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnComboGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnComboGrupo.Image")));
            this.btnComboGrupo.Location = new System.Drawing.Point(281, 93);
            this.btnComboGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.btnComboGrupo.Name = "btnComboGrupo";
            this.btnComboGrupo.Size = new System.Drawing.Size(135, 37);
            this.btnComboGrupo.TabIndex = 12;
            this.btnComboGrupo.Text = "Grupos Cbos";
            this.btnComboGrupo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComboGrupo.UseVisualStyleBackColor = false;
            this.btnComboGrupo.Click += new System.EventHandler(this.btnComboGrupo_Click);
            // 
            // btnComboVariable
            // 
            this.btnComboVariable.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnComboVariable.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnComboVariable.FlatAppearance.BorderSize = 0;
            this.btnComboVariable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnComboVariable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnComboVariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComboVariable.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnComboVariable.Image = ((System.Drawing.Image)(resources.GetObject("btnComboVariable.Image")));
            this.btnComboVariable.Location = new System.Drawing.Point(281, 52);
            this.btnComboVariable.Margin = new System.Windows.Forms.Padding(2);
            this.btnComboVariable.Name = "btnComboVariable";
            this.btnComboVariable.Size = new System.Drawing.Size(135, 37);
            this.btnComboVariable.TabIndex = 11;
            this.btnComboVariable.Text = "Cbos Electivos";
            this.btnComboVariable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComboVariable.UseVisualStyleBackColor = false;
            this.btnComboVariable.Click += new System.EventHandler(this.btnComboVariable_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCombo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCombo.FlatAppearance.BorderSize = 0;
            this.btnCombo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCombo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCombo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.Image = ((System.Drawing.Image)(resources.GetObject("btnCombo.Image")));
            this.btnCombo.Location = new System.Drawing.Point(281, 11);
            this.btnCombo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(135, 37);
            this.btnCombo.TabIndex = 10;
            this.btnCombo.Text = "Combos";
            this.btnCombo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCombo.UseVisualStyleBackColor = false;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnReceta
            // 
            this.btnReceta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReceta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReceta.FlatAppearance.BorderSize = 0;
            this.btnReceta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnReceta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnReceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceta.Image = ((System.Drawing.Image)(resources.GetObject("btnReceta.Image")));
            this.btnReceta.Location = new System.Drawing.Point(142, 176);
            this.btnReceta.Margin = new System.Windows.Forms.Padding(2);
            this.btnReceta.Name = "btnReceta";
            this.btnReceta.Size = new System.Drawing.Size(135, 37);
            this.btnReceta.TabIndex = 9;
            this.btnReceta.Text = "Recetas";
            this.btnReceta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReceta.UseVisualStyleBackColor = false;
            this.btnReceta.Click += new System.EventHandler(this.btnReceta_Click);
            // 
            // btnPrecio
            // 
            this.btnPrecio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrecio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrecio.FlatAppearance.BorderSize = 0;
            this.btnPrecio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnPrecio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecio.Image = ((System.Drawing.Image)(resources.GetObject("btnPrecio.Image")));
            this.btnPrecio.Location = new System.Drawing.Point(142, 135);
            this.btnPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(135, 37);
            this.btnPrecio.TabIndex = 8;
            this.btnPrecio.Text = "Precios";
            this.btnPrecio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrecio.UseVisualStyleBackColor = false;
            this.btnPrecio.Click += new System.EventHandler(this.btnPrecio_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProducto.FlatAppearance.BorderSize = 0;
            this.btnProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.Image")));
            this.btnProducto.Location = new System.Drawing.Point(2, 11);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(135, 37);
            this.btnProducto.TabIndex = 0;
            this.btnProducto.Text = "Productos";
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnGrupoProducto
            // 
            this.btnGrupoProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGrupoProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGrupoProducto.FlatAppearance.BorderSize = 0;
            this.btnGrupoProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnGrupoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGrupoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupoProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupoProducto.Image")));
            this.btnGrupoProducto.Location = new System.Drawing.Point(142, 52);
            this.btnGrupoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnGrupoProducto.Name = "btnGrupoProducto";
            this.btnGrupoProducto.Size = new System.Drawing.Size(135, 37);
            this.btnGrupoProducto.TabIndex = 6;
            this.btnGrupoProducto.Text = "Grupos";
            this.btnGrupoProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGrupoProducto.UseVisualStyleBackColor = false;
            this.btnGrupoProducto.Click += new System.EventHandler(this.btnGrupoProducto_Click);
            // 
            // btnSubFamilia
            // 
            this.btnSubFamilia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSubFamilia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubFamilia.FlatAppearance.BorderSize = 0;
            this.btnSubFamilia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSubFamilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSubFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubFamilia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubFamilia.Image = ((System.Drawing.Image)(resources.GetObject("btnSubFamilia.Image")));
            this.btnSubFamilia.Location = new System.Drawing.Point(2, 52);
            this.btnSubFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubFamilia.Name = "btnSubFamilia";
            this.btnSubFamilia.Size = new System.Drawing.Size(135, 37);
            this.btnSubFamilia.TabIndex = 1;
            this.btnSubFamilia.Text = "Sub-Familias";
            this.btnSubFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubFamilia.UseVisualStyleBackColor = false;
            this.btnSubFamilia.Click += new System.EventHandler(this.btnSubFamilia_Click);
            // 
            // btnClaseProducto
            // 
            this.btnClaseProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClaseProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClaseProducto.FlatAppearance.BorderSize = 0;
            this.btnClaseProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnClaseProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnClaseProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaseProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaseProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnClaseProducto.Image")));
            this.btnClaseProducto.Location = new System.Drawing.Point(142, 11);
            this.btnClaseProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnClaseProducto.Name = "btnClaseProducto";
            this.btnClaseProducto.Size = new System.Drawing.Size(135, 37);
            this.btnClaseProducto.TabIndex = 5;
            this.btnClaseProducto.Text = "Clases";
            this.btnClaseProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClaseProducto.UseVisualStyleBackColor = false;
            this.btnClaseProducto.Click += new System.EventHandler(this.btnClaseProducto_Click);
            // 
            // btnFamilia
            // 
            this.btnFamilia.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnFamilia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFamilia.FlatAppearance.BorderSize = 0;
            this.btnFamilia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnFamilia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFamilia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFamilia.Image = ((System.Drawing.Image)(resources.GetObject("btnFamilia.Image")));
            this.btnFamilia.Location = new System.Drawing.Point(2, 94);
            this.btnFamilia.Margin = new System.Windows.Forms.Padding(2);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(135, 37);
            this.btnFamilia.TabIndex = 2;
            this.btnFamilia.Text = "Familias";
            this.btnFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFamilia.UseVisualStyleBackColor = false;
            this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
            // 
            // btnTipoProducto
            // 
            this.btnTipoProducto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTipoProducto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTipoProducto.FlatAppearance.BorderSize = 0;
            this.btnTipoProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTipoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoProducto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoProducto.Image")));
            this.btnTipoProducto.Location = new System.Drawing.Point(142, 94);
            this.btnTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.btnTipoProducto.Name = "btnTipoProducto";
            this.btnTipoProducto.Size = new System.Drawing.Size(135, 37);
            this.btnTipoProducto.TabIndex = 7;
            this.btnTipoProducto.Text = "Tipos";
            this.btnTipoProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTipoProducto.UseVisualStyleBackColor = false;
            this.btnTipoProducto.Click += new System.EventHandler(this.btnTipoProducto_Click);
            // 
            // btnModelo
            // 
            this.btnModelo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModelo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnModelo.FlatAppearance.BorderSize = 0;
            this.btnModelo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnModelo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModelo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModelo.Image = ((System.Drawing.Image)(resources.GetObject("btnModelo.Image")));
            this.btnModelo.Location = new System.Drawing.Point(2, 135);
            this.btnModelo.Margin = new System.Windows.Forms.Padding(2);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(135, 37);
            this.btnModelo.TabIndex = 3;
            this.btnModelo.Text = "Modelos";
            this.btnModelo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModelo.UseVisualStyleBackColor = false;
            this.btnModelo.Click += new System.EventHandler(this.btnModelo_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMarca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMarca.FlatAppearance.BorderSize = 0;
            this.btnMarca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnMarca.Image")));
            this.btnMarca.Location = new System.Drawing.Point(2, 176);
            this.btnMarca.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(135, 37);
            this.btnMarca.TabIndex = 4;
            this.btnMarca.Text = "Marcas";
            this.btnMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMarca.UseVisualStyleBackColor = false;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // tabPagPersonas
            // 
            this.tabPagPersonas.Controls.Add(this.btnClaseEmp);
            this.tabPagPersonas.Controls.Add(this.btnCategoriaEmp);
            this.tabPagPersonas.Controls.Add(this.btnUsuario);
            this.tabPagPersonas.Controls.Add(this.btnCliente);
            this.tabPagPersonas.Controls.Add(this.btnProveedor);
            this.tabPagPersonas.Controls.Add(this.btnEmpleado);
            this.tabPagPersonas.HorizontalScrollbarBarColor = true;
            this.tabPagPersonas.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagPersonas.HorizontalScrollbarSize = 10;
            this.tabPagPersonas.Location = new System.Drawing.Point(4, 38);
            this.tabPagPersonas.Name = "tabPagPersonas";
            this.tabPagPersonas.Size = new System.Drawing.Size(673, 222);
            this.tabPagPersonas.TabIndex = 1;
            this.tabPagPersonas.Text = "Personas";
            this.tabPagPersonas.VerticalScrollbarBarColor = true;
            this.tabPagPersonas.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagPersonas.VerticalScrollbarSize = 10;
            // 
            // btnClaseEmp
            // 
            this.btnClaseEmp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClaseEmp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClaseEmp.FlatAppearance.BorderSize = 0;
            this.btnClaseEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnClaseEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnClaseEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClaseEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClaseEmp.ForeColor = System.Drawing.Color.White;
            this.btnClaseEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnClaseEmp.Image")));
            this.btnClaseEmp.Location = new System.Drawing.Point(2, 94);
            this.btnClaseEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnClaseEmp.Name = "btnClaseEmp";
            this.btnClaseEmp.Size = new System.Drawing.Size(135, 37);
            this.btnClaseEmp.TabIndex = 5;
            this.btnClaseEmp.Text = "Clase Emp.";
            this.btnClaseEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClaseEmp.UseVisualStyleBackColor = false;
            this.btnClaseEmp.Click += new System.EventHandler(this.btnClaseEmp_Click);
            // 
            // btnCategoriaEmp
            // 
            this.btnCategoriaEmp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCategoriaEmp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCategoriaEmp.FlatAppearance.BorderSize = 0;
            this.btnCategoriaEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCategoriaEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCategoriaEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriaEmp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCategoriaEmp.ForeColor = System.Drawing.Color.White;
            this.btnCategoriaEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriaEmp.Image")));
            this.btnCategoriaEmp.Location = new System.Drawing.Point(2, 52);
            this.btnCategoriaEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategoriaEmp.Name = "btnCategoriaEmp";
            this.btnCategoriaEmp.Size = new System.Drawing.Size(135, 37);
            this.btnCategoriaEmp.TabIndex = 4;
            this.btnCategoriaEmp.Text = "Categoría Emp.";
            this.btnCategoriaEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoriaEmp.UseVisualStyleBackColor = false;
            this.btnCategoriaEmp.Click += new System.EventHandler(this.btnCategoriaEmp_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.ForeColor = System.Drawing.Color.White;
            this.btnUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuario.Image")));
            this.btnUsuario.Location = new System.Drawing.Point(141, 11);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(135, 37);
            this.btnUsuario.TabIndex = 3;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.Image")));
            this.btnCliente.Location = new System.Drawing.Point(2, 177);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(135, 37);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProveedor.FlatAppearance.BorderSize = 0;
            this.btnProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.ForeColor = System.Drawing.Color.White;
            this.btnProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Image")));
            this.btnProveedor.Location = new System.Drawing.Point(2, 135);
            this.btnProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(135, 37);
            this.btnProveedor.TabIndex = 1;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProveedor.UseVisualStyleBackColor = false;
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.Location = new System.Drawing.Point(2, 11);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(135, 37);
            this.btnEmpleado.TabIndex = 0;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // tabPagMaestros
            // 
            this.tabPagMaestros.Controls.Add(this.btnTurno);
            this.tabPagMaestros.Controls.Add(this.btnEstadoMesa);
            this.tabPagMaestros.Controls.Add(this.btnMesa);
            this.tabPagMaestros.Controls.Add(this.btnCaja);
            this.tabPagMaestros.Controls.Add(this.btnImpresora);
            this.tabPagMaestros.Controls.Add(this.btnTipoImpresora);
            this.tabPagMaestros.Controls.Add(this.btnParametro);
            this.tabPagMaestros.Controls.Add(this.btnTipoLocation);
            this.tabPagMaestros.Controls.Add(this.btnLocation);
            this.tabPagMaestros.Controls.Add(this.btnMedioPago);
            this.tabPagMaestros.Controls.Add(this.btnImpuesto);
            this.tabPagMaestros.Controls.Add(this.btnDescuento);
            this.tabPagMaestros.Controls.Add(this.btnRazon);
            this.tabPagMaestros.Controls.Add(this.btnTipoOrden);
            this.tabPagMaestros.Controls.Add(this.btnCanalVenta);
            this.tabPagMaestros.HorizontalScrollbarBarColor = true;
            this.tabPagMaestros.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagMaestros.HorizontalScrollbarSize = 10;
            this.tabPagMaestros.Location = new System.Drawing.Point(4, 38);
            this.tabPagMaestros.Name = "tabPagMaestros";
            this.tabPagMaestros.Size = new System.Drawing.Size(673, 222);
            this.tabPagMaestros.TabIndex = 2;
            this.tabPagMaestros.Text = "Maestros";
            this.tabPagMaestros.VerticalScrollbarBarColor = true;
            this.tabPagMaestros.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagMaestros.VerticalScrollbarSize = 10;
            // 
            // btnTurno
            // 
            this.btnTurno.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTurno.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTurno.FlatAppearance.BorderSize = 0;
            this.btnTurno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurno.ForeColor = System.Drawing.Color.White;
            this.btnTurno.Image = ((System.Drawing.Image)(resources.GetObject("btnTurno.Image")));
            this.btnTurno.Location = new System.Drawing.Point(281, 134);
            this.btnTurno.Margin = new System.Windows.Forms.Padding(2);
            this.btnTurno.Name = "btnTurno";
            this.btnTurno.Size = new System.Drawing.Size(135, 37);
            this.btnTurno.TabIndex = 14;
            this.btnTurno.Text = "Turnos";
            this.btnTurno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTurno.UseVisualStyleBackColor = false;
            this.btnTurno.Click += new System.EventHandler(this.btnTurno_Click);
            // 
            // btnEstadoMesa
            // 
            this.btnEstadoMesa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEstadoMesa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEstadoMesa.FlatAppearance.BorderSize = 0;
            this.btnEstadoMesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEstadoMesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEstadoMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadoMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoMesa.ForeColor = System.Drawing.Color.White;
            this.btnEstadoMesa.Image = ((System.Drawing.Image)(resources.GetObject("btnEstadoMesa.Image")));
            this.btnEstadoMesa.Location = new System.Drawing.Point(281, 93);
            this.btnEstadoMesa.Margin = new System.Windows.Forms.Padding(2);
            this.btnEstadoMesa.Name = "btnEstadoMesa";
            this.btnEstadoMesa.Size = new System.Drawing.Size(135, 37);
            this.btnEstadoMesa.TabIndex = 13;
            this.btnEstadoMesa.Text = "Estado Mesa";
            this.btnEstadoMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstadoMesa.UseVisualStyleBackColor = false;
            this.btnEstadoMesa.Click += new System.EventHandler(this.btnEstadoMesa_Click);
            // 
            // btnMesa
            // 
            this.btnMesa.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMesa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMesa.FlatAppearance.BorderSize = 0;
            this.btnMesa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnMesa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMesa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesa.ForeColor = System.Drawing.Color.White;
            this.btnMesa.Image = ((System.Drawing.Image)(resources.GetObject("btnMesa.Image")));
            this.btnMesa.Location = new System.Drawing.Point(281, 52);
            this.btnMesa.Margin = new System.Windows.Forms.Padding(2);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(135, 37);
            this.btnMesa.TabIndex = 12;
            this.btnMesa.Text = "Mesas";
            this.btnMesa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMesa.UseVisualStyleBackColor = false;
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            // 
            // btnCaja
            // 
            this.btnCaja.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCaja.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCaja.FlatAppearance.BorderSize = 0;
            this.btnCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaja.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.ForeColor = System.Drawing.Color.White;
            this.btnCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCaja.Image")));
            this.btnCaja.Location = new System.Drawing.Point(281, 11);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(135, 37);
            this.btnCaja.TabIndex = 11;
            this.btnCaja.Text = "Cajas";
            this.btnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // btnImpresora
            // 
            this.btnImpresora.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImpresora.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImpresora.FlatAppearance.BorderSize = 0;
            this.btnImpresora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnImpresora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnImpresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpresora.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpresora.ForeColor = System.Drawing.Color.White;
            this.btnImpresora.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresora.Image")));
            this.btnImpresora.Location = new System.Drawing.Point(142, 135);
            this.btnImpresora.Margin = new System.Windows.Forms.Padding(2);
            this.btnImpresora.Name = "btnImpresora";
            this.btnImpresora.Size = new System.Drawing.Size(135, 37);
            this.btnImpresora.TabIndex = 10;
            this.btnImpresora.Text = "Impresoras";
            this.btnImpresora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImpresora.UseVisualStyleBackColor = false;
            this.btnImpresora.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // btnTipoImpresora
            // 
            this.btnTipoImpresora.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTipoImpresora.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTipoImpresora.FlatAppearance.BorderSize = 0;
            this.btnTipoImpresora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTipoImpresora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnTipoImpresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoImpresora.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTipoImpresora.ForeColor = System.Drawing.Color.White;
            this.btnTipoImpresora.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoImpresora.Image")));
            this.btnTipoImpresora.Location = new System.Drawing.Point(142, 176);
            this.btnTipoImpresora.Margin = new System.Windows.Forms.Padding(2);
            this.btnTipoImpresora.Name = "btnTipoImpresora";
            this.btnTipoImpresora.Size = new System.Drawing.Size(135, 37);
            this.btnTipoImpresora.TabIndex = 9;
            this.btnTipoImpresora.Text = "Tipo Impresora";
            this.btnTipoImpresora.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTipoImpresora.UseVisualStyleBackColor = false;
            this.btnTipoImpresora.Click += new System.EventHandler(this.btnTipoImpresora_Click);
            // 
            // btnParametro
            // 
            this.btnParametro.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnParametro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnParametro.FlatAppearance.BorderSize = 0;
            this.btnParametro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnParametro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnParametro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParametro.ForeColor = System.Drawing.Color.White;
            this.btnParametro.Image = ((System.Drawing.Image)(resources.GetObject("btnParametro.Image")));
            this.btnParametro.Location = new System.Drawing.Point(281, 175);
            this.btnParametro.Margin = new System.Windows.Forms.Padding(2);
            this.btnParametro.Name = "btnParametro";
            this.btnParametro.Size = new System.Drawing.Size(135, 37);
            this.btnParametro.TabIndex = 8;
            this.btnParametro.Text = "Parámetros";
            this.btnParametro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParametro.UseVisualStyleBackColor = false;
            this.btnParametro.Click += new System.EventHandler(this.btnParametro_Click);
            // 
            // btnTipoLocation
            // 
            this.btnTipoLocation.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTipoLocation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTipoLocation.FlatAppearance.BorderSize = 0;
            this.btnTipoLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTipoLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnTipoLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTipoLocation.ForeColor = System.Drawing.Color.White;
            this.btnTipoLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoLocation.Image")));
            this.btnTipoLocation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTipoLocation.Location = new System.Drawing.Point(142, 94);
            this.btnTipoLocation.Margin = new System.Windows.Forms.Padding(0);
            this.btnTipoLocation.Name = "btnTipoLocation";
            this.btnTipoLocation.Size = new System.Drawing.Size(135, 37);
            this.btnTipoLocation.TabIndex = 7;
            this.btnTipoLocation.Text = "Tipo Location";
            this.btnTipoLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTipoLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTipoLocation.UseVisualStyleBackColor = false;
            this.btnTipoLocation.Click += new System.EventHandler(this.btnTipoLocation_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLocation.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLocation.FlatAppearance.BorderSize = 0;
            this.btnLocation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnLocation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocation.ForeColor = System.Drawing.Color.White;
            this.btnLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnLocation.Image")));
            this.btnLocation.Location = new System.Drawing.Point(142, 52);
            this.btnLocation.Margin = new System.Windows.Forms.Padding(2);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(135, 37);
            this.btnLocation.TabIndex = 6;
            this.btnLocation.Text = "Location";
            this.btnLocation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLocation.UseVisualStyleBackColor = false;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnMedioPago
            // 
            this.btnMedioPago.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMedioPago.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMedioPago.FlatAppearance.BorderSize = 0;
            this.btnMedioPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnMedioPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnMedioPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedioPago.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedioPago.ForeColor = System.Drawing.Color.White;
            this.btnMedioPago.Image = ((System.Drawing.Image)(resources.GetObject("btnMedioPago.Image")));
            this.btnMedioPago.Location = new System.Drawing.Point(2, 11);
            this.btnMedioPago.Margin = new System.Windows.Forms.Padding(2);
            this.btnMedioPago.Name = "btnMedioPago";
            this.btnMedioPago.Size = new System.Drawing.Size(135, 37);
            this.btnMedioPago.TabIndex = 0;
            this.btnMedioPago.Text = "Medios Pago";
            this.btnMedioPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedioPago.UseVisualStyleBackColor = false;
            this.btnMedioPago.Click += new System.EventHandler(this.btnMedioPago_Click);
            // 
            // btnImpuesto
            // 
            this.btnImpuesto.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImpuesto.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnImpuesto.FlatAppearance.BorderSize = 0;
            this.btnImpuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnImpuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpuesto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpuesto.ForeColor = System.Drawing.Color.White;
            this.btnImpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnImpuesto.Image")));
            this.btnImpuesto.Location = new System.Drawing.Point(142, 11);
            this.btnImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.btnImpuesto.Name = "btnImpuesto";
            this.btnImpuesto.Size = new System.Drawing.Size(135, 37);
            this.btnImpuesto.TabIndex = 5;
            this.btnImpuesto.Text = "Impuestos";
            this.btnImpuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImpuesto.UseVisualStyleBackColor = false;
            this.btnImpuesto.Click += new System.EventHandler(this.btnImpuesto_Click);
            // 
            // btnDescuento
            // 
            this.btnDescuento.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDescuento.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDescuento.FlatAppearance.BorderSize = 0;
            this.btnDescuento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnDescuento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnDescuento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescuento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuento.ForeColor = System.Drawing.Color.White;
            this.btnDescuento.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuento.Image")));
            this.btnDescuento.Location = new System.Drawing.Point(2, 52);
            this.btnDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(135, 37);
            this.btnDescuento.TabIndex = 1;
            this.btnDescuento.Text = "Descuentos";
            this.btnDescuento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescuento.UseVisualStyleBackColor = false;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // btnRazon
            // 
            this.btnRazon.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRazon.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRazon.FlatAppearance.BorderSize = 0;
            this.btnRazon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRazon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRazon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRazon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRazon.ForeColor = System.Drawing.Color.White;
            this.btnRazon.Image = ((System.Drawing.Image)(resources.GetObject("btnRazon.Image")));
            this.btnRazon.Location = new System.Drawing.Point(2, 176);
            this.btnRazon.Margin = new System.Windows.Forms.Padding(2);
            this.btnRazon.Name = "btnRazon";
            this.btnRazon.Size = new System.Drawing.Size(135, 37);
            this.btnRazon.TabIndex = 4;
            this.btnRazon.Text = "Razones";
            this.btnRazon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRazon.UseVisualStyleBackColor = false;
            this.btnRazon.Click += new System.EventHandler(this.btnRazon_Click);
            // 
            // btnTipoOrden
            // 
            this.btnTipoOrden.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTipoOrden.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTipoOrden.FlatAppearance.BorderSize = 0;
            this.btnTipoOrden.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnTipoOrden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnTipoOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipoOrden.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTipoOrden.ForeColor = System.Drawing.Color.White;
            this.btnTipoOrden.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoOrden.Image")));
            this.btnTipoOrden.Location = new System.Drawing.Point(2, 94);
            this.btnTipoOrden.Margin = new System.Windows.Forms.Padding(2);
            this.btnTipoOrden.Name = "btnTipoOrden";
            this.btnTipoOrden.Size = new System.Drawing.Size(135, 37);
            this.btnTipoOrden.TabIndex = 2;
            this.btnTipoOrden.Text = "Tipo de Orden";
            this.btnTipoOrden.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTipoOrden.UseVisualStyleBackColor = false;
            this.btnTipoOrden.Click += new System.EventHandler(this.btnTipoOrden_Click);
            // 
            // btnCanalVenta
            // 
            this.btnCanalVenta.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCanalVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCanalVenta.FlatAppearance.BorderSize = 0;
            this.btnCanalVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCanalVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCanalVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCanalVenta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCanalVenta.ForeColor = System.Drawing.Color.White;
            this.btnCanalVenta.Image = ((System.Drawing.Image)(resources.GetObject("btnCanalVenta.Image")));
            this.btnCanalVenta.Location = new System.Drawing.Point(2, 135);
            this.btnCanalVenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCanalVenta.Name = "btnCanalVenta";
            this.btnCanalVenta.Size = new System.Drawing.Size(135, 37);
            this.btnCanalVenta.TabIndex = 3;
            this.btnCanalVenta.Text = "Canal de Venta";
            this.btnCanalVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCanalVenta.UseVisualStyleBackColor = false;
            this.btnCanalVenta.Click += new System.EventHandler(this.btnCanalVenta_Click);
            // 
            // tabPagReportes
            // 
            this.tabPagReportes.Controls.Add(this.btnCategoriaReporte);
            this.tabPagReportes.Controls.Add(this.btnReporte);
            this.tabPagReportes.HorizontalScrollbarBarColor = true;
            this.tabPagReportes.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagReportes.HorizontalScrollbarSize = 10;
            this.tabPagReportes.Location = new System.Drawing.Point(4, 38);
            this.tabPagReportes.Name = "tabPagReportes";
            this.tabPagReportes.Size = new System.Drawing.Size(673, 222);
            this.tabPagReportes.TabIndex = 3;
            this.tabPagReportes.Text = "Reportes";
            this.tabPagReportes.VerticalScrollbarBarColor = true;
            this.tabPagReportes.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagReportes.VerticalScrollbarSize = 10;
            // 
            // btnCategoriaReporte
            // 
            this.btnCategoriaReporte.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCategoriaReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCategoriaReporte.FlatAppearance.BorderSize = 0;
            this.btnCategoriaReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCategoriaReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCategoriaReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriaReporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriaReporte.ForeColor = System.Drawing.Color.White;
            this.btnCategoriaReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriaReporte.Image")));
            this.btnCategoriaReporte.Location = new System.Drawing.Point(2, 52);
            this.btnCategoriaReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategoriaReporte.Name = "btnCategoriaReporte";
            this.btnCategoriaReporte.Size = new System.Drawing.Size(135, 37);
            this.btnCategoriaReporte.TabIndex = 13;
            this.btnCategoriaReporte.Text = "Categorías";
            this.btnCategoriaReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategoriaReporte.UseVisualStyleBackColor = false;
            this.btnCategoriaReporte.Click += new System.EventHandler(this.btnCategoriaReporte_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReporte.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.ForeColor = System.Drawing.Color.White;
            this.btnReporte.Image = ((System.Drawing.Image)(resources.GetObject("btnReporte.Image")));
            this.btnReporte.Location = new System.Drawing.Point(2, 11);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(135, 37);
            this.btnReporte.TabIndex = 12;
            this.btnReporte.Text = "Reportes";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dtpFechaCronologia
            // 
            this.dtpFechaCronologia.Location = new System.Drawing.Point(520, 20);
            this.dtpFechaCronologia.Name = "dtpFechaCronologia";
            this.dtpFechaCronologia.Size = new System.Drawing.Size(192, 20);
            this.dtpFechaCronologia.TabIndex = 5;
            this.dtpFechaCronologia.Visible = false;
            // 
            // timerHora
            // 
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(87, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 47);
            this.label1.TabIndex = 8;
            this.label1.Text = "Eagle Configurator";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(31, 34);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(55, 55);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            // 
            // lnkBackup
            // 
            this.lnkBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lnkBackup.BackgroundImage")));
            this.lnkBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkBackup.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkBackup.Location = new System.Drawing.Point(31, 95);
            this.lnkBackup.Name = "lnkBackup";
            this.lnkBackup.Size = new System.Drawing.Size(62, 60);
            this.lnkBackup.TabIndex = 1;
            this.lnkBackup.Text = "&Backup";
            this.lnkBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkBackup.UseSelectable = true;
            this.lnkBackup.Click += new System.EventHandler(this.lnkBackup_Click);
            // 
            // lnkConnection
            // 
            this.lnkConnection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lnkConnection.BackgroundImage")));
            this.lnkConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lnkConnection.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkConnection.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkConnection.Location = new System.Drawing.Point(95, 95);
            this.lnkConnection.Name = "lnkConnection";
            this.lnkConnection.Size = new System.Drawing.Size(60, 60);
            this.lnkConnection.TabIndex = 2;
            this.lnkConnection.Text = "&Conexión";
            this.lnkConnection.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkConnection.UseSelectable = true;
            this.lnkConnection.Click += new System.EventHandler(this.lnkConnection_Click);
            // 
            // StatusStripEagle
            // 
            this.StatusStripEagle.BackColor = System.Drawing.Color.White;
            this.StatusStripEagle.Dock = System.Windows.Forms.DockStyle.None;
            this.StatusStripEagle.GripMargin = new System.Windows.Forms.Padding(10, 2, 2, 2);
            this.StatusStripEagle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStripEagle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsername,
            this.toolStripFechaCronologica,
            this.toolStripHora});
            this.StatusStripEagle.Location = new System.Drawing.Point(35, 434);
            this.StatusStripEagle.Name = "StatusStripEagle";
            this.StatusStripEagle.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.StatusStripEagle.Size = new System.Drawing.Size(259, 26);
            this.StatusStripEagle.SizingGrip = false;
            this.StatusStripEagle.TabIndex = 11;
            // 
            // toolStripUsername
            // 
            this.toolStripUsername.BackColor = System.Drawing.Color.White;
            this.toolStripUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripUsername.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripUsername.Name = "toolStripUsername";
            this.toolStripUsername.Size = new System.Drawing.Size(87, 21);
            this.toolStripUsername.Text = "Username";
            // 
            // toolStripFechaCronologica
            // 
            this.toolStripFechaCronologica.BackColor = System.Drawing.Color.White;
            this.toolStripFechaCronologica.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripFechaCronologica.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripFechaCronologica.Name = "toolStripFechaCronologica";
            this.toolStripFechaCronologica.Size = new System.Drawing.Size(120, 21);
            this.toolStripFechaCronologica.Text = "FechaCronologica";
            // 
            // toolStripHora
            // 
            this.toolStripHora.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripHora.ForeColor = System.Drawing.Color.DodgerBlue;
            this.toolStripHora.Name = "toolStripHora";
            this.toolStripHora.Size = new System.Drawing.Size(39, 21);
            this.toolStripHora.Text = "Hora";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(37, 424);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(673, 4);
            this.panel3.TabIndex = 66;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 485);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.StatusStripEagle);
            this.Controls.Add(this.lnkConnection);
            this.Controls.Add(this.lnkBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.dtpFechaCronologia);
            this.Controls.Add(this.tabPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.Padding = new System.Windows.Forms.Padding(20, 130, 20, 25);
            this.Resizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.tabPanel.ResumeLayout(false);
            this.tabPagProductos.ResumeLayout(false);
            this.tabPagPersonas.ResumeLayout(false);
            this.tabPagMaestros.ResumeLayout(false);
            this.tabPagReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.StatusStripEagle.ResumeLayout(false);
            this.StatusStripEagle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnClaseProducto;
        private System.Windows.Forms.Button btnTipoProducto;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnModelo;
        private System.Windows.Forms.Button btnFamilia;
        private System.Windows.Forms.Button btnSubFamilia;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Button btnReceta;
        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Button btnGrupoProducto;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnMedioPago;
        private System.Windows.Forms.Button btnParametro;
        private System.Windows.Forms.Button btnTipoLocation;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnImpuesto;
        private System.Windows.Forms.Button btnRazon;
        private System.Windows.Forms.Button btnCanalVenta;
        private System.Windows.Forms.Button btnTipoOrden;
        private System.Windows.Forms.Button btnDescuento;
        private MetroFramework.Controls.MetroTabControl tabPanel;
        private MetroFramework.Controls.MetroTabPage tabPagProductos;
        private MetroFramework.Controls.MetroTabPage tabPagPersonas;
        private MetroFramework.Controls.MetroTabPage tabPagMaestros;
        private System.Windows.Forms.DateTimePicker dtpFechaCronologia;
        private System.Windows.Forms.Timer timerHora;

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLink lnkBackup;
        private MetroFramework.Controls.MetroLink lnkConnection;
        private System.Windows.Forms.StatusStrip StatusStripEagle;
        private System.Windows.Forms.ToolStripStatusLabel toolStripUsername;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFechaCronologica;
        private System.Windows.Forms.ToolStripStatusLabel toolStripHora;
        private MetroFramework.Controls.MetroTabPage tabPagReportes;
        private System.Windows.Forms.Button btnCategoriaReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnImpresora;
        private System.Windows.Forms.Button btnTipoImpresora;
        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Button btnEstadoMesa;
        private System.Windows.Forms.Button btnMesa;
        private System.Windows.Forms.Button btnTurno;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClaseEmp;
        private System.Windows.Forms.Button btnCategoriaEmp;
        private System.Windows.Forms.Button btnComboVariable;
        private System.Windows.Forms.Button btnComboGrupo;
    }
}

