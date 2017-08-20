using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigUtilitarios
{
    public class FilePath
    {

        public static string BackupPath
        {
            get
            {
                string strPath = "";
                try
                {
                    strPath = Application.StartupPath + @"\Backup";
                    if (!Directory.Exists(strPath))
                    {
                        Directory.CreateDirectory(strPath);
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Backup Path: Utilitarios. ", e.Message);
                }
                return strPath;
            }
        }

        public static string LogPath
        {
            get
            {
                string strPath = "";
                try
                {
                    strPath = Application.StartupPath + @"\Log";
                    if (!Directory.Exists(strPath))
                    {
                        Directory.CreateDirectory(strPath);
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Log Path: Utilitarios. ", e.Message);
                }
                return strPath;
            }
        }

        public static string FotoDefault { get; } = Application.StartupPath+ @"\FotosDefault";



    }
}
