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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCombo));
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.dgvModelo = new System.Windows.Forms.DataGridView();
            this.lblIdModelo = new MetroFramework.Controls.MetroLabel();
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
            this.tabModelo = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMarca = new MetroFramework.Controls.MetroLink();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.lblMarca = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCodBarra = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).BeginInit();
            this.panelFiltro.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            this.tabModelo.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(177, 559);
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
            this.lblNumActivo.Location = new System.Drawing.Point(97, 559);
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
            this.lblNumReg.Location = new System.Drawing.Point(30, 559);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 126;
            this.lblNumReg.Text = "Total: ";
            // 
            // dgvModelo
            // 
            this.dgvModelo.AllowUserToAddRows = false;
            this.dgvModelo.AllowUserToResizeColumns = false;
            this.dgvModelo.AllowUserToResizeRows = false;
            this.dgvModelo.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModelo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvModelo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvModelo.Location = new System.Drawing.Point(39, 147);
            this.dgvModelo.MultiSelect = false;
            this.dgvModelo.Name = "dgvModelo";
            this.dgvModelo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvModelo.RowHeadersVisible = false;
            this.dgvModelo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModelo.Size = new System.Drawing.Size(222, 409);
            this.dgvModelo.TabIndex = 117;
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Location = new System.Drawing.Point(551, 30);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.Size = new System.Drawing.Size(0, 0);
            this.lblIdModelo.TabIndex = 125;
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
            this.panelFiltro.Location = new System.Drawing.Point(311, 532);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(544, 44);
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
            this.lblFiltro.Location = new System.Drawing.Point(13, 13);
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
            this.btnFilter.Location = new System.Drawing.Point(499, 6);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(37, 30);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.UseVisualStyleBackColor = false;
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
            this.panelMantenimiento.Location = new System.Drawing.Point(311, 53);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(544, 49);
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
            // 
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(137, 127);
            this.tglListarInactivos.Name = "tglListarInactivos";
            this.tglListarInactivos.Size = new System.Drawing.Size(80, 17);
            this.tglListarInactivos.TabIndex = 122;
            this.tglListarInactivos.Text = "Off";
            this.tglListarInactivos.UseSelectable = true;
            // 
            // lblListarInactivos
            // 
            this.lblListarInactivos.AutoSize = true;
            this.lblListarInactivos.Location = new System.Drawing.Point(39, 125);
            this.lblListarInactivos.Name = "lblListarInactivos";
            this.lblListarInactivos.Size = new System.Drawing.Size(92, 19);
            this.lblListarInactivos.TabIndex = 121;
            this.lblListarInactivos.Text = "Listar inactivos";
            // 
            // tabModelo
            // 
            this.tabModelo.Controls.Add(this.tabPagGeneral);
            this.tabModelo.Location = new System.Drawing.Point(311, 109);
            this.tabModelo.Name = "tabModelo";
            this.tabModelo.SelectedIndex = 0;
            this.tabModelo.Size = new System.Drawing.Size(562, 417);
            this.tabModelo.TabIndex = 118;
            this.tabModelo.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.button1);
            this.tabPagGeneral.Controls.Add(this.metroTextBox5);
            this.tabPagGeneral.Controls.Add(this.button2);
            this.tabPagGeneral.Controls.Add(this.metroLabel6);
            this.tabPagGeneral.Controls.Add(this.metroTextBox4);
            this.tabPagGeneral.Controls.Add(this.metroLabel5);
            this.tabPagGeneral.Controls.Add(this.metroTextBox3);
            this.tabPagGeneral.Controls.Add(this.metroLabel4);
            this.tabPagGeneral.Controls.Add(this.metroTextBox2);
            this.tabPagGeneral.Controls.Add(this.metroLabel3);
            this.tabPagGeneral.Controls.Add(this.metroTextBox1);
            this.tabPagGeneral.Controls.Add(this.metroLabel2);
            this.tabPagGeneral.Controls.Add(this.metroLabel1);
            this.tabPagGeneral.Controls.Add(this.dataGridView1);
            this.tabPagGeneral.Controls.Add(this.panel2);
            this.tabPagGeneral.Controls.Add(this.btnMarca);
            this.tabPagGeneral.Controls.Add(this.cboMarca);
            this.tabPagGeneral.Controls.Add(this.chkActivo);
            this.tabPagGeneral.Controls.Add(this.lblMarca);
            this.tabPagGeneral.Controls.Add(this.txtCodigo);
            this.tabPagGeneral.Controls.Add(this.lblCodBarra);
            this.tabPagGeneral.Controls.Add(this.txtNombre);
            this.tabPagGeneral.Controls.Add(this.lblNombre);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(554, 375);
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
            this.panel2.Location = new System.Drawing.Point(111, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 8);
            this.panel2.TabIndex = 86;
            // 
            // btnMarca
            // 
            this.btnMarca.Image = ((System.Drawing.Image)(resources.GetObject("btnMarca.Image")));
            this.btnMarca.ImageSize = 24;
            this.btnMarca.Location = new System.Drawing.Point(239, 45);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(29, 27);
            this.btnMarca.TabIndex = 59;
            this.btnMarca.UseSelectable = true;
            // 
            // cboMarca
            // 
            this.cboMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMarca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(77, 49);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(159, 23);
            this.cboMarca.TabIndex = 5;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkActivo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkActivo.ForeColor = System.Drawing.Color.Navy;
            this.chkActivo.Location = new System.Drawing.Point(348, 51);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 6;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseCustomForeColor = true;
            this.chkActivo.UseSelectable = true;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.ForeColor = System.Drawing.Color.Navy;
            this.lblMarca.Location = new System.Drawing.Point(1, 51);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(49, 19);
            this.lblMarca.TabIndex = 4;
            this.lblMarca.Text = "Grupo:";
            this.lblMarca.UseCustomForeColor = true;
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
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.UseCustomBackColor = true;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblCodBarra
            // 
            this.lblCodBarra.AutoSize = true;
            this.lblCodBarra.ForeColor = System.Drawing.Color.Navy;
            this.lblCodBarra.Location = new System.Drawing.Point(283, 16);
            this.lblCodBarra.Name = "lblCodBarra";
            this.lblCodBarra.Size = new System.Drawing.Size(56, 19);
            this.lblCodBarra.TabIndex = 2;
            this.lblCodBarra.Text = "Código:";
            this.lblCodBarra.UseCustomForeColor = true;
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
            this.txtNombre.TabIndex = 1;
            this.txtNombre.UseCustomBackColor = true;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(89, 51);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(132, 45);
            this.lblNombreForm.TabIndex = 124;
            this.lblNombreForm.Text = "Combos";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(27, 45);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 123;
            this.btnCerrar.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 167);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(533, 173);
            this.dataGridView1.TabIndex = 129;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(0, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 130;
            this.metroLabel1.Text = "Combo detalle";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(3, 132);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(184, 23);
            this.metroTextBox1.TabIndex = 132;
            this.metroTextBox1.UseCustomBackColor = true;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(1, 110);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 131;
            this.metroLabel2.Text = "Producto";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(450, 349);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(82, 23);
            this.metroTextBox2.TabIndex = 134;
            this.metroTextBox2.UseCustomBackColor = true;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(356, 351);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 133;
            this.metroLabel3.Text = "Total con IGV:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(60, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(268, 349);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(82, 23);
            this.metroTextBox3.TabIndex = 136;
            this.metroTextBox3.UseCustomBackColor = true;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel4.Location = new System.Drawing.Point(174, 351);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 135;
            this.metroLabel4.Text = "Total sin IGV:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroTextBox4
            // 
            this.metroTextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(193, 132);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(111, 23);
            this.metroTextBox4.TabIndex = 138;
            this.metroTextBox4.UseCustomBackColor = true;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel5.Location = new System.Drawing.Point(193, 110);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 137;
            this.metroLabel5.Text = "Cantidad";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroTextBox5
            // 
            this.metroTextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(77, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(310, 132);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(111, 23);
            this.metroTextBox5.TabIndex = 140;
            this.metroTextBox5.UseCustomBackColor = true;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel6.Location = new System.Drawing.Point(310, 110);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 19);
            this.metroLabel6.TabIndex = 139;
            this.metroLabel6.Text = "Precio x und";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(445, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 23);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(491, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 23);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FormCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 607);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.dgvModelo);
            this.Controls.Add(this.lblIdModelo);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.Controls.Add(this.tabModelo);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormCombo";
            this.Load += new System.EventHandler(this.FormCombo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).EndInit();
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            this.tabModelo.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private System.Windows.Forms.DataGridView dgvModelo;
        private MetroFramework.Controls.MetroLabel lblIdModelo;
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
        private MetroFramework.Controls.MetroTabControl tabModelo;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLink btnMarca;
        private System.Windows.Forms.ComboBox cboMarca;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroLabel lblMarca;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblCodBarra;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}