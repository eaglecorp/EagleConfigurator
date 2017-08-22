using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Maestro
{
    public class EstadoMesaDA
    {
        public List<MSTt16_estado_mesa> ListaEstadoMesa(int? id_estado = null)
        {
            var lista = new List<MSTt16_estado_mesa>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt16_estado_mesa" :
                @"SELECT * FROM MSTt16_estado_mesa WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt16_estado_mesa>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Estado Mesa: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarEstadoMesa(MSTt16_estado_mesa obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt16_estado_mesa.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_estado_mesa;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Estado Mesa: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarEstadoMesa(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt16_estado_mesa SET id_estado = @id_estado, txt_estado = @txt_estado Where id_estado_mesa=@id";
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
                    log.ArchiveLog("Eliminar Estado Mesa: ", e.Message);
                }
            }
        }
        public void ActualizarTipoEstadoMesa(MSTt16_estado_mesa actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt16_estado_mesa.Find(actualizado.id_estado_mesa);
                    if (original != null && original.id_estado_mesa > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Estado Mesa: ", e.Message);
                }
            }
        }
        public MSTt16_estado_mesa TipoEstadoMesaXId(int id)
        {
            var obj = new MSTt16_estado_mesa();
            string sentencia = "SELECT * FROM MSTt16_estado_mesa WHERE id_estado_mesa=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt16_estado_mesa>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Estado Mesa por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt16_estado_mesa TipoEstadoMesaXCod(string cod)
        {
            var obj = new MSTt16_estado_mesa();
            string sentencia = "SELECT * FROM MSTt16_estado_mesa WHERE cod_estado_mesa=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt16_estado_mesa>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Estado Mesa por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
