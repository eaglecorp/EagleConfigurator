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
    public class LocationDA
    {
        public List<MSTt08_location> ListaLocation(int? id_estado = null)
        {
            var lista = new List<MSTt08_location>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt08_location" :
                @"SELECT * FROM MSTt08_location WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt08_location>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Location: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarLocation(MSTt08_location obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt08_location.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_location;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Location: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarLocation(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt08_location SET id_estado = @id_estado, txt_estado = @txt_estado Where id_location=@id";
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
                    log.ArchiveLog("Eliminar Location: ", e.Message);
                }
            }
        }
        public void ActualizarLocation(MSTt08_location actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt08_location.Find(actualizado.id_location);
                    if (original != null && original.id_location > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Location: ", e.Message);
                }
            }
        }
        public MSTt08_location LocationXId(int id)
        {
            var obj = new MSTt08_location();
            string sentencia = "SELECT * FROM MSTt08_location WHERE id_location=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt08_location>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Location por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt08_location LocationXIdMM(int id)
        {
            var obj = new MSTt08_location();
            //obteniendo
            obj = LocationXId(id);
            const string sentencia =
                    @"SELECT * FROM SNTt33_distrito WHERE id_dist=@id_dist";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    var multi = cnn.QueryMultiple(sentencia, new
                    {
                        id_dist = obj.id_dist
                    });
                    var distrito = multi.Read<SNTt33_distrito>().FirstOrDefault();
                    obj.SNTt33_distrito = distrito;

                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Location MM por ID: ", e.Message);
                }
            }
            return obj;
        }


        public MSTt08_location LocationXCod(string cod)
        {
            var obj = new MSTt08_location();
            string sentencia = "SELECT * FROM MSTt08_location WHERE cod_location=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt08_location>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Location por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
