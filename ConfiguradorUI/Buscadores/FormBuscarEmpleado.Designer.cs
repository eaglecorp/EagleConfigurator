namespace ConfiguradorUI.Buscadores
{
    partial class FormBuscarEmpleado
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
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.txtApellidosYNombres = new MetroFramework.Controls.MetroTextBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNumDoc = new MetroFramework.Controls.MetroTextBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(23, 24);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(240, 32);
            this.lblNombreForm.TabIndex = 76;
            this.lblNombreForm.Text = "Seleccionar empleado";
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.txtApellidosYNombres);
            this.gbxFiltro.Controls.Add(this.btnVerTodos);
            this.gbxFiltro.Controls.Add(this.btnSeleccionar);
            this.gbxFiltro.Controls.Add(this.metroLabel3);
            this.gbxFiltro.Controls.Add(this.txtNumDoc);
            this.gbxFiltro.Controls.Add(this.txtCodigo);
            this.gbxFiltro.Controls.Add(this.metroLabel2);
            this.gbxFiltro.Controls.Add(this.metroLabel1);
            this.gbxFiltro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxFiltro.Location = new System.Drawing.Point(23, 71);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(834, 91);
            this.gbxFiltro.TabIndex = 75;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Panel de filtros";
            // 
            // txtApellidosYNombres
            // 
            this.txtApellidosYNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtApellidosYNombres.CustomButton.Image = null;
            this.txtApellidosYNombres.CustomButton.Location = new System.Drawing.Point(545, 1);
            this.txtApellidosYNombres.CustomButton.Name = "";
            this.txtApellidosYNombres.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApellidosYNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApellidosYNombres.CustomButton.TabIndex = 1;
            this.txtApellidosYNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApellidosYNombres.CustomButton.UseSelectable = true;
            this.txtApellidosYNombres.CustomButton.Visible = false;
            this.txtApellidosYNombres.Lines = new string[0];
            this.txtApellidosYNombres.Location = new System.Drawing.Point(164, 53);
            this.txtApellidosYNombres.MaxLength = 32767;
            this.txtApellidosYNombres.Name = "txtApellidosYNombres";
            this.txtApellidosYNombres.PasswordChar = '\0';
            this.txtApellidosYNombres.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApellidosYNombres.SelectedText = "";
            this.txtApellidosYNombres.SelectionLength = 0;
            this.txtApellidosYNombres.SelectionStart = 0;
            this.txtApellidosYNombres.ShortcutsEnabled = true;
            this.txtApellidosYNombres.Size = new System.Drawing.Size(567, 23);
            this.txtApellidosYNombres.TabIndex = 5;
            this.txtApellidosYNombres.UseCustomBackColor = true;
            this.txtApellidosYNombres.UseSelectable = true;
            this.txtApellidosYNombres.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApellidosYNombres.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidosYNombres.TextChanged += new System.EventHandler(this.txtApellidosYNombres_TextChanged);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVerTodos.FlatAppearance.BorderSize = 0;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.White;
            this.btnVerTodos.Location = new System.Drawing.Point(737, 24);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(87, 25);
            this.btnVerTodos.TabIndex = 10;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = false;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(737, 51);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(87, 25);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(7, 57);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(132, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Apellidos y nombres:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNumDoc.CustomButton.Image = null;
            this.txtNumDoc.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtNumDoc.CustomButton.Name = "";
            this.txtNumDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumDoc.CustomButton.TabIndex = 1;
            this.txtNumDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumDoc.CustomButton.UseSelectable = true;
            this.txtNumDoc.CustomButton.Visible = false;
            this.txtNumDoc.Lines = new string[0];
            this.txtNumDoc.Location = new System.Drawing.Point(164, 24);
            this.txtNumDoc.MaxLength = 32767;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.PasswordChar = '\0';
            this.txtNumDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumDoc.SelectedText = "";
            this.txtNumDoc.SelectionLength = 0;
            this.txtNumDoc.SelectionStart = 0;
            this.txtNumDoc.ShortcutsEnabled = true;
            this.txtNumDoc.Size = new System.Drawing.Size(137, 23);
            this.txtNumDoc.TabIndex = 3;
            this.txtNumDoc.UseCustomBackColor = true;
            this.txtNumDoc.UseSelectable = true;
            this.txtNumDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumDoc.TextChanged += new System.EventHandler(this.txtNumDoc_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(387, 24);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(137, 23);
            this.txtCodigo.TabIndex = 7;
            this.txtCodigo.UseCustomBackColor = true;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(325, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Código:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(7, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(103, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Nro. doc / RUC:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(23, 168);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.Size = new System.Drawing.Size(834, 309);
            this.dgvEmpleado.TabIndex = 74;
            this.dgvEmpleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleado_CellDoubleClick);
            this.dgvEmpleado.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvEmpleado_Paint);
            this.dgvEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvEmpleado_KeyDown);
            // 
            // FormBuscarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 500);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.gbxFiltro);
            this.Controls.Add(this.dgvEmpleado);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormBuscarEmpleado";
            this.Load += new System.EventHandler(this.FormBuscarEmpleado_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreForm;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private MetroFramework.Controls.MetroTextBox txtApellidosYNombres;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnSeleccionar;
        private MetroFramework.Controls.MetroTextBox txtNumDoc;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dgvEmpleado;
    }
}