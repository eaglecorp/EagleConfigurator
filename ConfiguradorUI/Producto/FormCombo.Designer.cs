using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Producto
{
    partial class FormCombo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCombo));
            this.dgvCombo = new System.Windows.Forms.DataGridView();
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.lblIdCombo = new MetroFramework.Controls.MetroLabel();
            this.panelFiltro = new MetroFramework.Controls.MetroPanel();
            this.lblFiltro = new MetroFramework.Controls.MetroLabel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.cboFiltro = new ConfigUtilitarios.Controls.BorderedCombo();
            this.panelMantenimiento = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tglListarInactivos = new MetroFramework.Controls.MetroToggle();
            this.lblListarInactivos = new MetroFramework.Controls.MetroLabel();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.tabCombo = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.chkPrecioAcumulado = new MetroFramework.Controls.MetroCheckBox();
            this.chkIncluyeImpto = new MetroFramework.Controls.MetroCheckBox();
            this.lblPorcentajeAcumuladoImpto = new System.Windows.Forms.Label();
            this.lblSimboloPorcentaje = new System.Windows.Forms.Label();
            this.cboImpuesto = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblImpuesto = new MetroFramework.Controls.MetroLabel();
            this.btnImpuesto = new MetroFramework.Controls.MetroLink();
            this.lblPrecioCboSinTax = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioCboConTax = new MetroFramework.Controls.MetroLabel();
            this.chkMostrarInactivos = new MetroFramework.Controls.MetroCheckBox();
            this.btnComboGrupo = new MetroFramework.Controls.MetroLink();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.cboComboGrupo = new ConfigUtilitarios.Controls.BorderedCombo();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.tabDetails = new System.Windows.Forms.TabControl();
            this.tabPagProductos = new System.Windows.Forms.TabPage();
            this.dgvProductDetail = new System.Windows.Forms.DataGridView();
            this.tabPagCboElectivo = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProductOfCboVarDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCboVariableDetail = new System.Windows.Forms.DataGridView();
            this.btnBuscarItem = new MetroFramework.Controls.MetroLink();
            this.btnItem = new MetroFramework.Controls.MetroLink();
            this.txtItemCod = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioSinImp = new MetroFramework.Controls.MetroLabel();
            this.txtItemPriceSinImp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtItemPriceConImp = new MetroFramework.Controls.MetroTextBox();
            this.lblPrecioConImp = new MetroFramework.Controls.MetroLabel();
            this.txtItemQuantity = new MetroFramework.Controls.MetroTextBox();
            this.lblCantidad = new MetroFramework.Controls.MetroLabel();
            this.txtPrecioCboSinTax = new MetroFramework.Controls.MetroTextBox();
            this.txtPrecioCboConTax = new MetroFramework.Controls.MetroTextBox();
            this.txtItemDesc = new MetroFramework.Controls.MetroTextBox();
            this.lblItemDesc = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblComboGrupo = new MetroFramework.Controls.MetroLabel();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvDtl = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombo)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            this.tabCombo.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.tabDetails.SuspendLayout();
            this.tabPagProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).BeginInit();
            this.tabPagCboElectivo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOfCboVarDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCboVariableDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvDtl)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCombo
            // 
            this.dgvCombo.AllowUserToAddRows = false;
            this.dgvCombo.AllowUserToResizeColumns = false;
            this.dgvCombo.AllowUserToResizeRows = false;
            this.dgvCombo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCombo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCombo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCombo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCombo.Location = new System.Drawing.Point(31, 129);
            this.dgvCombo.MultiSelect = false;
            this.dgvCombo.Name = "dgvCombo";
            this.dgvCombo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCombo.RowHeadersVisible = false;
            this.dgvCombo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCombo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCombo.Size = new System.Drawing.Size(222, 505);
            this.dgvCombo.TabIndex = 0;
            this.dgvCombo.SelectionChanged += new System.EventHandler(this.dgvCombo_SelectionChanged);
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(175, 637);
            this.lblNumInactivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumInactivo.Name = "lblNumInactivo";
            this.lblNumInactivo.Size = new System.Drawing.Size(65, 17);
            this.lblNumInactivo.TabIndex = 153;
            this.lblNumInactivo.Text = "Inactivos: ";
            // 
            // lblNumActivo
            // 
            this.lblNumActivo.AutoSize = true;
            this.lblNumActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumActivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActivo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNumActivo.Location = new System.Drawing.Point(95, 637);
            this.lblNumActivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumActivo.Name = "lblNumActivo";
            this.lblNumActivo.Size = new System.Drawing.Size(56, 17);
            this.lblNumActivo.TabIndex = 152;
            this.lblNumActivo.Text = "Activos: ";
            // 
            // lblNumReg
            // 
            this.lblNumReg.AutoSize = true;
            this.lblNumReg.BackColor = System.Drawing.Color.Transparent;
            this.lblNumReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumReg.Location = new System.Drawing.Point(28, 637);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 151;
            this.lblNumReg.Text = "Total: ";
            // 
            // lblIdCombo
            // 
            this.lblIdCombo.AutoSize = true;
            this.lblIdCombo.Location = new System.Drawing.Point(231, 60);
            this.lblIdCombo.Name = "lblIdCombo";
            this.lblIdCombo.Size = new System.Drawing.Size(0, 0);
            this.lblIdCombo.TabIndex = 150;
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
            this.panelFiltro.Location = new System.Drawing.Point(287, 610);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(689, 44);
            this.panelFiltro.TabIndex = 145;
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
            this.lblFiltro.Location = new System.Drawing.Point(5, 13);
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
            this.btnFilter.Location = new System.Drawing.Point(643, 6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(37, 30);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFiltro
            // 
            // 
            // 
            // 
            this.txtFiltro.CustomButton.Image = null;
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(214, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(402, 11);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PromptText = "Filtro";
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(236, 23);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.UseSelectable = true;
            this.txtFiltro.WaterMark = "Filtro";
            this.txtFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(84, 11);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(215, 23);
            this.cboFiltro.TabIndex = 3;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
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
            this.panelMantenimiento.Location = new System.Drawing.Point(286, 36);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(690, 49);
            this.panelMantenimiento.Style = MetroFramework.MetroColorStyle.Green;
            this.panelMantenimiento.TabIndex = 144;
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
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(519, 5);
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
            this.btnRollback.Location = new System.Drawing.Point(645, 5);
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
            this.btnCommit.Location = new System.Drawing.Point(603, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(561, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(142, 104);
            this.tglListarInactivos.Name = "tglListarInactivos";
            this.tglListarInactivos.Size = new System.Drawing.Size(80, 17);
            this.tglListarInactivos.TabIndex = 147;
            this.tglListarInactivos.Text = "Off";
            this.tglListarInactivos.UseSelectable = true;
            this.tglListarInactivos.Click += new System.EventHandler(this.tglListarInactivos_Click);
            // 
            // lblListarInactivos
            // 
            this.lblListarInactivos.AutoSize = true;
            this.lblListarInactivos.Location = new System.Drawing.Point(31, 104);
            this.lblListarInactivos.Name = "lblListarInactivos";
            this.lblListarInactivos.Size = new System.Drawing.Size(92, 19);
            this.lblListarInactivos.TabIndex = 146;
            this.lblListarInactivos.Text = "Listar inactivos";
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(102, 32);
            this.lblNombreForm.TabIndex = 149;
            this.lblNombreForm.Text = "Combos";
            // 
            // tabCombo
            // 
            this.tabCombo.Controls.Add(this.tabPagGeneral);
            this.tabCombo.Location = new System.Drawing.Point(286, 91);
            this.tabCombo.Name = "tabCombo";
            this.tabCombo.SelectedIndex = 0;
            this.tabCombo.Size = new System.Drawing.Size(706, 513);
            this.tabCombo.TabIndex = 143;
            this.tabCombo.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.chkPrecioAcumulado);
            this.tabPagGeneral.Controls.Add(this.chkIncluyeImpto);
            this.tabPagGeneral.Controls.Add(this.lblIdCombo);
            this.tabPagGeneral.Controls.Add(this.lblPorcentajeAcumuladoImpto);
            this.tabPagGeneral.Controls.Add(this.lblSimboloPorcentaje);
            this.tabPagGeneral.Controls.Add(this.cboImpuesto);
            this.tabPagGeneral.Controls.Add(this.lblImpuesto);
            this.tabPagGeneral.Controls.Add(this.btnImpuesto);
            this.tabPagGeneral.Controls.Add(this.lblPrecioCboSinTax);
            this.tabPagGeneral.Controls.Add(this.lblPrecioCboConTax);
            this.tabPagGeneral.Controls.Add(this.chkMostrarInactivos);
            this.tabPagGeneral.Controls.Add(this.btnComboGrupo);
            this.tabPagGeneral.Controls.Add(this.btnAddItem);
            this.tabPagGeneral.Controls.Add(this.cboComboGrupo);
            this.tabPagGeneral.Controls.Add(this.btnRemoveItem);
            this.tabPagGeneral.Controls.Add(this.tabDetails);
            this.tabPagGeneral.Controls.Add(this.btnBuscarItem);
            this.tabPagGeneral.Controls.Add(this.btnItem);
            this.tabPagGeneral.Controls.Add(this.txtItemCod);
            this.tabPagGeneral.Controls.Add(this.metroLabel4);
            this.tabPagGeneral.Controls.Add(this.metroLabel3);
            this.tabPagGeneral.Controls.Add(this.lblPrecioSinImp);
            this.tabPagGeneral.Controls.Add(this.txtItemPriceSinImp);
            this.tabPagGeneral.Controls.Add(this.metroLabel2);
            this.tabPagGeneral.Controls.Add(this.txtItemPriceConImp);
            this.tabPagGeneral.Controls.Add(this.lblPrecioConImp);
            this.tabPagGeneral.Controls.Add(this.txtItemQuantity);
            this.tabPagGeneral.Controls.Add(this.lblCantidad);
            this.tabPagGeneral.Controls.Add(this.txtPrecioCboSinTax);
            this.tabPagGeneral.Controls.Add(this.txtPrecioCboConTax);
            this.tabPagGeneral.Controls.Add(this.txtItemDesc);
            this.tabPagGeneral.Controls.Add(this.lblItemDesc);
            this.tabPagGeneral.Controls.Add(this.metroLabel1);
            this.tabPagGeneral.Controls.Add(this.panel2);
            this.tabPagGeneral.Controls.Add(this.chkActivo);
            this.tabPagGeneral.Controls.Add(this.txtCodigo);
            this.tabPagGeneral.Controls.Add(this.lblCodigo);
            this.tabPagGeneral.Controls.Add(this.txtNombre);
            this.tabPagGeneral.Controls.Add(this.lblNombre);
            this.tabPagGeneral.Controls.Add(this.lblComboGrupo);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(698, 471);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // chkPrecioAcumulado
            // 
            this.chkPrecioAcumulado.AutoSize = true;
            this.chkPrecioAcumulado.Checked = true;
            this.chkPrecioAcumulado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrecioAcumulado.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkPrecioAcumulado.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkPrecioAcumulado.ForeColor = System.Drawing.Color.Navy;
            this.chkPrecioAcumulado.Location = new System.Drawing.Point(0, 430);
            this.chkPrecioAcumulado.Name = "chkPrecioAcumulado";
            this.chkPrecioAcumulado.Size = new System.Drawing.Size(131, 19);
            this.chkPrecioAcumulado.TabIndex = 8;
            this.chkPrecioAcumulado.Text = "Precio acumulado";
            this.chkPrecioAcumulado.UseCustomForeColor = true;
            this.chkPrecioAcumulado.UseSelectable = true;
            this.chkPrecioAcumulado.CheckedChanged += new System.EventHandler(this.chkPrecioAcumulado_CheckedChanged);
            // 
            // chkIncluyeImpto
            // 
            this.chkIncluyeImpto.AutoSize = true;
            this.chkIncluyeImpto.Checked = true;
            this.chkIncluyeImpto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncluyeImpto.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkIncluyeImpto.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkIncluyeImpto.ForeColor = System.Drawing.Color.Navy;
            this.chkIncluyeImpto.Location = new System.Drawing.Point(0, 409);
            this.chkIncluyeImpto.Name = "chkIncluyeImpto";
            this.chkIncluyeImpto.Size = new System.Drawing.Size(163, 19);
            this.chkIncluyeImpto.TabIndex = 7;
            this.chkIncluyeImpto.Text = "Precio incluye impuesto";
            this.chkIncluyeImpto.UseCustomForeColor = true;
            this.chkIncluyeImpto.UseSelectable = true;
            this.chkIncluyeImpto.CheckedChanged += new System.EventHandler(this.chkIncluyeImpto_CheckedChanged);
            // 
            // lblPorcentajeAcumuladoImpto
            // 
            this.lblPorcentajeAcumuladoImpto.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentajeAcumuladoImpto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeAcumuladoImpto.ForeColor = System.Drawing.Color.Navy;
            this.lblPorcentajeAcumuladoImpto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPorcentajeAcumuladoImpto.Location = new System.Drawing.Point(79, 383);
            this.lblPorcentajeAcumuladoImpto.Name = "lblPorcentajeAcumuladoImpto";
            this.lblPorcentajeAcumuladoImpto.Size = new System.Drawing.Size(188, 23);
            this.lblPorcentajeAcumuladoImpto.TabIndex = 171;
            this.lblPorcentajeAcumuladoImpto.Text = "0";
            this.lblPorcentajeAcumuladoImpto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSimboloPorcentaje
            // 
            this.lblSimboloPorcentaje.AutoSize = true;
            this.lblSimboloPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblSimboloPorcentaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloPorcentaje.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorcentaje.Location = new System.Drawing.Point(271, 386);
            this.lblSimboloPorcentaje.Name = "lblSimboloPorcentaje";
            this.lblSimboloPorcentaje.Size = new System.Drawing.Size(19, 17);
            this.lblSimboloPorcentaje.TabIndex = 170;
            this.lblSimboloPorcentaje.Text = "%";
            // 
            // cboImpuesto
            // 
            this.cboImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboImpuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpuesto.FormattingEnabled = true;
            this.cboImpuesto.Location = new System.Drawing.Point(77, 360);
            this.cboImpuesto.Name = "cboImpuesto";
            this.cboImpuesto.Size = new System.Drawing.Size(190, 23);
            this.cboImpuesto.TabIndex = 6;
            this.cboImpuesto.SelectedIndexChanged += new System.EventHandler(this.cboImpuesto_SelectedIndexChanged);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuesto.ForeColor = System.Drawing.Color.Navy;
            this.lblImpuesto.Location = new System.Drawing.Point(0, 362);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(66, 19);
            this.lblImpuesto.TabIndex = 167;
            this.lblImpuesto.Text = "Impuesto:";
            this.lblImpuesto.UseCustomForeColor = true;
            // 
            // btnImpuesto
            // 
            this.btnImpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnImpuesto.Image")));
            this.btnImpuesto.ImageSize = 24;
            this.btnImpuesto.Location = new System.Drawing.Point(270, 356);
            this.btnImpuesto.Name = "btnImpuesto";
            this.btnImpuesto.Size = new System.Drawing.Size(29, 27);
            this.btnImpuesto.TabIndex = 169;
            this.btnImpuesto.UseSelectable = true;
            this.btnImpuesto.Click += new System.EventHandler(this.btnImpuesto_Click);
            // 
            // lblPrecioCboSinTax
            // 
            this.lblPrecioCboSinTax.AutoSize = true;
            this.lblPrecioCboSinTax.ForeColor = System.Drawing.Color.Navy;
            this.lblPrecioCboSinTax.Location = new System.Drawing.Point(390, 392);
            this.lblPrecioCboSinTax.Name = "lblPrecioCboSinTax";
            this.lblPrecioCboSinTax.Size = new System.Drawing.Size(155, 19);
            this.lblPrecioCboSinTax.TabIndex = 166;
            this.lblPrecioCboSinTax.Text = "Precio cbo. sin impuesto:";
            this.lblPrecioCboSinTax.UseCustomForeColor = true;
            // 
            // lblPrecioCboConTax
            // 
            this.lblPrecioCboConTax.AutoSize = true;
            this.lblPrecioCboConTax.ForeColor = System.Drawing.Color.Navy;
            this.lblPrecioCboConTax.Location = new System.Drawing.Point(390, 363);
            this.lblPrecioCboConTax.Name = "lblPrecioCboConTax";
            this.lblPrecioCboConTax.Size = new System.Drawing.Size(161, 19);
            this.lblPrecioCboConTax.TabIndex = 165;
            this.lblPrecioCboConTax.Text = "Precio cbo. con impuesto:";
            this.lblPrecioCboConTax.UseCustomForeColor = true;
            // 
            // chkMostrarInactivos
            // 
            this.chkMostrarInactivos.AutoSize = true;
            this.chkMostrarInactivos.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkMostrarInactivos.ForeColor = System.Drawing.Color.Navy;
            this.chkMostrarInactivos.Location = new System.Drawing.Point(143, 169);
            this.chkMostrarInactivos.Name = "chkMostrarInactivos";
            this.chkMostrarInactivos.Size = new System.Drawing.Size(108, 15);
            this.chkMostrarInactivos.TabIndex = 155;
            this.chkMostrarInactivos.Text = "Mostrar inactivos";
            this.chkMostrarInactivos.UseCustomForeColor = true;
            this.chkMostrarInactivos.UseSelectable = true;
            this.chkMostrarInactivos.CheckedChanged += new System.EventHandler(this.chkMostrarInactivos_CheckedChanged);
            // 
            // btnComboGrupo
            // 
            this.btnComboGrupo.Image = ((System.Drawing.Image)(resources.GetObject("btnComboGrupo.Image")));
            this.btnComboGrupo.ImageSize = 24;
            this.btnComboGrupo.Location = new System.Drawing.Point(270, 46);
            this.btnComboGrupo.Name = "btnComboGrupo";
            this.btnComboGrupo.Size = new System.Drawing.Size(29, 27);
            this.btnComboGrupo.TabIndex = 155;
            this.btnComboGrupo.UseSelectable = true;
            this.btnComboGrupo.Click += new System.EventHandler(this.btnComboGrupo_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.Location = new System.Drawing.Point(645, 131);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(33, 29);
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // cboComboGrupo
            // 
            this.cboComboGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboComboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComboGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboComboGrupo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboComboGrupo.FormattingEnabled = true;
            this.cboComboGrupo.Location = new System.Drawing.Point(77, 50);
            this.cboComboGrupo.Name = "cboComboGrupo";
            this.cboComboGrupo.Size = new System.Drawing.Size(190, 23);
            this.cboComboGrupo.TabIndex = 2;
            this.cboComboGrupo.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.Image")));
            this.btnRemoveItem.Location = new System.Drawing.Point(645, 99);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(33, 29);
            this.btnRemoveItem.TabIndex = 164;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // tabDetails
            // 
            this.tabDetails.Controls.Add(this.tabPagProductos);
            this.tabDetails.Controls.Add(this.tabPagCboElectivo);
            this.tabDetails.Location = new System.Drawing.Point(0, 166);
            this.tabDetails.Name = "tabDetails";
            this.tabDetails.SelectedIndex = 0;
            this.tabDetails.Size = new System.Drawing.Size(678, 186);
            this.tabDetails.TabIndex = 156;
            this.tabDetails.SelectedIndexChanged += new System.EventHandler(this.tabDetails_SelectedIndexChanged);
            // 
            // tabPagProductos
            // 
            this.tabPagProductos.Controls.Add(this.dgvProductDetail);
            this.tabPagProductos.Location = new System.Drawing.Point(4, 22);
            this.tabPagProductos.Name = "tabPagProductos";
            this.tabPagProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagProductos.Size = new System.Drawing.Size(670, 160);
            this.tabPagProductos.TabIndex = 0;
            this.tabPagProductos.Text = "Productos";
            this.tabPagProductos.UseVisualStyleBackColor = true;
            // 
            // dgvProductDetail
            // 
            this.dgvProductDetail.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductDetail.Location = new System.Drawing.Point(3, 3);
            this.dgvProductDetail.Name = "dgvProductDetail";
            this.dgvProductDetail.Size = new System.Drawing.Size(664, 154);
            this.dgvProductDetail.TabIndex = 150;
            this.dgvProductDetail.DataSourceChanged += new System.EventHandler(this.dgvProductDetail_DataSourceChanged);
            this.dgvProductDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetail_CellContentClick);
            this.dgvProductDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductDetail_CellDoubleClick);
            this.dgvProductDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductDetail_KeyDown);
            // 
            // tabPagCboElectivo
            // 
            this.tabPagCboElectivo.Controls.Add(this.tableLayoutPanel1);
            this.tabPagCboElectivo.Location = new System.Drawing.Point(4, 22);
            this.tabPagCboElectivo.Name = "tabPagCboElectivo";
            this.tabPagCboElectivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagCboElectivo.Size = new System.Drawing.Size(670, 160);
            this.tabPagCboElectivo.TabIndex = 1;
            this.tabPagCboElectivo.Text = "Cbo. Electivo";
            this.tabPagCboElectivo.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.53982F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.46018F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvCboVariableDetail, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(681, 154);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProductOfCboVarDetail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(435, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 148);
            this.panel1.TabIndex = 155;
            // 
            // dgvProductOfCboVarDetail
            // 
            this.dgvProductOfCboVarDetail.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProductOfCboVarDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductOfCboVarDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOfCboVarDetail.Location = new System.Drawing.Point(0, 24);
            this.dgvProductOfCboVarDetail.Name = "dgvProductOfCboVarDetail";
            this.dgvProductOfCboVarDetail.Size = new System.Drawing.Size(240, 124);
            this.dgvProductOfCboVarDetail.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 166;
            this.label1.Text = "Productos del cbo. electivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvCboVariableDetail
            // 
            this.dgvCboVariableDetail.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCboVariableDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCboVariableDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCboVariableDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCboVariableDetail.Location = new System.Drawing.Point(3, 3);
            this.dgvCboVariableDetail.Name = "dgvCboVariableDetail";
            this.dgvCboVariableDetail.Size = new System.Drawing.Size(426, 148);
            this.dgvCboVariableDetail.TabIndex = 151;
            this.dgvCboVariableDetail.DataSourceChanged += new System.EventHandler(this.dgvCboVariableDetail_DataSourceChanged);
            this.dgvCboVariableDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCboVariableDetail_CellContentClick);
            this.dgvCboVariableDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCboVariableDetail_CellDoubleClick);
            this.dgvCboVariableDetail.SelectionChanged += new System.EventHandler(this.dgvCboVariableDetail_SelectionChanged);
            this.dgvCboVariableDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvCboVariableDetail_KeyDown);
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarItem.Image")));
            this.btnBuscarItem.ImageSize = 20;
            this.btnBuscarItem.Location = new System.Drawing.Point(45, 111);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(31, 24);
            this.btnBuscarItem.TabIndex = 152;
            this.btnBuscarItem.UseSelectable = true;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // btnItem
            // 
            this.btnItem.BackColor = System.Drawing.Color.Transparent;
            this.btnItem.Image = ((System.Drawing.Image)(resources.GetObject("btnItem.Image")));
            this.btnItem.ImageSize = 20;
            this.btnItem.Location = new System.Drawing.Point(187, 111);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(31, 24);
            this.btnItem.TabIndex = 151;
            this.btnItem.UseSelectable = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // txtItemCod
            // 
            this.txtItemCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemCod.CustomButton.Image = null;
            this.txtItemCod.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtItemCod.CustomButton.Name = "";
            this.txtItemCod.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemCod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemCod.CustomButton.TabIndex = 1;
            this.txtItemCod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemCod.CustomButton.UseSelectable = true;
            this.txtItemCod.CustomButton.Visible = false;
            this.txtItemCod.Lines = new string[0];
            this.txtItemCod.Location = new System.Drawing.Point(0, 137);
            this.txtItemCod.MaxLength = 32767;
            this.txtItemCod.Name = "txtItemCod";
            this.txtItemCod.PasswordChar = '\0';
            this.txtItemCod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemCod.SelectedText = "";
            this.txtItemCod.SelectionLength = 0;
            this.txtItemCod.SelectionStart = 0;
            this.txtItemCod.ShortcutsEnabled = true;
            this.txtItemCod.Size = new System.Drawing.Size(74, 23);
            this.txtItemCod.TabIndex = 3;
            this.txtItemCod.UseCustomBackColor = true;
            this.txtItemCod.UseSelectable = true;
            this.txtItemCod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemCod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel4.Location = new System.Drawing.Point(546, 99);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 149;
            this.metroLabel4.Text = "Precio sin";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(447, 99);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 148;
            this.metroLabel3.Text = "Precio con";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // lblPrecioSinImp
            // 
            this.lblPrecioSinImp.AutoSize = true;
            this.lblPrecioSinImp.ForeColor = System.Drawing.Color.Navy;
            this.lblPrecioSinImp.Location = new System.Drawing.Point(546, 115);
            this.lblPrecioSinImp.MaximumSize = new System.Drawing.Size(100, 50);
            this.lblPrecioSinImp.Name = "lblPrecioSinImp";
            this.lblPrecioSinImp.Size = new System.Drawing.Size(63, 19);
            this.lblPrecioSinImp.TabIndex = 147;
            this.lblPrecioSinImp.Text = "impuesto";
            this.lblPrecioSinImp.UseCustomForeColor = true;
            // 
            // txtItemPriceSinImp
            // 
            this.txtItemPriceSinImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemPriceSinImp.CustomButton.Image = null;
            this.txtItemPriceSinImp.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtItemPriceSinImp.CustomButton.Name = "";
            this.txtItemPriceSinImp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemPriceSinImp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemPriceSinImp.CustomButton.TabIndex = 1;
            this.txtItemPriceSinImp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemPriceSinImp.CustomButton.UseSelectable = true;
            this.txtItemPriceSinImp.CustomButton.Visible = false;
            this.txtItemPriceSinImp.Lines = new string[0];
            this.txtItemPriceSinImp.Location = new System.Drawing.Point(546, 137);
            this.txtItemPriceSinImp.MaxLength = 32767;
            this.txtItemPriceSinImp.Name = "txtItemPriceSinImp";
            this.txtItemPriceSinImp.PasswordChar = '\0';
            this.txtItemPriceSinImp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemPriceSinImp.SelectedText = "";
            this.txtItemPriceSinImp.SelectionLength = 0;
            this.txtItemPriceSinImp.SelectionStart = 0;
            this.txtItemPriceSinImp.ShortcutsEnabled = true;
            this.txtItemPriceSinImp.Size = new System.Drawing.Size(93, 23);
            this.txtItemPriceSinImp.TabIndex = 146;
            this.txtItemPriceSinImp.UseCustomBackColor = true;
            this.txtItemPriceSinImp.UseSelectable = true;
            this.txtItemPriceSinImp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemPriceSinImp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(-3, 115);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 142;
            this.metroLabel2.Text = "Código";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtItemPriceConImp
            // 
            this.txtItemPriceConImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemPriceConImp.CustomButton.Image = null;
            this.txtItemPriceConImp.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtItemPriceConImp.CustomButton.Name = "";
            this.txtItemPriceConImp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemPriceConImp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemPriceConImp.CustomButton.TabIndex = 1;
            this.txtItemPriceConImp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemPriceConImp.CustomButton.UseSelectable = true;
            this.txtItemPriceConImp.CustomButton.Visible = false;
            this.txtItemPriceConImp.Lines = new string[0];
            this.txtItemPriceConImp.Location = new System.Drawing.Point(447, 137);
            this.txtItemPriceConImp.MaxLength = 32767;
            this.txtItemPriceConImp.Name = "txtItemPriceConImp";
            this.txtItemPriceConImp.PasswordChar = '\0';
            this.txtItemPriceConImp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemPriceConImp.SelectedText = "";
            this.txtItemPriceConImp.SelectionLength = 0;
            this.txtItemPriceConImp.SelectionStart = 0;
            this.txtItemPriceConImp.ShortcutsEnabled = true;
            this.txtItemPriceConImp.Size = new System.Drawing.Size(93, 23);
            this.txtItemPriceConImp.TabIndex = 140;
            this.txtItemPriceConImp.UseCustomBackColor = true;
            this.txtItemPriceConImp.UseSelectable = true;
            this.txtItemPriceConImp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemPriceConImp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrecioConImp
            // 
            this.lblPrecioConImp.AutoSize = true;
            this.lblPrecioConImp.ForeColor = System.Drawing.Color.Navy;
            this.lblPrecioConImp.Location = new System.Drawing.Point(447, 115);
            this.lblPrecioConImp.MaximumSize = new System.Drawing.Size(100, 50);
            this.lblPrecioConImp.Name = "lblPrecioConImp";
            this.lblPrecioConImp.Size = new System.Drawing.Size(63, 19);
            this.lblPrecioConImp.TabIndex = 139;
            this.lblPrecioConImp.Text = "impuesto";
            this.lblPrecioConImp.UseCustomForeColor = true;
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemQuantity.CustomButton.Image = null;
            this.txtItemQuantity.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtItemQuantity.CustomButton.Name = "";
            this.txtItemQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemQuantity.CustomButton.TabIndex = 1;
            this.txtItemQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemQuantity.CustomButton.UseSelectable = true;
            this.txtItemQuantity.CustomButton.Visible = false;
            this.txtItemQuantity.Lines = new string[0];
            this.txtItemQuantity.Location = new System.Drawing.Point(348, 137);
            this.txtItemQuantity.MaxLength = 32767;
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.PasswordChar = '\0';
            this.txtItemQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemQuantity.SelectedText = "";
            this.txtItemQuantity.SelectionLength = 0;
            this.txtItemQuantity.SelectionStart = 0;
            this.txtItemQuantity.ShortcutsEnabled = true;
            this.txtItemQuantity.Size = new System.Drawing.Size(93, 23);
            this.txtItemQuantity.TabIndex = 4;
            this.txtItemQuantity.UseCustomBackColor = true;
            this.txtItemQuantity.UseSelectable = true;
            this.txtItemQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemQuantity_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidad.Location = new System.Drawing.Point(348, 115);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 19);
            this.lblCantidad.TabIndex = 137;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.UseCustomForeColor = true;
            // 
            // txtPrecioCboSinTax
            // 
            this.txtPrecioCboSinTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPrecioCboSinTax.CustomButton.Image = null;
            this.txtPrecioCboSinTax.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPrecioCboSinTax.CustomButton.Name = "";
            this.txtPrecioCboSinTax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioCboSinTax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioCboSinTax.CustomButton.TabIndex = 1;
            this.txtPrecioCboSinTax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioCboSinTax.CustomButton.UseSelectable = true;
            this.txtPrecioCboSinTax.CustomButton.Visible = false;
            this.txtPrecioCboSinTax.Lines = new string[0];
            this.txtPrecioCboSinTax.Location = new System.Drawing.Point(552, 390);
            this.txtPrecioCboSinTax.MaxLength = 32767;
            this.txtPrecioCboSinTax.Name = "txtPrecioCboSinTax";
            this.txtPrecioCboSinTax.PasswordChar = '\0';
            this.txtPrecioCboSinTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioCboSinTax.SelectedText = "";
            this.txtPrecioCboSinTax.SelectionLength = 0;
            this.txtPrecioCboSinTax.SelectionStart = 0;
            this.txtPrecioCboSinTax.ShortcutsEnabled = true;
            this.txtPrecioCboSinTax.Size = new System.Drawing.Size(126, 23);
            this.txtPrecioCboSinTax.TabIndex = 136;
            this.txtPrecioCboSinTax.UseCustomBackColor = true;
            this.txtPrecioCboSinTax.UseSelectable = true;
            this.txtPrecioCboSinTax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioCboSinTax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioCboSinTax.TextChanged += new System.EventHandler(this.txtPrecioCboSinTax_TextChanged);
            // 
            // txtPrecioCboConTax
            // 
            this.txtPrecioCboConTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPrecioCboConTax.CustomButton.Image = null;
            this.txtPrecioCboConTax.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPrecioCboConTax.CustomButton.Name = "";
            this.txtPrecioCboConTax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioCboConTax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioCboConTax.CustomButton.TabIndex = 1;
            this.txtPrecioCboConTax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioCboConTax.CustomButton.UseSelectable = true;
            this.txtPrecioCboConTax.CustomButton.Visible = false;
            this.txtPrecioCboConTax.Lines = new string[0];
            this.txtPrecioCboConTax.Location = new System.Drawing.Point(552, 361);
            this.txtPrecioCboConTax.MaxLength = 32767;
            this.txtPrecioCboConTax.Name = "txtPrecioCboConTax";
            this.txtPrecioCboConTax.PasswordChar = '\0';
            this.txtPrecioCboConTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioCboConTax.SelectedText = "";
            this.txtPrecioCboConTax.SelectionLength = 0;
            this.txtPrecioCboConTax.SelectionStart = 0;
            this.txtPrecioCboConTax.ShortcutsEnabled = true;
            this.txtPrecioCboConTax.Size = new System.Drawing.Size(126, 23);
            this.txtPrecioCboConTax.TabIndex = 5;
            this.txtPrecioCboConTax.UseCustomBackColor = true;
            this.txtPrecioCboConTax.UseSelectable = true;
            this.txtPrecioCboConTax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioCboConTax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioCboConTax.TextChanged += new System.EventHandler(this.txtPrecioCboConTax_TextChanged);
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemDesc.CustomButton.Image = null;
            this.txtItemDesc.CustomButton.Location = new System.Drawing.Point(240, 1);
            this.txtItemDesc.CustomButton.Name = "";
            this.txtItemDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemDesc.CustomButton.TabIndex = 1;
            this.txtItemDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemDesc.CustomButton.UseSelectable = true;
            this.txtItemDesc.CustomButton.Visible = false;
            this.txtItemDesc.Lines = new string[0];
            this.txtItemDesc.Location = new System.Drawing.Point(80, 137);
            this.txtItemDesc.MaxLength = 32767;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.PasswordChar = '\0';
            this.txtItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemDesc.SelectedText = "";
            this.txtItemDesc.SelectionLength = 0;
            this.txtItemDesc.SelectionStart = 0;
            this.txtItemDesc.ShortcutsEnabled = true;
            this.txtItemDesc.Size = new System.Drawing.Size(262, 23);
            this.txtItemDesc.TabIndex = 4;
            this.txtItemDesc.UseCustomBackColor = true;
            this.txtItemDesc.UseSelectable = true;
            this.txtItemDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblItemDesc
            // 
            this.lblItemDesc.AutoSize = true;
            this.lblItemDesc.ForeColor = System.Drawing.Color.Navy;
            this.lblItemDesc.Location = new System.Drawing.Point(77, 115);
            this.lblItemDesc.Name = "lblItemDesc";
            this.lblItemDesc.Size = new System.Drawing.Size(113, 19);
            this.lblItemDesc.TabIndex = 131;
            this.lblItemDesc.Text = "Descrip. Producto";
            this.lblItemDesc.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(-2, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 130;
            this.metroLabel1.Text = "Combo detalle";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(114, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 5);
            this.panel2.TabIndex = 86;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkActivo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkActivo.ForeColor = System.Drawing.Color.Navy;
            this.chkActivo.Location = new System.Drawing.Point(0, 451);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 9;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseCustomForeColor = true;
            this.chkActivo.UseSelectable = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(459, 16);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(219, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.UseCustomBackColor = true;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Navy;
            this.lblCodigo.Location = new System.Drawing.Point(393, 18);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 19);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseCustomForeColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(77, 14);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(219, 23);
            this.txtNombre.TabIndex = 0;
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
            this.lblNombre.Location = new System.Drawing.Point(-1, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseCustomForeColor = true;
            // 
            // lblComboGrupo
            // 
            this.lblComboGrupo.AutoSize = true;
            this.lblComboGrupo.ForeColor = System.Drawing.Color.Navy;
            this.lblComboGrupo.Location = new System.Drawing.Point(-1, 52);
            this.lblComboGrupo.Name = "lblComboGrupo";
            this.lblComboGrupo.Size = new System.Drawing.Size(78, 19);
            this.lblComboGrupo.TabIndex = 153;
            this.lblComboGrupo.Text = "Grupo Cbo:";
            this.lblComboGrupo.UseCustomForeColor = true;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // errorProvDtl
            // 
            this.errorProvDtl.ContainerControl = this;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(28, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 148;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 683);
            this.Controls.Add(this.dgvCombo);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabCombo);
            this.MaximizeBox = false;
            this.Name = "FormCombo";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCombo)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            this.tabCombo.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            this.tabDetails.ResumeLayout(false);
            this.tabPagProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductDetail)).EndInit();
            this.tabPagCboElectivo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOfCboVarDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCboVariableDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvDtl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCombo;
        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private MetroFramework.Controls.MetroLabel lblIdCombo;
        private MetroFramework.Controls.MetroPanel panelFiltro;
        private MetroFramework.Controls.MetroLabel lblFiltro;
        private System.Windows.Forms.Button btnFilter;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private BorderedCombo cboFiltro;
        private MetroFramework.Controls.MetroPanel panelMantenimiento;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnDelete;
        private MetroFramework.Controls.MetroToggle tglListarInactivos;
        private MetroFramework.Controls.MetroLabel lblListarInactivos;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private MetroFramework.Controls.MetroTabControl tabCombo;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroLink btnBuscarItem;
        private MetroFramework.Controls.MetroLink btnItem;
        private System.Windows.Forms.DataGridView dgvProductDetail;
        private MetroFramework.Controls.MetroTextBox txtItemCod;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblPrecioSinImp;
        private MetroFramework.Controls.MetroTextBox txtItemPriceSinImp;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtItemPriceConImp;
        private MetroFramework.Controls.MetroLabel lblPrecioConImp;
        private MetroFramework.Controls.MetroTextBox txtItemQuantity;
        private MetroFramework.Controls.MetroLabel lblCantidad;
        private MetroFramework.Controls.MetroTextBox txtPrecioCboSinTax;
        private MetroFramework.Controls.MetroTextBox txtPrecioCboConTax;
        private MetroFramework.Controls.MetroTextBox txtItemDesc;
        private MetroFramework.Controls.MetroLabel lblItemDesc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.TabControl tabDetails;
        private System.Windows.Forms.TabPage tabPagProductos;
        private System.Windows.Forms.TabPage tabPagCboElectivo;
        private MetroFramework.Controls.MetroLink btnComboGrupo;
        private BorderedCombo cboComboGrupo;
        private MetroFramework.Controls.MetroLabel lblComboGrupo;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvCboVariableDetail;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.ErrorProvider errorProvDtl;
        private System.Windows.Forms.DataGridView dgvProductOfCboVarDetail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroCheckBox chkMostrarInactivos;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel lblPrecioCboSinTax;
        private MetroFramework.Controls.MetroLabel lblPrecioCboConTax;
        private MetroFramework.Controls.MetroCheckBox chkIncluyeImpto;
        private System.Windows.Forms.Label lblPorcentajeAcumuladoImpto;
        private System.Windows.Forms.Label lblSimboloPorcentaje;
        private BorderedCombo cboImpuesto;
        private MetroFramework.Controls.MetroLabel lblImpuesto;
        private MetroFramework.Controls.MetroLink btnImpuesto;
        private MetroFramework.Controls.MetroCheckBox chkPrecioAcumulado;
    }
}