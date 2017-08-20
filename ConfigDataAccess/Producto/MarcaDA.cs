using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using ConfigUtilitarios;

namespace ConfigDataAccess
{
    public class MarcaDA
    {
        public List<PROt01_marca> ListaMarca(int? id_estado = null)
        {
            var lista = new List<PROt01_marca>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PROt01_marca"
                                            : @"SELECT * FROM PROt01_marca WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt01_marca>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Marcas: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarMarca(PROt01_marca obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt01_marca.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_marca;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Marca: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarMarca(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt01_marca SET id_estado = @id_estado, txt_estado = @txt_estado Where id_marca=@id";
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
                    log.ArchiveLog("Eliminar Marca: ", e.Message);
                }
            }
        }
        public void ActualizarMarca(PROt01_marca marcaActualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PROt01_marca.Find(marcaActualizado.id_marca);
                    if (original != null && original.id_marca > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(marcaActualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Marca: ", e.Message);
                }
            }
        }
        public PROt01_marca MarcaXId(int id)
        {
            var oMarca = new PROt01_marca();
            string sentencia = "SELECT * FROM PROt01_marca WHERE id_marca=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    oMarca = cnn.Query<PROt01_marca>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Marca por ID: ", e.Message);
                }
            }
            return oMarca;
        }
        public PROt01_marca MarcaXCod(string cod)
        {
            var obj = new PROt01_marca();
            string sentencia = "SELECT * FROM PROt01_marca WHERE cod_marca=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt01_marca>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Marca por COD: ", e.Message);
                }
            }
            return obj;
        }

    }
}
