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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.chkSabado = new MetroFramework.Controls.MetroCheckBox();
            this.chkViernes = new MetroFramework.Controls.MetroCheckBox();
            this.chkJueves = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.chkDomingo = new MetroFramework.Controls.MetroCheckBox();
            this.chkMartes = new MetroFramework.Controls.MetroCheckBox();
            this.chkLunes = new MetroFramework.Controls.MetroCheckBox();
            this.chkMiercoles = new MetroFramework.Controls.MetroCheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNoPuedeEliminar = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblUltimoDiaHorario = new MetroFramework.Controls.MetroLabel();
            this.lblPrimerDiaHorario = new MetroFramework.Controls.MetroLabel();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnCancelar.Location = new System.Drawing.Point(345, 245);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 30);
            this.btnCancelar.TabIndex = 212;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(263, 245);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 30);
            this.btnEliminar.TabIndex = 211;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(23, 17);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(190, 32);
            this.lblNombreForm.TabIndex = 207;
            this.lblNombreForm.Text = "Eliminar Horarios";
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkSabado.Location = new System.Drawing.Point(373, 195);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(50, 19);
            this.chkSabado.TabIndex = 202;
            this.chkSabado.Text = "Sáb.";
            this.chkSabado.UseSelectable = true;
            // 
            // chkViernes
            // 
            this.chkViernes.AutoSize = true;
            this.chkViernes.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkViernes.Location = new System.Drawing.Point(320, 195);
            this.chkViernes.Name = "chkViernes";
            this.chkViernes.Size = new System.Drawing.Size(47, 19);
            this.chkViernes.TabIndex = 201;
            this.chkViernes.Text = "Vie.";
            this.chkViernes.UseSelectable = true;
            // 
            // chkJueves
            // 
            this.chkJueves.AutoSize = true;
            this.chkJueves.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkJueves.Location = new System.Drawing.Point(266, 195);
            this.chkJueves.Name = "chkJueves";
            this.chkJueves.Size = new System.Drawing.Size(48, 19);
            this.chkJueves.TabIndex = 200;
            this.chkJueves.Text = "Jue.";
            this.chkJueves.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel14.Location = new System.Drawing.Point(29, 160);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(179, 19);
            this.metroLabel14.TabIndex = 209;
            this.metroLabel14.Text = "Seleccione los días a eliminar";
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // chkDomingo
            // 
            this.chkDomingo.AutoSize = true;
            this.chkDomingo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkDomingo.Location = new System.Drawing.Point(29, 195);
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
            this.chkMartes.Location = new System.Drawing.Point(150, 195);
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
            this.chkLunes.Location = new System.Drawing.Point(93, 195);
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
            this.chkMiercoles.Location = new System.Drawing.Point(209, 195);
            this.chkMiercoles.Name = "chkMiercoles";
            this.chkMiercoles.Size = new System.Drawing.Size(51, 19);
            this.chkMiercoles.TabIndex = 199;
            this.chkMiercoles.Text = "Mié.";
            this.chkMiercoles.UseSelectable = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(32, 182);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 4);
            this.panel3.TabIndex = 213;
            // 
            // lblNoPuedeEliminar
            // 
            this.lblNoPuedeEliminar.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblNoPuedeEliminar.ForeColor = System.Drawing.Color.Red;
            this.lblNoPuedeEliminar.Location = new System.Drawing.Point(20, 218);
            this.lblNoPuedeEliminar.Name = "lblNoPuedeEliminar";
            this.lblNoPuedeEliminar.Size = new System.Drawing.Size(419, 22);
            this.lblNoPuedeEliminar.TabIndex = 214;
            this.lblNoPuedeEliminar.UseCustomForeColor = true;
            this.lblNoPuedeEliminar.WrapToLine = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(28, 62);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(140, 19);
            this.metroLabel2.TabIndex = 215;
            this.metroLabel2.Text = "Primer día de horario:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel4.Location = new System.Drawing.Point(29, 81);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(139, 19);
            this.metroLabel4.TabIndex = 216;
            this.metroLabel4.Text = "Último día de horario:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // lblUltimoDiaHorario
            // 
            this.lblUltimoDiaHorario.AutoSize = true;
            this.lblUltimoDiaHorario.ForeColor = System.Drawing.Color.Navy;
            this.lblUltimoDiaHorario.Location = new System.Drawing.Point(174, 81);
            this.lblUltimoDiaHorario.Name = "lblUltimoDiaHorario";
            this.lblUltimoDiaHorario.Size = new System.Drawing.Size(15, 19);
            this.lblUltimoDiaHorario.TabIndex = 217;
            this.lblUltimoDiaHorario.Text = "-";
            this.lblUltimoDiaHorario.UseCustomForeColor = true;
            // 
            // lblPrimerDiaHorario
            // 
            this.lblPrimerDiaHorario.AutoSize = true;
            this.lblPrimerDiaHorario.ForeColor = System.Drawing.Color.Navy;
            this.lblPrimerDiaHorario.Location = new System.Drawing.Point(174, 62);
            this.lblPrimerDiaHorario.Name = "lblPrimerDiaHorario";
            this.lblPrimerDiaHorario.Size = new System.Drawing.Size(15, 19);
            this.lblPrimerDiaHorario.TabIndex = 218;
            this.lblPrimerDiaHorario.Text = "-";
            this.lblPrimerDiaHorario.UseCustomForeColor = true;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(83, 122);
            this.dtpDesde.MinDate = new System.DateTime(2017, 1, 30, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(117, 20);
            this.dtpDesde.TabIndex = 220;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(29, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 219;
            this.metroLabel3.Text = "Desde:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel5.Location = new System.Drawing.Point(212, 121);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 19);
            this.metroLabel5.TabIndex = 221;
            this.metroLabel5.Text = "Hasta:";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(262, 122);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(117, 20);
            this.dtpHasta.TabIndex = 222;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 223;
            this.button1.Text = "Ver fechas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEliminarHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.lblPrimerDiaHorario);
            this.Controls.Add(this.lblUltimoDiaHorario);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblNoPuedeEliminar);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.chkSabado);
            this.Controls.Add(this.chkViernes);
            this.Controls.Add(this.chkJueves);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.chkDomingo);
            this.Controls.Add(this.chkMartes);
            this.Controls.Add(this.chkLunes);
            this.Controls.Add(this.chkMiercoles);
            this.MaximizeBox = false;
            this.Name = "FormEliminarHorario";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormEliminarHorario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroCheckBox chkSabado;
        private MetroFramework.Controls.MetroCheckBox chkViernes;
        private MetroFramework.Controls.MetroCheckBox chkJueves;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroCheckBox chkDomingo;
        private MetroFramework.Controls.MetroCheckBox chkMartes;
        private MetroFramework.Controls.MetroCheckBox chkLunes;
        private MetroFramework.Controls.MetroCheckBox chkMiercoles;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroLabel lblNoPuedeEliminar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblUltimoDiaHorario;
        private MetroFramework.Controls.MetroLabel lblPrimerDiaHorario;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button button1;
    }
}