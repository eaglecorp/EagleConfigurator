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
    public class CajaDA
    {
        public List<MSTt12_caja> ListaCaja(int? id_estado = null)
        {
            var lista = new List<MSTt12_caja>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt12_caja" :
                @"SELECT * FROM MSTt12_caja WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt12_caja>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Caja: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarCaja(MSTt12_caja obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt12_caja.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_caja;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Caja: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarCaja(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt12_caja SET id_estado = @id_estado, txt_estado = @txt_estado Where id_caja=@id";
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
                    log.ArchiveLog("Eliminar Caja: ", e.Message);
                }
            }
        }
        public void ActualizarCaja(MSTt12_caja actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt12_caja.Find(actualizado.id_caja);
                    if (original != null && original.id_caja > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Caja: ", e.Message);
                }
            }
        }
        public MSTt12_caja CajaXId(int id)
        {
            var obj = new MSTt12_caja();
            string sentencia = "SELECT * FROM MSTt12_caja WHERE id_caja=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt12_caja>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Caja por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt12_caja CajaXCod(string cod)
        {
            var obj = new MSTt12_caja();
            string sentencia = "SELECT * FROM MSTt12_caja WHERE cod_caja=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt12_caja>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Caja por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
