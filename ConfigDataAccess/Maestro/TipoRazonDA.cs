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
    public class TipoRazonDA
    {
        public List<MSTt16_tipo_razon> ListaTipoRazon(int? id_estado = null)
        {

            var lista = new List<MSTt16_tipo_razon>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt16_tipo_razon" :
                @"SELECT * FROM MSTt16_tipo_razon WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt16_tipo_razon>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Tipo Razón: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarTipoRazon(MSTt16_tipo_razon obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt16_tipo_razon.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_tipo_razon;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Tipo Razón: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarTipoRazon(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt16_tipo_razon SET id_estado = @id_estado, txt_estado = @txt_estado Where id_tipo_razon=@id";
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
                    log.ArchiveLog("Eliminar Tipo Razón: ", e.Message);
                }
            }
        }
        public void ActualizarTipoRazon(MSTt16_tipo_razon actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt16_tipo_razon.Find(actualizado.id_tipo_razon);
                    if (original != null && original.id_tipo_razon > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Tipo Razón: ", e.Message);
                }
            }
        }
        public MSTt16_tipo_razon TipoRazonXId(int id)
        {
            var obj = new MSTt16_tipo_razon();
            string sentencia = "SELECT * FROM MSTt16_tipo_razon WHERE id_tipo_razon=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt16_tipo_razon>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Razón por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt16_tipo_razon TipoRazonXCod(string cod)
        {
            var obj = new MSTt16_tipo_razon();
            string sentencia = "SELECT * FROM MSTt16_tipo_razon WHERE cod_tipo_razon=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt16_tipo_razon>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Razón por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
