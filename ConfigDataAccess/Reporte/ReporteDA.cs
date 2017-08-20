using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Reporte
{
    public class ReporteDA
    {
        public List<RPTt01_reporte> ListaReporte(int? id_estado = null)
        {
            var lista = new List<RPTt01_reporte>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM RPTt01_reporte" :
                @"SELECT * FROM RPTt01_reporte WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<RPTt01_reporte>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Reporte: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarReporte(RPTt01_reporte obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.RPTt01_reporte.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_reporte;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Reporte: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarReporte(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE RPTt01_reporte SET id_estado = @id_estado, txt_estado = @txt_estado Where id_reporte=@id";
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
                    log.ArchiveLog("Eliminar Reporte: ", e.Message);
                }
            }
        }
        public void ActualizarReporte(RPTt01_reporte actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.RPTt01_reporte.Find(actualizado.id_reporte);
                    if (original != null && original.id_reporte > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Reporte: ", e.Message);
                }
            }
        }
        public RPTt01_reporte ReporteXId(int id)
        {
            var obj = new RPTt01_reporte();
            string sentencia = "SELECT * FROM RPTt01_reporte WHERE id_reporte=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<RPTt01_reporte>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Reporte por ID: ", e.Message);
                }
            }
            return obj;
        }
        public RPTt01_reporte ReporteXCod(string cod)
        {
            var obj = new RPTt01_reporte();
            string sentencia = "SELECT * FROM RPTt01_reporte WHERE cod_reporte=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<RPTt01_reporte>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Reporte por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
