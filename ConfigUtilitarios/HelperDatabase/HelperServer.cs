using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios.HelperDatabase
{
    public static class HelperServer
    {
        public static DateTime GetCurrentDateTime()
        {
            DateTime ahora = DateTime.Now;
            using (var conexion = new SqlConnection(Connection.GetAppConnectionString()))
            {
                try
                {
                    using (var cmd = new SqlCommand("USP_SYS_CURRENT_DATE", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        conexion.Open();
                        ahora = DateTime.Parse(cmd.ExecuteScalar().ToString());
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("GetCurrentDateTime: ", e.Message);
                }
            }
            return ahora;
        }
    }
}
