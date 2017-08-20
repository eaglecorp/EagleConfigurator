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
    public class RazonDA
    {
        public List<MSTt05_razon> ListaRazon(int? id_estado = null)
        {
            var lista = new List<MSTt05_razon>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt05_razon" :
                @"SELECT * FROM MSTt05_razon WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt05_razon>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Razones: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarRazon(MSTt05_razon obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt05_razon.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_razon;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Razón: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarRazon(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt05_razon SET id_estado = @id_estado, txt_estado = @txt_estado Where id_razon=@id";
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
                    log.ArchiveLog("Eliminar Razón: ", e.Message);
                }
            }
        }
        public void ActualizarRazon(MSTt05_razon actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt05_razon.Find(actualizado.id_razon);
                    if (original != null && original.id_razon > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Razón: ", e.Message);
                }
            }
        }
        public MSTt05_razon RazonXId(int id)
        {
            var obj = new MSTt05_razon();
            string sentencia = "SELECT * FROM MSTt05_razon WHERE id_razon=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt05_razon>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Razón por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt05_razon RazonXCod(string cod)
        {
            var obj = new MSTt05_razon();
            string sentencia = "SELECT * FROM MSTt05_razon WHERE cod_razon=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt05_razon>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Razón por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
