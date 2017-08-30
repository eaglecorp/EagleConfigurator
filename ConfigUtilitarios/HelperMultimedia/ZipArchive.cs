using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Ionic.Zip;

namespace ConfigUtilitarios
{
    public class ZipArchive
    {
        public bool ZipFiles(string strPath, string strFileName, bool bDeleteFiles, string strExtension)
        {
            bool _result = false;
            ZipFile zip = new ZipFile();
            Log oLog = new Log();

            try
            {
                string strPathFileExt = strPath + strFileName + ".zip";

                zip.AddDirectory(strPath,"");
                zip.Save(strPathFileExt);
                _result = true;
                oLog.ArchiveLog("Utilitarios: Zip Files : ", "Se zippeo el archivo " + strFileName);
                if (bDeleteFiles)
                {
                    FileIO oFile = new FileIO();
                    oFile.DeleteFilesPath(strPath, strExtension);
                }
            }
            catch (Exception Ex)
            {                
                oLog.ArchiveLog("Utilitarios: Zip Files : ", Ex.Message.ToString());
            }

            return _result;
        }
    }
}
