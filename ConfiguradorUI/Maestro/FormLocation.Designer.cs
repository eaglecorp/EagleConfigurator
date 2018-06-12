using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Maestro
{
    partial class FormLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLocation));
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
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
            this.tabLocation = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboTipoLocation = new ConfigUtilitarios.Controls.BorderedCombo();
            this.txtFono02 = new MetroFramework.Controls.MetroTextBox();
            this.lblFono02 = new MetroFramework.Controls.MetroLabel();
            this.txtFono01 = new MetroFramework.Controls.MetroTextBox();
            this.lblFono01 = new MetroFramework.Controls.MetroLabel();
            this.dtpFechaNegocio = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNegocio = new MetroFramework.Controls.MetroLabel();
            this.txtNumRuc = new MetroFramework.Controls.MetroTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRUC = new MetroFramework.Controls.MetroLabel();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.btnTipoLocation = new MetroFramework.Controls.MetroLink();
            this.chkLocationActual = new MetroFramework.Controls.MetroCheckBox();
            this.chkAlmacen = new MetroFramework.Controls.MetroCheckBox();
            this.lblTipoLocation = new MetroFramework.Controls.MetroLabel();
            this.txtAbrev02 = new MetroFramework.Controls.MetroTextBox();
            this.lblAbrev02 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.txtAbrev01 = new MetroFramework.Controls.MetroTextBox();
            this.lblAbrev01 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.tabPagDireccion = new MetroFramework.Controls.MetroTabPage();
            this.grbUbicacionDetallada = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblLongitud = new MetroFramework.Controls.MetroLabel();
            this.txtLongitud = new MetroFramework.Controls.MetroTextBox();
            this.txtDireccion01 = new MetroFramework.Controls.MetroTextBox();
            this.lblDireccion01 = new MetroFramework.Controls.MetroLabel();
            this.lblDireccion02 = new MetroFramework.Controls.MetroLabel();
            this.txtLatitud = new MetroFramework.Controls.MetroTextBox();
            this.txtDireccion02 = new MetroFramework.Controls.MetroTextBox();
            this.lblLatitud = new MetroFramework.Controls.MetroLabel();
            this.gbrUbigeo = new System.Windows.Forms.GroupBox();
            this.lblDepartamento = new MetroFramework.Controls.MetroLabel();
            this.cboDepartamento = new ConfigUtilitarios.Controls.BorderedCombo();
            this.cboDistrito = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblDistrito = new MetroFramework.Controls.MetroLabel();
            this.lblProvincia = new MetroFramework.Controls.MetroLabel();
            this.cboProvincia = new ConfigUtilitarios.Controls.BorderedCombo();
            this.tabPagInfoExtra = new MetroFramework.Controls.MetroTabPage();
            this.grbInfoExtra = new System.Windows.Forms.GroupBox();
            this.txtDato04 = new MetroFramework.Controls.MetroTextBox();
            this.txtDato01 = new MetroFramework.Controls.MetroTextBox();
            this.lblDato02 = new MetroFramework.Controls.MetroLabel();
            this.txtDato03 = new MetroFramework.Controls.MetroTextBox();
            this.lblDato04 = new MetroFramework.Controls.MetroLabel();
            this.lblDato03 = new MetroFramework.Controls.MetroLabel();
            this.txtDato02 = new MetroFramework.Controls.MetroTextBox();
            this.lblDato01 = new MetroFramework.Controls.MetroLabel();
            this.tglListarInactivos = new MetroFramework.Controls.MetroToggle();
            this.lblListarInactivos = new MetroFramework.Controls.MetroLabel();
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblIdLocation = new MetroFramework.Controls.MetroLabel();
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.panelFiltro.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            this.tabLocation.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.tabPagDireccion.SuspendLayout();
            this.grbUbicacionDetallada.SuspendLayout();
            this.gbrUbigeo.SuspendLayout();
            this.tabPagInfoExtra.SuspendLayout();
            this.grbInfoExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(113, 32);
            this.lblNombreForm.TabIndex = 58;
            this.lblNombreForm.Text = "Locations";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(28, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.panelFiltro.Location = new System.Drawing.Point(312, 375);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(551, 49);
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
            this.lblFiltro.Location = new System.Drawing.Point(13, 15);
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
            this.btnFilter.Location = new System.Drawing.Point(507, 9);
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
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(291, 13);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PromptText = "Filtro";
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(209, 23);
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
            this.cboFiltro.Location = new System.Drawing.Point(95, 13);
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
            this.panelMantenimiento.Location = new System.Drawing.Point(312, 36);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(551, 49);
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
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(381, 5);
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
            this.btnRollback.Location = new System.Drawing.Point(507, 5);
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
            this.btnCommit.Location = new System.Drawing.Point(465, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(423, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tabLocation
            // 
            this.tabLocation.Controls.Add(this.tabPagGeneral);
            this.tabLocation.Controls.Add(this.tabPagDireccion);
            this.tabLocation.Controls.Add(this.tabPagInfoExtra);
            this.tabLocation.Location = new System.Drawing.Point(312, 91);
            this.tabLocation.Name = "tabLocation";
            this.tabLocation.SelectedIndex = 0;
            this.tabLocation.Size = new System.Drawing.Size(567, 282);
            this.tabLocation.TabIndex = 1;
            this.tabLocation.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.panel2);
            this.tabPagGeneral.Controls.Add(this.cboTipoLocation);
            this.tabPagGeneral.Controls.Add(this.txtFono02);
            this.tabPagGeneral.Controls.Add(this.lblFono02);
            this.tabPagGeneral.Controls.Add(this.txtFono01);
            this.tabPagGeneral.Controls.Add(this.lblFono01);
            this.tabPagGeneral.Controls.Add(this.dtpFechaNegocio);
            this.tabPagGeneral.Controls.Add(this.lblFechaNegocio);
            this.tabPagGeneral.Controls.Add(this.txtNumRuc);
            this.tabPagGeneral.Controls.Add(this.panel1);
            this.tabPagGeneral.Controls.Add(this.lblRUC);
            this.tabPagGeneral.Controls.Add(this.chkActivo);
            this.tabPagGeneral.Controls.Add(this.btnTipoLocation);
            this.tabPagGeneral.Controls.Add(this.chkLocationActual);
            this.tabPagGeneral.Controls.Add(this.chkAlmacen);
            this.tabPagGeneral.Controls.Add(this.lblTipoLocation);
            this.tabPagGeneral.Controls.Add(this.txtAbrev02);
            this.tabPagGeneral.Controls.Add(this.lblAbrev02);
            this.tabPagGeneral.Controls.Add(this.txtCodigo);
            this.tabPagGeneral.Controls.Add(this.lblCodigo);
            this.tabPagGeneral.Controls.Add(this.txtAbrev01);
            this.tabPagGeneral.Controls.Add(this.lblAbrev01);
            this.tabPagGeneral.Controls.Add(this.txtNombre);
            this.tabPagGeneral.Controls.Add(this.lblNombre);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(559, 240);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 5);
            this.panel2.TabIndex = 62;
            // 
            // cboTipoLocation
            // 
            this.cboTipoLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTipoLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoLocation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoLocation.FormattingEnabled = true;
            this.cboTipoLocation.Location = new System.Drawing.Point(75, 133);
            this.cboTipoLocation.Name = "cboTipoLocation";
            this.cboTipoLocation.Size = new System.Drawing.Size(154, 23);
            this.cboTipoLocation.TabIndex = 9;
            this.cboTipoLocation.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtFono02
            // 
            this.txtFono02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtFono02.CustomButton.Image = null;
            this.txtFono02.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtFono02.CustomButton.Name = "";
            this.txtFono02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFono02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFono02.CustomButton.TabIndex = 1;
            this.txtFono02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFono02.CustomButton.UseSelectable = true;
            this.txtFono02.CustomButton.Visible = false;
            this.txtFono02.Lines = new string[0];
            this.txtFono02.Location = new System.Drawing.Point(359, 168);
            this.txtFono02.MaxLength = 32767;
            this.txtFono02.Name = "txtFono02";
            this.txtFono02.PasswordChar = '\0';
            this.txtFono02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFono02.SelectedText = "";
            this.txtFono02.SelectionLength = 0;
            this.txtFono02.SelectionStart = 0;
            this.txtFono02.ShortcutsEnabled = true;
            this.txtFono02.Size = new System.Drawing.Size(184, 23);
            this.txtFono02.TabIndex = 20;
            this.txtFono02.UseCustomBackColor = true;
            this.txtFono02.UseSelectable = true;
            this.txtFono02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFono02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFono02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblFono02
            // 
            this.lblFono02.AutoSize = true;
            this.lblFono02.ForeColor = System.Drawing.Color.Navy;
            this.lblFono02.Location = new System.Drawing.Point(283, 170);
            this.lblFono02.Name = "lblFono02";
            this.lblFono02.Size = new System.Drawing.Size(51, 19);
            this.lblFono02.TabIndex = 19;
            this.lblFono02.Text = "Telf. 02:";
            this.lblFono02.UseCustomForeColor = true;
            // 
            // txtFono01
            // 
            this.txtFono01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtFono01.CustomButton.Image = null;
            this.txtFono01.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtFono01.CustomButton.Name = "";
            this.txtFono01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFono01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFono01.CustomButton.TabIndex = 1;
            this.txtFono01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFono01.CustomButton.UseSelectable = true;
            this.txtFono01.CustomButton.Visible = false;
            this.txtFono01.Lines = new string[0];
            this.txtFono01.Location = new System.Drawing.Point(75, 168);
            this.txtFono01.MaxLength = 32767;
            this.txtFono01.Name = "txtFono01";
            this.txtFono01.PasswordChar = '\0';
            this.txtFono01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFono01.SelectedText = "";
            this.txtFono01.SelectionLength = 0;
            this.txtFono01.SelectionStart = 0;
            this.txtFono01.ShortcutsEnabled = true;
            this.txtFono01.Size = new System.Drawing.Size(184, 23);
            this.txtFono01.TabIndex = 18;
            this.txtFono01.UseCustomBackColor = true;
            this.txtFono01.UseSelectable = true;
            this.txtFono01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFono01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFono01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblFono01
            // 
            this.lblFono01.AutoSize = true;
            this.lblFono01.ForeColor = System.Drawing.Color.Navy;
            this.lblFono01.Location = new System.Drawing.Point(1, 170);
            this.lblFono01.Name = "lblFono01";
            this.lblFono01.Size = new System.Drawing.Size(49, 19);
            this.lblFono01.TabIndex = 17;
            this.lblFono01.Text = "Telf. 01:";
            this.lblFono01.UseCustomForeColor = true;
            // 
            // dtpFechaNegocio
            // 
            this.dtpFechaNegocio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpFechaNegocio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNegocio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNegocio.Location = new System.Drawing.Point(75, 98);
            this.dtpFechaNegocio.Name = "dtpFechaNegocio";
            this.dtpFechaNegocio.Size = new System.Drawing.Size(184, 23);
            this.dtpFechaNegocio.TabIndex = 13;
            this.dtpFechaNegocio.ValueChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblFechaNegocio
            // 
            this.lblFechaNegocio.AutoSize = true;
            this.lblFechaNegocio.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaNegocio.Location = new System.Drawing.Point(1, 100);
            this.lblFechaNegocio.Name = "lblFechaNegocio";
            this.lblFechaNegocio.Size = new System.Drawing.Size(74, 19);
            this.lblFechaNegocio.TabIndex = 12;
            this.lblFechaNegocio.Text = "F. Negocio:";
            this.lblFechaNegocio.UseCustomForeColor = true;
            // 
            // txtNumRuc
            // 
            this.txtNumRuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNumRuc.CustomButton.Image = null;
            this.txtNumRuc.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNumRuc.CustomButton.Name = "";
            this.txtNumRuc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumRuc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumRuc.CustomButton.TabIndex = 1;
            this.txtNumRuc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumRuc.CustomButton.UseSelectable = true;
            this.txtNumRuc.CustomButton.Visible = false;
            this.txtNumRuc.Lines = new string[0];
            this.txtNumRuc.Location = new System.Drawing.Point(359, 133);
            this.txtNumRuc.MaxLength = 32767;
            this.txtNumRuc.Name = "txtNumRuc";
            this.txtNumRuc.PasswordChar = '\0';
            this.txtNumRuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumRuc.SelectedText = "";
            this.txtNumRuc.SelectionLength = 0;
            this.txtNumRuc.SelectionStart = 0;
            this.txtNumRuc.ShortcutsEnabled = true;
            this.txtNumRuc.Size = new System.Drawing.Size(184, 23);
            this.txtNumRuc.TabIndex = 11;
            this.txtNumRuc.UseCustomBackColor = true;
            this.txtNumRuc.UseSelectable = true;
            this.txtNumRuc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumRuc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumRuc.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 5);
            this.panel1.TabIndex = 57;
            // 
            // lblRUC
            // 
            this.lblRUC.AutoSize = true;
            this.lblRUC.ForeColor = System.Drawing.Color.Navy;
            this.lblRUC.Location = new System.Drawing.Point(283, 135);
            this.lblRUC.Name = "lblRUC";
            this.lblRUC.Size = new System.Drawing.Size(57, 19);
            this.lblRUC.TabIndex = 10;
            this.lblRUC.Text = "N° RUC:";
            this.lblRUC.UseCustomForeColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkActivo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkActivo.ForeColor = System.Drawing.Color.Navy;
            this.chkActivo.Location = new System.Drawing.Point(3, 218);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 16;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseCustomForeColor = true;
            this.chkActivo.UseSelectable = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // btnTipoLocation
            // 
            this.btnTipoLocation.Image = ((System.Drawing.Image)(resources.GetObject("btnTipoLocation.Image")));
            this.btnTipoLocation.ImageSize = 24;
            this.btnTipoLocation.Location = new System.Drawing.Point(235, 128);
            this.btnTipoLocation.Name = "btnTipoLocation";
            this.btnTipoLocation.Size = new System.Drawing.Size(29, 27);
            this.btnTipoLocation.TabIndex = 46;
            this.btnTipoLocation.UseSelectable = true;
            this.btnTipoLocation.Click += new System.EventHandler(this.btnTipoLocation_Click);
            // 
            // chkLocationActual
            // 
            this.chkLocationActual.AutoSize = true;
            this.chkLocationActual.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkLocationActual.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkLocationActual.ForeColor = System.Drawing.Color.Navy;
            this.chkLocationActual.Location = new System.Drawing.Point(177, 218);
            this.chkLocationActual.Name = "chkLocationActual";
            this.chkLocationActual.Size = new System.Drawing.Size(114, 19);
            this.chkLocationActual.TabIndex = 15;
            this.chkLocationActual.Text = "Location Actual";
            this.chkLocationActual.UseCustomForeColor = true;
            this.chkLocationActual.UseSelectable = true;
            this.chkLocationActual.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // chkAlmacen
            // 
            this.chkAlmacen.AutoSize = true;
            this.chkAlmacen.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkAlmacen.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkAlmacen.ForeColor = System.Drawing.Color.Navy;
            this.chkAlmacen.Location = new System.Drawing.Point(83, 218);
            this.chkAlmacen.Name = "chkAlmacen";
            this.chkAlmacen.Size = new System.Drawing.Size(76, 19);
            this.chkAlmacen.TabIndex = 14;
            this.chkAlmacen.Text = "Almacén";
            this.chkAlmacen.UseCustomForeColor = true;
            this.chkAlmacen.UseSelectable = true;
            this.chkAlmacen.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblTipoLocation
            // 
            this.lblTipoLocation.AutoSize = true;
            this.lblTipoLocation.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoLocation.Location = new System.Drawing.Point(1, 135);
            this.lblTipoLocation.Name = "lblTipoLocation";
            this.lblTipoLocation.Size = new System.Drawing.Size(73, 19);
            this.lblTipoLocation.TabIndex = 8;
            this.lblTipoLocation.Text = "Tipo Locat:";
            this.lblTipoLocation.UseCustomForeColor = true;
            // 
            // txtAbrev02
            // 
            this.txtAbrev02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtAbrev02.CustomButton.Image = null;
            this.txtAbrev02.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtAbrev02.CustomButton.Name = "";
            this.txtAbrev02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAbrev02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAbrev02.CustomButton.TabIndex = 1;
            this.txtAbrev02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAbrev02.CustomButton.UseSelectable = true;
            this.txtAbrev02.CustomButton.Visible = false;
            this.txtAbrev02.Lines = new string[0];
            this.txtAbrev02.Location = new System.Drawing.Point(359, 45);
            this.txtAbrev02.MaxLength = 32767;
            this.txtAbrev02.Name = "txtAbrev02";
            this.txtAbrev02.PasswordChar = '\0';
            this.txtAbrev02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAbrev02.SelectedText = "";
            this.txtAbrev02.SelectionLength = 0;
            this.txtAbrev02.SelectionStart = 0;
            this.txtAbrev02.ShortcutsEnabled = true;
            this.txtAbrev02.Size = new System.Drawing.Size(184, 23);
            this.txtAbrev02.TabIndex = 7;
            this.txtAbrev02.UseCustomBackColor = true;
            this.txtAbrev02.UseSelectable = true;
            this.txtAbrev02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAbrev02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAbrev02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblAbrev02
            // 
            this.lblAbrev02.AutoSize = true;
            this.lblAbrev02.ForeColor = System.Drawing.Color.Navy;
            this.lblAbrev02.Location = new System.Drawing.Point(283, 47);
            this.lblAbrev02.Name = "lblAbrev02";
            this.lblAbrev02.Size = new System.Drawing.Size(67, 19);
            this.lblAbrev02.TabIndex = 6;
            this.lblAbrev02.Text = "Abrev. 02:";
            this.lblAbrev02.UseCustomForeColor = true;
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
            this.txtCodigo.Location = new System.Drawing.Point(359, 11);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(184, 23);
            this.txtCodigo.TabIndex = 3;
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
            this.lblCodigo.Location = new System.Drawing.Point(283, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 19);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseCustomForeColor = true;
            // 
            // txtAbrev01
            // 
            this.txtAbrev01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtAbrev01.CustomButton.Image = null;
            this.txtAbrev01.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtAbrev01.CustomButton.Name = "";
            this.txtAbrev01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAbrev01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAbrev01.CustomButton.TabIndex = 1;
            this.txtAbrev01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAbrev01.CustomButton.UseSelectable = true;
            this.txtAbrev01.CustomButton.Visible = false;
            this.txtAbrev01.Lines = new string[0];
            this.txtAbrev01.Location = new System.Drawing.Point(75, 45);
            this.txtAbrev01.MaxLength = 32767;
            this.txtAbrev01.Name = "txtAbrev01";
            this.txtAbrev01.PasswordChar = '\0';
            this.txtAbrev01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAbrev01.SelectedText = "";
            this.txtAbrev01.SelectionLength = 0;
            this.txtAbrev01.SelectionStart = 0;
            this.txtAbrev01.ShortcutsEnabled = true;
            this.txtAbrev01.Size = new System.Drawing.Size(184, 23);
            this.txtAbrev01.TabIndex = 5;
            this.txtAbrev01.UseCustomBackColor = true;
            this.txtAbrev01.UseSelectable = true;
            this.txtAbrev01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAbrev01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAbrev01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblAbrev01
            // 
            this.lblAbrev01.AutoSize = true;
            this.lblAbrev01.ForeColor = System.Drawing.Color.Navy;
            this.lblAbrev01.Location = new System.Drawing.Point(1, 47);
            this.lblAbrev01.Name = "lblAbrev01";
            this.lblAbrev01.Size = new System.Drawing.Size(65, 19);
            this.lblAbrev01.TabIndex = 4;
            this.lblAbrev01.Text = "Abrev. 01:";
            this.lblAbrev01.UseCustomForeColor = true;
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
            this.txtNombre.Location = new System.Drawing.Point(75, 11);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(184, 23);
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
            // tabPagDireccion
            // 
            this.tabPagDireccion.Controls.Add(this.grbUbicacionDetallada);
            this.tabPagDireccion.Controls.Add(this.gbrUbigeo);
            this.tabPagDireccion.HorizontalScrollbarBarColor = true;
            this.tabPagDireccion.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagDireccion.HorizontalScrollbarSize = 10;
            this.tabPagDireccion.Location = new System.Drawing.Point(4, 38);
            this.tabPagDireccion.Name = "tabPagDireccion";
            this.tabPagDireccion.Size = new System.Drawing.Size(559, 240);
            this.tabPagDireccion.TabIndex = 1;
            this.tabPagDireccion.Text = "Dirección";
            this.tabPagDireccion.VerticalScrollbarBarColor = true;
            this.tabPagDireccion.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagDireccion.VerticalScrollbarSize = 10;
            // 
            // grbUbicacionDetallada
            // 
            this.grbUbicacionDetallada.BackColor = System.Drawing.Color.Transparent;
            this.grbUbicacionDetallada.Controls.Add(this.metroLabel1);
            this.grbUbicacionDetallada.Controls.Add(this.lblLongitud);
            this.grbUbicacionDetallada.Controls.Add(this.txtLongitud);
            this.grbUbicacionDetallada.Controls.Add(this.txtDireccion01);
            this.grbUbicacionDetallada.Controls.Add(this.lblDireccion01);
            this.grbUbicacionDetallada.Controls.Add(this.lblDireccion02);
            this.grbUbicacionDetallada.Controls.Add(this.txtLatitud);
            this.grbUbicacionDetallada.Controls.Add(this.txtDireccion02);
            this.grbUbicacionDetallada.Controls.Add(this.lblLatitud);
            this.grbUbicacionDetallada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUbicacionDetallada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUbicacionDetallada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbUbicacionDetallada.Location = new System.Drawing.Point(1, 109);
            this.grbUbicacionDetallada.Name = "grbUbicacionDetallada";
            this.grbUbicacionDetallada.Size = new System.Drawing.Size(555, 129);
            this.grbUbicacionDetallada.TabIndex = 58;
            this.grbUbicacionDetallada.TabStop = false;
            this.grbUbicacionDetallada.Text = "Ubicación detallada";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(6, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(139, 19);
            this.metroLabel1.TabIndex = 67;
            this.metroLabel1.Text = "Ubicación en el mapa:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.ForeColor = System.Drawing.Color.Navy;
            this.lblLongitud.Location = new System.Drawing.Point(379, 97);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(63, 19);
            this.lblLongitud.TabIndex = 65;
            this.lblLongitud.Text = "Longitud:";
            this.lblLongitud.UseCustomForeColor = true;
            // 
            // txtLongitud
            // 
            this.txtLongitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtLongitud.CustomButton.Image = null;
            this.txtLongitud.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtLongitud.CustomButton.Name = "";
            this.txtLongitud.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLongitud.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLongitud.CustomButton.TabIndex = 1;
            this.txtLongitud.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLongitud.CustomButton.UseSelectable = true;
            this.txtLongitud.CustomButton.Visible = false;
            this.txtLongitud.Lines = new string[0];
            this.txtLongitud.Location = new System.Drawing.Point(442, 95);
            this.txtLongitud.MaxLength = 32767;
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.PasswordChar = '\0';
            this.txtLongitud.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLongitud.SelectedText = "";
            this.txtLongitud.SelectionLength = 0;
            this.txtLongitud.SelectionStart = 0;
            this.txtLongitud.ShortcutsEnabled = true;
            this.txtLongitud.Size = new System.Drawing.Size(93, 23);
            this.txtLongitud.TabIndex = 66;
            this.txtLongitud.UseCustomBackColor = true;
            this.txtLongitud.UseSelectable = true;
            this.txtLongitud.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLongitud.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLongitud.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtDireccion01
            // 
            this.txtDireccion01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDireccion01.CustomButton.Image = null;
            this.txtDireccion01.CustomButton.Location = new System.Drawing.Point(446, 1);
            this.txtDireccion01.CustomButton.Name = "";
            this.txtDireccion01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion01.CustomButton.TabIndex = 1;
            this.txtDireccion01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion01.CustomButton.UseSelectable = true;
            this.txtDireccion01.CustomButton.Visible = false;
            this.txtDireccion01.Lines = new string[0];
            this.txtDireccion01.Location = new System.Drawing.Point(80, 26);
            this.txtDireccion01.MaxLength = 32767;
            this.txtDireccion01.Name = "txtDireccion01";
            this.txtDireccion01.PasswordChar = '\0';
            this.txtDireccion01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion01.SelectedText = "";
            this.txtDireccion01.SelectionLength = 0;
            this.txtDireccion01.SelectionStart = 0;
            this.txtDireccion01.ShortcutsEnabled = true;
            this.txtDireccion01.Size = new System.Drawing.Size(468, 23);
            this.txtDireccion01.TabIndex = 30;
            this.txtDireccion01.UseCustomBackColor = true;
            this.txtDireccion01.UseSelectable = true;
            this.txtDireccion01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblDireccion01
            // 
            this.lblDireccion01.AutoSize = true;
            this.lblDireccion01.ForeColor = System.Drawing.Color.Navy;
            this.lblDireccion01.Location = new System.Drawing.Point(6, 28);
            this.lblDireccion01.Name = "lblDireccion01";
            this.lblDireccion01.Size = new System.Drawing.Size(46, 19);
            this.lblDireccion01.TabIndex = 29;
            this.lblDireccion01.Text = "Dir. 01:";
            this.lblDireccion01.UseCustomForeColor = true;
            // 
            // lblDireccion02
            // 
            this.lblDireccion02.AutoSize = true;
            this.lblDireccion02.ForeColor = System.Drawing.Color.Navy;
            this.lblDireccion02.Location = new System.Drawing.Point(6, 65);
            this.lblDireccion02.Name = "lblDireccion02";
            this.lblDireccion02.Size = new System.Drawing.Size(48, 19);
            this.lblDireccion02.TabIndex = 31;
            this.lblDireccion02.Text = "Dir. 02:";
            this.lblDireccion02.UseCustomForeColor = true;
            // 
            // txtLatitud
            // 
            this.txtLatitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtLatitud.CustomButton.Image = null;
            this.txtLatitud.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtLatitud.CustomButton.Name = "";
            this.txtLatitud.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLatitud.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLatitud.CustomButton.TabIndex = 1;
            this.txtLatitud.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLatitud.CustomButton.UseSelectable = true;
            this.txtLatitud.CustomButton.Visible = false;
            this.txtLatitud.Lines = new string[0];
            this.txtLatitud.Location = new System.Drawing.Point(269, 95);
            this.txtLatitud.MaxLength = 32767;
            this.txtLatitud.Name = "txtLatitud";
            this.txtLatitud.PasswordChar = '\0';
            this.txtLatitud.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLatitud.SelectedText = "";
            this.txtLatitud.SelectionLength = 0;
            this.txtLatitud.SelectionStart = 0;
            this.txtLatitud.ShortcutsEnabled = true;
            this.txtLatitud.Size = new System.Drawing.Size(93, 23);
            this.txtLatitud.TabIndex = 64;
            this.txtLatitud.UseCustomBackColor = true;
            this.txtLatitud.UseSelectable = true;
            this.txtLatitud.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLatitud.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLatitud.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtDireccion02
            // 
            this.txtDireccion02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDireccion02.CustomButton.Image = null;
            this.txtDireccion02.CustomButton.Location = new System.Drawing.Point(446, 1);
            this.txtDireccion02.CustomButton.Name = "";
            this.txtDireccion02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion02.CustomButton.TabIndex = 1;
            this.txtDireccion02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion02.CustomButton.UseSelectable = true;
            this.txtDireccion02.CustomButton.Visible = false;
            this.txtDireccion02.Lines = new string[0];
            this.txtDireccion02.Location = new System.Drawing.Point(80, 61);
            this.txtDireccion02.MaxLength = 32767;
            this.txtDireccion02.Name = "txtDireccion02";
            this.txtDireccion02.PasswordChar = '\0';
            this.txtDireccion02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion02.SelectedText = "";
            this.txtDireccion02.SelectionLength = 0;
            this.txtDireccion02.SelectionStart = 0;
            this.txtDireccion02.ShortcutsEnabled = true;
            this.txtDireccion02.Size = new System.Drawing.Size(468, 23);
            this.txtDireccion02.TabIndex = 32;
            this.txtDireccion02.UseCustomBackColor = true;
            this.txtDireccion02.UseSelectable = true;
            this.txtDireccion02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblLatitud
            // 
            this.lblLatitud.AutoSize = true;
            this.lblLatitud.ForeColor = System.Drawing.Color.Navy;
            this.lblLatitud.Location = new System.Drawing.Point(219, 97);
            this.lblLatitud.Name = "lblLatitud";
            this.lblLatitud.Size = new System.Drawing.Size(51, 19);
            this.lblLatitud.TabIndex = 63;
            this.lblLatitud.Text = "Latitud:";
            this.lblLatitud.UseCustomForeColor = true;
            // 
            // gbrUbigeo
            // 
            this.gbrUbigeo.BackColor = System.Drawing.Color.Transparent;
            this.gbrUbigeo.Controls.Add(this.lblDepartamento);
            this.gbrUbigeo.Controls.Add(this.cboDepartamento);
            this.gbrUbigeo.Controls.Add(this.cboDistrito);
            this.gbrUbigeo.Controls.Add(this.lblDistrito);
            this.gbrUbigeo.Controls.Add(this.lblProvincia);
            this.gbrUbigeo.Controls.Add(this.cboProvincia);
            this.gbrUbigeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbrUbigeo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrUbigeo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbrUbigeo.Location = new System.Drawing.Point(1, 10);
            this.gbrUbigeo.Name = "gbrUbigeo";
            this.gbrUbigeo.Size = new System.Drawing.Size(555, 93);
            this.gbrUbigeo.TabIndex = 57;
            this.gbrUbigeo.TabStop = false;
            this.gbrUbigeo.Text = "Ubicación general";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartamento.Location = new System.Drawing.Point(6, 26);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(53, 19);
            this.lblDepartamento.TabIndex = 32;
            this.lblDepartamento.Text = "Región:";
            this.lblDepartamento.UseCustomForeColor = true;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepartamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(62, 24);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(184, 23);
            this.cboDepartamento.TabIndex = 33;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // cboDistrito
            // 
            this.cboDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDistrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(62, 59);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(184, 23);
            this.cboDistrito.TabIndex = 37;
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.ForeColor = System.Drawing.Color.Navy;
            this.lblDistrito.Location = new System.Drawing.Point(6, 61);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(53, 19);
            this.lblDistrito.TabIndex = 36;
            this.lblDistrito.Text = "Distrito:";
            this.lblDistrito.UseCustomForeColor = true;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.ForeColor = System.Drawing.Color.Navy;
            this.lblProvincia.Location = new System.Drawing.Point(272, 26);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(65, 19);
            this.lblProvincia.TabIndex = 34;
            this.lblProvincia.Text = "Provincia:";
            this.lblProvincia.UseCustomForeColor = true;
            // 
            // cboProvincia
            // 
            this.cboProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProvincia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(364, 24);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(184, 23);
            this.cboProvincia.TabIndex = 35;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // tabPagInfoExtra
            // 
            this.tabPagInfoExtra.Controls.Add(this.grbInfoExtra);
            this.tabPagInfoExtra.HorizontalScrollbarBarColor = true;
            this.tabPagInfoExtra.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagInfoExtra.HorizontalScrollbarSize = 10;
            this.tabPagInfoExtra.Location = new System.Drawing.Point(4, 38);
            this.tabPagInfoExtra.Name = "tabPagInfoExtra";
            this.tabPagInfoExtra.Size = new System.Drawing.Size(559, 240);
            this.tabPagInfoExtra.TabIndex = 2;
            this.tabPagInfoExtra.Text = "Info. Extra";
            this.tabPagInfoExtra.VerticalScrollbarBarColor = true;
            this.tabPagInfoExtra.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagInfoExtra.VerticalScrollbarSize = 10;
            // 
            // grbInfoExtra
            // 
            this.grbInfoExtra.BackColor = System.Drawing.Color.Transparent;
            this.grbInfoExtra.Controls.Add(this.txtDato04);
            this.grbInfoExtra.Controls.Add(this.txtDato01);
            this.grbInfoExtra.Controls.Add(this.lblDato02);
            this.grbInfoExtra.Controls.Add(this.txtDato03);
            this.grbInfoExtra.Controls.Add(this.lblDato04);
            this.grbInfoExtra.Controls.Add(this.lblDato03);
            this.grbInfoExtra.Controls.Add(this.txtDato02);
            this.grbInfoExtra.Controls.Add(this.lblDato01);
            this.grbInfoExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbInfoExtra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoExtra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbInfoExtra.Location = new System.Drawing.Point(1, 6);
            this.grbInfoExtra.Name = "grbInfoExtra";
            this.grbInfoExtra.Size = new System.Drawing.Size(555, 99);
            this.grbInfoExtra.TabIndex = 2;
            this.grbInfoExtra.TabStop = false;
            this.grbInfoExtra.Text = "Agregue la información extra que necesite";
            // 
            // txtDato04
            // 
            this.txtDato04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDato04.CustomButton.Image = null;
            this.txtDato04.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtDato04.CustomButton.Name = "";
            this.txtDato04.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDato04.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDato04.CustomButton.TabIndex = 1;
            this.txtDato04.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDato04.CustomButton.UseSelectable = true;
            this.txtDato04.CustomButton.Visible = false;
            this.txtDato04.Lines = new string[0];
            this.txtDato04.Location = new System.Drawing.Point(362, 62);
            this.txtDato04.MaxLength = 32767;
            this.txtDato04.Name = "txtDato04";
            this.txtDato04.PasswordChar = '\0';
            this.txtDato04.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDato04.SelectedText = "";
            this.txtDato04.SelectionLength = 0;
            this.txtDato04.SelectionStart = 0;
            this.txtDato04.ShortcutsEnabled = true;
            this.txtDato04.Size = new System.Drawing.Size(184, 23);
            this.txtDato04.TabIndex = 28;
            this.txtDato04.UseCustomBackColor = true;
            this.txtDato04.UseSelectable = true;
            this.txtDato04.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDato04.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDato04.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtDato01
            // 
            this.txtDato01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDato01.CustomButton.Image = null;
            this.txtDato01.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtDato01.CustomButton.Name = "";
            this.txtDato01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDato01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDato01.CustomButton.TabIndex = 1;
            this.txtDato01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDato01.CustomButton.UseSelectable = true;
            this.txtDato01.CustomButton.Visible = false;
            this.txtDato01.Lines = new string[0];
            this.txtDato01.Location = new System.Drawing.Point(90, 26);
            this.txtDato01.MaxLength = 32767;
            this.txtDato01.Name = "txtDato01";
            this.txtDato01.PasswordChar = '\0';
            this.txtDato01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDato01.SelectedText = "";
            this.txtDato01.SelectionLength = 0;
            this.txtDato01.SelectionStart = 0;
            this.txtDato01.ShortcutsEnabled = true;
            this.txtDato01.Size = new System.Drawing.Size(184, 23);
            this.txtDato01.TabIndex = 22;
            this.txtDato01.UseCustomBackColor = true;
            this.txtDato01.UseSelectable = true;
            this.txtDato01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDato01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDato01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblDato02
            // 
            this.lblDato02.AutoSize = true;
            this.lblDato02.ForeColor = System.Drawing.Color.Navy;
            this.lblDato02.Location = new System.Drawing.Point(14, 64);
            this.lblDato02.Name = "lblDato02";
            this.lblDato02.Size = new System.Drawing.Size(55, 19);
            this.lblDato02.TabIndex = 23;
            this.lblDato02.Text = "Info. 02:";
            this.lblDato02.UseCustomForeColor = true;
            // 
            // txtDato03
            // 
            this.txtDato03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDato03.CustomButton.Image = null;
            this.txtDato03.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtDato03.CustomButton.Name = "";
            this.txtDato03.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDato03.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDato03.CustomButton.TabIndex = 1;
            this.txtDato03.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDato03.CustomButton.UseSelectable = true;
            this.txtDato03.CustomButton.Visible = false;
            this.txtDato03.Lines = new string[0];
            this.txtDato03.Location = new System.Drawing.Point(362, 24);
            this.txtDato03.MaxLength = 32767;
            this.txtDato03.Name = "txtDato03";
            this.txtDato03.PasswordChar = '\0';
            this.txtDato03.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDato03.SelectedText = "";
            this.txtDato03.SelectionLength = 0;
            this.txtDato03.SelectionStart = 0;
            this.txtDato03.ShortcutsEnabled = true;
            this.txtDato03.Size = new System.Drawing.Size(184, 23);
            this.txtDato03.TabIndex = 26;
            this.txtDato03.UseCustomBackColor = true;
            this.txtDato03.UseSelectable = true;
            this.txtDato03.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDato03.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDato03.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblDato04
            // 
            this.lblDato04.AutoSize = true;
            this.lblDato04.ForeColor = System.Drawing.Color.Navy;
            this.lblDato04.Location = new System.Drawing.Point(288, 64);
            this.lblDato04.Name = "lblDato04";
            this.lblDato04.Size = new System.Drawing.Size(55, 19);
            this.lblDato04.TabIndex = 27;
            this.lblDato04.Text = "Info. 04:";
            this.lblDato04.UseCustomForeColor = true;
            // 
            // lblDato03
            // 
            this.lblDato03.AutoSize = true;
            this.lblDato03.ForeColor = System.Drawing.Color.Navy;
            this.lblDato03.Location = new System.Drawing.Point(288, 26);
            this.lblDato03.Name = "lblDato03";
            this.lblDato03.Size = new System.Drawing.Size(55, 19);
            this.lblDato03.TabIndex = 25;
            this.lblDato03.Text = "Info. 03:";
            this.lblDato03.UseCustomForeColor = true;
            // 
            // txtDato02
            // 
            this.txtDato02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDato02.CustomButton.Image = null;
            this.txtDato02.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtDato02.CustomButton.Name = "";
            this.txtDato02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDato02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDato02.CustomButton.TabIndex = 1;
            this.txtDato02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDato02.CustomButton.UseSelectable = true;
            this.txtDato02.CustomButton.Visible = false;
            this.txtDato02.Lines = new string[0];
            this.txtDato02.Location = new System.Drawing.Point(90, 62);
            this.txtDato02.MaxLength = 32767;
            this.txtDato02.Name = "txtDato02";
            this.txtDato02.PasswordChar = '\0';
            this.txtDato02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDato02.SelectedText = "";
            this.txtDato02.SelectionLength = 0;
            this.txtDato02.SelectionStart = 0;
            this.txtDato02.ShortcutsEnabled = true;
            this.txtDato02.Size = new System.Drawing.Size(184, 23);
            this.txtDato02.TabIndex = 24;
            this.txtDato02.UseCustomBackColor = true;
            this.txtDato02.UseSelectable = true;
            this.txtDato02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDato02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDato02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblDato01
            // 
            this.lblDato01.AutoSize = true;
            this.lblDato01.ForeColor = System.Drawing.Color.Navy;
            this.lblDato01.Location = new System.Drawing.Point(14, 28);
            this.lblDato01.Name = "lblDato01";
            this.lblDato01.Size = new System.Drawing.Size(53, 19);
            this.lblDato01.TabIndex = 21;
            this.lblDato01.Text = "Info. 01:";
            this.lblDato01.UseCustomForeColor = true;
            // 
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(132, 104);
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
            this.lblListarInactivos.Location = new System.Drawing.Point(34, 104);
            this.lblListarInactivos.Name = "lblListarInactivos";
            this.lblListarInactivos.Size = new System.Drawing.Size(92, 19);
            this.lblListarInactivos.TabIndex = 4;
            this.lblListarInactivos.Text = "Listar inactivos";
            // 
            // dgvLocation
            // 
            this.dgvLocation.AllowUserToAddRows = false;
            this.dgvLocation.AllowUserToResizeColumns = false;
            this.dgvLocation.AllowUserToResizeRows = false;
            this.dgvLocation.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvLocation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLocation.Location = new System.Drawing.Point(33, 129);
            this.dgvLocation.MultiSelect = false;
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLocation.RowHeadersVisible = false;
            this.dgvLocation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvLocation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocation.Size = new System.Drawing.Size(230, 275);
            this.dgvLocation.TabIndex = 0;
            this.dgvLocation.SelectionChanged += new System.EventHandler(this.dgvLocation_SelectionChanged);
            this.dgvLocation.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvBordered_Paint);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // lblIdLocation
            // 
            this.lblIdLocation.AutoSize = true;
            this.lblIdLocation.ForeColor = System.Drawing.Color.Navy;
            this.lblIdLocation.Location = new System.Drawing.Point(535, 22);
            this.lblIdLocation.Name = "lblIdLocation";
            this.lblIdLocation.Size = new System.Drawing.Size(0, 0);
            this.lblIdLocation.TabIndex = 83;
            this.lblIdLocation.UseCustomForeColor = true;
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(178, 407);
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
            this.lblNumActivo.Location = new System.Drawing.Point(98, 407);
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
            this.lblNumReg.Location = new System.Drawing.Point(31, 407);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 114;
            this.lblNumReg.Text = "Total: ";
            // 
            // FormLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 452);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.lblIdLocation);
            this.Controls.Add(this.dgvLocation);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.tabLocation);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.MaximizeBox = false;
            this.Name = "FormLocation";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormLocation_Load);
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            this.tabLocation.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            this.tabPagDireccion.ResumeLayout(false);
            this.grbUbicacionDetallada.ResumeLayout(false);
            this.grbUbicacionDetallada.PerformLayout();
            this.gbrUbigeo.ResumeLayout(false);
            this.gbrUbigeo.PerformLayout();
            this.tabPagInfoExtra.ResumeLayout(false);
            this.grbInfoExtra.ResumeLayout(false);
            this.grbInfoExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
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
        private MetroFramework.Controls.MetroTabControl tabLocation;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lblRUC;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroLink btnTipoLocation;
        private MetroFramework.Controls.MetroTextBox txtDireccion01;
        private MetroFramework.Controls.MetroLabel lblDireccion01;
        private MetroFramework.Controls.MetroCheckBox chkLocationActual;
        private MetroFramework.Controls.MetroCheckBox chkAlmacen;
        private BorderedCombo cboTipoLocation;
        private MetroFramework.Controls.MetroLabel lblTipoLocation;
        private MetroFramework.Controls.MetroTextBox txtAbrev02;
        private MetroFramework.Controls.MetroLabel lblAbrev02;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtAbrev01;
        private MetroFramework.Controls.MetroLabel lblAbrev01;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private MetroFramework.Controls.MetroToggle tglListarInactivos;
        private MetroFramework.Controls.MetroLabel lblListarInactivos;
        private System.Windows.Forms.DataGridView dgvLocation;
        private MetroFramework.Controls.MetroTextBox txtNumRuc;
        private MetroFramework.Controls.MetroTextBox txtDato04;
        private MetroFramework.Controls.MetroLabel lblDato04;
        private MetroFramework.Controls.MetroTextBox txtDato02;
        private MetroFramework.Controls.MetroLabel lblDato02;
        private MetroFramework.Controls.MetroTextBox txtDato03;
        private MetroFramework.Controls.MetroLabel lblDato03;
        private MetroFramework.Controls.MetroTextBox txtDato01;
        private MetroFramework.Controls.MetroLabel lblDato01;
        private System.Windows.Forms.DateTimePicker dtpFechaNegocio;
        private MetroFramework.Controls.MetroLabel lblFechaNegocio;
        private MetroFramework.Controls.MetroTextBox txtFono02;
        private MetroFramework.Controls.MetroLabel lblFono02;
        private MetroFramework.Controls.MetroTextBox txtFono01;
        private MetroFramework.Controls.MetroLabel lblFono01;
        private MetroFramework.Controls.MetroTextBox txtDireccion02;
        private MetroFramework.Controls.MetroLabel lblDireccion02;
        private System.Windows.Forms.ErrorProvider errorProv;
        private MetroFramework.Controls.MetroLabel lblIdLocation;
        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private MetroFramework.Controls.MetroTextBox txtLongitud;
        private MetroFramework.Controls.MetroLabel lblLongitud;
        private MetroFramework.Controls.MetroTextBox txtLatitud;
        private MetroFramework.Controls.MetroLabel lblLatitud;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTabPage tabPagDireccion;
        private System.Windows.Forms.GroupBox gbrUbigeo;
        private MetroFramework.Controls.MetroLabel lblDepartamento;
        private BorderedCombo cboDepartamento;
        private BorderedCombo cboDistrito;
        private MetroFramework.Controls.MetroLabel lblDistrito;
        private MetroFramework.Controls.MetroLabel lblProvincia;
        private BorderedCombo cboProvincia;
        private System.Windows.Forms.GroupBox grbUbicacionDetallada;
        private MetroFramework.Controls.MetroTabPage tabPagInfoExtra;
        private System.Windows.Forms.GroupBox grbInfoExtra;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}