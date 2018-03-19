//namespace ConfiguradorUI.Labor
//{
//    partial class FormHorarioEmpleado
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorarioEmpleado));
//            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mesero");
//            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Cocinero");
//            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Gerente");
//            this.grbBuscarEmp = new System.Windows.Forms.GroupBox();
//            this.lblNroDocEmp = new MetroFramework.Controls.MetroLabel();
//            this.txtNroDocEmp = new MetroFramework.Controls.MetroTextBox();
//            this.btnBuscarEmp = new System.Windows.Forms.Button();
//            this.lblNombreForm = new System.Windows.Forms.Label();
//            this.mcaMes = new System.Windows.Forms.MonthCalendar();
//            this.chkSabado = new MetroFramework.Controls.MetroCheckBox();
//            this.lblDomHf = new MetroFramework.Controls.MetroLabel();
//            this.chkViernes = new MetroFramework.Controls.MetroCheckBox();
//            this.lblDomHi = new MetroFramework.Controls.MetroLabel();
//            this.chkJueves = new MetroFramework.Controls.MetroCheckBox();
//            this.chkMartes = new MetroFramework.Controls.MetroCheckBox();
//            this.chkMiercoles = new MetroFramework.Controls.MetroCheckBox();
//            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
//            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
//            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
//            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
//            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
//            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
//            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
//            this.tabHorario = new MetroFramework.Controls.MetroTabControl();
//            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
//            this.chkDomingo = new MetroFramework.Controls.MetroCheckBox();
//            this.btnNuevo = new System.Windows.Forms.Button();
//            this.btnRemoveItem = new System.Windows.Forms.Button();
//            this.chkLunes = new MetroFramework.Controls.MetroCheckBox();
//            this.dtpT7 = new System.Windows.Forms.DateTimePicker();
//            this.dtpT6 = new System.Windows.Forms.DateTimePicker();
//            this.dtpT5 = new System.Windows.Forms.DateTimePicker();
//            this.dtpT4 = new System.Windows.Forms.DateTimePicker();
//            this.dtpT3 = new System.Windows.Forms.DateTimePicker();
//            this.dtpT2 = new System.Windows.Forms.DateTimePicker();
//            this.dtpT1 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHI1 = new System.Windows.Forms.DateTimePicker();
//            this.dtpFB7 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHF1 = new System.Windows.Forms.DateTimePicker();
//            this.dtpIB7 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHI2 = new System.Windows.Forms.DateTimePicker();
//            this.dtpFB6 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHF2 = new System.Windows.Forms.DateTimePicker();
//            this.dtpIB6 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHI3 = new System.Windows.Forms.DateTimePicker();
//            this.dtpFB5 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHF3 = new System.Windows.Forms.DateTimePicker();
//            this.dtpIB5 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHI4 = new System.Windows.Forms.DateTimePicker();
//            this.dtpFB4 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHF4 = new System.Windows.Forms.DateTimePicker();
//            this.dtpIB4 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHI5 = new System.Windows.Forms.DateTimePicker();
//            this.dtpFB3 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHF5 = new System.Windows.Forms.DateTimePicker();
//            this.dtpIB3 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHI6 = new System.Windows.Forms.DateTimePicker();
//            this.dtpFB2 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHF6 = new System.Windows.Forms.DateTimePicker();
//            this.dtpIB2 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHI7 = new System.Windows.Forms.DateTimePicker();
//            this.dtpFB1 = new System.Windows.Forms.DateTimePicker();
//            this.dtpHF7 = new System.Windows.Forms.DateTimePicker();
//            this.dtpIB1 = new System.Windows.Forms.DateTimePicker();
//            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
//            this.grbDatosEmpleado = new System.Windows.Forms.GroupBox();
//            this.txtFinContrato = new MetroFramework.Controls.MetroTextBox();
//            this.txtInicioContrato = new MetroFramework.Controls.MetroTextBox();
//            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
//            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
//            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
//            this.lstTrabajo = new System.Windows.Forms.ListView();
//            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
//            this.picFotoEmp = new System.Windows.Forms.PictureBox();
//            this.lblApeNom = new MetroFramework.Controls.MetroLabel();
//            this.lblNomEmp = new System.Windows.Forms.Label();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
//            this.btnCerrar = new MetroFramework.Controls.MetroLink();
//            this.grbBuscarEmp.SuspendLayout();
//            this.tabHorario.SuspendLayout();
//            this.tabPagGeneral.SuspendLayout();
//            this.metroTabPage1.SuspendLayout();
//            this.grbDatosEmpleado.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picFotoEmp)).BeginInit();
//            this.groupBox1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // grbBuscarEmp
//            // 
//            this.grbBuscarEmp.Controls.Add(this.lblNroDocEmp);
//            this.grbBuscarEmp.Controls.Add(this.txtNroDocEmp);
//            this.grbBuscarEmp.Controls.Add(this.btnBuscarEmp);
//            this.grbBuscarEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.grbBuscarEmp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
//            this.grbBuscarEmp.Location = new System.Drawing.Point(26, 100);
//            this.grbBuscarEmp.Name = "grbBuscarEmp";
//            this.grbBuscarEmp.Size = new System.Drawing.Size(357, 65);
//            this.grbBuscarEmp.TabIndex = 115;
//            this.grbBuscarEmp.TabStop = false;
//            this.grbBuscarEmp.Text = "Buscar empleado";
//            // 
//            // lblNroDocEmp
//            // 
//            this.lblNroDocEmp.AutoSize = true;
//            this.lblNroDocEmp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
//            this.lblNroDocEmp.ForeColor = System.Drawing.Color.Navy;
//            this.lblNroDocEmp.Location = new System.Drawing.Point(8, 28);
//            this.lblNroDocEmp.Name = "lblNroDocEmp";
//            this.lblNroDocEmp.Size = new System.Drawing.Size(138, 19);
//            this.lblNroDocEmp.TabIndex = 108;
//            this.lblNroDocEmp.Text = "Número Documento:";
//            this.lblNroDocEmp.UseCustomForeColor = true;
//            // 
//            // txtNroDocEmp
//            // 
//            this.txtNroDocEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
//            // 
//            // 
//            // 
//            this.txtNroDocEmp.CustomButton.Image = null;
//            this.txtNroDocEmp.CustomButton.Location = new System.Drawing.Point(95, 1);
//            this.txtNroDocEmp.CustomButton.Name = "";
//            this.txtNroDocEmp.CustomButton.Size = new System.Drawing.Size(21, 21);
//            this.txtNroDocEmp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
//            this.txtNroDocEmp.CustomButton.TabIndex = 1;
//            this.txtNroDocEmp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
//            this.txtNroDocEmp.CustomButton.UseSelectable = true;
//            this.txtNroDocEmp.CustomButton.Visible = false;
//            this.txtNroDocEmp.Lines = new string[] {
//        "76161544"};
//            this.txtNroDocEmp.Location = new System.Drawing.Point(152, 28);
//            this.txtNroDocEmp.MaxLength = 32767;
//            this.txtNroDocEmp.Name = "txtNroDocEmp";
//            this.txtNroDocEmp.PasswordChar = '\0';
//            this.txtNroDocEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
//            this.txtNroDocEmp.SelectedText = "";
//            this.txtNroDocEmp.SelectionLength = 0;
//            this.txtNroDocEmp.SelectionStart = 0;
//            this.txtNroDocEmp.ShortcutsEnabled = true;
//            this.txtNroDocEmp.Size = new System.Drawing.Size(117, 23);
//            this.txtNroDocEmp.TabIndex = 109;
//            this.txtNroDocEmp.Text = "76161544";
//            this.txtNroDocEmp.UseCustomBackColor = true;
//            this.txtNroDocEmp.UseSelectable = true;
//            this.txtNroDocEmp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
//            this.txtNroDocEmp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
//            this.txtNroDocEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDocEmp_KeyPress);
//            // 
//            // btnBuscarEmp
//            // 
//            this.btnBuscarEmp.BackColor = System.Drawing.Color.DodgerBlue;
//            this.btnBuscarEmp.FlatAppearance.BorderColor = System.Drawing.Color.White;
//            this.btnBuscarEmp.FlatAppearance.BorderSize = 0;
//            this.btnBuscarEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
//            this.btnBuscarEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
//            this.btnBuscarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnBuscarEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnBuscarEmp.ForeColor = System.Drawing.Color.White;
//            this.btnBuscarEmp.Location = new System.Drawing.Point(274, 28);
//            this.btnBuscarEmp.Margin = new System.Windows.Forms.Padding(2);
//            this.btnBuscarEmp.Name = "btnBuscarEmp";
//            this.btnBuscarEmp.Size = new System.Drawing.Size(69, 24);
//            this.btnBuscarEmp.TabIndex = 0;
//            this.btnBuscarEmp.Text = "Buscar";
//            this.btnBuscarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
//            this.btnBuscarEmp.UseVisualStyleBackColor = false;
//            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
//            // 
//            // lblNombreForm
//            // 
//            this.lblNombreForm.AutoSize = true;
//            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
//            this.lblNombreForm.Location = new System.Drawing.Point(73, 32);
//            this.lblNombreForm.Name = "lblNombreForm";
//            this.lblNombreForm.Size = new System.Drawing.Size(167, 32);
//            this.lblNombreForm.TabIndex = 114;
//            this.lblNombreForm.Text = "Nuevo Horario";
//            // 
//            // mcaMes
//            // 
//            this.mcaMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
//            this.mcaMes.CalendarDimensions = new System.Drawing.Size(3, 1);
//            this.mcaMes.Location = new System.Drawing.Point(0, 267);
//            this.mcaMes.Name = "mcaMes";
//            this.mcaMes.TabIndex = 116;
//            // 
//            // chkSabado
//            // 
//            this.chkSabado.AutoSize = true;
//            this.chkSabado.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
//            this.chkSabado.Location = new System.Drawing.Point(19, 236);
//            this.chkSabado.Name = "chkSabado";
//            this.chkSabado.Size = new System.Drawing.Size(70, 19);
//            this.chkSabado.TabIndex = 125;
//            this.chkSabado.Text = "Sábado";
//            this.chkSabado.UseSelectable = true;
//            // 
//            // lblDomHf
//            // 
//            this.lblDomHf.AutoSize = true;
//            this.lblDomHf.ForeColor = System.Drawing.Color.Navy;
//            this.lblDomHf.Location = new System.Drawing.Point(258, 59);
//            this.lblDomHf.Name = "lblDomHf";
//            this.lblDomHf.Size = new System.Drawing.Size(59, 19);
//            this.lblDomHf.TabIndex = 119;
//            this.lblDomHf.Text = "Hora Fin";
//            this.lblDomHf.UseCustomForeColor = true;
//            // 
//            // chkViernes
//            // 
//            this.chkViernes.AutoSize = true;
//            this.chkViernes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
//            this.chkViernes.Location = new System.Drawing.Point(19, 211);
//            this.chkViernes.Name = "chkViernes";
//            this.chkViernes.Size = new System.Drawing.Size(70, 19);
//            this.chkViernes.TabIndex = 124;
//            this.chkViernes.Text = "Viernes";
//            this.chkViernes.UseSelectable = true;
//            // 
//            // lblDomHi
//            // 
//            this.lblDomHi.AutoSize = true;
//            this.lblDomHi.ForeColor = System.Drawing.Color.Navy;
//            this.lblDomHi.Location = new System.Drawing.Point(180, 59);
//            this.lblDomHi.Name = "lblDomHi";
//            this.lblDomHi.Size = new System.Drawing.Size(72, 19);
//            this.lblDomHi.TabIndex = 118;
//            this.lblDomHi.Text = "Hora Inicio";
//            this.lblDomHi.UseCustomForeColor = true;
//            // 
//            // chkJueves
//            // 
//            this.chkJueves.AutoSize = true;
//            this.chkJueves.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
//            this.chkJueves.Location = new System.Drawing.Point(19, 186);
//            this.chkJueves.Name = "chkJueves";
//            this.chkJueves.Size = new System.Drawing.Size(65, 19);
//            this.chkJueves.TabIndex = 123;
//            this.chkJueves.Text = "Jueves";
//            this.chkJueves.UseSelectable = true;
//            // 
//            // chkMartes
//            // 
//            this.chkMartes.AutoSize = true;
//            this.chkMartes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
//            this.chkMartes.Location = new System.Drawing.Point(19, 136);
//            this.chkMartes.Name = "chkMartes";
//            this.chkMartes.Size = new System.Drawing.Size(68, 19);
//            this.chkMartes.TabIndex = 121;
//            this.chkMartes.Text = "Martes";
//            this.chkMartes.UseSelectable = true;
//            // 
//            // chkMiercoles
//            // 
//            this.chkMiercoles.AutoSize = true;
//            this.chkMiercoles.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
//            this.chkMiercoles.Location = new System.Drawing.Point(19, 161);
//            this.chkMiercoles.Name = "chkMiercoles";
//            this.chkMiercoles.Size = new System.Drawing.Size(83, 19);
//            this.chkMiercoles.TabIndex = 122;
//            this.chkMiercoles.Text = "Miércoles";
//            this.chkMiercoles.UseSelectable = true;
//            // 
//            // metroLabel1
//            // 
//            this.metroLabel1.AutoSize = true;
//            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
//            this.metroLabel1.Location = new System.Drawing.Point(416, 59);
//            this.metroLabel1.Name = "metroLabel1";
//            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
//            this.metroLabel1.TabIndex = 141;
//            this.metroLabel1.Text = "Fin Break";
//            this.metroLabel1.UseCustomForeColor = true;
//            // 
//            // metroLabel2
//            // 
//            this.metroLabel2.AutoSize = true;
//            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
//            this.metroLabel2.Location = new System.Drawing.Point(338, 59);
//            this.metroLabel2.Name = "metroLabel2";
//            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
//            this.metroLabel2.TabIndex = 140;
//            this.metroLabel2.Text = "Inicio Break";
//            this.metroLabel2.UseCustomForeColor = true;
//            // 
//            // metroLabel4
//            // 
//            this.metroLabel4.AutoSize = true;
//            this.metroLabel4.ForeColor = System.Drawing.Color.Navy;
//            this.metroLabel4.Location = new System.Drawing.Point(494, 59);
//            this.metroLabel4.Name = "metroLabel4";
//            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
//            this.metroLabel4.TabIndex = 156;
//            this.metroLabel4.Text = "Tolerancia";
//            this.metroLabel4.UseCustomForeColor = true;
//            // 
//            // metroLabel3
//            // 
//            this.metroLabel3.AutoSize = true;
//            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
//            this.metroLabel3.Location = new System.Drawing.Point(4, 8);
//            this.metroLabel3.Name = "metroLabel3";
//            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
//            this.metroLabel3.TabIndex = 171;
//            this.metroLabel3.Text = "Desde:";
//            this.metroLabel3.UseCustomForeColor = true;
//            // 
//            // dtpDesde
//            // 
//            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
//            this.dtpDesde.Location = new System.Drawing.Point(6, 30);
//            this.dtpDesde.MinDate = new System.DateTime(2017, 1, 30, 0, 0, 0, 0);
//            this.dtpDesde.Name = "dtpDesde";
//            this.dtpDesde.Size = new System.Drawing.Size(96, 20);
//            this.dtpDesde.TabIndex = 172;
//            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
//            // 
//            // dtpHasta
//            // 
//            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
//            this.dtpHasta.Location = new System.Drawing.Point(122, 30);
//            this.dtpHasta.Name = "dtpHasta";
//            this.dtpHasta.Size = new System.Drawing.Size(101, 20);
//            this.dtpHasta.TabIndex = 174;
//            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
//            // 
//            // metroLabel5
//            // 
//            this.metroLabel5.AutoSize = true;
//            this.metroLabel5.ForeColor = System.Drawing.Color.Navy;
//            this.metroLabel5.Location = new System.Drawing.Point(122, 8);
//            this.metroLabel5.Name = "metroLabel5";
//            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
//            this.metroLabel5.TabIndex = 173;
//            this.metroLabel5.Text = "Hasta:";
//            this.metroLabel5.UseCustomForeColor = true;
//            // 
//            // tabHorario
//            // 
//            this.tabHorario.Controls.Add(this.tabPagGeneral);
//            this.tabHorario.Controls.Add(this.metroTabPage1);
//            this.tabHorario.Location = new System.Drawing.Point(26, 171);
//            this.tabHorario.Name = "tabHorario";
//            this.tabHorario.SelectedIndex = 0;
//            this.tabHorario.Size = new System.Drawing.Size(609, 484);
//            this.tabHorario.TabIndex = 175;
//            this.tabHorario.UseSelectable = true;
//            // 
//            // tabPagGeneral
//            // 
//            this.tabPagGeneral.Controls.Add(this.mcaMes);
//            this.tabPagGeneral.Controls.Add(this.chkDomingo);
//            this.tabPagGeneral.Controls.Add(this.btnNuevo);
//            this.tabPagGeneral.Controls.Add(this.btnRemoveItem);
//            this.tabPagGeneral.Controls.Add(this.dtpHasta);
//            this.tabPagGeneral.Controls.Add(this.metroLabel5);
//            this.tabPagGeneral.Controls.Add(this.metroLabel3);
//            this.tabPagGeneral.Controls.Add(this.dtpDesde);
//            this.tabPagGeneral.Controls.Add(this.chkLunes);
//            this.tabPagGeneral.Controls.Add(this.dtpT7);
//            this.tabPagGeneral.Controls.Add(this.chkMiercoles);
//            this.tabPagGeneral.Controls.Add(this.dtpT6);
//            this.tabPagGeneral.Controls.Add(this.chkMartes);
//            this.tabPagGeneral.Controls.Add(this.dtpT5);
//            this.tabPagGeneral.Controls.Add(this.chkJueves);
//            this.tabPagGeneral.Controls.Add(this.dtpT4);
//            this.tabPagGeneral.Controls.Add(this.lblDomHi);
//            this.tabPagGeneral.Controls.Add(this.dtpT3);
//            this.tabPagGeneral.Controls.Add(this.chkViernes);
//            this.tabPagGeneral.Controls.Add(this.dtpT2);
//            this.tabPagGeneral.Controls.Add(this.lblDomHf);
//            this.tabPagGeneral.Controls.Add(this.dtpT1);
//            this.tabPagGeneral.Controls.Add(this.chkSabado);
//            this.tabPagGeneral.Controls.Add(this.metroLabel4);
//            this.tabPagGeneral.Controls.Add(this.dtpHI1);
//            this.tabPagGeneral.Controls.Add(this.dtpFB7);
//            this.tabPagGeneral.Controls.Add(this.dtpHF1);
//            this.tabPagGeneral.Controls.Add(this.dtpIB7);
//            this.tabPagGeneral.Controls.Add(this.dtpHI2);
//            this.tabPagGeneral.Controls.Add(this.dtpFB6);
//            this.tabPagGeneral.Controls.Add(this.dtpHF2);
//            this.tabPagGeneral.Controls.Add(this.dtpIB6);
//            this.tabPagGeneral.Controls.Add(this.dtpHI3);
//            this.tabPagGeneral.Controls.Add(this.dtpFB5);
//            this.tabPagGeneral.Controls.Add(this.dtpHF3);
//            this.tabPagGeneral.Controls.Add(this.dtpIB5);
//            this.tabPagGeneral.Controls.Add(this.dtpHI4);
//            this.tabPagGeneral.Controls.Add(this.dtpFB4);
//            this.tabPagGeneral.Controls.Add(this.dtpHF4);
//            this.tabPagGeneral.Controls.Add(this.dtpIB4);
//            this.tabPagGeneral.Controls.Add(this.dtpHI5);
//            this.tabPagGeneral.Controls.Add(this.dtpFB3);
//            this.tabPagGeneral.Controls.Add(this.dtpHF5);
//            this.tabPagGeneral.Controls.Add(this.dtpIB3);
//            this.tabPagGeneral.Controls.Add(this.dtpHI6);
//            this.tabPagGeneral.Controls.Add(this.dtpFB2);
//            this.tabPagGeneral.Controls.Add(this.dtpHF6);
//            this.tabPagGeneral.Controls.Add(this.dtpIB2);
//            this.tabPagGeneral.Controls.Add(this.dtpHI7);
//            this.tabPagGeneral.Controls.Add(this.dtpFB1);
//            this.tabPagGeneral.Controls.Add(this.dtpHF7);
//            this.tabPagGeneral.Controls.Add(this.dtpIB1);
//            this.tabPagGeneral.Controls.Add(this.metroLabel2);
//            this.tabPagGeneral.Controls.Add(this.metroLabel1);
//            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
//            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
//            this.tabPagGeneral.HorizontalScrollbarSize = 10;
//            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
//            this.tabPagGeneral.Name = "tabPagGeneral";
//            this.tabPagGeneral.Size = new System.Drawing.Size(601, 442);
//            this.tabPagGeneral.TabIndex = 0;
//            this.tabPagGeneral.Text = "General";
//            this.tabPagGeneral.VerticalScrollbarBarColor = true;
//            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
//            this.tabPagGeneral.VerticalScrollbarSize = 10;
//            // 
//            // chkDomingo
//            // 
//            this.chkDomingo.AutoSize = true;
//            this.chkDomingo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
//            this.chkDomingo.Location = new System.Drawing.Point(19, 86);
//            this.chkDomingo.Name = "chkDomingo";
//            this.chkDomingo.Size = new System.Drawing.Size(82, 19);
//            this.chkDomingo.TabIndex = 180;
//            this.chkDomingo.Text = "Domingo";
//            this.chkDomingo.UseSelectable = true;
//            // 
//            // btnNuevo
//            // 
//            this.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen;
//            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
//            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
//            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
//            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
//            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
//            this.btnNuevo.Location = new System.Drawing.Point(495, 18);
//            this.btnNuevo.Name = "btnNuevo";
//            this.btnNuevo.Size = new System.Drawing.Size(30, 30);
//            this.btnNuevo.TabIndex = 176;
//            this.btnNuevo.UseVisualStyleBackColor = false;
//            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
//            // 
//            // btnRemoveItem
//            // 
//            this.btnRemoveItem.BackColor = System.Drawing.Color.IndianRed;
//            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
//            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
//            this.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
//            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btnRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.Image")));
//            this.btnRemoveItem.Location = new System.Drawing.Point(531, 18);
//            this.btnRemoveItem.Name = "btnRemoveItem";
//            this.btnRemoveItem.Size = new System.Drawing.Size(30, 30);
//            this.btnRemoveItem.TabIndex = 177;
//            this.btnRemoveItem.UseVisualStyleBackColor = false;
//            // 
//            // chkLunes
//            // 
//            this.chkLunes.AutoSize = true;
//            this.chkLunes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
//            this.chkLunes.Location = new System.Drawing.Point(19, 111);
//            this.chkLunes.Name = "chkLunes";
//            this.chkLunes.Size = new System.Drawing.Size(61, 19);
//            this.chkLunes.TabIndex = 120;
//            this.chkLunes.Text = "Lunes";
//            this.chkLunes.UseSelectable = true;
//            // 
//            // dtpT7
//            // 
//            this.dtpT7.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpT7.Location = new System.Drawing.Point(494, 237);
//            this.dtpT7.Name = "dtpT7";
//            this.dtpT7.Size = new System.Drawing.Size(72, 20);
//            this.dtpT7.TabIndex = 170;
//            // 
//            // dtpT6
//            // 
//            this.dtpT6.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpT6.Location = new System.Drawing.Point(494, 211);
//            this.dtpT6.Name = "dtpT6";
//            this.dtpT6.Size = new System.Drawing.Size(72, 20);
//            this.dtpT6.TabIndex = 168;
//            // 
//            // dtpT5
//            // 
//            this.dtpT5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpT5.Location = new System.Drawing.Point(494, 185);
//            this.dtpT5.Name = "dtpT5";
//            this.dtpT5.Size = new System.Drawing.Size(72, 20);
//            this.dtpT5.TabIndex = 166;
//            // 
//            // dtpT4
//            // 
//            this.dtpT4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpT4.Location = new System.Drawing.Point(494, 159);
//            this.dtpT4.Name = "dtpT4";
//            this.dtpT4.Size = new System.Drawing.Size(72, 20);
//            this.dtpT4.TabIndex = 164;
//            // 
//            // dtpT3
//            // 
//            this.dtpT3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpT3.Location = new System.Drawing.Point(494, 133);
//            this.dtpT3.Name = "dtpT3";
//            this.dtpT3.Size = new System.Drawing.Size(72, 20);
//            this.dtpT3.TabIndex = 162;
//            // 
//            // dtpT2
//            // 
//            this.dtpT2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpT2.Location = new System.Drawing.Point(494, 107);
//            this.dtpT2.Name = "dtpT2";
//            this.dtpT2.Size = new System.Drawing.Size(72, 20);
//            this.dtpT2.TabIndex = 160;
//            // 
//            // dtpT1
//            // 
//            this.dtpT1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpT1.Location = new System.Drawing.Point(494, 81);
//            this.dtpT1.Name = "dtpT1";
//            this.dtpT1.Size = new System.Drawing.Size(72, 20);
//            this.dtpT1.TabIndex = 158;
//            // 
//            // dtpHI1
//            // 
//            this.dtpHI1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHI1.Location = new System.Drawing.Point(180, 81);
//            this.dtpHI1.Name = "dtpHI1";
//            this.dtpHI1.Size = new System.Drawing.Size(72, 20);
//            this.dtpHI1.TabIndex = 126;
//            // 
//            // dtpFB7
//            // 
//            this.dtpFB7.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpFB7.Location = new System.Drawing.Point(416, 237);
//            this.dtpFB7.Name = "dtpFB7";
//            this.dtpFB7.Size = new System.Drawing.Size(72, 20);
//            this.dtpFB7.TabIndex = 155;
//            // 
//            // dtpHF1
//            // 
//            this.dtpHF1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHF1.Location = new System.Drawing.Point(258, 81);
//            this.dtpHF1.Name = "dtpHF1";
//            this.dtpHF1.Size = new System.Drawing.Size(72, 20);
//            this.dtpHF1.TabIndex = 127;
//            this.dtpHF1.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
//            // 
//            // dtpIB7
//            // 
//            this.dtpIB7.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpIB7.Location = new System.Drawing.Point(338, 237);
//            this.dtpIB7.Name = "dtpIB7";
//            this.dtpIB7.Size = new System.Drawing.Size(72, 20);
//            this.dtpIB7.TabIndex = 154;
//            // 
//            // dtpHI2
//            // 
//            this.dtpHI2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHI2.Location = new System.Drawing.Point(180, 107);
//            this.dtpHI2.Name = "dtpHI2";
//            this.dtpHI2.Size = new System.Drawing.Size(72, 20);
//            this.dtpHI2.TabIndex = 128;
//            // 
//            // dtpFB6
//            // 
//            this.dtpFB6.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpFB6.Location = new System.Drawing.Point(416, 211);
//            this.dtpFB6.Name = "dtpFB6";
//            this.dtpFB6.Size = new System.Drawing.Size(72, 20);
//            this.dtpFB6.TabIndex = 153;
//            // 
//            // dtpHF2
//            // 
//            this.dtpHF2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHF2.Location = new System.Drawing.Point(258, 107);
//            this.dtpHF2.Name = "dtpHF2";
//            this.dtpHF2.Size = new System.Drawing.Size(72, 20);
//            this.dtpHF2.TabIndex = 129;
//            // 
//            // dtpIB6
//            // 
//            this.dtpIB6.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpIB6.Location = new System.Drawing.Point(338, 211);
//            this.dtpIB6.Name = "dtpIB6";
//            this.dtpIB6.Size = new System.Drawing.Size(72, 20);
//            this.dtpIB6.TabIndex = 152;
//            // 
//            // dtpHI3
//            // 
//            this.dtpHI3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHI3.Location = new System.Drawing.Point(180, 133);
//            this.dtpHI3.Name = "dtpHI3";
//            this.dtpHI3.Size = new System.Drawing.Size(72, 20);
//            this.dtpHI3.TabIndex = 130;
//            // 
//            // dtpFB5
//            // 
//            this.dtpFB5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpFB5.Location = new System.Drawing.Point(416, 185);
//            this.dtpFB5.Name = "dtpFB5";
//            this.dtpFB5.Size = new System.Drawing.Size(72, 20);
//            this.dtpFB5.TabIndex = 151;
//            // 
//            // dtpHF3
//            // 
//            this.dtpHF3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHF3.Location = new System.Drawing.Point(258, 133);
//            this.dtpHF3.Name = "dtpHF3";
//            this.dtpHF3.Size = new System.Drawing.Size(72, 20);
//            this.dtpHF3.TabIndex = 131;
//            // 
//            // dtpIB5
//            // 
//            this.dtpIB5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpIB5.Location = new System.Drawing.Point(338, 185);
//            this.dtpIB5.Name = "dtpIB5";
//            this.dtpIB5.Size = new System.Drawing.Size(72, 20);
//            this.dtpIB5.TabIndex = 150;
//            // 
//            // dtpHI4
//            // 
//            this.dtpHI4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHI4.Location = new System.Drawing.Point(180, 159);
//            this.dtpHI4.Name = "dtpHI4";
//            this.dtpHI4.Size = new System.Drawing.Size(72, 20);
//            this.dtpHI4.TabIndex = 132;
//            // 
//            // dtpFB4
//            // 
//            this.dtpFB4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpFB4.Location = new System.Drawing.Point(416, 159);
//            this.dtpFB4.Name = "dtpFB4";
//            this.dtpFB4.Size = new System.Drawing.Size(72, 20);
//            this.dtpFB4.TabIndex = 149;
//            // 
//            // dtpHF4
//            // 
//            this.dtpHF4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHF4.Location = new System.Drawing.Point(258, 159);
//            this.dtpHF4.Name = "dtpHF4";
//            this.dtpHF4.Size = new System.Drawing.Size(72, 20);
//            this.dtpHF4.TabIndex = 133;
//            // 
//            // dtpIB4
//            // 
//            this.dtpIB4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpIB4.Location = new System.Drawing.Point(338, 159);
//            this.dtpIB4.Name = "dtpIB4";
//            this.dtpIB4.Size = new System.Drawing.Size(72, 20);
//            this.dtpIB4.TabIndex = 148;
//            // 
//            // dtpHI5
//            // 
//            this.dtpHI5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHI5.Location = new System.Drawing.Point(180, 185);
//            this.dtpHI5.Name = "dtpHI5";
//            this.dtpHI5.Size = new System.Drawing.Size(72, 20);
//            this.dtpHI5.TabIndex = 134;
//            // 
//            // dtpFB3
//            // 
//            this.dtpFB3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpFB3.Location = new System.Drawing.Point(416, 133);
//            this.dtpFB3.Name = "dtpFB3";
//            this.dtpFB3.Size = new System.Drawing.Size(72, 20);
//            this.dtpFB3.TabIndex = 147;
//            // 
//            // dtpHF5
//            // 
//            this.dtpHF5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHF5.Location = new System.Drawing.Point(258, 185);
//            this.dtpHF5.Name = "dtpHF5";
//            this.dtpHF5.Size = new System.Drawing.Size(72, 20);
//            this.dtpHF5.TabIndex = 135;
//            // 
//            // dtpIB3
//            // 
//            this.dtpIB3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpIB3.Location = new System.Drawing.Point(338, 133);
//            this.dtpIB3.Name = "dtpIB3";
//            this.dtpIB3.Size = new System.Drawing.Size(72, 20);
//            this.dtpIB3.TabIndex = 146;
//            // 
//            // dtpHI6
//            // 
//            this.dtpHI6.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHI6.Location = new System.Drawing.Point(180, 211);
//            this.dtpHI6.Name = "dtpHI6";
//            this.dtpHI6.Size = new System.Drawing.Size(72, 20);
//            this.dtpHI6.TabIndex = 136;
//            // 
//            // dtpFB2
//            // 
//            this.dtpFB2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpFB2.Location = new System.Drawing.Point(416, 107);
//            this.dtpFB2.Name = "dtpFB2";
//            this.dtpFB2.Size = new System.Drawing.Size(72, 20);
//            this.dtpFB2.TabIndex = 145;
//            // 
//            // dtpHF6
//            // 
//            this.dtpHF6.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHF6.Location = new System.Drawing.Point(258, 211);
//            this.dtpHF6.Name = "dtpHF6";
//            this.dtpHF6.Size = new System.Drawing.Size(72, 20);
//            this.dtpHF6.TabIndex = 137;
//            // 
//            // dtpIB2
//            // 
//            this.dtpIB2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpIB2.Location = new System.Drawing.Point(338, 107);
//            this.dtpIB2.Name = "dtpIB2";
//            this.dtpIB2.Size = new System.Drawing.Size(72, 20);
//            this.dtpIB2.TabIndex = 144;
//            // 
//            // dtpHI7
//            // 
//            this.dtpHI7.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHI7.Location = new System.Drawing.Point(180, 237);
//            this.dtpHI7.Name = "dtpHI7";
//            this.dtpHI7.Size = new System.Drawing.Size(72, 20);
//            this.dtpHI7.TabIndex = 138;
//            // 
//            // dtpFB1
//            // 
//            this.dtpFB1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpFB1.Location = new System.Drawing.Point(416, 81);
//            this.dtpFB1.Name = "dtpFB1";
//            this.dtpFB1.Size = new System.Drawing.Size(72, 20);
//            this.dtpFB1.TabIndex = 143;
//            // 
//            // dtpHF7
//            // 
//            this.dtpHF7.Format = System.Windows.Forms.DateTimePickerFormat.Time;
//            this.dtpHF7.Location = new System.Drawing.Point(258, 237);
//            this.dtpHF7.Name = "dtpHF7";
//            this.dtpHF7.Size = new System.Drawing.Size(72, 20);
//            this.dtpHF7.TabIndex = 139;
//            // 
//            // dtpIB1
//            // 
//            this.dtpIB1.CustomFormat = "HH:mm";
//            this.dtpIB1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
//            this.dtpIB1.Location = new System.Drawing.Point(338, 81);
//            this.dtpIB1.Name = "dtpIB1";
//            this.dtpIB1.ShowUpDown = true;
//            this.dtpIB1.Size = new System.Drawing.Size(72, 20);
//            this.dtpIB1.TabIndex = 142;
//            // 
//            // metroTabPage1
//            // 
//            this.metroTabPage1.Controls.Add(this.grbDatosEmpleado);
//            this.metroTabPage1.HorizontalScrollbarBarColor = true;
//            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
//            this.metroTabPage1.HorizontalScrollbarSize = 10;
//            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
//            this.metroTabPage1.Name = "metroTabPage1";
//            this.metroTabPage1.Size = new System.Drawing.Size(601, 442);
//            this.metroTabPage1.TabIndex = 1;
//            this.metroTabPage1.Text = "Datos Empleado";
//            this.metroTabPage1.VerticalScrollbarBarColor = true;
//            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
//            this.metroTabPage1.VerticalScrollbarSize = 10;
//            // 
//            // grbDatosEmpleado
//            // 
//            this.grbDatosEmpleado.BackColor = System.Drawing.Color.Transparent;
//            this.grbDatosEmpleado.Controls.Add(this.txtFinContrato);
//            this.grbDatosEmpleado.Controls.Add(this.txtInicioContrato);
//            this.grbDatosEmpleado.Controls.Add(this.metroLabel6);
//            this.grbDatosEmpleado.Controls.Add(this.metroLabel7);
//            this.grbDatosEmpleado.Controls.Add(this.metroLabel8);
//            this.grbDatosEmpleado.Controls.Add(this.lstTrabajo);
//            this.grbDatosEmpleado.Controls.Add(this.txtUsuario);
//            this.grbDatosEmpleado.Controls.Add(this.picFotoEmp);
//            this.grbDatosEmpleado.Controls.Add(this.lblApeNom);
//            this.grbDatosEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.grbDatosEmpleado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
//            this.grbDatosEmpleado.Location = new System.Drawing.Point(4, 12);
//            this.grbDatosEmpleado.Name = "grbDatosEmpleado";
//            this.grbDatosEmpleado.Size = new System.Drawing.Size(436, 211);
//            this.grbDatosEmpleado.TabIndex = 73;
//            this.grbDatosEmpleado.TabStop = false;
//            this.grbDatosEmpleado.Text = "Datos del Empleado";
//            // 
//            // txtFinContrato
//            // 
//            this.txtFinContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
//            // 
//            // 
//            // 
//            this.txtFinContrato.CustomButton.Image = null;
//            this.txtFinContrato.CustomButton.Location = new System.Drawing.Point(78, 1);
//            this.txtFinContrato.CustomButton.Name = "";
//            this.txtFinContrato.CustomButton.Size = new System.Drawing.Size(21, 21);
//            this.txtFinContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
//            this.txtFinContrato.CustomButton.TabIndex = 1;
//            this.txtFinContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
//            this.txtFinContrato.CustomButton.UseSelectable = true;
//            this.txtFinContrato.CustomButton.Visible = false;
//            this.txtFinContrato.Enabled = false;
//            this.txtFinContrato.Lines = new string[0];
//            this.txtFinContrato.Location = new System.Drawing.Point(173, 165);
//            this.txtFinContrato.MaxLength = 32767;
//            this.txtFinContrato.Name = "txtFinContrato";
//            this.txtFinContrato.PasswordChar = '\0';
//            this.txtFinContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
//            this.txtFinContrato.SelectedText = "";
//            this.txtFinContrato.SelectionLength = 0;
//            this.txtFinContrato.SelectionStart = 0;
//            this.txtFinContrato.ShortcutsEnabled = true;
//            this.txtFinContrato.Size = new System.Drawing.Size(100, 23);
//            this.txtFinContrato.TabIndex = 120;
//            this.txtFinContrato.UseCustomBackColor = true;
//            this.txtFinContrato.UseSelectable = true;
//            this.txtFinContrato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
//            this.txtFinContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
//            // 
//            // txtInicioContrato
//            // 
//            this.txtInicioContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
//            // 
//            // 
//            // 
//            this.txtInicioContrato.CustomButton.Image = null;
//            this.txtInicioContrato.CustomButton.Location = new System.Drawing.Point(78, 1);
//            this.txtInicioContrato.CustomButton.Name = "";
//            this.txtInicioContrato.CustomButton.Size = new System.Drawing.Size(21, 21);
//            this.txtInicioContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
//            this.txtInicioContrato.CustomButton.TabIndex = 1;
//            this.txtInicioContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
//            this.txtInicioContrato.CustomButton.UseSelectable = true;
//            this.txtInicioContrato.CustomButton.Visible = false;
//            this.txtInicioContrato.Enabled = false;
//            this.txtInicioContrato.Lines = new string[0];
//            this.txtInicioContrato.Location = new System.Drawing.Point(173, 108);
//            this.txtInicioContrato.MaxLength = 32767;
//            this.txtInicioContrato.Name = "txtInicioContrato";
//            this.txtInicioContrato.PasswordChar = '\0';
//            this.txtInicioContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
//            this.txtInicioContrato.SelectedText = "";
//            this.txtInicioContrato.SelectionLength = 0;
//            this.txtInicioContrato.SelectionStart = 0;
//            this.txtInicioContrato.ShortcutsEnabled = true;
//            this.txtInicioContrato.Size = new System.Drawing.Size(100, 23);
//            this.txtInicioContrato.TabIndex = 120;
//            this.txtInicioContrato.UseCustomBackColor = true;
//            this.txtInicioContrato.UseSelectable = true;
//            this.txtInicioContrato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
//            this.txtInicioContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
//            // 
//            // metroLabel6
//            // 
//            this.metroLabel6.AutoSize = true;
//            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
//            this.metroLabel6.ForeColor = System.Drawing.Color.Navy;
//            this.metroLabel6.Location = new System.Drawing.Point(173, 143);
//            this.metroLabel6.Name = "metroLabel6";
//            this.metroLabel6.Size = new System.Drawing.Size(86, 19);
//            this.metroLabel6.TabIndex = 119;
//            this.metroLabel6.Text = "Fin contrato:";
//            this.metroLabel6.UseCustomForeColor = true;
//            // 
//            // metroLabel7
//            // 
//            this.metroLabel7.AutoSize = true;
//            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
//            this.metroLabel7.ForeColor = System.Drawing.Color.Navy;
//            this.metroLabel7.Location = new System.Drawing.Point(173, 86);
//            this.metroLabel7.Name = "metroLabel7";
//            this.metroLabel7.Size = new System.Drawing.Size(100, 19);
//            this.metroLabel7.TabIndex = 116;
//            this.metroLabel7.Text = "Inicio contrato:";
//            this.metroLabel7.UseCustomForeColor = true;
//            // 
//            // metroLabel8
//            // 
//            this.metroLabel8.AutoSize = true;
//            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
//            this.metroLabel8.ForeColor = System.Drawing.Color.Navy;
//            this.metroLabel8.Location = new System.Drawing.Point(8, 86);
//            this.metroLabel8.Name = "metroLabel8";
//            this.metroLabel8.Size = new System.Drawing.Size(62, 19);
//            this.metroLabel8.TabIndex = 115;
//            this.metroLabel8.Text = "Trabajos:";
//            this.metroLabel8.UseCustomForeColor = true;
//            // 
//            // lstTrabajo
//            // 
//            this.lstTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
//            this.lstTrabajo.Enabled = false;
//            this.lstTrabajo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
//            listViewItem1,
//            listViewItem2,
//            listViewItem3});
//            this.lstTrabajo.Location = new System.Drawing.Point(8, 108);
//            this.lstTrabajo.Name = "lstTrabajo";
//            this.lstTrabajo.Size = new System.Drawing.Size(142, 82);
//            this.lstTrabajo.TabIndex = 114;
//            this.lstTrabajo.UseCompatibleStateImageBehavior = false;
//            this.lstTrabajo.View = System.Windows.Forms.View.List;
//            // 
//            // txtUsuario
//            // 
//            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
//            // 
//            // 
//            // 
//            this.txtUsuario.CustomButton.Image = null;
//            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(252, 1);
//            this.txtUsuario.CustomButton.Name = "";
//            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
//            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
//            this.txtUsuario.CustomButton.TabIndex = 1;
//            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
//            this.txtUsuario.CustomButton.UseSelectable = true;
//            this.txtUsuario.CustomButton.Visible = false;
//            this.txtUsuario.Enabled = false;
//            this.txtUsuario.Lines = new string[0];
//            this.txtUsuario.Location = new System.Drawing.Point(8, 49);
//            this.txtUsuario.MaxLength = 32767;
//            this.txtUsuario.Name = "txtUsuario";
//            this.txtUsuario.PasswordChar = '\0';
//            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
//            this.txtUsuario.SelectedText = "";
//            this.txtUsuario.SelectionLength = 0;
//            this.txtUsuario.SelectionStart = 0;
//            this.txtUsuario.ShortcutsEnabled = true;
//            this.txtUsuario.Size = new System.Drawing.Size(274, 23);
//            this.txtUsuario.TabIndex = 113;
//            this.txtUsuario.UseCustomBackColor = true;
//            this.txtUsuario.UseSelectable = true;
//            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
//            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
//            // 
//            // picFotoEmp
//            // 
//            this.picFotoEmp.Image = ((System.Drawing.Image)(resources.GetObject("picFotoEmp.Image")));
//            this.picFotoEmp.Location = new System.Drawing.Point(288, 27);
//            this.picFotoEmp.Name = "picFotoEmp";
//            this.picFotoEmp.Size = new System.Drawing.Size(140, 163);
//            this.picFotoEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.picFotoEmp.TabIndex = 112;
//            this.picFotoEmp.TabStop = false;
//            // 
//            // lblApeNom
//            // 
//            this.lblApeNom.AutoSize = true;
//            this.lblApeNom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
//            this.lblApeNom.ForeColor = System.Drawing.Color.Navy;
//            this.lblApeNom.Location = new System.Drawing.Point(8, 27);
//            this.lblApeNom.Name = "lblApeNom";
//            this.lblApeNom.Size = new System.Drawing.Size(136, 19);
//            this.lblApeNom.TabIndex = 111;
//            this.lblApeNom.Text = "Apellidos y nombres:";
//            this.lblApeNom.UseCustomForeColor = true;
//            // 
//            // lblNomEmp
//            // 
//            this.lblNomEmp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
//            this.lblNomEmp.Location = new System.Drawing.Point(6, 21);
//            this.lblNomEmp.Name = "lblNomEmp";
//            this.lblNomEmp.Size = new System.Drawing.Size(221, 41);
//            this.lblNomEmp.TabIndex = 176;
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.lblNomEmp);
//            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
//            this.groupBox1.Location = new System.Drawing.Point(389, 100);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(246, 65);
//            this.groupBox1.TabIndex = 116;
//            this.groupBox1.TabStop = false;
//            this.groupBox1.Text = "Nombre Empleado";
//            // 
//            // errorProv
//            // 
//            this.errorProv.ContainerControl = this;
//            // 
//            // btnCerrar
//            // 
//            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
//            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
//            this.btnCerrar.ImageSize = 48;
//            this.btnCerrar.Location = new System.Drawing.Point(11, 20);
//            this.btnCerrar.Name = "btnCerrar";
//            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
//            this.btnCerrar.TabIndex = 113;
//            this.btnCerrar.UseSelectable = true;
//            // 
//            // FormHorarioEmpleado
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(686, 788);
//            this.Controls.Add(this.groupBox1);
//            this.Controls.Add(this.tabHorario);
//            this.Controls.Add(this.grbBuscarEmp);
//            this.Controls.Add(this.lblNombreForm);
//            this.Controls.Add(this.btnCerrar);
//            this.Name = "FormHorarioEmpleado";
//            this.Load += new System.EventHandler(this.FormHorarioEmpleado_Load);
//            this.grbBuscarEmp.ResumeLayout(false);
//            this.grbBuscarEmp.PerformLayout();
//            this.tabHorario.ResumeLayout(false);
//            this.tabPagGeneral.ResumeLayout(false);
//            this.tabPagGeneral.PerformLayout();
//            this.metroTabPage1.ResumeLayout(false);
//            this.grbDatosEmpleado.ResumeLayout(false);
//            this.grbDatosEmpleado.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.picFotoEmp)).EndInit();
//            this.groupBox1.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.GroupBox grbBuscarEmp;
//        private MetroFramework.Controls.MetroLabel lblNroDocEmp;
//        private MetroFramework.Controls.MetroTextBox txtNroDocEmp;
//        private System.Windows.Forms.Button btnBuscarEmp;
//        private System.Windows.Forms.Label lblNombreForm;
//        private MetroFramework.Controls.MetroLink btnCerrar;
//        private System.Windows.Forms.MonthCalendar mcaMes;
//        private MetroFramework.Controls.MetroCheckBox chkSabado;
//        private MetroFramework.Controls.MetroLabel lblDomHf;
//        private MetroFramework.Controls.MetroCheckBox chkViernes;
//        private MetroFramework.Controls.MetroLabel lblDomHi;
//        private MetroFramework.Controls.MetroCheckBox chkJueves;
//        private MetroFramework.Controls.MetroCheckBox chkMartes;
//        private MetroFramework.Controls.MetroCheckBox chkMiercoles;
//        private MetroFramework.Controls.MetroLabel metroLabel1;
//        private MetroFramework.Controls.MetroLabel metroLabel2;
//        private MetroFramework.Controls.MetroLabel metroLabel4;
//        private MetroFramework.Controls.MetroLabel metroLabel3;
//        private System.Windows.Forms.DateTimePicker dtpDesde;
//        private System.Windows.Forms.DateTimePicker dtpHasta;
//        private MetroFramework.Controls.MetroLabel metroLabel5;
//        private MetroFramework.Controls.MetroTabControl tabHorario;
//        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
//        private MetroFramework.Controls.MetroTabPage metroTabPage1;
//        private System.Windows.Forms.GroupBox grbDatosEmpleado;
//        private MetroFramework.Controls.MetroLabel metroLabel6;
//        private MetroFramework.Controls.MetroLabel metroLabel7;
//        private MetroFramework.Controls.MetroLabel metroLabel8;
//        private System.Windows.Forms.ListView lstTrabajo;
//        private MetroFramework.Controls.MetroTextBox txtUsuario;
//        private System.Windows.Forms.PictureBox picFotoEmp;
//        private MetroFramework.Controls.MetroLabel lblApeNom;
//        private System.Windows.Forms.Label lblNomEmp;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.Button btnNuevo;
//        private System.Windows.Forms.Button btnRemoveItem;
//        private System.Windows.Forms.DateTimePicker dtpT7;
//        private System.Windows.Forms.DateTimePicker dtpT6;
//        private System.Windows.Forms.DateTimePicker dtpT5;
//        private System.Windows.Forms.DateTimePicker dtpT4;
//        private System.Windows.Forms.DateTimePicker dtpT3;
//        private System.Windows.Forms.DateTimePicker dtpT2;
//        private System.Windows.Forms.DateTimePicker dtpT1;
//        private System.Windows.Forms.DateTimePicker dtpHI1;
//        private System.Windows.Forms.DateTimePicker dtpFB7;
//        private System.Windows.Forms.DateTimePicker dtpHF1;
//        private System.Windows.Forms.DateTimePicker dtpIB7;
//        private System.Windows.Forms.DateTimePicker dtpHI2;
//        private System.Windows.Forms.DateTimePicker dtpFB6;
//        private System.Windows.Forms.DateTimePicker dtpHF2;
//        private System.Windows.Forms.DateTimePicker dtpIB6;
//        private System.Windows.Forms.DateTimePicker dtpHI3;
//        private System.Windows.Forms.DateTimePicker dtpFB5;
//        private System.Windows.Forms.DateTimePicker dtpHF3;
//        private System.Windows.Forms.DateTimePicker dtpIB5;
//        private System.Windows.Forms.DateTimePicker dtpHI4;
//        private System.Windows.Forms.DateTimePicker dtpFB4;
//        private System.Windows.Forms.DateTimePicker dtpHF4;
//        private System.Windows.Forms.DateTimePicker dtpIB4;
//        private System.Windows.Forms.DateTimePicker dtpHI5;
//        private System.Windows.Forms.DateTimePicker dtpFB3;
//        private System.Windows.Forms.DateTimePicker dtpHF5;
//        private System.Windows.Forms.DateTimePicker dtpIB3;
//        private System.Windows.Forms.DateTimePicker dtpHI6;
//        private System.Windows.Forms.DateTimePicker dtpFB2;
//        private System.Windows.Forms.DateTimePicker dtpHF6;
//        private System.Windows.Forms.DateTimePicker dtpIB2;
//        private System.Windows.Forms.DateTimePicker dtpHI7;
//        private System.Windows.Forms.DateTimePicker dtpFB1;
//        private System.Windows.Forms.DateTimePicker dtpHF7;
//        private System.Windows.Forms.DateTimePicker dtpIB1;
//        private MetroFramework.Controls.MetroCheckBox chkLunes;
//        private MetroFramework.Controls.MetroCheckBox chkDomingo;
//        private System.Windows.Forms.ErrorProvider errorProv;
//        private MetroFramework.Controls.MetroTextBox txtFinContrato;
//        private MetroFramework.Controls.MetroTextBox txtInicioContrato;
//    }
//}