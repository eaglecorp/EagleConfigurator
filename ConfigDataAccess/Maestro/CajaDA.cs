using ConfigBusinessEntity;
using ConfigDataAccess.Fiscal;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Maestro
{
    public class CajaDA
    {
        public List<MSTt12_caja> ListaCaja(int? id_estado = null)
        {
            var lista = new List<MSTt12_caja>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt12_caja" :
                @"SELECT * FROM MSTt12_caja WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt12_caja>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Caja: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarCaja(MSTt12_caja obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                using (var tns = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        ctx.MSTt12_caja.Add(obj);
                        ctx.SaveChanges();
                        id = obj.id_caja;
                        tns.Commit();
                    }
                    catch (Exception e)
                    {
                        tns.Rollback();
                        var log = new Log();
                        log.ArchiveLog("Insertar Caja: ", e.Message);
                    }
                }
            }
            return id;
        }

        public void EliminarCaja(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt12_caja SET id_estado = @id_estado, txt_estado = @txt_estado Where id_caja=@id";
                        cmd.Parameters.AddWithValue("@id_estado", id_estado);
                        cmd.Parameters.AddWithValue("@txt_estado", txt_estado);
                        cmd.Parameters.AddWithValue("@id", id);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Eliminar Caja: ", e.Message);
                }
            }
        }
        public void ActualizarCaja(MSTt12_caja actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                using (var tns = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        var original = ctx.MSTt12_caja.Find(actualizado.id_caja);
                        if (original != null && original.id_caja > 0)
                        {
                            ctx.Entry(original).CurrentValues.SetValues(actualizado);
                            ctx.SaveChanges();
                            //contra sql injection
                            if (ActualizarConfigFiscalCaja(actualizado.FISt05_configuracion_fiscal_caja))
                                tns.Commit();
                            else
                                tns.Rollback();
                        }
                    }
                    catch (Exception e)
                    {
                        tns.Rollback();
                        var log = new Log();
                        log.ArchiveLog("Actualizar Caja: ", e.Message);
                    }
                }
            }
        }
        public bool ActualizarConfigFiscalCaja(ICollection<FISt05_configuracion_fiscal_caja> configFiscal)
        {
            if (configFiscal == null || configFiscal.Count == 0)
                return true;

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
                            cnn.Execute(@"UPDATE FISt05_configuracion_fiscal_caja
                                            SET valor = @valor 
                                            WHERE id_configuracion_fiscal_caja = @id_configuracion_fiscal_caja",
                                     configFiscal, transaction: trans);

                            trans.Commit();
                            success = true;
                        }
                        catch (Exception e)
                        {
                            trans.Rollback();
                            var log = new Log();
                            log.ArchiveLog("Actualizar Config. Fiscal Caja - Excepción en la ejecución de la transacción: ", e.Message);
                        }
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Config. Fiscal Caja  - Excepción en abrir la transacción.: ", e.Message);
                }
            }
            return success;
        }
        public MSTt12_caja CajaXId(int id)
        {
            var obj = new MSTt12_caja();
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {


                    obj = ctx.MSTt12_caja.Include(x => x.FISt05_configuracion_fiscal_caja
                                                    .Select(cf => cf.FISt04_parametro_fiscal))
                                                    .FirstOrDefault(x => x.id_caja == id);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Caja por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt12_caja CajaXCod(string cod)
        {
            var obj = new MSTt12_caja();
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    obj = ctx.MSTt12_caja.Include(x => x.FISt05_configuracion_fiscal_caja
                                                    .Select(cf => cf.FISt04_parametro_fiscal))
                                                    .FirstOrDefault(x => x.cod_caja == cod);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Caja por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
