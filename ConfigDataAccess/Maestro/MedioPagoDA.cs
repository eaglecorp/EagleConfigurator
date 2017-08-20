using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using System.Data.SqlClient;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess.Maestro
{
    public class MedioPagoDA
    {
        public List<MSTt01_medio_pago> ListaMedioPago(int? id_estado = null)
        {
            var lista = new List<MSTt01_medio_pago>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM MSTt01_medio_pago" : @"SELECT * FROM MSTt01_medio_pago WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt01_medio_pago>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Medios de Pago: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarMedioPago(MSTt01_medio_pago obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt01_medio_pago.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_medio_pago;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Medio de Pago: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarMedioPago(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt01_medio_pago SET id_estado = @id_estado, txt_estado = @txt_estado Where id_medio_pago=@id";
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
                    log.ArchiveLog("Eliminar Medio de Pago: ", e.Message);
                }
            }
        }
        public void ActualizarMedioPago(MSTt01_medio_pago actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt01_medio_pago.Find(actualizado.id_medio_pago);
                    if (original != null && original.id_medio_pago > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Medio de Pago: ", e.Message);
                }
            }
        }
        public MSTt01_medio_pago MedioPagoXId(int id)
        {
            var obj = new MSTt01_medio_pago();
            string sentencia = "SELECT * FROM MSTt01_medio_pago WHERE id_medio_pago=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt01_medio_pago>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Medio de Pago por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt01_medio_pago MedioPagoXCod(string cod)
        {
            var obj = new MSTt01_medio_pago();
            string sentencia = "SELECT * FROM MSTt01_medio_pago WHERE cod_medio_pago=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt01_medio_pago>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Medio de Pago por COD: ", e.Message);
                }
            }
            return obj;
        }

    }
}
