namespace ConfiguradorUI.Labor.Horario
{
    partial class FormEditarDia
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
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.chkModificarEnTodosLosMismosDias = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.dtpHoraFinLabor = new System.Windows.Forms.DateTimePicker();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dtpTiempoTolerancia = new System.Windows.Forms.DateTimePicker();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.dtpHoraInicioBreak = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicioLabor = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraFinBreak = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(23, 30);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(121, 21);
            this.lblNombreForm.TabIndex = 180;
            this.lblNombreForm.Text = "Detalles del día";
            // 
            // chkModificarEnTodosLosMismosDias
            // 
            this.chkModificarEnTodosLosMismosDias.AutoSize = true;
            this.chkModificarEnTodosLosMismosDias.Location = new System.Drawing.Point(27, 198);
            this.chkModificarEnTodosLosMismosDias.Name = "chkModificarEnTodosLosMismosDias";
            this.chkModificarEnTodosLosMismosDias.Size = new System.Drawing.Size(224, 15);
            this.chkModificarEnTodosLosMismosDias.TabIndex = 192;
            this.chkModificarEnTodosLosMismosDias.Text = "Modificar en todos los _ _ _ _ _ _ _ _ _ _ ";
            this.chkModificarEnTodosLosMismosDias.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel9.Location = new System.Drawing.Point(27, 64);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(72, 19);
            this.metroLabel9.TabIndex = 193;
            this.metroLabel9.Text = "Hora Inicio";
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // dtpHoraFinLabor
            // 
            this.dtpHoraFinLabor.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFinLabor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFinLabor.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinLabor.Location = new System.Drawing.Point(148, 86);
            this.dtpHoraFinLabor.Name = "dtpHoraFinLabor";
            this.dtpHoraFinLabor.Size = new System.Drawing.Size(101, 25);
            this.dtpHoraFinLabor.TabIndex = 196;
            this.dtpHoraFinLabor.Value = new System.DateTime(2018, 1, 31, 0, 0, 0, 0);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel10.Location = new System.Drawing.Point(147, 64);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(59, 19);
            this.metroLabel10.TabIndex = 194;
            this.metroLabel10.Text = "Hora Fin";
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel13.Location = new System.Drawing.Point(148, 128);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(63, 19);
            this.metroLabel13.TabIndex = 198;
            this.metroLabel13.Text = "Fin Break";
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // dtpTiempoTolerancia
            // 
            this.dtpTiempoTolerancia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTiempoTolerancia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTiempoTolerancia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTiempoTolerancia.Location = new System.Drawing.Point(291, 86);
            this.dtpTiempoTolerancia.Name = "dtpTiempoTolerancia";
            this.dtpTiempoTolerancia.Size = new System.Drawing.Size(67, 25);
            this.dtpTiempoTolerancia.TabIndex = 202;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel12.Location = new System.Drawing.Point(27, 128);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(76, 19);
            this.metroLabel12.TabIndex = 197;
            this.metroLabel12.Text = "Inicio Break";
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel11.Location = new System.Drawing.Point(291, 64);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 19);
            this.metroLabel11.TabIndex = 201;
            this.metroLabel11.Text = "Tolerancia";
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // dtpHoraInicioBreak
            // 
            this.dtpHoraInicioBreak.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicioBreak.CustomFormat = "";
            this.dtpHoraInicioBreak.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicioBreak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicioBreak.Location = new System.Drawing.Point(27, 150);
            this.dtpHoraInicioBreak.Name = "dtpHoraInicioBreak";
            this.dtpHoraInicioBreak.Size = new System.Drawing.Size(101, 25);
            this.dtpHoraInicioBreak.TabIndex = 199;
            // 
            // dtpHoraInicioLabor
            // 
            this.dtpHoraInicioLabor.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicioLabor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicioLabor.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicioLabor.Location = new System.Drawing.Point(27, 86);
            this.dtpHoraInicioLabor.Name = "dtpHoraInicioLabor";
            this.dtpHoraInicioLabor.Size = new System.Drawing.Size(101, 25);
            this.dtpHoraInicioLabor.TabIndex = 195;
            // 
            // dtpHoraFinBreak
            // 
            this.dtpHoraFinBreak.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFinBreak.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraFinBreak.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinBreak.Location = new System.Drawing.Point(148, 150);
            this.dtpHoraFinBreak.Name = "dtpHoraFinBreak";
            this.dtpHoraFinBreak.Size = new System.Drawing.Size(101, 25);
            this.dtpHoraFinBreak.TabIndex = 200;
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
            this.btnCancelar.Location = new System.Drawing.Point(280, 231);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 30);
            this.btnCancelar.TabIndex = 205;
            this.btnCancelar.Text = "Cancelar";
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
            this.btnGuardar.Location = new System.Drawing.Point(198, 231);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 30);
            this.btnGuardar.TabIndex = 204;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FormEditarDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 287);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.chkModificarEnTodosLosMismosDias);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.dtpHoraFinLabor);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.dtpTiempoTolerancia);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.dtpHoraInicioBreak);
            this.Controls.Add(this.dtpHoraInicioLabor);
            this.Controls.Add(this.dtpHoraFinBreak);
            this.Controls.Add(this.lblNombreForm);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarDia";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormEditarDia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroCheckBox chkModificarEnTodosLosMismosDias;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DateTimePicker dtpHoraFinLabor;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.DateTimePicker dtpTiempoTolerancia;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioBreak;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioLabor;
        private System.Windows.Forms.DateTimePicker dtpHoraFinBreak;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}