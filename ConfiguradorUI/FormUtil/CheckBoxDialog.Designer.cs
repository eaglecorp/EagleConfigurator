namespace ConfiguradorUI.FormUtil
{
    partial class CheckBoxDialog
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
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.chkDialog = new System.Windows.Forms.CheckBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSi
            // 
            this.btnSi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSi.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnSi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSi.FlatAppearance.BorderSize = 0;
            this.btnSi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.Color.White;
            this.btnSi.Location = new System.Drawing.Point(90, 124);
            this.btnSi.Margin = new System.Windows.Forms.Padding(2);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(81, 36);
            this.btnSi.TabIndex = 1;
            this.btnSi.Text = "&Sí";
            this.btnSi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSi.UseVisualStyleBackColor = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Location = new System.Drawing.Point(175, 124);
            this.btnNo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(81, 36);
            this.btnNo.TabIndex = 0;
            this.btnNo.Text = "&No";
            this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNo.UseVisualStyleBackColor = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // chkDialog
            // 
            this.chkDialog.AutoSize = true;
            this.chkDialog.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDialog.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkDialog.Location = new System.Drawing.Point(31, 182);
            this.chkDialog.Name = "chkDialog";
            this.chkDialog.Size = new System.Drawing.Size(201, 19);
            this.chkDialog.TabIndex = 2;
            this.chkDialog.Text = "No volver a mostrar este mensaje";
            this.chkDialog.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitulo.Location = new System.Drawing.Point(28, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(150, 25);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "CONFIRMACIÓN";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMensaje.Location = new System.Drawing.Point(47, 66);
            this.lblMensaje.MaximumSize = new System.Drawing.Size(250, 100);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(235, 40);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Tiene una modificación pendiente ¿Desea confirmar los cambios?";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSi);
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.chkDialog);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 220);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(288, 75);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(85, 85);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // CheckBoxDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(419, 227);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckBoxDialog";
            this.Load += new System.EventHandler(this.CheckBoxDialog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.CheckBox chkDialog;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLogo;
    }
}