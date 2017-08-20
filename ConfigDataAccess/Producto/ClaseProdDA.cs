using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ConfigBusinessEntity;
using System.Data.SqlClient;
using ConfigUtilitarios;

namespace ConfigDataAccess
{
    public class ClaseProdDA
    {
        public List<PROt06_clase_prod> ListaClaseProd(int? id_estado = null)
        {
            var lista = new List<PROt06_clase_prod>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PROt06_clase_prod" 
                                            : @"SELECT * FROM PROt06_clase_prod WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt06_clase_prod>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Clases de Productos: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarClase(PROt06_clase_prod obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt06_clase_prod.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_clase_prod;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Clase Producto: ", e.Message);
                }
            }
            return id;

        }
        public void EliminarClase(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt06_clase_prod SET id_estado = @id_estado, txt_estado = @txt_estado Where id_clase_prod=@id";
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
                    log.ArchiveLog("Eliminar Clase Producto: ", e.Message);
                }
            }
        }
        public void ActualizarClase(PROt06_clase_prod claseActualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PROt06_clase_prod.Find(claseActualizado.id_clase_prod);
                    if (original != null && original.id_clase_prod > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(claseActualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Clase Producto: ", e.Message);
                }
            }
        }
        public PROt06_clase_prod ClaseXId(int id)
        {
            var oClase = new PROt06_clase_prod();
            string sentencia = "SELECT * FROM PROt06_clase_prod WHERE id_clase_prod=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    oClase = cnn.Query<PROt06_clase_prod>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsuqeda Clase Producto por ID: ", e.Message);
                }
            }
            return oClase;
        }
        public PROt06_clase_prod ClaseProdXCod(string cod)
        {
            var obj = new PROt06_clase_prod();
            string sentencia = "SELECT * FROM PROt06_clase_prod WHERE cod_clase_prod=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt06_clase_prod>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Clase Producto por COD: ", e.Message);
                }
            }
            return obj;
        }
        public List<PROt06_clase_prod> ListaClaseProdXGrupo(int id_grupo_prod, int? id_estado = null)
        {
            var lista = new List<PROt06_clase_prod>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM PROt06_clase_prod WHERE id_grupo_prod =@id_grupo_prod" :
                @"SELECT * FROM PROt06_clase_prod WHERE id_grupo_prod =@id_grupo_prod AND id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt06_clase_prod>(sentencia, new { id_grupo_prod, id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Clases de Productos por Grupo: ", e.Message);
                }
            }
            return lista;
        }
    }
}
