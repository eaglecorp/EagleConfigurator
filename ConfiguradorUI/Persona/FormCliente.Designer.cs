using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Persona
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.tglListarInactivos = new MetroFramework.Controls.MetroToggle();
            this.lblListarInactivos = new MetroFramework.Controls.MetroLabel();
            this.panelFiltro = new MetroFramework.Controls.MetroPanel();
            this.lblFiltro = new MetroFramework.Controls.MetroLabel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.cboFiltro = new ConfigUtilitarios.Controls.BorderedCombo();
            this.tabCliente = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.txtNumRuc = new MetroFramework.Controls.MetroTextBox();
            this.lblNumRuc = new MetroFramework.Controls.MetroLabel();
            this.txtNumDoc = new MetroFramework.Controls.MetroTextBox();
            this.lblNumDoc = new MetroFramework.Controls.MetroLabel();
            this.cboTipoDocIdentidad = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblTipoDocIdentidad = new MetroFramework.Controls.MetroLabel();
            this.txtNomComercial = new MetroFramework.Controls.MetroTextBox();
            this.lblNomComercial = new MetroFramework.Controls.MetroLabel();
            this.txtRazonSocial = new MetroFramework.Controls.MetroTextBox();
            this.lblRazonSocial = new MetroFramework.Controls.MetroLabel();
            this.lblSexo = new MetroFramework.Controls.MetroLabel();
            this.rbtFemenino = new MetroFramework.Controls.MetroRadioButton();
            this.rbtMasculino = new MetroFramework.Controls.MetroRadioButton();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechaNac = new MetroFramework.Controls.MetroLabel();
            this.cboEstadoCivil = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblEstadoCivil = new MetroFramework.Controls.MetroLabel();
            this.txtSegundoNom = new MetroFramework.Controls.MetroTextBox();
            this.lblSegundoNom = new MetroFramework.Controls.MetroLabel();
            this.txtApMaterno = new MetroFramework.Controls.MetroTextBox();
            this.lblApMaterno = new MetroFramework.Controls.MetroLabel();
            this.txtPrimerNom = new MetroFramework.Controls.MetroTextBox();
            this.lblPrimerNom = new MetroFramework.Controls.MetroLabel();
            this.txtApPaterno = new MetroFramework.Controls.MetroTextBox();
            this.lblApPaterno = new MetroFramework.Controls.MetroLabel();
            this.tabPagDireccion = new MetroFramework.Controls.MetroTabPage();
            this.grbUbicacionDetallada = new System.Windows.Forms.GroupBox();
            this.txtDireccion01 = new MetroFramework.Controls.MetroTextBox();
            this.lblDireccion02 = new MetroFramework.Controls.MetroLabel();
            this.lblDireccion01 = new MetroFramework.Controls.MetroLabel();
            this.txtDireccion02 = new MetroFramework.Controls.MetroTextBox();
            this.txtNomZona = new MetroFramework.Controls.MetroTextBox();
            this.lblNomZona = new MetroFramework.Controls.MetroLabel();
            this.txtNomVia = new MetroFramework.Controls.MetroTextBox();
            this.lblZona = new MetroFramework.Controls.MetroLabel();
            this.cboZona = new ConfigUtilitarios.Controls.BorderedCombo();
            this.txtReferencia = new MetroFramework.Controls.MetroTextBox();
            this.lblNomVia = new MetroFramework.Controls.MetroLabel();
            this.lblReferencia = new MetroFramework.Controls.MetroLabel();
            this.txtNumVia = new MetroFramework.Controls.MetroTextBox();
            this.lblVia = new MetroFramework.Controls.MetroLabel();
            this.cboVia = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblNumVia = new MetroFramework.Controls.MetroLabel();
            this.gbrUbigeo = new System.Windows.Forms.GroupBox();
            this.lblDepartamento = new MetroFramework.Controls.MetroLabel();
            this.cboDepartamento = new ConfigUtilitarios.Controls.BorderedCombo();
            this.cboDistrito = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblDistrito = new MetroFramework.Controls.MetroLabel();
            this.lblNacionalidad = new MetroFramework.Controls.MetroLabel();
            this.lblProvincia = new MetroFramework.Controls.MetroLabel();
            this.cboNacionalidad = new ConfigUtilitarios.Controls.BorderedCombo();
            this.cboProvincia = new ConfigUtilitarios.Controls.BorderedCombo();
            this.tabPagContacto = new MetroFramework.Controls.MetroTabPage();
            this.grbEmailYWeb = new System.Windows.Forms.GroupBox();
            this.txtEmail02 = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail02 = new MetroFramework.Controls.MetroLabel();
            this.txtPagWeb = new MetroFramework.Controls.MetroTextBox();
            this.lblPagWeb = new MetroFramework.Controls.MetroLabel();
            this.txtEmail01 = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail01 = new MetroFramework.Controls.MetroLabel();
            this.grbNumerosContacto = new System.Windows.Forms.GroupBox();
            this.txtTelfFijo02 = new MetroFramework.Controls.MetroTextBox();
            this.txtCelular02 = new MetroFramework.Controls.MetroTextBox();
            this.txtTelfFijo01 = new MetroFramework.Controls.MetroTextBox();
            this.lblCelular02 = new MetroFramework.Controls.MetroLabel();
            this.lblTelFijo02 = new MetroFramework.Controls.MetroLabel();
            this.txtCelular03 = new MetroFramework.Controls.MetroTextBox();
            this.lblTelFijo01 = new MetroFramework.Controls.MetroLabel();
            this.lblCelular03 = new MetroFramework.Controls.MetroLabel();
            this.txtTelfFijo03 = new MetroFramework.Controls.MetroTextBox();
            this.lblTelFijo03 = new MetroFramework.Controls.MetroLabel();
            this.txtCelular01 = new MetroFramework.Controls.MetroTextBox();
            this.lblCelular01 = new MetroFramework.Controls.MetroLabel();
            this.tabPagInfoExtra = new MetroFramework.Controls.MetroTabPage();
            this.grbInfoExtra = new System.Windows.Forms.GroupBox();
            this.txtInfo10 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo10 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo08 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo08 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo09 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo09 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo07 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo07 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo05 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo05 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo06 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo06 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo04 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo04 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo02 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo02 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo03 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo03 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo01 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo01 = new MetroFramework.Controls.MetroLabel();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.panelMantenimiento = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblIdCliente = new MetroFramework.Controls.MetroLabel();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.panelFiltro.SuspendLayout();
            this.tabCliente.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.tabPagDireccion.SuspendLayout();
            this.grbUbicacionDetallada.SuspendLayout();
            this.gbrUbigeo.SuspendLayout();
            this.tabPagContacto.SuspendLayout();
            this.grbEmailYWeb.SuspendLayout();
            this.grbNumerosContacto.SuspendLayout();
            this.tabPagInfoExtra.SuspendLayout();
            this.grbInfoExtra.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(134, 104);
            this.tglListarInactivos.Name = "tglListarInactivos";
            this.tglListarInactivos.Size = new System.Drawing.Size(80, 17);
            this.tglListarInactivos.TabIndex = 4;
            this.tglListarInactivos.Text = "Off";
            this.tglListarInactivos.UseSelectable = true;
            this.tglListarInactivos.Click += new System.EventHandler(this.tglListarInactivos_Click);
            // 
            // lblListarInactivos
            // 
            this.lblListarInactivos.AutoSize = true;
            this.lblListarInactivos.Location = new System.Drawing.Point(36, 104);
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
            this.panelFiltro.Location = new System.Drawing.Point(408, 447);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(564, 44);
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
            this.btnFilter.Location = new System.Drawing.Point(521, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(37, 29);
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
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(295, 11);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PromptText = "Filtro";
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(222, 23);
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
            this.cboFiltro.TabIndex = 2;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.tabPagGeneral);
            this.tabCliente.Controls.Add(this.tabPagDireccion);
            this.tabCliente.Controls.Add(this.tabPagContacto);
            this.tabCliente.Controls.Add(this.tabPagInfoExtra);
            this.tabCliente.Location = new System.Drawing.Point(411, 91);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(586, 350);
            this.tabCliente.TabIndex = 1;
            this.tabCliente.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.chkActivo);
            this.tabPagGeneral.Controls.Add(this.txtNumRuc);
            this.tabPagGeneral.Controls.Add(this.lblNumRuc);
            this.tabPagGeneral.Controls.Add(this.txtNumDoc);
            this.tabPagGeneral.Controls.Add(this.lblNumDoc);
            this.tabPagGeneral.Controls.Add(this.cboTipoDocIdentidad);
            this.tabPagGeneral.Controls.Add(this.lblTipoDocIdentidad);
            this.tabPagGeneral.Controls.Add(this.txtNomComercial);
            this.tabPagGeneral.Controls.Add(this.lblNomComercial);
            this.tabPagGeneral.Controls.Add(this.txtRazonSocial);
            this.tabPagGeneral.Controls.Add(this.lblRazonSocial);
            this.tabPagGeneral.Controls.Add(this.lblSexo);
            this.tabPagGeneral.Controls.Add(this.rbtFemenino);
            this.tabPagGeneral.Controls.Add(this.rbtMasculino);
            this.tabPagGeneral.Controls.Add(this.txtCodigo);
            this.tabPagGeneral.Controls.Add(this.lblCodigo);
            this.tabPagGeneral.Controls.Add(this.dtpFechaNacimiento);
            this.tabPagGeneral.Controls.Add(this.panel3);
            this.tabPagGeneral.Controls.Add(this.panel1);
            this.tabPagGeneral.Controls.Add(this.lblFechaNac);
            this.tabPagGeneral.Controls.Add(this.cboEstadoCivil);
            this.tabPagGeneral.Controls.Add(this.lblEstadoCivil);
            this.tabPagGeneral.Controls.Add(this.txtSegundoNom);
            this.tabPagGeneral.Controls.Add(this.lblSegundoNom);
            this.tabPagGeneral.Controls.Add(this.txtApMaterno);
            this.tabPagGeneral.Controls.Add(this.lblApMaterno);
            this.tabPagGeneral.Controls.Add(this.txtPrimerNom);
            this.tabPagGeneral.Controls.Add(this.lblPrimerNom);
            this.tabPagGeneral.Controls.Add(this.txtApPaterno);
            this.tabPagGeneral.Controls.Add(this.lblApPaterno);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(578, 308);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkActivo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkActivo.ForeColor = System.Drawing.Color.Navy;
            this.chkActivo.Location = new System.Drawing.Point(3, 285);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 14;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseCustomForeColor = true;
            this.chkActivo.UseSelectable = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.CambioEnControl);
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
            this.txtNumRuc.Location = new System.Drawing.Point(82, 235);
            this.txtNumRuc.MaxLength = 32767;
            this.txtNumRuc.Name = "txtNumRuc";
            this.txtNumRuc.PasswordChar = '\0';
            this.txtNumRuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumRuc.SelectedText = "";
            this.txtNumRuc.SelectionLength = 0;
            this.txtNumRuc.SelectionStart = 0;
            this.txtNumRuc.ShortcutsEnabled = true;
            this.txtNumRuc.Size = new System.Drawing.Size(184, 23);
            this.txtNumRuc.TabIndex = 13;
            this.txtNumRuc.UseCustomBackColor = true;
            this.txtNumRuc.UseSelectable = true;
            this.txtNumRuc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumRuc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumRuc.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNumRuc
            // 
            this.lblNumRuc.AutoSize = true;
            this.lblNumRuc.ForeColor = System.Drawing.Color.Navy;
            this.lblNumRuc.Location = new System.Drawing.Point(1, 237);
            this.lblNumRuc.Name = "lblNumRuc";
            this.lblNumRuc.Size = new System.Drawing.Size(74, 19);
            this.lblNumRuc.TabIndex = 25;
            this.lblNumRuc.Text = "Núm. RUC:";
            this.lblNumRuc.UseCustomForeColor = true;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNumDoc.CustomButton.Image = null;
            this.txtNumDoc.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNumDoc.CustomButton.Name = "";
            this.txtNumDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumDoc.CustomButton.TabIndex = 1;
            this.txtNumDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumDoc.CustomButton.UseSelectable = true;
            this.txtNumDoc.CustomButton.Visible = false;
            this.txtNumDoc.Lines = new string[0];
            this.txtNumDoc.Location = new System.Drawing.Point(376, 201);
            this.txtNumDoc.MaxLength = 32767;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.PasswordChar = '\0';
            this.txtNumDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumDoc.SelectedText = "";
            this.txtNumDoc.SelectionLength = 0;
            this.txtNumDoc.SelectionStart = 0;
            this.txtNumDoc.ShortcutsEnabled = true;
            this.txtNumDoc.Size = new System.Drawing.Size(184, 23);
            this.txtNumDoc.TabIndex = 12;
            this.txtNumDoc.UseCustomBackColor = true;
            this.txtNumDoc.UseSelectable = true;
            this.txtNumDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumDoc.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.ForeColor = System.Drawing.Color.Navy;
            this.lblNumDoc.Location = new System.Drawing.Point(289, 203);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(71, 19);
            this.lblNumDoc.TabIndex = 23;
            this.lblNumDoc.Text = "Núm. Doc:";
            this.lblNumDoc.UseCustomForeColor = true;
            // 
            // cboTipoDocIdentidad
            // 
            this.cboTipoDocIdentidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTipoDocIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocIdentidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoDocIdentidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocIdentidad.FormattingEnabled = true;
            this.cboTipoDocIdentidad.Location = new System.Drawing.Point(82, 201);
            this.cboTipoDocIdentidad.Name = "cboTipoDocIdentidad";
            this.cboTipoDocIdentidad.Size = new System.Drawing.Size(184, 23);
            this.cboTipoDocIdentidad.TabIndex = 11;
            // 
            // lblTipoDocIdentidad
            // 
            this.lblTipoDocIdentidad.AutoSize = true;
            this.lblTipoDocIdentidad.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoDocIdentidad.Location = new System.Drawing.Point(-1, 203);
            this.lblTipoDocIdentidad.Name = "lblTipoDocIdentidad";
            this.lblTipoDocIdentidad.Size = new System.Drawing.Size(65, 19);
            this.lblTipoDocIdentidad.TabIndex = 21;
            this.lblTipoDocIdentidad.Text = "Tipo Doc:";
            this.lblTipoDocIdentidad.UseCustomForeColor = true;
            // 
            // txtNomComercial
            // 
            this.txtNomComercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNomComercial.CustomButton.Image = null;
            this.txtNomComercial.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNomComercial.CustomButton.Name = "";
            this.txtNomComercial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomComercial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomComercial.CustomButton.TabIndex = 1;
            this.txtNomComercial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomComercial.CustomButton.UseSelectable = true;
            this.txtNomComercial.CustomButton.Visible = false;
            this.txtNomComercial.Lines = new string[0];
            this.txtNomComercial.Location = new System.Drawing.Point(376, 167);
            this.txtNomComercial.MaxLength = 32767;
            this.txtNomComercial.Name = "txtNomComercial";
            this.txtNomComercial.PasswordChar = '\0';
            this.txtNomComercial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomComercial.SelectedText = "";
            this.txtNomComercial.SelectionLength = 0;
            this.txtNomComercial.SelectionStart = 0;
            this.txtNomComercial.ShortcutsEnabled = true;
            this.txtNomComercial.Size = new System.Drawing.Size(184, 23);
            this.txtNomComercial.TabIndex = 10;
            this.txtNomComercial.UseCustomBackColor = true;
            this.txtNomComercial.UseSelectable = true;
            this.txtNomComercial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomComercial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomComercial.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNomComercial
            // 
            this.lblNomComercial.AutoSize = true;
            this.lblNomComercial.ForeColor = System.Drawing.Color.Navy;
            this.lblNomComercial.Location = new System.Drawing.Point(290, 169);
            this.lblNomComercial.Name = "lblNomComercial";
            this.lblNomComercial.Size = new System.Drawing.Size(89, 19);
            this.lblNomComercial.TabIndex = 19;
            this.lblNomComercial.Text = "N. Comercial:";
            this.lblNomComercial.UseCustomForeColor = true;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtRazonSocial.CustomButton.Image = null;
            this.txtRazonSocial.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtRazonSocial.CustomButton.Name = "";
            this.txtRazonSocial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRazonSocial.CustomButton.TabIndex = 1;
            this.txtRazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRazonSocial.CustomButton.UseSelectable = true;
            this.txtRazonSocial.CustomButton.Visible = false;
            this.txtRazonSocial.Lines = new string[0];
            this.txtRazonSocial.Location = new System.Drawing.Point(82, 167);
            this.txtRazonSocial.MaxLength = 32767;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.SelectionLength = 0;
            this.txtRazonSocial.SelectionStart = 0;
            this.txtRazonSocial.ShortcutsEnabled = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(184, 23);
            this.txtRazonSocial.TabIndex = 9;
            this.txtRazonSocial.UseCustomBackColor = true;
            this.txtRazonSocial.UseSelectable = true;
            this.txtRazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRazonSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.ForeColor = System.Drawing.Color.Navy;
            this.lblRazonSocial.Location = new System.Drawing.Point(0, 169);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(86, 19);
            this.lblRazonSocial.TabIndex = 17;
            this.lblRazonSocial.Text = "Razón Social:";
            this.lblRazonSocial.UseCustomForeColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.Color.Navy;
            this.lblSexo.Location = new System.Drawing.Point(290, 117);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 19);
            this.lblSexo.TabIndex = 14;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.UseCustomForeColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(483, 121);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(76, 15);
            this.rbtFemenino.TabIndex = 8;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseSelectable = true;
            this.rbtFemenino.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(376, 121);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(78, 15);
            this.rbtMasculino.TabIndex = 7;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseSelectable = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.CambioEnControl);
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
            this.txtCodigo.Location = new System.Drawing.Point(82, 82);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(184, 23);
            this.txtCodigo.TabIndex = 4;
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
            this.lblCodigo.Location = new System.Drawing.Point(-1, 84);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 19);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseCustomForeColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(376, 82);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(183, 23);
            this.dtpFechaNacimiento.TabIndex = 5;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(4, 269);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 5);
            this.panel3.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 5);
            this.panel1.TabIndex = 57;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaNac.Location = new System.Drawing.Point(290, 86);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(73, 19);
            this.lblFechaNac.TabIndex = 10;
            this.lblFechaNac.Text = "Fecha Nac:";
            this.lblFechaNac.UseCustomForeColor = true;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(81, 116);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(185, 23);
            this.cboEstadoCivil.TabIndex = 6;
            this.cboEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.ForeColor = System.Drawing.Color.Navy;
            this.lblEstadoCivil.Location = new System.Drawing.Point(0, 118);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(79, 19);
            this.lblEstadoCivil.TabIndex = 12;
            this.lblEstadoCivil.Text = "Estado Civil:";
            this.lblEstadoCivil.UseCustomForeColor = true;
            // 
            // txtSegundoNom
            // 
            this.txtSegundoNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtSegundoNom.CustomButton.Image = null;
            this.txtSegundoNom.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtSegundoNom.CustomButton.Name = "";
            this.txtSegundoNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSegundoNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSegundoNom.CustomButton.TabIndex = 1;
            this.txtSegundoNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSegundoNom.CustomButton.UseSelectable = true;
            this.txtSegundoNom.CustomButton.Visible = false;
            this.txtSegundoNom.Lines = new string[0];
            this.txtSegundoNom.Location = new System.Drawing.Point(374, 12);
            this.txtSegundoNom.MaxLength = 32767;
            this.txtSegundoNom.Name = "txtSegundoNom";
            this.txtSegundoNom.PasswordChar = '\0';
            this.txtSegundoNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSegundoNom.SelectedText = "";
            this.txtSegundoNom.SelectionLength = 0;
            this.txtSegundoNom.SelectionStart = 0;
            this.txtSegundoNom.ShortcutsEnabled = true;
            this.txtSegundoNom.Size = new System.Drawing.Size(184, 23);
            this.txtSegundoNom.TabIndex = 1;
            this.txtSegundoNom.UseCustomBackColor = true;
            this.txtSegundoNom.UseSelectable = true;
            this.txtSegundoNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSegundoNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegundoNom.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblSegundoNom
            // 
            this.lblSegundoNom.AutoSize = true;
            this.lblSegundoNom.ForeColor = System.Drawing.Color.Navy;
            this.lblSegundoNom.Location = new System.Drawing.Point(289, 14);
            this.lblSegundoNom.Name = "lblSegundoNom";
            this.lblSegundoNom.Size = new System.Drawing.Size(78, 19);
            this.lblSegundoNom.TabIndex = 6;
            this.lblSegundoNom.Text = "2° Nombre:";
            this.lblSegundoNom.UseCustomForeColor = true;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtApMaterno.CustomButton.Image = null;
            this.txtApMaterno.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtApMaterno.CustomButton.Name = "";
            this.txtApMaterno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApMaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApMaterno.CustomButton.TabIndex = 1;
            this.txtApMaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApMaterno.CustomButton.UseSelectable = true;
            this.txtApMaterno.CustomButton.Visible = false;
            this.txtApMaterno.Lines = new string[0];
            this.txtApMaterno.Location = new System.Drawing.Point(374, 47);
            this.txtApMaterno.MaxLength = 32767;
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.PasswordChar = '\0';
            this.txtApMaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApMaterno.SelectedText = "";
            this.txtApMaterno.SelectionLength = 0;
            this.txtApMaterno.SelectionStart = 0;
            this.txtApMaterno.ShortcutsEnabled = true;
            this.txtApMaterno.Size = new System.Drawing.Size(184, 23);
            this.txtApMaterno.TabIndex = 3;
            this.txtApMaterno.UseCustomBackColor = true;
            this.txtApMaterno.UseSelectable = true;
            this.txtApMaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApMaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtApMaterno.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.ForeColor = System.Drawing.Color.Navy;
            this.lblApMaterno.Location = new System.Drawing.Point(289, 49);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(86, 19);
            this.lblApMaterno.TabIndex = 2;
            this.lblApMaterno.Text = "Ap. Materno:";
            this.lblApMaterno.UseCustomForeColor = true;
            // 
            // txtPrimerNom
            // 
            this.txtPrimerNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPrimerNom.CustomButton.Image = null;
            this.txtPrimerNom.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtPrimerNom.CustomButton.Name = "";
            this.txtPrimerNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrimerNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrimerNom.CustomButton.TabIndex = 1;
            this.txtPrimerNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrimerNom.CustomButton.UseSelectable = true;
            this.txtPrimerNom.CustomButton.Visible = false;
            this.txtPrimerNom.Lines = new string[0];
            this.txtPrimerNom.Location = new System.Drawing.Point(81, 12);
            this.txtPrimerNom.MaxLength = 32767;
            this.txtPrimerNom.Name = "txtPrimerNom";
            this.txtPrimerNom.PasswordChar = '\0';
            this.txtPrimerNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrimerNom.SelectedText = "";
            this.txtPrimerNom.SelectionLength = 0;
            this.txtPrimerNom.SelectionStart = 0;
            this.txtPrimerNom.ShortcutsEnabled = true;
            this.txtPrimerNom.Size = new System.Drawing.Size(184, 23);
            this.txtPrimerNom.TabIndex = 0;
            this.txtPrimerNom.UseCustomBackColor = true;
            this.txtPrimerNom.UseSelectable = true;
            this.txtPrimerNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrimerNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimerNom.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblPrimerNom
            // 
            this.lblPrimerNom.AutoSize = true;
            this.lblPrimerNom.ForeColor = System.Drawing.Color.Navy;
            this.lblPrimerNom.Location = new System.Drawing.Point(-2, 14);
            this.lblPrimerNom.Name = "lblPrimerNom";
            this.lblPrimerNom.Size = new System.Drawing.Size(76, 19);
            this.lblPrimerNom.TabIndex = 4;
            this.lblPrimerNom.Text = "1° Nombre:";
            this.lblPrimerNom.UseCustomForeColor = true;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtApPaterno.CustomButton.Image = null;
            this.txtApPaterno.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtApPaterno.CustomButton.Name = "";
            this.txtApPaterno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApPaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApPaterno.CustomButton.TabIndex = 1;
            this.txtApPaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApPaterno.CustomButton.UseSelectable = true;
            this.txtApPaterno.CustomButton.Visible = false;
            this.txtApPaterno.Lines = new string[0];
            this.txtApPaterno.Location = new System.Drawing.Point(81, 47);
            this.txtApPaterno.MaxLength = 32767;
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.PasswordChar = '\0';
            this.txtApPaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApPaterno.SelectedText = "";
            this.txtApPaterno.SelectionLength = 0;
            this.txtApPaterno.SelectionStart = 0;
            this.txtApPaterno.ShortcutsEnabled = true;
            this.txtApPaterno.Size = new System.Drawing.Size(184, 23);
            this.txtApPaterno.TabIndex = 2;
            this.txtApPaterno.UseCustomBackColor = true;
            this.txtApPaterno.UseSelectable = true;
            this.txtApPaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApPaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtApPaterno.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.ForeColor = System.Drawing.Color.Navy;
            this.lblApPaterno.Location = new System.Drawing.Point(-2, 49);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(81, 19);
            this.lblApPaterno.TabIndex = 0;
            this.lblApPaterno.Text = "Ap. Paterno:";
            this.lblApPaterno.UseCustomForeColor = true;
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
            this.tabPagDireccion.Size = new System.Drawing.Size(578, 308);
            this.tabPagDireccion.TabIndex = 3;
            this.tabPagDireccion.Text = "Dirección";
            this.tabPagDireccion.VerticalScrollbarBarColor = true;
            this.tabPagDireccion.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagDireccion.VerticalScrollbarSize = 10;
            // 
            // grbUbicacionDetallada
            // 
            this.grbUbicacionDetallada.BackColor = System.Drawing.Color.Transparent;
            this.grbUbicacionDetallada.Controls.Add(this.txtDireccion01);
            this.grbUbicacionDetallada.Controls.Add(this.lblDireccion02);
            this.grbUbicacionDetallada.Controls.Add(this.lblDireccion01);
            this.grbUbicacionDetallada.Controls.Add(this.txtDireccion02);
            this.grbUbicacionDetallada.Controls.Add(this.txtNomZona);
            this.grbUbicacionDetallada.Controls.Add(this.lblNomZona);
            this.grbUbicacionDetallada.Controls.Add(this.txtNomVia);
            this.grbUbicacionDetallada.Controls.Add(this.lblZona);
            this.grbUbicacionDetallada.Controls.Add(this.cboZona);
            this.grbUbicacionDetallada.Controls.Add(this.txtReferencia);
            this.grbUbicacionDetallada.Controls.Add(this.lblNomVia);
            this.grbUbicacionDetallada.Controls.Add(this.lblReferencia);
            this.grbUbicacionDetallada.Controls.Add(this.txtNumVia);
            this.grbUbicacionDetallada.Controls.Add(this.lblVia);
            this.grbUbicacionDetallada.Controls.Add(this.cboVia);
            this.grbUbicacionDetallada.Controls.Add(this.lblNumVia);
            this.grbUbicacionDetallada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUbicacionDetallada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUbicacionDetallada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbUbicacionDetallada.Location = new System.Drawing.Point(3, 107);
            this.grbUbicacionDetallada.Name = "grbUbicacionDetallada";
            this.grbUbicacionDetallada.Size = new System.Drawing.Size(555, 202);
            this.grbUbicacionDetallada.TabIndex = 1;
            this.grbUbicacionDetallada.TabStop = false;
            this.grbUbicacionDetallada.Text = "Ubicación detallada";
            // 
            // txtDireccion01
            // 
            this.txtDireccion01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDireccion01.CustomButton.Image = null;
            this.txtDireccion01.CustomButton.Location = new System.Drawing.Point(445, 1);
            this.txtDireccion01.CustomButton.Name = "";
            this.txtDireccion01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion01.CustomButton.TabIndex = 1;
            this.txtDireccion01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion01.CustomButton.UseSelectable = true;
            this.txtDireccion01.CustomButton.Visible = false;
            this.txtDireccion01.Lines = new string[0];
            this.txtDireccion01.Location = new System.Drawing.Point(82, 97);
            this.txtDireccion01.MaxLength = 32767;
            this.txtDireccion01.Name = "txtDireccion01";
            this.txtDireccion01.PasswordChar = '\0';
            this.txtDireccion01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion01.SelectedText = "";
            this.txtDireccion01.SelectionLength = 0;
            this.txtDireccion01.SelectionStart = 0;
            this.txtDireccion01.ShortcutsEnabled = true;
            this.txtDireccion01.Size = new System.Drawing.Size(467, 23);
            this.txtDireccion01.TabIndex = 5;
            this.txtDireccion01.UseCustomBackColor = true;
            this.txtDireccion01.UseSelectable = true;
            this.txtDireccion01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblDireccion02
            // 
            this.lblDireccion02.AutoSize = true;
            this.lblDireccion02.ForeColor = System.Drawing.Color.Navy;
            this.lblDireccion02.Location = new System.Drawing.Point(8, 134);
            this.lblDireccion02.Name = "lblDireccion02";
            this.lblDireccion02.Size = new System.Drawing.Size(48, 19);
            this.lblDireccion02.TabIndex = 54;
            this.lblDireccion02.Text = "Dir. 02:";
            this.lblDireccion02.UseCustomForeColor = true;
            // 
            // lblDireccion01
            // 
            this.lblDireccion01.AutoSize = true;
            this.lblDireccion01.ForeColor = System.Drawing.Color.Navy;
            this.lblDireccion01.Location = new System.Drawing.Point(8, 99);
            this.lblDireccion01.Name = "lblDireccion01";
            this.lblDireccion01.Size = new System.Drawing.Size(46, 19);
            this.lblDireccion01.TabIndex = 52;
            this.lblDireccion01.Text = "Dir. 01:";
            this.lblDireccion01.UseCustomForeColor = true;
            // 
            // txtDireccion02
            // 
            this.txtDireccion02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDireccion02.CustomButton.Image = null;
            this.txtDireccion02.CustomButton.Location = new System.Drawing.Point(445, 1);
            this.txtDireccion02.CustomButton.Name = "";
            this.txtDireccion02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion02.CustomButton.TabIndex = 1;
            this.txtDireccion02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion02.CustomButton.UseSelectable = true;
            this.txtDireccion02.CustomButton.Visible = false;
            this.txtDireccion02.Lines = new string[0];
            this.txtDireccion02.Location = new System.Drawing.Point(82, 132);
            this.txtDireccion02.MaxLength = 32767;
            this.txtDireccion02.Name = "txtDireccion02";
            this.txtDireccion02.PasswordChar = '\0';
            this.txtDireccion02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion02.SelectedText = "";
            this.txtDireccion02.SelectionLength = 0;
            this.txtDireccion02.SelectionStart = 0;
            this.txtDireccion02.ShortcutsEnabled = true;
            this.txtDireccion02.Size = new System.Drawing.Size(467, 23);
            this.txtDireccion02.TabIndex = 6;
            this.txtDireccion02.UseCustomBackColor = true;
            this.txtDireccion02.UseSelectable = true;
            this.txtDireccion02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtNomZona
            // 
            this.txtNomZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNomZona.CustomButton.Image = null;
            this.txtNomZona.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNomZona.CustomButton.Name = "";
            this.txtNomZona.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomZona.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomZona.CustomButton.TabIndex = 1;
            this.txtNomZona.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomZona.CustomButton.UseSelectable = true;
            this.txtNomZona.CustomButton.Visible = false;
            this.txtNomZona.Lines = new string[0];
            this.txtNomZona.Location = new System.Drawing.Point(363, 25);
            this.txtNomZona.MaxLength = 32767;
            this.txtNomZona.Name = "txtNomZona";
            this.txtNomZona.PasswordChar = '\0';
            this.txtNomZona.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomZona.SelectedText = "";
            this.txtNomZona.SelectionLength = 0;
            this.txtNomZona.SelectionStart = 0;
            this.txtNomZona.ShortcutsEnabled = true;
            this.txtNomZona.Size = new System.Drawing.Size(184, 23);
            this.txtNomZona.TabIndex = 1;
            this.txtNomZona.UseCustomBackColor = true;
            this.txtNomZona.UseSelectable = true;
            this.txtNomZona.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomZona.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomZona.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNomZona
            // 
            this.lblNomZona.AutoSize = true;
            this.lblNomZona.ForeColor = System.Drawing.Color.Navy;
            this.lblNomZona.Location = new System.Drawing.Point(278, 27);
            this.lblNomZona.Name = "lblNomZona";
            this.lblNomZona.Size = new System.Drawing.Size(79, 19);
            this.lblNomZona.TabIndex = 42;
            this.lblNomZona.Text = "Nom. Zona:";
            this.lblNomZona.UseCustomForeColor = true;
            // 
            // txtNomVia
            // 
            this.txtNomVia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNomVia.CustomButton.Image = null;
            this.txtNomVia.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtNomVia.CustomButton.Name = "";
            this.txtNomVia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomVia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomVia.CustomButton.TabIndex = 1;
            this.txtNomVia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomVia.CustomButton.UseSelectable = true;
            this.txtNomVia.CustomButton.Visible = false;
            this.txtNomVia.Lines = new string[0];
            this.txtNomVia.Location = new System.Drawing.Point(363, 61);
            this.txtNomVia.MaxLength = 32767;
            this.txtNomVia.Name = "txtNomVia";
            this.txtNomVia.PasswordChar = '\0';
            this.txtNomVia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomVia.SelectedText = "";
            this.txtNomVia.SelectionLength = 0;
            this.txtNomVia.SelectionStart = 0;
            this.txtNomVia.ShortcutsEnabled = true;
            this.txtNomVia.Size = new System.Drawing.Size(125, 23);
            this.txtNomVia.TabIndex = 3;
            this.txtNomVia.UseCustomBackColor = true;
            this.txtNomVia.UseSelectable = true;
            this.txtNomVia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomVia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomVia.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.ForeColor = System.Drawing.Color.Navy;
            this.lblZona.Location = new System.Drawing.Point(5, 25);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(72, 19);
            this.lblZona.TabIndex = 40;
            this.lblZona.Text = "Tipo Zona:";
            this.lblZona.UseCustomForeColor = true;
            // 
            // cboZona
            // 
            this.cboZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboZona.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboZona.FormattingEnabled = true;
            this.cboZona.Location = new System.Drawing.Point(82, 25);
            this.cboZona.Name = "cboZona";
            this.cboZona.Size = new System.Drawing.Size(163, 23);
            this.cboZona.TabIndex = 0;
            this.cboZona.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtReferencia.CustomButton.Image = null;
            this.txtReferencia.CustomButton.Location = new System.Drawing.Point(445, 1);
            this.txtReferencia.CustomButton.Name = "";
            this.txtReferencia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReferencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReferencia.CustomButton.TabIndex = 1;
            this.txtReferencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReferencia.CustomButton.UseSelectable = true;
            this.txtReferencia.CustomButton.Visible = false;
            this.txtReferencia.Lines = new string[0];
            this.txtReferencia.Location = new System.Drawing.Point(82, 166);
            this.txtReferencia.MaxLength = 32767;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.PasswordChar = '\0';
            this.txtReferencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReferencia.SelectedText = "";
            this.txtReferencia.SelectionLength = 0;
            this.txtReferencia.SelectionStart = 0;
            this.txtReferencia.ShortcutsEnabled = true;
            this.txtReferencia.Size = new System.Drawing.Size(467, 23);
            this.txtReferencia.TabIndex = 7;
            this.txtReferencia.UseCustomBackColor = true;
            this.txtReferencia.UseSelectable = true;
            this.txtReferencia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReferencia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtReferencia.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNomVia
            // 
            this.lblNomVia.AutoSize = true;
            this.lblNomVia.ForeColor = System.Drawing.Color.Navy;
            this.lblNomVia.Location = new System.Drawing.Point(278, 63);
            this.lblNomVia.Name = "lblNomVia";
            this.lblNomVia.Size = new System.Drawing.Size(67, 19);
            this.lblNomVia.TabIndex = 46;
            this.lblNomVia.Text = "Nom. Vía:";
            this.lblNomVia.UseCustomForeColor = true;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.ForeColor = System.Drawing.Color.Navy;
            this.lblReferencia.Location = new System.Drawing.Point(8, 170);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(73, 19);
            this.lblReferencia.TabIndex = 50;
            this.lblReferencia.Text = "Referencia:";
            this.lblReferencia.UseCustomForeColor = true;
            // 
            // txtNumVia
            // 
            this.txtNumVia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNumVia.CustomButton.Image = null;
            this.txtNumVia.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtNumVia.CustomButton.Name = "";
            this.txtNumVia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumVia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumVia.CustomButton.TabIndex = 1;
            this.txtNumVia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumVia.CustomButton.UseSelectable = true;
            this.txtNumVia.CustomButton.Visible = false;
            this.txtNumVia.Lines = new string[0];
            this.txtNumVia.Location = new System.Drawing.Point(514, 61);
            this.txtNumVia.MaxLength = 32767;
            this.txtNumVia.Name = "txtNumVia";
            this.txtNumVia.PasswordChar = '\0';
            this.txtNumVia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumVia.SelectedText = "";
            this.txtNumVia.SelectionLength = 0;
            this.txtNumVia.SelectionStart = 0;
            this.txtNumVia.ShortcutsEnabled = true;
            this.txtNumVia.Size = new System.Drawing.Size(33, 23);
            this.txtNumVia.TabIndex = 4;
            this.txtNumVia.UseCustomBackColor = true;
            this.txtNumVia.UseSelectable = true;
            this.txtNumVia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumVia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumVia.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblVia
            // 
            this.lblVia.AutoSize = true;
            this.lblVia.ForeColor = System.Drawing.Color.Navy;
            this.lblVia.Location = new System.Drawing.Point(6, 63);
            this.lblVia.Name = "lblVia";
            this.lblVia.Size = new System.Drawing.Size(60, 19);
            this.lblVia.TabIndex = 44;
            this.lblVia.Text = "Tipo Vía:";
            this.lblVia.UseCustomForeColor = true;
            // 
            // cboVia
            // 
            this.cboVia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVia.FormattingEnabled = true;
            this.cboVia.Location = new System.Drawing.Point(82, 61);
            this.cboVia.Name = "cboVia";
            this.cboVia.Size = new System.Drawing.Size(163, 23);
            this.cboVia.TabIndex = 2;
            this.cboVia.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNumVia
            // 
            this.lblNumVia.AutoSize = true;
            this.lblNumVia.ForeColor = System.Drawing.Color.Navy;
            this.lblNumVia.Location = new System.Drawing.Point(489, 63);
            this.lblNumVia.Name = "lblNumVia";
            this.lblNumVia.Size = new System.Drawing.Size(24, 19);
            this.lblNumVia.TabIndex = 48;
            this.lblNumVia.Text = "N°";
            this.lblNumVia.UseCustomForeColor = true;
            // 
            // gbrUbigeo
            // 
            this.gbrUbigeo.BackColor = System.Drawing.Color.Transparent;
            this.gbrUbigeo.Controls.Add(this.lblDepartamento);
            this.gbrUbigeo.Controls.Add(this.cboDepartamento);
            this.gbrUbigeo.Controls.Add(this.cboDistrito);
            this.gbrUbigeo.Controls.Add(this.lblDistrito);
            this.gbrUbigeo.Controls.Add(this.lblNacionalidad);
            this.gbrUbigeo.Controls.Add(this.lblProvincia);
            this.gbrUbigeo.Controls.Add(this.cboNacionalidad);
            this.gbrUbigeo.Controls.Add(this.cboProvincia);
            this.gbrUbigeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbrUbigeo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrUbigeo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbrUbigeo.Location = new System.Drawing.Point(3, 8);
            this.gbrUbigeo.Name = "gbrUbigeo";
            this.gbrUbigeo.Size = new System.Drawing.Size(555, 93);
            this.gbrUbigeo.TabIndex = 0;
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
            this.cboDepartamento.TabIndex = 0;
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
            this.cboDistrito.TabIndex = 2;
            this.cboDistrito.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
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
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.ForeColor = System.Drawing.Color.Navy;
            this.lblNacionalidad.Location = new System.Drawing.Point(272, 61);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(89, 19);
            this.lblNacionalidad.TabIndex = 38;
            this.lblNacionalidad.Text = "Nacionalidad:";
            this.lblNacionalidad.UseCustomForeColor = true;
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
            // cboNacionalidad
            // 
            this.cboNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNacionalidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(364, 59);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(184, 23);
            this.cboNacionalidad.TabIndex = 3;
            this.cboNacionalidad.SelectionChangeCommitted += new System.EventHandler(this.CambioEnControl);
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
            this.cboProvincia.TabIndex = 1;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // tabPagContacto
            // 
            this.tabPagContacto.Controls.Add(this.grbEmailYWeb);
            this.tabPagContacto.Controls.Add(this.grbNumerosContacto);
            this.tabPagContacto.HorizontalScrollbarBarColor = true;
            this.tabPagContacto.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagContacto.HorizontalScrollbarSize = 10;
            this.tabPagContacto.Location = new System.Drawing.Point(4, 38);
            this.tabPagContacto.Name = "tabPagContacto";
            this.tabPagContacto.Size = new System.Drawing.Size(578, 308);
            this.tabPagContacto.TabIndex = 1;
            this.tabPagContacto.Text = "Contacto";
            this.tabPagContacto.VerticalScrollbarBarColor = true;
            this.tabPagContacto.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagContacto.VerticalScrollbarSize = 10;
            // 
            // grbEmailYWeb
            // 
            this.grbEmailYWeb.BackColor = System.Drawing.Color.Transparent;
            this.grbEmailYWeb.Controls.Add(this.txtEmail02);
            this.grbEmailYWeb.Controls.Add(this.lblEmail02);
            this.grbEmailYWeb.Controls.Add(this.txtPagWeb);
            this.grbEmailYWeb.Controls.Add(this.lblPagWeb);
            this.grbEmailYWeb.Controls.Add(this.txtEmail01);
            this.grbEmailYWeb.Controls.Add(this.lblEmail01);
            this.grbEmailYWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbEmailYWeb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEmailYWeb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbEmailYWeb.Location = new System.Drawing.Point(3, 10);
            this.grbEmailYWeb.Name = "grbEmailYWeb";
            this.grbEmailYWeb.Size = new System.Drawing.Size(555, 130);
            this.grbEmailYWeb.TabIndex = 0;
            this.grbEmailYWeb.TabStop = false;
            this.grbEmailYWeb.Text = "Email\'s y Web";
            // 
            // txtEmail02
            // 
            this.txtEmail02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtEmail02.CustomButton.Image = null;
            this.txtEmail02.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txtEmail02.CustomButton.Name = "";
            this.txtEmail02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail02.CustomButton.TabIndex = 1;
            this.txtEmail02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail02.CustomButton.UseSelectable = true;
            this.txtEmail02.CustomButton.Visible = false;
            this.txtEmail02.Lines = new string[0];
            this.txtEmail02.Location = new System.Drawing.Point(91, 60);
            this.txtEmail02.MaxLength = 32767;
            this.txtEmail02.Name = "txtEmail02";
            this.txtEmail02.PasswordChar = '\0';
            this.txtEmail02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail02.SelectedText = "";
            this.txtEmail02.SelectionLength = 0;
            this.txtEmail02.SelectionStart = 0;
            this.txtEmail02.ShortcutsEnabled = true;
            this.txtEmail02.Size = new System.Drawing.Size(446, 23);
            this.txtEmail02.TabIndex = 1;
            this.txtEmail02.UseCustomBackColor = true;
            this.txtEmail02.UseSelectable = true;
            this.txtEmail02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblEmail02
            // 
            this.lblEmail02.AutoSize = true;
            this.lblEmail02.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail02.ForeColor = System.Drawing.Color.Navy;
            this.lblEmail02.Location = new System.Drawing.Point(6, 62);
            this.lblEmail02.Name = "lblEmail02";
            this.lblEmail02.Size = new System.Drawing.Size(62, 19);
            this.lblEmail02.TabIndex = 2;
            this.lblEmail02.Text = "Email 02:";
            this.lblEmail02.UseCustomForeColor = true;
            // 
            // txtPagWeb
            // 
            this.txtPagWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPagWeb.CustomButton.Image = null;
            this.txtPagWeb.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txtPagWeb.CustomButton.Name = "";
            this.txtPagWeb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPagWeb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPagWeb.CustomButton.TabIndex = 1;
            this.txtPagWeb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPagWeb.CustomButton.UseSelectable = true;
            this.txtPagWeb.CustomButton.Visible = false;
            this.txtPagWeb.Lines = new string[0];
            this.txtPagWeb.Location = new System.Drawing.Point(91, 94);
            this.txtPagWeb.MaxLength = 32767;
            this.txtPagWeb.Name = "txtPagWeb";
            this.txtPagWeb.PasswordChar = '\0';
            this.txtPagWeb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPagWeb.SelectedText = "";
            this.txtPagWeb.SelectionLength = 0;
            this.txtPagWeb.SelectionStart = 0;
            this.txtPagWeb.ShortcutsEnabled = true;
            this.txtPagWeb.Size = new System.Drawing.Size(446, 23);
            this.txtPagWeb.TabIndex = 2;
            this.txtPagWeb.UseCustomBackColor = true;
            this.txtPagWeb.UseSelectable = true;
            this.txtPagWeb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPagWeb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPagWeb.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblPagWeb
            // 
            this.lblPagWeb.AutoSize = true;
            this.lblPagWeb.BackColor = System.Drawing.Color.Transparent;
            this.lblPagWeb.ForeColor = System.Drawing.Color.Navy;
            this.lblPagWeb.Location = new System.Drawing.Point(6, 96);
            this.lblPagWeb.Name = "lblPagWeb";
            this.lblPagWeb.Size = new System.Drawing.Size(79, 19);
            this.lblPagWeb.TabIndex = 4;
            this.lblPagWeb.Text = "Página web:";
            this.lblPagWeb.UseCustomForeColor = true;
            // 
            // txtEmail01
            // 
            this.txtEmail01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtEmail01.CustomButton.Image = null;
            this.txtEmail01.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txtEmail01.CustomButton.Name = "";
            this.txtEmail01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail01.CustomButton.TabIndex = 1;
            this.txtEmail01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail01.CustomButton.UseSelectable = true;
            this.txtEmail01.CustomButton.Visible = false;
            this.txtEmail01.Lines = new string[0];
            this.txtEmail01.Location = new System.Drawing.Point(91, 26);
            this.txtEmail01.MaxLength = 32767;
            this.txtEmail01.Name = "txtEmail01";
            this.txtEmail01.PasswordChar = '\0';
            this.txtEmail01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail01.SelectedText = "";
            this.txtEmail01.SelectionLength = 0;
            this.txtEmail01.SelectionStart = 0;
            this.txtEmail01.ShortcutsEnabled = true;
            this.txtEmail01.Size = new System.Drawing.Size(446, 23);
            this.txtEmail01.TabIndex = 0;
            this.txtEmail01.UseCustomBackColor = true;
            this.txtEmail01.UseSelectable = true;
            this.txtEmail01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblEmail01
            // 
            this.lblEmail01.AutoSize = true;
            this.lblEmail01.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail01.ForeColor = System.Drawing.Color.Navy;
            this.lblEmail01.Location = new System.Drawing.Point(6, 28);
            this.lblEmail01.Name = "lblEmail01";
            this.lblEmail01.Size = new System.Drawing.Size(60, 19);
            this.lblEmail01.TabIndex = 0;
            this.lblEmail01.Text = "Email 01:";
            this.lblEmail01.UseCustomForeColor = true;
            // 
            // grbNumerosContacto
            // 
            this.grbNumerosContacto.BackColor = System.Drawing.Color.Transparent;
            this.grbNumerosContacto.Controls.Add(this.txtTelfFijo02);
            this.grbNumerosContacto.Controls.Add(this.txtCelular02);
            this.grbNumerosContacto.Controls.Add(this.txtTelfFijo01);
            this.grbNumerosContacto.Controls.Add(this.lblCelular02);
            this.grbNumerosContacto.Controls.Add(this.lblTelFijo02);
            this.grbNumerosContacto.Controls.Add(this.txtCelular03);
            this.grbNumerosContacto.Controls.Add(this.lblTelFijo01);
            this.grbNumerosContacto.Controls.Add(this.lblCelular03);
            this.grbNumerosContacto.Controls.Add(this.txtTelfFijo03);
            this.grbNumerosContacto.Controls.Add(this.lblTelFijo03);
            this.grbNumerosContacto.Controls.Add(this.txtCelular01);
            this.grbNumerosContacto.Controls.Add(this.lblCelular01);
            this.grbNumerosContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbNumerosContacto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNumerosContacto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbNumerosContacto.Location = new System.Drawing.Point(3, 146);
            this.grbNumerosContacto.Name = "grbNumerosContacto";
            this.grbNumerosContacto.Size = new System.Drawing.Size(555, 129);
            this.grbNumerosContacto.TabIndex = 1;
            this.grbNumerosContacto.TabStop = false;
            this.grbNumerosContacto.Text = "Celulares y teléfonos";
            // 
            // txtTelfFijo02
            // 
            this.txtTelfFijo02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtTelfFijo02.CustomButton.Image = null;
            this.txtTelfFijo02.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtTelfFijo02.CustomButton.Name = "";
            this.txtTelfFijo02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelfFijo02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelfFijo02.CustomButton.TabIndex = 1;
            this.txtTelfFijo02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelfFijo02.CustomButton.UseSelectable = true;
            this.txtTelfFijo02.CustomButton.Visible = false;
            this.txtTelfFijo02.Lines = new string[0];
            this.txtTelfFijo02.Location = new System.Drawing.Point(381, 60);
            this.txtTelfFijo02.MaxLength = 32767;
            this.txtTelfFijo02.Name = "txtTelfFijo02";
            this.txtTelfFijo02.PasswordChar = '\0';
            this.txtTelfFijo02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelfFijo02.SelectedText = "";
            this.txtTelfFijo02.SelectionLength = 0;
            this.txtTelfFijo02.SelectionStart = 0;
            this.txtTelfFijo02.ShortcutsEnabled = true;
            this.txtTelfFijo02.Size = new System.Drawing.Size(156, 23);
            this.txtTelfFijo02.TabIndex = 4;
            this.txtTelfFijo02.UseCustomBackColor = true;
            this.txtTelfFijo02.UseSelectable = true;
            this.txtTelfFijo02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelfFijo02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelfFijo02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtCelular02
            // 
            this.txtCelular02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCelular02.CustomButton.Image = null;
            this.txtCelular02.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtCelular02.CustomButton.Name = "";
            this.txtCelular02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCelular02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular02.CustomButton.TabIndex = 1;
            this.txtCelular02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCelular02.CustomButton.UseSelectable = true;
            this.txtCelular02.CustomButton.Visible = false;
            this.txtCelular02.Lines = new string[0];
            this.txtCelular02.Location = new System.Drawing.Point(91, 60);
            this.txtCelular02.MaxLength = 32767;
            this.txtCelular02.Name = "txtCelular02";
            this.txtCelular02.PasswordChar = '\0';
            this.txtCelular02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCelular02.SelectedText = "";
            this.txtCelular02.SelectionLength = 0;
            this.txtCelular02.SelectionStart = 0;
            this.txtCelular02.ShortcutsEnabled = true;
            this.txtCelular02.Size = new System.Drawing.Size(156, 23);
            this.txtCelular02.TabIndex = 1;
            this.txtCelular02.UseCustomBackColor = true;
            this.txtCelular02.UseSelectable = true;
            this.txtCelular02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCelular02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtTelfFijo01
            // 
            this.txtTelfFijo01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtTelfFijo01.CustomButton.Image = null;
            this.txtTelfFijo01.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtTelfFijo01.CustomButton.Name = "";
            this.txtTelfFijo01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelfFijo01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelfFijo01.CustomButton.TabIndex = 1;
            this.txtTelfFijo01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelfFijo01.CustomButton.UseSelectable = true;
            this.txtTelfFijo01.CustomButton.Visible = false;
            this.txtTelfFijo01.Lines = new string[0];
            this.txtTelfFijo01.Location = new System.Drawing.Point(381, 26);
            this.txtTelfFijo01.MaxLength = 32767;
            this.txtTelfFijo01.Name = "txtTelfFijo01";
            this.txtTelfFijo01.PasswordChar = '\0';
            this.txtTelfFijo01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelfFijo01.SelectedText = "";
            this.txtTelfFijo01.SelectionLength = 0;
            this.txtTelfFijo01.SelectionStart = 0;
            this.txtTelfFijo01.ShortcutsEnabled = true;
            this.txtTelfFijo01.Size = new System.Drawing.Size(156, 23);
            this.txtTelfFijo01.TabIndex = 3;
            this.txtTelfFijo01.UseCustomBackColor = true;
            this.txtTelfFijo01.UseSelectable = true;
            this.txtTelfFijo01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelfFijo01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelfFijo01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCelular02
            // 
            this.lblCelular02.AutoSize = true;
            this.lblCelular02.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular02.ForeColor = System.Drawing.Color.Navy;
            this.lblCelular02.Location = new System.Drawing.Point(6, 62);
            this.lblCelular02.Name = "lblCelular02";
            this.lblCelular02.Size = new System.Drawing.Size(71, 19);
            this.lblCelular02.TabIndex = 2;
            this.lblCelular02.Text = "Celular 02:";
            this.lblCelular02.UseCustomForeColor = true;
            // 
            // lblTelFijo02
            // 
            this.lblTelFijo02.AutoSize = true;
            this.lblTelFijo02.BackColor = System.Drawing.Color.Transparent;
            this.lblTelFijo02.ForeColor = System.Drawing.Color.Navy;
            this.lblTelFijo02.Location = new System.Drawing.Point(294, 62);
            this.lblTelFijo02.Name = "lblTelFijo02";
            this.lblTelFijo02.Size = new System.Drawing.Size(76, 19);
            this.lblTelFijo02.TabIndex = 2;
            this.lblTelFijo02.Text = "Telf. Fijo 02:";
            this.lblTelFijo02.UseCustomForeColor = true;
            // 
            // txtCelular03
            // 
            this.txtCelular03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCelular03.CustomButton.Image = null;
            this.txtCelular03.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtCelular03.CustomButton.Name = "";
            this.txtCelular03.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCelular03.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular03.CustomButton.TabIndex = 1;
            this.txtCelular03.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCelular03.CustomButton.UseSelectable = true;
            this.txtCelular03.CustomButton.Visible = false;
            this.txtCelular03.Lines = new string[0];
            this.txtCelular03.Location = new System.Drawing.Point(91, 93);
            this.txtCelular03.MaxLength = 32767;
            this.txtCelular03.Name = "txtCelular03";
            this.txtCelular03.PasswordChar = '\0';
            this.txtCelular03.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCelular03.SelectedText = "";
            this.txtCelular03.SelectionLength = 0;
            this.txtCelular03.SelectionStart = 0;
            this.txtCelular03.ShortcutsEnabled = true;
            this.txtCelular03.Size = new System.Drawing.Size(156, 23);
            this.txtCelular03.TabIndex = 2;
            this.txtCelular03.UseCustomBackColor = true;
            this.txtCelular03.UseSelectable = true;
            this.txtCelular03.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCelular03.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular03.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblTelFijo01
            // 
            this.lblTelFijo01.AutoSize = true;
            this.lblTelFijo01.BackColor = System.Drawing.Color.Transparent;
            this.lblTelFijo01.ForeColor = System.Drawing.Color.Navy;
            this.lblTelFijo01.Location = new System.Drawing.Point(296, 30);
            this.lblTelFijo01.Name = "lblTelFijo01";
            this.lblTelFijo01.Size = new System.Drawing.Size(74, 19);
            this.lblTelFijo01.TabIndex = 0;
            this.lblTelFijo01.Text = "Telf. Fijo 01:";
            this.lblTelFijo01.UseCustomForeColor = true;
            // 
            // lblCelular03
            // 
            this.lblCelular03.AutoSize = true;
            this.lblCelular03.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular03.ForeColor = System.Drawing.Color.Navy;
            this.lblCelular03.Location = new System.Drawing.Point(6, 95);
            this.lblCelular03.Name = "lblCelular03";
            this.lblCelular03.Size = new System.Drawing.Size(71, 19);
            this.lblCelular03.TabIndex = 4;
            this.lblCelular03.Text = "Celular 03:";
            this.lblCelular03.UseCustomForeColor = true;
            // 
            // txtTelfFijo03
            // 
            this.txtTelfFijo03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtTelfFijo03.CustomButton.Image = null;
            this.txtTelfFijo03.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtTelfFijo03.CustomButton.Name = "";
            this.txtTelfFijo03.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelfFijo03.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelfFijo03.CustomButton.TabIndex = 1;
            this.txtTelfFijo03.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelfFijo03.CustomButton.UseSelectable = true;
            this.txtTelfFijo03.CustomButton.Visible = false;
            this.txtTelfFijo03.Lines = new string[0];
            this.txtTelfFijo03.Location = new System.Drawing.Point(381, 93);
            this.txtTelfFijo03.MaxLength = 32767;
            this.txtTelfFijo03.Name = "txtTelfFijo03";
            this.txtTelfFijo03.PasswordChar = '\0';
            this.txtTelfFijo03.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelfFijo03.SelectedText = "";
            this.txtTelfFijo03.SelectionLength = 0;
            this.txtTelfFijo03.SelectionStart = 0;
            this.txtTelfFijo03.ShortcutsEnabled = true;
            this.txtTelfFijo03.Size = new System.Drawing.Size(156, 23);
            this.txtTelfFijo03.TabIndex = 5;
            this.txtTelfFijo03.UseCustomBackColor = true;
            this.txtTelfFijo03.UseSelectable = true;
            this.txtTelfFijo03.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelfFijo03.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelfFijo03.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblTelFijo03
            // 
            this.lblTelFijo03.AutoSize = true;
            this.lblTelFijo03.BackColor = System.Drawing.Color.Transparent;
            this.lblTelFijo03.ForeColor = System.Drawing.Color.Navy;
            this.lblTelFijo03.Location = new System.Drawing.Point(294, 95);
            this.lblTelFijo03.Name = "lblTelFijo03";
            this.lblTelFijo03.Size = new System.Drawing.Size(76, 19);
            this.lblTelFijo03.TabIndex = 4;
            this.lblTelFijo03.Text = "Telf. Fijo 03:";
            this.lblTelFijo03.UseCustomForeColor = true;
            // 
            // txtCelular01
            // 
            this.txtCelular01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCelular01.CustomButton.Image = null;
            this.txtCelular01.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtCelular01.CustomButton.Name = "";
            this.txtCelular01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCelular01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular01.CustomButton.TabIndex = 1;
            this.txtCelular01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCelular01.CustomButton.UseSelectable = true;
            this.txtCelular01.CustomButton.Visible = false;
            this.txtCelular01.Lines = new string[0];
            this.txtCelular01.Location = new System.Drawing.Point(91, 26);
            this.txtCelular01.MaxLength = 32767;
            this.txtCelular01.Name = "txtCelular01";
            this.txtCelular01.PasswordChar = '\0';
            this.txtCelular01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCelular01.SelectedText = "";
            this.txtCelular01.SelectionLength = 0;
            this.txtCelular01.SelectionStart = 0;
            this.txtCelular01.ShortcutsEnabled = true;
            this.txtCelular01.Size = new System.Drawing.Size(156, 23);
            this.txtCelular01.TabIndex = 0;
            this.txtCelular01.UseCustomBackColor = true;
            this.txtCelular01.UseSelectable = true;
            this.txtCelular01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCelular01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCelular01
            // 
            this.lblCelular01.AutoSize = true;
            this.lblCelular01.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular01.ForeColor = System.Drawing.Color.Navy;
            this.lblCelular01.Location = new System.Drawing.Point(6, 27);
            this.lblCelular01.Name = "lblCelular01";
            this.lblCelular01.Size = new System.Drawing.Size(69, 19);
            this.lblCelular01.TabIndex = 0;
            this.lblCelular01.Text = "Celular 01:";
            this.lblCelular01.UseCustomForeColor = true;
            // 
            // tabPagInfoExtra
            // 
            this.tabPagInfoExtra.Controls.Add(this.grbInfoExtra);
            this.tabPagInfoExtra.HorizontalScrollbarBarColor = true;
            this.tabPagInfoExtra.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagInfoExtra.HorizontalScrollbarSize = 10;
            this.tabPagInfoExtra.Location = new System.Drawing.Point(4, 38);
            this.tabPagInfoExtra.Name = "tabPagInfoExtra";
            this.tabPagInfoExtra.Size = new System.Drawing.Size(578, 308);
            this.tabPagInfoExtra.TabIndex = 2;
            this.tabPagInfoExtra.Text = "Info. Extra";
            this.tabPagInfoExtra.VerticalScrollbarBarColor = true;
            this.tabPagInfoExtra.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagInfoExtra.VerticalScrollbarSize = 10;
            // 
            // grbInfoExtra
            // 
            this.grbInfoExtra.BackColor = System.Drawing.Color.Transparent;
            this.grbInfoExtra.Controls.Add(this.txtInfo10);
            this.grbInfoExtra.Controls.Add(this.lblInfo10);
            this.grbInfoExtra.Controls.Add(this.txtInfo08);
            this.grbInfoExtra.Controls.Add(this.lblInfo08);
            this.grbInfoExtra.Controls.Add(this.txtInfo09);
            this.grbInfoExtra.Controls.Add(this.lblInfo09);
            this.grbInfoExtra.Controls.Add(this.txtInfo07);
            this.grbInfoExtra.Controls.Add(this.lblInfo07);
            this.grbInfoExtra.Controls.Add(this.txtInfo05);
            this.grbInfoExtra.Controls.Add(this.lblInfo05);
            this.grbInfoExtra.Controls.Add(this.txtInfo06);
            this.grbInfoExtra.Controls.Add(this.lblInfo06);
            this.grbInfoExtra.Controls.Add(this.txtInfo04);
            this.grbInfoExtra.Controls.Add(this.lblInfo04);
            this.grbInfoExtra.Controls.Add(this.txtInfo02);
            this.grbInfoExtra.Controls.Add(this.lblInfo02);
            this.grbInfoExtra.Controls.Add(this.txtInfo03);
            this.grbInfoExtra.Controls.Add(this.lblInfo03);
            this.grbInfoExtra.Controls.Add(this.txtInfo01);
            this.grbInfoExtra.Controls.Add(this.lblInfo01);
            this.grbInfoExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbInfoExtra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoExtra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbInfoExtra.Location = new System.Drawing.Point(3, 9);
            this.grbInfoExtra.Name = "grbInfoExtra";
            this.grbInfoExtra.Size = new System.Drawing.Size(555, 201);
            this.grbInfoExtra.TabIndex = 0;
            this.grbInfoExtra.TabStop = false;
            this.grbInfoExtra.Text = "Agregue la información extra que necesite";
            // 
            // txtInfo10
            // 
            this.txtInfo10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo10.CustomButton.Image = null;
            this.txtInfo10.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo10.CustomButton.Name = "";
            this.txtInfo10.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo10.CustomButton.TabIndex = 1;
            this.txtInfo10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo10.CustomButton.UseSelectable = true;
            this.txtInfo10.CustomButton.Visible = false;
            this.txtInfo10.Lines = new string[0];
            this.txtInfo10.Location = new System.Drawing.Point(353, 165);
            this.txtInfo10.MaxLength = 32767;
            this.txtInfo10.Name = "txtInfo10";
            this.txtInfo10.PasswordChar = '\0';
            this.txtInfo10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo10.SelectedText = "";
            this.txtInfo10.SelectionLength = 0;
            this.txtInfo10.SelectionStart = 0;
            this.txtInfo10.ShortcutsEnabled = true;
            this.txtInfo10.Size = new System.Drawing.Size(184, 23);
            this.txtInfo10.TabIndex = 9;
            this.txtInfo10.UseCustomBackColor = true;
            this.txtInfo10.UseSelectable = true;
            this.txtInfo10.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo10.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo10.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo10
            // 
            this.lblInfo10.AutoSize = true;
            this.lblInfo10.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo10.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo10.Location = new System.Drawing.Point(292, 167);
            this.lblInfo10.Name = "lblInfo10";
            this.lblInfo10.Size = new System.Drawing.Size(53, 19);
            this.lblInfo10.TabIndex = 18;
            this.lblInfo10.Text = "Info. 10:";
            this.lblInfo10.UseCustomForeColor = true;
            // 
            // txtInfo08
            // 
            this.txtInfo08.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo08.CustomButton.Image = null;
            this.txtInfo08.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo08.CustomButton.Name = "";
            this.txtInfo08.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo08.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo08.CustomButton.TabIndex = 1;
            this.txtInfo08.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo08.CustomButton.UseSelectable = true;
            this.txtInfo08.CustomButton.Visible = false;
            this.txtInfo08.Lines = new string[0];
            this.txtInfo08.Location = new System.Drawing.Point(353, 97);
            this.txtInfo08.MaxLength = 32767;
            this.txtInfo08.Name = "txtInfo08";
            this.txtInfo08.PasswordChar = '\0';
            this.txtInfo08.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo08.SelectedText = "";
            this.txtInfo08.SelectionLength = 0;
            this.txtInfo08.SelectionStart = 0;
            this.txtInfo08.ShortcutsEnabled = true;
            this.txtInfo08.Size = new System.Drawing.Size(184, 23);
            this.txtInfo08.TabIndex = 7;
            this.txtInfo08.UseCustomBackColor = true;
            this.txtInfo08.UseSelectable = true;
            this.txtInfo08.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo08.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo08.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo08
            // 
            this.lblInfo08.AutoSize = true;
            this.lblInfo08.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo08.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo08.Location = new System.Drawing.Point(292, 99);
            this.lblInfo08.Name = "lblInfo08";
            this.lblInfo08.Size = new System.Drawing.Size(55, 19);
            this.lblInfo08.TabIndex = 14;
            this.lblInfo08.Text = "Info. 08:";
            this.lblInfo08.UseCustomForeColor = true;
            // 
            // txtInfo09
            // 
            this.txtInfo09.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo09.CustomButton.Image = null;
            this.txtInfo09.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo09.CustomButton.Name = "";
            this.txtInfo09.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo09.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo09.CustomButton.TabIndex = 1;
            this.txtInfo09.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo09.CustomButton.UseSelectable = true;
            this.txtInfo09.CustomButton.Visible = false;
            this.txtInfo09.Lines = new string[0];
            this.txtInfo09.Location = new System.Drawing.Point(353, 131);
            this.txtInfo09.MaxLength = 32767;
            this.txtInfo09.Name = "txtInfo09";
            this.txtInfo09.PasswordChar = '\0';
            this.txtInfo09.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo09.SelectedText = "";
            this.txtInfo09.SelectionLength = 0;
            this.txtInfo09.SelectionStart = 0;
            this.txtInfo09.ShortcutsEnabled = true;
            this.txtInfo09.Size = new System.Drawing.Size(184, 23);
            this.txtInfo09.TabIndex = 8;
            this.txtInfo09.UseCustomBackColor = true;
            this.txtInfo09.UseSelectable = true;
            this.txtInfo09.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo09.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo09.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo09
            // 
            this.lblInfo09.AutoSize = true;
            this.lblInfo09.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo09.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo09.Location = new System.Drawing.Point(292, 133);
            this.lblInfo09.Name = "lblInfo09";
            this.lblInfo09.Size = new System.Drawing.Size(55, 19);
            this.lblInfo09.TabIndex = 16;
            this.lblInfo09.Text = "Info. 09:";
            this.lblInfo09.UseCustomForeColor = true;
            // 
            // txtInfo07
            // 
            this.txtInfo07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo07.CustomButton.Image = null;
            this.txtInfo07.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo07.CustomButton.Name = "";
            this.txtInfo07.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo07.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo07.CustomButton.TabIndex = 1;
            this.txtInfo07.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo07.CustomButton.UseSelectable = true;
            this.txtInfo07.CustomButton.Visible = false;
            this.txtInfo07.Lines = new string[0];
            this.txtInfo07.Location = new System.Drawing.Point(353, 63);
            this.txtInfo07.MaxLength = 32767;
            this.txtInfo07.Name = "txtInfo07";
            this.txtInfo07.PasswordChar = '\0';
            this.txtInfo07.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo07.SelectedText = "";
            this.txtInfo07.SelectionLength = 0;
            this.txtInfo07.SelectionStart = 0;
            this.txtInfo07.ShortcutsEnabled = true;
            this.txtInfo07.Size = new System.Drawing.Size(184, 23);
            this.txtInfo07.TabIndex = 6;
            this.txtInfo07.UseCustomBackColor = true;
            this.txtInfo07.UseSelectable = true;
            this.txtInfo07.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo07.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo07.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo07
            // 
            this.lblInfo07.AutoSize = true;
            this.lblInfo07.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo07.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo07.Location = new System.Drawing.Point(292, 65);
            this.lblInfo07.Name = "lblInfo07";
            this.lblInfo07.Size = new System.Drawing.Size(55, 19);
            this.lblInfo07.TabIndex = 12;
            this.lblInfo07.Text = "Info. 07:";
            this.lblInfo07.UseCustomForeColor = true;
            // 
            // txtInfo05
            // 
            this.txtInfo05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo05.CustomButton.Image = null;
            this.txtInfo05.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo05.CustomButton.Name = "";
            this.txtInfo05.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo05.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo05.CustomButton.TabIndex = 1;
            this.txtInfo05.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo05.CustomButton.UseSelectable = true;
            this.txtInfo05.CustomButton.Visible = false;
            this.txtInfo05.Lines = new string[0];
            this.txtInfo05.Location = new System.Drawing.Point(74, 165);
            this.txtInfo05.MaxLength = 32767;
            this.txtInfo05.Name = "txtInfo05";
            this.txtInfo05.PasswordChar = '\0';
            this.txtInfo05.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo05.SelectedText = "";
            this.txtInfo05.SelectionLength = 0;
            this.txtInfo05.SelectionStart = 0;
            this.txtInfo05.ShortcutsEnabled = true;
            this.txtInfo05.Size = new System.Drawing.Size(184, 23);
            this.txtInfo05.TabIndex = 4;
            this.txtInfo05.UseCustomBackColor = true;
            this.txtInfo05.UseSelectable = true;
            this.txtInfo05.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo05.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo05.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo05
            // 
            this.lblInfo05.AutoSize = true;
            this.lblInfo05.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo05.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo05.Location = new System.Drawing.Point(13, 167);
            this.lblInfo05.Name = "lblInfo05";
            this.lblInfo05.Size = new System.Drawing.Size(55, 19);
            this.lblInfo05.TabIndex = 8;
            this.lblInfo05.Text = "Info. 05:";
            this.lblInfo05.UseCustomForeColor = true;
            // 
            // txtInfo06
            // 
            this.txtInfo06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo06.CustomButton.Image = null;
            this.txtInfo06.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo06.CustomButton.Name = "";
            this.txtInfo06.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo06.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo06.CustomButton.TabIndex = 1;
            this.txtInfo06.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo06.CustomButton.UseSelectable = true;
            this.txtInfo06.CustomButton.Visible = false;
            this.txtInfo06.Lines = new string[0];
            this.txtInfo06.Location = new System.Drawing.Point(353, 29);
            this.txtInfo06.MaxLength = 32767;
            this.txtInfo06.Name = "txtInfo06";
            this.txtInfo06.PasswordChar = '\0';
            this.txtInfo06.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo06.SelectedText = "";
            this.txtInfo06.SelectionLength = 0;
            this.txtInfo06.SelectionStart = 0;
            this.txtInfo06.ShortcutsEnabled = true;
            this.txtInfo06.Size = new System.Drawing.Size(184, 23);
            this.txtInfo06.TabIndex = 5;
            this.txtInfo06.UseCustomBackColor = true;
            this.txtInfo06.UseSelectable = true;
            this.txtInfo06.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo06.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo06.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo06
            // 
            this.lblInfo06.AutoSize = true;
            this.lblInfo06.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo06.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo06.Location = new System.Drawing.Point(292, 31);
            this.lblInfo06.Name = "lblInfo06";
            this.lblInfo06.Size = new System.Drawing.Size(55, 19);
            this.lblInfo06.TabIndex = 10;
            this.lblInfo06.Text = "Info. 06:";
            this.lblInfo06.UseCustomForeColor = true;
            // 
            // txtInfo04
            // 
            this.txtInfo04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo04.CustomButton.Image = null;
            this.txtInfo04.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo04.CustomButton.Name = "";
            this.txtInfo04.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo04.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo04.CustomButton.TabIndex = 1;
            this.txtInfo04.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo04.CustomButton.UseSelectable = true;
            this.txtInfo04.CustomButton.Visible = false;
            this.txtInfo04.Lines = new string[0];
            this.txtInfo04.Location = new System.Drawing.Point(74, 131);
            this.txtInfo04.MaxLength = 32767;
            this.txtInfo04.Name = "txtInfo04";
            this.txtInfo04.PasswordChar = '\0';
            this.txtInfo04.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo04.SelectedText = "";
            this.txtInfo04.SelectionLength = 0;
            this.txtInfo04.SelectionStart = 0;
            this.txtInfo04.ShortcutsEnabled = true;
            this.txtInfo04.Size = new System.Drawing.Size(184, 23);
            this.txtInfo04.TabIndex = 3;
            this.txtInfo04.UseCustomBackColor = true;
            this.txtInfo04.UseSelectable = true;
            this.txtInfo04.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo04.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo04.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo04
            // 
            this.lblInfo04.AutoSize = true;
            this.lblInfo04.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo04.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo04.Location = new System.Drawing.Point(13, 133);
            this.lblInfo04.Name = "lblInfo04";
            this.lblInfo04.Size = new System.Drawing.Size(55, 19);
            this.lblInfo04.TabIndex = 6;
            this.lblInfo04.Text = "Info. 04:";
            this.lblInfo04.UseCustomForeColor = true;
            // 
            // txtInfo02
            // 
            this.txtInfo02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo02.CustomButton.Image = null;
            this.txtInfo02.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo02.CustomButton.Name = "";
            this.txtInfo02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo02.CustomButton.TabIndex = 1;
            this.txtInfo02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo02.CustomButton.UseSelectable = true;
            this.txtInfo02.CustomButton.Visible = false;
            this.txtInfo02.Lines = new string[0];
            this.txtInfo02.Location = new System.Drawing.Point(74, 63);
            this.txtInfo02.MaxLength = 32767;
            this.txtInfo02.Name = "txtInfo02";
            this.txtInfo02.PasswordChar = '\0';
            this.txtInfo02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo02.SelectedText = "";
            this.txtInfo02.SelectionLength = 0;
            this.txtInfo02.SelectionStart = 0;
            this.txtInfo02.ShortcutsEnabled = true;
            this.txtInfo02.Size = new System.Drawing.Size(184, 23);
            this.txtInfo02.TabIndex = 1;
            this.txtInfo02.UseCustomBackColor = true;
            this.txtInfo02.UseSelectable = true;
            this.txtInfo02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo02
            // 
            this.lblInfo02.AutoSize = true;
            this.lblInfo02.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo02.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo02.Location = new System.Drawing.Point(13, 65);
            this.lblInfo02.Name = "lblInfo02";
            this.lblInfo02.Size = new System.Drawing.Size(55, 19);
            this.lblInfo02.TabIndex = 2;
            this.lblInfo02.Text = "Info. 02:";
            this.lblInfo02.UseCustomForeColor = true;
            // 
            // txtInfo03
            // 
            this.txtInfo03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo03.CustomButton.Image = null;
            this.txtInfo03.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo03.CustomButton.Name = "";
            this.txtInfo03.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo03.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo03.CustomButton.TabIndex = 1;
            this.txtInfo03.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo03.CustomButton.UseSelectable = true;
            this.txtInfo03.CustomButton.Visible = false;
            this.txtInfo03.Lines = new string[0];
            this.txtInfo03.Location = new System.Drawing.Point(74, 97);
            this.txtInfo03.MaxLength = 32767;
            this.txtInfo03.Name = "txtInfo03";
            this.txtInfo03.PasswordChar = '\0';
            this.txtInfo03.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo03.SelectedText = "";
            this.txtInfo03.SelectionLength = 0;
            this.txtInfo03.SelectionStart = 0;
            this.txtInfo03.ShortcutsEnabled = true;
            this.txtInfo03.Size = new System.Drawing.Size(184, 23);
            this.txtInfo03.TabIndex = 2;
            this.txtInfo03.UseCustomBackColor = true;
            this.txtInfo03.UseSelectable = true;
            this.txtInfo03.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo03.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo03.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo03
            // 
            this.lblInfo03.AutoSize = true;
            this.lblInfo03.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo03.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo03.Location = new System.Drawing.Point(13, 99);
            this.lblInfo03.Name = "lblInfo03";
            this.lblInfo03.Size = new System.Drawing.Size(55, 19);
            this.lblInfo03.TabIndex = 4;
            this.lblInfo03.Text = "Info. 03:";
            this.lblInfo03.UseCustomForeColor = true;
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
            this.txtInfo01.Location = new System.Drawing.Point(74, 29);
            this.txtInfo01.MaxLength = 32767;
            this.txtInfo01.Name = "txtInfo01";
            this.txtInfo01.PasswordChar = '\0';
            this.txtInfo01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo01.SelectedText = "";
            this.txtInfo01.SelectionLength = 0;
            this.txtInfo01.SelectionStart = 0;
            this.txtInfo01.ShortcutsEnabled = true;
            this.txtInfo01.Size = new System.Drawing.Size(184, 23);
            this.txtInfo01.TabIndex = 0;
            this.txtInfo01.UseCustomBackColor = true;
            this.txtInfo01.UseSelectable = true;
            this.txtInfo01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo01
            // 
            this.lblInfo01.AutoSize = true;
            this.lblInfo01.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo01.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo01.Location = new System.Drawing.Point(15, 31);
            this.lblInfo01.Name = "lblInfo01";
            this.lblInfo01.Size = new System.Drawing.Size(53, 19);
            this.lblInfo01.TabIndex = 0;
            this.lblInfo01.Text = "Info. 01:";
            this.lblInfo01.UseCustomForeColor = true;
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(95, 32);
            this.lblNombreForm.TabIndex = 62;
            this.lblNombreForm.Text = "Clientes";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(28, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.panelMantenimiento.Location = new System.Drawing.Point(408, 36);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(572, 49);
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
            this.btnSearch.Location = new System.Drawing.Point(5, 5);
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
            this.btnNuevo.Location = new System.Drawing.Point(399, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 2;
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
            this.btnRollback.Location = new System.Drawing.Point(525, 5);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(40, 40);
            this.btnRollback.TabIndex = 1;
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
            this.btnCommit.Location = new System.Drawing.Point(483, 5);
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
            this.btnDelete.Location = new System.Drawing.Point(441, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.ForeColor = System.Drawing.Color.Navy;
            this.lblIdCliente.Location = new System.Drawing.Point(488, 13);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(0, 0);
            this.lblIdCliente.TabIndex = 107;
            this.lblIdCliente.UseCustomForeColor = true;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToResizeColumns = false;
            this.dgvCliente.AllowUserToResizeRows = false;
            this.dgvCliente.BackgroundColor = System.Drawing.Color.White;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCliente.Location = new System.Drawing.Point(37, 129);
            this.dgvCliente.MultiSelect = false;
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCliente.RowHeadersVisible = false;
            this.dgvCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCliente.Size = new System.Drawing.Size(320, 339);
            this.dgvCliente.TabIndex = 0;
            this.dgvCliente.SelectionChanged += new System.EventHandler(this.dgvCliente_SelectionChanged);
            this.dgvCliente.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvBordered_Paint);
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(180, 471);
            this.lblNumInactivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumInactivo.Name = "lblNumInactivo";
            this.lblNumInactivo.Size = new System.Drawing.Size(65, 17);
            this.lblNumInactivo.TabIndex = 113;
            this.lblNumInactivo.Text = "Inactivos: ";
            // 
            // lblNumActivo
            // 
            this.lblNumActivo.AutoSize = true;
            this.lblNumActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumActivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActivo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNumActivo.Location = new System.Drawing.Point(100, 471);
            this.lblNumActivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumActivo.Name = "lblNumActivo";
            this.lblNumActivo.Size = new System.Drawing.Size(56, 17);
            this.lblNumActivo.TabIndex = 112;
            this.lblNumActivo.Text = "Activos: ";
            // 
            // lblNumReg
            // 
            this.lblNumReg.AutoSize = true;
            this.lblNumReg.BackColor = System.Drawing.Color.Transparent;
            this.lblNumReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumReg.Location = new System.Drawing.Point(33, 471);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 111;
            this.lblNumReg.Text = "Total: ";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 518);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.tabCliente);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panelMantenimiento);
            this.MaximizeBox = false;
            this.Name = "FormCliente";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.tabCliente.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            this.tabPagDireccion.ResumeLayout(false);
            this.grbUbicacionDetallada.ResumeLayout(false);
            this.grbUbicacionDetallada.PerformLayout();
            this.gbrUbigeo.ResumeLayout(false);
            this.gbrUbigeo.PerformLayout();
            this.tabPagContacto.ResumeLayout(false);
            this.grbEmailYWeb.ResumeLayout(false);
            this.grbEmailYWeb.PerformLayout();
            this.grbNumerosContacto.ResumeLayout(false);
            this.grbNumerosContacto.PerformLayout();
            this.tabPagInfoExtra.ResumeLayout(false);
            this.grbInfoExtra.ResumeLayout(false);
            this.grbInfoExtra.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroToggle tglListarInactivos;
        private MetroFramework.Controls.MetroLabel lblListarInactivos;
        private MetroFramework.Controls.MetroPanel panelFiltro;
        private MetroFramework.Controls.MetroLabel lblFiltro;
        private System.Windows.Forms.Button btnFilter;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private BorderedCombo cboFiltro;
        private MetroFramework.Controls.MetroTabControl tabCliente;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroTextBox txtNumRuc;
        private MetroFramework.Controls.MetroLabel lblNumRuc;
        private MetroFramework.Controls.MetroTextBox txtNumDoc;
        private MetroFramework.Controls.MetroLabel lblNumDoc;
        private BorderedCombo cboTipoDocIdentidad;
        private MetroFramework.Controls.MetroLabel lblTipoDocIdentidad;
        private MetroFramework.Controls.MetroTextBox txtNomComercial;
        private MetroFramework.Controls.MetroLabel lblNomComercial;
        private MetroFramework.Controls.MetroTextBox txtRazonSocial;
        private MetroFramework.Controls.MetroLabel lblRazonSocial;
        private MetroFramework.Controls.MetroLabel lblSexo;
        private MetroFramework.Controls.MetroRadioButton rbtFemenino;
        private MetroFramework.Controls.MetroRadioButton rbtMasculino;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lblFechaNac;
        private BorderedCombo cboEstadoCivil;
        private MetroFramework.Controls.MetroLabel lblEstadoCivil;
        private MetroFramework.Controls.MetroTextBox txtSegundoNom;
        private MetroFramework.Controls.MetroLabel lblSegundoNom;
        private MetroFramework.Controls.MetroTextBox txtApMaterno;
        private MetroFramework.Controls.MetroLabel lblApMaterno;
        private MetroFramework.Controls.MetroTextBox txtPrimerNom;
        private MetroFramework.Controls.MetroLabel lblPrimerNom;
        private MetroFramework.Controls.MetroTextBox txtApPaterno;
        private MetroFramework.Controls.MetroLabel lblApPaterno;
        private MetroFramework.Controls.MetroTabPage tabPagContacto;
        private MetroFramework.Controls.MetroTabPage tabPagInfoExtra;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private MetroFramework.Controls.MetroPanel panelMantenimiento;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnDelete;
        private MetroFramework.Controls.MetroLabel lblIdCliente;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private MetroFramework.Controls.MetroTabPage tabPagDireccion;
        private System.Windows.Forms.GroupBox grbUbicacionDetallada;
        private MetroFramework.Controls.MetroTextBox txtDireccion01;
        private MetroFramework.Controls.MetroLabel lblDireccion02;
        private MetroFramework.Controls.MetroLabel lblDireccion01;
        private MetroFramework.Controls.MetroTextBox txtDireccion02;
        private MetroFramework.Controls.MetroTextBox txtNomZona;
        private MetroFramework.Controls.MetroLabel lblNomZona;
        private MetroFramework.Controls.MetroTextBox txtNomVia;
        private MetroFramework.Controls.MetroLabel lblZona;
        private BorderedCombo cboZona;
        private MetroFramework.Controls.MetroTextBox txtReferencia;
        private MetroFramework.Controls.MetroLabel lblNomVia;
        private MetroFramework.Controls.MetroLabel lblReferencia;
        private MetroFramework.Controls.MetroTextBox txtNumVia;
        private MetroFramework.Controls.MetroLabel lblVia;
        private BorderedCombo cboVia;
        private MetroFramework.Controls.MetroLabel lblNumVia;
        private System.Windows.Forms.GroupBox gbrUbigeo;
        private MetroFramework.Controls.MetroLabel lblDepartamento;
        private BorderedCombo cboDepartamento;
        private BorderedCombo cboDistrito;
        private MetroFramework.Controls.MetroLabel lblDistrito;
        private MetroFramework.Controls.MetroLabel lblNacionalidad;
        private MetroFramework.Controls.MetroLabel lblProvincia;
        private BorderedCombo cboNacionalidad;
        private BorderedCombo cboProvincia;
        private System.Windows.Forms.GroupBox grbEmailYWeb;
        private MetroFramework.Controls.MetroTextBox txtEmail02;
        private MetroFramework.Controls.MetroLabel lblEmail02;
        private MetroFramework.Controls.MetroTextBox txtPagWeb;
        private MetroFramework.Controls.MetroLabel lblPagWeb;
        private MetroFramework.Controls.MetroTextBox txtEmail01;
        private MetroFramework.Controls.MetroLabel lblEmail01;
        private System.Windows.Forms.GroupBox grbNumerosContacto;
        private MetroFramework.Controls.MetroTextBox txtTelfFijo02;
        private MetroFramework.Controls.MetroTextBox txtCelular02;
        private MetroFramework.Controls.MetroTextBox txtTelfFijo01;
        private MetroFramework.Controls.MetroLabel lblCelular02;
        private MetroFramework.Controls.MetroLabel lblTelFijo02;
        private MetroFramework.Controls.MetroTextBox txtCelular03;
        private MetroFramework.Controls.MetroLabel lblTelFijo01;
        private MetroFramework.Controls.MetroLabel lblCelular03;
        private MetroFramework.Controls.MetroTextBox txtTelfFijo03;
        private MetroFramework.Controls.MetroLabel lblTelFijo03;
        private MetroFramework.Controls.MetroTextBox txtCelular01;
        private MetroFramework.Controls.MetroLabel lblCelular01;
        private System.Windows.Forms.GroupBox grbInfoExtra;
        private MetroFramework.Controls.MetroTextBox txtInfo10;
        private MetroFramework.Controls.MetroLabel lblInfo10;
        private MetroFramework.Controls.MetroTextBox txtInfo08;
        private MetroFramework.Controls.MetroLabel lblInfo08;
        private MetroFramework.Controls.MetroTextBox txtInfo09;
        private MetroFramework.Controls.MetroLabel lblInfo09;
        private MetroFramework.Controls.MetroTextBox txtInfo07;
        private MetroFramework.Controls.MetroLabel lblInfo07;
        private MetroFramework.Controls.MetroTextBox txtInfo05;
        private MetroFramework.Controls.MetroLabel lblInfo05;
        private MetroFramework.Controls.MetroTextBox txtInfo06;
        private MetroFramework.Controls.MetroLabel lblInfo06;
        private MetroFramework.Controls.MetroTextBox txtInfo04;
        private MetroFramework.Controls.MetroLabel lblInfo04;
        private MetroFramework.Controls.MetroTextBox txtInfo02;
        private MetroFramework.Controls.MetroLabel lblInfo02;
        private MetroFramework.Controls.MetroTextBox txtInfo03;
        private MetroFramework.Controls.MetroLabel lblInfo03;
        private MetroFramework.Controls.MetroTextBox txtInfo01;
        private MetroFramework.Controls.MetroLabel lblInfo01;
    }
}