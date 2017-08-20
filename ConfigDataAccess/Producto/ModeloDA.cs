using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using System.Data.SqlClient;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess
{
    public class ModeloDA
    {
        public List<PROt02_modelo> ListaModelo(int? id_estado = null)
        {
            var lista = new List<PROt02_modelo>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PROt02_modelo" 
                                            : @"SELECT * FROM PROt02_modelo WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt02_modelo>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Modelos de Productos: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarModelo(PROt02_modelo obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt02_modelo.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_modelo;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Modelo Producto: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarModelo(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt02_modelo SET id_estado = @id_estado, txt_estado = @txt_estado Where id_modelo=@id";
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
                    log.ArchiveLog("Eliminar Modelo Producto: ", e.Message);
                }
            }
        }
        public void ActualizarModelo(PROt02_modelo modeloActualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PROt02_modelo.Find(modeloActualizado.id_modelo);
                    if (original != null && original.id_modelo > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(modeloActualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Modelo Producto: ", e.Message);
                }
            }
        }
        public PROt02_modelo ModeloXId(int id)
        {
            var oModelo = new PROt02_modelo();
            string sentencia = "SELECT * FROM PROt02_modelo WHERE id_modelo=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    oModelo = cnn.Query<PROt02_modelo>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Modelo Producto por ID: ", e.Message);
                }
            }
            return oModelo;
        }
        public PROt02_modelo ModeloXCod(string cod)
        {
            var obj = new PROt02_modelo();
            string sentencia = "SELECT * FROM PROt02_modelo WHERE cod_modelo=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt02_modelo>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Modelo Producto por COD: ", e.Message);
                }
            }
            return obj;
        }
        public List<PROt02_modelo> ListaModeloXMarca(int id_marca, int? id_estado = null)
        {
            var lista = new List<PROt02_modelo>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM PROt02_modelo WHERE id_marca=@id_marca" :
                @"SELECT * FROM PROt02_modelo WHERE id_marca=@id_marca AND id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt02_modelo>(sentencia, new { id_marca, id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Modelo Producto por Marca: ", e.Message);
                }
            }
            return lista;
        }
    }
}
