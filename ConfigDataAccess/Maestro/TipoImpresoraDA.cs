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
    public class TipoImpresoraDA
    {
        public List<MSTt11_tipo_impresora> ListaTipoImpresora(int? id_estado = null)
        {
            var lista = new List<MSTt11_tipo_impresora>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt11_tipo_impresora" :
                @"SELECT * FROM MSTt11_tipo_impresora WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt11_tipo_impresora>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Tipo Impresora: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarTipoImpresora(MSTt11_tipo_impresora obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt11_tipo_impresora.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_tipo_impresora;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Tipo Impresora: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarTipoImpresora(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt11_tipo_impresora SET id_estado = @id_estado, txt_estado = @txt_estado Where id_tipo_impresora=@id";
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
                    log.ArchiveLog("Eliminar Tipo Impresora: ", e.Message);
                }
            }
        }
        public void ActualizarTipoImpresora(MSTt11_tipo_impresora actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt11_tipo_impresora.Find(actualizado.id_tipo_impresora);
                    if (original != null && original.id_tipo_impresora > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Tipo Impresora: ", e.Message);
                }
            }
        }
        public MSTt11_tipo_impresora TipoImpresoraXId(int id)
        {
            var obj = new MSTt11_tipo_impresora();
            string sentencia = "SELECT * FROM MSTt11_tipo_impresora WHERE id_tipo_impresora=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt11_tipo_impresora>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Impresora por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt11_tipo_impresora TipoImpresoraXCod(string cod)
        {
            var obj = new MSTt11_tipo_impresora();
            string sentencia = "SELECT * FROM MSTt11_tipo_impresora WHERE cod_tipo_impresora=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt11_tipo_impresora>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Impresora por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
