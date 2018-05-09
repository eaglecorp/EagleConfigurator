namespace ConfiguradorUI.Buscadores
{
    partial class FormBuscarComboVariable
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
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new MetroFramework.Controls.MetroTextBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chkIncluirInactivos = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgvComboVariable = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvComboVariableDtl = new System.Windows.Forms.DataGridView();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.gbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboVariable)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboVariableDtl)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.txtDescripcion);
            this.gbxFiltro.Controls.Add(this.btnVerTodos);
            this.gbxFiltro.Controls.Add(this.btnSeleccionar);
            this.gbxFiltro.Controls.Add(this.txtCodigo);
            this.gbxFiltro.Controls.Add(this.metroLabel1);
            this.gbxFiltro.Controls.Add(this.chkIncluirInactivos);
            this.gbxFiltro.Controls.Add(this.metroLabel3);
            this.gbxFiltro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFiltro.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbxFiltro.Location = new System.Drawing.Point(35, 66);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(710, 91);
            this.gbxFiltro.TabIndex = 14;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Panel de filtros";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDescripcion.CustomButton.Image = null;
            this.txtDescripcion.CustomButton.Location = new System.Drawing.Point(471, 1);
            this.txtDescripcion.CustomButton.Name = "";
            this.txtDescripcion.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescripcion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescripcion.CustomButton.TabIndex = 1;
            this.txtDescripcion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescripcion.CustomButton.UseSelectable = true;
            this.txtDescripcion.CustomButton.Visible = false;
            this.txtDescripcion.Lines = new string[0];
            this.txtDescripcion.Location = new System.Drawing.Point(91, 53);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(493, 23);
            this.txtDescripcion.TabIndex = 5;
            this.txtDescripcion.UseCustomBackColor = true;
            this.txtDescripcion.UseSelectable = true;
            this.txtDescripcion.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescripcion.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
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
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(117, 1);
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
            this.txtCodigo.Size = new System.Drawing.Size(139, 23);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.UseCustomBackColor = true;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(6, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Código:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // chkIncluirInactivos
            // 
            this.chkIncluirInactivos.AutoSize = true;
            this.chkIncluirInactivos.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkIncluirInactivos.ForeColor = System.Drawing.Color.Navy;
            this.chkIncluirInactivos.Location = new System.Drawing.Point(464, 26);
            this.chkIncluirInactivos.Name = "chkIncluirInactivos";
            this.chkIncluirInactivos.Size = new System.Drawing.Size(120, 19);
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
            // dgvComboVariable
            // 
            this.dgvComboVariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComboVariable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComboVariable.Location = new System.Drawing.Point(3, 3);
            this.dgvComboVariable.Name = "dgvComboVariable";
            this.dgvComboVariable.Size = new System.Drawing.Size(417, 286);
            this.dgvComboVariable.TabIndex = 0;
            this.dgvComboVariable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComboVariable_CellDoubleClick);
            this.dgvComboVariable.SelectionChanged += new System.EventHandler(this.dgvComboVariable_SelectionChanged);
            this.dgvComboVariable.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvComboVariable_Paint);
            this.dgvComboVariable.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvComboVariable_KeyDown);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.57747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.42253F));
            this.tableLayoutPanel1.Controls.Add(this.dgvComboVariableDtl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvComboVariable, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 163);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 292F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(710, 292);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // dgvComboVariableDtl
            // 
            this.dgvComboVariableDtl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComboVariableDtl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComboVariableDtl.Location = new System.Drawing.Point(426, 3);
            this.dgvComboVariableDtl.Name = "dgvComboVariableDtl";
            this.dgvComboVariableDtl.Size = new System.Drawing.Size(281, 286);
            this.dgvComboVariableDtl.TabIndex = 14;
            this.dgvComboVariableDtl.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvComboVariableDtl_Paint);
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(35, 22);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(295, 32);
            this.lblNombreForm.TabIndex = 72;
            this.lblNombreForm.Text = "Seleccionar combo electivo";
            // 
            // FormBuscarComboVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 478);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.gbxFiltro);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormBuscarComboVariable";
            this.Load += new System.EventHandler(this.FormBuscarComboVariable_Load);
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboVariable)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboVariableDtl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltro;
        private MetroFramework.Controls.MetroTextBox txtDescripcion;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnSeleccionar;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox chkIncluirInactivos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.DataGridView dgvComboVariable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvComboVariableDtl;
        private System.Windows.Forms.Label lblNombreForm;
    }
}