using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Maestro
{
    partial class FormImpuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImpuesto));
            this.dgvImpuesto = new System.Windows.Forms.DataGridView();
            this.panelFiltro = new MetroFramework.Controls.MetroPanel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.cboFiltro = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblFiltro = new MetroFramework.Controls.MetroLabel();
            this.panelMantenimiento = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tglListarInactivos = new MetroFramework.Controls.MetroToggle();
            this.lblListarInactivos = new MetroFramework.Controls.MetroLabel();
            this.tabImpuesto = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.lblPorcentajeAcumulado = new System.Windows.Forms.Label();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPorcentaje05 = new MetroFramework.Controls.MetroTextBox();
            this.txtPorcentaje08 = new MetroFramework.Controls.MetroTextBox();
            this.txtPorcentaje07 = new MetroFramework.Controls.MetroTextBox();
            this.txtPorcentaje06 = new MetroFramework.Controls.MetroTextBox();
            this.txtPorcentaje04 = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPorcentaje02 = new MetroFramework.Controls.MetroTextBox();
            this.txtPorcentaje03 = new MetroFramework.Controls.MetroTextBox();
            this.txtPorcentaje01 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblSimboloPorc04 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblSimboloPorc03 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblSimboloPorc02 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblSimboloPorc01 = new MetroFramework.Controls.MetroLabel();
            this.lblSimboloPorc08 = new MetroFramework.Controls.MetroLabel();
            this.lblSimboloPorc07 = new MetroFramework.Controls.MetroLabel();
            this.lblSimboloPorc06 = new MetroFramework.Controls.MetroLabel();
            this.lblSimboloPorc05 = new MetroFramework.Controls.MetroLabel();
            this.txtAbreviacion = new MetroFramework.Controls.MetroTextBox();
            this.lblAbreviacion = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.lblIdImpuesto = new MetroFramework.Controls.MetroLabel();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            this.tabImpuesto.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvImpuesto
            // 
            this.dgvImpuesto.AllowUserToAddRows = false;
            this.dgvImpuesto.AllowUserToResizeColumns = false;
            this.dgvImpuesto.AllowUserToResizeRows = false;
            this.dgvImpuesto.BackgroundColor = System.Drawing.Color.White;
            this.dgvImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvImpuesto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvImpuesto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvImpuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvImpuesto.Location = new System.Drawing.Point(42, 129);
            this.dgvImpuesto.MultiSelect = false;
            this.dgvImpuesto.Name = "dgvImpuesto";
            this.dgvImpuesto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvImpuesto.RowHeadersVisible = false;
            this.dgvImpuesto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvImpuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvImpuesto.Size = new System.Drawing.Size(227, 308);
            this.dgvImpuesto.TabIndex = 0;
            this.dgvImpuesto.SelectionChanged += new System.EventHandler(this.dgvImpuesto_SelectionChanged);
            // 
            // panelFiltro
            // 
            this.panelFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panelFiltro.Controls.Add(this.btnFilter);
            this.panelFiltro.Controls.Add(this.txtFiltro);
            this.panelFiltro.Controls.Add(this.cboFiltro);
            this.panelFiltro.Controls.Add(this.lblFiltro);
            this.panelFiltro.HorizontalScrollbarBarColor = true;
            this.panelFiltro.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFiltro.HorizontalScrollbarSize = 10;
            this.panelFiltro.Location = new System.Drawing.Point(305, 413);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(551, 44);
            this.panelFiltro.TabIndex = 3;
            this.panelFiltro.UseCustomBackColor = true;
            this.panelFiltro.VerticalScrollbarBarColor = true;
            this.panelFiltro.VerticalScrollbarHighlightOnWheel = false;
            this.panelFiltro.VerticalScrollbarSize = 10;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(510, 6);
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
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(191, 1);
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
            this.txtFiltro.Size = new System.Drawing.Size(213, 23);
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
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.ForeColor = System.Drawing.Color.Navy;
            this.lblFiltro.Location = new System.Drawing.Point(12, 13);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(76, 19);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Buscar por:";
            this.lblFiltro.UseCustomBackColor = true;
            this.lblFiltro.UseCustomForeColor = true;
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
            this.panelMantenimiento.Location = new System.Drawing.Point(305, 36);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(550, 49);
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
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(139, 104);
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
            this.lblListarInactivos.Location = new System.Drawing.Point(41, 104);
            this.lblListarInactivos.Name = "lblListarInactivos";
            this.lblListarInactivos.Size = new System.Drawing.Size(92, 19);
            this.lblListarInactivos.TabIndex = 4;
            this.lblListarInactivos.Text = "Listar inactivos";
            // 
            // tabImpuesto
            // 
            this.tabImpuesto.Controls.Add(this.tabPagGeneral);
            this.tabImpuesto.Location = new System.Drawing.Point(305, 91);
            this.tabImpuesto.Name = "tabImpuesto";
            this.tabImpuesto.SelectedIndex = 0;
            this.tabImpuesto.Size = new System.Drawing.Size(564, 316);
            this.tabImpuesto.TabIndex = 1;
            this.tabImpuesto.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.lblPorcentajeAcumulado);
            this.tabPagGeneral.Controls.Add(this.metroLabel17);
            this.tabPagGeneral.Controls.Add(this.panel1);
            this.tabPagGeneral.Controls.Add(this.txtAbreviacion);
            this.tabPagGeneral.Controls.Add(this.lblAbreviacion);
            this.tabPagGeneral.Controls.Add(this.panel2);
            this.tabPagGeneral.Controls.Add(this.panel3);
            this.tabPagGeneral.Controls.Add(this.chkActivo);
            this.tabPagGeneral.Controls.Add(this.txtCodigo);
            this.tabPagGeneral.Controls.Add(this.lblCodigo);
            this.tabPagGeneral.Controls.Add(this.txtNombre);
            this.tabPagGeneral.Controls.Add(this.lblNombre);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(556, 274);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // lblPorcentajeAcumulado
            // 
            this.lblPorcentajeAcumulado.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentajeAcumulado.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeAcumulado.ForeColor = System.Drawing.Color.Navy;
            this.lblPorcentajeAcumulado.Location = new System.Drawing.Point(355, 135);
            this.lblPorcentajeAcumulado.Name = "lblPorcentajeAcumulado";
            this.lblPorcentajeAcumulado.Size = new System.Drawing.Size(184, 90);
            this.lblPorcentajeAcumulado.TabIndex = 117;
            this.lblPorcentajeAcumulado.Text = "0 %";
            this.lblPorcentajeAcumulado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel17.Location = new System.Drawing.Point(376, 113);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(139, 19);
            this.metroLabel17.TabIndex = 116;
            this.metroLabel17.Text = "Porcentaje acumulado";
            this.metroLabel17.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPorcentaje05);
            this.panel1.Controls.Add(this.txtPorcentaje08);
            this.panel1.Controls.Add(this.txtPorcentaje07);
            this.panel1.Controls.Add(this.txtPorcentaje06);
            this.panel1.Controls.Add(this.txtPorcentaje04);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPorcentaje02);
            this.panel1.Controls.Add(this.txtPorcentaje03);
            this.panel1.Controls.Add(this.txtPorcentaje01);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.lblSimboloPorc04);
            this.panel1.Controls.Add(this.metroLabel7);
            this.panel1.Controls.Add(this.lblSimboloPorc03);
            this.panel1.Controls.Add(this.metroLabel8);
            this.panel1.Controls.Add(this.metroLabel2);
            this.panel1.Controls.Add(this.metroLabel9);
            this.panel1.Controls.Add(this.lblSimboloPorc02);
            this.panel1.Controls.Add(this.metroLabel10);
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.lblSimboloPorc01);
            this.panel1.Controls.Add(this.lblSimboloPorc08);
            this.panel1.Controls.Add(this.lblSimboloPorc07);
            this.panel1.Controls.Add(this.lblSimboloPorc06);
            this.panel1.Controls.Add(this.lblSimboloPorc05);
            this.panel1.Location = new System.Drawing.Point(3, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 116);
            this.panel1.TabIndex = 115;
            // 
            // txtPorcentaje05
            // 
            this.txtPorcentaje05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPorcentaje05.CustomButton.Image = null;
            this.txtPorcentaje05.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtPorcentaje05.CustomButton.Name = "";
            this.txtPorcentaje05.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentaje05.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentaje05.CustomButton.TabIndex = 1;
            this.txtPorcentaje05.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentaje05.CustomButton.UseSelectable = true;
            this.txtPorcentaje05.CustomButton.Visible = false;
            this.txtPorcentaje05.Lines = new string[0];
            this.txtPorcentaje05.Location = new System.Drawing.Point(226, 22);
            this.txtPorcentaje05.MaxLength = 32767;
            this.txtPorcentaje05.Name = "txtPorcentaje05";
            this.txtPorcentaje05.PasswordChar = '\0';
            this.txtPorcentaje05.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentaje05.SelectedText = "";
            this.txtPorcentaje05.SelectionLength = 0;
            this.txtPorcentaje05.SelectionStart = 0;
            this.txtPorcentaje05.ShortcutsEnabled = true;
            this.txtPorcentaje05.Size = new System.Drawing.Size(74, 23);
            this.txtPorcentaje05.TabIndex = 91;
            this.txtPorcentaje05.UseCustomBackColor = true;
            this.txtPorcentaje05.UseSelectable = true;
            this.txtPorcentaje05.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentaje05.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorcentaje05.TextChanged += new System.EventHandler(this.CambioEnControlYCalcularAcumulado);
            // 
            // txtPorcentaje08
            // 
            this.txtPorcentaje08.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPorcentaje08.CustomButton.Image = null;
            this.txtPorcentaje08.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtPorcentaje08.CustomButton.Name = "";
            this.txtPorcentaje08.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentaje08.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentaje08.CustomButton.TabIndex = 1;
            this.txtPorcentaje08.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentaje08.CustomButton.UseSelectable = true;
            this.txtPorcentaje08.CustomButton.Visible = false;
            this.txtPorcentaje08.Lines = new string[0];
            this.txtPorcentaje08.Location = new System.Drawing.Point(226, 91);
            this.txtPorcentaje08.MaxLength = 32767;
            this.txtPorcentaje08.Name = "txtPorcentaje08";
            this.txtPorcentaje08.PasswordChar = '\0';
            this.txtPorcentaje08.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentaje08.SelectedText = "";
            this.txtPorcentaje08.SelectionLength = 0;
            this.txtPorcentaje08.SelectionStart = 0;
            this.txtPorcentaje08.ShortcutsEnabled = true;
            this.txtPorcentaje08.Size = new System.Drawing.Size(74, 23);
            this.txtPorcentaje08.TabIndex = 94;
            this.txtPorcentaje08.UseCustomBackColor = true;
            this.txtPorcentaje08.UseSelectable = true;
            this.txtPorcentaje08.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentaje08.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorcentaje08.TextChanged += new System.EventHandler(this.CambioEnControlYCalcularAcumulado);
            // 
            // txtPorcentaje07
            // 
            this.txtPorcentaje07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPorcentaje07.CustomButton.Image = null;
            this.txtPorcentaje07.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtPorcentaje07.CustomButton.Name = "";
            this.txtPorcentaje07.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentaje07.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentaje07.CustomButton.TabIndex = 1;
            this.txtPorcentaje07.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentaje07.CustomButton.UseSelectable = true;
            this.txtPorcentaje07.CustomButton.Visible = false;
            this.txtPorcentaje07.Lines = new string[0];
            this.txtPorcentaje07.Location = new System.Drawing.Point(226, 68);
            this.txtPorcentaje07.MaxLength = 32767;
            this.txtPorcentaje07.Name = "txtPorcentaje07";
            this.txtPorcentaje07.PasswordChar = '\0';
            this.txtPorcentaje07.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentaje07.SelectedText = "";
            this.txtPorcentaje07.SelectionLength = 0;
            this.txtPorcentaje07.SelectionStart = 0;
            this.txtPorcentaje07.ShortcutsEnabled = true;
            this.txtPorcentaje07.Size = new System.Drawing.Size(74, 23);
            this.txtPorcentaje07.TabIndex = 93;
            this.txtPorcentaje07.UseCustomBackColor = true;
            this.txtPorcentaje07.UseSelectable = true;
            this.txtPorcentaje07.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentaje07.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorcentaje07.TextChanged += new System.EventHandler(this.CambioEnControlYCalcularAcumulado);
            // 
            // txtPorcentaje06
            // 
            this.txtPorcentaje06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPorcentaje06.CustomButton.Image = null;
            this.txtPorcentaje06.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtPorcentaje06.CustomButton.Name = "";
            this.txtPorcentaje06.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentaje06.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentaje06.CustomButton.TabIndex = 1;
            this.txtPorcentaje06.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentaje06.CustomButton.UseSelectable = true;
            this.txtPorcentaje06.CustomButton.Visible = false;
            this.txtPorcentaje06.Lines = new string[0];
            this.txtPorcentaje06.Location = new System.Drawing.Point(226, 45);
            this.txtPorcentaje06.MaxLength = 32767;
            this.txtPorcentaje06.Name = "txtPorcentaje06";
            this.txtPorcentaje06.PasswordChar = '\0';
            this.txtPorcentaje06.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentaje06.SelectedText = "";
            this.txtPorcentaje06.SelectionLength = 0;
            this.txtPorcentaje06.SelectionStart = 0;
            this.txtPorcentaje06.ShortcutsEnabled = true;
            this.txtPorcentaje06.Size = new System.Drawing.Size(74, 23);
            this.txtPorcentaje06.TabIndex = 92;
            this.txtPorcentaje06.UseCustomBackColor = true;
            this.txtPorcentaje06.UseSelectable = true;
            this.txtPorcentaje06.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentaje06.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorcentaje06.TextChanged += new System.EventHandler(this.CambioEnControlYCalcularAcumulado);
            // 
            // txtPorcentaje04
            // 
            this.txtPorcentaje04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPorcentaje04.CustomButton.Image = null;
            this.txtPorcentaje04.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtPorcentaje04.CustomButton.Name = "";
            this.txtPorcentaje04.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentaje04.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentaje04.CustomButton.TabIndex = 1;
            this.txtPorcentaje04.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentaje04.CustomButton.UseSelectable = true;
            this.txtPorcentaje04.CustomButton.Visible = false;
            this.txtPorcentaje04.Lines = new string[0];
            this.txtPorcentaje04.Location = new System.Drawing.Point(66, 91);
            this.txtPorcentaje04.MaxLength = 32767;
            this.txtPorcentaje04.Name = "txtPorcentaje04";
            this.txtPorcentaje04.PasswordChar = '\0';
            this.txtPorcentaje04.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentaje04.SelectedText = "";
            this.txtPorcentaje04.SelectionLength = 0;
            this.txtPorcentaje04.SelectionStart = 0;
            this.txtPorcentaje04.ShortcutsEnabled = true;
            this.txtPorcentaje04.Size = new System.Drawing.Size(74, 23);
            this.txtPorcentaje04.TabIndex = 89;
            this.txtPorcentaje04.UseCustomBackColor = true;
            this.txtPorcentaje04.UseSelectable = true;
            this.txtPorcentaje04.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentaje04.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorcentaje04.TextChanged += new System.EventHandler(this.CambioEnControlYCalcularAcumulado);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.label1.Size = new System.Drawing.Size(335, 23);
            this.label1.TabIndex = 106;
            this.label1.Text = "Tabla de Porcentajes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPorcentaje02
            // 
            this.txtPorcentaje02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPorcentaje02.CustomButton.Image = null;
            this.txtPorcentaje02.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtPorcentaje02.CustomButton.Name = "";
            this.txtPorcentaje02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentaje02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentaje02.CustomButton.TabIndex = 1;
            this.txtPorcentaje02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentaje02.CustomButton.UseSelectable = true;
            this.txtPorcentaje02.CustomButton.Visible = false;
            this.txtPorcentaje02.Lines = new string[0];
            this.txtPorcentaje02.Location = new System.Drawing.Point(66, 45);
            this.txtPorcentaje02.MaxLength = 32767;
            this.txtPorcentaje02.Name = "txtPorcentaje02";
            this.txtPorcentaje02.PasswordChar = '\0';
            this.txtPorcentaje02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentaje02.SelectedText = "";
            this.txtPorcentaje02.SelectionLength = 0;
            this.txtPorcentaje02.SelectionStart = 0;
            this.txtPorcentaje02.ShortcutsEnabled = true;
            this.txtPorcentaje02.Size = new System.Drawing.Size(74, 23);
            this.txtPorcentaje02.TabIndex = 87;
            this.txtPorcentaje02.UseCustomBackColor = true;
            this.txtPorcentaje02.UseSelectable = true;
            this.txtPorcentaje02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentaje02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorcentaje02.TextChanged += new System.EventHandler(this.CambioEnControlYCalcularAcumulado);
            // 
            // txtPorcentaje03
            // 
            this.txtPorcentaje03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPorcentaje03.CustomButton.Image = null;
            this.txtPorcentaje03.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtPorcentaje03.CustomButton.Name = "";
            this.txtPorcentaje03.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentaje03.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentaje03.CustomButton.TabIndex = 1;
            this.txtPorcentaje03.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentaje03.CustomButton.UseSelectable = true;
            this.txtPorcentaje03.CustomButton.Visible = false;
            this.txtPorcentaje03.Lines = new string[0];
            this.txtPorcentaje03.Location = new System.Drawing.Point(66, 68);
            this.txtPorcentaje03.MaxLength = 32767;
            this.txtPorcentaje03.Name = "txtPorcentaje03";
            this.txtPorcentaje03.PasswordChar = '\0';
            this.txtPorcentaje03.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentaje03.SelectedText = "";
            this.txtPorcentaje03.SelectionLength = 0;
            this.txtPorcentaje03.SelectionStart = 0;
            this.txtPorcentaje03.ShortcutsEnabled = true;
            this.txtPorcentaje03.Size = new System.Drawing.Size(74, 23);
            this.txtPorcentaje03.TabIndex = 88;
            this.txtPorcentaje03.UseCustomBackColor = true;
            this.txtPorcentaje03.UseSelectable = true;
            this.txtPorcentaje03.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentaje03.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorcentaje03.TextChanged += new System.EventHandler(this.CambioEnControlYCalcularAcumulado);
            // 
            // txtPorcentaje01
            // 
            this.txtPorcentaje01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPorcentaje01.CustomButton.Image = null;
            this.txtPorcentaje01.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtPorcentaje01.CustomButton.Name = "";
            this.txtPorcentaje01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPorcentaje01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPorcentaje01.CustomButton.TabIndex = 1;
            this.txtPorcentaje01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPorcentaje01.CustomButton.UseSelectable = true;
            this.txtPorcentaje01.CustomButton.Visible = false;
            this.txtPorcentaje01.Lines = new string[0];
            this.txtPorcentaje01.Location = new System.Drawing.Point(66, 22);
            this.txtPorcentaje01.MaxLength = 32767;
            this.txtPorcentaje01.Name = "txtPorcentaje01";
            this.txtPorcentaje01.PasswordChar = '\0';
            this.txtPorcentaje01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPorcentaje01.SelectedText = "";
            this.txtPorcentaje01.SelectionLength = 0;
            this.txtPorcentaje01.SelectionStart = 0;
            this.txtPorcentaje01.ShortcutsEnabled = true;
            this.txtPorcentaje01.Size = new System.Drawing.Size(74, 23);
            this.txtPorcentaje01.TabIndex = 7;
            this.txtPorcentaje01.UseCustomBackColor = true;
            this.txtPorcentaje01.UseSelectable = true;
            this.txtPorcentaje01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPorcentaje01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPorcentaje01.TextChanged += new System.EventHandler(this.CambioEnControlYCalcularAcumulado);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel4.Location = new System.Drawing.Point(10, 93);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(59, 19);
            this.metroLabel4.TabIndex = 99;
            this.metroLabel4.Text = "Porc. 04:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(10, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 96;
            this.metroLabel1.Text = "Porc. 01:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // lblSimboloPorc04
            // 
            this.lblSimboloPorc04.AutoSize = true;
            this.lblSimboloPorc04.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorc04.Location = new System.Drawing.Point(137, 94);
            this.lblSimboloPorc04.Margin = new System.Windows.Forms.Padding(0);
            this.lblSimboloPorc04.Name = "lblSimboloPorc04";
            this.lblSimboloPorc04.Size = new System.Drawing.Size(20, 19);
            this.lblSimboloPorc04.TabIndex = 110;
            this.lblSimboloPorc04.Text = "%";
            this.lblSimboloPorc04.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel7.Location = new System.Drawing.Point(168, 94);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 104;
            this.metroLabel7.Text = "Porc. 08:";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // lblSimboloPorc03
            // 
            this.lblSimboloPorc03.AutoSize = true;
            this.lblSimboloPorc03.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorc03.Location = new System.Drawing.Point(137, 70);
            this.lblSimboloPorc03.Margin = new System.Windows.Forms.Padding(0);
            this.lblSimboloPorc03.Name = "lblSimboloPorc03";
            this.lblSimboloPorc03.Size = new System.Drawing.Size(20, 19);
            this.lblSimboloPorc03.TabIndex = 109;
            this.lblSimboloPorc03.Text = "%";
            this.lblSimboloPorc03.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel8.Location = new System.Drawing.Point(168, 70);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(59, 19);
            this.metroLabel8.TabIndex = 103;
            this.metroLabel8.Text = "Porc. 07:";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(10, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 97;
            this.metroLabel2.Text = "Porc. 02:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel9.Location = new System.Drawing.Point(168, 47);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(59, 19);
            this.metroLabel9.TabIndex = 102;
            this.metroLabel9.Text = "Porc. 06:";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // lblSimboloPorc02
            // 
            this.lblSimboloPorc02.AutoSize = true;
            this.lblSimboloPorc02.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorc02.Location = new System.Drawing.Point(137, 47);
            this.lblSimboloPorc02.Margin = new System.Windows.Forms.Padding(0);
            this.lblSimboloPorc02.Name = "lblSimboloPorc02";
            this.lblSimboloPorc02.Size = new System.Drawing.Size(20, 19);
            this.lblSimboloPorc02.TabIndex = 108;
            this.lblSimboloPorc02.Text = "%";
            this.lblSimboloPorc02.UseCustomForeColor = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel10.Location = new System.Drawing.Point(168, 24);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 19);
            this.metroLabel10.TabIndex = 101;
            this.metroLabel10.Text = "Porc. 05:";
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(10, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 98;
            this.metroLabel3.Text = "Porc. 03:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // lblSimboloPorc01
            // 
            this.lblSimboloPorc01.AutoSize = true;
            this.lblSimboloPorc01.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorc01.Location = new System.Drawing.Point(137, 24);
            this.lblSimboloPorc01.Margin = new System.Windows.Forms.Padding(0);
            this.lblSimboloPorc01.Name = "lblSimboloPorc01";
            this.lblSimboloPorc01.Size = new System.Drawing.Size(20, 19);
            this.lblSimboloPorc01.TabIndex = 107;
            this.lblSimboloPorc01.Text = "%";
            this.lblSimboloPorc01.UseCustomForeColor = true;
            // 
            // lblSimboloPorc08
            // 
            this.lblSimboloPorc08.AutoSize = true;
            this.lblSimboloPorc08.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorc08.Location = new System.Drawing.Point(297, 94);
            this.lblSimboloPorc08.Margin = new System.Windows.Forms.Padding(0);
            this.lblSimboloPorc08.Name = "lblSimboloPorc08";
            this.lblSimboloPorc08.Size = new System.Drawing.Size(20, 19);
            this.lblSimboloPorc08.TabIndex = 114;
            this.lblSimboloPorc08.Text = "%";
            this.lblSimboloPorc08.UseCustomForeColor = true;
            // 
            // lblSimboloPorc07
            // 
            this.lblSimboloPorc07.AutoSize = true;
            this.lblSimboloPorc07.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorc07.Location = new System.Drawing.Point(297, 72);
            this.lblSimboloPorc07.Margin = new System.Windows.Forms.Padding(0);
            this.lblSimboloPorc07.Name = "lblSimboloPorc07";
            this.lblSimboloPorc07.Size = new System.Drawing.Size(20, 19);
            this.lblSimboloPorc07.TabIndex = 113;
            this.lblSimboloPorc07.Text = "%";
            this.lblSimboloPorc07.UseCustomForeColor = true;
            // 
            // lblSimboloPorc06
            // 
            this.lblSimboloPorc06.AutoSize = true;
            this.lblSimboloPorc06.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorc06.Location = new System.Drawing.Point(297, 49);
            this.lblSimboloPorc06.Margin = new System.Windows.Forms.Padding(0);
            this.lblSimboloPorc06.Name = "lblSimboloPorc06";
            this.lblSimboloPorc06.Size = new System.Drawing.Size(20, 19);
            this.lblSimboloPorc06.TabIndex = 112;
            this.lblSimboloPorc06.Text = "%";
            this.lblSimboloPorc06.UseCustomForeColor = true;
            // 
            // lblSimboloPorc05
            // 
            this.lblSimboloPorc05.AutoSize = true;
            this.lblSimboloPorc05.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorc05.Location = new System.Drawing.Point(297, 24);
            this.lblSimboloPorc05.Margin = new System.Windows.Forms.Padding(0);
            this.lblSimboloPorc05.Name = "lblSimboloPorc05";
            this.lblSimboloPorc05.Size = new System.Drawing.Size(20, 19);
            this.lblSimboloPorc05.TabIndex = 111;
            this.lblSimboloPorc05.Text = "%";
            this.lblSimboloPorc05.UseCustomForeColor = true;
            // 
            // txtAbreviacion
            // 
            this.txtAbreviacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtAbreviacion.CustomButton.Image = null;
            this.txtAbreviacion.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtAbreviacion.CustomButton.Name = "";
            this.txtAbreviacion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAbreviacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAbreviacion.CustomButton.TabIndex = 1;
            this.txtAbreviacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAbreviacion.CustomButton.UseSelectable = true;
            this.txtAbreviacion.CustomButton.Visible = false;
            this.txtAbreviacion.Lines = new string[0];
            this.txtAbreviacion.Location = new System.Drawing.Point(84, 51);
            this.txtAbreviacion.MaxLength = 32767;
            this.txtAbreviacion.Name = "txtAbreviacion";
            this.txtAbreviacion.PasswordChar = '\0';
            this.txtAbreviacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAbreviacion.SelectedText = "";
            this.txtAbreviacion.SelectionLength = 0;
            this.txtAbreviacion.SelectionStart = 0;
            this.txtAbreviacion.ShortcutsEnabled = true;
            this.txtAbreviacion.Size = new System.Drawing.Size(184, 23);
            this.txtAbreviacion.TabIndex = 3;
            this.txtAbreviacion.UseCustomBackColor = true;
            this.txtAbreviacion.UseSelectable = true;
            this.txtAbreviacion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAbreviacion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAbreviacion.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblAbreviacion
            // 
            this.lblAbreviacion.AutoSize = true;
            this.lblAbreviacion.ForeColor = System.Drawing.Color.Navy;
            this.lblAbreviacion.Location = new System.Drawing.Point(3, 53);
            this.lblAbreviacion.Name = "lblAbreviacion";
            this.lblAbreviacion.Size = new System.Drawing.Size(81, 19);
            this.lblAbreviacion.TabIndex = 2;
            this.lblAbreviacion.Text = "Abreviación:";
            this.lblAbreviacion.UseCustomForeColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 241);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 5);
            this.panel2.TabIndex = 86;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(3, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 5);
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
            this.chkActivo.Location = new System.Drawing.Point(6, 255);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 8;
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
            this.txtCodigo.Location = new System.Drawing.Point(355, 14);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(184, 23);
            this.txtCodigo.TabIndex = 5;
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
            this.lblCodigo.Location = new System.Drawing.Point(293, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 19);
            this.lblCodigo.TabIndex = 4;
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
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(84, 14);
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
            this.lblNombre.Location = new System.Drawing.Point(1, 18);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseCustomForeColor = true;
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(122, 32);
            this.lblNombreForm.TabIndex = 96;
            this.lblNombreForm.Text = "Impuestos";
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
            // lblIdImpuesto
            // 
            this.lblIdImpuesto.AutoSize = true;
            this.lblIdImpuesto.Location = new System.Drawing.Point(519, 28);
            this.lblIdImpuesto.Name = "lblIdImpuesto";
            this.lblIdImpuesto.Size = new System.Drawing.Size(0, 0);
            this.lblIdImpuesto.TabIndex = 89;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(186, 440);
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
            this.lblNumActivo.Location = new System.Drawing.Point(106, 440);
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
            this.lblNumReg.Location = new System.Drawing.Point(38, 440);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 114;
            this.lblNumReg.Text = "Total: ";
            // 
            // FormImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(900, 486);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.lblIdImpuesto);
            this.Controls.Add(this.dgvImpuesto);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.Controls.Add(this.tabImpuesto);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.MaximizeBox = false;
            this.Name = "FormImpuesto";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormImpuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImpuesto)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            this.tabImpuesto.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImpuesto;
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
        private MetroFramework.Controls.MetroTabControl tabImpuesto;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje01;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private MetroFramework.Controls.MetroLabel lblIdImpuesto;
        private System.Windows.Forms.ErrorProvider errorProv;
        private MetroFramework.Controls.MetroTextBox txtAbreviacion;
        private MetroFramework.Controls.MetroLabel lblAbreviacion;
        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje08;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje07;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje06;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje05;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje04;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje03;
        private MetroFramework.Controls.MetroTextBox txtPorcentaje02;
        private System.Windows.Forms.Label lblPorcentajeAcumulado;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lblSimboloPorc08;
        private MetroFramework.Controls.MetroLabel lblSimboloPorc07;
        private MetroFramework.Controls.MetroLabel lblSimboloPorc06;
        private MetroFramework.Controls.MetroLabel lblSimboloPorc05;
        private MetroFramework.Controls.MetroLabel lblSimboloPorc04;
        private MetroFramework.Controls.MetroLabel lblSimboloPorc03;
        private MetroFramework.Controls.MetroLabel lblSimboloPorc02;
        private MetroFramework.Controls.MetroLabel lblSimboloPorc01;
    }
}