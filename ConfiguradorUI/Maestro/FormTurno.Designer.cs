namespace ConfiguradorUI.Maestro
{
    partial class FormTurno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTurno));
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.lblIdTurno = new MetroFramework.Controls.MetroLabel();
            this.dgvTurno = new System.Windows.Forms.DataGridView();
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
            this.tabTurno = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.txtAbreviacion = new MetroFramework.Controls.MetroTextBox();
            this.lblAbreviacion = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboHoraEntradaHH = new System.Windows.Forms.ComboBox();
            this.cboHoraEntradaMM = new System.Windows.Forms.ComboBox();
            this.cboHoraEntradaTT = new System.Windows.Forms.ComboBox();
            this.cboHoraSalidaTT = new System.Windows.Forms.ComboBox();
            this.cboHoraSalidaMM = new System.Windows.Forms.ComboBox();
            this.cboHoraSalidaHH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            this.tabTurno.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(186, 394);
            this.lblNumInactivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumInactivo.Name = "lblNumInactivo";
            this.lblNumInactivo.Size = new System.Drawing.Size(65, 17);
            this.lblNumInactivo.TabIndex = 128;
            this.lblNumInactivo.Text = "Inactivos: ";
            // 
            // lblNumActivo
            // 
            this.lblNumActivo.AutoSize = true;
            this.lblNumActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumActivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActivo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNumActivo.Location = new System.Drawing.Point(106, 394);
            this.lblNumActivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumActivo.Name = "lblNumActivo";
            this.lblNumActivo.Size = new System.Drawing.Size(56, 17);
            this.lblNumActivo.TabIndex = 127;
            this.lblNumActivo.Text = "Activos: ";
            // 
            // lblNumReg
            // 
            this.lblNumReg.AutoSize = true;
            this.lblNumReg.BackColor = System.Drawing.Color.Transparent;
            this.lblNumReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumReg.Location = new System.Drawing.Point(39, 394);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 126;
            this.lblNumReg.Text = "Total: ";
            // 
            // lblIdTurno
            // 
            this.lblIdTurno.AutoSize = true;
            this.lblIdTurno.Location = new System.Drawing.Point(580, 33);
            this.lblIdTurno.Name = "lblIdTurno";
            this.lblIdTurno.Size = new System.Drawing.Size(0, 0);
            this.lblIdTurno.TabIndex = 125;
            // 
            // dgvTurno
            // 
            this.dgvTurno.AllowUserToAddRows = false;
            this.dgvTurno.AllowUserToResizeColumns = false;
            this.dgvTurno.AllowUserToResizeRows = false;
            this.dgvTurno.BackgroundColor = System.Drawing.Color.White;
            this.dgvTurno.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTurno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTurno.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTurno.Location = new System.Drawing.Point(42, 143);
            this.dgvTurno.MultiSelect = false;
            this.dgvTurno.Name = "dgvTurno";
            this.dgvTurno.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTurno.RowHeadersVisible = false;
            this.dgvTurno.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTurno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurno.Size = new System.Drawing.Size(227, 248);
            this.dgvTurno.TabIndex = 117;
            this.dgvTurno.SelectionChanged += new System.EventHandler(this.dgvTurno_SelectionChanged);
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
            this.panelFiltro.Location = new System.Drawing.Point(314, 362);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(547, 49);
            this.panelFiltro.TabIndex = 120;
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
            this.lblFiltro.Location = new System.Drawing.Point(13, 16);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(56, 19);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Criterio:";
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
            this.btnFilter.Location = new System.Drawing.Point(502, 9);
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
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(291, 14);
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
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(84, 14);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(183, 23);
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
            this.panelMantenimiento.Location = new System.Drawing.Point(314, 52);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(547, 49);
            this.panelMantenimiento.Style = MetroFramework.MetroColorStyle.Green;
            this.panelMantenimiento.TabIndex = 119;
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
            this.btnNuevo.Location = new System.Drawing.Point(376, 5);
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
            this.btnRollback.Location = new System.Drawing.Point(502, 5);
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
            this.btnCommit.Location = new System.Drawing.Point(460, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(418, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(140, 123);
            this.tglListarInactivos.Name = "tglListarInactivos";
            this.tglListarInactivos.Size = new System.Drawing.Size(80, 17);
            this.tglListarInactivos.TabIndex = 123;
            this.tglListarInactivos.Text = "Off";
            this.tglListarInactivos.UseSelectable = true;
            this.tglListarInactivos.Click += new System.EventHandler(this.tglListarInactivos_Click);
            // 
            // lblListarInactivos
            // 
            this.lblListarInactivos.AutoSize = true;
            this.lblListarInactivos.Location = new System.Drawing.Point(42, 121);
            this.lblListarInactivos.Name = "lblListarInactivos";
            this.lblListarInactivos.Size = new System.Drawing.Size(92, 19);
            this.lblListarInactivos.TabIndex = 122;
            this.lblListarInactivos.Text = "Listar inactivos";
            // 
            // tabTurno
            // 
            this.tabTurno.Controls.Add(this.tabPagGeneral);
            this.tabTurno.Location = new System.Drawing.Point(314, 108);
            this.tabTurno.Name = "tabTurno";
            this.tabTurno.SelectedIndex = 0;
            this.tabTurno.Size = new System.Drawing.Size(554, 248);
            this.tabTurno.TabIndex = 118;
            this.tabTurno.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.cboHoraSalidaTT);
            this.tabPagGeneral.Controls.Add(this.cboHoraSalidaMM);
            this.tabPagGeneral.Controls.Add(this.cboHoraSalidaHH);
            this.tabPagGeneral.Controls.Add(this.cboHoraEntradaTT);
            this.tabPagGeneral.Controls.Add(this.cboHoraEntradaMM);
            this.tabPagGeneral.Controls.Add(this.cboHoraEntradaHH);
            this.tabPagGeneral.Controls.Add(this.metroLabel2);
            this.tabPagGeneral.Controls.Add(this.metroLabel1);
            this.tabPagGeneral.Controls.Add(this.panel1);
            this.tabPagGeneral.Controls.Add(this.txtAbreviacion);
            this.tabPagGeneral.Controls.Add(this.lblAbreviacion);
            this.tabPagGeneral.Controls.Add(this.panel2);
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
            this.tabPagGeneral.Size = new System.Drawing.Size(546, 206);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
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
            this.txtAbreviacion.Location = new System.Drawing.Point(82, 52);
            this.txtAbreviacion.MaxLength = 32767;
            this.txtAbreviacion.Name = "txtAbreviacion";
            this.txtAbreviacion.PasswordChar = '\0';
            this.txtAbreviacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAbreviacion.SelectedText = "";
            this.txtAbreviacion.SelectionLength = 0;
            this.txtAbreviacion.SelectionStart = 0;
            this.txtAbreviacion.ShortcutsEnabled = true;
            this.txtAbreviacion.Size = new System.Drawing.Size(184, 23);
            this.txtAbreviacion.TabIndex = 5;
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
            this.lblAbreviacion.Location = new System.Drawing.Point(3, 54);
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
            this.panel2.Location = new System.Drawing.Point(4, 89);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 8);
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
            this.chkActivo.Location = new System.Drawing.Point(7, 186);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 6;
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
            this.txtCodigo.Location = new System.Drawing.Point(343, 14);
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
            this.lblCodigo.Location = new System.Drawing.Point(286, 16);
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
            this.txtNombre.Location = new System.Drawing.Point(79, 14);
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
            this.lblNombre.Location = new System.Drawing.Point(3, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseCustomForeColor = true;
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(92, 50);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(107, 45);
            this.lblNombreForm.TabIndex = 121;
            this.lblNombreForm.Text = "Turnos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(32, 44);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 124;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(5, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 8);
            this.panel1.TabIndex = 87;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(96, 100);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 88;
            this.metroLabel1.Text = "Hora Entrada";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(358, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(88, 19);
            this.metroLabel2.TabIndex = 89;
            this.metroLabel2.Text = "Hora Salida";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // cboHoraEntradaHH
            // 
            this.cboHoraEntradaHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboHoraEntradaHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraEntradaHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHoraEntradaHH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraEntradaHH.FormattingEnabled = true;
            this.cboHoraEntradaHH.Location = new System.Drawing.Point(74, 124);
            this.cboHoraEntradaHH.Name = "cboHoraEntradaHH";
            this.cboHoraEntradaHH.Size = new System.Drawing.Size(50, 29);
            this.cboHoraEntradaHH.TabIndex = 90;
            this.cboHoraEntradaHH.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboHoraEntradaMM
            // 
            this.cboHoraEntradaMM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboHoraEntradaMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraEntradaMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHoraEntradaMM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraEntradaMM.FormattingEnabled = true;
            this.cboHoraEntradaMM.Location = new System.Drawing.Point(126, 124);
            this.cboHoraEntradaMM.Name = "cboHoraEntradaMM";
            this.cboHoraEntradaMM.Size = new System.Drawing.Size(50, 29);
            this.cboHoraEntradaMM.TabIndex = 91;
            this.cboHoraEntradaMM.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboHoraEntradaTT
            // 
            this.cboHoraEntradaTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboHoraEntradaTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraEntradaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHoraEntradaTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraEntradaTT.FormattingEnabled = true;
            this.cboHoraEntradaTT.Location = new System.Drawing.Point(179, 124);
            this.cboHoraEntradaTT.Name = "cboHoraEntradaTT";
            this.cboHoraEntradaTT.Size = new System.Drawing.Size(55, 29);
            this.cboHoraEntradaTT.TabIndex = 92;
            this.cboHoraEntradaTT.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboHoraSalidaTT
            // 
            this.cboHoraSalidaTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboHoraSalidaTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraSalidaTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHoraSalidaTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraSalidaTT.FormattingEnabled = true;
            this.cboHoraSalidaTT.Location = new System.Drawing.Point(432, 124);
            this.cboHoraSalidaTT.Name = "cboHoraSalidaTT";
            this.cboHoraSalidaTT.Size = new System.Drawing.Size(55, 29);
            this.cboHoraSalidaTT.TabIndex = 95;
            this.cboHoraSalidaTT.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboHoraSalidaMM
            // 
            this.cboHoraSalidaMM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboHoraSalidaMM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraSalidaMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHoraSalidaMM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraSalidaMM.FormattingEnabled = true;
            this.cboHoraSalidaMM.Location = new System.Drawing.Point(380, 124);
            this.cboHoraSalidaMM.Name = "cboHoraSalidaMM";
            this.cboHoraSalidaMM.Size = new System.Drawing.Size(50, 29);
            this.cboHoraSalidaMM.TabIndex = 94;
            this.cboHoraSalidaMM.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboHoraSalidaHH
            // 
            this.cboHoraSalidaHH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboHoraSalidaHH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHoraSalidaHH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHoraSalidaHH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHoraSalidaHH.FormattingEnabled = true;
            this.cboHoraSalidaHH.Location = new System.Drawing.Point(328, 124);
            this.cboHoraSalidaHH.Name = "cboHoraSalidaHH";
            this.cboHoraSalidaHH.Size = new System.Drawing.Size(50, 29);
            this.cboHoraSalidaHH.TabIndex = 93;
            this.cboHoraSalidaHH.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // FormTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 451);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.lblIdTurno);
            this.Controls.Add(this.dgvTurno);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.Controls.Add(this.tabTurno);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormTurno";
            this.Load += new System.EventHandler(this.FormTurno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            this.tabTurno.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private MetroFramework.Controls.MetroLabel lblIdTurno;
        private System.Windows.Forms.DataGridView dgvTurno;
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
        private MetroFramework.Controls.MetroTabControl tabTurno;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroTextBox txtAbreviacion;
        private MetroFramework.Controls.MetroLabel lblAbreviacion;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.ErrorProvider errorProv;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboHoraSalidaTT;
        private System.Windows.Forms.ComboBox cboHoraSalidaMM;
        private System.Windows.Forms.ComboBox cboHoraSalidaHH;
        private System.Windows.Forms.ComboBox cboHoraEntradaTT;
        private System.Windows.Forms.ComboBox cboHoraEntradaMM;
        private System.Windows.Forms.ComboBox cboHoraEntradaHH;
    }
}