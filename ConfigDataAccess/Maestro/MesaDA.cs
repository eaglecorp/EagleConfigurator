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
    public class MesaDA
    {
        public List<MSTt14_mesa> ListaMesa(int? id_estado_mesa = null)
        {
            var lista = new List<MSTt14_mesa>();
            string sentencia = string.Empty;
            sentencia = (id_estado_mesa == null) ?
                @"SELECT * FROM MSTt14_mesa" :
                @"SELECT * FROM MSTt14_mesa WHERE id_estado_estado=@id_estado_mesa";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt14_mesa>(sentencia, new { id_estado_mesa }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Mesa: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarMesa(MSTt14_mesa obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt14_mesa.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_mesa;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Mesa: ", e.Message);
                }
            }
            return id;
        }
        public void CambiarEstadoMesa(int id_mesa, int id_estado_mesa)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt14_mesa SET id_estado_mesa = @id_estado_mesa Where id_mesa=@id_mesa";
                        cmd.Parameters.AddWithValue("@id_estado_mesa", id_estado_mesa);
                        cmd.Parameters.AddWithValue("@id_mesa", id_mesa);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Cambiar Estado Mesa: ", e.Message);
                }
            }
        }
        public void ActualizarMesa(MSTt14_mesa actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt14_mesa.Find(actualizado.id_mesa);
                    if (original != null && original.id_mesa > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Mesa: ", e.Message);
                }
            }
        }
        public MSTt14_mesa MesaXId(int id)
        {
            var obj = new MSTt14_mesa();
            string sentencia = "SELECT * FROM MSTt14_mesa WHERE id_mesa=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt14_mesa>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Mesa por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt14_mesa MesaXCod(string cod)
        {
            var obj = new MSTt14_mesa();
            string sentencia = "SELECT * FROM MSTt14_mesa WHERE cod_mesa=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt14_mesa>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Mesa por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
