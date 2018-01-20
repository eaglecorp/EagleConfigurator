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
            string sentencia = @"SELECT * FROM FISt04_parametro_fiscal  ORDER BY cod_parametro_fiscal";
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

        public bool ActualizarParametrosFiscales(List<FISt04_parametro_fiscal> parametros)
        {
            bool success = false;
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    using (var trans = cnn.BeginTransaction())
                    {
                        try
                        {
                            cnn.Execute(@"UPDATE FISt04_parametro_fiscal
                                        SET valor_default = @valor_default
                                     WHERE id_parametro_fiscal = @id_parametro_fiscal",
                                     parametros, transaction: trans);

                            trans.Commit();
                            success = true;
                        }
                        catch (Exception e)
                        {
                            trans.Rollback();
                            var log = new Log();
                            log.ArchiveLog("Actualizar Parametros Fiscales - Excepción en la ejecución de la transacción: ", e.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Parametros Fiscales - Excepción en abrir la transacción.: ", e.Message);
                }
            }
            return success;
        }
    }
}
