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
    public class TipoLocationDA
    {
        public List<MSTt09_tipo_location> ListaTipoLocation(int? id_estado = null)
        {
            var lista = new List<MSTt09_tipo_location>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt09_tipo_location" :
                @"SELECT * FROM MSTt09_tipo_location WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt09_tipo_location>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Tipos de Location: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarTipoLocation(MSTt09_tipo_location obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt09_tipo_location.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_tipo_location;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Tipo Location: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarTipoLocation(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt09_tipo_location SET id_estado = @id_estado, txt_estado = @txt_estado Where id_tipo_location=@id";
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
                    log.ArchiveLog("Eliminar Tipo Location: ", e.Message);
                }
            }
        }
        public void ActualizarTipoLocation(MSTt09_tipo_location actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt09_tipo_location.Find(actualizado.id_tipo_location);
                    if (original != null && original.id_tipo_location > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Tipo Location: ", e.Message);
                }
            }
        }
        public MSTt09_tipo_location TipoLocationXId(int id)
        {
            var obj = new MSTt09_tipo_location();
            string sentencia = "SELECT * FROM MSTt09_tipo_location WHERE id_tipo_location=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt09_tipo_location>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Location por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt09_tipo_location TipoLocationXCod(string cod)
        {
            var obj = new MSTt09_tipo_location();
            string sentencia = "SELECT * FROM MSTt09_tipo_location WHERE cod_tipo_location=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt09_tipo_location>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Location por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
