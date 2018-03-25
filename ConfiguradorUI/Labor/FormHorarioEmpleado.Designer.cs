using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Labor
{
    partial class FormHorarioEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorarioEmpleado));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mesero");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Cocinero");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Gerente");
            this.grbBuscarEmp = new System.Windows.Forms.GroupBox();
            this.lblNroDocEmp = new MetroFramework.Controls.MetroLabel();
            this.txtNroDocEmp = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.mcaMes = new System.Windows.Forms.MonthCalendar();
            this.chkSabado = new MetroFramework.Controls.MetroCheckBox();
            this.lblDomHf = new MetroFramework.Controls.MetroLabel();
            this.chkViernes = new MetroFramework.Controls.MetroCheckBox();
            this.lblDomHi = new MetroFramework.Controls.MetroLabel();
            this.chkJueves = new MetroFramework.Controls.MetroCheckBox();
            this.chkMartes = new MetroFramework.Controls.MetroCheckBox();
            this.chkMiercoles = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tabHorario = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.pnlControlesGenerales = new System.Windows.Forms.Panel();
            this.lblOperacionActual = new MetroFramework.Controls.MetroLabel();
            this.btnCommit = new System.Windows.Forms.Button();
            this.pnlHoras = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpToleranciaSab = new System.Windows.Forms.DateTimePicker();
            this.dtpToleranciaVie = new System.Windows.Forms.DateTimePicker();
            this.dtpIniBrkDom = new System.Windows.Forms.DateTimePicker();
            this.dtpToleranciaJue = new System.Windows.Forms.DateTimePicker();
            this.dtpFinLabSab = new System.Windows.Forms.DateTimePicker();
            this.dtpToleranciaMie = new System.Windows.Forms.DateTimePicker();
            this.dtpFinBrkDom = new System.Windows.Forms.DateTimePicker();
            this.dtpIniLabSab = new System.Windows.Forms.DateTimePicker();
            this.dtpToleranciaMar = new System.Windows.Forms.DateTimePicker();
            this.dtpIniBrkLun = new System.Windows.Forms.DateTimePicker();
            this.dtpToleranciaLun = new System.Windows.Forms.DateTimePicker();
            this.dtpFinLabVie = new System.Windows.Forms.DateTimePicker();
            this.dtpFinBrkLun = new System.Windows.Forms.DateTimePicker();
            this.dtpToleranciaDom = new System.Windows.Forms.DateTimePicker();
            this.dtpIniLabVie = new System.Windows.Forms.DateTimePicker();
            this.dtpIniBrkMar = new System.Windows.Forms.DateTimePicker();
            this.dtpIniLabDom = new System.Windows.Forms.DateTimePicker();
            this.dtpFinLabJue = new System.Windows.Forms.DateTimePicker();
            this.dtpFinBrkSab = new System.Windows.Forms.DateTimePicker();
            this.dtpFinBrkMar = new System.Windows.Forms.DateTimePicker();
            this.dtpFinLabDom = new System.Windows.Forms.DateTimePicker();
            this.dtpIniLabJue = new System.Windows.Forms.DateTimePicker();
            this.dtpIniBrkSab = new System.Windows.Forms.DateTimePicker();
            this.dtpIniBrkMie = new System.Windows.Forms.DateTimePicker();
            this.dtpIniLabLun = new System.Windows.Forms.DateTimePicker();
            this.dtpFinLabMie = new System.Windows.Forms.DateTimePicker();
            this.dtpFinBrkVie = new System.Windows.Forms.DateTimePicker();
            this.dtpFinBrkMie = new System.Windows.Forms.DateTimePicker();
            this.dtpFinLabLun = new System.Windows.Forms.DateTimePicker();
            this.dtpIniLabMie = new System.Windows.Forms.DateTimePicker();
            this.dtpIniBrkVie = new System.Windows.Forms.DateTimePicker();
            this.dtpIniBrkJue = new System.Windows.Forms.DateTimePicker();
            this.dtpIniLabMar = new System.Windows.Forms.DateTimePicker();
            this.dtpFinLabMar = new System.Windows.Forms.DateTimePicker();
            this.dtpFinBrkJue = new System.Windows.Forms.DateTimePicker();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.chkDomingo = new MetroFramework.Controls.MetroCheckBox();
            this.chkLunes = new MetroFramework.Controls.MetroCheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnDesasignarFechas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.grbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.txtFinContrato = new MetroFramework.Controls.MetroTextBox();
            this.txtInicioContrato = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lstTrabajo = new System.Windows.Forms.ListView();
            this.txtNombreEmpleado = new MetroFramework.Controls.MetroTextBox();
            this.picFotoEmp = new System.Windows.Forms.PictureBox();
            this.lblApeNom = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRangoHorario = new MetroFramework.Controls.MetroLabel();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.grbDetalleDia = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.chkModificarEnTodosLosMismosDias = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.grbBuscarEmp.SuspendLayout();
            this.tabHorario.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.pnlControlesGenerales.SuspendLayout();
            this.pnlHoras.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.grbDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoEmp)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbDetalleDia.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBuscarEmp
            // 
            this.grbBuscarEmp.Controls.Add(this.lblNroDocEmp);
            this.grbBuscarEmp.Controls.Add(this.txtNroDocEmp);
            this.grbBuscarEmp.Controls.Add(this.btnBuscarEmp);
            this.grbBuscarEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscarEmp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbBuscarEmp.Location = new System.Drawing.Point(33, 82);
            this.grbBuscarEmp.Name = "grbBuscarEmp";
            this.grbBuscarEmp.Size = new System.Drawing.Size(366, 76);
            this.grbBuscarEmp.TabIndex = 115;
            this.grbBuscarEmp.TabStop = false;
            this.grbBuscarEmp.Text = "Buscar empleado";
            // 
            // lblNroDocEmp
            // 
            this.lblNroDocEmp.AutoSize = true;
            this.lblNroDocEmp.ForeColor = System.Drawing.Color.Navy;
            this.lblNroDocEmp.Location = new System.Drawing.Point(8, 35);
            this.lblNroDocEmp.Name = "lblNroDocEmp";
            this.lblNroDocEmp.Size = new System.Drawing.Size(133, 19);
            this.lblNroDocEmp.TabIndex = 108;
            this.lblNroDocEmp.Text = "Número Documento:";
            this.lblNroDocEmp.UseCustomForeColor = true;
            // 
            // txtNroDocEmp
            // 
            this.txtNroDocEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNroDocEmp.CustomButton.Image = null;
            this.txtNroDocEmp.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.txtNroDocEmp.CustomButton.Name = "";
            this.txtNroDocEmp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNroDocEmp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroDocEmp.CustomButton.TabIndex = 1;
            this.txtNroDocEmp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroDocEmp.CustomButton.UseSelectable = true;
            this.txtNroDocEmp.CustomButton.Visible = false;
            this.txtNroDocEmp.Lines = new string[] {
        "76161544"};
            this.txtNroDocEmp.Location = new System.Drawing.Point(147, 33);
            this.txtNroDocEmp.MaxLength = 32767;
            this.txtNroDocEmp.Name = "txtNroDocEmp";
            this.txtNroDocEmp.PasswordChar = '\0';
            this.txtNroDocEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroDocEmp.SelectedText = "";
            this.txtNroDocEmp.SelectionLength = 0;
            this.txtNroDocEmp.SelectionStart = 0;
            this.txtNroDocEmp.ShortcutsEnabled = true;
            this.txtNroDocEmp.Size = new System.Drawing.Size(132, 23);
            this.txtNroDocEmp.TabIndex = 109;
            this.txtNroDocEmp.Text = "76161544";
            this.txtNroDocEmp.UseCustomBackColor = true;
            this.txtNroDocEmp.UseSelectable = true;
            this.txtNroDocEmp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroDocEmp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNroDocEmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNroDocEmp_KeyPress);
            // 
            // btnBuscarEmp
            // 
            this.btnBuscarEmp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarEmp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarEmp.FlatAppearance.BorderSize = 0;
            this.btnBuscarEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscarEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEmp.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEmp.ForeColor = System.Drawing.Color.White;
            this.btnBuscarEmp.Location = new System.Drawing.Point(284, 32);
            this.btnBuscarEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(69, 24);
            this.btnBuscarEmp.TabIndex = 0;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEmp.UseVisualStyleBackColor = false;
            this.btnBuscarEmp.Click += new System.EventHandler(this.btnBuscarEmp_Click);
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(80, 32);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(167, 32);
            this.lblNombreForm.TabIndex = 114;
            this.lblNombreForm.Text = "Nuevo Horario";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(18, 20);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 113;
            this.btnCerrar.UseSelectable = true;
            // 
            // mcaMes
            // 
            this.mcaMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.mcaMes.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.mcaMes.Location = new System.Drawing.Point(24, 477);
            this.mcaMes.Name = "mcaMes";
            this.mcaMes.TabIndex = 116;
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkSabado.Location = new System.Drawing.Point(5, 206);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(70, 19);
            this.chkSabado.TabIndex = 125;
            this.chkSabado.Text = "Sábado";
            this.chkSabado.UseSelectable = true;
            // 
            // lblDomHf
            // 
            this.lblDomHf.AutoSize = true;
            this.lblDomHf.ForeColor = System.Drawing.Color.Navy;
            this.lblDomHf.Location = new System.Drawing.Point(81, 2);
            this.lblDomHf.Name = "lblDomHf";
            this.lblDomHf.Size = new System.Drawing.Size(59, 19);
            this.lblDomHf.TabIndex = 119;
            this.lblDomHf.Text = "Hora Fin";
            this.lblDomHf.UseCustomForeColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkViernes.Location = new System.Drawing.Point(5, 181);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(70, 19);
            this.chkViernes.TabIndex = 124;
            this.chkViernes.Text = "Viernes";
            this.chkViernes.UseSelectable = true;
            // 
            // lblDomHi
            // 
            this.lblDomHi.AutoSize = true;
            this.lblDomHi.ForeColor = System.Drawing.Color.Navy;
            this.lblDomHi.Location = new System.Drawing.Point(3, 2);
            this.lblDomHi.Name = "lblDomHi";
            this.lblDomHi.Size = new System.Drawing.Size(72, 19);
            this.lblDomHi.TabIndex = 118;
            this.lblDomHi.Text = "Hora Inicio";
            this.lblDomHi.UseCustomForeColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkJueves.Location = new System.Drawing.Point(5, 156);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(65, 19);
            this.chkJueves.TabIndex = 123;
            this.chkJueves.Text = "Jueves";
            this.chkJueves.UseSelectable = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkMartes.Location = new System.Drawing.Point(5, 106);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(68, 19);
            this.chkMartes.TabIndex = 121;
            this.chkMartes.Text = "Martes";
            this.chkMartes.UseSelectable = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkMiercoles.Location = new System.Drawing.Point(5, 131);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(83, 19);
            this.chkMiercoles.TabIndex = 122;
            this.chkMiercoles.Text = "Miércoles";
            this.chkMiercoles.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(237, 2);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 141;
            this.metroLabel1.Text = "Fin Break";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(159, 2);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 140;
            this.metroLabel2.Text = "Inicio Break";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel4.Location = new System.Drawing.Point(315, 2);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 156;
            this.metroLabel4.Text = "Tolerancia";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(612, 33);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 171;
            this.metroLabel3.Text = "Desde:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(615, 55);
            this.dtpDesde.MinDate = new System.DateTime(2017, 1, 30, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(96, 20);
            this.dtpDesde.TabIndex = 172;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(615, 105);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(96, 20);
            this.dtpHasta.TabIndex = 174;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel5.Location = new System.Drawing.Point(612, 83);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 173;
            this.metroLabel5.Text = "Hasta:";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // tabHorario
            // 
            this.tabHorario.Controls.Add(this.tabPagGeneral);
            this.tabHorario.Controls.Add(this.metroTabPage1);
            this.tabHorario.Location = new System.Drawing.Point(33, 159);
            this.tabHorario.Name = "tabHorario";
            this.tabHorario.SelectedIndex = 0;
            this.tabHorario.Size = new System.Drawing.Size(731, 315);
            this.tabHorario.TabIndex = 175;
            this.tabHorario.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.metroLabel16);
            this.tabPagGeneral.Controls.Add(this.metroLabel15);
            this.tabPagGeneral.Controls.Add(this.pnlControlesGenerales);
            this.tabPagGeneral.Controls.Add(this.btnNuevo);
            this.tabPagGeneral.Controls.Add(this.btnDesasignarFechas);
            this.tabPagGeneral.Controls.Add(this.label1);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(723, 273);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel16.Location = new System.Drawing.Point(553, 23);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(167, 19);
            this.metroLabel16.TabIndex = 196;
            this.metroLabel16.Text = "Formato de horas: HH:mm";
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel15.Location = new System.Drawing.Point(516, 4);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(204, 19);
            this.metroLabel15.TabIndex = 195;
            this.metroLabel15.Text = "Formato de fechas: dd/MM/aaaa";
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // pnlControlesGenerales
            // 
            this.pnlControlesGenerales.BackColor = System.Drawing.Color.White;
            this.pnlControlesGenerales.Controls.Add(this.lblOperacionActual);
            this.pnlControlesGenerales.Controls.Add(this.btnCommit);
            this.pnlControlesGenerales.Controls.Add(this.chkSabado);
            this.pnlControlesGenerales.Controls.Add(this.pnlHoras);
            this.pnlControlesGenerales.Controls.Add(this.chkViernes);
            this.pnlControlesGenerales.Controls.Add(this.chkJueves);
            this.pnlControlesGenerales.Controls.Add(this.metroLabel14);
            this.pnlControlesGenerales.Controls.Add(this.chkMartes);
            this.pnlControlesGenerales.Controls.Add(this.chkDomingo);
            this.pnlControlesGenerales.Controls.Add(this.chkMiercoles);
            this.pnlControlesGenerales.Controls.Add(this.chkLunes);
            this.pnlControlesGenerales.Controls.Add(this.dtpDesde);
            this.pnlControlesGenerales.Controls.Add(this.dtpHasta);
            this.pnlControlesGenerales.Controls.Add(this.metroLabel3);
            this.pnlControlesGenerales.Controls.Add(this.metroLabel5);
            this.pnlControlesGenerales.Location = new System.Drawing.Point(0, 44);
            this.pnlControlesGenerales.Name = "pnlControlesGenerales";
            this.pnlControlesGenerales.Size = new System.Drawing.Size(720, 229);
            this.pnlControlesGenerales.TabIndex = 177;
            // 
            // lblOperacionActual
            // 
            this.lblOperacionActual.AutoSize = true;
            this.lblOperacionActual.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblOperacionActual.ForeColor = System.Drawing.Color.Navy;
            this.lblOperacionActual.Location = new System.Drawing.Point(5, 1);
            this.lblOperacionActual.Name = "lblOperacionActual";
            this.lblOperacionActual.Size = new System.Drawing.Size(123, 19);
            this.lblOperacionActual.TabIndex = 172;
            this.lblOperacionActual.Text = "Operación actual";
            this.lblOperacionActual.UseCustomForeColor = true;
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCommit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCommit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.ForeColor = System.Drawing.Color.White;
            this.btnCommit.Image = ((System.Drawing.Image)(resources.GetObject("btnCommit.Image")));
            this.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCommit.Location = new System.Drawing.Point(615, 145);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(96, 30);
            this.btnCommit.TabIndex = 192;
            this.btnCommit.Text = "Confirmar";
            this.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // pnlHoras
            // 
            this.pnlHoras.BackColor = System.Drawing.Color.White;
            this.pnlHoras.Controls.Add(this.panel3);
            this.pnlHoras.Controls.Add(this.dtpToleranciaSab);
            this.pnlHoras.Controls.Add(this.metroLabel1);
            this.pnlHoras.Controls.Add(this.metroLabel2);
            this.pnlHoras.Controls.Add(this.dtpToleranciaVie);
            this.pnlHoras.Controls.Add(this.dtpIniBrkDom);
            this.pnlHoras.Controls.Add(this.dtpToleranciaJue);
            this.pnlHoras.Controls.Add(this.dtpFinLabSab);
            this.pnlHoras.Controls.Add(this.dtpToleranciaMie);
            this.pnlHoras.Controls.Add(this.dtpFinBrkDom);
            this.pnlHoras.Controls.Add(this.lblDomHi);
            this.pnlHoras.Controls.Add(this.dtpIniLabSab);
            this.pnlHoras.Controls.Add(this.dtpToleranciaMar);
            this.pnlHoras.Controls.Add(this.dtpIniBrkLun);
            this.pnlHoras.Controls.Add(this.dtpToleranciaLun);
            this.pnlHoras.Controls.Add(this.dtpFinLabVie);
            this.pnlHoras.Controls.Add(this.lblDomHf);
            this.pnlHoras.Controls.Add(this.dtpFinBrkLun);
            this.pnlHoras.Controls.Add(this.dtpToleranciaDom);
            this.pnlHoras.Controls.Add(this.dtpIniLabVie);
            this.pnlHoras.Controls.Add(this.metroLabel4);
            this.pnlHoras.Controls.Add(this.dtpIniBrkMar);
            this.pnlHoras.Controls.Add(this.dtpIniLabDom);
            this.pnlHoras.Controls.Add(this.dtpFinLabJue);
            this.pnlHoras.Controls.Add(this.dtpFinBrkSab);
            this.pnlHoras.Controls.Add(this.dtpFinBrkMar);
            this.pnlHoras.Controls.Add(this.dtpFinLabDom);
            this.pnlHoras.Controls.Add(this.dtpIniLabJue);
            this.pnlHoras.Controls.Add(this.dtpIniBrkSab);
            this.pnlHoras.Controls.Add(this.dtpIniBrkMie);
            this.pnlHoras.Controls.Add(this.dtpIniLabLun);
            this.pnlHoras.Controls.Add(this.dtpFinLabMie);
            this.pnlHoras.Controls.Add(this.dtpFinBrkVie);
            this.pnlHoras.Controls.Add(this.dtpFinBrkMie);
            this.pnlHoras.Controls.Add(this.dtpFinLabLun);
            this.pnlHoras.Controls.Add(this.dtpIniLabMie);
            this.pnlHoras.Controls.Add(this.dtpIniBrkVie);
            this.pnlHoras.Controls.Add(this.dtpIniBrkJue);
            this.pnlHoras.Controls.Add(this.dtpIniLabMar);
            this.pnlHoras.Controls.Add(this.dtpFinLabMar);
            this.pnlHoras.Controls.Add(this.dtpFinBrkJue);
            this.pnlHoras.Location = new System.Drawing.Point(175, 22);
            this.pnlHoras.Name = "pnlHoras";
            this.pnlHoras.Size = new System.Drawing.Size(389, 207);
            this.pnlHoras.TabIndex = 194;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(3, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 4);
            this.panel3.TabIndex = 171;
            // 
            // dtpToleranciaSab
            // 
            this.dtpToleranciaSab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToleranciaSab.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToleranciaSab.Location = new System.Drawing.Point(315, 183);
            this.dtpToleranciaSab.Name = "dtpToleranciaSab";
            this.dtpToleranciaSab.Size = new System.Drawing.Size(72, 21);
            this.dtpToleranciaSab.TabIndex = 170;
            // 
            // dtpToleranciaVie
            // 
            this.dtpToleranciaVie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToleranciaVie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToleranciaVie.Location = new System.Drawing.Point(315, 158);
            this.dtpToleranciaVie.Name = "dtpToleranciaVie";
            this.dtpToleranciaVie.Size = new System.Drawing.Size(72, 21);
            this.dtpToleranciaVie.TabIndex = 168;
            // 
            // dtpIniBrkDom
            // 
            this.dtpIniBrkDom.CustomFormat = "";
            this.dtpIniBrkDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniBrkDom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniBrkDom.Location = new System.Drawing.Point(159, 33);
            this.dtpIniBrkDom.Name = "dtpIniBrkDom";
            this.dtpIniBrkDom.Size = new System.Drawing.Size(72, 21);
            this.dtpIniBrkDom.TabIndex = 142;
            // 
            // dtpToleranciaJue
            // 
            this.dtpToleranciaJue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToleranciaJue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToleranciaJue.Location = new System.Drawing.Point(315, 133);
            this.dtpToleranciaJue.Name = "dtpToleranciaJue";
            this.dtpToleranciaJue.Size = new System.Drawing.Size(72, 21);
            this.dtpToleranciaJue.TabIndex = 166;
            // 
            // dtpFinLabSab
            // 
            this.dtpFinLabSab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinLabSab.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinLabSab.Location = new System.Drawing.Point(81, 183);
            this.dtpFinLabSab.Name = "dtpFinLabSab";
            this.dtpFinLabSab.Size = new System.Drawing.Size(72, 21);
            this.dtpFinLabSab.TabIndex = 139;
            // 
            // dtpToleranciaMie
            // 
            this.dtpToleranciaMie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToleranciaMie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToleranciaMie.Location = new System.Drawing.Point(315, 108);
            this.dtpToleranciaMie.Name = "dtpToleranciaMie";
            this.dtpToleranciaMie.Size = new System.Drawing.Size(72, 21);
            this.dtpToleranciaMie.TabIndex = 164;
            // 
            // dtpFinBrkDom
            // 
            this.dtpFinBrkDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinBrkDom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinBrkDom.Location = new System.Drawing.Point(237, 33);
            this.dtpFinBrkDom.Name = "dtpFinBrkDom";
            this.dtpFinBrkDom.Size = new System.Drawing.Size(72, 21);
            this.dtpFinBrkDom.TabIndex = 143;
            // 
            // dtpIniLabSab
            // 
            this.dtpIniLabSab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniLabSab.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniLabSab.Location = new System.Drawing.Point(3, 183);
            this.dtpIniLabSab.Name = "dtpIniLabSab";
            this.dtpIniLabSab.Size = new System.Drawing.Size(72, 21);
            this.dtpIniLabSab.TabIndex = 138;
            // 
            // dtpToleranciaMar
            // 
            this.dtpToleranciaMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToleranciaMar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToleranciaMar.Location = new System.Drawing.Point(315, 83);
            this.dtpToleranciaMar.Name = "dtpToleranciaMar";
            this.dtpToleranciaMar.Size = new System.Drawing.Size(72, 21);
            this.dtpToleranciaMar.TabIndex = 162;
            // 
            // dtpIniBrkLun
            // 
            this.dtpIniBrkLun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniBrkLun.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniBrkLun.Location = new System.Drawing.Point(159, 58);
            this.dtpIniBrkLun.Name = "dtpIniBrkLun";
            this.dtpIniBrkLun.Size = new System.Drawing.Size(72, 21);
            this.dtpIniBrkLun.TabIndex = 144;
            // 
            // dtpToleranciaLun
            // 
            this.dtpToleranciaLun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToleranciaLun.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToleranciaLun.Location = new System.Drawing.Point(315, 58);
            this.dtpToleranciaLun.Name = "dtpToleranciaLun";
            this.dtpToleranciaLun.Size = new System.Drawing.Size(72, 21);
            this.dtpToleranciaLun.TabIndex = 160;
            // 
            // dtpFinLabVie
            // 
            this.dtpFinLabVie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinLabVie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinLabVie.Location = new System.Drawing.Point(81, 158);
            this.dtpFinLabVie.Name = "dtpFinLabVie";
            this.dtpFinLabVie.Size = new System.Drawing.Size(72, 21);
            this.dtpFinLabVie.TabIndex = 137;
            // 
            // dtpFinBrkLun
            // 
            this.dtpFinBrkLun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinBrkLun.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinBrkLun.Location = new System.Drawing.Point(237, 58);
            this.dtpFinBrkLun.Name = "dtpFinBrkLun";
            this.dtpFinBrkLun.Size = new System.Drawing.Size(72, 21);
            this.dtpFinBrkLun.TabIndex = 145;
            // 
            // dtpToleranciaDom
            // 
            this.dtpToleranciaDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToleranciaDom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpToleranciaDom.Location = new System.Drawing.Point(315, 33);
            this.dtpToleranciaDom.Name = "dtpToleranciaDom";
            this.dtpToleranciaDom.Size = new System.Drawing.Size(72, 21);
            this.dtpToleranciaDom.TabIndex = 158;
            // 
            // dtpIniLabVie
            // 
            this.dtpIniLabVie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniLabVie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniLabVie.Location = new System.Drawing.Point(3, 158);
            this.dtpIniLabVie.Name = "dtpIniLabVie";
            this.dtpIniLabVie.Size = new System.Drawing.Size(72, 21);
            this.dtpIniLabVie.TabIndex = 136;
            // 
            // dtpIniBrkMar
            // 
            this.dtpIniBrkMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniBrkMar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniBrkMar.Location = new System.Drawing.Point(159, 83);
            this.dtpIniBrkMar.Name = "dtpIniBrkMar";
            this.dtpIniBrkMar.Size = new System.Drawing.Size(72, 21);
            this.dtpIniBrkMar.TabIndex = 146;
            // 
            // dtpIniLabDom
            // 
            this.dtpIniLabDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniLabDom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniLabDom.Location = new System.Drawing.Point(3, 33);
            this.dtpIniLabDom.Name = "dtpIniLabDom";
            this.dtpIniLabDom.Size = new System.Drawing.Size(72, 21);
            this.dtpIniLabDom.TabIndex = 126;
            // 
            // dtpFinLabJue
            // 
            this.dtpFinLabJue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinLabJue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinLabJue.Location = new System.Drawing.Point(81, 133);
            this.dtpFinLabJue.Name = "dtpFinLabJue";
            this.dtpFinLabJue.Size = new System.Drawing.Size(72, 21);
            this.dtpFinLabJue.TabIndex = 135;
            // 
            // dtpFinBrkSab
            // 
            this.dtpFinBrkSab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinBrkSab.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinBrkSab.Location = new System.Drawing.Point(237, 183);
            this.dtpFinBrkSab.Name = "dtpFinBrkSab";
            this.dtpFinBrkSab.Size = new System.Drawing.Size(72, 21);
            this.dtpFinBrkSab.TabIndex = 155;
            // 
            // dtpFinBrkMar
            // 
            this.dtpFinBrkMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinBrkMar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinBrkMar.Location = new System.Drawing.Point(237, 83);
            this.dtpFinBrkMar.Name = "dtpFinBrkMar";
            this.dtpFinBrkMar.Size = new System.Drawing.Size(72, 21);
            this.dtpFinBrkMar.TabIndex = 147;
            // 
            // dtpFinLabDom
            // 
            this.dtpFinLabDom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinLabDom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinLabDom.Location = new System.Drawing.Point(81, 33);
            this.dtpFinLabDom.Name = "dtpFinLabDom";
            this.dtpFinLabDom.Size = new System.Drawing.Size(72, 21);
            this.dtpFinLabDom.TabIndex = 127;
            this.dtpFinLabDom.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            // 
            // dtpIniLabJue
            // 
            this.dtpIniLabJue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniLabJue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniLabJue.Location = new System.Drawing.Point(3, 133);
            this.dtpIniLabJue.Name = "dtpIniLabJue";
            this.dtpIniLabJue.Size = new System.Drawing.Size(72, 21);
            this.dtpIniLabJue.TabIndex = 134;
            // 
            // dtpIniBrkSab
            // 
            this.dtpIniBrkSab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniBrkSab.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniBrkSab.Location = new System.Drawing.Point(159, 183);
            this.dtpIniBrkSab.Name = "dtpIniBrkSab";
            this.dtpIniBrkSab.Size = new System.Drawing.Size(72, 21);
            this.dtpIniBrkSab.TabIndex = 154;
            // 
            // dtpIniBrkMie
            // 
            this.dtpIniBrkMie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniBrkMie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniBrkMie.Location = new System.Drawing.Point(159, 108);
            this.dtpIniBrkMie.Name = "dtpIniBrkMie";
            this.dtpIniBrkMie.Size = new System.Drawing.Size(72, 21);
            this.dtpIniBrkMie.TabIndex = 148;
            // 
            // dtpIniLabLun
            // 
            this.dtpIniLabLun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniLabLun.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniLabLun.Location = new System.Drawing.Point(3, 58);
            this.dtpIniLabLun.Name = "dtpIniLabLun";
            this.dtpIniLabLun.Size = new System.Drawing.Size(72, 21);
            this.dtpIniLabLun.TabIndex = 128;
            // 
            // dtpFinLabMie
            // 
            this.dtpFinLabMie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinLabMie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinLabMie.Location = new System.Drawing.Point(81, 108);
            this.dtpFinLabMie.Name = "dtpFinLabMie";
            this.dtpFinLabMie.Size = new System.Drawing.Size(72, 21);
            this.dtpFinLabMie.TabIndex = 133;
            // 
            // dtpFinBrkVie
            // 
            this.dtpFinBrkVie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinBrkVie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinBrkVie.Location = new System.Drawing.Point(237, 158);
            this.dtpFinBrkVie.Name = "dtpFinBrkVie";
            this.dtpFinBrkVie.Size = new System.Drawing.Size(72, 21);
            this.dtpFinBrkVie.TabIndex = 153;
            // 
            // dtpFinBrkMie
            // 
            this.dtpFinBrkMie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinBrkMie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinBrkMie.Location = new System.Drawing.Point(237, 108);
            this.dtpFinBrkMie.Name = "dtpFinBrkMie";
            this.dtpFinBrkMie.Size = new System.Drawing.Size(72, 21);
            this.dtpFinBrkMie.TabIndex = 149;
            // 
            // dtpFinLabLun
            // 
            this.dtpFinLabLun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinLabLun.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinLabLun.Location = new System.Drawing.Point(81, 58);
            this.dtpFinLabLun.Name = "dtpFinLabLun";
            this.dtpFinLabLun.Size = new System.Drawing.Size(72, 21);
            this.dtpFinLabLun.TabIndex = 129;
            // 
            // dtpIniLabMie
            // 
            this.dtpIniLabMie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniLabMie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniLabMie.Location = new System.Drawing.Point(3, 108);
            this.dtpIniLabMie.Name = "dtpIniLabMie";
            this.dtpIniLabMie.Size = new System.Drawing.Size(72, 21);
            this.dtpIniLabMie.TabIndex = 132;
            // 
            // dtpIniBrkVie
            // 
            this.dtpIniBrkVie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniBrkVie.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniBrkVie.Location = new System.Drawing.Point(159, 158);
            this.dtpIniBrkVie.Name = "dtpIniBrkVie";
            this.dtpIniBrkVie.Size = new System.Drawing.Size(72, 21);
            this.dtpIniBrkVie.TabIndex = 152;
            // 
            // dtpIniBrkJue
            // 
            this.dtpIniBrkJue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniBrkJue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniBrkJue.Location = new System.Drawing.Point(159, 133);
            this.dtpIniBrkJue.Name = "dtpIniBrkJue";
            this.dtpIniBrkJue.Size = new System.Drawing.Size(72, 21);
            this.dtpIniBrkJue.TabIndex = 150;
            // 
            // dtpIniLabMar
            // 
            this.dtpIniLabMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpIniLabMar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpIniLabMar.Location = new System.Drawing.Point(3, 83);
            this.dtpIniLabMar.Name = "dtpIniLabMar";
            this.dtpIniLabMar.Size = new System.Drawing.Size(72, 21);
            this.dtpIniLabMar.TabIndex = 130;
            // 
            // dtpFinLabMar
            // 
            this.dtpFinLabMar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinLabMar.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinLabMar.Location = new System.Drawing.Point(81, 83);
            this.dtpFinLabMar.Name = "dtpFinLabMar";
            this.dtpFinLabMar.Size = new System.Drawing.Size(72, 21);
            this.dtpFinLabMar.TabIndex = 131;
            // 
            // dtpFinBrkJue
            // 
            this.dtpFinBrkJue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinBrkJue.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFinBrkJue.Location = new System.Drawing.Point(237, 133);
            this.dtpFinBrkJue.Name = "dtpFinBrkJue";
            this.dtpFinBrkJue.Size = new System.Drawing.Size(72, 21);
            this.dtpFinBrkJue.TabIndex = 151;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel14.Location = new System.Drawing.Point(5, 24);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(28, 19);
            this.metroLabel14.TabIndex = 181;
            this.metroLabel14.Text = "Día";
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkDomingo.Location = new System.Drawing.Point(5, 56);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(82, 19);
            this.chkDomingo.TabIndex = 180;
            this.chkDomingo.Text = "Domingo";
            this.chkDomingo.UseSelectable = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkLunes.Location = new System.Drawing.Point(5, 81);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(61, 19);
            this.chkLunes.TabIndex = 120;
            this.chkLunes.Text = "Lunes";
            this.chkLunes.UseSelectable = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(0, 8);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(118, 30);
            this.btnNuevo.TabIndex = 176;
            this.btnNuevo.Text = "Asignar fechas";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnDesasignarFechas
            // 
            this.btnDesasignarFechas.BackColor = System.Drawing.Color.IndianRed;
            this.btnDesasignarFechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDesasignarFechas.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDesasignarFechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDesasignarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesasignarFechas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignarFechas.ForeColor = System.Drawing.Color.White;
            this.btnDesasignarFechas.Image = ((System.Drawing.Image)(resources.GetObject("btnDesasignarFechas.Image")));
            this.btnDesasignarFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesasignarFechas.Location = new System.Drawing.Point(124, 8);
            this.btnDesasignarFechas.Name = "btnDesasignarFechas";
            this.btnDesasignarFechas.Size = new System.Drawing.Size(118, 30);
            this.btnDesasignarFechas.TabIndex = 177;
            this.btnDesasignarFechas.Text = "Quitar fechas";
            this.btnDesasignarFechas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesasignarFechas.UseVisualStyleBackColor = false;
            this.btnDesasignarFechas.Click += new System.EventHandler(this.btnDesasignarFechas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(3, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(703, 50);
            this.label1.TabIndex = 197;
            this.label1.Text = "Busque al empleado y asigne o quite fechas";
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.grbDatosEmpleado);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(723, 273);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Datos Empleado";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // grbDatosEmpleado
            // 
            this.grbDatosEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.grbDatosEmpleado.Controls.Add(this.txtFinContrato);
            this.grbDatosEmpleado.Controls.Add(this.txtInicioContrato);
            this.grbDatosEmpleado.Controls.Add(this.metroLabel6);
            this.grbDatosEmpleado.Controls.Add(this.metroLabel7);
            this.grbDatosEmpleado.Controls.Add(this.metroLabel8);
            this.grbDatosEmpleado.Controls.Add(this.lstTrabajo);
            this.grbDatosEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.grbDatosEmpleado.Controls.Add(this.picFotoEmp);
            this.grbDatosEmpleado.Controls.Add(this.lblApeNom);
            this.grbDatosEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosEmpleado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbDatosEmpleado.Location = new System.Drawing.Point(4, 12);
            this.grbDatosEmpleado.Name = "grbDatosEmpleado";
            this.grbDatosEmpleado.Size = new System.Drawing.Size(707, 211);
            this.grbDatosEmpleado.TabIndex = 73;
            this.grbDatosEmpleado.TabStop = false;
            this.grbDatosEmpleado.Text = "Datos del Empleado";
            // 
            // txtFinContrato
            // 
            this.txtFinContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtFinContrato.CustomButton.Image = null;
            this.txtFinContrato.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtFinContrato.CustomButton.Name = "";
            this.txtFinContrato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFinContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFinContrato.CustomButton.TabIndex = 1;
            this.txtFinContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFinContrato.CustomButton.UseSelectable = true;
            this.txtFinContrato.CustomButton.Visible = false;
            this.txtFinContrato.Enabled = false;
            this.txtFinContrato.Lines = new string[0];
            this.txtFinContrato.Location = new System.Drawing.Point(439, 164);
            this.txtFinContrato.MaxLength = 32767;
            this.txtFinContrato.Name = "txtFinContrato";
            this.txtFinContrato.PasswordChar = '\0';
            this.txtFinContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFinContrato.SelectedText = "";
            this.txtFinContrato.SelectionLength = 0;
            this.txtFinContrato.SelectionStart = 0;
            this.txtFinContrato.ShortcutsEnabled = true;
            this.txtFinContrato.Size = new System.Drawing.Size(100, 23);
            this.txtFinContrato.TabIndex = 120;
            this.txtFinContrato.UseCustomBackColor = true;
            this.txtFinContrato.UseSelectable = true;
            this.txtFinContrato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFinContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtInicioContrato
            // 
            this.txtInicioContrato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInicioContrato.CustomButton.Image = null;
            this.txtInicioContrato.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtInicioContrato.CustomButton.Name = "";
            this.txtInicioContrato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInicioContrato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInicioContrato.CustomButton.TabIndex = 1;
            this.txtInicioContrato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInicioContrato.CustomButton.UseSelectable = true;
            this.txtInicioContrato.CustomButton.Visible = false;
            this.txtInicioContrato.Enabled = false;
            this.txtInicioContrato.Lines = new string[0];
            this.txtInicioContrato.Location = new System.Drawing.Point(439, 105);
            this.txtInicioContrato.MaxLength = 32767;
            this.txtInicioContrato.Name = "txtInicioContrato";
            this.txtInicioContrato.PasswordChar = '\0';
            this.txtInicioContrato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInicioContrato.SelectedText = "";
            this.txtInicioContrato.SelectionLength = 0;
            this.txtInicioContrato.SelectionStart = 0;
            this.txtInicioContrato.ShortcutsEnabled = true;
            this.txtInicioContrato.Size = new System.Drawing.Size(100, 23);
            this.txtInicioContrato.TabIndex = 120;
            this.txtInicioContrato.UseCustomBackColor = true;
            this.txtInicioContrato.UseSelectable = true;
            this.txtInicioContrato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInicioContrato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel6.Location = new System.Drawing.Point(439, 142);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(82, 19);
            this.metroLabel6.TabIndex = 119;
            this.metroLabel6.Text = "Fin contrato:";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel7.Location = new System.Drawing.Point(439, 83);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 19);
            this.metroLabel7.TabIndex = 116;
            this.metroLabel7.Text = "Inicio contrato:";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel8.Location = new System.Drawing.Point(20, 83);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(60, 19);
            this.metroLabel8.TabIndex = 115;
            this.metroLabel8.Text = "Trabajos:";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // lstTrabajo
            // 
            this.lstTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lstTrabajo.Enabled = false;
            this.lstTrabajo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstTrabajo.Location = new System.Drawing.Point(20, 105);
            this.lstTrabajo.Name = "lstTrabajo";
            this.lstTrabajo.Size = new System.Drawing.Size(413, 82);
            this.lstTrabajo.TabIndex = 114;
            this.lstTrabajo.UseCompatibleStateImageBehavior = false;
            this.lstTrabajo.View = System.Windows.Forms.View.List;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNombreEmpleado.CustomButton.Image = null;
            this.txtNombreEmpleado.CustomButton.Location = new System.Drawing.Point(497, 1);
            this.txtNombreEmpleado.CustomButton.Name = "";
            this.txtNombreEmpleado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreEmpleado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreEmpleado.CustomButton.TabIndex = 1;
            this.txtNombreEmpleado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreEmpleado.CustomButton.UseSelectable = true;
            this.txtNombreEmpleado.CustomButton.Visible = false;
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Lines = new string[0];
            this.txtNombreEmpleado.Location = new System.Drawing.Point(20, 49);
            this.txtNombreEmpleado.MaxLength = 32767;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.ShortcutsEnabled = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(519, 23);
            this.txtNombreEmpleado.TabIndex = 113;
            this.txtNombreEmpleado.UseCustomBackColor = true;
            this.txtNombreEmpleado.UseSelectable = true;
            this.txtNombreEmpleado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreEmpleado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // picFotoEmp
            // 
            this.picFotoEmp.Image = ((System.Drawing.Image)(resources.GetObject("picFotoEmp.Image")));
            this.picFotoEmp.Location = new System.Drawing.Point(545, 27);
            this.picFotoEmp.Name = "picFotoEmp";
            this.picFotoEmp.Size = new System.Drawing.Size(140, 160);
            this.picFotoEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoEmp.TabIndex = 112;
            this.picFotoEmp.TabStop = false;
            // 
            // lblApeNom
            // 
            this.lblApeNom.AutoSize = true;
            this.lblApeNom.ForeColor = System.Drawing.Color.Navy;
            this.lblApeNom.Location = new System.Drawing.Point(20, 27);
            this.lblApeNom.Name = "lblApeNom";
            this.lblApeNom.Size = new System.Drawing.Size(132, 19);
            this.lblApeNom.TabIndex = 111;
            this.lblApeNom.Text = "Apellidos y nombres:";
            this.lblApeNom.UseCustomForeColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRangoHorario);
            this.groupBox1.Controls.Add(this.lblNombreEmpleado);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(405, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 76);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado y horario";
            // 
            // lblRangoHorario
            // 
            this.lblRangoHorario.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblRangoHorario.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblRangoHorario.ForeColor = System.Drawing.Color.Navy;
            this.lblRangoHorario.Location = new System.Drawing.Point(6, 47);
            this.lblRangoHorario.Name = "lblRangoHorario";
            this.lblRangoHorario.Size = new System.Drawing.Size(343, 26);
            this.lblRangoHorario.TabIndex = 181;
            this.lblRangoHorario.Text = "Rango del horario establecido";
            this.lblRangoHorario.UseCustomForeColor = true;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreEmpleado.Location = new System.Drawing.Point(6, 22);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(343, 25);
            this.lblNombreEmpleado.TabIndex = 176;
            this.lblNombreEmpleado.Text = "NOMBRE COMPLETO DEL EMPLEADO";
            // 
            // grbDetalleDia
            // 
            this.grbDetalleDia.Controls.Add(this.btnGuardar);
            this.grbDetalleDia.Controls.Add(this.chkModificarEnTodosLosMismosDias);
            this.grbDetalleDia.Controls.Add(this.metroLabel9);
            this.grbDetalleDia.Controls.Add(this.dateTimePicker3);
            this.grbDetalleDia.Controls.Add(this.metroLabel10);
            this.grbDetalleDia.Controls.Add(this.metroLabel13);
            this.grbDetalleDia.Controls.Add(this.dateTimePicker1);
            this.grbDetalleDia.Controls.Add(this.metroLabel12);
            this.grbDetalleDia.Controls.Add(this.metroLabel11);
            this.grbDetalleDia.Controls.Add(this.dateTimePicker5);
            this.grbDetalleDia.Controls.Add(this.dateTimePicker2);
            this.grbDetalleDia.Controls.Add(this.dateTimePicker4);
            this.grbDetalleDia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDetalleDia.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbDetalleDia.Location = new System.Drawing.Point(33, 640);
            this.grbDetalleDia.Name = "grbDetalleDia";
            this.grbDetalleDia.Size = new System.Drawing.Size(731, 92);
            this.grbDetalleDia.TabIndex = 176;
            this.grbDetalleDia.TabStop = false;
            this.grbDetalleDia.Text = "Detalle del día";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(597, 48);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(118, 30);
            this.btnGuardar.TabIndex = 191;
            this.btnGuardar.Text = "Guardar cambio";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // chkModificarEnTodosLosMismosDias
            // 
            this.chkModificarEnTodosLosMismosDias.AutoSize = true;
            this.chkModificarEnTodosLosMismosDias.Location = new System.Drawing.Point(430, 26);
            this.chkModificarEnTodosLosMismosDias.Name = "chkModificarEnTodosLosMismosDias";
            this.chkModificarEnTodosLosMismosDias.Size = new System.Drawing.Size(285, 15);
            this.chkModificarEnTodosLosMismosDias.TabIndex = 181;
            this.chkModificarEnTodosLosMismosDias.Text = "Modificar en todos los días con el mismo nombre";
            this.chkModificarEnTodosLosMismosDias.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel9.Location = new System.Drawing.Point(13, 22);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(72, 19);
            this.metroLabel9.TabIndex = 181;
            this.metroLabel9.Text = "Hora Inicio";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(91, 48);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(72, 21);
            this.dateTimePicker3.TabIndex = 184;
            this.dateTimePicker3.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel10.Location = new System.Drawing.Point(98, 22);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 19);
            this.metroLabel10.TabIndex = 182;
            this.metroLabel10.Text = "Hora Fin";
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel13.Location = new System.Drawing.Point(252, 22);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(63, 19);
            this.metroLabel13.TabIndex = 186;
            this.metroLabel13.Text = "Fin Break";
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(325, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(72, 21);
            this.dateTimePicker1.TabIndex = 190;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel12.Location = new System.Drawing.Point(167, 22);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(76, 19);
            this.metroLabel12.TabIndex = 185;
            this.metroLabel12.Text = "Inicio Break";
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel11.Location = new System.Drawing.Point(328, 22);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 19);
            this.metroLabel11.TabIndex = 189;
            this.metroLabel11.Text = "Tolerancia";
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.CustomFormat = "";
            this.dateTimePicker5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker5.Location = new System.Drawing.Point(169, 48);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(72, 21);
            this.dateTimePicker5.TabIndex = 187;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(13, 48);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(72, 21);
            this.dateTimePicker2.TabIndex = 183;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(247, 48);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(72, 21);
            this.dateTimePicker4.TabIndex = 188;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(673, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 196;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormHorarioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 756);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbDetalleDia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabHorario);
            this.Controls.Add(this.mcaMes);
            this.Controls.Add(this.grbBuscarEmp);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.MaximizeBox = false;
            this.Name = "FormHorarioEmpleado";
            this.Load += new System.EventHandler(this.FormHorarioEmpleado_Load);
            this.grbBuscarEmp.ResumeLayout(false);
            this.grbBuscarEmp.PerformLayout();
            this.tabHorario.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            this.pnlControlesGenerales.ResumeLayout(false);
            this.pnlControlesGenerales.PerformLayout();
            this.pnlHoras.ResumeLayout(false);
            this.pnlHoras.PerformLayout();
            this.metroTabPage1.ResumeLayout(false);
            this.grbDatosEmpleado.ResumeLayout(false);
            this.grbDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoEmp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.grbDetalleDia.ResumeLayout(false);
            this.grbDetalleDia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBuscarEmp;
        private MetroFramework.Controls.MetroLabel lblNroDocEmp;
        private MetroFramework.Controls.MetroTextBox txtNroDocEmp;
        private System.Windows.Forms.Button btnBuscarEmp;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.MonthCalendar mcaMes;
        private MetroFramework.Controls.MetroCheckBox chkSabado;
        private MetroFramework.Controls.MetroLabel lblDomHf;
        private MetroFramework.Controls.MetroCheckBox chkViernes;
        private MetroFramework.Controls.MetroLabel lblDomHi;
        private MetroFramework.Controls.MetroCheckBox chkJueves;
        private MetroFramework.Controls.MetroCheckBox chkMartes;
        private MetroFramework.Controls.MetroCheckBox chkMiercoles;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTabControl tabHorario;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.GroupBox grbDatosEmpleado;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.ListView lstTrabajo;
        private MetroFramework.Controls.MetroTextBox txtNombreEmpleado;
        private System.Windows.Forms.PictureBox picFotoEmp;
        private MetroFramework.Controls.MetroLabel lblApeNom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnDesasignarFechas;
        private System.Windows.Forms.DateTimePicker dtpToleranciaSab;
        private System.Windows.Forms.DateTimePicker dtpToleranciaVie;
        private System.Windows.Forms.DateTimePicker dtpToleranciaJue;
        private System.Windows.Forms.DateTimePicker dtpToleranciaMie;
        private System.Windows.Forms.DateTimePicker dtpToleranciaMar;
        private System.Windows.Forms.DateTimePicker dtpToleranciaLun;
        private System.Windows.Forms.DateTimePicker dtpToleranciaDom;
        private System.Windows.Forms.DateTimePicker dtpIniLabDom;
        private System.Windows.Forms.DateTimePicker dtpFinBrkSab;
        private System.Windows.Forms.DateTimePicker dtpFinLabDom;
        private System.Windows.Forms.DateTimePicker dtpIniBrkSab;
        private System.Windows.Forms.DateTimePicker dtpIniLabLun;
        private System.Windows.Forms.DateTimePicker dtpFinBrkVie;
        private System.Windows.Forms.DateTimePicker dtpFinLabLun;
        private System.Windows.Forms.DateTimePicker dtpIniBrkVie;
        private System.Windows.Forms.DateTimePicker dtpIniLabMar;
        private System.Windows.Forms.DateTimePicker dtpFinBrkJue;
        private System.Windows.Forms.DateTimePicker dtpFinLabMar;
        private System.Windows.Forms.DateTimePicker dtpIniBrkJue;
        private System.Windows.Forms.DateTimePicker dtpIniLabMie;
        private System.Windows.Forms.DateTimePicker dtpFinBrkMie;
        private System.Windows.Forms.DateTimePicker dtpFinLabMie;
        private System.Windows.Forms.DateTimePicker dtpIniBrkMie;
        private System.Windows.Forms.DateTimePicker dtpIniLabJue;
        private System.Windows.Forms.DateTimePicker dtpFinBrkMar;
        private System.Windows.Forms.DateTimePicker dtpFinLabJue;
        private System.Windows.Forms.DateTimePicker dtpIniBrkMar;
        private System.Windows.Forms.DateTimePicker dtpIniLabVie;
        private System.Windows.Forms.DateTimePicker dtpFinBrkLun;
        private System.Windows.Forms.DateTimePicker dtpFinLabVie;
        private System.Windows.Forms.DateTimePicker dtpIniBrkLun;
        private System.Windows.Forms.DateTimePicker dtpIniLabSab;
        private System.Windows.Forms.DateTimePicker dtpFinBrkDom;
        private System.Windows.Forms.DateTimePicker dtpFinLabSab;
        private System.Windows.Forms.DateTimePicker dtpIniBrkDom;
        private MetroFramework.Controls.MetroCheckBox chkLunes;
        private MetroFramework.Controls.MetroCheckBox chkDomingo;
        private MetroFramework.Controls.MetroTextBox txtFinContrato;
        private MetroFramework.Controls.MetroTextBox txtInicioContrato;
        private MetroFramework.Controls.MetroLabel lblRangoHorario;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.GroupBox grbDetalleDia;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroCheckBox chkModificarEnTodosLosMismosDias;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.Panel pnlHoras;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Panel pnlControlesGenerales;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel lblOperacionActual;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private System.Windows.Forms.Label label1;
    }
}