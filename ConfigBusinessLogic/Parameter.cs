using ConfigBusinessLogic.General;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
                var p = new ParametroBL().ParametroXCod(ParameterCode.EmailFrom);
                string emailFrom = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                return emailFrom;
            }
        }
        public static string DisplayNameEmail
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.DisplayNameEmail);
                string displayNameEmail = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                return displayNameEmail;
            }
        }
        public static string Password
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.Password);
                string password = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                return password;

            }
        }
        public static string SubjectRegister
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.SubjectRegister);
                string subjectRegister = (p != null && p.id_parametro > 0) ? p.txt_valor : "Registro de usuario - EagleConfig";
                return subjectRegister;
            }
        }
        public static string SubjectCredentials
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.SubjectCredentials);
                string subjectCredentials = (p != null && p.id_parametro > 0) ? p.txt_valor : "Envío de credenciales - EagleConfig";
                return subjectCredentials;
            }
        }
        public static string MailServer
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.MailServer);
                string subjectCredentials = (p != null && p.id_parametro > 0) ? p.txt_valor : "smtp.gmail.com";
                return subjectCredentials;
            }
        }
        public static int Port
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.Port);
                int port = (p != null && p.id_parametro > 0) ? (int)p.dec_valor : 587;
                return port;
            }
        }
        public static string AddMsjRegister
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.AddMsjRegister);
                string additionalMsj = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                return additionalMsj;
            }
        }
        public static string AddMsjCredentials
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.AddMsjCredentials);
                string additionalMsj = (p != null && p.id_parametro > 0) ? p.txt_valor : "";
                return additionalMsj;
            }
        }
        public static string SendMailRegister
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.SendMailRegister);
                string sendMailRegister = (p != null && p.id_parametro > 0) ? p.txt_valor.Trim().ToLower() : "";
                return sendMailRegister;
            }
        }

        #endregion

        #region Parámetros de Imágenes
        public static string SplashImg { get; } = "splash.jpg";
        public static string LogoImg { get; } = "logo.jpg";
        public static string LoginImg { get; } = "login.jpg";
        #endregion

        #region Parámetros de botones

        public static string EnableRestore
        {
            get
            {
                var p = new ParametroBL().ParametroXCod(ParameterCode.EnableRestore);
                string enableRestore = (p != null && p.id_parametro > 0) ? p.txt_valor.Trim().ToLower() : "";
                return enableRestore;
            }
        }

        #endregion
    }

    public class ParameterCode
    {

        #region Parámetros de Email
        public static string EmailFrom { get; } = "100000";
        public static string DisplayNameEmail { get; } = "100001";
        public static string Password { get; } = "100002";
        public static string SubjectRegister { get; } = "100003";
        public static string SubjectCredentials { get; } = "100004";
        public static string MailServer { get; } = "100005";
        public static string Port { get; } = "100006";
        public static string AddMsjRegister { get; } = "100007";
        public static string AddMsjCredentials { get; } = "100008";
        public static string SendMailRegister { get; } = "100009";
        #endregion

        #region Parámetros de Imágenes
        public static string SplashImg { get; } = "200000";
        public static string LogoImg { get; } = "200001";
        public static string LoginImg { get; } = "200002";
        #endregion

        #region Parámetros de botones

        public static string EnableRestore { get; } = "300000";

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


    }
}
