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
    public class SubFamiliaDA
    {
        public List<PROt04_subfamilia> ListaSubFamilia(int? id_estado = null)
        {
            var lista = new List<PROt04_subfamilia>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PROt04_subfamilia" : @"SELECT * FROM PROt04_subfamilia WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt04_subfamilia>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de SubFamilias de Producto: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarSubFam(PROt04_subfamilia obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt04_subfamilia.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_subfamilia;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar SubFamilia Producto: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarSubFam(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt04_subfamilia SET id_estado = @id_estado, txt_estado = @txt_estado Where id_subfamilia=@id";
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
                    log.ArchiveLog("Eliminar SubFamilia Producto: ", e.Message);
                }
            }
        }
        public void ActualizarSubFam(PROt04_subfamilia subFamActualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PROt04_subfamilia.Find(subFamActualizado.id_subfamilia);
                    if (original != null && original.id_subfamilia > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(subFamActualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar SubFamilia Producto: ", e.Message);
                }
            }
        }
        public PROt04_subfamilia SubFamiliaXId(int id)
        {
            var oSubFam = new PROt04_subfamilia();
            string sentencia = "SELECT * FROM PROt04_subfamilia WHERE id_subfamilia=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    oSubFam = cnn.Query<PROt04_subfamilia>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda SubFamilia Producto por ID: ", e.Message);
                }
            }
            return oSubFam;
        }
        public PROt04_subfamilia SubFamiliaXCod(string cod)
        {
            var obj = new PROt04_subfamilia();
            string sentencia = "SELECT * FROM PROt04_subfamilia WHERE cod_subfamilia=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt04_subfamilia>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda SubFamilia Producto por COD: ", e.Message);
                }
            }
            return obj;
        }
        public List<PROt04_subfamilia> ListaSubFamXFam(int id_familia, int? id_estado = null)
        {
            var lista = new List<PROt04_subfamilia>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM PROt04_subfamilia WHERE id_familia = @id_familia" :
                @"SELECT * FROM PROt04_subfamilia WHERE id_familia = @id_familia AND id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt04_subfamilia>(sentencia, new { id_familia, id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista SubFamilia Producto por Familia: ", e.Message);
                }
            }
            return lista;
        }
    }
}
