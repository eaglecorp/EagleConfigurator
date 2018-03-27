namespace ConfiguradorUI.Labor.Horario
{
    partial class FormEliminarHorario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.chkSabado = new MetroFramework.Controls.MetroCheckBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.chkViernes = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.chkJueves = new MetroFramework.Controls.MetroCheckBox();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.chkDomingo = new MetroFramework.Controls.MetroCheckBox();
            this.chkMartes = new MetroFramework.Controls.MetroCheckBox();
            this.chkLunes = new MetroFramework.Controls.MetroCheckBox();
            this.chkMiercoles = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(339, 160);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 30);
            this.btnCancelar.TabIndex = 212;
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
            this.btnGuardar.Location = new System.Drawing.Point(257, 160);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 30);
            this.btnGuardar.TabIndex = 211;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(23, 19);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(190, 32);
            this.lblNombreForm.TabIndex = 207;
            this.lblNombreForm.Text = "Eliminar Horarios";
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkSabado.Location = new System.Drawing.Point(367, 128);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(50, 19);
            this.chkSabado.TabIndex = 202;
            this.chkSabado.Text = "Sáb.";
            this.chkSabado.UseSelectable = true;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(83, 70);
            this.dtpDesde.MinDate = new System.DateTime(2017, 1, 30, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(117, 20);
            this.dtpDesde.TabIndex = 204;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(29, 69);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 203;
            this.metroLabel3.Text = "Desde:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkViernes.Location = new System.Drawing.Point(320, 128);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(47, 19);
            this.chkViernes.TabIndex = 201;
            this.chkViernes.Text = "Vie.";
            this.chkViernes.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel5.Location = new System.Drawing.Point(212, 69);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 205;
            this.metroLabel5.Text = "Hasta:";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkJueves.Location = new System.Drawing.Point(266, 128);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(48, 19);
            this.chkJueves.TabIndex = 200;
            this.chkJueves.Text = "Jue.";
            this.chkJueves.UseSelectable = true;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(262, 70);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(117, 20);
            this.dtpHasta.TabIndex = 206;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel14.Location = new System.Drawing.Point(29, 106);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(155, 19);
            this.metroLabel14.TabIndex = 209;
            this.metroLabel14.Text = "Marca los días a eliminar";
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkDomingo.Location = new System.Drawing.Point(29, 128);
            this.chkDomingo.Name = "chkDomingo";
            this.chkDomingo.Size = new System.Drawing.Size(58, 19);
            this.chkDomingo.TabIndex = 208;
            this.chkDomingo.Text = "Dom.";
            this.chkDomingo.UseSelectable = true;
            // 
            // chkMartes
            // 
            this.chkMartes.AutoSize = true;
            this.chkMartes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkMartes.Location = new System.Drawing.Point(150, 128);
            this.chkMartes.Name = "chkMartes";
            this.chkMartes.Size = new System.Drawing.Size(53, 19);
            this.chkMartes.TabIndex = 198;
            this.chkMartes.Text = "Mar.";
            this.chkMartes.UseSelectable = true;
            // 
            // chkLunes
            // 
            this.chkLunes.AutoSize = true;
            this.chkLunes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkLunes.Location = new System.Drawing.Point(93, 128);
            this.chkLunes.Name = "chkLunes";
            this.chkLunes.Size = new System.Drawing.Size(51, 19);
            this.chkLunes.TabIndex = 197;
            this.chkLunes.Text = "Lun.";
            this.chkLunes.UseSelectable = true;
            // 
            // chkMiercoles
            // 
            this.chkMiercoles.AutoSize = true;
            this.chkMiercoles.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkMiercoles.Location = new System.Drawing.Point(209, 128);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(51, 19);
            this.chkMiercoles.TabIndex = 199;
            this.chkMiercoles.Text = "Mié.";
            this.chkMiercoles.UseSelectable = true;
            // 
            // FormEliminarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 213);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.chkSabado);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.chkViernes);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.chkJueves);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.chkDomingo);
            this.Controls.Add(this.chkMartes);
            this.Controls.Add(this.chkLunes);
            this.Controls.Add(this.chkMiercoles);
            this.MaximizeBox = false;
            this.Name = "FormEliminarHorario";
            this.Resizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroCheckBox chkSabado;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox chkViernes;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroCheckBox chkJueves;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroCheckBox chkDomingo;
        private MetroFramework.Controls.MetroCheckBox chkMartes;
        private MetroFramework.Controls.MetroCheckBox chkLunes;
        private MetroFramework.Controls.MetroCheckBox chkMiercoles;
    }
}