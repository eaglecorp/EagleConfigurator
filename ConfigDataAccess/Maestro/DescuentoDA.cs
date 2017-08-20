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
    public class DescuentoDA
    {
        public List<MSTt02_descuento> ListaDescuento(int? id_estado = null)
        {
            var lista = new List<MSTt02_descuento>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt02_descuento" :
                @"SELECT * FROM MSTt02_descuento WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt02_descuento>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Descuentos: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarDescuento(MSTt02_descuento obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt02_descuento.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_descuento;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Descuento: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarDescuento(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt02_descuento SET id_estado = @id_estado, txt_estado = @txt_estado Where id_descuento=@id";
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
                    log.ArchiveLog("Eliminar Descuento: ", e.Message);
                }
            }
        }
        public void ActualizarDescuento(MSTt02_descuento actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt02_descuento.Find(actualizado.id_descuento);
                    if (original != null && original.id_descuento > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Descuento: ", e.Message);
                }
            }
        }
        public MSTt02_descuento DescuentoXId(int id)
        {
            var obj = new MSTt02_descuento();
            string sentencia = "SELECT * FROM MSTt02_descuento WHERE id_descuento=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt02_descuento>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Descuento por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt02_descuento DescuentoXCod(string cod)
        {
            var obj = new MSTt02_descuento();
            string sentencia = "SELECT * FROM MSTt02_descuento WHERE cod_descuento=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt02_descuento>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Descuento por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
