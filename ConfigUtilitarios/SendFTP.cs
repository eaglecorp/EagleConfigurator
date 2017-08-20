using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace ConfigUtilitarios
{
    public class SendFTP
    {
        public bool SendFileFTP(string Server, string User, string Password, string PathOrigen, string PathDestino, string FileNameExt,bool ftpSsl)
        {
            bool _result = false;
            Log oLog = new Log();

            try
            {
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(Server + PathDestino + "/" + FileNameExt);

                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(User, Password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;

                if (Convert.ToBoolean(ftpSsl))
                {
                    request.UsePassive = true;
                    request.EnableSsl = true;
                    ServicePointManager.ServerCertificateValidationCallback = AcceptAllCertificatePolicy;
                }
                else
                {
                    request.UsePassive = false;
                    request.EnableSsl = false;
                }

                FileStream stream = File.OpenRead(PathOrigen + FileNameExt);

                byte[] buffer = new byte[stream.Length];
                stream.Read(buffer, 0, buffer.Length);
                stream.Close();

                Stream reqStream = request.GetRequestStream();
                reqStream.Write(buffer, 0, buffer.Length);
                reqStream.Flush();
                reqStream.Close();

                _result = true;
            }
            catch (Exception Ex)
            {
                oLog.ArchiveLog("Utilitarios: Send File FTP : ", Ex.Message.ToString());
                _result = false;
            }
            return _result;
        }



        private bool AcceptAllCertificatePolicy(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
