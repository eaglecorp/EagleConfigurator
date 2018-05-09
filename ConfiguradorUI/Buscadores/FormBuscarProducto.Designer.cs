namespace ConfiguradorUI.Buscadores
{
    partial class FormBuscarProducto
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
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.chkIncluirInactivos = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtDescripcionProd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo02 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.dgvProd = new System.Windows.Forms.DataGridView();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.lblNombreForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).BeginInit();
            this.gbxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVerTodos.FlatAppearance.BorderSize = 0;
            this.btnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerTodos.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTodos.ForeColor = System.Drawing.Color.White;
            this.btnVerTodos.Location = new System.Drawing.Point(617, 24);
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
            this.btnSeleccionar.Location = new System.Drawing.Point(617, 51);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(87, 25);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // chkIncluirInactivos
            // 
            this.chkIncluirInactivos.AutoSize = true;
            this.chkIncluirInactivos.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkIncluirInactivos.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkIncluirInactivos.ForeColor = System.Drawing.Color.Navy;
            this.chkIncluirInactivos.Location = new System.Drawing.Point(467, 26);
            this.chkIncluirInactivos.Name = "chkIncluirInactivos";
            this.chkIncluirInactivos.Size = new System.Drawing.Size(112, 19);
            this.chkIncluirInactivos.TabIndex = 8;
            this.chkIncluirInactivos.Text = "Incluir Inactivos";
            this.chkIncluirInactivos.UseCustomForeColor = true;
            this.chkIncluirInactivos.UseSelectable = true;
            this.chkIncluirInactivos.CheckedChanged += new System.EventHandler(this.chkIncluirInactivos_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(6, 55);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Descripción:";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDescripcionProd.CustomButton.Image = null;
            this.txtDescripcionProd.CustomButton.Location = new System.Drawing.Point(474, 1);
            this.txtDescripcionProd.CustomButton.Name = "";
            this.txtDescripcionProd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcionProd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcionProd.CustomButton.TabIndex = 1;
            this.txtDescripcionProd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcionProd.CustomButton.UseSelectable = true;
            this.txtDescripcionProd.CustomButton.Visible = false;
            this.txtDescripcionProd.Lines = new string[0];
            this.txtDescripcionProd.Location = new System.Drawing.Point(91, 53);
            this.txtDescripcionProd.MaxLength = 32767;
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.PasswordChar = '\0';
            this.txtDescripcionProd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcionProd.SelectedText = "";
            this.txtDescripcionProd.SelectionLength = 0;
            this.txtDescripcionProd.SelectionStart = 0;
            this.txtDescripcionProd.ShortcutsEnabled = true;
            this.txtDescripcionProd.Size = new System.Drawing.Size(496, 23);
            this.txtDescripcionProd.TabIndex = 5;
            this.txtDescripcionProd.UseCustomBackColor = true;
            this.txtDescripcionProd.UseSelectable = true;
            this.txtDescripcionProd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcionProd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcionProd.TextChanged += new System.EventHandler(this.txtDescripcionProd_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(239, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Código 02:";
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtCodigo02
            // 
            this.txtCodigo02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodigo02.CustomButton.Image = null;
            this.txtCodigo02.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtCodigo02.CustomButton.Name = "";
            this.txtCodigo02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo02.CustomButton.TabIndex = 1;
            this.txtCodigo02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo02.CustomButton.UseSelectable = true;
            this.txtCodigo02.CustomButton.Visible = false;
            this.txtCodigo02.Lines = new string[0];
            this.txtCodigo02.Location = new System.Drawing.Point(319, 24);
            this.txtCodigo02.MaxLength = 32767;
            this.txtCodigo02.Name = "txtCodigo02";
            this.txtCodigo02.PasswordChar = '\0';
            this.txtCodigo02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo02.SelectedText = "";
            this.txtCodigo02.SelectionLength = 0;
            this.txtCodigo02.SelectionStart = 0;
            this.txtCodigo02.ShortcutsEnabled = true;
            this.txtCodigo02.Size = new System.Drawing.Size(137, 23);
            this.txtCodigo02.TabIndex = 7;
            this.txtCodigo02.UseCustomBackColor = true;
            this.txtCodigo02.UseSelectable = true;
            this.txtCodigo02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo02.TextChanged += new System.EventHandler(this.txtCodigo02_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(6, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Código 01:";
            this.metroLabel1.UseCustomForeColor = true;
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
            this.txtCodigo.Location = new System.Drawing.Point(91, 24);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(137, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.UseCustomBackColor = true;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // dgvProd
            // 
            this.dgvProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProd.Location = new System.Drawing.Point(35, 168);
            this.dgvProd.Name = "dgvProd";
            this.dgvProd.Size = new System.Drawing.Size(710, 277);
            this.dgvProd.TabIndex = 0;
            this.dgvProd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProd_CellDoubleClick);
            this.dgvProd.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvProd_Paint);
            this.dgvProd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProd_KeyDown);
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.txtDescripcionProd);
            this.gbxFiltro.Controls.Add(this.btnVerTodos);
            this.gbxFiltro.Controls.Add(this.btnSeleccionar);
            this.gbxFiltro.Controls.Add(this.txtCodigo);
            this.gbxFiltro.Controls.Add(this.metroLabel1);
            this.gbxFiltro.Controls.Add(this.txtCodigo02);
            this.gbxFiltro.Controls.Add(this.chkIncluirInactivos);
            this.gbxFiltro.Controls.Add(this.metroLabel2);
            this.gbxFiltro.Controls.Add(this.metroLabel3);
            this.gbxFiltro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxFiltro.Location = new System.Drawing.Point(35, 71);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(710, 91);
            this.gbxFiltro.TabIndex = 12;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Panel de filtros";
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(35, 23);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(233, 32);
            this.lblNombreForm.TabIndex = 73;
            this.lblNombreForm.Text = "Seleccionar producto";
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 478);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.gbxFiltro);
            this.Controls.Add(this.dgvProd);
            this.Name = "FormBuscarProducto";
            this.Load += new System.EventHandler(this.FormBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProd)).EndInit();
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnSeleccionar;
        private MetroFramework.Controls.MetroCheckBox chkIncluirInactivos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtDescripcionProd;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtCodigo02;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private System.Windows.Forms.DataGridView dgvProd;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.Label lblNombreForm;
    }
}