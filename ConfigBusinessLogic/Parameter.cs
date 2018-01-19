using ConfigBusinessEntity;
using ConfigBusinessLogic.General;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigBusinessLogic
{
    public class Parameter
    {

        #region Parámetros Utiles(Extras sin cod)
        public static string BlankRegister = "0";
        public static int LenghtPassMin { get; } = 7;
        public static int LenghtPassMed { get; } = 13;
        public static int LenghtPassMax { get; } = 20;
        #endregion

        #region Parámetros de Email
        public static string EmailFrom
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.EmailFrom);
                    string emailFrom = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                    return emailFrom;
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }
        public static string DisplayNameEmail
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.DisplayNameEmail);
                    string displayNameEmail = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                    return displayNameEmail;
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }
        public static string Password
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.Password);
                    string password = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                    return password;
                }
                catch (Exception)
                {

                    return "";
                }

            }
        }
        public static string SubjectRegister
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.SubjectRegister);
                    string subjectRegister = (p != null && p.id_parametro > 0) ? p.txt_valor : "Registro de usuario - EagleConfig";
                    return subjectRegister;
                }
                catch (Exception)
                {

                    return "";
                }
            }
        }
        public static string SubjectCredentials
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.SubjectCredentials);
                    string subjectCredentials = (p != null && p.id_parametro > 0) ? p.txt_valor : "Envío de credenciales - EagleConfig";
                    return subjectCredentials;
                }
                catch (Exception)
                {

                    return "";
                }
            }
        }
        public static string MailServer
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.MailServer);
                    string subjectCredentials = (p != null && p.id_parametro > 0) ? p.txt_valor : "smtp.gmail.com";
                    return subjectCredentials;
                }
                catch (Exception)
                {

                    return "";
                }
            }
        }
        public static int Port
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.Port);
                    int port = (p != null && p.id_parametro > 0) ? (int)p.dec_valor : 587;
                    return port;
                }
                catch (Exception)
                {

                    return 0;
                }
            }
        }
        public static string AddMsjRegister
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.AddMsjRegister);
                    string additionalMsj = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                    return additionalMsj;
                }
                catch (Exception)
                {

                    return "";
                }
            }
        }
        public static string AddMsjCredentials
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.AddMsjCredentials);
                    string additionalMsj = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                    return additionalMsj;
                }
                catch (Exception)
                {

                    return "";
                }
            }
        }
        public static int SendMailRegister
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.SendMailRegister);
                    int sendMailRegister = (p != null && p.id_parametro > 0) ? (int)p.dec_valor : 0;
                    return sendMailRegister;
                }
                catch (Exception)
                {

                    return 0;
                }
            }
        }

        #endregion

        #region Parámetros de Imágenes
        public static string SplashImg { get; } = "splash.jpg";
        public static string LogoImg { get; } = "logo.jpg";
        public static string LoginImg { get; } = "login.jpg";

        #endregion

        #region Parámetros de botones

        public static int EnableRestore
        {
            get
            {
                try
                {
                    var p = new ParametroBL().ParametroXCod(ParameterCode.EnableRestore);
                    int enableRestore = (p != null && p.id_parametro > 0) ? (int)p.dec_valor : 0;
                    return enableRestore;
                }
                catch (Exception)
                {
                    return 0;
                }
            }
        }

        #endregion

        #region Métodos

        public static void CargarParametroImg(GRLt01_parametro parametroImg, PictureBox picTarget, string codDefault)
        {
            bool intentarCargarImgDefault = true;

            if (parametroImg != null && parametroImg.id_parametro > 0 &&
                !string.IsNullOrEmpty(parametroImg.txt_valor))
            {
                string fullpath = parametroImg.txt_valor;
                if (File.Exists(fullpath))
                {
                    try
                    {
                        picTarget.Image = new Bitmap(fullpath);
                        intentarCargarImgDefault = false;
                    }
                    catch
                    {
                        //MessageBox.Show($"No se pudo cargar la imagen ({parametroImg.txt_desc}). Se cargará la imagen por defecto. Parámetro: {parametroImg.cod_parametro}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //MessageBox.Show($"La ruta de la imagen ({parametroImg.txt_desc}) no existe. Se cargará la imagen por defecto. Parámetro: {parametroImg.cod_parametro}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (intentarCargarImgDefault)
            {
                try
                {
                    picTarget.Image = new Bitmap(Path.Combine
                          (FilePath.DefaultImages, ParameterCode.GetImgDefaultNameByCod(codDefault)));
                }
                catch
                {
                    MessageBox.Show($"La imagen por defecto no existe o la ruta es incorrecta. Parámetro: {codDefault}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void CargarParametroImg(string fullPath, PictureBox picTarget, string codDefault)
        {
            bool intentarCargarImgDefault = true;

            if (!string.IsNullOrEmpty(fullPath))
            {
                if (File.Exists(fullPath))
                {
                    try
                    {
                        picTarget.Image = new Bitmap(fullPath);
                        intentarCargarImgDefault = false;
                    }
                    catch
                    {
                        //MessageBox.Show($"No se pudo cargar la imagen. Se cargará la imagen por defecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //MessageBox.Show($"La ruta de la imagen no existe. Se cargará la imagen por defecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (intentarCargarImgDefault)
            {
                try
                {
                    picTarget.Image = new Bitmap(Path.Combine
                          (FilePath.DefaultImages, ParameterCode.GetImgDefaultNameByCod(codDefault)));
                }
                catch
                {
                    MessageBox.Show($"La imagen por defecto no existe o la ruta es incorrecta. Parámetro: {codDefault}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }

    public class ParameterCode
    {

        #region Parámetros de Email
        public static string EmailFrom { get; }          = "100000";
        public static string DisplayNameEmail { get; }   = "100001";
        public static string Password { get; }           = "100002";
        public static string SubjectRegister { get; }    = "100003";
        public static string SubjectCredentials { get; } = "100004";
        public static string MailServer { get; }         = "100005";
        public static string Port { get; }               = "100006";
        public static string AddMsjRegister { get; }     = "100007";
        public static string AddMsjCredentials { get; }  = "100008";
        public static string SendMailRegister { get; }   = "100009";
        #endregion

        #region Parámetros de Imágenes
        public static string SplashImg { get; }          = "200000";
        public static string LogoImg { get; }            = "200001";
        public static string LoginImg { get; }           = "200002";
        #endregion

        #region Parámetros de botones

        public static string EnableRestore { get; } = "300000";

        #endregion

        #region Comprobante

        public static string AuthAnularComp { get; }      = "400000";
        public static string AuthReimpresionComp { get; } = "400001";

        #endregion

        public static List<string> ListaCodigosFijos()
        {
            var listaCodigos = new List<string>();

            var objParameterCode = new ParameterCode();
            var properties = GetProperties(objParameterCode);

            foreach (var p in properties)
            {
                //string name = p.Name;
                var value = p.GetValue(objParameterCode, null);
                listaCodigos.Add(value.ToString());
            }

            return listaCodigos;
        }
        private static PropertyInfo[] GetProperties(object obj)
        {
            return obj.GetType().GetProperties();
        }
        public static string GetImgDefaultNameByCod(string cod)
        {
            if (cod == LoginImg)
            {
                return Parameter.LoginImg;
            }
            if (cod == LogoImg)
            {
                return Parameter.LogoImg;
            }
            if (cod == SplashImg)
            {
                return Parameter.SplashImg;
            }
            return "";
        }



    }
}
