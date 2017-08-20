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
    public class CanalVentaDA
    {
        public List<MSTt04_canal_vta> ListaCanalVenta(int? id_estado = null)
        {
            var lista = new List<MSTt04_canal_vta>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt04_canal_vta" :
                @"SELECT * FROM MSTt04_canal_vta WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt04_canal_vta>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Canales de Venta: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarCanalVenta(MSTt04_canal_vta obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt04_canal_vta.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_can_vta;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Canal de Venta: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarCanalVenta(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt04_canal_vta SET id_estado = @id_estado, txt_estado = @txt_estado Where id_can_vta=@id";
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
                    log.ArchiveLog("Eliminar Canal de Venta: ", e.Message);
                }
            }
        }
        public void ActualizarCanalVenta(MSTt04_canal_vta actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt04_canal_vta.Find(actualizado.id_can_vta);
                    if (original != null && original.id_can_vta > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Canal de Venta: ", e.Message);
                }
            }
        }
        public MSTt04_canal_vta CanalVentaXId(int id)
        {
            var obj = new MSTt04_canal_vta();
            string sentencia = "SELECT * FROM MSTt04_canal_vta WHERE id_can_vta=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt04_canal_vta>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Canal de Venta por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt04_canal_vta CanalVentaXCod(string cod)
        {
            var obj = new MSTt04_canal_vta();
            string sentencia = "SELECT * FROM MSTt04_canal_vta WHERE cod_can_vta=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt04_canal_vta>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Canal de Venta por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
