using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Labor
{
    public class TrabajoDA
    {

        public List<LABt06_trabajo> ListaTrabajo(int? id_estado = null)
        {
            var lista = new List<LABt06_trabajo>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM LABt06_trabajo" :
                @"SELECT * FROM LABt06_trabajo WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<LABt06_trabajo>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Trabajo: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarTrabajo(LABt06_trabajo obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.LABt06_trabajo.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_trabajo;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Trabajo: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarTrabajo(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE LABt06_trabajo SET id_estado = @id_estado, txt_estado = @txt_estado Where id_trabajo=@id";
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
                    log.ArchiveLog("Eliminar Trabajo: ", e.Message);
                }
            }
        }
        public void ActualizarTrabajo(LABt06_trabajo actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.LABt06_trabajo.Find(actualizado.id_trabajo);
                    if (original != null && original.id_trabajo > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Trabajo: ", e.Message);
                }
            }
        }
        public LABt06_trabajo TrabajoXId(int id)
        {
            var obj = new LABt06_trabajo();
            string sentencia = "SELECT * FROM LABt06_trabajo WHERE id_trabajo=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<LABt06_trabajo>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Trabajo por ID: ", e.Message);
                }
            }
            return obj;
        }
        public LABt06_trabajo TrabajoXCod(string cod)
        {
            var obj = new LABt06_trabajo();
            string sentencia = "SELECT * FROM LABt06_trabajo WHERE cod_trabajo=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<LABt06_trabajo>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Trabajo por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
