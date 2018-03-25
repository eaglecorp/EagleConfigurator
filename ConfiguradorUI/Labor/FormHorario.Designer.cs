using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Labor
{
    partial class FormHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHorario));
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Mesero");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Cocinero");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Gerente");
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.grbDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lstTrabajo = new System.Windows.Forms.ListView();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.picFotoEmp = new System.Windows.Forms.PictureBox();
            this.lblApeNom = new MetroFramework.Controls.MetroLabel();
            this.btnBuscarEmp = new System.Windows.Forms.Button();
            this.txtNroDocEmp = new MetroFramework.Controls.MetroTextBox();
            this.lblNroDocEmp = new MetroFramework.Controls.MetroLabel();
            this.grbBuscarEmp = new System.Windows.Forms.GroupBox();
            this.grbMesYAnio = new System.Windows.Forms.GroupBox();
            this.dgvMes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboTurno = new System.Windows.Forms.ComboBox();
            this.lblTurno = new MetroFramework.Controls.MetroLabel();
            this.lblMes = new MetroFramework.Controls.MetroLabel();
            this.dgvSemana = new System.Windows.Forms.DataGridView();
            this.mcaMes = new EagleMonthCalendar();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grbDatosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoEmp)).BeginInit();
            this.grbBuscarEmp.SuspendLayout();
            this.grbMesYAnio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemana)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(83, 33);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(167, 32);
            this.lblNombreForm.TabIndex = 71;
            this.lblNombreForm.Text = "Nuevo Horario";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(21, 21);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 70;
            this.btnCerrar.UseSelectable = true;
            // 
            // grbDatosEmpleado
            // 
            this.grbDatosEmpleado.Controls.Add(this.metroLabel3);
            this.grbDatosEmpleado.Controls.Add(this.dateTimePicker2);
            this.grbDatosEmpleado.Controls.Add(this.dateTimePicker1);
            this.grbDatosEmpleado.Controls.Add(this.metroLabel2);
            this.grbDatosEmpleado.Controls.Add(this.metroLabel1);
            this.grbDatosEmpleado.Controls.Add(this.lstTrabajo);
            this.grbDatosEmpleado.Controls.Add(this.txtUsuario);
            this.grbDatosEmpleado.Controls.Add(this.picFotoEmp);
            this.grbDatosEmpleado.Controls.Add(this.lblApeNom);
            this.grbDatosEmpleado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosEmpleado.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbDatosEmpleado.Location = new System.Drawing.Point(36, 172);
            this.grbDatosEmpleado.Name = "grbDatosEmpleado";
            this.grbDatosEmpleado.Size = new System.Drawing.Size(436, 211);
            this.grbDatosEmpleado.TabIndex = 72;
            this.grbDatosEmpleado.TabStop = false;
            this.grbDatosEmpleado.Text = "Datos del Empleado";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(173, 143);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(86, 19);
            this.metroLabel3.TabIndex = 119;
            this.metroLabel3.Text = "Fin contrato:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(173, 165);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(99, 25);
            this.dateTimePicker2.TabIndex = 118;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 108);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 25);
            this.dateTimePicker1.TabIndex = 117;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(173, 86);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(100, 19);
            this.metroLabel2.TabIndex = 116;
            this.metroLabel2.Text = "Inicio contrato:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(8, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 19);
            this.metroLabel1.TabIndex = 115;
            this.metroLabel1.Text = "Trabajos:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // lstTrabajo
            // 
            this.lstTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.lstTrabajo.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.lstTrabajo.Location = new System.Drawing.Point(8, 108);
            this.lstTrabajo.Name = "lstTrabajo";
            this.lstTrabajo.Size = new System.Drawing.Size(142, 82);
            this.lstTrabajo.TabIndex = 114;
            this.lstTrabajo.UseCompatibleStateImageBehavior = false;
            this.lstTrabajo.View = System.Windows.Forms.View.List;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtUsuario.CustomButton.Image = null;
            this.txtUsuario.CustomButton.Location = new System.Drawing.Point(252, 1);
            this.txtUsuario.CustomButton.Name = "";
            this.txtUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsuario.CustomButton.TabIndex = 1;
            this.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsuario.CustomButton.UseSelectable = true;
            this.txtUsuario.CustomButton.Visible = false;
            this.txtUsuario.Lines = new string[] {
        "RAMIRO SAAVEDRA"};
            this.txtUsuario.Location = new System.Drawing.Point(8, 49);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.ShortcutsEnabled = true;
            this.txtUsuario.Size = new System.Drawing.Size(274, 23);
            this.txtUsuario.TabIndex = 113;
            this.txtUsuario.Text = "RAMIRO SAAVEDRA";
            this.txtUsuario.UseCustomBackColor = true;
            this.txtUsuario.UseSelectable = true;
            this.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // picFotoEmp
            // 
            this.picFotoEmp.Image = ((System.Drawing.Image)(resources.GetObject("picFotoEmp.Image")));
            this.picFotoEmp.Location = new System.Drawing.Point(288, 27);
            this.picFotoEmp.Name = "picFotoEmp";
            this.picFotoEmp.Size = new System.Drawing.Size(140, 163);
            this.picFotoEmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFotoEmp.TabIndex = 112;
            this.picFotoEmp.TabStop = false;
            // 
            // lblApeNom
            // 
            this.lblApeNom.AutoSize = true;
            this.lblApeNom.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblApeNom.ForeColor = System.Drawing.Color.Navy;
            this.lblApeNom.Location = new System.Drawing.Point(8, 27);
            this.lblApeNom.Name = "lblApeNom";
            this.lblApeNom.Size = new System.Drawing.Size(136, 19);
            this.lblApeNom.TabIndex = 111;
            this.lblApeNom.Text = "Apellidos y nombres:";
            this.lblApeNom.UseCustomForeColor = true;
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
            this.btnBuscarEmp.Location = new System.Drawing.Point(359, 26);
            this.btnBuscarEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarEmp.Name = "btnBuscarEmp";
            this.btnBuscarEmp.Size = new System.Drawing.Size(69, 24);
            this.btnBuscarEmp.TabIndex = 0;
            this.btnBuscarEmp.Text = "Buscar";
            this.btnBuscarEmp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarEmp.UseVisualStyleBackColor = false;
            // 
            // txtNroDocEmp
            // 
            this.txtNroDocEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNroDocEmp.CustomButton.Image = null;
            this.txtNroDocEmp.CustomButton.Location = new System.Drawing.Point(95, 1);
            this.txtNroDocEmp.CustomButton.Name = "";
            this.txtNroDocEmp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNroDocEmp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNroDocEmp.CustomButton.TabIndex = 1;
            this.txtNroDocEmp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNroDocEmp.CustomButton.UseSelectable = true;
            this.txtNroDocEmp.CustomButton.Visible = false;
            this.txtNroDocEmp.Lines = new string[0];
            this.txtNroDocEmp.Location = new System.Drawing.Point(237, 26);
            this.txtNroDocEmp.MaxLength = 32767;
            this.txtNroDocEmp.Name = "txtNroDocEmp";
            this.txtNroDocEmp.PasswordChar = '\0';
            this.txtNroDocEmp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNroDocEmp.SelectedText = "";
            this.txtNroDocEmp.SelectionLength = 0;
            this.txtNroDocEmp.SelectionStart = 0;
            this.txtNroDocEmp.ShortcutsEnabled = true;
            this.txtNroDocEmp.Size = new System.Drawing.Size(117, 23);
            this.txtNroDocEmp.TabIndex = 109;
            this.txtNroDocEmp.UseCustomBackColor = true;
            this.txtNroDocEmp.UseSelectable = true;
            this.txtNroDocEmp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNroDocEmp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblNroDocEmp
            // 
            this.lblNroDocEmp.AutoSize = true;
            this.lblNroDocEmp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNroDocEmp.ForeColor = System.Drawing.Color.Navy;
            this.lblNroDocEmp.Location = new System.Drawing.Point(8, 28);
            this.lblNroDocEmp.Name = "lblNroDocEmp";
            this.lblNroDocEmp.Size = new System.Drawing.Size(207, 19);
            this.lblNroDocEmp.TabIndex = 108;
            this.lblNroDocEmp.Text = "Ingresar número de documento:";
            this.lblNroDocEmp.UseCustomForeColor = true;
            // 
            // grbBuscarEmp
            // 
            this.grbBuscarEmp.Controls.Add(this.lblNroDocEmp);
            this.grbBuscarEmp.Controls.Add(this.txtNroDocEmp);
            this.grbBuscarEmp.Controls.Add(this.btnBuscarEmp);
            this.grbBuscarEmp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscarEmp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbBuscarEmp.Location = new System.Drawing.Point(36, 101);
            this.grbBuscarEmp.Name = "grbBuscarEmp";
            this.grbBuscarEmp.Size = new System.Drawing.Size(436, 65);
            this.grbBuscarEmp.TabIndex = 112;
            this.grbBuscarEmp.TabStop = false;
            this.grbBuscarEmp.Text = "Buscar empleado";
            // 
            // grbMesYAnio
            // 
            this.grbMesYAnio.Controls.Add(this.dgvMes);
            this.grbMesYAnio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMesYAnio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbMesYAnio.Location = new System.Drawing.Point(36, 389);
            this.grbMesYAnio.Name = "grbMesYAnio";
            this.grbMesYAnio.Size = new System.Drawing.Size(1026, 164);
            this.grbMesYAnio.TabIndex = 113;
            this.grbMesYAnio.TabStop = false;
            this.grbMesYAnio.Text = "Mes y año";
            // 
            // dgvMes
            // 
            this.dgvMes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMes.Location = new System.Drawing.Point(8, 30);
            this.dgvMes.Name = "dgvMes";
            this.dgvMes.Size = new System.Drawing.Size(1012, 134);
            this.dgvMes.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboTurno);
            this.groupBox1.Controls.Add(this.lblTurno);
            this.groupBox1.Controls.Add(this.lblMes);
            this.groupBox1.Controls.Add(this.dgvSemana);
            this.groupBox1.Controls.Add(this.mcaMes);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(478, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 282);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Turnos y días de labor";
            // 
            // cboTurno
            // 
            this.cboTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTurno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTurno.FormattingEnabled = true;
            this.cboTurno.Location = new System.Drawing.Point(12, 48);
            this.cboTurno.Name = "cboTurno";
            this.cboTurno.Size = new System.Drawing.Size(248, 23);
            this.cboTurno.TabIndex = 111;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTurno.ForeColor = System.Drawing.Color.Navy;
            this.lblTurno.Location = new System.Drawing.Point(12, 26);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(119, 19);
            this.lblTurno.TabIndex = 110;
            this.lblTurno.Text = "Seleccionar Turno:";
            this.lblTurno.UseCustomForeColor = true;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblMes.ForeColor = System.Drawing.Color.Navy;
            this.lblMes.Location = new System.Drawing.Point(12, 80);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(108, 19);
            this.lblMes.TabIndex = 109;
            this.lblMes.Text = "Seleccionar mes:";
            this.lblMes.UseCustomForeColor = true;
            // 
            // dgvSemana
            // 
            this.dgvSemana.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemana.Location = new System.Drawing.Point(272, 24);
            this.dgvSemana.Name = "dgvSemana";
            this.dgvSemana.Size = new System.Drawing.Size(306, 246);
            this.dgvSemana.TabIndex = 1;
            // 
            // mcaMes
            // 
            this.mcaMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.mcaMes.Location = new System.Drawing.Point(12, 108);
            this.mcaMes.Name = "mcaMes";
            this.mcaMes.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(910, 48);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 30);
            this.btnCancelar.TabIndex = 116;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(828, 48);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 30);
            this.btnGuardar.TabIndex = 115;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 589);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbMesYAnio);
            this.Controls.Add(this.grbBuscarEmp);
            this.Controls.Add(this.grbDatosEmpleado);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Name = "FormHorario";
            this.Load += new System.EventHandler(this.FormHorario_Load);
            this.grbDatosEmpleado.ResumeLayout(false);
            this.grbDatosEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoEmp)).EndInit();
            this.grbBuscarEmp.ResumeLayout(false);
            this.grbBuscarEmp.PerformLayout();
            this.grbMesYAnio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.GroupBox grbDatosEmpleado;
        private System.Windows.Forms.Button btnBuscarEmp;
        private MetroFramework.Controls.MetroTextBox txtNroDocEmp;
        private MetroFramework.Controls.MetroLabel lblNroDocEmp;
        private MetroFramework.Controls.MetroLabel lblApeNom;
        private System.Windows.Forms.GroupBox grbBuscarEmp;
        private System.Windows.Forms.PictureBox picFotoEmp;
        private System.Windows.Forms.GroupBox grbMesYAnio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMes;
        private MetroFramework.Controls.MetroLabel lblTurno;
        private MetroFramework.Controls.MetroLabel lblMes;
        private System.Windows.Forms.DataGridView dgvSemana;
        private EagleMonthCalendar mcaMes;
        private System.Windows.Forms.ComboBox cboTurno;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListView lstTrabajo;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
    }
}