using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Fiscal
{
    public class ParametroFiscalDA
    {
        public List<FISt04_parametro_fiscal> ListaParametroFiscal()
        {
            var lista = new List<FISt04_parametro_fiscal>();
            string sentencia =   @"SELECT * FROM FISt04_parametro_fiscal" ;
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<FISt04_parametro_fiscal>(sentencia).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Parámetro Fiscal: ", e.Message);
                }
            }
            return lista;
        }
    }
}
