using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios
{
    public class Connection
    {
        public static string dataSource { get; } = "dataSource";
        public static string dbName { get; } = "dbName";
        public static string dbUser { get; } = "dbUser";
        public static string dbPassword { get; } = "dbPassword";

        public static string GetAppConnectionString()
        {
            string appConnectionString = "";
            try
            {
                string _dataSource = GetSettingValue(dataSource);
                string _dbName = GetSettingValue(dbName);
                string _dbUser = GetSettingValue(dbUser);
                string _dbPassword = GetSettingValue(dbPassword);

                appConnectionString = $@"data source={_dataSource};initial catalog={_dbName};
                                        user id={_dbUser};password={_dbPassword};MultipleActiveResultSets=True;App=EntityFramework";
            }
            catch (Exception e)
            {
                var log = new Log();
                log.ArchiveLog("Utilitarios: Get AppConnectionString: ", e.Message);
            }

            return appConnectionString;

        }

        public static string AssembleConnectionString(string dataSource = null, string dbUser = null, string dbPassword = null, string dbName = null)
        {
            string connectionString = "";

            #region Si también aceptará windows authentication
            //if (dbUser == "" && dbPassword == "")
            //    connectionString = "Data source = " + dataSource + "; Trusted_Connection = True;";

            //else 
            #endregion

            if (dbName != null)
                connectionString = $@"data source={dataSource};initial catalog={dbName};
                                        user id={dbUser};password={dbPassword};MultipleActiveResultSets=True;App=EntityFramework";
            else
                connectionString = $@"data source={dataSource}; user id={dbUser};password={dbPassword};";

            return connectionString;
        }

        public bool EditConnectionString(string dataSource = null, string dbName = null, string dbUser = null, string dbPassword = null)
        {
            bool success = false;
            try
            {
                if (dataSource != null)
                    UpdateSetting(Connection.dataSource, dataSource);
                if (dbName != null)
                    UpdateSetting(Connection.dbName, dbName);
                if (dbUser != null)
                    UpdateSetting(Connection.dbUser, dbUser);
                if (dbPassword != null)
                {
                    dbPassword = new Encription().Encryption(dbPassword);
                    UpdateSetting(Connection.dbPassword, dbPassword);
                }

                success = true;
            }
            catch (Exception e)
            {
                var log = new Log();
                log.ArchiveLog("Utilitarios: Edit Connection String: ", e.Message);
            }
            return success;
        }

        public static bool ConnectionTest(string connectionString = null)
        {
            if (connectionString == null)
                connectionString = GetAppConnectionString();

            bool success = false;
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "select 1";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        command.ExecuteScalar();
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Utilitarios: Test Connection Failed: ", e.Message);
                }
            }
            return success;
        }

        public static string GetSettingValue(string key)
        {
            string value = "";
            try
            {
                value = ConfigurationManager.AppSettings[key];

                if (key == dbPassword)
                    value = new Encription().Decryption(value);
            }
            catch (Exception e)
            {
                var log = new Log();
                log.ArchiveLog("Utilitarios: Get Setting Value. Key: " + key + ". ", e.Message);
            }
            return value;
        }

        private void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        public List<string> GetDatabases(string connectionString)
        {
            var listDatabases = new List<string>();
            using (var cnn = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "EXEC sp_databases";
                    cnn.Open();
                    using (var cmd = new SqlCommand(query, cnn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            listDatabases.Add(reader[0].ToString());
                        }
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Utilitarios: Get Databases: ", e.Message);
                }
            }

            return listDatabases;
        }
    }



}
