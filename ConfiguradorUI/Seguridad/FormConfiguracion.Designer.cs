namespace ConfiguradorUI.Seguridad
{
    partial class FormConfiguracion
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.tabConfiguracion = new MetroFramework.Controls.MetroTabControl();
            this.tabPagEmail = new MetroFramework.Controls.MetroTabPage();
            this.grbConfiguracionMensajes = new System.Windows.Forms.GroupBox();
            this.txtAddMsjCredentials = new System.Windows.Forms.TextBox();
            this.txtAddMsjRegister = new System.Windows.Forms.TextBox();
            this.lblAddMsjCredentials = new MetroFramework.Controls.MetroLabel();
            this.lblSubjectCredentials = new MetroFramework.Controls.MetroLabel();
            this.txtSubjectCredentials = new MetroFramework.Controls.MetroTextBox();
            this.chkSendMailPostRegister = new MetroFramework.Controls.MetroCheckBox();
            this.lblAddMsjRegister = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubjectRegister = new MetroFramework.Controls.MetroLabel();
            this.txtSubjectRegister = new MetroFramework.Controls.MetroTextBox();
            this.grbCredencialesSistema = new System.Windows.Forms.GroupBox();
            this.lblContrasena = new MetroFramework.Controls.MetroLabel();
            this.txtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblDisplayNameEmail = new MetroFramework.Controls.MetroLabel();
            this.txtDisplayNameEmail = new MetroFramework.Controls.MetroTextBox();
            this.grbServidorCorreo = new System.Windows.Forms.GroupBox();
            this.lblPort = new MetroFramework.Controls.MetroLabel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.lblMailServer = new MetroFramework.Controls.MetroLabel();
            this.txtMailServer = new MetroFramework.Controls.MetroTextBox();
            this.tabPagFiscal = new MetroFramework.Controls.MetroTabPage();
            this.btnRemoveParamFis = new System.Windows.Forms.Button();
            this.txtValorDefParamFis = new MetroFramework.Controls.MetroTextBox();
            this.txtDescParamFis = new MetroFramework.Controls.MetroTextBox();
            this.txtCodParamFis = new MetroFramework.Controls.MetroTextBox();
            this.btnAddParametroFiscal = new System.Windows.Forms.Button();
            this.dgvParametrosFiscales = new System.Windows.Forms.DataGridView();
            this.tabPagComprobante = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAuthReimprComp = new MetroFramework.Controls.MetroCheckBox();
            this.chkAuthAnularComp = new MetroFramework.Controls.MetroCheckBox();
            this.tabPagUsuario = new MetroFramework.Controls.MetroTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkCreateUserAfterRegisterEmployee = new MetroFramework.Controls.MetroCheckBox();
            this.tabPagBaseDeDatos = new MetroFramework.Controls.MetroTabPage();
            this.grbBackupRestore = new System.Windows.Forms.GroupBox();
            this.chkHabilitarRestore = new MetroFramework.Controls.MetroCheckBox();
            this.tabPagDiseno = new MetroFramework.Controls.MetroTabPage();
            this.grbLogo = new System.Windows.Forms.GroupBox();
            this.lblPathLogo = new System.Windows.Forms.Label();
            this.btnCambiarLogo = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grbImagenLogin = new System.Windows.Forms.GroupBox();
            this.lblPathLoginImg = new System.Windows.Forms.Label();
            this.btnCambiarImagenLogin = new System.Windows.Forms.Button();
            this.picImagenLogin = new System.Windows.Forms.PictureBox();
            this.grbSplash = new System.Windows.Forms.GroupBox();
            this.lblPathSplash = new System.Windows.Forms.Label();
            this.btnCambiarSplash = new System.Windows.Forms.Button();
            this.picSplash = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCodParametro = new System.Windows.Forms.Label();
            this.lblDescripcionParametro = new System.Windows.Forms.Label();
            this.errorProvParamSis = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvParamFis = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabConfiguracion.SuspendLayout();
            this.tabPagEmail.SuspendLayout();
            this.grbConfiguracionMensajes.SuspendLayout();
            this.grbCredencialesSistema.SuspendLayout();
            this.grbServidorCorreo.SuspendLayout();
            this.tabPagFiscal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrosFiscales)).BeginInit();
            this.tabPagComprobante.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPagUsuario.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPagBaseDeDatos.SuspendLayout();
            this.grbBackupRestore.SuspendLayout();
            this.tabPagDiseno.SuspendLayout();
            this.grbLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grbImagenLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenLogin)).BeginInit();
            this.grbSplash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvParamSis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvParamFis)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(281, 32);
            this.lblNombreForm.TabIndex = 110;
            this.lblNombreForm.Text = "Configuración del sistema";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(28, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.UseSelectable = true;
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.Controls.Add(this.tabPagEmail);
            this.tabConfiguracion.Controls.Add(this.tabPagFiscal);
            this.tabConfiguracion.Controls.Add(this.tabPagComprobante);
            this.tabConfiguracion.Controls.Add(this.tabPagUsuario);
            this.tabConfiguracion.Controls.Add(this.tabPagBaseDeDatos);
            this.tabConfiguracion.Controls.Add(this.tabPagDiseno);
            this.tabConfiguracion.Location = new System.Drawing.Point(33, 89);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.SelectedIndex = 0;
            this.tabConfiguracion.Size = new System.Drawing.Size(567, 389);
            this.tabConfiguracion.TabIndex = 0;
            this.tabConfiguracion.UseSelectable = true;
            // 
            // tabPagEmail
            // 
            this.tabPagEmail.Controls.Add(this.grbConfiguracionMensajes);
            this.tabPagEmail.Controls.Add(this.grbCredencialesSistema);
            this.tabPagEmail.Controls.Add(this.grbServidorCorreo);
            this.tabPagEmail.HorizontalScrollbarBarColor = true;
            this.tabPagEmail.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagEmail.HorizontalScrollbarSize = 10;
            this.tabPagEmail.Location = new System.Drawing.Point(4, 38);
            this.tabPagEmail.Name = "tabPagEmail";
            this.tabPagEmail.Size = new System.Drawing.Size(559, 347);
            this.tabPagEmail.TabIndex = 0;
            this.tabPagEmail.Text = "Email";
            this.tabPagEmail.VerticalScrollbarBarColor = true;
            this.tabPagEmail.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagEmail.VerticalScrollbarSize = 10;
            // 
            // grbConfiguracionMensajes
            // 
            this.grbConfiguracionMensajes.BackColor = System.Drawing.Color.White;
            this.grbConfiguracionMensajes.Controls.Add(this.txtAddMsjCredentials);
            this.grbConfiguracionMensajes.Controls.Add(this.txtAddMsjRegister);
            this.grbConfiguracionMensajes.Controls.Add(this.lblAddMsjCredentials);
            this.grbConfiguracionMensajes.Controls.Add(this.lblSubjectCredentials);
            this.grbConfiguracionMensajes.Controls.Add(this.txtSubjectCredentials);
            this.grbConfiguracionMensajes.Controls.Add(this.chkSendMailPostRegister);
            this.grbConfiguracionMensajes.Controls.Add(this.lblAddMsjRegister);
            this.grbConfiguracionMensajes.Controls.Add(this.label1);
            this.grbConfiguracionMensajes.Controls.Add(this.lblSubjectRegister);
            this.grbConfiguracionMensajes.Controls.Add(this.txtSubjectRegister);
            this.grbConfiguracionMensajes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConfiguracionMensajes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbConfiguracionMensajes.Location = new System.Drawing.Point(254, 12);
            this.grbConfiguracionMensajes.Name = "grbConfiguracionMensajes";
            this.grbConfiguracionMensajes.Size = new System.Drawing.Size(302, 329);
            this.grbConfiguracionMensajes.TabIndex = 2;
            this.grbConfiguracionMensajes.TabStop = false;
            this.grbConfiguracionMensajes.Text = "Configuración de mensajes";
            // 
            // txtAddMsjCredentials
            // 
            this.txtAddMsjCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAddMsjCredentials.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMsjCredentials.Location = new System.Drawing.Point(16, 268);
            this.txtAddMsjCredentials.Multiline = true;
            this.txtAddMsjCredentials.Name = "txtAddMsjCredentials";
            this.txtAddMsjCredentials.Size = new System.Drawing.Size(264, 46);
            this.txtAddMsjCredentials.TabIndex = 4;
            this.txtAddMsjCredentials.Enter += new System.EventHandler(this.txtAddMsjCredentials_Enter);
            // 
            // txtAddMsjRegister
            // 
            this.txtAddMsjRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAddMsjRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMsjRegister.Location = new System.Drawing.Point(16, 96);
            this.txtAddMsjRegister.Multiline = true;
            this.txtAddMsjRegister.Name = "txtAddMsjRegister";
            this.txtAddMsjRegister.Size = new System.Drawing.Size(264, 46);
            this.txtAddMsjRegister.TabIndex = 1;
            this.txtAddMsjRegister.Enter += new System.EventHandler(this.txtAddMsjRegister_Enter);
            // 
            // lblAddMsjCredentials
            // 
            this.lblAddMsjCredentials.AutoSize = true;
            this.lblAddMsjCredentials.ForeColor = System.Drawing.Color.Navy;
            this.lblAddMsjCredentials.Location = new System.Drawing.Point(16, 246);
            this.lblAddMsjCredentials.Name = "lblAddMsjCredentials";
            this.lblAddMsjCredentials.Size = new System.Drawing.Size(253, 19);
            this.lblAddMsjCredentials.TabIndex = 14;
            this.lblAddMsjCredentials.Text = "Adjuntar mensaje - Envío de credenciales:";
            this.lblAddMsjCredentials.UseCustomForeColor = true;
            // 
            // lblSubjectCredentials
            // 
            this.lblSubjectCredentials.AutoSize = true;
            this.lblSubjectCredentials.ForeColor = System.Drawing.Color.Navy;
            this.lblSubjectCredentials.Location = new System.Drawing.Point(16, 198);
            this.lblSubjectCredentials.Name = "lblSubjectCredentials";
            this.lblSubjectCredentials.Size = new System.Drawing.Size(191, 19);
            this.lblSubjectCredentials.TabIndex = 12;
            this.lblSubjectCredentials.Text = "Asunto - Envío de credenciales:";
            this.lblSubjectCredentials.UseCustomForeColor = true;
            // 
            // txtSubjectCredentials
            // 
            this.txtSubjectCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtSubjectCredentials.CustomButton.Image = null;
            this.txtSubjectCredentials.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtSubjectCredentials.CustomButton.Name = "";
            this.txtSubjectCredentials.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubjectCredentials.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubjectCredentials.CustomButton.TabIndex = 1;
            this.txtSubjectCredentials.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubjectCredentials.CustomButton.UseSelectable = true;
            this.txtSubjectCredentials.CustomButton.Visible = false;
            this.txtSubjectCredentials.Lines = new string[0];
            this.txtSubjectCredentials.Location = new System.Drawing.Point(16, 220);
            this.txtSubjectCredentials.MaxLength = 32767;
            this.txtSubjectCredentials.Name = "txtSubjectCredentials";
            this.txtSubjectCredentials.PasswordChar = '\0';
            this.txtSubjectCredentials.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubjectCredentials.SelectedText = "";
            this.txtSubjectCredentials.SelectionLength = 0;
            this.txtSubjectCredentials.SelectionStart = 0;
            this.txtSubjectCredentials.ShortcutsEnabled = true;
            this.txtSubjectCredentials.Size = new System.Drawing.Size(264, 23);
            this.txtSubjectCredentials.TabIndex = 3;
            this.txtSubjectCredentials.UseCustomBackColor = true;
            this.txtSubjectCredentials.UseSelectable = true;
            this.txtSubjectCredentials.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubjectCredentials.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSubjectCredentials.Enter += new System.EventHandler(this.txtSubjectCredentials_Enter);
            // 
            // chkSendMailPostRegister
            // 
            this.chkSendMailPostRegister.AutoSize = true;
            this.chkSendMailPostRegister.Checked = true;
            this.chkSendMailPostRegister.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSendMailPostRegister.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkSendMailPostRegister.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkSendMailPostRegister.ForeColor = System.Drawing.Color.Navy;
            this.chkSendMailPostRegister.Location = new System.Drawing.Point(18, 148);
            this.chkSendMailPostRegister.Name = "chkSendMailPostRegister";
            this.chkSendMailPostRegister.Size = new System.Drawing.Size(254, 19);
            this.chkSendMailPostRegister.TabIndex = 2;
            this.chkSendMailPostRegister.Text = "Enviar credenciales después de registro";
            this.chkSendMailPostRegister.UseCustomForeColor = true;
            this.chkSendMailPostRegister.UseSelectable = true;
            this.chkSendMailPostRegister.MouseEnter += new System.EventHandler(this.chkSendMailPostRegister_MouseEnter);
            // 
            // lblAddMsjRegister
            // 
            this.lblAddMsjRegister.AutoSize = true;
            this.lblAddMsjRegister.ForeColor = System.Drawing.Color.Navy;
            this.lblAddMsjRegister.Location = new System.Drawing.Point(16, 74);
            this.lblAddMsjRegister.Name = "lblAddMsjRegister";
            this.lblAddMsjRegister.Size = new System.Drawing.Size(212, 19);
            this.lblAddMsjRegister.TabIndex = 8;
            this.lblAddMsjRegister.Text = "Adjuntar mensaje - Nuevo usuario:";
            this.lblAddMsjRegister.UseCustomForeColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 2);
            this.label1.TabIndex = 6;
            // 
            // lblSubjectRegister
            // 
            this.lblSubjectRegister.AutoSize = true;
            this.lblSubjectRegister.ForeColor = System.Drawing.Color.Navy;
            this.lblSubjectRegister.Location = new System.Drawing.Point(16, 26);
            this.lblSubjectRegister.Name = "lblSubjectRegister";
            this.lblSubjectRegister.Size = new System.Drawing.Size(150, 19);
            this.lblSubjectRegister.TabIndex = 4;
            this.lblSubjectRegister.Text = "Asunto - Nuevo usuario:";
            this.lblSubjectRegister.UseCustomForeColor = true;
            // 
            // txtSubjectRegister
            // 
            this.txtSubjectRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtSubjectRegister.CustomButton.Image = null;
            this.txtSubjectRegister.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtSubjectRegister.CustomButton.Name = "";
            this.txtSubjectRegister.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubjectRegister.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubjectRegister.CustomButton.TabIndex = 1;
            this.txtSubjectRegister.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubjectRegister.CustomButton.UseSelectable = true;
            this.txtSubjectRegister.CustomButton.Visible = false;
            this.txtSubjectRegister.Lines = new string[0];
            this.txtSubjectRegister.Location = new System.Drawing.Point(16, 48);
            this.txtSubjectRegister.MaxLength = 32767;
            this.txtSubjectRegister.Name = "txtSubjectRegister";
            this.txtSubjectRegister.PasswordChar = '\0';
            this.txtSubjectRegister.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubjectRegister.SelectedText = "";
            this.txtSubjectRegister.SelectionLength = 0;
            this.txtSubjectRegister.SelectionStart = 0;
            this.txtSubjectRegister.ShortcutsEnabled = true;
            this.txtSubjectRegister.Size = new System.Drawing.Size(264, 23);
            this.txtSubjectRegister.TabIndex = 0;
            this.txtSubjectRegister.UseCustomBackColor = true;
            this.txtSubjectRegister.UseSelectable = true;
            this.txtSubjectRegister.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubjectRegister.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSubjectRegister.Enter += new System.EventHandler(this.txtSubjectRegister_Enter);
            // 
            // grbCredencialesSistema
            // 
            this.grbCredencialesSistema.BackColor = System.Drawing.Color.White;
            this.grbCredencialesSistema.Controls.Add(this.lblContrasena);
            this.grbCredencialesSistema.Controls.Add(this.txtContrasena);
            this.grbCredencialesSistema.Controls.Add(this.lblEmail);
            this.grbCredencialesSistema.Controls.Add(this.txtEmail);
            this.grbCredencialesSistema.Controls.Add(this.lblDisplayNameEmail);
            this.grbCredencialesSistema.Controls.Add(this.txtDisplayNameEmail);
            this.grbCredencialesSistema.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCredencialesSistema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbCredencialesSistema.Location = new System.Drawing.Point(3, 157);
            this.grbCredencialesSistema.Name = "grbCredencialesSistema";
            this.grbCredencialesSistema.Size = new System.Drawing.Size(245, 184);
            this.grbCredencialesSistema.TabIndex = 1;
            this.grbCredencialesSistema.TabStop = false;
            this.grbCredencialesSistema.Text = "Credenciales del sistema";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.ForeColor = System.Drawing.Color.Navy;
            this.lblContrasena.Location = new System.Drawing.Point(15, 76);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(78, 19);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña:";
            this.lblContrasena.UseCustomForeColor = true;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtContrasena.CustomButton.Image = null;
            this.txtContrasena.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtContrasena.CustomButton.Name = "";
            this.txtContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasena.CustomButton.TabIndex = 1;
            this.txtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasena.CustomButton.UseSelectable = true;
            this.txtContrasena.CustomButton.Visible = false;
            this.txtContrasena.Lines = new string[0];
            this.txtContrasena.Location = new System.Drawing.Point(15, 98);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '\0';
            this.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.ShortcutsEnabled = true;
            this.txtContrasena.Size = new System.Drawing.Size(209, 23);
            this.txtContrasena.TabIndex = 1;
            this.txtContrasena.UseCustomBackColor = true;
            this.txtContrasena.UseSelectable = true;
            this.txtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContrasena.Enter += new System.EventHandler(this.txtContrasena_Enter);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Navy;
            this.lblEmail.Location = new System.Drawing.Point(15, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            this.lblEmail.UseCustomForeColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(15, 50);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(209, 23);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.UseCustomBackColor = true;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            // 
            // lblDisplayNameEmail
            // 
            this.lblDisplayNameEmail.AutoSize = true;
            this.lblDisplayNameEmail.ForeColor = System.Drawing.Color.Navy;
            this.lblDisplayNameEmail.Location = new System.Drawing.Point(15, 124);
            this.lblDisplayNameEmail.Name = "lblDisplayNameEmail";
            this.lblDisplayNameEmail.Size = new System.Drawing.Size(126, 19);
            this.lblDisplayNameEmail.TabIndex = 2;
            this.lblDisplayNameEmail.Text = "Nombre de emisor:";
            this.lblDisplayNameEmail.UseCustomForeColor = true;
            // 
            // txtDisplayNameEmail
            // 
            this.txtDisplayNameEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDisplayNameEmail.CustomButton.Image = null;
            this.txtDisplayNameEmail.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtDisplayNameEmail.CustomButton.Name = "";
            this.txtDisplayNameEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDisplayNameEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDisplayNameEmail.CustomButton.TabIndex = 1;
            this.txtDisplayNameEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDisplayNameEmail.CustomButton.UseSelectable = true;
            this.txtDisplayNameEmail.CustomButton.Visible = false;
            this.txtDisplayNameEmail.Lines = new string[0];
            this.txtDisplayNameEmail.Location = new System.Drawing.Point(15, 146);
            this.txtDisplayNameEmail.MaxLength = 32767;
            this.txtDisplayNameEmail.Name = "txtDisplayNameEmail";
            this.txtDisplayNameEmail.PasswordChar = '\0';
            this.txtDisplayNameEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDisplayNameEmail.SelectedText = "";
            this.txtDisplayNameEmail.SelectionLength = 0;
            this.txtDisplayNameEmail.SelectionStart = 0;
            this.txtDisplayNameEmail.ShortcutsEnabled = true;
            this.txtDisplayNameEmail.Size = new System.Drawing.Size(209, 23);
            this.txtDisplayNameEmail.TabIndex = 2;
            this.txtDisplayNameEmail.UseCustomBackColor = true;
            this.txtDisplayNameEmail.UseSelectable = true;
            this.txtDisplayNameEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDisplayNameEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDisplayNameEmail.Enter += new System.EventHandler(this.txtDisplayNameEmail_Enter);
            // 
            // grbServidorCorreo
            // 
            this.grbServidorCorreo.BackColor = System.Drawing.Color.White;
            this.grbServidorCorreo.Controls.Add(this.lblPort);
            this.grbServidorCorreo.Controls.Add(this.txtPort);
            this.grbServidorCorreo.Controls.Add(this.lblMailServer);
            this.grbServidorCorreo.Controls.Add(this.txtMailServer);
            this.grbServidorCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbServidorCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbServidorCorreo.Location = new System.Drawing.Point(3, 12);
            this.grbServidorCorreo.Name = "grbServidorCorreo";
            this.grbServidorCorreo.Size = new System.Drawing.Size(245, 139);
            this.grbServidorCorreo.TabIndex = 0;
            this.grbServidorCorreo.TabStop = false;
            this.grbServidorCorreo.Text = "Servidor de correo";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.ForeColor = System.Drawing.Color.Navy;
            this.lblPort.Location = new System.Drawing.Point(15, 74);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 19);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            this.lblPort.UseCustomForeColor = true;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(15, 96);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(209, 23);
            this.txtPort.TabIndex = 1;
            this.txtPort.UseCustomBackColor = true;
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPort.Enter += new System.EventHandler(this.txtPort_Enter);
            // 
            // lblMailServer
            // 
            this.lblMailServer.AutoSize = true;
            this.lblMailServer.ForeColor = System.Drawing.Color.Navy;
            this.lblMailServer.Location = new System.Drawing.Point(15, 26);
            this.lblMailServer.Name = "lblMailServer";
            this.lblMailServer.Size = new System.Drawing.Size(80, 19);
            this.lblMailServer.TabIndex = 2;
            this.lblMailServer.Text = "Mail Server:";
            this.lblMailServer.UseCustomForeColor = true;
            // 
            // txtMailServer
            // 
            this.txtMailServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtMailServer.CustomButton.Image = null;
            this.txtMailServer.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtMailServer.CustomButton.Name = "";
            this.txtMailServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMailServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMailServer.CustomButton.TabIndex = 1;
            this.txtMailServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMailServer.CustomButton.UseSelectable = true;
            this.txtMailServer.CustomButton.Visible = false;
            this.txtMailServer.Lines = new string[0];
            this.txtMailServer.Location = new System.Drawing.Point(15, 48);
            this.txtMailServer.MaxLength = 32767;
            this.txtMailServer.Name = "txtMailServer";
            this.txtMailServer.PasswordChar = '\0';
            this.txtMailServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMailServer.SelectedText = "";
            this.txtMailServer.SelectionLength = 0;
            this.txtMailServer.SelectionStart = 0;
            this.txtMailServer.ShortcutsEnabled = true;
            this.txtMailServer.Size = new System.Drawing.Size(209, 23);
            this.txtMailServer.TabIndex = 0;
            this.txtMailServer.UseCustomBackColor = true;
            this.txtMailServer.UseSelectable = true;
            this.txtMailServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMailServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMailServer.Enter += new System.EventHandler(this.txtMailServer_Enter);
            // 
            // tabPagFiscal
            // 
            this.tabPagFiscal.Controls.Add(this.btnRemoveParamFis);
            this.tabPagFiscal.Controls.Add(this.txtValorDefParamFis);
            this.tabPagFiscal.Controls.Add(this.txtDescParamFis);
            this.tabPagFiscal.Controls.Add(this.txtCodParamFis);
            this.tabPagFiscal.Controls.Add(this.btnAddParametroFiscal);
            this.tabPagFiscal.Controls.Add(this.dgvParametrosFiscales);
            this.tabPagFiscal.HorizontalScrollbarBarColor = true;
            this.tabPagFiscal.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagFiscal.HorizontalScrollbarSize = 10;
            this.tabPagFiscal.Location = new System.Drawing.Point(4, 38);
            this.tabPagFiscal.Name = "tabPagFiscal";
            this.tabPagFiscal.Size = new System.Drawing.Size(559, 347);
            this.tabPagFiscal.TabIndex = 3;
            this.tabPagFiscal.Text = "Fiscal";
            this.tabPagFiscal.VerticalScrollbarBarColor = true;
            this.tabPagFiscal.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagFiscal.VerticalScrollbarSize = 10;
            // 
            // btnRemoveParamFis
            // 
            this.btnRemoveParamFis.BackColor = System.Drawing.Color.Gray;
            this.btnRemoveParamFis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveParamFis.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRemoveParamFis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveParamFis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveParamFis.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveParamFis.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveParamFis.Image")));
            this.btnRemoveParamFis.Location = new System.Drawing.Point(526, 10);
            this.btnRemoveParamFis.Name = "btnRemoveParamFis";
            this.btnRemoveParamFis.Size = new System.Drawing.Size(30, 23);
            this.btnRemoveParamFis.TabIndex = 4;
            this.btnRemoveParamFis.UseVisualStyleBackColor = false;
            this.btnRemoveParamFis.Click += new System.EventHandler(this.btnRemoveParamFis_Click);
            // 
            // txtValorDefParamFis
            // 
            this.txtValorDefParamFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtValorDefParamFis.CustomButton.Image = null;
            this.txtValorDefParamFis.CustomButton.Location = new System.Drawing.Point(64, 1);
            this.txtValorDefParamFis.CustomButton.Name = "";
            this.txtValorDefParamFis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValorDefParamFis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValorDefParamFis.CustomButton.TabIndex = 1;
            this.txtValorDefParamFis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValorDefParamFis.CustomButton.UseSelectable = true;
            this.txtValorDefParamFis.CustomButton.Visible = false;
            this.txtValorDefParamFis.Lines = new string[0];
            this.txtValorDefParamFis.Location = new System.Drawing.Point(398, 10);
            this.txtValorDefParamFis.MaxLength = 32767;
            this.txtValorDefParamFis.Name = "txtValorDefParamFis";
            this.txtValorDefParamFis.PasswordChar = '\0';
            this.txtValorDefParamFis.PromptText = "Valor Default";
            this.txtValorDefParamFis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValorDefParamFis.SelectedText = "";
            this.txtValorDefParamFis.SelectionLength = 0;
            this.txtValorDefParamFis.SelectionStart = 0;
            this.txtValorDefParamFis.ShortcutsEnabled = true;
            this.txtValorDefParamFis.Size = new System.Drawing.Size(86, 23);
            this.txtValorDefParamFis.TabIndex = 2;
            this.txtValorDefParamFis.UseCustomBackColor = true;
            this.txtValorDefParamFis.UseSelectable = true;
            this.txtValorDefParamFis.WaterMark = "Valor Default";
            this.txtValorDefParamFis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValorDefParamFis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDescParamFis
            // 
            this.txtDescParamFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDescParamFis.CustomButton.Image = null;
            this.txtDescParamFis.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtDescParamFis.CustomButton.Name = "";
            this.txtDescParamFis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDescParamFis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescParamFis.CustomButton.TabIndex = 1;
            this.txtDescParamFis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescParamFis.CustomButton.UseSelectable = true;
            this.txtDescParamFis.CustomButton.Visible = false;
            this.txtDescParamFis.Lines = new string[0];
            this.txtDescParamFis.Location = new System.Drawing.Point(144, 10);
            this.txtDescParamFis.MaxLength = 32767;
            this.txtDescParamFis.Name = "txtDescParamFis";
            this.txtDescParamFis.PasswordChar = '\0';
            this.txtDescParamFis.PromptText = "Nombre del parámetro";
            this.txtDescParamFis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescParamFis.SelectedText = "";
            this.txtDescParamFis.SelectionLength = 0;
            this.txtDescParamFis.SelectionStart = 0;
            this.txtDescParamFis.ShortcutsEnabled = true;
            this.txtDescParamFis.Size = new System.Drawing.Size(248, 23);
            this.txtDescParamFis.TabIndex = 1;
            this.txtDescParamFis.UseCustomBackColor = true;
            this.txtDescParamFis.UseSelectable = true;
            this.txtDescParamFis.WaterMark = "Nombre del parámetro";
            this.txtDescParamFis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescParamFis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCodParamFis
            // 
            this.txtCodParamFis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodParamFis.CustomButton.Image = null;
            this.txtCodParamFis.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.txtCodParamFis.CustomButton.Name = "";
            this.txtCodParamFis.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodParamFis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodParamFis.CustomButton.TabIndex = 1;
            this.txtCodParamFis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodParamFis.CustomButton.UseSelectable = true;
            this.txtCodParamFis.CustomButton.Visible = false;
            this.txtCodParamFis.Lines = new string[0];
            this.txtCodParamFis.Location = new System.Drawing.Point(3, 10);
            this.txtCodParamFis.MaxLength = 32767;
            this.txtCodParamFis.Name = "txtCodParamFis";
            this.txtCodParamFis.PasswordChar = '\0';
            this.txtCodParamFis.PromptText = "Código";
            this.txtCodParamFis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodParamFis.SelectedText = "";
            this.txtCodParamFis.SelectionLength = 0;
            this.txtCodParamFis.SelectionStart = 0;
            this.txtCodParamFis.ShortcutsEnabled = true;
            this.txtCodParamFis.Size = new System.Drawing.Size(135, 23);
            this.txtCodParamFis.TabIndex = 0;
            this.txtCodParamFis.UseCustomBackColor = true;
            this.txtCodParamFis.UseSelectable = true;
            this.txtCodParamFis.WaterMark = "Código";
            this.txtCodParamFis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodParamFis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAddParametroFiscal
            // 
            this.btnAddParametroFiscal.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddParametroFiscal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddParametroFiscal.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddParametroFiscal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnAddParametroFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddParametroFiscal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddParametroFiscal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddParametroFiscal.Image = ((System.Drawing.Image)(resources.GetObject("btnAddParametroFiscal.Image")));
            this.btnAddParametroFiscal.Location = new System.Drawing.Point(490, 10);
            this.btnAddParametroFiscal.Name = "btnAddParametroFiscal";
            this.btnAddParametroFiscal.Size = new System.Drawing.Size(30, 23);
            this.btnAddParametroFiscal.TabIndex = 3;
            this.btnAddParametroFiscal.UseVisualStyleBackColor = false;
            this.btnAddParametroFiscal.Click += new System.EventHandler(this.btnAddParametroFiscal_Click);
            // 
            // dgvParametrosFiscales
            // 
            this.dgvParametrosFiscales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParametrosFiscales.Location = new System.Drawing.Point(3, 39);
            this.dgvParametrosFiscales.Name = "dgvParametrosFiscales";
            this.dgvParametrosFiscales.Size = new System.Drawing.Size(553, 302);
            this.dgvParametrosFiscales.TabIndex = 5;
            this.dgvParametrosFiscales.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParametrosFiscales_CellValueChanged);
            this.dgvParametrosFiscales.SelectionChanged += new System.EventHandler(this.dgvParametrosFiscales_SelectionChanged);
            this.dgvParametrosFiscales.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvBordered_Paint);
            // 
            // tabPagComprobante
            // 
            this.tabPagComprobante.Controls.Add(this.groupBox1);
            this.tabPagComprobante.HorizontalScrollbarBarColor = true;
            this.tabPagComprobante.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagComprobante.HorizontalScrollbarSize = 10;
            this.tabPagComprobante.Location = new System.Drawing.Point(4, 38);
            this.tabPagComprobante.Name = "tabPagComprobante";
            this.tabPagComprobante.Size = new System.Drawing.Size(559, 347);
            this.tabPagComprobante.TabIndex = 4;
            this.tabPagComprobante.Text = "Comprobante";
            this.tabPagComprobante.VerticalScrollbarBarColor = true;
            this.tabPagComprobante.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagComprobante.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chkAuthReimprComp);
            this.groupBox1.Controls.Add(this.chkAuthAnularComp);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(3, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Autorizaciones";
            // 
            // chkAuthReimprComp
            // 
            this.chkAuthReimprComp.AutoSize = true;
            this.chkAuthReimprComp.Checked = true;
            this.chkAuthReimprComp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuthReimprComp.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkAuthReimprComp.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkAuthReimprComp.ForeColor = System.Drawing.Color.Navy;
            this.chkAuthReimprComp.Location = new System.Drawing.Point(17, 50);
            this.chkAuthReimprComp.Name = "chkAuthReimprComp";
            this.chkAuthReimprComp.Size = new System.Drawing.Size(371, 19);
            this.chkAuthReimprComp.TabIndex = 1;
            this.chkAuthReimprComp.Text = "Reimprimir comprobante requiere autorización de gerente";
            this.chkAuthReimprComp.UseCustomForeColor = true;
            this.chkAuthReimprComp.UseSelectable = true;
            this.chkAuthReimprComp.MouseEnter += new System.EventHandler(this.chkAuthReimprComp_MouseEnter);
            // 
            // chkAuthAnularComp
            // 
            this.chkAuthAnularComp.AutoSize = true;
            this.chkAuthAnularComp.Checked = true;
            this.chkAuthAnularComp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAuthAnularComp.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkAuthAnularComp.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkAuthAnularComp.ForeColor = System.Drawing.Color.Navy;
            this.chkAuthAnularComp.Location = new System.Drawing.Point(17, 25);
            this.chkAuthAnularComp.Name = "chkAuthAnularComp";
            this.chkAuthAnularComp.Size = new System.Drawing.Size(343, 19);
            this.chkAuthAnularComp.TabIndex = 0;
            this.chkAuthAnularComp.Text = "Anular comprobante requiere autorización de gerente";
            this.chkAuthAnularComp.UseCustomForeColor = true;
            this.chkAuthAnularComp.UseSelectable = true;
            this.chkAuthAnularComp.MouseEnter += new System.EventHandler(this.chkAuthAnularComp_MouseEnter);
            // 
            // tabPagUsuario
            // 
            this.tabPagUsuario.Controls.Add(this.groupBox2);
            this.tabPagUsuario.HorizontalScrollbarBarColor = true;
            this.tabPagUsuario.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagUsuario.HorizontalScrollbarSize = 10;
            this.tabPagUsuario.Location = new System.Drawing.Point(4, 38);
            this.tabPagUsuario.Name = "tabPagUsuario";
            this.tabPagUsuario.Size = new System.Drawing.Size(559, 347);
            this.tabPagUsuario.TabIndex = 5;
            this.tabPagUsuario.Text = "Usuario";
            this.tabPagUsuario.VerticalScrollbarBarColor = true;
            this.tabPagUsuario.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagUsuario.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.chkCreateUserAfterRegisterEmployee);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(3, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuario de empleado";
            // 
            // chkCreateUserAfterRegisterEmployee
            // 
            this.chkCreateUserAfterRegisterEmployee.AutoSize = true;
            this.chkCreateUserAfterRegisterEmployee.Checked = true;
            this.chkCreateUserAfterRegisterEmployee.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCreateUserAfterRegisterEmployee.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkCreateUserAfterRegisterEmployee.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkCreateUserAfterRegisterEmployee.ForeColor = System.Drawing.Color.Navy;
            this.chkCreateUserAfterRegisterEmployee.Location = new System.Drawing.Point(17, 25);
            this.chkCreateUserAfterRegisterEmployee.Name = "chkCreateUserAfterRegisterEmployee";
            this.chkCreateUserAfterRegisterEmployee.Size = new System.Drawing.Size(396, 19);
            this.chkCreateUserAfterRegisterEmployee.TabIndex = 0;
            this.chkCreateUserAfterRegisterEmployee.Text = "Crear usuario automáticamente después de crear un empleado";
            this.chkCreateUserAfterRegisterEmployee.UseCustomForeColor = true;
            this.chkCreateUserAfterRegisterEmployee.UseSelectable = true;
            this.chkCreateUserAfterRegisterEmployee.MouseEnter += new System.EventHandler(this.chkCreateUserAfterRegisterEmployee_MouseEnter);
            // 
            // tabPagBaseDeDatos
            // 
            this.tabPagBaseDeDatos.Controls.Add(this.grbBackupRestore);
            this.tabPagBaseDeDatos.HorizontalScrollbarBarColor = true;
            this.tabPagBaseDeDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagBaseDeDatos.HorizontalScrollbarSize = 10;
            this.tabPagBaseDeDatos.Location = new System.Drawing.Point(4, 38);
            this.tabPagBaseDeDatos.Name = "tabPagBaseDeDatos";
            this.tabPagBaseDeDatos.Size = new System.Drawing.Size(559, 347);
            this.tabPagBaseDeDatos.TabIndex = 2;
            this.tabPagBaseDeDatos.Text = "Base de Datos";
            this.tabPagBaseDeDatos.VerticalScrollbarBarColor = true;
            this.tabPagBaseDeDatos.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagBaseDeDatos.VerticalScrollbarSize = 10;
            // 
            // grbBackupRestore
            // 
            this.grbBackupRestore.BackColor = System.Drawing.Color.White;
            this.grbBackupRestore.Controls.Add(this.chkHabilitarRestore);
            this.grbBackupRestore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBackupRestore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbBackupRestore.Location = new System.Drawing.Point(3, 16);
            this.grbBackupRestore.Name = "grbBackupRestore";
            this.grbBackupRestore.Size = new System.Drawing.Size(553, 62);
            this.grbBackupRestore.TabIndex = 0;
            this.grbBackupRestore.TabStop = false;
            this.grbBackupRestore.Text = "Backup y Restore";
            // 
            // chkHabilitarRestore
            // 
            this.chkHabilitarRestore.AutoSize = true;
            this.chkHabilitarRestore.Checked = true;
            this.chkHabilitarRestore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitarRestore.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkHabilitarRestore.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkHabilitarRestore.ForeColor = System.Drawing.Color.Navy;
            this.chkHabilitarRestore.Location = new System.Drawing.Point(17, 25);
            this.chkHabilitarRestore.Name = "chkHabilitarRestore";
            this.chkHabilitarRestore.Size = new System.Drawing.Size(312, 19);
            this.chkHabilitarRestore.TabIndex = 0;
            this.chkHabilitarRestore.Text = "Habilitar botón de restauración de base de datos";
            this.chkHabilitarRestore.UseCustomForeColor = true;
            this.chkHabilitarRestore.UseSelectable = true;
            this.chkHabilitarRestore.MouseEnter += new System.EventHandler(this.chkHabilitarRestore_MouseEnter);
            // 
            // tabPagDiseno
            // 
            this.tabPagDiseno.Controls.Add(this.grbLogo);
            this.tabPagDiseno.Controls.Add(this.grbImagenLogin);
            this.tabPagDiseno.Controls.Add(this.grbSplash);
            this.tabPagDiseno.HorizontalScrollbarBarColor = true;
            this.tabPagDiseno.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagDiseno.HorizontalScrollbarSize = 10;
            this.tabPagDiseno.Location = new System.Drawing.Point(4, 38);
            this.tabPagDiseno.Name = "tabPagDiseno";
            this.tabPagDiseno.Size = new System.Drawing.Size(559, 347);
            this.tabPagDiseno.TabIndex = 1;
            this.tabPagDiseno.Text = "Diseño";
            this.tabPagDiseno.VerticalScrollbarBarColor = true;
            this.tabPagDiseno.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagDiseno.VerticalScrollbarSize = 10;
            // 
            // grbLogo
            // 
            this.grbLogo.BackColor = System.Drawing.Color.White;
            this.grbLogo.Controls.Add(this.lblPathLogo);
            this.grbLogo.Controls.Add(this.btnCambiarLogo);
            this.grbLogo.Controls.Add(this.picLogo);
            this.grbLogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLogo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbLogo.Location = new System.Drawing.Point(377, 16);
            this.grbLogo.Margin = new System.Windows.Forms.Padding(20);
            this.grbLogo.Name = "grbLogo";
            this.grbLogo.Size = new System.Drawing.Size(162, 200);
            this.grbLogo.TabIndex = 2;
            this.grbLogo.TabStop = false;
            this.grbLogo.Text = "Logo";
            // 
            // lblPathLogo
            // 
            this.lblPathLogo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathLogo.Location = new System.Drawing.Point(18, 184);
            this.lblPathLogo.Name = "lblPathLogo";
            this.lblPathLogo.Size = new System.Drawing.Size(125, 13);
            this.lblPathLogo.TabIndex = 118;
            this.lblPathLogo.Text = "path logo";
            // 
            // btnCambiarLogo
            // 
            this.btnCambiarLogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarLogo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarLogo.FlatAppearance.BorderSize = 0;
            this.btnCambiarLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCambiarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarLogo.ForeColor = System.Drawing.Color.White;
            this.btnCambiarLogo.Location = new System.Drawing.Point(46, 159);
            this.btnCambiarLogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarLogo.Name = "btnCambiarLogo";
            this.btnCambiarLogo.Size = new System.Drawing.Size(69, 24);
            this.btnCambiarLogo.TabIndex = 0;
            this.btnCambiarLogo.Text = "Cambiar";
            this.btnCambiarLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarLogo.UseVisualStyleBackColor = false;
            this.btnCambiarLogo.Click += new System.EventHandler(this.btnCambiarLogo_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(18, 28);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 126);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 21;
            this.picLogo.TabStop = false;
            this.picLogo.MouseEnter += new System.EventHandler(this.picLogo_MouseEnter);
            // 
            // grbImagenLogin
            // 
            this.grbImagenLogin.BackColor = System.Drawing.Color.White;
            this.grbImagenLogin.Controls.Add(this.lblPathLoginImg);
            this.grbImagenLogin.Controls.Add(this.btnCambiarImagenLogin);
            this.grbImagenLogin.Controls.Add(this.picImagenLogin);
            this.grbImagenLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbImagenLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbImagenLogin.Location = new System.Drawing.Point(198, 16);
            this.grbImagenLogin.Margin = new System.Windows.Forms.Padding(20);
            this.grbImagenLogin.Name = "grbImagenLogin";
            this.grbImagenLogin.Size = new System.Drawing.Size(162, 200);
            this.grbImagenLogin.TabIndex = 1;
            this.grbImagenLogin.TabStop = false;
            this.grbImagenLogin.Text = "Imagen del login";
            // 
            // lblPathLoginImg
            // 
            this.lblPathLoginImg.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathLoginImg.Location = new System.Drawing.Point(18, 184);
            this.lblPathLoginImg.Name = "lblPathLoginImg";
            this.lblPathLoginImg.Size = new System.Drawing.Size(125, 13);
            this.lblPathLoginImg.TabIndex = 117;
            this.lblPathLoginImg.Text = "path imagen login";
            // 
            // btnCambiarImagenLogin
            // 
            this.btnCambiarImagenLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarImagenLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarImagenLogin.FlatAppearance.BorderSize = 0;
            this.btnCambiarImagenLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarImagenLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCambiarImagenLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarImagenLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarImagenLogin.ForeColor = System.Drawing.Color.White;
            this.btnCambiarImagenLogin.Location = new System.Drawing.Point(46, 159);
            this.btnCambiarImagenLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarImagenLogin.Name = "btnCambiarImagenLogin";
            this.btnCambiarImagenLogin.Size = new System.Drawing.Size(69, 24);
            this.btnCambiarImagenLogin.TabIndex = 0;
            this.btnCambiarImagenLogin.Text = "Cambiar";
            this.btnCambiarImagenLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarImagenLogin.UseVisualStyleBackColor = false;
            this.btnCambiarImagenLogin.Click += new System.EventHandler(this.btnCambiarImagenLogin_Click);
            // 
            // picImagenLogin
            // 
            this.picImagenLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.picImagenLogin.InitialImage = null;
            this.picImagenLogin.Location = new System.Drawing.Point(18, 28);
            this.picImagenLogin.Name = "picImagenLogin";
            this.picImagenLogin.Size = new System.Drawing.Size(125, 126);
            this.picImagenLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImagenLogin.TabIndex = 21;
            this.picImagenLogin.TabStop = false;
            this.picImagenLogin.MouseEnter += new System.EventHandler(this.picImagenLogin_MouseEnter);
            // 
            // grbSplash
            // 
            this.grbSplash.BackColor = System.Drawing.Color.White;
            this.grbSplash.Controls.Add(this.lblPathSplash);
            this.grbSplash.Controls.Add(this.btnCambiarSplash);
            this.grbSplash.Controls.Add(this.picSplash);
            this.grbSplash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSplash.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbSplash.Location = new System.Drawing.Point(20, 16);
            this.grbSplash.Margin = new System.Windows.Forms.Padding(20);
            this.grbSplash.Name = "grbSplash";
            this.grbSplash.Size = new System.Drawing.Size(162, 200);
            this.grbSplash.TabIndex = 0;
            this.grbSplash.TabStop = false;
            this.grbSplash.Text = "Splash";
            // 
            // lblPathSplash
            // 
            this.lblPathSplash.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathSplash.Location = new System.Drawing.Point(18, 184);
            this.lblPathSplash.Name = "lblPathSplash";
            this.lblPathSplash.Size = new System.Drawing.Size(125, 13);
            this.lblPathSplash.TabIndex = 116;
            this.lblPathSplash.Text = "path splash";
            // 
            // btnCambiarSplash
            // 
            this.btnCambiarSplash.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarSplash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarSplash.FlatAppearance.BorderSize = 0;
            this.btnCambiarSplash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarSplash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCambiarSplash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarSplash.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarSplash.ForeColor = System.Drawing.Color.White;
            this.btnCambiarSplash.Location = new System.Drawing.Point(46, 159);
            this.btnCambiarSplash.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarSplash.Name = "btnCambiarSplash";
            this.btnCambiarSplash.Size = new System.Drawing.Size(69, 24);
            this.btnCambiarSplash.TabIndex = 0;
            this.btnCambiarSplash.Text = "Cambiar";
            this.btnCambiarSplash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarSplash.UseVisualStyleBackColor = false;
            this.btnCambiarSplash.Click += new System.EventHandler(this.btnCambiarSplash_Click);
            // 
            // picSplash
            // 
            this.picSplash.Cursor = System.Windows.Forms.Cursors.Default;
            this.picSplash.InitialImage = null;
            this.picSplash.Location = new System.Drawing.Point(18, 28);
            this.picSplash.Name = "picSplash";
            this.picSplash.Size = new System.Drawing.Size(125, 126);
            this.picSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSplash.TabIndex = 21;
            this.picSplash.TabStop = false;
            this.picSplash.MouseEnter += new System.EventHandler(this.picSplash_MouseEnter);
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
            this.btnCancelar.Location = new System.Drawing.Point(520, 481);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 30);
            this.btnCancelar.TabIndex = 2;
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
            this.btnGuardar.Location = new System.Drawing.Point(381, 481);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 30);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblCodParametro
            // 
            this.lblCodParametro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodParametro.Location = new System.Drawing.Point(37, 481);
            this.lblCodParametro.Name = "lblCodParametro";
            this.lblCodParametro.Size = new System.Drawing.Size(77, 30);
            this.lblCodParametro.TabIndex = 114;
            this.lblCodParametro.Text = "COD: 1000000000";
            // 
            // lblDescripcionParametro
            // 
            this.lblDescripcionParametro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionParametro.Location = new System.Drawing.Point(120, 481);
            this.lblDescripcionParametro.Name = "lblDescripcionParametro";
            this.lblDescripcionParametro.Size = new System.Drawing.Size(251, 45);
            this.lblDescripcionParametro.TabIndex = 115;
            this.lblDescripcionParametro.Text = "Descripción del parámetro";
            // 
            // errorProvParamSis
            // 
            this.errorProvParamSis.ContainerControl = this;
            // 
            // errorProvParamFis
            // 
            this.errorProvParamFis.ContainerControl = this;
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 537);
            this.Controls.Add(this.lblDescripcionParametro);
            this.Controls.Add(this.lblCodParametro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabConfiguracion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNombreForm);
            this.MaximizeBox = false;
            this.Name = "FormConfiguracion";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            this.tabConfiguracion.ResumeLayout(false);
            this.tabPagEmail.ResumeLayout(false);
            this.grbConfiguracionMensajes.ResumeLayout(false);
            this.grbConfiguracionMensajes.PerformLayout();
            this.grbCredencialesSistema.ResumeLayout(false);
            this.grbCredencialesSistema.PerformLayout();
            this.grbServidorCorreo.ResumeLayout(false);
            this.grbServidorCorreo.PerformLayout();
            this.tabPagFiscal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametrosFiscales)).EndInit();
            this.tabPagComprobante.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPagUsuario.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPagBaseDeDatos.ResumeLayout(false);
            this.grbBackupRestore.ResumeLayout(false);
            this.grbBackupRestore.PerformLayout();
            this.tabPagDiseno.ResumeLayout(false);
            this.grbLogo.ResumeLayout(false);
            this.grbLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grbImagenLogin.ResumeLayout(false);
            this.grbImagenLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenLogin)).EndInit();
            this.grbSplash.ResumeLayout(false);
            this.grbSplash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvParamSis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvParamFis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroTabControl tabConfiguracion;
        private MetroFramework.Controls.MetroTabPage tabPagEmail;
        private MetroFramework.Controls.MetroTabPage tabPagDiseno;
        private MetroFramework.Controls.MetroTabPage tabPagBaseDeDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtMailServer;
        private MetroFramework.Controls.MetroLabel lblMailServer;
        private System.Windows.Forms.GroupBox grbServidorCorreo;
        private MetroFramework.Controls.MetroLabel lblPort;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private System.Windows.Forms.GroupBox grbCredencialesSistema;
        private MetroFramework.Controls.MetroLabel lblContrasena;
        private MetroFramework.Controls.MetroTextBox txtContrasena;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.GroupBox grbConfiguracionMensajes;
        private MetroFramework.Controls.MetroLabel lblSubjectRegister;
        private MetroFramework.Controls.MetroTextBox txtSubjectRegister;
        private MetroFramework.Controls.MetroLabel lblDisplayNameEmail;
        private MetroFramework.Controls.MetroTextBox txtDisplayNameEmail;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel lblAddMsjRegister;
        private MetroFramework.Controls.MetroCheckBox chkSendMailPostRegister;
        private MetroFramework.Controls.MetroLabel lblAddMsjCredentials;
        private MetroFramework.Controls.MetroLabel lblSubjectCredentials;
        private MetroFramework.Controls.MetroTextBox txtSubjectCredentials;
        private MetroFramework.Controls.MetroCheckBox chkHabilitarRestore;
        private System.Windows.Forms.TextBox txtAddMsjRegister;
        private System.Windows.Forms.TextBox txtAddMsjCredentials;
        private System.Windows.Forms.GroupBox grbSplash;
        private System.Windows.Forms.GroupBox grbLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grbImagenLogin;
        private System.Windows.Forms.PictureBox picImagenLogin;
        private System.Windows.Forms.PictureBox picSplash;
        private System.Windows.Forms.GroupBox grbBackupRestore;
        private System.Windows.Forms.Button btnCambiarLogo;
        private System.Windows.Forms.Button btnCambiarImagenLogin;
        private System.Windows.Forms.Button btnCambiarSplash;
        private System.Windows.Forms.Label lblCodParametro;
        private System.Windows.Forms.Label lblDescripcionParametro;
        private System.Windows.Forms.ErrorProvider errorProvParamSis;
        private System.Windows.Forms.Label lblPathLogo;
        private System.Windows.Forms.Label lblPathLoginImg;
        private System.Windows.Forms.Label lblPathSplash;
        private MetroFramework.Controls.MetroTabPage tabPagFiscal;
        private MetroFramework.Controls.MetroTabPage tabPagComprobante;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroCheckBox chkAuthReimprComp;
        private MetroFramework.Controls.MetroCheckBox chkAuthAnularComp;
        private System.Windows.Forms.DataGridView dgvParametrosFiscales;
        private System.Windows.Forms.Button btnAddParametroFiscal;
        private MetroFramework.Controls.MetroTextBox txtValorDefParamFis;
        private MetroFramework.Controls.MetroTextBox txtDescParamFis;
        private MetroFramework.Controls.MetroTextBox txtCodParamFis;
        private System.Windows.Forms.ErrorProvider errorProvParamFis;
        private System.Windows.Forms.Button btnRemoveParamFis;
        private MetroFramework.Controls.MetroTabPage tabPagUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroCheckBox chkCreateUserAfterRegisterEmployee;
    }
}