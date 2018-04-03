using ConfigUtilitarios.Controls;
using CustomControls;

namespace ConfiguradorUI.Labor.Horario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mesero");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Cocinero");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Gerente");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorarioEmpleado));
            this.grbBuscarEmp = new System.Windows.Forms.GroupBox();
            this.lblNroDocEmp = new MetroFramework.Controls.MetroLabel();
            this.txtNroDocEmp = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.tabHorario = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.cboCanalVenta = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.button2 = new System.Windows.Forms.Button();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.btnAsignarHorario = new System.Windows.Forms.Button();
            this.btnDesasignarFechas = new System.Windows.Forms.Button();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.txtFinContrato = new MetroFramework.Controls.MetroTextBox();
            this.txtInicioContrato = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblApeNom = new MetroFramework.Controls.MetroLabel();
            this.lstTrabajo = new System.Windows.Forms.ListView();
            this.txtNombreEmpleado = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRangoHorario = new MetroFramework.Controls.MetroLabel();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mcaMes = new CustomControls.MonthCalendar();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.ctxMenuDate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAgregarOEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.button3 = new System.Windows.Forms.Button();
            this.grbBuscarEmp.SuspendLayout();
            this.tabHorario.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctxMenuDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBuscarEmp
            // 
            this.grbBuscarEmp.Controls.Add(this.lblNroDocEmp);
            this.grbBuscarEmp.Controls.Add(this.txtNroDocEmp);
            this.grbBuscarEmp.Controls.Add(this.btnBuscarEmp);
            this.grbBuscarEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscarEmp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbBuscarEmp.Location = new System.Drawing.Point(38, 85);
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
            this.lblNombreForm.Location = new System.Drawing.Point(85, 35);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(256, 32);
            this.lblNombreForm.TabIndex = 114;
            this.lblNombreForm.Text = "Horarios de empleados";
            // 
            // tabHorario
            // 
            this.tabHorario.Controls.Add(this.tabPagGeneral);
            this.tabHorario.Controls.Add(this.metroTabPage1);
            this.tabHorario.Location = new System.Drawing.Point(43, 162);
            this.tabHorario.Name = "tabHorario";
            this.tabHorario.SelectedIndex = 0;
            this.tabHorario.Size = new System.Drawing.Size(737, 119);
            this.tabHorario.TabIndex = 175;
            this.tabHorario.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.button3);
            this.tabPagGeneral.Controls.Add(this.button2);
            this.tabPagGeneral.Controls.Add(this.cboCanalVenta);
            this.tabPagGeneral.Controls.Add(this.metroLabel1);
            this.tabPagGeneral.Controls.Add(this.metroLabel16);
            this.tabPagGeneral.Controls.Add(this.metroLabel15);
            this.tabPagGeneral.Controls.Add(this.btnAsignarHorario);
            this.tabPagGeneral.Controls.Add(this.btnDesasignarFechas);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(729, 77);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // cboCanalVenta
            // 
            this.cboCanalVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboCanalVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCanalVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCanalVenta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCanalVenta.FormattingEnabled = true;
            this.cboCanalVenta.Location = new System.Drawing.Point(597, 54);
            this.cboCanalVenta.Name = "cboCanalVenta";
            this.cboCanalVenta.Size = new System.Drawing.Size(123, 23);
            this.cboCanalVenta.TabIndex = 200;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(548, 56);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 199;
            this.metroLabel1.Text = "Tema:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 23);
            this.button2.TabIndex = 198;
            this.button2.Text = "Ir a último día";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroLabel16.Location = new System.Drawing.Point(541, 23);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(179, 19);
            this.metroLabel16.TabIndex = 196;
            this.metroLabel16.Text = "Formato de horas: HH:mm tt";
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
            // btnAsignarHorario
            // 
            this.btnAsignarHorario.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAsignarHorario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAsignarHorario.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAsignarHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnAsignarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarHorario.ForeColor = System.Drawing.Color.White;
            this.btnAsignarHorario.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarHorario.Image")));
            this.btnAsignarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarHorario.Location = new System.Drawing.Point(0, 8);
            this.btnAsignarHorario.Name = "btnAsignarHorario";
            this.btnAsignarHorario.Size = new System.Drawing.Size(132, 30);
            this.btnAsignarHorario.TabIndex = 176;
            this.btnAsignarHorario.Text = "Asignar horario";
            this.btnAsignarHorario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarHorario.UseVisualStyleBackColor = false;
            this.btnAsignarHorario.Click += new System.EventHandler(this.btnAsignarHorario_Click);
            // 
            // btnDesasignarFechas
            // 
            this.btnDesasignarFechas.BackColor = System.Drawing.Color.IndianRed;
            this.btnDesasignarFechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDesasignarFechas.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDesasignarFechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDesasignarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesasignarFechas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignarFechas.ForeColor = System.Drawing.Color.White;
            this.btnDesasignarFechas.Image = ((System.Drawing.Image)(resources.GetObject("btnDesasignarFechas.Image")));
            this.btnDesasignarFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesasignarFechas.Location = new System.Drawing.Point(138, 8);
            this.btnDesasignarFechas.Name = "btnDesasignarFechas";
            this.btnDesasignarFechas.Size = new System.Drawing.Size(118, 30);
            this.btnDesasignarFechas.TabIndex = 177;
            this.btnDesasignarFechas.Text = "Quitar fechas";
            this.btnDesasignarFechas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesasignarFechas.UseVisualStyleBackColor = false;
            this.btnDesasignarFechas.Click += new System.EventHandler(this.btnDesasignarFechas_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.txtFinContrato);
            this.metroTabPage1.Controls.Add(this.txtInicioContrato);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.lblApeNom);
            this.metroTabPage1.Controls.Add(this.lstTrabajo);
            this.metroTabPage1.Controls.Add(this.txtNombreEmpleado);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(729, 77);
            this.metroTabPage1.TabIndex = 1;
            this.metroTabPage1.Text = "Datos Empleado";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
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
            this.txtFinContrato.Location = new System.Drawing.Point(337, 43);
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
            this.txtInicioContrato.Location = new System.Drawing.Point(138, 43);
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
            this.metroLabel6.Location = new System.Drawing.Point(249, 45);
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
            this.metroLabel7.Location = new System.Drawing.Point(4, 45);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(95, 19);
            this.metroLabel7.TabIndex = 116;
            this.metroLabel7.Text = "Inicio contrato:";
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // lblApeNom
            // 
            this.lblApeNom.AutoSize = true;
            this.lblApeNom.ForeColor = System.Drawing.Color.Navy;
            this.lblApeNom.Location = new System.Drawing.Point(0, 13);
            this.lblApeNom.Name = "lblApeNom";
            this.lblApeNom.Size = new System.Drawing.Size(132, 19);
            this.lblApeNom.TabIndex = 111;
            this.lblApeNom.Text = "Apellidos y nombres:";
            this.lblApeNom.UseCustomForeColor = true;
            // 
            // lstTrabajo
            // 
            this.lstTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lstTrabajo.Enabled = false;
            this.lstTrabajo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstTrabajo.Location = new System.Drawing.Point(449, 11);
            this.lstTrabajo.Name = "lstTrabajo";
            this.lstTrabajo.Size = new System.Drawing.Size(268, 59);
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
            this.txtNombreEmpleado.CustomButton.Location = new System.Drawing.Point(277, 1);
            this.txtNombreEmpleado.CustomButton.Name = "";
            this.txtNombreEmpleado.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombreEmpleado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombreEmpleado.CustomButton.TabIndex = 1;
            this.txtNombreEmpleado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombreEmpleado.CustomButton.UseSelectable = true;
            this.txtNombreEmpleado.CustomButton.Visible = false;
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Lines = new string[0];
            this.txtNombreEmpleado.Location = new System.Drawing.Point(138, 11);
            this.txtNombreEmpleado.MaxLength = 32767;
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.PasswordChar = '\0';
            this.txtNombreEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombreEmpleado.SelectedText = "";
            this.txtNombreEmpleado.SelectionLength = 0;
            this.txtNombreEmpleado.SelectionStart = 0;
            this.txtNombreEmpleado.ShortcutsEnabled = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(299, 23);
            this.txtNombreEmpleado.TabIndex = 113;
            this.txtNombreEmpleado.UseCustomBackColor = true;
            this.txtNombreEmpleado.UseSelectable = true;
            this.txtNombreEmpleado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombreEmpleado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRangoHorario);
            this.groupBox1.Controls.Add(this.lblNombreEmpleado);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(410, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 76);
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
            this.lblRangoHorario.Size = new System.Drawing.Size(360, 26);
            this.lblRangoHorario.TabIndex = 181;
            this.lblRangoHorario.Text = "Rango del horario establecido";
            this.lblRangoHorario.UseCustomForeColor = true;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNombreEmpleado.Location = new System.Drawing.Point(6, 22);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(360, 25);
            this.lblNombreEmpleado.TabIndex = 176;
            this.lblNombreEmpleado.Text = "NOMBRE COMPLETO DEL EMPLEADO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(678, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 196;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mcaMes
            // 
            this.mcaMes.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.mcaMes.ColorTable.DayActiveTodayCircleBorder = System.Drawing.Color.DarkOrange;
            this.mcaMes.ColorTable.DaySelectedTodayCircleBorder = System.Drawing.Color.DarkOrange;
            this.mcaMes.ColorTable.DayTextBold = System.Drawing.Color.MediumSeaGreen;
            this.mcaMes.ColorTable.DayTodayCircleBorder = System.Drawing.Color.DarkOrange;
            this.mcaMes.Culture = new System.Globalization.CultureInfo("es-PE");
            this.mcaMes.DayHeaderFont = new System.Drawing.Font("Segoe UI", 9F);
            this.mcaMes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcaMes.Location = new System.Drawing.Point(43, 283);
            this.mcaMes.Name = "mcaMes";
            this.mcaMes.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2018, 4, 1, 0, 0, 0, 0), new System.DateTime(2018, 4, 1, 0, 0, 0, 0));
            this.mcaMes.ShowFooter = false;
            this.mcaMes.TabIndex = 197;
            this.mcaMes.DoubleClick += new System.EventHandler(this.mcaMes_DoubleClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(23, 23);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 113;
            this.btnCerrar.UseSelectable = true;
            // 
            // ctxMenuDate
            // 
            this.ctxMenuDate.AutoSize = false;
            this.ctxMenuDate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAgregarOEditar,
            this.toolStripMenuItemEliminar});
            this.ctxMenuDate.Name = "ctxMenuDate";
            this.ctxMenuDate.Size = new System.Drawing.Size(153, 70);
            this.ctxMenuDate.Opening += new System.ComponentModel.CancelEventHandler(this.ctxMenuDate_Opening);
            // 
            // toolStripMenuItemAgregarOEditar
            // 
            this.toolStripMenuItemAgregarOEditar.Name = "toolStripMenuItemAgregarOEditar";
            this.toolStripMenuItemAgregarOEditar.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemAgregarOEditar.Text = "Editar";
            this.toolStripMenuItemAgregarOEditar.Click += new System.EventHandler(this.toolStripMenuItemAgregarOEditar_Click);
            // 
            // toolStripMenuItemEliminar
            // 
            this.toolStripMenuItemEliminar.Name = "toolStripMenuItemEliminar";
            this.toolStripMenuItemEliminar.Size = new System.Drawing.Size(117, 22);
            this.toolStripMenuItemEliminar.Text = "Eliminar";
            this.toolStripMenuItemEliminar.Click += new System.EventHandler(this.toolStripMenuItemEliminar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(43, 618);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(29, 15);
            this.metroLabel2.TabIndex = 110;
            this.metroLabel2.Text = "Hoy";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 30);
            this.button3.TabIndex = 201;
            this.button3.Text = "Asignar horario";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // FormHorarioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 669);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mcaMes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabHorario);
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
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ctxMenuDate.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTabControl tabHorario;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ListView lstTrabajo;
        private MetroFramework.Controls.MetroTextBox txtNombreEmpleado;
        private MetroFramework.Controls.MetroLabel lblApeNom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsignarHorario;
        private System.Windows.Forms.Button btnDesasignarFechas;
        private MetroFramework.Controls.MetroTextBox txtFinContrato;
        private MetroFramework.Controls.MetroTextBox txtInicioContrato;
        private MetroFramework.Controls.MetroLabel lblRangoHorario;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private CustomControls.MonthCalendar mcaMes;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ComboBox cboCanalVenta;
        private System.Windows.Forms.ContextMenuStrip ctxMenuDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAgregarOEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEliminar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Button button3;
    }
}