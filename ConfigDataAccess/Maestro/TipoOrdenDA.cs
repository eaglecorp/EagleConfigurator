using ConfigBusinessEntity;
using Dapper;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Maestro
{
    public class TipoOrdenDA
    {
        public List<MSTt03_tipo_orden> ListaTipoOrden(int? id_estado = null)
        {
            var lista = new List<MSTt03_tipo_orden>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? 
                @"SELECT * FROM MSTt03_tipo_orden" :
                @"SELECT * FROM MSTt03_tipo_orden WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt03_tipo_orden>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Tipos de Orden: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarTipoOrden(MSTt03_tipo_orden obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt03_tipo_orden.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_tipo_orden;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Tipo Orden: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarTipoOrden(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt03_tipo_orden SET id_estado = @id_estado, txt_estado = @txt_estado Where id_tipo_orden=@id";
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
                    log.ArchiveLog("Eliminar Tipo Orden: ", e.Message);
                }
            }
        }
        public void ActualizarTipoOrden(MSTt03_tipo_orden actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt03_tipo_orden.Find(actualizado.id_tipo_orden);
                    if (original != null && original.id_tipo_orden > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Tipo Orden: ", e.Message);
                }
            }
        }
        public MSTt03_tipo_orden TipoOrdenXId(int id)
        {
            var obj = new MSTt03_tipo_orden();
            string sentencia = "SELECT * FROM MSTt03_tipo_orden WHERE id_tipo_orden=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt03_tipo_orden>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Orden por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt03_tipo_orden TipoOrdenXCod(string cod)
        {
            var obj = new MSTt03_tipo_orden();
            string sentencia = "SELECT * FROM MSTt03_tipo_orden WHERE cod_tipo_orden=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt03_tipo_orden>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Orden por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
