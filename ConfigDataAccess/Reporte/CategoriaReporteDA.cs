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
    public class CategoriaReporteDA
    {
        public List<RPTt02_categoria_reporte> ListaCategoriaReporte(int? id_estado = null)
        {
            var lista = new List<RPTt02_categoria_reporte>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM RPTt02_categoria_reporte" :
                @"SELECT * FROM RPTt02_categoria_reporte WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<RPTt02_categoria_reporte>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Categoría Reporte: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarCategoriaReporte(RPTt02_categoria_reporte obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.RPTt02_categoria_reporte.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_categoria_reporte;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Categoría Reporte: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarCategoriaReporte(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE RPTt02_categoria_reporte SET id_estado = @id_estado, txt_estado = @txt_estado Where id_categoria_reporte=@id";
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
                    log.ArchiveLog("Eliminar Categoría de Reporte: ", e.Message);
                }
            }
        }
        public void ActualizarCategoriaReporte(RPTt02_categoria_reporte actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.RPTt02_categoria_reporte.Find(actualizado.id_categoria_reporte);
                    if (original != null && original.id_categoria_reporte > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Categoría de Reporte: ", e.Message);
                }
            }
        }
        public RPTt02_categoria_reporte CategoriaReporteXId(int id)
        {
            var obj = new RPTt02_categoria_reporte();
            string sentencia = "SELECT * FROM RPTt02_categoria_reporte WHERE id_categoria_reporte=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<RPTt02_categoria_reporte>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Categoría de Reporte por ID: ", e.Message);
                }
            }
            return obj;
        }
        public RPTt02_categoria_reporte CategoriaReporteXCod(string cod)
        {
            var obj = new RPTt02_categoria_reporte();
            string sentencia = "SELECT * FROM RPTt02_categoria_reporte WHERE cod_categoria_reporte=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<RPTt02_categoria_reporte>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Categoría de Reporte por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
