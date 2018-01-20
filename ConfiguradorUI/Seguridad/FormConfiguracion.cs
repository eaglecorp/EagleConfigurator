using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigUtilitarios;
using ConfigBusinessEntity;
using MetroFramework.Controls;
using ConfigBusinessLogic.General;
using ConfigBusinessLogic;
using System.IO;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.HelperGeneric;
using ConfigBusinessLogic.Fiscal;
using ConfigUtilitarios.ViewModels;

namespace ConfiguradorUI.Seguridad
{
    public partial class FormConfiguracion : MetroForm
    {

        #region Variables

        List<GRLt01_parametro> _parametrosSistema = null;
        List<int> _idsParametrosFiscalesCambiados = null;
        public bool changedLogo = false;

        const int colIdParametroFiscal = 0;
        const int colCodParametroFiscal = 1;
        const int colNombreParametroFiscal = 2;
        const int colValorDefault = 3;

        enum ResultadoOperacion
        {
            Fail,
            Success,
            NoAction
        };

        bool postLoad = false;
        #endregion

        public FormConfiguracion()
        {
            InitializeComponent();
        }

        #region Métodos de ventana

        private void SetParametrosSistema()
        {
            try
            {
                #region Identificando los parámetros

                var mailServer = GetParametro(ParameterCode.MailServer);
                var port = GetParametro(ParameterCode.Port);
                var email = GetParametro(ParameterCode.EmailFrom);
                var contrasena = GetParametro(ParameterCode.Password);
                var displayNameEmail = GetParametro(ParameterCode.DisplayNameEmail);
                var subjectRegister = GetParametro(ParameterCode.SubjectRegister);
                var addMsjRegister = GetParametro(ParameterCode.AddMsjRegister);
                var sendMailPostRegister = GetParametro(ParameterCode.SendMailRegister);
                var subjectCredentials = GetParametro(ParameterCode.SubjectCredentials);
                var addMsjCredentials = GetParametro(ParameterCode.AddMsjCredentials);

                var splash = GetParametro(ParameterCode.SplashImg);
                var loginImg = GetParametro(ParameterCode.LoginImg);
                var logo = GetParametro(ParameterCode.LogoImg);

                var enableRestore = GetParametro(ParameterCode.EnableRestore);

                var authAnularComp = GetParametro(ParameterCode.AuthAnularComp);
                var authReimprComp = GetParametro(ParameterCode.AuthReimpresionComp);

                #endregion

                SetParametrosFiscales(new ParametroFiscalBL().ListaParametroFiscal());

                #region Seteando los parámetros

                txtMailServer.Text = mailServer.txt_valor;
                txtPort.Text = port.dec_valor.RemoveTrailingZeros();

                txtEmail.Text = email.txt_valor;
                txtContrasena.Text = new Encription().Decryption(contrasena.txt_valor);
                txtDisplayNameEmail.Text = displayNameEmail.txt_valor;

                txtSubjectRegister.Text = subjectRegister.txt_valor;
                txtAddMsjRegister.Text = addMsjRegister.txt_valor;
                chkSendMailPostRegister.Checked = sendMailPostRegister.dec_valor != null &&
                                                    (int)sendMailPostRegister.dec_valor == Estado.IdActivo;

                txtSubjectCredentials.Text = subjectCredentials.txt_valor;
                txtAddMsjCredentials.Text = addMsjCredentials.txt_valor;

                chkHabilitarRestore.Checked = enableRestore.dec_valor != null &&
                                    (int)enableRestore.dec_valor == Estado.IdActivo;

                chkAuthAnularComp.Checked = authAnularComp.dec_valor != null &&
                    (int)authAnularComp.dec_valor == Estado.IdActivo;

                chkAuthReimprComp.Checked = authReimprComp.dec_valor != null &&
                    (int)authReimprComp.dec_valor == Estado.IdActivo;

                Parameter.CargarParametroImg(splash, picSplash, ParameterCode.SplashImg);
                lblPathSplash.Text = splash.txt_valor;
                Parameter.CargarParametroImg(loginImg, picImagenLogin, ParameterCode.LoginImg);
                lblPathLoginImg.Text = loginImg.txt_valor;
                Parameter.CargarParametroImg(logo, picLogo, ParameterCode.LogoImg);
                lblPathLogo.Text = logo.txt_valor;

                #endregion
            }
            catch (Exception e)
            {
                Msg.Ok_Err("Ocurrió un error cuando se mostraba los parámetros. Excepción:" + e.Message);
            }
        }
        private List<GRLt01_parametro> GetParametrosSistemaCambiados()
        {
            if (_parametrosSistema == null || _parametrosSistema.Count == 0)
                return null;

            var parametrosCambiados = new List<GRLt01_parametro>();

            var mailServer = GetParametro(ParameterCode.MailServer);
            var port = GetParametro(ParameterCode.Port);
            var email = GetParametro(ParameterCode.EmailFrom);
            var contrasena = GetParametro(ParameterCode.Password);
            var displayNameEmail = GetParametro(ParameterCode.DisplayNameEmail);
            var subjectRegister = GetParametro(ParameterCode.SubjectRegister);
            var addMsjRegister = GetParametro(ParameterCode.AddMsjRegister);
            var sendMailPostRegister = GetParametro(ParameterCode.SendMailRegister);
            var subjectCredentials = GetParametro(ParameterCode.SubjectCredentials);
            var addMsjCredentials = GetParametro(ParameterCode.AddMsjCredentials);

            var splash = GetParametro(ParameterCode.SplashImg);
            var loginImg = GetParametro(ParameterCode.LoginImg);
            var logo = GetParametro(ParameterCode.LogoImg);

            var enableRestore = GetParametro(ParameterCode.EnableRestore);

            var authAnularComp = GetParametro(ParameterCode.AuthAnularComp);
            var authReimprComp = GetParametro(ParameterCode.AuthReimpresionComp);

            TryAddParameterFromMetroTxt(mailServer, txtMailServer);

            int.TryParse(txtPort.Text.Trim(), out int valuePort);
            if (port != null && port.id_parametro > 0 && port.dec_valor != valuePort)
            {
                port.dec_valor = valuePort;
                parametrosCambiados.Add(port);
            }

            TryAddParameterFromMetroTxt(email, txtEmail);

            string valueContrasena = txtContrasena.Text;
            if (contrasena != null && contrasena.id_parametro > 0 && new Encription().Decryption(contrasena.txt_valor) != valueContrasena)
            {
                contrasena.txt_valor = new Encription().Encryption(valueContrasena);
                parametrosCambiados.Add(contrasena);
            }

            TryAddParameterFromMetroTxt(displayNameEmail, txtDisplayNameEmail);
            TryAddParameterFromMetroTxt(subjectRegister, txtSubjectRegister);
            TryAddParameterFromTxt(addMsjRegister, txtAddMsjRegister);

            TryAddParameterFromChk(sendMailPostRegister, chkSendMailPostRegister);

            TryAddParameterFromMetroTxt(subjectCredentials, txtSubjectCredentials);
            TryAddParameterFromTxt(addMsjCredentials, txtAddMsjCredentials);

            TryAddParameterFromLbl(splash, lblPathSplash);
            TryAddParameterFromLbl(loginImg, lblPathLoginImg);
            TryAddParameterFromLbl(logo, lblPathLogo);

            TryAddParameterFromChk(enableRestore, chkHabilitarRestore);

            TryAddParameterFromChk(authAnularComp, chkAuthAnularComp);
            TryAddParameterFromChk(authReimprComp, chkAuthReimprComp);

            #region Métodos locales
            void TryAddParameterFromMetroTxt(GRLt01_parametro parametro, MetroTextBox txtParametro)
            {
                string valueParameter = txtParametro.Text.Trim();
                if (parametro != null && parametro.id_parametro > 0 && parametro.txt_valor != valueParameter)
                {
                    parametro.txt_valor = valueParameter;
                    parametrosCambiados.Add(parametro);
                }
            }

            void TryAddParameterFromTxt(GRLt01_parametro parametro, TextBox txtParametro)
            {
                string valueParameter = txtParametro.Text.Trim();
                if (parametro != null && parametro.id_parametro > 0 && parametro.txt_valor != valueParameter)
                {
                    parametro.txt_valor = valueParameter;
                    parametrosCambiados.Add(parametro);
                }
            }

            void TryAddParameterFromLbl(GRLt01_parametro parametro, Label lblParametro)
            {
                string valueParameter = lblParametro.Text.Trim();
                if (parametro != null && parametro.id_parametro > 0 && parametro.txt_valor != valueParameter)
                {
                    parametro.txt_valor = valueParameter;
                    parametrosCambiados.Add(parametro);
                }
            }

            void TryAddParameterFromChk(GRLt01_parametro parametro, MetroCheckBox chkParametro)
            {
                int valueParameter = chkParametro.Checked ? Estado.IdActivo : Estado.IdInactivo;
                if (parametro != null && parametro.id_parametro > 0 && parametro.dec_valor != valueParameter)
                {
                    parametro.dec_valor = valueParameter;
                    parametrosCambiados.Add(parametro);
                }
            }
            #endregion

            return parametrosCambiados;
        }
        private GRLt01_parametro GetParametro(string cod)
        {
            var parametro = new GRLt01_parametro();
            if (_parametrosSistema == null || cod == null)
            { return parametro; }
            else
            {
                try
                {
                    var tempParametro = _parametrosSistema.FirstOrDefault(x => x.cod_parametro == cod);
                    if (tempParametro != null && tempParametro.id_parametro > 0)
                    {
                        parametro = new GRLt01_parametro
                        {
                            id_parametro = tempParametro.id_parametro,
                            cod_parametro = tempParametro.cod_parametro,
                            dec_valor = tempParametro.dec_valor,
                            sn_edit = tempParametro.sn_edit,
                            txt_desc = tempParametro.txt_desc,
                            txt_obs = tempParametro.txt_obs,
                            txt_valor = tempParametro.txt_valor
                        };
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo obtener el parámetro {cod}. Excepción: {ex.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            return parametro;
        }

        private ResultadoOperacion Actualizar()
        {
            var parametrosSistemaCambiados = GetParametrosSistemaCambiados();
            bool? pSistemasSuccess = null, pFiscalesSuccess = null;

            if (parametrosSistemaCambiados != null && parametrosSistemaCambiados.Count > 0)
            {
                pSistemasSuccess = new ParametroBL().ActualizarParametros(parametrosSistemaCambiados);

                if (pSistemasSuccess == true)
                {
                    changedLogo = parametrosSistemaCambiados.Any(x => x.cod_parametro == ParameterCode.LogoImg);
                }
            }

            if (_idsParametrosFiscalesCambiados != null && _idsParametrosFiscalesCambiados.Count > 0)
            {
                pFiscalesSuccess = new ParametroFiscalBL().ActualizarParametrosFiscales(GetParametrosFiscales());
            }

            return
                (pSistemasSuccess == null && pFiscalesSuccess == null) ? ResultadoOperacion.NoAction :
                (pSistemasSuccess == false || pSistemasSuccess == false) ? ResultadoOperacion.Fail :
                ResultadoOperacion.Success;
        }
        private void Guardar()
        {
            if (EsValido())
            {
                var resultadoOperacion = Actualizar();
                if (resultadoOperacion == ResultadoOperacion.Success)
                {
                    Msg.Ok_Info("Se actualizó correctamente los parámetros.");
                }
                else if (resultadoOperacion == ResultadoOperacion.Fail)
                {
                    Msg.Ok_Err("Ocurrió un error en la actualización de los parámetros.");
                }

                CargarParametros();
                LimpiarParametrosCambiados();
            }
        }

        private void AddIdParametroFiscalCambiado()
        {
            try
            {
                var idTxt = ControlHelper.DgvGetCellValueSelectedFromCell(dgvParametrosFiscales, colIdParametroFiscal);
                if (int.TryParse(idTxt, out int id))
                {
                    if (_idsParametrosFiscalesCambiados == null)
                    {
                        _idsParametrosFiscalesCambiados = new List<int>();
                    }

                    if (!_idsParametrosFiscalesCambiados.Any(x => x == id))
                    {
                        _idsParametrosFiscalesCambiados.Add(id);
                    }
                }
            }
            catch (Exception e)
            {
                Msg.Ok_Err("No se pudo agregar el ID del parámetro fiscal. Excepción: " + e.Message);
            }
        }
        private void LimpiarParametrosCambiados()
        {
            _idsParametrosFiscalesCambiados = null;
        }
        private string GuardarImageDesde(string pathSource)
        {
            if (File.Exists(pathSource))
            {
                if (Directory.Exists(FilePath.Images))
                {
                    try
                    {
                        string fileName = UtilString.GetRandomName();
                        string extension = pathSource.Substring(pathSource.LastIndexOf(@"."));
                        string pathTarget = Path.Combine(Path.GetFullPath(FilePath.Images), fileName + extension);
                        if (pathSource != pathTarget)
                            File.Copy(pathSource, pathTarget, true);
                        if (File.Exists(pathTarget))
                            return pathTarget;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("No se pudo guardar la imagen. Excepción: " + exc.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La ruta de destino no existe o ha sido modificada.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("La imagen no existe o ha sido modificada. Verifique y vuelva a intentarlo.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }
        private void CargarParametros()
        {
            _parametrosSistema = new ParametroBL().ListaParametro(true);
            var parametrosFiscales = new ParametroFiscalBL().ListaParametroFiscal();

            if ((_parametrosSistema == null || _parametrosSistema.Count == 0) && (parametrosFiscales == null || parametrosFiscales.Count == 0))
            {
                if (Msg.YesNo_Ques("No se ha encontrado ningún parámetro en la base de datos. ¿Continuar de todas formas?") == DialogResult.No)
                {
                    Close();
                }
                else
                {
                    btnGuardar.Enabled = false;
                }
            }
            else
            {
                SetParametrosSistema();
                SetParametrosFiscales(parametrosFiscales);
            }
        }
        private bool EsValido()
        {
            bool esValido = true;

            errorProv.Clear();

            #region Email
            if (txtContrasena.Text.Length == 0)
            {
                tabConfiguracion.SelectedTab = tabPagEmail;
                errorProv.SetError(txtContrasena, "Debe ingresar una contraseña.");
                txtContrasena.Focus();
                esValido = false;
            }

            if (txtEmail.Text.Trim().Length == 0 || !Validation.EsEmail(txtEmail.Text.Trim()))
            {
                tabConfiguracion.SelectedTab = tabPagEmail;
                errorProv.SetError(txtEmail, "Debe ingresar un correo electrónico.");
                txtEmail.Focus();
                esValido = false;
            }

            if (txtPort.Text.Trim().Length == 0 || !int.TryParse(txtPort.Text, out int puerto))
            {
                tabConfiguracion.SelectedTab = tabPagEmail;
                errorProv.SetError(txtPort, "Debe ingresar un puerto.");
                txtPort.Focus();
                esValido = false;
            }

            if (txtMailServer.Text.Trim().Length == 0)
            {
                tabConfiguracion.SelectedTab = tabPagEmail;
                errorProv.SetError(txtMailServer, "Debe ingresar un servidor de correo.");
                txtMailServer.Focus();
                esValido = false;
            }
            #endregion

            #region Diseno
            if (esValido)
            {
                Tuple<Label, string>[] PathsImg =
                                            {
                                                Tuple.Create(lblPathSplash, ParameterCode.SplashImg),
                                                Tuple.Create(lblPathLoginImg, ParameterCode.LoginImg),
                                                Tuple.Create(lblPathLogo, ParameterCode.LogoImg)
                                            };
                foreach (var pathWithCode in PathsImg)
                {
                    var pathSource = pathWithCode.Item1.Text.Trim();
                    var codImg = pathWithCode.Item2;

                    if (!string.IsNullOrEmpty(pathSource))
                    {
                        if (pathSource.Length <= 260)
                        {
                            //verificar si la ruta de la imagen ha cambiado
                            var parametro = GetParametro(codImg);
                            if (parametro != null && parametro.txt_valor != pathSource)
                            {
                                //si ha cambiado... entonces copiamos la imagen en la carpeta de la app (local)
                                string path = GuardarImageDesde(pathSource);
                                if (path == null)
                                {
                                    //Si no se pudo copiar
                                    errorProv.SetError(pathWithCode.Item1.Parent, "No se pudo guardar la imagen localmente.");
                                    esValido = false;
                                }
                                else
                                {
                                    //Si copió exitosamente... la ruta generada la guardamos
                                    if (!Validation.IsValidImage(path))
                                    {
                                        errorProv.SetError(pathWithCode.Item1.Parent, "El archivo debe ser una imagen.");
                                        esValido = false;
                                    }
                                    else
                                    {
                                        pathWithCode.Item1.Text = path;
                                    }
                                }
                            }
                            else if (!File.Exists(pathSource))
                            {
                                errorProv.SetError(pathWithCode.Item1.Parent, "La ruta de la imagen no existe o ha sido modificada.");
                                esValido = false;
                            }
                            else if (!Validation.IsValidImage(pathSource))
                            {
                                errorProv.SetError(pathWithCode.Item1.Parent, "El archivo debe ser una imagen.");
                                esValido = false;
                            }
                        }
                        else
                        {
                            errorProv.SetError(pathWithCode.Item1.Parent, "La ruta del archivo puede tener máximo hasta 260 de longitud.");
                            esValido = false;
                        }
                    }
                }
                if (!esValido)
                {
                    tabConfiguracion.SelectedTab = tabPagDiseno;
                }
            }
            #endregion

            return esValido;
        }

        private void CargarImg(string codImg, PictureBox picTarget, Label lblTargetPath)
        {
            var dialog = new OpenFileDialog()
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                FilterIndex = 0
            };

            try
            {
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
            catch (Exception exDirectory)
            {
                MessageBox.Show("No se puedo establecer el directorio inicial en el escritorio. Excepción: " + exDirectory.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lblTargetPath.Text = Path.GetFullPath(dialog.FileName);
                }
                catch (Exception exGetFullPath)
                {
                    MessageBox.Show("No se puedo obtener la ruta completa de la imagen. Excepción: " + exGetFullPath.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Parameter.CargarParametroImg(lblTargetPath.Text, picTarget, codImg);
            }
        }

        private void AddHandlers()
        {
            var txts = new[]
            {
                txtMailServer,
                txtPort,
                txtEmail,
                txtContrasena,
                txtDisplayNameEmail,
                txtSubjectRegister,
                txtSubjectCredentials
            };

            var chks = new[]
            {
                chkSendMailPostRegister,
                chkHabilitarRestore,
                chkAuthAnularComp,
                chkAuthReimprComp
            };

            var pics = new[]
            {
                picSplash,
                picImagenLogin,
                picLogo
            };

            foreach (var txt in txts)
            {
                txt.Leave += controlParametro_FocusLeave;
            }

            foreach (var chk in chks)
            {
                chk.MouseLeave += controlParametro_MouseLeave;
            }

            foreach (var pic in pics)
            {
                pic.MouseLeave += controlParametro_MouseLeave;
            }

            txtAddMsjRegister.Leave += controlParametro_FocusLeave;
            txtAddMsjCredentials.Leave += controlParametro_FocusLeave;
            txtPort.KeyPress += ControlHelper.TxtValidInteger;
        }
        private void LimpiarCodYDescripcionParametro()
        {
            lblCodParametro.Text = "";
            lblDescripcionParametro.Text = "";
        }
        private void SetCodYDescripcionParametro(string cod)
        {
            lblDescripcionParametro.Text = GetParametro(cod)?.txt_obs;
            lblCodParametro.Text = "Código:\n" + GetParametro(cod)?.cod_parametro;
        }
        private void SetMaxLengthTxt()
        {
            var txtsParametrosConValorTxt = new[]
            {
                txtMailServer,
                txtEmail,
                txtDisplayNameEmail,
                txtSubjectRegister,
                txtSubjectCredentials
            };

            foreach (var txt in txtsParametrosConValorTxt)
            {
                txt.MaxLength = 500;
            }
            txtContrasena.MaxLength = 50;
            txtAddMsjRegister.MaxLength = 500;
            txtAddMsjCredentials.MaxLength = 500;
            txtPort.MaxLength = 10;
        }
        private void ConfigurarControles()
        {
            #region Label
            var lblPathsImg = new[] { lblPathSplash, lblPathLoginImg, lblPathLogo };
            foreach (var lbl in lblPathsImg)
            {
                lbl.Visible = false;
                lbl.Text = "";
            }

            LimpiarCodYDescripcionParametro();
            #endregion

            #region Textbox
            SetMaxLengthTxt();
            ControlHelper.SetTextArea(txtAddMsjRegister);
            ControlHelper.SetTextArea(txtAddMsjCredentials);
            txtContrasena.UseSystemPasswordChar = true;
            #endregion

            #region Picture

            picSplash.SizeMode = PictureBoxSizeMode.StretchImage;
            picImagenLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            #endregion

            #region Dgv

            DefinirCabeceraGridParametros();
            RenombrarCabeceraGridParametros();
            ConfigurarGridParametrosFiscales();
            ((DataGridViewTextBoxColumn)dgvParametrosFiscales.Columns[colValorDefault]).MaxInputLength = 500;
            ControlHelper.DgvBaseStyle(dgvParametrosFiscales);
            ControlHelper.DgvBaseConfig(dgvParametrosFiscales);

            #endregion
        }

        private void DefinirCabeceraGridParametros()
        {
            try
            {
                var configHeader = new List<FISt04_parametro_fiscal>();
                dgvParametrosFiscales.DataSource = configHeader.Select(x => new
                ParametroFiscalVM()
                {
                    id_parametro_fiscal = 0,
                    cod_parametro_fiscal = "",
                    txt_desc = "",
                    valor_default = ""
                }).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo definir la cabecera de la grilla de los parámetros fiscales. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RenombrarCabeceraGridParametros()
        {
            try
            {
                dgvParametrosFiscales.Columns["cod_parametro_fiscal"].HeaderText = "CÓDIGO";
                dgvParametrosFiscales.Columns["txt_desc"].HeaderText = "PARÁMETRO";
                dgvParametrosFiscales.Columns["valor_default"].HeaderText = "VALOR DEFAULT";
            }
            catch (Exception e)
            {
                MessageBox.Show($"No se pudo renombrar la cabecera de la grilla de los parámetros fiscales. Excepción: {e.Message}", "Excepción encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConfigurarGridParametrosFiscales()
        {
            dgvParametrosFiscales.Columns["id_parametro_fiscal"].Visible = false;
            dgvParametrosFiscales.ReadOnly = false;
            dgvParametrosFiscales.Columns[colIdParametroFiscal].ReadOnly = true;
            dgvParametrosFiscales.Columns[colCodParametroFiscal].ReadOnly = true;
            dgvParametrosFiscales.Columns[colNombreParametroFiscal].ReadOnly = true;

            dgvParametrosFiscales.Columns["cod_parametro_fiscal"].Width = 110;
            dgvParametrosFiscales.Columns["txt_desc"].Width = 280;
            dgvParametrosFiscales.Columns["valor_default"].Width = 125;
        }
        private void SetParametrosFiscales(ICollection<FISt04_parametro_fiscal> parametrosFiscales)
        {
            try
            {
                if (parametrosFiscales != null && parametrosFiscales.Count > 0)
                {
                    dgvParametrosFiscales.DataSource = parametrosFiscales
                                                                .Select(x => new
                                                        ParametroFiscalVM()
                                                                {
                                                                    id_parametro_fiscal = x.id_parametro_fiscal,
                                                                    cod_parametro_fiscal = x.cod_parametro_fiscal,
                                                                    txt_desc = x.txt_desc,
                                                                    valor_default = x.valor_default
                                                                }).ToList();
                }
                else
                {
                    DefinirCabeceraGridParametros();
                }
                RenombrarCabeceraGridParametros();
            }
            catch (Exception ex)
            {
                Msg.Ok_Err("Ocurrió un error cuando se cargaba la configuración de parámetros fiscales. Excepción : " + ex.Message);
            }
        }
        private List<FISt04_parametro_fiscal> GetParametrosFiscales()
        {
            var parametrosFiscalesCambiados = new List<FISt04_parametro_fiscal>();

            try
            {
                if (dgvParametrosFiscales.Rows != null && dgvParametrosFiscales.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvParametrosFiscales.Rows)
                    {
                        var id_parametro_fiscal = int.Parse(row.Cells[colIdParametroFiscal].Value.ToString());

                        if (_idsParametrosFiscalesCambiados.Any(x => x == id_parametro_fiscal))
                        {
                            parametrosFiscalesCambiados.Add(
                                new FISt04_parametro_fiscal()
                                {
                                    id_parametro_fiscal = id_parametro_fiscal,
                                    cod_parametro_fiscal = row.Cells[colCodParametroFiscal].Value.ToString(),
                                    txt_desc = row.Cells[colNombreParametroFiscal].Value.ToString(),
                                    valor_default = row.Cells[colValorDefault].Value.ToString()
                                }
                               );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Msg.Ok_Err("No se pudo obtener los parámetros fiscales. Excepción: " + ex.Message);
            }
            return parametrosFiscalesCambiados;
        }


        private void ConfigurarLoad()
        {
            ConfigurarControles();
            CargarParametros();
            AddHandlers();
        }

        #endregion

        #region Eventos de ventana

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            ConfigurarLoad();
            postLoad = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnCambiarSplash_Click(object sender, EventArgs e)
        {
            CargarImg(Parameter.SplashImg, picSplash, lblPathSplash);
        }
        private void btnCambiarImagenLogin_Click(object sender, EventArgs e)
        {
            CargarImg(Parameter.LoginImg, picImagenLogin, lblPathLoginImg);
        }
        private void btnCambiarLogo_Click(object sender, EventArgs e)
        {
            CargarImg(Parameter.LogoImg, picLogo, lblPathLogo);
        }

        private void controlParametro_FocusLeave(object sender, EventArgs e)
        {
            LimpiarCodYDescripcionParametro();
        }
        private void controlParametro_MouseLeave(object sender, EventArgs e)
        {
            LimpiarCodYDescripcionParametro();
        }

        private void txtMailServer_Enter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.MailServer);
        }
        private void txtPort_Enter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.Port);
        }
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.EmailFrom);
        }
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.Password);
        }
        private void txtDisplayNameEmail_Enter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.DisplayNameEmail);
        }
        private void txtSubjectRegister_Enter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.SubjectRegister);
        }
        private void txtAddMsjRegister_Enter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.AddMsjRegister);
        }
        private void txtSubjectCredentials_Enter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.SubjectCredentials);
        }
        private void txtAddMsjCredentials_Enter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.AddMsjCredentials);
        }

        private void chkSendMailPostRegister_MouseEnter(object sender, EventArgs e)
        {
            chkSendMailPostRegister.Focus();
            SetCodYDescripcionParametro(ParameterCode.SendMailRegister);
        }
        private void chkHabilitarRestore_MouseEnter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.EnableRestore);
        }

        private void picSplash_MouseEnter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.SplashImg);
        }
        private void picImagenLogin_MouseEnter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.LoginImg);
        }
        private void picLogo_MouseEnter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.LogoImg);
        }


        private void chkAuthAnularComp_MouseEnter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.AuthAnularComp);
        }

        private void chkAuthReimprComp_MouseEnter(object sender, EventArgs e)
        {
            SetCodYDescripcionParametro(ParameterCode.AuthReimpresionComp);
        }

        private void dgvParametrosFiscales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colValorDefault && postLoad)
            {
                AddIdParametroFiscalCambiado();
            }
        }

        #endregion

    }
}
