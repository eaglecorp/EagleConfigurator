using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
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
            string sentencia = @"SELECT * FROM FISt04_parametro_fiscal";
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

        public bool ActualizarAndInsertarParametrosFiscales(
            List<FISt04_parametro_fiscal> paramFisParaActualizar,
            List<FISt04_parametro_fiscal> paramFisParaInsertar)
        {
            bool success = true;
            if (paramFisParaActualizar != null && paramFisParaActualizar.Count > 0)
            {
                success = ActualizarParametrosFiscales(paramFisParaActualizar);
            }
            if (success && paramFisParaInsertar != null && paramFisParaInsertar.Count > 0)
            {
                success = success && InsertarParametrosFiscales(paramFisParaInsertar);
            }
            return success;
        }

        public bool InsertarParametrosFiscales(List<FISt04_parametro_fiscal> paramFisParaInsertar)
        {
            bool success = false;

            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                using (var tns = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        ctx.FISt04_parametro_fiscal.AddRange(paramFisParaInsertar);
                        ctx.SaveChanges();
                        tns.Commit();
                        success = true;
                    }
                    catch (Exception e)
                    {
                        tns.Rollback();
                        var log = new Log();
                        log.ArchiveLog("Insertar Parametros fiscales: ", e.Message);
                    }
                }
            }
            return success;
        }

        public bool EstaDisponibleCodigo(long? idParametroFiscal, string codigo)
        {
            bool isValid = true;

            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    if (idParametroFiscal == null)
                    {
                        //Cuando verifica en toda la tabla (EN INSERCIÓN)
                        isValid = ctx.FISt04_parametro_fiscal.Any(x => x.cod_parametro_fiscal == codigo);
                    }

                    else
                    {
                        //Cuando verifica en toda la tabla excepto su contenido (EN ACTUALIZACIÓN)
                        isValid = ctx.FISt04_parametro_fiscal.Where(x => x.id_parametro_fiscal != idParametroFiscal)
                                                        .Any(x => x.cod_parametro_fiscal == codigo);
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Validación: Está Disponible Código - Parámetro Fiscal: ", e.Message);
                }
            }
            return !isValid;
        }
        public bool EstaDisponibleNombre(long? idParametroFiscal, string nombre)
        {
            bool isValid = true;

            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    if (idParametroFiscal == null)
                    {
                        //Cuando verifica en toda la tabla (EN INSERCIÓN)
                        isValid = ctx.FISt04_parametro_fiscal.Any(x => x.txt_desc == nombre);
                    }

                    else
                    {
                        //Cuando verifica en toda la tabla excepto su contenido (EN ACTUALIZACIÓN)
                        isValid = ctx.FISt04_parametro_fiscal.Where(x => x.id_parametro_fiscal != idParametroFiscal)
                                                        .Any(x => x.txt_desc == nombre);
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Validación: Está Disponible Nombre - Parámetro Fiscal: ", e.Message);
                }
            }
            return !isValid;
        }
    }
}
