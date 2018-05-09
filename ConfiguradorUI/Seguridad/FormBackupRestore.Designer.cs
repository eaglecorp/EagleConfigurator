namespace ConfiguradorUI.Seguridad
{
    partial class FormBackupRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackupRestore));
            this.grbRestore = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnBrowseRestore = new System.Windows.Forms.Button();
            this.txtLocationRestore = new MetroFramework.Controls.MetroTextBox();
            this.lblLocationRestore = new MetroFramework.Controls.MetroLabel();
            this.grbBackup = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBrowseBackup = new System.Windows.Forms.Button();
            this.txtLocationBackup = new MetroFramework.Controls.MetroTextBox();
            this.lblLocationBackup = new MetroFramework.Controls.MetroLabel();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grbRestore.SuspendLayout();
            this.grbBackup.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRestore
            // 
            this.grbRestore.Controls.Add(this.btnRestore);
            this.grbRestore.Controls.Add(this.btnBrowseRestore);
            this.grbRestore.Controls.Add(this.txtLocationRestore);
            this.grbRestore.Controls.Add(this.lblLocationRestore);
            this.grbRestore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRestore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbRestore.Location = new System.Drawing.Point(37, 215);
            this.grbRestore.Name = "grbRestore";
            this.grbRestore.Size = new System.Drawing.Size(562, 98);
            this.grbRestore.TabIndex = 1;
            this.grbRestore.TabStop = false;
            this.grbRestore.Text = "Restore Base de Datos";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(477, 55);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(69, 24);
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Text = "Restore";
            this.btnRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnBrowseRestore
            // 
            this.btnBrowseRestore.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowseRestore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrowseRestore.FlatAppearance.BorderSize = 0;
            this.btnBrowseRestore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBrowseRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBrowseRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseRestore.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseRestore.ForeColor = System.Drawing.Color.White;
            this.btnBrowseRestore.Location = new System.Drawing.Point(477, 25);
            this.btnBrowseRestore.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseRestore.Name = "btnBrowseRestore";
            this.btnBrowseRestore.Size = new System.Drawing.Size(69, 24);
            this.btnBrowseRestore.TabIndex = 0;
            this.btnBrowseRestore.Text = "Browse";
            this.btnBrowseRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowseRestore.UseVisualStyleBackColor = false;
            this.btnBrowseRestore.Click += new System.EventHandler(this.btnBrowseRestore_Click);
            // 
            // txtLocationRestore
            // 
            this.txtLocationRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtLocationRestore.CustomButton.Image = null;
            this.txtLocationRestore.CustomButton.Location = new System.Drawing.Point(351, 1);
            this.txtLocationRestore.CustomButton.Name = "";
            this.txtLocationRestore.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocationRestore.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocationRestore.CustomButton.TabIndex = 1;
            this.txtLocationRestore.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocationRestore.CustomButton.UseSelectable = true;
            this.txtLocationRestore.CustomButton.Visible = false;
            this.txtLocationRestore.Lines = new string[0];
            this.txtLocationRestore.Location = new System.Drawing.Point(98, 25);
            this.txtLocationRestore.MaxLength = 32767;
            this.txtLocationRestore.Name = "txtLocationRestore";
            this.txtLocationRestore.PasswordChar = '\0';
            this.txtLocationRestore.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocationRestore.SelectedText = "";
            this.txtLocationRestore.SelectionLength = 0;
            this.txtLocationRestore.SelectionStart = 0;
            this.txtLocationRestore.ShortcutsEnabled = true;
            this.txtLocationRestore.Size = new System.Drawing.Size(373, 23);
            this.txtLocationRestore.TabIndex = 113;
            this.txtLocationRestore.UseCustomBackColor = true;
            this.txtLocationRestore.UseSelectable = true;
            this.txtLocationRestore.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocationRestore.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLocationRestore
            // 
            this.lblLocationRestore.AutoSize = true;
            this.lblLocationRestore.ForeColor = System.Drawing.Color.Navy;
            this.lblLocationRestore.Location = new System.Drawing.Point(16, 27);
            this.lblLocationRestore.Name = "lblLocationRestore";
            this.lblLocationRestore.Size = new System.Drawing.Size(82, 19);
            this.lblLocationRestore.TabIndex = 112;
            this.lblLocationRestore.Text = "Localización:";
            this.lblLocationRestore.UseCustomForeColor = true;
            // 
            // grbBackup
            // 
            this.grbBackup.Controls.Add(this.btnBackup);
            this.grbBackup.Controls.Add(this.btnBrowseBackup);
            this.grbBackup.Controls.Add(this.txtLocationBackup);
            this.grbBackup.Controls.Add(this.lblLocationBackup);
            this.grbBackup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBackup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbBackup.Location = new System.Drawing.Point(37, 99);
            this.grbBackup.Name = "grbBackup";
            this.grbBackup.Size = new System.Drawing.Size(562, 101);
            this.grbBackup.TabIndex = 0;
            this.grbBackup.TabStop = false;
            this.grbBackup.Text = "Backup de la Base de Datos";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(477, 56);
            this.btnBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(69, 24);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "Backup";
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnBrowseBackup
            // 
            this.btnBrowseBackup.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowseBackup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBrowseBackup.FlatAppearance.BorderSize = 0;
            this.btnBrowseBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBrowseBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBrowseBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseBackup.ForeColor = System.Drawing.Color.White;
            this.btnBrowseBackup.Location = new System.Drawing.Point(477, 26);
            this.btnBrowseBackup.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseBackup.Name = "btnBrowseBackup";
            this.btnBrowseBackup.Size = new System.Drawing.Size(69, 24);
            this.btnBrowseBackup.TabIndex = 0;
            this.btnBrowseBackup.Text = "Browse";
            this.btnBrowseBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowseBackup.UseVisualStyleBackColor = false;
            this.btnBrowseBackup.Click += new System.EventHandler(this.btnBrowseBackup_Click);
            // 
            // txtLocationBackup
            // 
            this.txtLocationBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtLocationBackup.CustomButton.Image = null;
            this.txtLocationBackup.CustomButton.Location = new System.Drawing.Point(355, 1);
            this.txtLocationBackup.CustomButton.Name = "";
            this.txtLocationBackup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLocationBackup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLocationBackup.CustomButton.TabIndex = 1;
            this.txtLocationBackup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLocationBackup.CustomButton.UseSelectable = true;
            this.txtLocationBackup.CustomButton.Visible = false;
            this.txtLocationBackup.Lines = new string[0];
            this.txtLocationBackup.Location = new System.Drawing.Point(94, 26);
            this.txtLocationBackup.MaxLength = 32767;
            this.txtLocationBackup.Name = "txtLocationBackup";
            this.txtLocationBackup.PasswordChar = '\0';
            this.txtLocationBackup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLocationBackup.SelectedText = "";
            this.txtLocationBackup.SelectionLength = 0;
            this.txtLocationBackup.SelectionStart = 0;
            this.txtLocationBackup.ShortcutsEnabled = true;
            this.txtLocationBackup.Size = new System.Drawing.Size(377, 23);
            this.txtLocationBackup.TabIndex = 109;
            this.txtLocationBackup.UseCustomBackColor = true;
            this.txtLocationBackup.UseSelectable = true;
            this.txtLocationBackup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLocationBackup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblLocationBackup
            // 
            this.lblLocationBackup.AutoSize = true;
            this.lblLocationBackup.ForeColor = System.Drawing.Color.Navy;
            this.lblLocationBackup.Location = new System.Drawing.Point(12, 28);
            this.lblLocationBackup.Name = "lblLocationBackup";
            this.lblLocationBackup.Size = new System.Drawing.Size(82, 19);
            this.lblLocationBackup.TabIndex = 108;
            this.lblLocationBackup.Text = "Localización:";
            this.lblLocationBackup.UseCustomForeColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(28, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(191, 32);
            this.lblNombreForm.TabIndex = 108;
            this.lblNombreForm.Text = "Backup y Restore";
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
            this.btnCancelar.Location = new System.Drawing.Point(521, 326);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 30);
            this.btnCancelar.TabIndex = 109;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 381);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.grbRestore);
            this.Controls.Add(this.grbBackup);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNombreForm);
            this.MaximizeBox = false;
            this.Name = "FormBackupRestore";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormBackupRestore_Load);
            this.grbRestore.ResumeLayout(false);
            this.grbRestore.PerformLayout();
            this.grbBackup.ResumeLayout(false);
            this.grbBackup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRestore;
        private System.Windows.Forms.GroupBox grbBackup;
        private System.Windows.Forms.Button btnBrowseBackup;
        private MetroFramework.Controls.MetroTextBox txtLocationBackup;
        private MetroFramework.Controls.MetroLabel lblLocationBackup;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.Label lblNombreForm;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBrowseRestore;
        private MetroFramework.Controls.MetroTextBox txtLocationRestore;
        private MetroFramework.Controls.MetroLabel lblLocationRestore;
        private System.Windows.Forms.Button btnCancelar;
    }
}