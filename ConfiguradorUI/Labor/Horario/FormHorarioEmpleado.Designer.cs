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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorarioEmpleado));
            this.grbBuscarEmp = new System.Windows.Forms.GroupBox();
            this.lblNroDocEmp = new MetroFramework.Controls.MetroLabel();
            this.txtNroDocEmp = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.tabHorario = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblColorDiasLaborales = new MetroFramework.Controls.MetroLabel();
            this.picColorDiaDeTrabajo = new System.Windows.Forms.PictureBox();
            this.btnUltimoDiaTrabajo = new System.Windows.Forms.Button();
            this.btnPrimerDiaTrabajo = new System.Windows.Forms.Button();
            this.lblDiasDeTrabajoRestantes = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnHoy = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEditarHorario = new System.Windows.Forms.Button();
            this.btnQuitarFechas = new System.Windows.Forms.Button();
            this.btnAsignarHorario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFechaCese = new MetroFramework.Controls.MetroLabel();
            this.lblFechaIngreso = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblRuc = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblNumDoc = new MetroFramework.Controls.MetroLabel();
            this.lblMensajeNoTieneHorario = new MetroFramework.Controls.MetroLabel();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.mcaMes = new CustomControls.MonthCalendar();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.ctxMenuDate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAgregarOEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.grbBuscarEmp.SuspendLayout();
            this.tabHorario.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorDiaDeTrabajo)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.grbBuscarEmp.Location = new System.Drawing.Point(38, 89);
            this.grbBuscarEmp.Name = "grbBuscarEmp";
            this.grbBuscarEmp.Size = new System.Drawing.Size(289, 87);
            this.grbBuscarEmp.TabIndex = 115;
            this.grbBuscarEmp.TabStop = false;
            this.grbBuscarEmp.Text = "Buscar empleado";
            // 
            // lblNroDocEmp
            // 
            this.lblNroDocEmp.AutoSize = true;
            this.lblNroDocEmp.ForeColor = System.Drawing.Color.Navy;
            this.lblNroDocEmp.Location = new System.Drawing.Point(18, 28);
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
            this.txtNroDocEmp.CustomButton.Location = new System.Drawing.Point(141, 1);
            this.txtNroDocEmp.CustomButton.Name = "";
            this.txtNroDocEmp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNroDocEmp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroDocEmp.CustomButton.TabIndex = 1;
            this.txtNroDocEmp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroDocEmp.CustomButton.UseSelectable = true;
            this.txtNroDocEmp.CustomButton.Visible = false;
            this.txtNroDocEmp.Lines = new string[0];
            this.txtNroDocEmp.Location = new System.Drawing.Point(20, 50);
            this.txtNroDocEmp.MaxLength = 32767;
            this.txtNroDocEmp.Name = "txtNroDocEmp";
            this.txtNroDocEmp.PasswordChar = '\0';
            this.txtNroDocEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroDocEmp.SelectedText = "";
            this.txtNroDocEmp.SelectionLength = 0;
            this.txtNroDocEmp.SelectionStart = 0;
            this.txtNroDocEmp.ShortcutsEnabled = true;
            this.txtNroDocEmp.Size = new System.Drawing.Size(163, 23);
            this.txtNroDocEmp.TabIndex = 109;
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
            this.btnBuscarEmp.Location = new System.Drawing.Point(189, 49);
            this.btnBuscarEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(81, 24);
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
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(256, 32);
            this.lblNombreForm.TabIndex = 114;
            this.lblNombreForm.Text = "Horarios de empleados";
            // 
            // tabHorario
            // 
            this.tabHorario.Controls.Add(this.tabPagGeneral);
            this.tabHorario.Location = new System.Drawing.Point(43, 170);
            this.tabHorario.Name = "tabHorario";
            this.tabHorario.SelectedIndex = 0;
            this.tabHorario.Size = new System.Drawing.Size(737, 147);
            this.tabHorario.TabIndex = 175;
            this.tabHorario.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.groupBox3);
            this.tabPagGeneral.Controls.Add(this.groupBox2);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(729, 105);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.lblColorDiasLaborales);
            this.groupBox3.Controls.Add(this.picColorDiaDeTrabajo);
            this.groupBox3.Controls.Add(this.btnUltimoDiaTrabajo);
            this.groupBox3.Controls.Add(this.btnPrimerDiaTrabajo);
            this.groupBox3.Controls.Add(this.lblDiasDeTrabajoRestantes);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.btnHoy);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(297, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 98);
            this.groupBox3.TabIndex = 204;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del horario";
            // 
            // lblColorDiasLaborales
            // 
            this.lblColorDiasLaborales.AutoSize = true;
            this.lblColorDiasLaborales.ForeColor = System.Drawing.Color.Navy;
            this.lblColorDiasLaborales.Location = new System.Drawing.Point(257, 47);
            this.lblColorDiasLaborales.Name = "lblColorDiasLaborales";
            this.lblColorDiasLaborales.Size = new System.Drawing.Size(160, 19);
            this.lblColorDiasLaborales.TabIndex = 212;
            this.lblColorDiasLaborales.Text = "Días de trabajo asignados";
            this.lblColorDiasLaborales.UseCustomForeColor = true;
            // 
            // picColorDiaDeTrabajo
            // 
            this.picColorDiaDeTrabajo.Image = ((System.Drawing.Image)(resources.GetObject("picColorDiaDeTrabajo.Image")));
            this.picColorDiaDeTrabajo.Location = new System.Drawing.Point(235, 50);
            this.picColorDiaDeTrabajo.Name = "picColorDiaDeTrabajo";
            this.picColorDiaDeTrabajo.Size = new System.Drawing.Size(16, 16);
            this.picColorDiaDeTrabajo.TabIndex = 110;
            this.picColorDiaDeTrabajo.TabStop = false;
            // 
            // btnUltimoDiaTrabajo
            // 
            this.btnUltimoDiaTrabajo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnUltimoDiaTrabajo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnUltimoDiaTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimoDiaTrabajo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoDiaTrabajo.ForeColor = System.Drawing.Color.Black;
            this.btnUltimoDiaTrabajo.Location = new System.Drawing.Point(152, 66);
            this.btnUltimoDiaTrabajo.Name = "btnUltimoDiaTrabajo";
            this.btnUltimoDiaTrabajo.Size = new System.Drawing.Size(76, 23);
            this.btnUltimoDiaTrabajo.TabIndex = 211;
            this.btnUltimoDiaTrabajo.Text = "-";
            this.btnUltimoDiaTrabajo.UseVisualStyleBackColor = false;
            // 
            // btnPrimerDiaTrabajo
            // 
            this.btnPrimerDiaTrabajo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrimerDiaTrabajo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPrimerDiaTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimerDiaTrabajo.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimerDiaTrabajo.ForeColor = System.Drawing.Color.Black;
            this.btnPrimerDiaTrabajo.Location = new System.Drawing.Point(152, 43);
            this.btnPrimerDiaTrabajo.Name = "btnPrimerDiaTrabajo";
            this.btnPrimerDiaTrabajo.Size = new System.Drawing.Size(76, 23);
            this.btnPrimerDiaTrabajo.TabIndex = 210;
            this.btnPrimerDiaTrabajo.Text = "-";
            this.btnPrimerDiaTrabajo.UseVisualStyleBackColor = false;
            // 
            // lblDiasDeTrabajoRestantes
            // 
            this.lblDiasDeTrabajoRestantes.AutoSize = true;
            this.lblDiasDeTrabajoRestantes.ForeColor = System.Drawing.Color.Navy;
            this.lblDiasDeTrabajoRestantes.Location = new System.Drawing.Point(394, 25);
            this.lblDiasDeTrabajoRestantes.Name = "lblDiasDeTrabajoRestantes";
            this.lblDiasDeTrabajoRestantes.Size = new System.Drawing.Size(15, 19);
            this.lblDiasDeTrabajoRestantes.TabIndex = 207;
            this.lblDiasDeTrabajoRestantes.Text = "-";
            this.lblDiasDeTrabajoRestantes.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel5.Location = new System.Drawing.Point(235, 24);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(156, 19);
            this.metroLabel5.TabIndex = 206;
            this.metroLabel5.Text = "Días de trabajo restantes:";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // btnHoy
            // 
            this.btnHoy.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHoy.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoy.ForeColor = System.Drawing.Color.Black;
            this.btnHoy.Location = new System.Drawing.Point(152, 20);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(76, 23);
            this.btnHoy.TabIndex = 205;
            this.btnHoy.Text = "-";
            this.btnHoy.UseVisualStyleBackColor = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel4.Location = new System.Drawing.Point(6, 24);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(103, 19);
            this.metroLabel4.TabIndex = 202;
            this.metroLabel4.Text = "Hoy (día actual):";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(6, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(139, 19);
            this.metroLabel3.TabIndex = 201;
            this.metroLabel3.Text = "Último día de horario:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(6, 47);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 19);
            this.metroLabel2.TabIndex = 200;
            this.metroLabel2.Text = "Primer día de horario:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnEditarHorario);
            this.groupBox2.Controls.Add(this.btnQuitarFechas);
            this.groupBox2.Controls.Add(this.btnAsignarHorario);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(0, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 98);
            this.groupBox2.TabIndex = 203;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones";
            // 
            // btnEditarHorario
            // 
            this.btnEditarHorario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditarHorario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditarHorario.FlatAppearance.BorderSize = 0;
            this.btnEditarHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEditarHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarHorario.ForeColor = System.Drawing.Color.White;
            this.btnEditarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarHorario.Location = new System.Drawing.Point(10, 56);
            this.btnEditarHorario.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnEditarHorario.Name = "btnEditarHorario";
            this.btnEditarHorario.Size = new System.Drawing.Size(133, 30);
            this.btnEditarHorario.TabIndex = 203;
            this.btnEditarHorario.Text = "Editar horario";
            this.btnEditarHorario.UseVisualStyleBackColor = false;
            this.btnEditarHorario.Click += new System.EventHandler(this.btnEditarHorario_Click);
            // 
            // btnQuitarFechas
            // 
            this.btnQuitarFechas.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnQuitarFechas.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnQuitarFechas.FlatAppearance.BorderSize = 0;
            this.btnQuitarFechas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnQuitarFechas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnQuitarFechas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarFechas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarFechas.ForeColor = System.Drawing.Color.White;
            this.btnQuitarFechas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarFechas.Location = new System.Drawing.Point(147, 22);
            this.btnQuitarFechas.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnQuitarFechas.Name = "btnQuitarFechas";
            this.btnQuitarFechas.Size = new System.Drawing.Size(133, 30);
            this.btnQuitarFechas.TabIndex = 204;
            this.btnQuitarFechas.Text = "Eliminar fechas";
            this.btnQuitarFechas.UseVisualStyleBackColor = false;
            this.btnQuitarFechas.Click += new System.EventHandler(this.btnEliminarFechas_Click);
            // 
            // btnAsignarHorario
            // 
            this.btnAsignarHorario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAsignarHorario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAsignarHorario.FlatAppearance.BorderSize = 0;
            this.btnAsignarHorario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAsignarHorario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnAsignarHorario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarHorario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarHorario.ForeColor = System.Drawing.Color.White;
            this.btnAsignarHorario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarHorario.Location = new System.Drawing.Point(10, 22);
            this.btnAsignarHorario.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnAsignarHorario.Name = "btnAsignarHorario";
            this.btnAsignarHorario.Size = new System.Drawing.Size(133, 30);
            this.btnAsignarHorario.TabIndex = 202;
            this.btnAsignarHorario.Text = "Asignar horario";
            this.btnAsignarHorario.UseVisualStyleBackColor = false;
            this.btnAsignarHorario.Click += new System.EventHandler(this.btnAsignarHorario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechaCese);
            this.groupBox1.Controls.Add(this.lblFechaIngreso);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.lblRuc);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.lblNumDoc);
            this.groupBox1.Controls.Add(this.lblMensajeNoTieneHorario);
            this.groupBox1.Controls.Add(this.lblNombreEmpleado);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(333, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 87);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleado";
            // 
            // lblFechaCese
            // 
            this.lblFechaCese.AutoSize = true;
            this.lblFechaCese.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaCese.Location = new System.Drawing.Point(324, 62);
            this.lblFechaCese.Name = "lblFechaCese";
            this.lblFechaCese.Size = new System.Drawing.Size(15, 19);
            this.lblFechaCese.TabIndex = 214;
            this.lblFechaCese.Text = "-";
            this.lblFechaCese.UseCustomForeColor = true;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaIngreso.Location = new System.Drawing.Point(103, 62);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(15, 19);
            this.lblFechaIngreso.TabIndex = 213;
            this.lblFechaIngreso.Text = "-";
            this.lblFechaIngreso.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel6.Location = new System.Drawing.Point(243, 41);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(38, 19);
            this.metroLabel6.TabIndex = 212;
            this.metroLabel6.Text = "RUC:";
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(9, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 211;
            this.metroLabel1.Text = "Número Doc:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.ForeColor = System.Drawing.Color.Navy;
            this.lblRuc.Location = new System.Drawing.Point(324, 41);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(15, 19);
            this.lblRuc.TabIndex = 210;
            this.lblRuc.Text = "-";
            this.lblRuc.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel9.Location = new System.Drawing.Point(243, 62);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(75, 19);
            this.metroLabel9.TabIndex = 209;
            this.metroLabel9.Text = "Fecha cese:";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel8.Location = new System.Drawing.Point(9, 62);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(93, 19);
            this.metroLabel8.TabIndex = 207;
            this.metroLabel8.Text = "Fecha ingreso:";
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.ForeColor = System.Drawing.Color.Navy;
            this.lblNumDoc.Location = new System.Drawing.Point(103, 41);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(15, 19);
            this.lblNumDoc.TabIndex = 205;
            this.lblNumDoc.Text = "-";
            this.lblNumDoc.UseCustomForeColor = true;
            // 
            // lblMensajeNoTieneHorario
            // 
            this.lblMensajeNoTieneHorario.AutoSize = true;
            this.lblMensajeNoTieneHorario.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblMensajeNoTieneHorario.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeNoTieneHorario.Location = new System.Drawing.Point(116, -2);
            this.lblMensajeNoTieneHorario.Name = "lblMensajeNoTieneHorario";
            this.lblMensajeNoTieneHorario.Size = new System.Drawing.Size(239, 19);
            this.lblMensajeNoTieneHorario.TabIndex = 206;
            this.lblMensajeNoTieneHorario.Text = "ASIGNE SU HORARIO DE TRABAJO";
            this.lblMensajeNoTieneHorario.UseCustomForeColor = true;
            this.lblMensajeNoTieneHorario.Visible = false;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.ForeColor = System.Drawing.Color.Navy;
            this.lblNombreEmpleado.Location = new System.Drawing.Point(9, 20);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(436, 19);
            this.lblNombreEmpleado.TabIndex = 176;
            this.lblNombreEmpleado.Text = "NOMBRE COMPLETO DEL EMPLEADO";
            // 
            // mcaMes
            // 
            this.mcaMes.CalendarDimensions = new System.Drawing.Size(3, 2);
            this.mcaMes.ColorTable.DayActiveTodayCircleBorder = System.Drawing.Color.DarkOrange;
            this.mcaMes.ColorTable.DaySelectedGradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(200)))), ((int)(((byte)(79)))));
            this.mcaMes.ColorTable.DaySelectedTodayCircleBorder = System.Drawing.Color.DarkOrange;
            this.mcaMes.ColorTable.DayTextBold = System.Drawing.Color.Red;
            this.mcaMes.ColorTable.DayTodayCircleBorder = System.Drawing.Color.DarkOrange;
            this.mcaMes.Culture = new System.Globalization.CultureInfo("es-PE");
            this.mcaMes.DayHeaderFont = new System.Drawing.Font("Segoe UI", 9F);
            this.mcaMes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcaMes.Location = new System.Drawing.Point(43, 319);
            this.mcaMes.Name = "mcaMes";
            this.mcaMes.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2018, 4, 1, 0, 0, 0, 0), new System.DateTime(2018, 4, 1, 0, 0, 0, 0));
            this.mcaMes.ShowFooter = false;
            this.mcaMes.TabIndex = 197;
            this.mcaMes.DateChanged += new System.EventHandler<System.Windows.Forms.DateRangeEventArgs>(this.mcaMes_DateChanged);
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(28, 28);
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
            this.toolStripMenuItemAgregarOEditar.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemAgregarOEditar.Text = "Asignar día";
            this.toolStripMenuItemAgregarOEditar.Click += new System.EventHandler(this.toolStripMenuItemAgregarOEditar_Click);
            // 
            // toolStripMenuItemEliminar
            // 
            this.toolStripMenuItemEliminar.Name = "toolStripMenuItemEliminar";
            this.toolStripMenuItemEliminar.Size = new System.Drawing.Size(133, 22);
            this.toolStripMenuItemEliminar.Text = "Eliminar";
            this.toolStripMenuItemEliminar.Click += new System.EventHandler(this.toolStripMenuItemEliminar_Click);
            // 
            // FormHorarioEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 683);
            this.Controls.Add(this.grbBuscarEmp);
            this.Controls.Add(this.mcaMes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabHorario);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.MaximizeBox = false;
            this.Name = "FormHorarioEmpleado";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormHorarioEmpleado_Load);
            this.grbBuscarEmp.ResumeLayout(false);
            this.grbBuscarEmp.PerformLayout();
            this.tabHorario.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picColorDiaDeTrabajo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private CustomControls.MonthCalendar mcaMes;
        private System.Windows.Forms.ContextMenuStrip ctxMenuDate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAgregarOEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnHoy;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel lblNumDoc;
        private MetroFramework.Controls.MetroLabel lblMensajeNoTieneHorario;
        private MetroFramework.Controls.MetroLabel lblDiasDeTrabajoRestantes;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Button btnEditarHorario;
        private System.Windows.Forms.Button btnQuitarFechas;
        private System.Windows.Forms.Button btnAsignarHorario;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel lblFechaCese;
        private MetroFramework.Controls.MetroLabel lblFechaIngreso;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblRuc;
        private System.Windows.Forms.Button btnUltimoDiaTrabajo;
        private System.Windows.Forms.Button btnPrimerDiaTrabajo;
        private MetroFramework.Controls.MetroLabel lblColorDiasLaborales;
        private System.Windows.Forms.PictureBox picColorDiaDeTrabajo;
    }
}