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
    public class ImpresoraDA
    {
        public List<MSTt10_impresora> ListaImpresora(int? id_estado = null)
        {
            var lista = new List<MSTt10_impresora>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt10_impresora" :
                @"SELECT * FROM MSTt10_impresora WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt10_impresora>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Impresora: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarImpresora(MSTt10_impresora obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt10_impresora.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_impresora;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Impresora: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarImpresora(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt10_impresora SET id_estado = @id_estado, txt_estado = @txt_estado Where id_impresora=@id";
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
                    log.ArchiveLog("Eliminar Impresora: ", e.Message);
                }
            }
        }
        public void ActualizarImpresora(MSTt10_impresora actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt10_impresora.Find(actualizado.id_impresora);
                    if (original != null && original.id_impresora > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Impresora: ", e.Message);
                }
            }
        }
        public MSTt10_impresora ImpresoraXId(int id)
        {
            var obj = new MSTt10_impresora();
            string sentencia = "SELECT * FROM MSTt10_impresora WHERE id_impresora=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt10_impresora>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Impresora por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt10_impresora ImpresoraXCod(string cod)
        {
            var obj = new MSTt10_impresora();
            string sentencia = "SELECT * FROM MSTt10_impresora WHERE cod_impresora=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt10_impresora>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Impresora por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
