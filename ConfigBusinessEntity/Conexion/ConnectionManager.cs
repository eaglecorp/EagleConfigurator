using ConfigUtilitarios;
using System;
using System.Configuration;

namespace ConfigBusinessEntity
{
    public class ConnectionManager
    {
        public static string GetConnectionString()
        {
            string strCn = "";
            try
            {
                strCn = Connection.GetAppConnectionString();
            }
            catch (Exception e)
            {
                var log = new Log();
                log.ArchiveLog("Entity. Get Connection String: ", e.Message);
            }
            return strCn;
        }
    }
}
