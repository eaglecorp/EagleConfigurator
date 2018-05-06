namespace ConfiguradorUI.Seguridad
{
    partial class FormCambiarClave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambiarClave));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.txtNuevaClaveRepeat = new MetroFramework.Controls.MetroTextBox();
            this.lblNuevaClaveRepeat = new MetroFramework.Controls.MetroLabel();
            this.txtNuevaClave = new MetroFramework.Controls.MetroTextBox();
            this.lblNuevaClave = new MetroFramework.Controls.MetroLabel();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.panelIndicadorClave = new System.Windows.Forms.Panel();
            this.lblIndicadorContraseña = new System.Windows.Forms.Label();
            this.panelIndicadorClave.SuspendLayout();
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
            this.btnCancelar.Location = new System.Drawing.Point(330, 236);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 30);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(224, 236);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(102, 30);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsername.Location = new System.Drawing.Point(224, 102);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(72, 25);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Usuario";
            // 
            // txtNuevaClaveRepeat
            // 
            this.txtNuevaClaveRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNuevaClaveRepeat.CustomButton.Image = null;
            this.txtNuevaClaveRepeat.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNuevaClaveRepeat.CustomButton.Name = "";
            this.txtNuevaClaveRepeat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNuevaClaveRepeat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNuevaClaveRepeat.CustomButton.TabIndex = 1;
            this.txtNuevaClaveRepeat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNuevaClaveRepeat.CustomButton.UseSelectable = true;
            this.txtNuevaClaveRepeat.CustomButton.Visible = false;
            this.txtNuevaClaveRepeat.Lines = new string[0];
            this.txtNuevaClaveRepeat.Location = new System.Drawing.Point(224, 200);
            this.txtNuevaClaveRepeat.MaxLength = 32767;
            this.txtNuevaClaveRepeat.Name = "txtNuevaClaveRepeat";
            this.txtNuevaClaveRepeat.PasswordChar = '\0';
            this.txtNuevaClaveRepeat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNuevaClaveRepeat.SelectedText = "";
            this.txtNuevaClaveRepeat.SelectionLength = 0;
            this.txtNuevaClaveRepeat.SelectionStart = 0;
            this.txtNuevaClaveRepeat.ShortcutsEnabled = true;
            this.txtNuevaClaveRepeat.Size = new System.Drawing.Size(184, 23);
            this.txtNuevaClaveRepeat.TabIndex = 5;
            this.txtNuevaClaveRepeat.UseCustomBackColor = true;
            this.txtNuevaClaveRepeat.UseSelectable = true;
            this.txtNuevaClaveRepeat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNuevaClaveRepeat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNuevaClaveRepeat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNuevaClaveRepeat_KeyPress);
            // 
            // lblNuevaClaveRepeat
            // 
            this.lblNuevaClaveRepeat.AutoSize = true;
            this.lblNuevaClaveRepeat.ForeColor = System.Drawing.Color.Navy;
            this.lblNuevaClaveRepeat.Location = new System.Drawing.Point(31, 202);
            this.lblNuevaClaveRepeat.Name = "lblNuevaClaveRepeat";
            this.lblNuevaClaveRepeat.Size = new System.Drawing.Size(187, 19);
            this.lblNuevaClaveRepeat.TabIndex = 4;
            this.lblNuevaClaveRepeat.Text = "Confirma tu nueva contraseña:";
            this.lblNuevaClaveRepeat.UseCustomForeColor = true;
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNuevaClave.CustomButton.Image = null;
            this.txtNuevaClave.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNuevaClave.CustomButton.Name = "";
            this.txtNuevaClave.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNuevaClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNuevaClave.CustomButton.TabIndex = 1;
            this.txtNuevaClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNuevaClave.CustomButton.UseSelectable = true;
            this.txtNuevaClave.CustomButton.Visible = false;
            this.txtNuevaClave.Lines = new string[0];
            this.txtNuevaClave.Location = new System.Drawing.Point(224, 146);
            this.txtNuevaClave.MaxLength = 32767;
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.PasswordChar = '\0';
            this.txtNuevaClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNuevaClave.SelectedText = "";
            this.txtNuevaClave.SelectionLength = 0;
            this.txtNuevaClave.SelectionStart = 0;
            this.txtNuevaClave.ShortcutsEnabled = true;
            this.txtNuevaClave.Size = new System.Drawing.Size(184, 23);
            this.txtNuevaClave.TabIndex = 3;
            this.txtNuevaClave.UseCustomBackColor = true;
            this.txtNuevaClave.UseSelectable = true;
            this.txtNuevaClave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNuevaClave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNuevaClave.TextChanged += new System.EventHandler(this.txtNuevaClave_TextChanged);
            // 
            // lblNuevaClave
            // 
            this.lblNuevaClave.AutoSize = true;
            this.lblNuevaClave.ForeColor = System.Drawing.Color.Navy;
            this.lblNuevaClave.Location = new System.Drawing.Point(31, 150);
            this.lblNuevaClave.Name = "lblNuevaClave";
            this.lblNuevaClave.Size = new System.Drawing.Size(116, 19);
            this.lblNuevaClave.TabIndex = 2;
            this.lblNuevaClave.Text = "Nueva contraseña:";
            this.lblNuevaClave.UseCustomForeColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(31, 106);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Usuario:";
            this.lblNombre.UseCustomForeColor = true;
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(254, 32);
            this.lblNombreForm.TabIndex = 103;
            this.lblNombreForm.Text = "Cambiar de contraseña";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(28, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelIndicadorClave
            // 
            this.panelIndicadorClave.BackColor = System.Drawing.Color.Transparent;
            this.panelIndicadorClave.Controls.Add(this.lblIndicadorContraseña);
            this.panelIndicadorClave.Location = new System.Drawing.Point(224, 172);
            this.panelIndicadorClave.Name = "panelIndicadorClave";
            this.panelIndicadorClave.Size = new System.Drawing.Size(184, 19);
            this.panelIndicadorClave.TabIndex = 115;
            // 
            // lblIndicadorContraseña
            // 
            this.lblIndicadorContraseña.AutoSize = true;
            this.lblIndicadorContraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicadorContraseña.Location = new System.Drawing.Point(70, 1);
            this.lblIndicadorContraseña.Name = "lblIndicadorContraseña";
            this.lblIndicadorContraseña.Size = new System.Drawing.Size(41, 17);
            this.lblIndicadorContraseña.TabIndex = 0;
            this.lblIndicadorContraseña.Text = "label1";
            // 
            // FormCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(444, 291);
            this.Controls.Add(this.panelIndicadorClave);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtNuevaClaveRepeat);
            this.Controls.Add(this.lblNuevaClaveRepeat);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.lblNuevaClave);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.MaximizeBox = false;
            this.Name = "FormCambiarClave";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormCambiarClave_Load);
            this.panelIndicadorClave.ResumeLayout(false);
            this.panelIndicadorClave.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroTextBox txtNuevaClaveRepeat;
        private MetroFramework.Controls.MetroLabel lblNuevaClaveRepeat;
        private MetroFramework.Controls.MetroTextBox txtNuevaClave;
        private MetroFramework.Controls.MetroLabel lblNuevaClave;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.Panel panelIndicadorClave;
        private System.Windows.Forms.Label lblIndicadorContraseña;
    }
}