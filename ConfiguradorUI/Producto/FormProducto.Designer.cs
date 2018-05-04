using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Producto
{
    partial class FormProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            this.tabProducto = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.txtDiametro = new MetroFramework.Controls.MetroTextBox();
            this.lblDiametro = new MetroFramework.Controls.MetroLabel();
            this.chkReceta = new MetroFramework.Controls.MetroCheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboUnidadMedida = new BorderedCombo();
            this.lblUnidadMedida = new MetroFramework.Controls.MetroLabel();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.btnClaseProd = new MetroFramework.Controls.MetroLink();
            this.btnGrupoProd = new MetroFramework.Controls.MetroLink();
            this.btnTipoProd = new MetroFramework.Controls.MetroLink();
            this.btnModelo = new MetroFramework.Controls.MetroLink();
            this.btnMarca = new MetroFramework.Controls.MetroLink();
            this.btnSubFamilia = new MetroFramework.Controls.MetroLink();
            this.btnFamilia = new MetroFramework.Controls.MetroLink();
            this.txtAltura = new MetroFramework.Controls.MetroTextBox();
            this.txtLargo = new MetroFramework.Controls.MetroTextBox();
            this.lblAltura = new MetroFramework.Controls.MetroLabel();
            this.lblLargo = new MetroFramework.Controls.MetroLabel();
            this.txtAncho = new MetroFramework.Controls.MetroTextBox();
            this.txtReferencia = new MetroFramework.Controls.MetroTextBox();
            this.txtPeso = new MetroFramework.Controls.MetroTextBox();
            this.lblReferencia = new MetroFramework.Controls.MetroLabel();
            this.chkCombo = new MetroFramework.Controls.MetroCheckBox();
            this.lblAncho = new MetroFramework.Controls.MetroLabel();
            this.chkProductoCompra = new MetroFramework.Controls.MetroCheckBox();
            this.chkProductoVenta = new MetroFramework.Controls.MetroCheckBox();
            this.lblPeso = new MetroFramework.Controls.MetroLabel();
            this.cboClaseProd = new BorderedCombo();
            this.cboGrupoProd = new BorderedCombo();
            this.cboTipoExistencia = new BorderedCombo();
            this.cboTipoProd = new BorderedCombo();
            this.lblClaseProd = new MetroFramework.Controls.MetroLabel();
            this.lblGrupo = new MetroFramework.Controls.MetroLabel();
            this.lblTipoExistencia = new MetroFramework.Controls.MetroLabel();
            this.lblTipoProd = new MetroFramework.Controls.MetroLabel();
            this.cboModelo = new BorderedCombo();
            this.cboMarca = new BorderedCombo();
            this.cboSubFamilia = new BorderedCombo();
            this.cboFamilia = new BorderedCombo();
            this.lblModelo = new MetroFramework.Controls.MetroLabel();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.lblSubFamilia = new MetroFramework.Controls.MetroLabel();
            this.lblFamilia = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo02 = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo02 = new MetroFramework.Controls.MetroLabel();
            this.txtCodBarra = new MetroFramework.Controls.MetroTextBox();
            this.lblCodBarra = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo01 = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo01 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.tabPagPrecio = new MetroFramework.Controls.MetroTabPage();
            this.lblPorcentajeAcumuladoImpto = new System.Windows.Forms.Label();
            this.lblSimboloPorcentaje = new System.Windows.Forms.Label();
            this.grbCostoProd = new System.Windows.Forms.GroupBox();
            this.txtCostoProd = new MetroFramework.Controls.MetroTextBox();
            this.lblCosto = new MetroFramework.Controls.MetroLabel();
            this.grbConImpto = new System.Windows.Forms.GroupBox();
            this.txtPvMiConImpto = new MetroFramework.Controls.MetroTextBox();
            this.lblPvMiConIGV = new MetroFramework.Controls.MetroLabel();
            this.txtPvMaConImpto = new MetroFramework.Controls.MetroTextBox();
            this.lblPvMaConIGV = new MetroFramework.Controls.MetroLabel();
            this.txtPvPuConImpto = new MetroFramework.Controls.MetroTextBox();
            this.lblPvPuConIGV = new MetroFramework.Controls.MetroLabel();
            this.grbSinImpto = new System.Windows.Forms.GroupBox();
            this.txtPvMiSinImpto = new MetroFramework.Controls.MetroTextBox();
            this.lblPvMiSinIGV = new MetroFramework.Controls.MetroLabel();
            this.txtPvMaSinImpto = new MetroFramework.Controls.MetroTextBox();
            this.lblPvMaSinIGV = new MetroFramework.Controls.MetroLabel();
            this.txtPvPuSinImpto = new MetroFramework.Controls.MetroTextBox();
            this.lblPvPuSinIGV = new MetroFramework.Controls.MetroLabel();
            this.chkInafecto = new MetroFramework.Controls.MetroCheckBox();
            this.chkExento = new MetroFramework.Controls.MetroCheckBox();
            this.chkImpto = new MetroFramework.Controls.MetroCheckBox();
            this.cboImpuesto = new BorderedCombo();
            this.cboTipoMoneda = new BorderedCombo();
            this.lblImpuesto = new MetroFramework.Controls.MetroLabel();
            this.lblTipoMoneda = new MetroFramework.Controls.MetroLabel();
            this.btnImpuesto = new MetroFramework.Controls.MetroLink();
            this.cboFiltro = new BorderedCombo();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.panelMantenimiento = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tglListarInactivos = new MetroFramework.Controls.MetroToggle();
            this.lblListarInactivos = new MetroFramework.Controls.MetroLabel();
            this.panelFiltro = new MetroFramework.Controls.MetroPanel();
            this.lblFiltro = new MetroFramework.Controls.MetroLabel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.tabProducto.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.tabPagPrecio.SuspendLayout();
            this.grbCostoProd.SuspendLayout();
            this.grbConImpto.SuspendLayout();
            this.grbSinImpto.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            this.panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.tabPagGeneral);
            this.tabProducto.Controls.Add(this.tabPagPrecio);
            this.tabProducto.Location = new System.Drawing.Point(428, 102);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.SelectedIndex = 0;
            this.tabProducto.Size = new System.Drawing.Size(564, 527);
            this.tabProducto.TabIndex = 1;
            this.tabProducto.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.txtDiametro);
            this.tabPagGeneral.Controls.Add(this.lblDiametro);
            this.tabPagGeneral.Controls.Add(this.chkReceta);
            this.tabPagGeneral.Controls.Add(this.panel4);
            this.tabPagGeneral.Controls.Add(this.panel3);
            this.tabPagGeneral.Controls.Add(this.panel2);
            this.tabPagGeneral.Controls.Add(this.panel1);
            this.tabPagGeneral.Controls.Add(this.cboUnidadMedida);
            this.tabPagGeneral.Controls.Add(this.lblUnidadMedida);
            this.tabPagGeneral.Controls.Add(this.chkActivo);
            this.tabPagGeneral.Controls.Add(this.btnClaseProd);
            this.tabPagGeneral.Controls.Add(this.btnGrupoProd);
            this.tabPagGeneral.Controls.Add(this.btnTipoProd);
            this.tabPagGeneral.Controls.Add(this.btnModelo);
            this.tabPagGeneral.Controls.Add(this.btnMarca);
            this.tabPagGeneral.Controls.Add(this.btnSubFamilia);
            this.tabPagGeneral.Controls.Add(this.btnFamilia);
            this.tabPagGeneral.Controls.Add(this.txtAltura);
            this.tabPagGeneral.Controls.Add(this.txtLargo);
            this.tabPagGeneral.Controls.Add(this.lblAltura);
            this.tabPagGeneral.Controls.Add(this.lblLargo);
            this.tabPagGeneral.Controls.Add(this.txtAncho);
            this.tabPagGeneral.Controls.Add(this.txtReferencia);
            this.tabPagGeneral.Controls.Add(this.txtPeso);
            this.tabPagGeneral.Controls.Add(this.lblReferencia);
            this.tabPagGeneral.Controls.Add(this.chkCombo);
            this.tabPagGeneral.Controls.Add(this.lblAncho);
            this.tabPagGeneral.Controls.Add(this.chkProductoCompra);
            this.tabPagGeneral.Controls.Add(this.chkProductoVenta);
            this.tabPagGeneral.Controls.Add(this.lblPeso);
            this.tabPagGeneral.Controls.Add(this.cboClaseProd);
            this.tabPagGeneral.Controls.Add(this.cboGrupoProd);
            this.tabPagGeneral.Controls.Add(this.cboTipoExistencia);
            this.tabPagGeneral.Controls.Add(this.cboTipoProd);
            this.tabPagGeneral.Controls.Add(this.lblClaseProd);
            this.tabPagGeneral.Controls.Add(this.lblGrupo);
            this.tabPagGeneral.Controls.Add(this.lblTipoExistencia);
            this.tabPagGeneral.Controls.Add(this.lblTipoProd);
            this.tabPagGeneral.Controls.Add(this.cboModelo);
            this.tabPagGeneral.Controls.Add(this.cboMarca);
            this.tabPagGeneral.Controls.Add(this.cboSubFamilia);
            this.tabPagGeneral.Controls.Add(this.cboFamilia);
            this.tabPagGeneral.Controls.Add(this.lblModelo);
            this.tabPagGeneral.Controls.Add(this.lblMarca);
            this.tabPagGeneral.Controls.Add(this.lblSubFamilia);
            this.tabPagGeneral.Controls.Add(this.lblFamilia);
            this.tabPagGeneral.Controls.Add(this.txtCodigo02);
            this.tabPagGeneral.Controls.Add(this.lblCodigo02);
            this.tabPagGeneral.Controls.Add(this.txtCodBarra);
            this.tabPagGeneral.Controls.Add(this.lblCodBarra);
            this.tabPagGeneral.Controls.Add(this.txtCodigo01);
            this.tabPagGeneral.Controls.Add(this.lblCodigo01);
            this.tabPagGeneral.Controls.Add(this.txtNombre);
            this.tabPagGeneral.Controls.Add(this.lblNombre);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(556, 485);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // txtDiametro
            // 
            this.txtDiametro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDiametro.CustomButton.Image = null;
            this.txtDiametro.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtDiametro.CustomButton.Name = "";
            this.txtDiametro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDiametro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDiametro.CustomButton.TabIndex = 1;
            this.txtDiametro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDiametro.CustomButton.UseSelectable = true;
            this.txtDiametro.CustomButton.Visible = false;
            this.txtDiametro.Lines = new string[0];
            this.txtDiametro.Location = new System.Drawing.Point(75, 460);
            this.txtDiametro.MaxLength = 32767;
            this.txtDiametro.Name = "txtDiametro";
            this.txtDiametro.PasswordChar = '\0';
            this.txtDiametro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDiametro.SelectedText = "";
            this.txtDiametro.SelectionLength = 0;
            this.txtDiametro.SelectionStart = 0;
            this.txtDiametro.ShortcutsEnabled = true;
            this.txtDiametro.Size = new System.Drawing.Size(104, 23);
            this.txtDiametro.TabIndex = 42;
            this.txtDiametro.UseCustomBackColor = true;
            this.txtDiametro.UseSelectable = true;
            this.txtDiametro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDiametro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDiametro.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblDiametro
            // 
            this.lblDiametro.AutoSize = true;
            this.lblDiametro.ForeColor = System.Drawing.Color.Navy;
            this.lblDiametro.Location = new System.Drawing.Point(5, 462);
            this.lblDiametro.Name = "lblDiametro";
            this.lblDiametro.Size = new System.Drawing.Size(67, 19);
            this.lblDiametro.TabIndex = 41;
            this.lblDiametro.Text = "Diámetro:";
            this.lblDiametro.UseCustomForeColor = true;
            // 
            // chkReceta
            // 
            this.chkReceta.AutoSize = true;
            this.chkReceta.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkReceta.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkReceta.ForeColor = System.Drawing.Color.Navy;
            this.chkReceta.Location = new System.Drawing.Point(371, 338);
            this.chkReceta.Name = "chkReceta";
            this.chkReceta.Size = new System.Drawing.Size(64, 19);
            this.chkReceta.TabIndex = 28;
            this.chkReceta.Text = "Receta";
            this.chkReceta.UseCustomForeColor = true;
            this.chkReceta.UseSelectable = true;
            this.chkReceta.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(5, 406);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(530, 8);
            this.panel4.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(5, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 8);
            this.panel3.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(5, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 8);
            this.panel2.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(5, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 8);
            this.panel1.TabIndex = 57;
            // 
            // cboUnidadMedida
            // 
            this.cboUnidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboUnidadMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboUnidadMedida.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadMedida.FormattingEnabled = true;
            this.cboUnidadMedida.Location = new System.Drawing.Point(354, 83);
            this.cboUnidadMedida.Name = "cboUnidadMedida";
            this.cboUnidadMedida.Size = new System.Drawing.Size(183, 23);
            this.cboUnidadMedida.TabIndex = 9;
            this.cboUnidadMedida.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblUnidadMedida
            // 
            this.lblUnidadMedida.AutoSize = true;
            this.lblUnidadMedida.ForeColor = System.Drawing.Color.Navy;
            this.lblUnidadMedida.Location = new System.Drawing.Point(281, 85);
            this.lblUnidadMedida.Name = "lblUnidadMedida";
            this.lblUnidadMedida.Size = new System.Drawing.Size(67, 19);
            this.lblUnidadMedida.TabIndex = 8;
            this.lblUnidadMedida.Text = "Und Med:";
            this.lblUnidadMedida.UseCustomForeColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkActivo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkActivo.ForeColor = System.Drawing.Color.Navy;
            this.chkActivo.Location = new System.Drawing.Point(5, 338);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 30;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseCustomForeColor = true;
            this.chkActivo.UseSelectable = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // btnClaseProd
            // 
            this.btnClaseProd.Image = ((System.Drawing.Image)(resources.GetObject("btnClaseProd.Image")));
            this.btnClaseProd.ImageSize = 24;
            this.btnClaseProd.Location = new System.Drawing.Point(510, 273);
            this.btnClaseProd.Name = "btnClaseProd";
            this.btnClaseProd.Size = new System.Drawing.Size(29, 27);
            this.btnClaseProd.TabIndex = 52;
            this.btnClaseProd.UseSelectable = true;
            this.btnClaseProd.Click += new System.EventHandler(this.btnClaseProd_Click);
            // 
            // btnGrupoProd
            // 
            this.btnGrupoProd.Image = ((System.Drawing.Image)(resources.GetObject("btnGrupoProd.Image")));
            this.btnGrupoProd.ImageSize = 24;
            this.btnGrupoProd.Location = new System.Drawing.Point(510, 237);
            this.btnGrupoProd.Name = "btnGrupoProd";
            this.btnGrupoProd.Size = new System.Drawing.Size(29, 27);
            this.btnGrupoProd.TabIndex = 51;
            this.btnGrupoProd.UseSelectable = true;
            this.btnGrupoProd.Click += new System.EventHandler(this.btnGrupoProd_Click);
            // 
            // btnTipoProd
            // 
            this.btnTipoProd.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoProd.Image")));
            this.btnTipoProd.ImageSize = 24;
            this.btnTipoProd.Location = new System.Drawing.Point(234, 237);
            this.btnTipoProd.Name = "btnTipoProd";
            this.btnTipoProd.Size = new System.Drawing.Size(29, 27);
            this.btnTipoProd.TabIndex = 50;
            this.btnTipoProd.UseSelectable = true;
            this.btnTipoProd.Click += new System.EventHandler(this.btnTipoProd_Click);
            // 
            // btnModelo
            // 
            this.btnModelo.Image = ((System.Drawing.Image)(resources.GetObject("btnModelo.Image")));
            this.btnModelo.ImageSize = 24;
            this.btnModelo.Location = new System.Drawing.Point(510, 174);
            this.btnModelo.Name = "btnModelo";
            this.btnModelo.Size = new System.Drawing.Size(29, 27);
            this.btnModelo.TabIndex = 49;
            this.btnModelo.UseSelectable = true;
            this.btnModelo.Click += new System.EventHandler(this.btnModelo_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnMarca.Image")));
            this.btnMarca.ImageSize = 24;
            this.btnMarca.Location = new System.Drawing.Point(510, 138);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(29, 27);
            this.btnMarca.TabIndex = 48;
            this.btnMarca.UseSelectable = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click);
            // 
            // btnSubFamilia
            // 
            this.btnSubFamilia.Image = ((System.Drawing.Image)(resources.GetObject("btnSubFamilia.Image")));
            this.btnSubFamilia.ImageSize = 24;
            this.btnSubFamilia.Location = new System.Drawing.Point(233, 174);
            this.btnSubFamilia.Name = "btnSubFamilia";
            this.btnSubFamilia.Size = new System.Drawing.Size(29, 27);
            this.btnSubFamilia.TabIndex = 47;
            this.btnSubFamilia.UseSelectable = true;
            this.btnSubFamilia.Click += new System.EventHandler(this.btnSubFamilia_Click);
            // 
            // btnFamilia
            // 
            this.btnFamilia.Image = ((System.Drawing.Image)(resources.GetObject("btnFamilia.Image")));
            this.btnFamilia.ImageSize = 24;
            this.btnFamilia.Location = new System.Drawing.Point(233, 138);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(29, 27);
            this.btnFamilia.TabIndex = 46;
            this.btnFamilia.UseSelectable = true;
            this.btnFamilia.Click += new System.EventHandler(this.btnFamilia_Click);
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtAltura.CustomButton.Image = null;
            this.txtAltura.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtAltura.CustomButton.Name = "";
            this.txtAltura.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAltura.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAltura.CustomButton.TabIndex = 1;
            this.txtAltura.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAltura.CustomButton.UseSelectable = true;
            this.txtAltura.CustomButton.Visible = false;
            this.txtAltura.Lines = new string[0];
            this.txtAltura.Location = new System.Drawing.Point(257, 426);
            this.txtAltura.MaxLength = 32767;
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.PasswordChar = '\0';
            this.txtAltura.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAltura.SelectedText = "";
            this.txtAltura.SelectionLength = 0;
            this.txtAltura.SelectionStart = 0;
            this.txtAltura.ShortcutsEnabled = true;
            this.txtAltura.Size = new System.Drawing.Size(104, 23);
            this.txtAltura.TabIndex = 40;
            this.txtAltura.UseCustomBackColor = true;
            this.txtAltura.UseSelectable = true;
            this.txtAltura.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAltura.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAltura.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtLargo
            // 
            this.txtLargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtLargo.CustomButton.Image = null;
            this.txtLargo.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtLargo.CustomButton.Name = "";
            this.txtLargo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLargo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLargo.CustomButton.TabIndex = 1;
            this.txtLargo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLargo.CustomButton.UseSelectable = true;
            this.txtLargo.CustomButton.Visible = false;
            this.txtLargo.Lines = new string[0];
            this.txtLargo.Location = new System.Drawing.Point(433, 426);
            this.txtLargo.MaxLength = 32767;
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.PasswordChar = '\0';
            this.txtLargo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLargo.SelectedText = "";
            this.txtLargo.SelectionLength = 0;
            this.txtLargo.SelectionStart = 0;
            this.txtLargo.ShortcutsEnabled = true;
            this.txtLargo.Size = new System.Drawing.Size(104, 23);
            this.txtLargo.TabIndex = 38;
            this.txtLargo.UseCustomBackColor = true;
            this.txtLargo.UseSelectable = true;
            this.txtLargo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLargo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLargo.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.ForeColor = System.Drawing.Color.Navy;
            this.lblAltura.Location = new System.Drawing.Point(204, 428);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(47, 19);
            this.lblAltura.TabIndex = 39;
            this.lblAltura.Text = "Altura:";
            this.lblAltura.UseCustomForeColor = true;
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.ForeColor = System.Drawing.Color.Navy;
            this.lblLargo.Location = new System.Drawing.Point(379, 428);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(46, 19);
            this.lblLargo.TabIndex = 37;
            this.lblLargo.Text = "Largo:";
            this.lblLargo.UseCustomForeColor = true;
            // 
            // txtAncho
            // 
            this.txtAncho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtAncho.CustomButton.Image = null;
            this.txtAncho.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtAncho.CustomButton.Name = "";
            this.txtAncho.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAncho.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAncho.CustomButton.TabIndex = 1;
            this.txtAncho.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAncho.CustomButton.UseSelectable = true;
            this.txtAncho.CustomButton.Visible = false;
            this.txtAncho.Lines = new string[0];
            this.txtAncho.Location = new System.Drawing.Point(75, 426);
            this.txtAncho.MaxLength = 32767;
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.PasswordChar = '\0';
            this.txtAncho.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAncho.SelectedText = "";
            this.txtAncho.SelectionLength = 0;
            this.txtAncho.SelectionStart = 0;
            this.txtAncho.ShortcutsEnabled = true;
            this.txtAncho.Size = new System.Drawing.Size(104, 23);
            this.txtAncho.TabIndex = 36;
            this.txtAncho.UseCustomBackColor = true;
            this.txtAncho.UseSelectable = true;
            this.txtAncho.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAncho.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAncho.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtReferencia.CustomButton.Image = null;
            this.txtReferencia.CustomButton.Location = new System.Drawing.Point(440, 1);
            this.txtReferencia.CustomButton.Name = "";
            this.txtReferencia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReferencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReferencia.CustomButton.TabIndex = 1;
            this.txtReferencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReferencia.CustomButton.UseSelectable = true;
            this.txtReferencia.CustomButton.Visible = false;
            this.txtReferencia.Lines = new string[0];
            this.txtReferencia.Location = new System.Drawing.Point(75, 371);
            this.txtReferencia.MaxLength = 32767;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.PasswordChar = '\0';
            this.txtReferencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReferencia.SelectedText = "";
            this.txtReferencia.SelectionLength = 0;
            this.txtReferencia.SelectionStart = 0;
            this.txtReferencia.ShortcutsEnabled = true;
            this.txtReferencia.Size = new System.Drawing.Size(462, 23);
            this.txtReferencia.TabIndex = 32;
            this.txtReferencia.UseCustomBackColor = true;
            this.txtReferencia.UseSelectable = true;
            this.txtReferencia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReferencia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtReferencia.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPeso.CustomButton.Image = null;
            this.txtPeso.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtPeso.CustomButton.Name = "";
            this.txtPeso.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPeso.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPeso.CustomButton.TabIndex = 1;
            this.txtPeso.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPeso.CustomButton.UseSelectable = true;
            this.txtPeso.CustomButton.Visible = false;
            this.txtPeso.Lines = new string[0];
            this.txtPeso.Location = new System.Drawing.Point(257, 460);
            this.txtPeso.MaxLength = 32767;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.PasswordChar = '\0';
            this.txtPeso.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPeso.SelectedText = "";
            this.txtPeso.SelectionLength = 0;
            this.txtPeso.SelectionStart = 0;
            this.txtPeso.ShortcutsEnabled = true;
            this.txtPeso.Size = new System.Drawing.Size(104, 23);
            this.txtPeso.TabIndex = 34;
            this.txtPeso.UseCustomBackColor = true;
            this.txtPeso.UseSelectable = true;
            this.txtPeso.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPeso.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPeso.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.ForeColor = System.Drawing.Color.Navy;
            this.lblReferencia.Location = new System.Drawing.Point(1, 373);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(73, 19);
            this.lblReferencia.TabIndex = 31;
            this.lblReferencia.Text = "Referencia:";
            this.lblReferencia.UseCustomForeColor = true;
            // 
            // chkCombo
            // 
            this.chkCombo.AutoSize = true;
            this.chkCombo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkCombo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkCombo.ForeColor = System.Drawing.Color.Navy;
            this.chkCombo.Location = new System.Drawing.Point(455, 338);
            this.chkCombo.Name = "chkCombo";
            this.chkCombo.Size = new System.Drawing.Size(70, 19);
            this.chkCombo.TabIndex = 29;
            this.chkCombo.Text = "Combo";
            this.chkCombo.UseCustomForeColor = true;
            this.chkCombo.UseSelectable = true;
            this.chkCombo.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.ForeColor = System.Drawing.Color.Navy;
            this.lblAncho.Location = new System.Drawing.Point(5, 428);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(49, 19);
            this.lblAncho.TabIndex = 35;
            this.lblAncho.Text = "Ancho:";
            this.lblAncho.UseCustomForeColor = true;
            // 
            // chkProductoCompra
            // 
            this.chkProductoCompra.AutoSize = true;
            this.chkProductoCompra.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkProductoCompra.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkProductoCompra.ForeColor = System.Drawing.Color.Navy;
            this.chkProductoCompra.Location = new System.Drawing.Point(223, 338);
            this.chkProductoCompra.Name = "chkProductoCompra";
            this.chkProductoCompra.Size = new System.Drawing.Size(132, 19);
            this.chkProductoCompra.TabIndex = 27;
            this.chkProductoCompra.Text = "Producto Compra";
            this.chkProductoCompra.UseCustomForeColor = true;
            this.chkProductoCompra.UseSelectable = true;
            this.chkProductoCompra.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // chkProductoVenta
            // 
            this.chkProductoVenta.AutoSize = true;
            this.chkProductoVenta.Checked = true;
            this.chkProductoVenta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProductoVenta.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkProductoVenta.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkProductoVenta.ForeColor = System.Drawing.Color.Navy;
            this.chkProductoVenta.Location = new System.Drawing.Point(87, 338);
            this.chkProductoVenta.Name = "chkProductoVenta";
            this.chkProductoVenta.Size = new System.Drawing.Size(115, 19);
            this.chkProductoVenta.TabIndex = 26;
            this.chkProductoVenta.Text = "Producto Venta";
            this.chkProductoVenta.UseCustomForeColor = true;
            this.chkProductoVenta.UseSelectable = true;
            this.chkProductoVenta.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.ForeColor = System.Drawing.Color.Navy;
            this.lblPeso.Location = new System.Drawing.Point(204, 462);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 19);
            this.lblPeso.TabIndex = 33;
            this.lblPeso.Text = "Peso:";
            this.lblPeso.UseCustomForeColor = true;
            // 
            // cboClaseProd
            // 
            this.cboClaseProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboClaseProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClaseProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClaseProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClaseProd.FormattingEnabled = true;
            this.cboClaseProd.Location = new System.Drawing.Point(353, 277);
            this.cboClaseProd.Name = "cboClaseProd";
            this.cboClaseProd.Size = new System.Drawing.Size(152, 23);
            this.cboClaseProd.TabIndex = 25;
            this.cboClaseProd.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboGrupoProd
            // 
            this.cboGrupoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboGrupoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboGrupoProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGrupoProd.FormattingEnabled = true;
            this.cboGrupoProd.Location = new System.Drawing.Point(353, 241);
            this.cboGrupoProd.Name = "cboGrupoProd";
            this.cboGrupoProd.Size = new System.Drawing.Size(152, 23);
            this.cboGrupoProd.TabIndex = 21;
            this.cboGrupoProd.SelectedIndexChanged += new System.EventHandler(this.cboGrupoProd_SelectedIndexChanged);
            // 
            // cboTipoExistencia
            // 
            this.cboTipoExistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTipoExistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoExistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoExistencia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoExistencia.FormattingEnabled = true;
            this.cboTipoExistencia.Location = new System.Drawing.Point(75, 277);
            this.cboTipoExistencia.Name = "cboTipoExistencia";
            this.cboTipoExistencia.Size = new System.Drawing.Size(184, 23);
            this.cboTipoExistencia.TabIndex = 23;
            this.cboTipoExistencia.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboTipoProd
            // 
            this.cboTipoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTipoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoProd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoProd.FormattingEnabled = true;
            this.cboTipoProd.Location = new System.Drawing.Point(76, 241);
            this.cboTipoProd.Name = "cboTipoProd";
            this.cboTipoProd.Size = new System.Drawing.Size(152, 23);
            this.cboTipoProd.TabIndex = 19;
            this.cboTipoProd.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblClaseProd
            // 
            this.lblClaseProd.AutoSize = true;
            this.lblClaseProd.ForeColor = System.Drawing.Color.Navy;
            this.lblClaseProd.Location = new System.Drawing.Point(283, 279);
            this.lblClaseProd.Name = "lblClaseProd";
            this.lblClaseProd.Size = new System.Drawing.Size(43, 19);
            this.lblClaseProd.TabIndex = 24;
            this.lblClaseProd.Text = "Clase:";
            this.lblClaseProd.UseCustomForeColor = true;
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.ForeColor = System.Drawing.Color.Navy;
            this.lblGrupo.Location = new System.Drawing.Point(283, 243);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(49, 19);
            this.lblGrupo.TabIndex = 20;
            this.lblGrupo.Text = "Grupo:";
            this.lblGrupo.UseCustomForeColor = true;
            // 
            // lblTipoExistencia
            // 
            this.lblTipoExistencia.AutoSize = true;
            this.lblTipoExistencia.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoExistencia.Location = new System.Drawing.Point(-1, 279);
            this.lblTipoExistencia.Name = "lblTipoExistencia";
            this.lblTipoExistencia.Size = new System.Drawing.Size(79, 19);
            this.lblTipoExistencia.TabIndex = 22;
            this.lblTipoExistencia.Text = "T. Existencia:";
            this.lblTipoExistencia.UseCustomForeColor = true;
            // 
            // lblTipoProd
            // 
            this.lblTipoProd.AutoSize = true;
            this.lblTipoProd.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoProd.Location = new System.Drawing.Point(-2, 243);
            this.lblTipoProd.Name = "lblTipoProd";
            this.lblTipoProd.Size = new System.Drawing.Size(71, 19);
            this.lblTipoProd.TabIndex = 18;
            this.lblTipoProd.Text = "Tipo Prod:";
            this.lblTipoProd.UseCustomForeColor = true;
            // 
            // cboModelo
            // 
            this.cboModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboModelo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(353, 178);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(152, 23);
            this.cboModelo.TabIndex = 17;
            this.cboModelo.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(353, 142);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(152, 23);
            this.cboMarca.TabIndex = 13;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.cboMarca_SelectedIndexChanged);
            // 
            // cboSubFamilia
            // 
            this.cboSubFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboSubFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSubFamilia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSubFamilia.FormattingEnabled = true;
            this.cboSubFamilia.Location = new System.Drawing.Point(75, 178);
            this.cboSubFamilia.Name = "cboSubFamilia";
            this.cboSubFamilia.Size = new System.Drawing.Size(152, 23);
            this.cboSubFamilia.TabIndex = 15;
            this.cboSubFamilia.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboFamilia
            // 
            this.cboFamilia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboFamilia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFamilia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFamilia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFamilia.FormattingEnabled = true;
            this.cboFamilia.Location = new System.Drawing.Point(75, 142);
            this.cboFamilia.Name = "cboFamilia";
            this.cboFamilia.Size = new System.Drawing.Size(152, 23);
            this.cboFamilia.TabIndex = 11;
            this.cboFamilia.SelectedIndexChanged += new System.EventHandler(this.cboFamilia_SelectedIndexChanged);
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.ForeColor = System.Drawing.Color.Navy;
            this.lblModelo.Location = new System.Drawing.Point(283, 180);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(58, 19);
            this.lblModelo.TabIndex = 16;
            this.lblModelo.Text = "Modelo:";
            this.lblModelo.UseCustomForeColor = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.Color.Navy;
            this.lblMarca.Location = new System.Drawing.Point(283, 144);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(49, 19);
            this.lblMarca.TabIndex = 12;
            this.lblMarca.Text = "Marca:";
            this.lblMarca.UseCustomForeColor = true;
            // 
            // lblSubFamilia
            // 
            this.lblSubFamilia.AutoSize = true;
            this.lblSubFamilia.ForeColor = System.Drawing.Color.Navy;
            this.lblSubFamilia.Location = new System.Drawing.Point(-2, 180);
            this.lblSubFamilia.Name = "lblSubFamilia";
            this.lblSubFamilia.Size = new System.Drawing.Size(79, 19);
            this.lblSubFamilia.TabIndex = 14;
            this.lblSubFamilia.Text = "Sub Familia:";
            this.lblSubFamilia.UseCustomForeColor = true;
            // 
            // lblFamilia
            // 
            this.lblFamilia.AutoSize = true;
            this.lblFamilia.ForeColor = System.Drawing.Color.Navy;
            this.lblFamilia.Location = new System.Drawing.Point(-2, 144);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(53, 19);
            this.lblFamilia.TabIndex = 10;
            this.lblFamilia.Text = "Familia:";
            this.lblFamilia.UseCustomForeColor = true;
            // 
            // txtCodigo02
            // 
            this.txtCodigo02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodigo02.CustomButton.Image = null;
            this.txtCodigo02.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtCodigo02.CustomButton.Name = "";
            this.txtCodigo02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo02.CustomButton.TabIndex = 1;
            this.txtCodigo02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo02.CustomButton.UseSelectable = true;
            this.txtCodigo02.CustomButton.Visible = false;
            this.txtCodigo02.Lines = new string[0];
            this.txtCodigo02.Location = new System.Drawing.Point(353, 47);
            this.txtCodigo02.MaxLength = 32767;
            this.txtCodigo02.Name = "txtCodigo02";
            this.txtCodigo02.PasswordChar = '\0';
            this.txtCodigo02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo02.SelectedText = "";
            this.txtCodigo02.SelectionLength = 0;
            this.txtCodigo02.SelectionStart = 0;
            this.txtCodigo02.ShortcutsEnabled = true;
            this.txtCodigo02.Size = new System.Drawing.Size(184, 23);
            this.txtCodigo02.TabIndex = 5;
            this.txtCodigo02.UseCustomBackColor = true;
            this.txtCodigo02.UseSelectable = true;
            this.txtCodigo02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCodigo02
            // 
            this.lblCodigo02.AutoSize = true;
            this.lblCodigo02.ForeColor = System.Drawing.Color.Navy;
            this.lblCodigo02.Location = new System.Drawing.Point(281, 49);
            this.lblCodigo02.Name = "lblCodigo02";
            this.lblCodigo02.Size = new System.Drawing.Size(74, 19);
            this.lblCodigo02.TabIndex = 4;
            this.lblCodigo02.Text = "Código 02:";
            this.lblCodigo02.UseCustomForeColor = true;
            // 
            // txtCodBarra
            // 
            this.txtCodBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodBarra.CustomButton.Image = null;
            this.txtCodBarra.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtCodBarra.CustomButton.Name = "";
            this.txtCodBarra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodBarra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodBarra.CustomButton.TabIndex = 1;
            this.txtCodBarra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodBarra.CustomButton.UseSelectable = true;
            this.txtCodBarra.CustomButton.Visible = false;
            this.txtCodBarra.Lines = new string[0];
            this.txtCodBarra.Location = new System.Drawing.Point(75, 83);
            this.txtCodBarra.MaxLength = 32767;
            this.txtCodBarra.Name = "txtCodBarra";
            this.txtCodBarra.PasswordChar = '\0';
            this.txtCodBarra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodBarra.SelectedText = "";
            this.txtCodBarra.SelectionLength = 0;
            this.txtCodBarra.SelectionStart = 0;
            this.txtCodBarra.ShortcutsEnabled = true;
            this.txtCodBarra.Size = new System.Drawing.Size(184, 23);
            this.txtCodBarra.TabIndex = 7;
            this.txtCodBarra.UseCustomBackColor = true;
            this.txtCodBarra.UseSelectable = true;
            this.txtCodBarra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodBarra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodBarra.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCodBarra
            // 
            this.lblCodBarra.AutoSize = true;
            this.lblCodBarra.ForeColor = System.Drawing.Color.Navy;
            this.lblCodBarra.Location = new System.Drawing.Point(3, 85);
            this.lblCodBarra.Name = "lblCodBarra";
            this.lblCodBarra.Size = new System.Drawing.Size(76, 19);
            this.lblCodBarra.TabIndex = 6;
            this.lblCodBarra.Text = "Cód. Barra:";
            this.lblCodBarra.UseCustomForeColor = true;
            // 
            // txtCodigo01
            // 
            this.txtCodigo01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodigo01.CustomButton.Image = null;
            this.txtCodigo01.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtCodigo01.CustomButton.Name = "";
            this.txtCodigo01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo01.CustomButton.TabIndex = 1;
            this.txtCodigo01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo01.CustomButton.UseSelectable = true;
            this.txtCodigo01.CustomButton.Visible = false;
            this.txtCodigo01.Lines = new string[0];
            this.txtCodigo01.Location = new System.Drawing.Point(75, 47);
            this.txtCodigo01.MaxLength = 32767;
            this.txtCodigo01.Name = "txtCodigo01";
            this.txtCodigo01.PasswordChar = '\0';
            this.txtCodigo01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo01.SelectedText = "";
            this.txtCodigo01.SelectionLength = 0;
            this.txtCodigo01.SelectionStart = 0;
            this.txtCodigo01.ShortcutsEnabled = true;
            this.txtCodigo01.Size = new System.Drawing.Size(184, 23);
            this.txtCodigo01.TabIndex = 3;
            this.txtCodigo01.UseCustomBackColor = true;
            this.txtCodigo01.UseSelectable = true;
            this.txtCodigo01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCodigo01
            // 
            this.lblCodigo01.AutoSize = true;
            this.lblCodigo01.ForeColor = System.Drawing.Color.Navy;
            this.lblCodigo01.Location = new System.Drawing.Point(1, 49);
            this.lblCodigo01.Name = "lblCodigo01";
            this.lblCodigo01.Size = new System.Drawing.Size(72, 19);
            this.lblCodigo01.TabIndex = 2;
            this.lblCodigo01.Text = "Código 01:";
            this.lblCodigo01.UseCustomForeColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(440, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(75, 11);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(462, 23);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.UseCustomBackColor = true;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(1, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseCustomForeColor = true;
            // 
            // tabPagPrecio
            // 
            this.tabPagPrecio.Controls.Add(this.lblPorcentajeAcumuladoImpto);
            this.tabPagPrecio.Controls.Add(this.lblSimboloPorcentaje);
            this.tabPagPrecio.Controls.Add(this.grbCostoProd);
            this.tabPagPrecio.Controls.Add(this.grbConImpto);
            this.tabPagPrecio.Controls.Add(this.grbSinImpto);
            this.tabPagPrecio.Controls.Add(this.chkInafecto);
            this.tabPagPrecio.Controls.Add(this.chkExento);
            this.tabPagPrecio.Controls.Add(this.chkImpto);
            this.tabPagPrecio.Controls.Add(this.cboImpuesto);
            this.tabPagPrecio.Controls.Add(this.cboTipoMoneda);
            this.tabPagPrecio.Controls.Add(this.lblImpuesto);
            this.tabPagPrecio.Controls.Add(this.lblTipoMoneda);
            this.tabPagPrecio.Controls.Add(this.btnImpuesto);
            this.tabPagPrecio.HorizontalScrollbarBarColor = true;
            this.tabPagPrecio.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagPrecio.HorizontalScrollbarSize = 10;
            this.tabPagPrecio.Location = new System.Drawing.Point(4, 38);
            this.tabPagPrecio.Name = "tabPagPrecio";
            this.tabPagPrecio.Size = new System.Drawing.Size(556, 485);
            this.tabPagPrecio.TabIndex = 1;
            this.tabPagPrecio.Text = "Precios";
            this.tabPagPrecio.VerticalScrollbarBarColor = true;
            this.tabPagPrecio.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagPrecio.VerticalScrollbarSize = 10;
            // 
            // lblPorcentajeAcumuladoImpto
            // 
            this.lblPorcentajeAcumuladoImpto.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentajeAcumuladoImpto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeAcumuladoImpto.ForeColor = System.Drawing.Color.Navy;
            this.lblPorcentajeAcumuladoImpto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPorcentajeAcumuladoImpto.Location = new System.Drawing.Point(348, 35);
            this.lblPorcentajeAcumuladoImpto.Name = "lblPorcentajeAcumuladoImpto";
            this.lblPorcentajeAcumuladoImpto.Size = new System.Drawing.Size(147, 17);
            this.lblPorcentajeAcumuladoImpto.TabIndex = 56;
            this.lblPorcentajeAcumuladoImpto.Text = "0";
            this.lblPorcentajeAcumuladoImpto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSimboloPorcentaje
            // 
            this.lblSimboloPorcentaje.AutoSize = true;
            this.lblSimboloPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblSimboloPorcentaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloPorcentaje.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorcentaje.Location = new System.Drawing.Point(495, 35);
            this.lblSimboloPorcentaje.Name = "lblSimboloPorcentaje";
            this.lblSimboloPorcentaje.Size = new System.Drawing.Size(19, 17);
            this.lblSimboloPorcentaje.TabIndex = 55;
            this.lblSimboloPorcentaje.Text = "%";
            // 
            // grbCostoProd
            // 
            this.grbCostoProd.BackColor = System.Drawing.Color.Transparent;
            this.grbCostoProd.Controls.Add(this.txtCostoProd);
            this.grbCostoProd.Controls.Add(this.lblCosto);
            this.grbCostoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbCostoProd.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCostoProd.ForeColor = System.Drawing.Color.Black;
            this.grbCostoProd.Location = new System.Drawing.Point(9, 267);
            this.grbCostoProd.Name = "grbCostoProd";
            this.grbCostoProd.Size = new System.Drawing.Size(251, 81);
            this.grbCostoProd.TabIndex = 9;
            this.grbCostoProd.TabStop = false;
            this.grbCostoProd.Text = "Costo del producto";
            // 
            // txtCostoProd
            // 
            this.txtCostoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCostoProd.CustomButton.Image = null;
            this.txtCostoProd.CustomButton.Location = new System.Drawing.Point(106, 1);
            this.txtCostoProd.CustomButton.Name = "";
            this.txtCostoProd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCostoProd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCostoProd.CustomButton.TabIndex = 1;
            this.txtCostoProd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCostoProd.CustomButton.UseSelectable = true;
            this.txtCostoProd.CustomButton.Visible = false;
            this.txtCostoProd.Lines = new string[0];
            this.txtCostoProd.Location = new System.Drawing.Point(96, 35);
            this.txtCostoProd.MaxLength = 32767;
            this.txtCostoProd.Name = "txtCostoProd";
            this.txtCostoProd.PasswordChar = '\0';
            this.txtCostoProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCostoProd.SelectedText = "";
            this.txtCostoProd.SelectionLength = 0;
            this.txtCostoProd.SelectionStart = 0;
            this.txtCostoProd.ShortcutsEnabled = true;
            this.txtCostoProd.Size = new System.Drawing.Size(128, 23);
            this.txtCostoProd.TabIndex = 1;
            this.txtCostoProd.UseCustomBackColor = true;
            this.txtCostoProd.UseSelectable = true;
            this.txtCostoProd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCostoProd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCostoProd.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.BackColor = System.Drawing.Color.Transparent;
            this.lblCosto.ForeColor = System.Drawing.Color.Navy;
            this.lblCosto.Location = new System.Drawing.Point(20, 35);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(50, 19);
            this.lblCosto.TabIndex = 0;
            this.lblCosto.Text = "Costo: ";
            this.lblCosto.UseCustomForeColor = true;
            // 
            // grbConImpto
            // 
            this.grbConImpto.BackColor = System.Drawing.Color.Transparent;
            this.grbConImpto.Controls.Add(this.txtPvMiConImpto);
            this.grbConImpto.Controls.Add(this.lblPvMiConIGV);
            this.grbConImpto.Controls.Add(this.txtPvMaConImpto);
            this.grbConImpto.Controls.Add(this.lblPvMaConIGV);
            this.grbConImpto.Controls.Add(this.txtPvPuConImpto);
            this.grbConImpto.Controls.Add(this.lblPvPuConIGV);
            this.grbConImpto.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConImpto.Location = new System.Drawing.Point(287, 88);
            this.grbConImpto.Name = "grbConImpto";
            this.grbConImpto.Size = new System.Drawing.Size(251, 160);
            this.grbConImpto.TabIndex = 8;
            this.grbConImpto.TabStop = false;
            this.grbConImpto.Text = "Precio con impuesto";
            // 
            // txtPvMiConImpto
            // 
            this.txtPvMiConImpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPvMiConImpto.CustomButton.Image = null;
            this.txtPvMiConImpto.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPvMiConImpto.CustomButton.Name = "";
            this.txtPvMiConImpto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPvMiConImpto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPvMiConImpto.CustomButton.TabIndex = 1;
            this.txtPvMiConImpto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPvMiConImpto.CustomButton.UseSelectable = true;
            this.txtPvMiConImpto.CustomButton.Visible = false;
            this.txtPvMiConImpto.Lines = new string[0];
            this.txtPvMiConImpto.Location = new System.Drawing.Point(100, 69);
            this.txtPvMiConImpto.MaxLength = 32767;
            this.txtPvMiConImpto.Name = "txtPvMiConImpto";
            this.txtPvMiConImpto.PasswordChar = '\0';
            this.txtPvMiConImpto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPvMiConImpto.SelectedText = "";
            this.txtPvMiConImpto.SelectionLength = 0;
            this.txtPvMiConImpto.SelectionStart = 0;
            this.txtPvMiConImpto.ShortcutsEnabled = true;
            this.txtPvMiConImpto.Size = new System.Drawing.Size(126, 23);
            this.txtPvMiConImpto.TabIndex = 3;
            this.txtPvMiConImpto.UseCustomBackColor = true;
            this.txtPvMiConImpto.UseSelectable = true;
            this.txtPvMiConImpto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPvMiConImpto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPvMiConImpto.TextChanged += new System.EventHandler(this.txtPvMiConImpto_TextChanged);
            // 
            // lblPvMiConIGV
            // 
            this.lblPvMiConIGV.AutoSize = true;
            this.lblPvMiConIGV.BackColor = System.Drawing.Color.Transparent;
            this.lblPvMiConIGV.ForeColor = System.Drawing.Color.Navy;
            this.lblPvMiConIGV.Location = new System.Drawing.Point(24, 70);
            this.lblPvMiConIGV.Name = "lblPvMiConIGV";
            this.lblPvMiConIGV.Size = new System.Drawing.Size(69, 19);
            this.lblPvMiConIGV.TabIndex = 2;
            this.lblPvMiConIGV.Text = "P. Mínimo:";
            this.lblPvMiConIGV.UseCustomForeColor = true;
            // 
            // txtPvMaConImpto
            // 
            this.txtPvMaConImpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPvMaConImpto.CustomButton.Image = null;
            this.txtPvMaConImpto.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPvMaConImpto.CustomButton.Name = "";
            this.txtPvMaConImpto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPvMaConImpto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPvMaConImpto.CustomButton.TabIndex = 1;
            this.txtPvMaConImpto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPvMaConImpto.CustomButton.UseSelectable = true;
            this.txtPvMaConImpto.CustomButton.Visible = false;
            this.txtPvMaConImpto.Lines = new string[0];
            this.txtPvMaConImpto.Location = new System.Drawing.Point(100, 110);
            this.txtPvMaConImpto.MaxLength = 32767;
            this.txtPvMaConImpto.Name = "txtPvMaConImpto";
            this.txtPvMaConImpto.PasswordChar = '\0';
            this.txtPvMaConImpto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPvMaConImpto.SelectedText = "";
            this.txtPvMaConImpto.SelectionLength = 0;
            this.txtPvMaConImpto.SelectionStart = 0;
            this.txtPvMaConImpto.ShortcutsEnabled = true;
            this.txtPvMaConImpto.Size = new System.Drawing.Size(126, 23);
            this.txtPvMaConImpto.TabIndex = 5;
            this.txtPvMaConImpto.UseCustomBackColor = true;
            this.txtPvMaConImpto.UseSelectable = true;
            this.txtPvMaConImpto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPvMaConImpto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPvMaConImpto.TextChanged += new System.EventHandler(this.txtPvMaConImpto_TextChanged);
            // 
            // lblPvMaConIGV
            // 
            this.lblPvMaConIGV.AutoSize = true;
            this.lblPvMaConIGV.BackColor = System.Drawing.Color.Transparent;
            this.lblPvMaConIGV.ForeColor = System.Drawing.Color.Navy;
            this.lblPvMaConIGV.Location = new System.Drawing.Point(24, 112);
            this.lblPvMaConIGV.Name = "lblPvMaConIGV";
            this.lblPvMaConIGV.Size = new System.Drawing.Size(72, 19);
            this.lblPvMaConIGV.TabIndex = 4;
            this.lblPvMaConIGV.Text = "P. Máximo:";
            this.lblPvMaConIGV.UseCustomForeColor = true;
            // 
            // txtPvPuConImpto
            // 
            this.txtPvPuConImpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPvPuConImpto.CustomButton.Image = null;
            this.txtPvPuConImpto.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPvPuConImpto.CustomButton.Name = "";
            this.txtPvPuConImpto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPvPuConImpto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPvPuConImpto.CustomButton.TabIndex = 1;
            this.txtPvPuConImpto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPvPuConImpto.CustomButton.UseSelectable = true;
            this.txtPvPuConImpto.CustomButton.Visible = false;
            this.txtPvPuConImpto.Lines = new string[0];
            this.txtPvPuConImpto.Location = new System.Drawing.Point(100, 28);
            this.txtPvPuConImpto.MaxLength = 32767;
            this.txtPvPuConImpto.Name = "txtPvPuConImpto";
            this.txtPvPuConImpto.PasswordChar = '\0';
            this.txtPvPuConImpto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPvPuConImpto.SelectedText = "";
            this.txtPvPuConImpto.SelectionLength = 0;
            this.txtPvPuConImpto.SelectionStart = 0;
            this.txtPvPuConImpto.ShortcutsEnabled = true;
            this.txtPvPuConImpto.Size = new System.Drawing.Size(126, 23);
            this.txtPvPuConImpto.TabIndex = 1;
            this.txtPvPuConImpto.UseCustomBackColor = true;
            this.txtPvPuConImpto.UseSelectable = true;
            this.txtPvPuConImpto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPvPuConImpto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPvPuConImpto.TextChanged += new System.EventHandler(this.txtPvPuConImpto_TextChanged);
            // 
            // lblPvPuConIGV
            // 
            this.lblPvPuConIGV.AutoSize = true;
            this.lblPvPuConIGV.BackColor = System.Drawing.Color.Transparent;
            this.lblPvPuConIGV.ForeColor = System.Drawing.Color.Navy;
            this.lblPvPuConIGV.Location = new System.Drawing.Point(24, 30);
            this.lblPvPuConIGV.Name = "lblPvPuConIGV";
            this.lblPvPuConIGV.Size = new System.Drawing.Size(70, 19);
            this.lblPvPuConIGV.TabIndex = 0;
            this.lblPvPuConIGV.Text = "P. Unitario:";
            this.lblPvPuConIGV.UseCustomForeColor = true;
            // 
            // grbSinImpto
            // 
            this.grbSinImpto.BackColor = System.Drawing.Color.Transparent;
            this.grbSinImpto.Controls.Add(this.txtPvMiSinImpto);
            this.grbSinImpto.Controls.Add(this.lblPvMiSinIGV);
            this.grbSinImpto.Controls.Add(this.txtPvMaSinImpto);
            this.grbSinImpto.Controls.Add(this.lblPvMaSinIGV);
            this.grbSinImpto.Controls.Add(this.txtPvPuSinImpto);
            this.grbSinImpto.Controls.Add(this.lblPvPuSinIGV);
            this.grbSinImpto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSinImpto.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSinImpto.ForeColor = System.Drawing.Color.Black;
            this.grbSinImpto.Location = new System.Drawing.Point(9, 88);
            this.grbSinImpto.Name = "grbSinImpto";
            this.grbSinImpto.Size = new System.Drawing.Size(251, 160);
            this.grbSinImpto.TabIndex = 7;
            this.grbSinImpto.TabStop = false;
            this.grbSinImpto.Text = "Precio sin impuesto";
            // 
            // txtPvMiSinImpto
            // 
            this.txtPvMiSinImpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPvMiSinImpto.CustomButton.Image = null;
            this.txtPvMiSinImpto.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPvMiSinImpto.CustomButton.Name = "";
            this.txtPvMiSinImpto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPvMiSinImpto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPvMiSinImpto.CustomButton.TabIndex = 1;
            this.txtPvMiSinImpto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPvMiSinImpto.CustomButton.UseSelectable = true;
            this.txtPvMiSinImpto.CustomButton.Visible = false;
            this.txtPvMiSinImpto.Lines = new string[0];
            this.txtPvMiSinImpto.Location = new System.Drawing.Point(98, 74);
            this.txtPvMiSinImpto.MaxLength = 32767;
            this.txtPvMiSinImpto.Name = "txtPvMiSinImpto";
            this.txtPvMiSinImpto.PasswordChar = '\0';
            this.txtPvMiSinImpto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPvMiSinImpto.SelectedText = "";
            this.txtPvMiSinImpto.SelectionLength = 0;
            this.txtPvMiSinImpto.SelectionStart = 0;
            this.txtPvMiSinImpto.ShortcutsEnabled = true;
            this.txtPvMiSinImpto.Size = new System.Drawing.Size(126, 23);
            this.txtPvMiSinImpto.TabIndex = 3;
            this.txtPvMiSinImpto.UseCustomBackColor = true;
            this.txtPvMiSinImpto.UseSelectable = true;
            this.txtPvMiSinImpto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPvMiSinImpto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPvMiSinImpto.TextChanged += new System.EventHandler(this.txtPvMiSinImpto_TextChanged);
            // 
            // lblPvMiSinIGV
            // 
            this.lblPvMiSinIGV.AutoSize = true;
            this.lblPvMiSinIGV.BackColor = System.Drawing.Color.Transparent;
            this.lblPvMiSinIGV.ForeColor = System.Drawing.Color.Navy;
            this.lblPvMiSinIGV.Location = new System.Drawing.Point(22, 75);
            this.lblPvMiSinIGV.Name = "lblPvMiSinIGV";
            this.lblPvMiSinIGV.Size = new System.Drawing.Size(69, 19);
            this.lblPvMiSinIGV.TabIndex = 2;
            this.lblPvMiSinIGV.Text = "P. Mínimo:";
            this.lblPvMiSinIGV.UseCustomForeColor = true;
            // 
            // txtPvMaSinImpto
            // 
            this.txtPvMaSinImpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPvMaSinImpto.CustomButton.Image = null;
            this.txtPvMaSinImpto.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPvMaSinImpto.CustomButton.Name = "";
            this.txtPvMaSinImpto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPvMaSinImpto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPvMaSinImpto.CustomButton.TabIndex = 1;
            this.txtPvMaSinImpto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPvMaSinImpto.CustomButton.UseSelectable = true;
            this.txtPvMaSinImpto.CustomButton.Visible = false;
            this.txtPvMaSinImpto.Lines = new string[0];
            this.txtPvMaSinImpto.Location = new System.Drawing.Point(98, 115);
            this.txtPvMaSinImpto.MaxLength = 32767;
            this.txtPvMaSinImpto.Name = "txtPvMaSinImpto";
            this.txtPvMaSinImpto.PasswordChar = '\0';
            this.txtPvMaSinImpto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPvMaSinImpto.SelectedText = "";
            this.txtPvMaSinImpto.SelectionLength = 0;
            this.txtPvMaSinImpto.SelectionStart = 0;
            this.txtPvMaSinImpto.ShortcutsEnabled = true;
            this.txtPvMaSinImpto.Size = new System.Drawing.Size(126, 23);
            this.txtPvMaSinImpto.TabIndex = 5;
            this.txtPvMaSinImpto.UseCustomBackColor = true;
            this.txtPvMaSinImpto.UseSelectable = true;
            this.txtPvMaSinImpto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPvMaSinImpto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPvMaSinImpto.TextChanged += new System.EventHandler(this.txtPvMaSinImpto_TextChanged);
            // 
            // lblPvMaSinIGV
            // 
            this.lblPvMaSinIGV.AutoSize = true;
            this.lblPvMaSinIGV.BackColor = System.Drawing.Color.Transparent;
            this.lblPvMaSinIGV.ForeColor = System.Drawing.Color.Navy;
            this.lblPvMaSinIGV.Location = new System.Drawing.Point(22, 117);
            this.lblPvMaSinIGV.Name = "lblPvMaSinIGV";
            this.lblPvMaSinIGV.Size = new System.Drawing.Size(72, 19);
            this.lblPvMaSinIGV.TabIndex = 4;
            this.lblPvMaSinIGV.Text = "P. Máximo:";
            this.lblPvMaSinIGV.UseCustomForeColor = true;
            // 
            // txtPvPuSinImpto
            // 
            this.txtPvPuSinImpto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPvPuSinImpto.CustomButton.Image = null;
            this.txtPvPuSinImpto.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPvPuSinImpto.CustomButton.Name = "";
            this.txtPvPuSinImpto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPvPuSinImpto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPvPuSinImpto.CustomButton.TabIndex = 1;
            this.txtPvPuSinImpto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPvPuSinImpto.CustomButton.UseSelectable = true;
            this.txtPvPuSinImpto.CustomButton.Visible = false;
            this.txtPvPuSinImpto.Lines = new string[0];
            this.txtPvPuSinImpto.Location = new System.Drawing.Point(98, 33);
            this.txtPvPuSinImpto.MaxLength = 32767;
            this.txtPvPuSinImpto.Name = "txtPvPuSinImpto";
            this.txtPvPuSinImpto.PasswordChar = '\0';
            this.txtPvPuSinImpto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPvPuSinImpto.SelectedText = "";
            this.txtPvPuSinImpto.SelectionLength = 0;
            this.txtPvPuSinImpto.SelectionStart = 0;
            this.txtPvPuSinImpto.ShortcutsEnabled = true;
            this.txtPvPuSinImpto.Size = new System.Drawing.Size(126, 23);
            this.txtPvPuSinImpto.TabIndex = 1;
            this.txtPvPuSinImpto.UseCustomBackColor = true;
            this.txtPvPuSinImpto.UseSelectable = true;
            this.txtPvPuSinImpto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPvPuSinImpto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPvPuSinImpto.TextChanged += new System.EventHandler(this.txtPvPuSinImpto_TextChanged);
            // 
            // lblPvPuSinIGV
            // 
            this.lblPvPuSinIGV.AutoSize = true;
            this.lblPvPuSinIGV.BackColor = System.Drawing.Color.Transparent;
            this.lblPvPuSinIGV.ForeColor = System.Drawing.Color.Navy;
            this.lblPvPuSinIGV.Location = new System.Drawing.Point(22, 35);
            this.lblPvPuSinIGV.Name = "lblPvPuSinIGV";
            this.lblPvPuSinIGV.Size = new System.Drawing.Size(70, 19);
            this.lblPvPuSinIGV.TabIndex = 0;
            this.lblPvPuSinIGV.Text = "P. Unitario:";
            this.lblPvPuSinIGV.UseCustomForeColor = true;
            // 
            // chkInafecto
            // 
            this.chkInafecto.AutoSize = true;
            this.chkInafecto.BackColor = System.Drawing.Color.Transparent;
            this.chkInafecto.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkInafecto.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkInafecto.ForeColor = System.Drawing.Color.Navy;
            this.chkInafecto.Location = new System.Drawing.Point(317, 56);
            this.chkInafecto.Name = "chkInafecto";
            this.chkInafecto.Size = new System.Drawing.Size(129, 19);
            this.chkInafecto.TabIndex = 6;
            this.chkInafecto.Text = "Producto Inafecto";
            this.chkInafecto.UseCustomForeColor = true;
            this.chkInafecto.UseSelectable = true;
            this.chkInafecto.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // chkExento
            // 
            this.chkExento.AutoSize = true;
            this.chkExento.BackColor = System.Drawing.Color.Transparent;
            this.chkExento.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkExento.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkExento.ForeColor = System.Drawing.Color.Navy;
            this.chkExento.Location = new System.Drawing.Point(189, 56);
            this.chkExento.Name = "chkExento";
            this.chkExento.Size = new System.Drawing.Size(122, 19);
            this.chkExento.TabIndex = 5;
            this.chkExento.Text = "Producto Exento";
            this.chkExento.UseCustomForeColor = true;
            this.chkExento.UseSelectable = true;
            this.chkExento.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // chkImpto
            // 
            this.chkImpto.AutoSize = true;
            this.chkImpto.BackColor = System.Drawing.Color.Transparent;
            this.chkImpto.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkImpto.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkImpto.ForeColor = System.Drawing.Color.Navy;
            this.chkImpto.Location = new System.Drawing.Point(8, 56);
            this.chkImpto.Name = "chkImpto";
            this.chkImpto.Size = new System.Drawing.Size(175, 19);
            this.chkImpto.TabIndex = 4;
            this.chkImpto.Text = "Precios incluyen impuesto";
            this.chkImpto.UseCustomForeColor = true;
            this.chkImpto.UseSelectable = true;
            this.chkImpto.CheckedChanged += new System.EventHandler(this.chkImpto_CheckedChanged);
            // 
            // cboImpuesto
            // 
            this.cboImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboImpuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpuesto.FormattingEnabled = true;
            this.cboImpuesto.Location = new System.Drawing.Point(348, 12);
            this.cboImpuesto.Name = "cboImpuesto";
            this.cboImpuesto.Size = new System.Drawing.Size(166, 23);
            this.cboImpuesto.TabIndex = 3;
            this.cboImpuesto.SelectedIndexChanged += new System.EventHandler(this.cboImpuesto_SelectedIndexChanged);
            // 
            // cboTipoMoneda
            // 
            this.cboTipoMoneda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTipoMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoMoneda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoMoneda.FormattingEnabled = true;
            this.cboTipoMoneda.Location = new System.Drawing.Point(78, 12);
            this.cboTipoMoneda.Name = "cboTipoMoneda";
            this.cboTipoMoneda.Size = new System.Drawing.Size(182, 23);
            this.cboTipoMoneda.TabIndex = 1;
            this.cboTipoMoneda.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuesto.ForeColor = System.Drawing.Color.Navy;
            this.lblImpuesto.Location = new System.Drawing.Point(286, 14);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(66, 19);
            this.lblImpuesto.TabIndex = 2;
            this.lblImpuesto.Text = "Impuesto:";
            this.lblImpuesto.UseCustomForeColor = true;
            // 
            // lblTipoMoneda
            // 
            this.lblTipoMoneda.AutoSize = true;
            this.lblTipoMoneda.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoMoneda.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoMoneda.Location = new System.Drawing.Point(1, 14);
            this.lblTipoMoneda.Name = "lblTipoMoneda";
            this.lblTipoMoneda.Size = new System.Drawing.Size(61, 19);
            this.lblTipoMoneda.TabIndex = 0;
            this.lblTipoMoneda.Text = "Moneda:";
            this.lblTipoMoneda.UseCustomForeColor = true;
            // 
            // btnImpuesto
            // 
            this.btnImpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnImpuesto.Image")));
            this.btnImpuesto.ImageSize = 24;
            this.btnImpuesto.Location = new System.Drawing.Point(517, 8);
            this.btnImpuesto.Name = "btnImpuesto";
            this.btnImpuesto.Size = new System.Drawing.Size(29, 27);
            this.btnImpuesto.TabIndex = 54;
            this.btnImpuesto.UseSelectable = true;
            this.btnImpuesto.Click += new System.EventHandler(this.btnImpuesto_Click);
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(84, 11);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(183, 23);
            this.cboFiltro.TabIndex = 3;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // txtFiltro
            // 
            // 
            // 
            // 
            this.txtFiltro.CustomButton.Image = null;
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(291, 11);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PromptText = "Filtro";
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(205, 23);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.UseSelectable = true;
            this.txtFiltro.WaterMark = "Filtro";
            this.txtFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // panelMantenimiento
            // 
            this.panelMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panelMantenimiento.Controls.Add(this.btnSearch);
            this.panelMantenimiento.Controls.Add(this.btnNuevo);
            this.panelMantenimiento.Controls.Add(this.btnRollback);
            this.panelMantenimiento.Controls.Add(this.btnCommit);
            this.panelMantenimiento.Controls.Add(this.btnDelete);
            this.panelMantenimiento.HorizontalScrollbarBarColor = true;
            this.panelMantenimiento.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMantenimiento.HorizontalScrollbarSize = 10;
            this.panelMantenimiento.Location = new System.Drawing.Point(428, 43);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(547, 49);
            this.panelMantenimiento.Style = MetroFramework.MetroColorStyle.Green;
            this.panelMantenimiento.TabIndex = 2;
            this.panelMantenimiento.UseCustomBackColor = true;
            this.panelMantenimiento.UseStyleColors = true;
            this.panelMantenimiento.VerticalScrollbarBarColor = true;
            this.panelMantenimiento.VerticalScrollbarHighlightOnWheel = false;
            this.panelMantenimiento.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(3, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(375, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRollback
            // 
            this.btnRollback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRollback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRollback.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRollback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollback.Image = ((System.Drawing.Image)(resources.GetObject("btnRollback.Image")));
            this.btnRollback.Location = new System.Drawing.Point(501, 5);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(40, 40);
            this.btnRollback.TabIndex = 3;
            this.btnRollback.UseVisualStyleBackColor = false;
            this.btnRollback.Click += new System.EventHandler(this.btnRollback_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCommit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCommit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Image = ((System.Drawing.Image)(resources.GetObject("btnCommit.Image")));
            this.btnCommit.Location = new System.Drawing.Point(459, 5);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(40, 40);
            this.btnCommit.TabIndex = 0;
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(417, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(137, 117);
            this.tglListarInactivos.Name = "tglListarInactivos";
            this.tglListarInactivos.Size = new System.Drawing.Size(80, 17);
            this.tglListarInactivos.TabIndex = 5;
            this.tglListarInactivos.Text = "Off";
            this.tglListarInactivos.UseSelectable = true;
            this.tglListarInactivos.Click += new System.EventHandler(this.tglListarInactivos_Click);
            // 
            // lblListarInactivos
            // 
            this.lblListarInactivos.AutoSize = true;
            this.lblListarInactivos.Location = new System.Drawing.Point(39, 115);
            this.lblListarInactivos.Name = "lblListarInactivos";
            this.lblListarInactivos.Size = new System.Drawing.Size(92, 19);
            this.lblListarInactivos.TabIndex = 4;
            this.lblListarInactivos.Text = "Listar inactivos";
            // 
            // panelFiltro
            // 
            this.panelFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panelFiltro.Controls.Add(this.lblFiltro);
            this.panelFiltro.Controls.Add(this.btnFilter);
            this.panelFiltro.Controls.Add(this.txtFiltro);
            this.panelFiltro.Controls.Add(this.cboFiltro);
            this.panelFiltro.HorizontalScrollbarBarColor = true;
            this.panelFiltro.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFiltro.HorizontalScrollbarSize = 10;
            this.panelFiltro.Location = new System.Drawing.Point(429, 631);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(547, 44);
            this.panelFiltro.TabIndex = 3;
            this.panelFiltro.UseCustomBackColor = true;
            this.panelFiltro.VerticalScrollbarBarColor = true;
            this.panelFiltro.VerticalScrollbarHighlightOnWheel = false;
            this.panelFiltro.VerticalScrollbarSize = 10;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.ForeColor = System.Drawing.Color.Navy;
            this.lblFiltro.Location = new System.Drawing.Point(13, 13);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(76, 19);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Buscar por:";
            this.lblFiltro.UseCustomBackColor = true;
            this.lblFiltro.UseCustomForeColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(502, 6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(37, 30);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(100, 43);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(120, 32);
            this.lblNombreForm.TabIndex = 50;
            this.lblNombreForm.Text = "Productos";
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Location = new System.Drawing.Point(503, 39);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(0, 13);
            this.lblIdProducto.TabIndex = 51;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(38, 32);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToResizeColumns = false;
            this.dgvProducto.AllowUserToResizeRows = false;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducto.Location = new System.Drawing.Point(40, 140);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducto.RowHeadersVisible = false;
            this.dgvProducto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(349, 514);
            this.dgvProducto.TabIndex = 0;
            this.dgvProducto.SelectionChanged += new System.EventHandler(this.dgvProducto_SelectionChanged);
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(181, 657);
            this.lblNumInactivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumInactivo.Name = "lblNumInactivo";
            this.lblNumInactivo.Size = new System.Drawing.Size(65, 17);
            this.lblNumInactivo.TabIndex = 116;
            this.lblNumInactivo.Text = "Inactivos: ";
            // 
            // lblNumActivo
            // 
            this.lblNumActivo.AutoSize = true;
            this.lblNumActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumActivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActivo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNumActivo.Location = new System.Drawing.Point(101, 657);
            this.lblNumActivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumActivo.Name = "lblNumActivo";
            this.lblNumActivo.Size = new System.Drawing.Size(56, 17);
            this.lblNumActivo.TabIndex = 115;
            this.lblNumActivo.Text = "Activos: ";
            // 
            // lblNumReg
            // 
            this.lblNumReg.AutoSize = true;
            this.lblNumReg.BackColor = System.Drawing.Color.Transparent;
            this.lblNumReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumReg.Location = new System.Drawing.Point(34, 657);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 114;
            this.lblNumReg.Text = "Total: ";
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(1030, 709);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.tabProducto);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.MaximizeBox = false;
            this.Name = "FormProducto";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Load += new System.EventHandler(this.FormProducto_Load);
            this.tabProducto.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            this.tabPagPrecio.ResumeLayout(false);
            this.tabPagPrecio.PerformLayout();
            this.grbCostoProd.ResumeLayout(false);
            this.grbCostoProd.PerformLayout();
            this.grbConImpto.ResumeLayout(false);
            this.grbConImpto.PerformLayout();
            this.grbSinImpto.ResumeLayout(false);
            this.grbSinImpto.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tabProducto;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroTabPage tabPagPrecio;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblCodigo02;
        private MetroFramework.Controls.MetroTextBox txtCodBarra;
        private MetroFramework.Controls.MetroLabel lblCodBarra;
        private MetroFramework.Controls.MetroTextBox txtCodigo01;
        private MetroFramework.Controls.MetroLabel lblCodigo01;
        private MetroFramework.Controls.MetroTextBox txtCodigo02;
        private MetroFramework.Controls.MetroLabel lblSubFamilia;
        private MetroFramework.Controls.MetroLabel lblFamilia;
        private BorderedCombo cboFamilia;
        private MetroFramework.Controls.MetroLabel lblModelo;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private BorderedCombo cboSubFamilia;
        private BorderedCombo cboModelo;
        private BorderedCombo cboMarca;
        private MetroFramework.Controls.MetroLabel lblTipoProd;
        private MetroFramework.Controls.MetroLabel lblGrupo;
        private MetroFramework.Controls.MetroLabel lblTipoExistencia;
        private MetroFramework.Controls.MetroLabel lblClaseProd;
        private MetroFramework.Controls.MetroCheckBox chkProductoVenta;
        private BorderedCombo cboClaseProd;
        private BorderedCombo cboGrupoProd;
        private BorderedCombo cboTipoExistencia;
        private BorderedCombo cboTipoProd;
        private MetroFramework.Controls.MetroCheckBox chkCombo;
        private MetroFramework.Controls.MetroCheckBox chkProductoCompra;
        private MetroFramework.Controls.MetroTextBox txtReferencia;
        private MetroFramework.Controls.MetroLabel lblReferencia;
        private MetroFramework.Controls.MetroLabel lblPeso;
        private MetroFramework.Controls.MetroLabel lblLargo;
        private MetroFramework.Controls.MetroLabel lblAncho;
        private MetroFramework.Controls.MetroLabel lblAltura;
        private MetroFramework.Controls.MetroTextBox txtPeso;
        private MetroFramework.Controls.MetroTextBox txtLargo;
        private MetroFramework.Controls.MetroTextBox txtAncho;
        private MetroFramework.Controls.MetroTextBox txtAltura;
        private BorderedCombo cboFiltro;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private MetroFramework.Controls.MetroPanel panelMantenimiento;
        private MetroFramework.Controls.MetroPanel panelFiltro;
        private MetroFramework.Controls.MetroLink btnFamilia;
        private MetroFramework.Controls.MetroLink btnModelo;
        private MetroFramework.Controls.MetroLink btnMarca;
        private MetroFramework.Controls.MetroLink btnSubFamilia;
        private MetroFramework.Controls.MetroLink btnClaseProd;
        private MetroFramework.Controls.MetroLink btnGrupoProd;
        private MetroFramework.Controls.MetroLink btnTipoProd;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroToggle tglListarInactivos;
        private MetroFramework.Controls.MetroLabel lblListarInactivos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFilter;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroLink btnImpuesto;
        private BorderedCombo cboImpuesto;
        private BorderedCombo cboTipoMoneda;
        private MetroFramework.Controls.MetroLabel lblImpuesto;
        private MetroFramework.Controls.MetroLabel lblTipoMoneda;
        private System.Windows.Forms.GroupBox grbConImpto;
        private System.Windows.Forms.GroupBox grbSinImpto;
        private MetroFramework.Controls.MetroCheckBox chkInafecto;
        private MetroFramework.Controls.MetroCheckBox chkExento;
        private MetroFramework.Controls.MetroCheckBox chkImpto;
        private MetroFramework.Controls.MetroTextBox txtPvMiConImpto;
        private MetroFramework.Controls.MetroLabel lblPvMiConIGV;
        private MetroFramework.Controls.MetroTextBox txtPvMaConImpto;
        private MetroFramework.Controls.MetroLabel lblPvMaConIGV;
        private MetroFramework.Controls.MetroTextBox txtPvPuConImpto;
        private MetroFramework.Controls.MetroLabel lblPvPuConIGV;
        private MetroFramework.Controls.MetroTextBox txtPvMiSinImpto;
        private MetroFramework.Controls.MetroLabel lblPvMiSinIGV;
        private MetroFramework.Controls.MetroTextBox txtPvMaSinImpto;
        private MetroFramework.Controls.MetroLabel lblPvMaSinIGV;
        private MetroFramework.Controls.MetroTextBox txtPvPuSinImpto;
        private MetroFramework.Controls.MetroLabel lblPvPuSinIGV;
        private BorderedCombo cboUnidadMedida;
        private MetroFramework.Controls.MetroLabel lblUnidadMedida;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.Label lblIdProducto;
        private MetroFramework.Controls.MetroLabel lblFiltro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txtDiametro;
        private MetroFramework.Controls.MetroLabel lblDiametro;
        private MetroFramework.Controls.MetroCheckBox chkReceta;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.GroupBox grbCostoProd;
        private MetroFramework.Controls.MetroTextBox txtCostoProd;
        private MetroFramework.Controls.MetroLabel lblCosto;
        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private System.Windows.Forms.Label lblPorcentajeAcumuladoImpto;
        private System.Windows.Forms.Label lblSimboloPorcentaje;
    }
}