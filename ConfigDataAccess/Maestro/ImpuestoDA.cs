using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using Dapper;
using System.Data.SqlClient;
using ConfigUtilitarios;
using System.Data;

namespace ConfigDataAccess
{
    public class ImpuestoDA
    {
        public List<MSTt06_impuesto> ListaImpuesto(int? id_estado = null)
        {
            var lista = new List<MSTt06_impuesto>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt06_impuesto" :
                @"SELECT * FROM MSTt06_impuesto WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt06_impuesto>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Impuestos: ", e.Message);
                }
            }
            return lista;
        }

        public int InsertarImpuesto(MSTt06_impuesto obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt06_impuesto.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_impuesto;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Impuesto: ", e.Message);
                }
            }
            return id;
        }

        public void EliminarImpuesto(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt06_impuesto SET id_estado = @id_estado, txt_estado = @txt_estado Where id_impuesto=@id";
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
                    log.ArchiveLog("Eliminar Impuesto: ", e.Message);
                }
            }
        }

        public decimal SumarImpuestos(MSTt06_impuesto impto)
        {
            decimal porcImpto = 0;

            if (impto.por_impto01 != null)
            {
                porcImpto += (decimal)impto.por_impto01;
            }
            if (impto.por_impto02 != null)
            {
                porcImpto += (decimal)impto.por_impto02;
            }
            if (impto.por_impto03 != null)
            {
                porcImpto += (decimal)impto.por_impto03;
            }
            if (impto.por_impto04 != null)
            {
                porcImpto += (decimal)impto.por_impto04;
            }
            if (impto.por_impto05 != null)
            {
                porcImpto += (decimal)impto.por_impto05;
            }
            if (impto.por_impto06 != null)
            {
                porcImpto += (decimal)impto.por_impto06;
            }
            if (impto.por_impto07 != null)
            {
                porcImpto += (decimal)impto.por_impto07;
            }
            if (impto.por_impto08 != null)
            {
                porcImpto += (decimal)impto.por_impto08;
            }

            return porcImpto;
        }

        public bool CambioDistribucionDeImptos(MSTt06_impuesto original, MSTt06_impuesto actualizado)
        {
            if (original.por_impto01 != actualizado.por_impto01 ||
                original.por_impto02 != actualizado.por_impto02 ||
                original.por_impto03 != actualizado.por_impto03 ||
                original.por_impto04 != actualizado.por_impto04 ||
                original.por_impto05 != actualizado.por_impto05 ||
                original.por_impto06 != actualizado.por_impto06 ||
                original.por_impto07 != actualizado.por_impto07 ||
                original.por_impto08 != actualizado.por_impto08
                ) return true;
            return false;
        }

        public bool ActualizarImpuesto(MSTt06_impuesto actualizado)
        {
            bool success = false;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt06_impuesto.Find(actualizado.id_impuesto);
                    if (original != null && original.id_impuesto > 0)
                    {
                        bool actualizarPrecioCascada = true;
                        decimal nuevoPorcAcumulado = SumarImpuestos(actualizado);
                        decimal anteriorPorcAcumulado = SumarImpuestos(original);

                        if (anteriorPorcAcumulado != nuevoPorcAcumulado || CambioDistribucionDeImptos(original, actualizado))
                        {
                            actualizarPrecioCascada = ActualizarEnCascadaPreciosPorImpto(actualizado.id_impuesto, anteriorPorcAcumulado, actualizado);
                        }

                        if (actualizarPrecioCascada)
                        {
                            ctx.Entry(original).CurrentValues.SetValues(actualizado);
                            ctx.SaveChanges();
                            success = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Impuesto: ", e.Message);
                }
            }
            return success;
        }

        public MSTt06_impuesto ImpuestoXId(int id)
        {
            var obj = new MSTt06_impuesto();
            string sentencia = "SELECT * FROM MSTt06_impuesto WHERE id_impuesto=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt06_impuesto>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Impuesto por ID: ", e.Message);
                }
            }
            return obj;
        }

        public MSTt06_impuesto ImpuestoXCod(string cod)
        {
            var obj = new MSTt06_impuesto();
            string sentencia = "SELECT * FROM MSTt06_impuesto WHERE cod_impuesto=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt06_impuesto>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Impuesto por COD: ", e.Message);
                }
            }
            return obj;
        }

        public decimal? GetPorcentajeAcumulado(int id)
        {
            decimal? porcentajeAcumulado = 0;
            #region query

            string query = @"select (isnull(impto.por_impto01,0) +
		                    isnull(impto.por_impto02,0) +
		                    isnull(impto.por_impto03,0) +
		                    isnull(impto.por_impto04,0) +
		                    isnull(impto.por_impto05,0) +
		                    isnull(impto.por_impto06,0) +
		                    isnull(impto.por_impto07,0) +
		                    isnull(impto.por_impto08,0))
		                    as por_acumulado
		                      from dbo.MSTt06_impuesto impto
		                      where impto.id_impuesto = @id";
            #endregion

            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    porcentajeAcumulado = cnn.Query<decimal?>(query, new { id }).SingleOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Get Porcentaje Acumulado: ", e.Message);
                }
            }
            return porcentajeAcumulado;
        }

        public bool ActualizarEnCascadaPreciosPorImpto(int id_impto, decimal anteriorPorcImpto, MSTt06_impuesto actualizado)
        {
            bool success = false;

            using (var conexion = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    using (var cmd = new SqlCommand("USP_MST_ACT_IMPTO_CASCADA", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@por_total_anterior", anteriorPorcImpto));
                        cmd.Parameters.Add(new SqlParameter("@por_impto01", actualizado.por_impto01 ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@por_impto02", actualizado.por_impto02 ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@por_impto03", actualizado.por_impto03 ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@por_impto04", actualizado.por_impto04 ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@por_impto05", actualizado.por_impto05 ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@por_impto06", actualizado.por_impto06 ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@por_impto07", actualizado.por_impto07 ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@por_impto08", actualizado.por_impto08 ?? (object)DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@id_impuesto", id_impto));
                        cmd.Parameters.Add(new SqlParameter("@sn_incluye_impto", Estado.IdActivo));

                        var returnParameter = cmd.Parameters.Add("@success", SqlDbType.Bit);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        #region Evaluando retorno
                        if (int.TryParse(returnParameter.Value.ToString(), out int result) && result == 1)
                        {
                            success = true;
                        }
                        else
                        {
                            var log = new Log();
                            log.ArchiveLog("Ocurrió un error en la actualización en cascada de precios.", "USP_MST_ACT_IMPTO_CASCADA");
                        }
                        #endregion
                    }

                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar En Cascada Precio por Impuesto: ", e.Message);
                }
            }
            return success;
        }
    }
}
