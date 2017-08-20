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
    public class FamiliaDA
    {

        public List<PROt03_familia> ListaFamiliaProd(int? id_estado = null)
        {
            var lista = new List<PROt03_familia>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PROt03_familia"
                                            : @"SELECT * FROM PROt03_familia WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt03_familia>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Familias de Productos: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarFamilia(PROt03_familia obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt03_familia.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_familia;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Familia Producto: ", e.Message);
                }
            }
            return id;

        }
        public void EliminarFamilia(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt03_familia SET id_estado = @id_estado, txt_estado = @txt_estado Where id_familia=@id";
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
                    log.ArchiveLog("Eliminar Familia Producto: ", e.Message);
                }
            }
        }
        public void ActualizarFamilia(PROt03_familia familiaActualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PROt03_familia.Find(familiaActualizado.id_familia);
                    if (original != null && original.id_familia > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(familiaActualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Familia Producto: ", e.Message);
                }
            }
        }
        public PROt03_familia FamiliaXId(int id)
        {
            var oFamilia = new PROt03_familia();
            string sentencia = "SELECT * FROM PROt03_familia WHERE id_familia=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    oFamilia = cnn.Query<PROt03_familia>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Familia Producto por ID: ", e.Message);
                }
            }
            return oFamilia;
        }
        public PROt03_familia FamiliaXCod(string cod)
        {
            var obj = new PROt03_familia();
            string sentencia = "SELECT * FROM PROt03_familia WHERE cod_familia=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt03_familia>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Familia Producto por COD: ", e.Message);
                }
            }
            return obj;
        }
        public List<PROt03_familia> ListaFamConSubFam()
        {
            var lista = new List<PROt03_familia>();
            string sentencia = @"SELECT * FROM PROt03_familia f
                                INNER JOIN PROt04_subfamilia sb 
                                on f.id_familia = sb.id_familia";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt03_familia, PROt04_subfamilia, PROt03_familia>(sentencia, (f, sf) => { f.PROt04_subfamilia.Add(sf); return f; },
                    splitOn: "id_familia").ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Familia Producto con SubFamilia: ", e.Message);
                }
            }
            return lista;
        }

    }
}
