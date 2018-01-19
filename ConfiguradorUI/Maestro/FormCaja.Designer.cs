namespace ConfiguradorUI.Maestro
{
    partial class FormCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCaja));
            this.lblIdCaja = new MetroFramework.Controls.MetroLabel();
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.dgvCaja = new System.Windows.Forms.DataGridView();
            this.panelFiltro = new MetroFramework.Controls.MetroPanel();
            this.lblFiltro = new MetroFramework.Controls.MetroLabel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.panelMantenimiento = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tglListarInactivos = new MetroFramework.Controls.MetroToggle();
            this.lblListarInactivos = new MetroFramework.Controls.MetroLabel();
            this.tabCaja = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.cboImpresora06 = new System.Windows.Forms.ComboBox();
            this.cboImpresora05 = new System.Windows.Forms.ComboBox();
            this.cboImpresora04 = new System.Windows.Forms.ComboBox();
            this.cboImpresora03 = new System.Windows.Forms.ComboBox();
            this.cboImpresora02 = new System.Windows.Forms.ComboBox();
            this.cboImpresora = new System.Windows.Forms.ComboBox();
            this.lblImpresoras = new MetroFramework.Controls.MetroLabel();
            this.btnImpresora06 = new MetroFramework.Controls.MetroLink();
            this.lblImpresora06 = new MetroFramework.Controls.MetroLabel();
            this.btnImpresora05 = new MetroFramework.Controls.MetroLink();
            this.lblImpresora05 = new MetroFramework.Controls.MetroLabel();
            this.btnImpresora04 = new MetroFramework.Controls.MetroLink();
            this.lblImpresora04 = new MetroFramework.Controls.MetroLabel();
            this.btnImpresora03 = new MetroFramework.Controls.MetroLink();
            this.lblImpresora03 = new MetroFramework.Controls.MetroLabel();
            this.btnImpresora02 = new MetroFramework.Controls.MetroLink();
            this.lblImpresora02 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIp = new MetroFramework.Controls.MetroTextBox();
            this.lblIp = new MetroFramework.Controls.MetroLabel();
            this.btnImpresora = new MetroFramework.Controls.MetroLink();
            this.lblImpresora = new MetroFramework.Controls.MetroLabel();
            this.txtInfo01 = new MetroFramework.Controls.MetroTextBox();
            this.txtInfo02 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo02 = new MetroFramework.Controls.MetroLabel();
            this.lblInfo01 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCod = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.tabPagConfigFiscal = new MetroFramework.Controls.MetroTabPage();
            this.dgvConfigFiscalCaja = new System.Windows.Forms.DataGridView();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            this.tabCaja.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.tabPagConfigFiscal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigFiscalCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdCaja
            // 
            this.lblIdCaja.AutoSize = true;
            this.lblIdCaja.Location = new System.Drawing.Point(450, 21);
            this.lblIdCaja.Name = "lblIdCaja";
            this.lblIdCaja.Size = new System.Drawing.Size(0, 0);
            this.lblIdCaja.TabIndex = 140;
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(177, 497);
            this.lblNumInactivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumInactivo.Name = "lblNumInactivo";
            this.lblNumInactivo.Size = new System.Drawing.Size(65, 17);
            this.lblNumInactivo.TabIndex = 139;
            this.lblNumInactivo.Text = "Inactivos: ";
            // 
            // lblNumActivo
            // 
            this.lblNumActivo.AutoSize = true;
            this.lblNumActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumActivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActivo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNumActivo.Location = new System.Drawing.Point(97, 497);
            this.lblNumActivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumActivo.Name = "lblNumActivo";
            this.lblNumActivo.Size = new System.Drawing.Size(56, 17);
            this.lblNumActivo.TabIndex = 138;
            this.lblNumActivo.Text = "Activos: ";
            // 
            // lblNumReg
            // 
            this.lblNumReg.AutoSize = true;
            this.lblNumReg.BackColor = System.Drawing.Color.Transparent;
            this.lblNumReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumReg.Location = new System.Drawing.Point(30, 496);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 137;
            this.lblNumReg.Text = "Total: ";
            // 
            // dgvCaja
            // 
            this.dgvCaja.AllowUserToAddRows = false;
            this.dgvCaja.AllowUserToResizeColumns = false;
            this.dgvCaja.AllowUserToResizeRows = false;
            this.dgvCaja.BackgroundColor = System.Drawing.Color.White;
            this.dgvCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCaja.Location = new System.Drawing.Point(39, 141);
            this.dgvCaja.MultiSelect = false;
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCaja.RowHeadersVisible = false;
            this.dgvCaja.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaja.Size = new System.Drawing.Size(222, 345);
            this.dgvCaja.TabIndex = 129;
            this.dgvCaja.SelectionChanged += new System.EventHandler(this.dgvCaja_SelectionChanged);
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
            this.panelFiltro.Location = new System.Drawing.Point(311, 470);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(544, 44);
            this.panelFiltro.TabIndex = 132;
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
            this.btnFilter.Location = new System.Drawing.Point(499, 6);
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
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(180, 1);
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
            this.txtFiltro.Size = new System.Drawing.Size(202, 23);
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
            this.cboFiltro.Location = new System.Drawing.Point(95, 11);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(172, 23);
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
            this.panelMantenimiento.Location = new System.Drawing.Point(311, 47);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(544, 49);
            this.panelMantenimiento.Style = MetroFramework.MetroColorStyle.Green;
            this.panelMantenimiento.TabIndex = 131;
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
            this.btnNuevo.Location = new System.Drawing.Point(370, 5);
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
            this.btnRollback.Location = new System.Drawing.Point(496, 5);
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
            this.btnCommit.Location = new System.Drawing.Point(454, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(412, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(137, 121);
            this.tglListarInactivos.Name = "tglListarInactivos";
            this.tglListarInactivos.Size = new System.Drawing.Size(80, 17);
            this.tglListarInactivos.TabIndex = 134;
            this.tglListarInactivos.Text = "Off";
            this.tglListarInactivos.UseSelectable = true;
            this.tglListarInactivos.Click += new System.EventHandler(this.tglListarInactivos_Click);
            // 
            // lblListarInactivos
            // 
            this.lblListarInactivos.AutoSize = true;
            this.lblListarInactivos.Location = new System.Drawing.Point(39, 119);
            this.lblListarInactivos.Name = "lblListarInactivos";
            this.lblListarInactivos.Size = new System.Drawing.Size(92, 19);
            this.lblListarInactivos.TabIndex = 133;
            this.lblListarInactivos.Text = "Listar inactivos";
            // 
            // tabCaja
            // 
            this.tabCaja.Controls.Add(this.tabPagGeneral);
            this.tabCaja.Controls.Add(this.tabPagConfigFiscal);
            this.tabCaja.Location = new System.Drawing.Point(311, 103);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.SelectedIndex = 1;
            this.tabCaja.Size = new System.Drawing.Size(562, 361);
            this.tabCaja.TabIndex = 130;
            this.tabCaja.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.cboImpresora06);
            this.tabPagGeneral.Controls.Add(this.cboImpresora05);
            this.tabPagGeneral.Controls.Add(this.cboImpresora04);
            this.tabPagGeneral.Controls.Add(this.cboImpresora03);
            this.tabPagGeneral.Controls.Add(this.cboImpresora02);
            this.tabPagGeneral.Controls.Add(this.cboImpresora);
            this.tabPagGeneral.Controls.Add(this.lblImpresoras);
            this.tabPagGeneral.Controls.Add(this.btnImpresora06);
            this.tabPagGeneral.Controls.Add(this.lblImpresora06);
            this.tabPagGeneral.Controls.Add(this.btnImpresora05);
            this.tabPagGeneral.Controls.Add(this.lblImpresora05);
            this.tabPagGeneral.Controls.Add(this.btnImpresora04);
            this.tabPagGeneral.Controls.Add(this.lblImpresora04);
            this.tabPagGeneral.Controls.Add(this.btnImpresora03);
            this.tabPagGeneral.Controls.Add(this.lblImpresora03);
            this.tabPagGeneral.Controls.Add(this.btnImpresora02);
            this.tabPagGeneral.Controls.Add(this.lblImpresora02);
            this.tabPagGeneral.Controls.Add(this.panel1);
            this.tabPagGeneral.Controls.Add(this.txtIp);
            this.tabPagGeneral.Controls.Add(this.lblIp);
            this.tabPagGeneral.Controls.Add(this.btnImpresora);
            this.tabPagGeneral.Controls.Add(this.lblImpresora);
            this.tabPagGeneral.Controls.Add(this.txtInfo01);
            this.tabPagGeneral.Controls.Add(this.txtInfo02);
            this.tabPagGeneral.Controls.Add(this.lblInfo02);
            this.tabPagGeneral.Controls.Add(this.lblInfo01);
            this.tabPagGeneral.Controls.Add(this.panel2);
            this.tabPagGeneral.Controls.Add(this.panel3);
            this.tabPagGeneral.Controls.Add(this.chkActivo);
            this.tabPagGeneral.Controls.Add(this.txtCodigo);
            this.tabPagGeneral.Controls.Add(this.lblCod);
            this.tabPagGeneral.Controls.Add(this.txtNombre);
            this.tabPagGeneral.Controls.Add(this.lblNombre);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(554, 319);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // cboImpresora06
            // 
            this.cboImpresora06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboImpresora06.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpresora06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboImpresora06.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpresora06.FormattingEnabled = true;
            this.cboImpresora06.Location = new System.Drawing.Point(348, 245);
            this.cboImpresora06.Name = "cboImpresora06";
            this.cboImpresora06.Size = new System.Drawing.Size(156, 23);
            this.cboImpresora06.TabIndex = 10;
            this.cboImpresora06.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboImpresora05
            // 
            this.cboImpresora05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboImpresora05.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpresora05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboImpresora05.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpresora05.FormattingEnabled = true;
            this.cboImpresora05.Location = new System.Drawing.Point(77, 248);
            this.cboImpresora05.Name = "cboImpresora05";
            this.cboImpresora05.Size = new System.Drawing.Size(156, 23);
            this.cboImpresora05.TabIndex = 9;
            this.cboImpresora05.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboImpresora04
            // 
            this.cboImpresora04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboImpresora04.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpresora04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboImpresora04.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpresora04.FormattingEnabled = true;
            this.cboImpresora04.Location = new System.Drawing.Point(348, 206);
            this.cboImpresora04.Name = "cboImpresora04";
            this.cboImpresora04.Size = new System.Drawing.Size(156, 23);
            this.cboImpresora04.TabIndex = 8;
            this.cboImpresora04.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboImpresora03
            // 
            this.cboImpresora03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboImpresora03.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpresora03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboImpresora03.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpresora03.FormattingEnabled = true;
            this.cboImpresora03.Location = new System.Drawing.Point(77, 209);
            this.cboImpresora03.Name = "cboImpresora03";
            this.cboImpresora03.Size = new System.Drawing.Size(156, 23);
            this.cboImpresora03.TabIndex = 7;
            this.cboImpresora03.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboImpresora02
            // 
            this.cboImpresora02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboImpresora02.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpresora02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboImpresora02.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpresora02.FormattingEnabled = true;
            this.cboImpresora02.Location = new System.Drawing.Point(348, 167);
            this.cboImpresora02.Name = "cboImpresora02";
            this.cboImpresora02.Size = new System.Drawing.Size(156, 23);
            this.cboImpresora02.TabIndex = 6;
            this.cboImpresora02.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboImpresora
            // 
            this.cboImpresora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboImpresora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboImpresora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpresora.FormattingEnabled = true;
            this.cboImpresora.Location = new System.Drawing.Point(77, 170);
            this.cboImpresora.Name = "cboImpresora";
            this.cboImpresora.Size = new System.Drawing.Size(156, 23);
            this.cboImpresora.TabIndex = 5;
            this.cboImpresora.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblImpresoras
            // 
            this.lblImpresoras.AutoSize = true;
            this.lblImpresoras.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblImpresoras.ForeColor = System.Drawing.Color.Navy;
            this.lblImpresoras.Location = new System.Drawing.Point(4, 138);
            this.lblImpresoras.Name = "lblImpresoras";
            this.lblImpresoras.Size = new System.Drawing.Size(84, 19);
            this.lblImpresoras.TabIndex = 118;
            this.lblImpresoras.Text = "Impresoras";
            this.lblImpresoras.UseCustomForeColor = true;
            // 
            // btnImpresora06
            // 
            this.btnImpresora06.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresora06.Image")));
            this.btnImpresora06.ImageSize = 24;
            this.btnImpresora06.Location = new System.Drawing.Point(504, 244);
            this.btnImpresora06.Name = "btnImpresora06";
            this.btnImpresora06.Size = new System.Drawing.Size(29, 27);
            this.btnImpresora06.TabIndex = 116;
            this.btnImpresora06.UseSelectable = true;
            this.btnImpresora06.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // lblImpresora06
            // 
            this.lblImpresora06.AutoSize = true;
            this.lblImpresora06.ForeColor = System.Drawing.Color.Navy;
            this.lblImpresora06.Location = new System.Drawing.Point(285, 249);
            this.lblImpresora06.Name = "lblImpresora06";
            this.lblImpresora06.Size = new System.Drawing.Size(59, 19);
            this.lblImpresora06.TabIndex = 115;
            this.lblImpresora06.Text = "Impr. 06:";
            this.lblImpresora06.UseCustomForeColor = true;
            // 
            // btnImpresora05
            // 
            this.btnImpresora05.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresora05.Image")));
            this.btnImpresora05.ImageSize = 24;
            this.btnImpresora05.Location = new System.Drawing.Point(233, 244);
            this.btnImpresora05.Name = "btnImpresora05";
            this.btnImpresora05.Size = new System.Drawing.Size(29, 27);
            this.btnImpresora05.TabIndex = 113;
            this.btnImpresora05.UseSelectable = true;
            this.btnImpresora05.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // lblImpresora05
            // 
            this.lblImpresora05.AutoSize = true;
            this.lblImpresora05.ForeColor = System.Drawing.Color.Navy;
            this.lblImpresora05.Location = new System.Drawing.Point(4, 249);
            this.lblImpresora05.Name = "lblImpresora05";
            this.lblImpresora05.Size = new System.Drawing.Size(59, 19);
            this.lblImpresora05.TabIndex = 112;
            this.lblImpresora05.Text = "Impr. 05:";
            this.lblImpresora05.UseCustomForeColor = true;
            // 
            // btnImpresora04
            // 
            this.btnImpresora04.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresora04.Image")));
            this.btnImpresora04.ImageSize = 24;
            this.btnImpresora04.Location = new System.Drawing.Point(504, 205);
            this.btnImpresora04.Name = "btnImpresora04";
            this.btnImpresora04.Size = new System.Drawing.Size(29, 27);
            this.btnImpresora04.TabIndex = 110;
            this.btnImpresora04.UseSelectable = true;
            this.btnImpresora04.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // lblImpresora04
            // 
            this.lblImpresora04.AutoSize = true;
            this.lblImpresora04.ForeColor = System.Drawing.Color.Navy;
            this.lblImpresora04.Location = new System.Drawing.Point(285, 210);
            this.lblImpresora04.Name = "lblImpresora04";
            this.lblImpresora04.Size = new System.Drawing.Size(59, 19);
            this.lblImpresora04.TabIndex = 109;
            this.lblImpresora04.Text = "Impr. 04:";
            this.lblImpresora04.UseCustomForeColor = true;
            // 
            // btnImpresora03
            // 
            this.btnImpresora03.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresora03.Image")));
            this.btnImpresora03.ImageSize = 24;
            this.btnImpresora03.Location = new System.Drawing.Point(233, 205);
            this.btnImpresora03.Name = "btnImpresora03";
            this.btnImpresora03.Size = new System.Drawing.Size(29, 27);
            this.btnImpresora03.TabIndex = 107;
            this.btnImpresora03.UseSelectable = true;
            this.btnImpresora03.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // lblImpresora03
            // 
            this.lblImpresora03.AutoSize = true;
            this.lblImpresora03.ForeColor = System.Drawing.Color.Navy;
            this.lblImpresora03.Location = new System.Drawing.Point(4, 210);
            this.lblImpresora03.Name = "lblImpresora03";
            this.lblImpresora03.Size = new System.Drawing.Size(59, 19);
            this.lblImpresora03.TabIndex = 106;
            this.lblImpresora03.Text = "Impr. 03:";
            this.lblImpresora03.UseCustomForeColor = true;
            // 
            // btnImpresora02
            // 
            this.btnImpresora02.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresora02.Image")));
            this.btnImpresora02.ImageSize = 24;
            this.btnImpresora02.Location = new System.Drawing.Point(504, 166);
            this.btnImpresora02.Name = "btnImpresora02";
            this.btnImpresora02.Size = new System.Drawing.Size(29, 27);
            this.btnImpresora02.TabIndex = 104;
            this.btnImpresora02.UseSelectable = true;
            this.btnImpresora02.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // lblImpresora02
            // 
            this.lblImpresora02.AutoSize = true;
            this.lblImpresora02.ForeColor = System.Drawing.Color.Navy;
            this.lblImpresora02.Location = new System.Drawing.Point(285, 171);
            this.lblImpresora02.Name = "lblImpresora02";
            this.lblImpresora02.Size = new System.Drawing.Size(59, 19);
            this.lblImpresora02.TabIndex = 103;
            this.lblImpresora02.Text = "Impr. 02:";
            this.lblImpresora02.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(82, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 8);
            this.panel1.TabIndex = 101;
            // 
            // txtIp
            // 
            this.txtIp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtIp.CustomButton.Image = null;
            this.txtIp.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtIp.CustomButton.Name = "";
            this.txtIp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtIp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIp.CustomButton.TabIndex = 1;
            this.txtIp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIp.CustomButton.UseSelectable = true;
            this.txtIp.CustomButton.Visible = false;
            this.txtIp.Lines = new string[0];
            this.txtIp.Location = new System.Drawing.Point(77, 72);
            this.txtIp.MaxLength = 32767;
            this.txtIp.Name = "txtIp";
            this.txtIp.PasswordChar = '\0';
            this.txtIp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIp.SelectedText = "";
            this.txtIp.SelectionLength = 0;
            this.txtIp.SelectionStart = 0;
            this.txtIp.ShortcutsEnabled = true;
            this.txtIp.Size = new System.Drawing.Size(184, 23);
            this.txtIp.TabIndex = 2;
            this.txtIp.UseCustomBackColor = true;
            this.txtIp.UseSelectable = true;
            this.txtIp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtIp.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.ForeColor = System.Drawing.Color.Navy;
            this.lblIp.Location = new System.Drawing.Point(4, 74);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(23, 19);
            this.lblIp.TabIndex = 99;
            this.lblIp.Text = "IP:";
            this.lblIp.UseCustomForeColor = true;
            // 
            // btnImpresora
            // 
            this.btnImpresora.Image = ((System.Drawing.Image)(resources.GetObject("btnImpresora.Image")));
            this.btnImpresora.ImageSize = 24;
            this.btnImpresora.Location = new System.Drawing.Point(233, 166);
            this.btnImpresora.Name = "btnImpresora";
            this.btnImpresora.Size = new System.Drawing.Size(29, 27);
            this.btnImpresora.TabIndex = 98;
            this.btnImpresora.UseSelectable = true;
            this.btnImpresora.Click += new System.EventHandler(this.btnImpresora_Click);
            // 
            // lblImpresora
            // 
            this.lblImpresora.AutoSize = true;
            this.lblImpresora.ForeColor = System.Drawing.Color.Navy;
            this.lblImpresora.Location = new System.Drawing.Point(4, 171);
            this.lblImpresora.Name = "lblImpresora";
            this.lblImpresora.Size = new System.Drawing.Size(57, 19);
            this.lblImpresora.TabIndex = 96;
            this.lblImpresora.Text = "Impr. 01:";
            this.lblImpresora.UseCustomForeColor = true;
            // 
            // txtInfo01
            // 
            this.txtInfo01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo01.CustomButton.Image = null;
            this.txtInfo01.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo01.CustomButton.Name = "";
            this.txtInfo01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo01.CustomButton.TabIndex = 1;
            this.txtInfo01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo01.CustomButton.UseSelectable = true;
            this.txtInfo01.CustomButton.Visible = false;
            this.txtInfo01.Lines = new string[0];
            this.txtInfo01.Location = new System.Drawing.Point(348, 72);
            this.txtInfo01.MaxLength = 32767;
            this.txtInfo01.Name = "txtInfo01";
            this.txtInfo01.PasswordChar = '\0';
            this.txtInfo01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo01.SelectedText = "";
            this.txtInfo01.SelectionLength = 0;
            this.txtInfo01.SelectionStart = 0;
            this.txtInfo01.ShortcutsEnabled = true;
            this.txtInfo01.Size = new System.Drawing.Size(184, 23);
            this.txtInfo01.TabIndex = 3;
            this.txtInfo01.UseCustomBackColor = true;
            this.txtInfo01.UseSelectable = true;
            this.txtInfo01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtInfo02
            // 
            this.txtInfo02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo02.CustomButton.Image = null;
            this.txtInfo02.CustomButton.Location = new System.Drawing.Point(433, 1);
            this.txtInfo02.CustomButton.Name = "";
            this.txtInfo02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo02.CustomButton.TabIndex = 1;
            this.txtInfo02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo02.CustomButton.UseSelectable = true;
            this.txtInfo02.CustomButton.Visible = false;
            this.txtInfo02.Lines = new string[0];
            this.txtInfo02.Location = new System.Drawing.Point(77, 109);
            this.txtInfo02.MaxLength = 32767;
            this.txtInfo02.Name = "txtInfo02";
            this.txtInfo02.PasswordChar = '\0';
            this.txtInfo02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo02.SelectedText = "";
            this.txtInfo02.SelectionLength = 0;
            this.txtInfo02.SelectionStart = 0;
            this.txtInfo02.ShortcutsEnabled = true;
            this.txtInfo02.Size = new System.Drawing.Size(455, 23);
            this.txtInfo02.TabIndex = 4;
            this.txtInfo02.UseCustomBackColor = true;
            this.txtInfo02.UseSelectable = true;
            this.txtInfo02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo02
            // 
            this.lblInfo02.AutoSize = true;
            this.lblInfo02.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo02.Location = new System.Drawing.Point(3, 111);
            this.lblInfo02.Name = "lblInfo02";
            this.lblInfo02.Size = new System.Drawing.Size(52, 19);
            this.lblInfo02.TabIndex = 93;
            this.lblInfo02.Text = "Info 02:";
            this.lblInfo02.UseCustomForeColor = true;
            // 
            // lblInfo01
            // 
            this.lblInfo01.AutoSize = true;
            this.lblInfo01.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo01.Location = new System.Drawing.Point(285, 74);
            this.lblInfo01.Name = "lblInfo01";
            this.lblInfo01.Size = new System.Drawing.Size(53, 19);
            this.lblInfo01.TabIndex = 87;
            this.lblInfo01.Text = "Info. 01:";
            this.lblInfo01.UseCustomForeColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(4, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 8);
            this.panel2.TabIndex = 86;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(4, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 8);
            this.panel3.TabIndex = 65;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkActivo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkActivo.ForeColor = System.Drawing.Color.Navy;
            this.chkActivo.Location = new System.Drawing.Point(9, 300);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 11;
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
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(348, 14);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(184, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.UseCustomBackColor = true;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.ForeColor = System.Drawing.Color.Navy;
            this.lblCod.Location = new System.Drawing.Point(283, 16);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(56, 19);
            this.lblCod.TabIndex = 2;
            this.lblCod.Text = "Código:";
            this.lblCod.UseCustomForeColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(162, 1);
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
            this.txtNombre.Size = new System.Drawing.Size(184, 23);
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
            this.lblNombre.Location = new System.Drawing.Point(1, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseCustomForeColor = true;
            // 
            // tabPagConfigFiscal
            // 
            this.tabPagConfigFiscal.Controls.Add(this.dgvConfigFiscalCaja);
            this.tabPagConfigFiscal.HorizontalScrollbarBarColor = true;
            this.tabPagConfigFiscal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagConfigFiscal.HorizontalScrollbarSize = 10;
            this.tabPagConfigFiscal.Location = new System.Drawing.Point(4, 38);
            this.tabPagConfigFiscal.Name = "tabPagConfigFiscal";
            this.tabPagConfigFiscal.Size = new System.Drawing.Size(554, 319);
            this.tabPagConfigFiscal.TabIndex = 1;
            this.tabPagConfigFiscal.Text = "Configuración Fiscal";
            this.tabPagConfigFiscal.VerticalScrollbarBarColor = true;
            this.tabPagConfigFiscal.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagConfigFiscal.VerticalScrollbarSize = 10;
            // 
            // dgvConfigFiscalCaja
            // 
            this.dgvConfigFiscalCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfigFiscalCaja.Location = new System.Drawing.Point(3, 16);
            this.dgvConfigFiscalCaja.Name = "dgvConfigFiscalCaja";
            this.dgvConfigFiscalCaja.Size = new System.Drawing.Size(548, 300);
            this.dgvConfigFiscalCaja.TabIndex = 2;
            this.dgvConfigFiscalCaja.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConfigFiscalCaja_CellValueChanged);
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(84, 51);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(69, 32);
            this.lblNombreForm.TabIndex = 136;
            this.lblNombreForm.Text = "Cajas";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(27, 39);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 135;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // FormCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(900, 552);
            this.Controls.Add(this.lblIdCaja);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.dgvCaja);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.Controls.Add(this.tabCaja);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormCaja";
            this.Load += new System.EventHandler(this.FormCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            this.tabCaja.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            this.tabPagConfigFiscal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfigFiscalCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblIdCaja;
        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private System.Windows.Forms.DataGridView dgvCaja;
        private MetroFramework.Controls.MetroPanel panelFiltro;
        private MetroFramework.Controls.MetroLabel lblFiltro;
        private System.Windows.Forms.Button btnFilter;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private System.Windows.Forms.ComboBox cboFiltro;
        private MetroFramework.Controls.MetroPanel panelMantenimiento;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnDelete;
        private MetroFramework.Controls.MetroToggle tglListarInactivos;
        private MetroFramework.Controls.MetroLabel lblListarInactivos;
        private MetroFramework.Controls.MetroTabControl tabCaja;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroTextBox txtInfo01;
        private MetroFramework.Controls.MetroTextBox txtInfo02;
        private MetroFramework.Controls.MetroLabel lblInfo02;
        private MetroFramework.Controls.MetroLabel lblInfo01;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblCod;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private MetroFramework.Controls.MetroLink btnImpresora;
        private MetroFramework.Controls.MetroLabel lblImpresora;
        private MetroFramework.Controls.MetroLink btnImpresora06;
        private MetroFramework.Controls.MetroLabel lblImpresora06;
        private MetroFramework.Controls.MetroLink btnImpresora05;
        private MetroFramework.Controls.MetroLabel lblImpresora05;
        private MetroFramework.Controls.MetroLink btnImpresora04;
        private MetroFramework.Controls.MetroLabel lblImpresora04;
        private MetroFramework.Controls.MetroLink btnImpresora03;
        private MetroFramework.Controls.MetroLabel lblImpresora03;
        private MetroFramework.Controls.MetroLink btnImpresora02;
        private MetroFramework.Controls.MetroLabel lblImpresora02;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox txtIp;
        private MetroFramework.Controls.MetroLabel lblIp;
        private System.Windows.Forms.ErrorProvider errorProv;
        private MetroFramework.Controls.MetroLabel lblImpresoras;
        private System.Windows.Forms.ComboBox cboImpresora;
        private System.Windows.Forms.ComboBox cboImpresora06;
        private System.Windows.Forms.ComboBox cboImpresora05;
        private System.Windows.Forms.ComboBox cboImpresora04;
        private System.Windows.Forms.ComboBox cboImpresora03;
        private System.Windows.Forms.ComboBox cboImpresora02;
        private MetroFramework.Controls.MetroTabPage tabPagConfigFiscal;
        private System.Windows.Forms.DataGridView dgvConfigFiscalCaja;
    }
}