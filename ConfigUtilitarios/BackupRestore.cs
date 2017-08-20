using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios
{
    public class BackupRestore
    {
        public static bool Backup(string cnString, string dbName, string path)
        {
            bool success = false;
            using (var cn = new SqlConnection(cnString))
            {
                try
                {
                    string backupName = string.Format("{0} {1}.bak", dbName, DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss-fff"));

                    string sentence = $"BACKUP DATABASE {dbName} TO DISK = '{path}\\{backupName}'";
                    cn.Open();
                    using (var cmd = new SqlCommand(sentence, cn))
                    {
                        cmd.ExecuteNonQuery();
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Backup: Utilitarios: ", e.Message);
                }
            }
            return success;
        }

        public static  bool Restore(string cnString, string dbName, string pathFile)
        {
            bool success = false;
            using (var cn = new SqlConnection(cnString))
            {
                try
                {
                    cn.Open();
                    string masterSentece = "USE master";
                    string sentence = $@"ALTER DATABASE {dbName} SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                        RESTORE DATABASE {dbName} FROM DISK = '{pathFile}' WITH REPLACE;";
                    using (var cmdMaster = new SqlCommand(masterSentece, cn))
                    {
                        cmdMaster.ExecuteNonQuery();
                        using (var cmd = new SqlCommand(sentence, cn))
                        {
                            cmd.ExecuteNonQuery();
                            success = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Restore: Utilitarios: ", e.Message);
                }
            }
            return success;
        }


    }
}
