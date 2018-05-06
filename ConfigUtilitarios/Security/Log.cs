using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using ConfigUtilitarios.HelperDatabase;

namespace ConfigUtilitarios
{
    public class Log
    {
        public void ArchiveLog(string strModulo, string strMensaje)
        {
            string strPath = FilePath.LogPath;
            string strPathLog = strPath + @"\Eagle_Log.log";

            using (StreamWriter sw = new StreamWriter(strPathLog, true, Encoding.Default))
            {
                try
                {
                    var hoy = HelperServer.GetCurrentDateTime();
                    StringBuilder str = new StringBuilder();
                    str.Append(hoy.ToShortDateString() + " " + hoy.ToShortTimeString() + " || " + strModulo + " --> " + strMensaje);
                    sw.WriteLine(str);
                    str.AppendLine();
                    sw.Close();
                }
                catch
                {
                    sw.Close();
                }
            }
        }
    }
}
