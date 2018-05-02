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
using ConfigBusinessLogic.Persona;
using ConfigBusinessLogic.Utiles;
using ConfigUtilitarios.HelperControl;

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

        private bool EsFechaValida(DateTime hoy, DateTime? fechaIngreso, DateTime? fechaCese)
        {
            var success = false;

            if (fechaIngreso == null && fechaCese == null)
            {
                success = true;
            }
            else if (fechaIngreso == null && fechaCese != null && hoy <= ((DateTime)fechaCese).Date)
            {
                success = true;
            }
            else if (fechaIngreso != null && fechaCese == null && hoy >= ((DateTime)fechaIngreso).Date)
            {
                success = true;
            }
            else if (fechaIngreso != null && fechaCese != null && 
                hoy >= ((DateTime)fechaIngreso).Date && hoy <= ((DateTime)fechaCese).Date)
            {
                success = true;
            }

            return success;
        }

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
                        else
                        {
                            var empleado = new EmpleadoBL().EmpleadoXId(usuarioIn.id_empleado);
                            var hoy = UtilBL.GetCurrentDateTime.Date;

                            if (EsFechaValida(hoy, empleado.fecha_ingreso, empleado.fecha_cese))
                            {
                                backWorkerLogin.RunWorkerAsync();

                                usuarioLogin = new PERt01_usuario();
                                usuarioLogin = usuarioIn;
                                result = true;
                                Hide();
                                Close();
                            }
                            else
                            {
                                Msg.Ok_Wng("No puede ingresar al sistema porque está fuera de la fecha de ingreso y cese de empleado.");
                                btnCancelar.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("La cuenta del usuario está deshabilitada.\nPara mayor información contacte al administrador. ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(" La clave o username es incorrecta ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
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
            var parametroImg = new ParametroBL().ParametroXCod(ParameterCode.LogoImg);
            Parameter.CargarParametroImg(parametroImg, picLogo, ParameterCode.LogoImg);
        }

        private void AsignarImagenLogin()
        {

            var parametroImg = new ParametroBL().ParametroXCod(ParameterCode.LoginImg);
            Parameter.CargarParametroImg(parametroImg, picUserLogin, ParameterCode.LoginImg);

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
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picUserLogin.SizeMode = PictureBoxSizeMode.StretchImage;
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
            Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
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
