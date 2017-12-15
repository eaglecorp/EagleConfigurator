using MetroFramework.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using ConfigBusinessEntity;
using ConfigBusinessLogic.Seguridad;
using ConfigUtilitarios;
using ConfigBusinessLogic.General;
using System.IO;
using System.ServiceProcess;
using ConfigBusinessLogic;

namespace ConfiguradorUI.Seguridad
{
    public partial class FormLogin : MetroForm
    {
        #region Variables globales

        public bool result = false;
        public PERt01_usuario usuarioLogin = null;
        public bool dbRunning = false;

        #endregion

        public FormLogin()
        {
            InitializeComponent();
            txtUsuario.Focus();
        }

        #region Métodos de ventana

        private void ValidarUsuario()
        {
            try
            {
                var usuarioIn = new UsuarioBL().ValidarUsuario(txtUsuario.Text, txtClave.Text);

                if ((usuarioIn != null && usuarioIn.id_empleado > 0))
                {
                    if ((usuarioIn.id_estado == Estado.IdActivo))
                    {
                        if (usuarioIn.sn_upd_requered == Estado.IdActivo)
                        {
                            FormCambiarClave oForm = new FormCambiarClave(usuarioIn);
                            oForm.ShowDialog();
                        }
                        else if (usuarioIn.sn_upd_requered == Estado.IdInactivo)
                        {
                            backWorkerLogin.RunWorkerAsync();

                            usuarioLogin = new PERt01_usuario();
                            usuarioLogin = usuarioIn;
                            result = true;
                            Hide();
                            Close();
                        }
                    }
                    else
                    {
                        txtUsuario.Focus();
                        MessageBox.Show("La cuenta del usuario está deshabilitada.\nPara mayor información contacte al administrador. ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    txtUsuario.Focus();
                    MessageBox.Show(" La clave o username es incorrecta ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e)
            {
                result = false;
                MessageBox.Show($" Ocurrió una excepción:{ e.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AsignarImagenLogo()
        {
            bool errorDefault = false;
            try
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.LogoImg);

                if (p != null && p.id_parametro > 0 && !string.IsNullOrEmpty(p.txt_valor) && File.Exists(@p.txt_valor))
                {
                    string fullpath = @p.txt_valor;
                    try
                    {
                        picLogo.Image = new Bitmap(fullpath);
                    }
                    catch
                    {
                        MessageBox.Show($"Excepción al momento de cargar la imagen del logo sugerido. Parámetro: {ParameterCode.LogoImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        try
                        {
                            picLogo.Image = new Bitmap(Path.Combine
                                  (FilePath.FotoDefault, Parameter.LogoImg));
                        }
                        catch
                        {
                            MessageBox.Show($"El logo por defecto no existe o la ruta es incorrecta. Parámetro: {ParameterCode.LogoImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    errorDefault = true;
                    picLogo.Image = new Bitmap(Path.Combine(FilePath.FotoDefault, Parameter.LogoImg));
                }
            }
            catch (Exception e)
            {
                if (errorDefault)
                    MessageBox.Show($"El logo por defecto no existe o la ruta es incorrecta. Parámetro: {ParameterCode.LogoImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show($"Ocurrió un error no identificado. ERROR:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AsignarImagenLogin()
        {
            bool errorDefault = false;
            try
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.LoginImg);

                if (p != null && p.id_parametro > 0 && !string.IsNullOrEmpty(p.txt_valor) && File.Exists(@p.txt_valor))
                {
                    string fullpath = @p.txt_valor;
                    try
                    {
                        picUserLogin.Image = new Bitmap(fullpath);
                    }
                    catch
                    {
                        MessageBox.Show($"Excepción al momento de cargar la imagen del logo sugerido. Parámetro: {ParameterCode.LoginImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        try
                        {
                            picUserLogin.Image = new Bitmap(Path.Combine
                                  (FilePath.FotoDefault, Parameter.LoginImg));
                        }
                        catch
                        {
                            MessageBox.Show($"El login por defecto no existe o la ruta es incorrecta. Parámetro: {ParameterCode.LoginImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    errorDefault = true;
                    picUserLogin.Image = new Bitmap(Path.Combine(FilePath.FotoDefault, Parameter.LoginImg));
                }
            }
            catch (Exception e)
            {
                if (errorDefault)
                    MessageBox.Show($"El login por defecto no existe o la ruta es incorrecta. Parámetro: {ParameterCode.LoginImg}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show($"Ocurrió un error no identificado. ERROR:" + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AsignarImagenStatus()
        {
            var ttStatus = new ToolTip();
            ttStatus.AutoPopDelay = 5000;
            ttStatus.InitialDelay = 0;
            ttStatus.ReshowDelay = 500;
            ttStatus.ShowAlways = true;
            try
            {
                //if (dbRunning)
                //{
                picStatus.Image = Properties.Resources.database_on;
                ttStatus.SetToolTip(picStatus, "La base de datos está lista.");
                //}

                //else
                //{
                //    picStatus.Image = Properties.Resources.database_off;
                //    ttStatus.SetToolTip(picStatus, "La base de datos no está disponible.");
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show("No se encontró la imagen que grafica el estado de la base de datos. Exception: " + e.Message);
            }
        }

        private void SetMaxLengthTxt()
        {
            txtClave.UseSystemPasswordChar = true;
            txtUsuario.MaxLength = 20;
            txtClave.MaxLength = Parameter.LenghtPassMax;
        }

        public static ServiceControllerStatus StatusServices(string nombreServicio)
        {
            ServiceController sc = new ServiceController(nombreServicio);
            sc.Refresh();
            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    { return ServiceControllerStatus.Running; }

                case ServiceControllerStatus.Stopped:
                    { return ServiceControllerStatus.Stopped; }

                case ServiceControllerStatus.Paused:
                    { return ServiceControllerStatus.Paused; }

                case ServiceControllerStatus.StopPending:
                    { return ServiceControllerStatus.StopPending; }

                case ServiceControllerStatus.StartPending:
                    { return ServiceControllerStatus.StartPending; }

                case ServiceControllerStatus.PausePending:
                    { return ServiceControllerStatus.PausePending; }

                case ServiceControllerStatus.ContinuePending:
                    { return ServiceControllerStatus.ContinuePending; }
                //preguntar
                default:
                    { return ServiceControllerStatus.ContinuePending; }
            }
        }

        private void ComprobarStatusDb()
        {
            if (StatusServices("MSSQL$SQLEXPRESS2014") == ServiceControllerStatus.Running)
            { dbRunning = true; }
            else { dbRunning = false; }
        }

        private void ConfigurarInicio()
        {
            SetMaxLengthTxt();
            AsignarImagenLogo();
            AsignarImagenLogin();
            //ComprobarStatusDb();
            AsignarImagenStatus();
            txtUsuario.Focus();
        }

        public void RunContext()
        {
            try
            {
                new ConfigBusinessLogic.Utiles.UtilBL().RunContext();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Ocurrió una excepción al abrir el contexto: " + exc.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Eventos de ventana

        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                if (Connection.ConnectionTest())
                {
                    ConfigurarInicio();
                }
                else
                {
                    var frm = new FormConnection();
                    frm.ShowDialog();
                    if (!frm.isRight)
                    {
                        result = false;
                        Hide();
                        Close();
                    }
                    else
                    {
                        ConfigurarInicio();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("error en el load del login. " + exc.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            result = false;
            //Hide();
            Close();
            //Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //if (dbRunning)
            ValidarUsuario();
            //else
            //    MessageBox.Show("La base de datos no está disponible en estos momentos.\nContáctese con el administrador.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void linkOlvideCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarCuenta oForm = new FormRecuperarCuenta();
            oForm.ShowDialog();
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
              ValidarUsuario();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                ValidarUsuario();
            }
        }

        private void backWorkerLogin_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            RunContext();
        }

        private void backWorkerLogin_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
        }
        #endregion

    }
}
