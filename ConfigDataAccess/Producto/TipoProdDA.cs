using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using Dapper;
using System.Data.SqlClient;
using ConfigUtilitarios;

namespace ConfigDataAccess
{
    public class TipoProdDA
    {
        public List<PROt07_tipo_prod> ListaTipoProd(int? id_estado = null)
        {
            var lista = new List<PROt07_tipo_prod>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PROt07_tipo_prod"
                                            : @"SELECT * FROM PROt07_tipo_prod WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt07_tipo_prod>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Tipos de Productos: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarTipoProd(PROt07_tipo_prod obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt07_tipo_prod.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_tipo_prod;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Tipo Producto: ", e.Message);
                }
            }
            return id;

        }
        public void EliminarTipoProd(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt07_tipo_prod SET id_estado = @id_estado, txt_estado = @txt_estado Where id_tipo_prod=@id";
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
                    log.ArchiveLog("Eliminar Tipo Producto: ", e.Message);
                }
            }
        }
        public void ActualizarTipoProd(PROt07_tipo_prod tipoProdActualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PROt07_tipo_prod.Find(tipoProdActualizado.id_tipo_prod);
                    if (original != null && original.id_tipo_prod > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(tipoProdActualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Tipo Producto: ", e.Message);
                }
            }
        }
        public PROt07_tipo_prod TipoProdXId(int id)
        {
            var obj = new PROt07_tipo_prod();
            string sentencia = "SELECT * FROM PROt07_tipo_prod WHERE id_tipo_prod=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt07_tipo_prod>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Producto por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PROt07_tipo_prod TipoProdXCod(string cod)
        {
            var obj = new PROt07_tipo_prod();
            string sentencia = "SELECT * FROM PROt07_tipo_prod WHERE cod_tipo_prod=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt07_tipo_prod>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Tipo Producto por COD: ", e.Message);
                }
            }
            return obj;
        }

    }
}
