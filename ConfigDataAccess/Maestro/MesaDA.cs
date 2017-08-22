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
        public List<MSTt15_mesa> ListaMesa(int? id_estado = null)
        {
            var lista = new List<MSTt15_mesa>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt15_mesa" :
                @"SELECT * FROM MSTt15_mesa WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt15_mesa>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Mesa: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarMesa(MSTt15_mesa obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt15_mesa.Add(obj);
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
        public void EliminarMesa(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt15_mesa SET id_estado = @id_estado, txt_estado = @txt_estado Where id_mesa=@id";
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
                    log.ArchiveLog("Eliminar Mesa: ", e.Message);
                }
            }
        }
        public void ActualizarMesa(MSTt15_mesa actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt15_mesa.Find(actualizado.id_mesa);
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
        public MSTt15_mesa MesaXId(int id)
        {
            var obj = new MSTt15_mesa();
            string sentencia = "SELECT * FROM MSTt15_mesa WHERE id_mesa=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt15_mesa>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Mesa por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt15_mesa MesaXCod(string cod)
        {
            var obj = new MSTt15_mesa();
            string sentencia = "SELECT * FROM MSTt15_mesa WHERE cod_mesa=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt15_mesa>(sentencia, new { cod }).FirstOrDefault();
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
