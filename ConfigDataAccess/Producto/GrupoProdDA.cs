using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess
{
    public class GrupoProdDA
    {
        public List<PROt05_grupo_prod> ListaGrupoProd(int? id_estado = null)
        {
            var lista = new List<PROt05_grupo_prod>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PROt05_grupo_prod"
                                            : @"SELECT * FROM PROt05_grupo_prod WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt05_grupo_prod>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Grupos de Productos: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarGrupo(PROt05_grupo_prod obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt05_grupo_prod.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_grupo_prod;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Grupo Producto: ", e.Message);
                }
            }
            return id;

        }
        public void EliminarGrupo(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt05_grupo_prod SET id_estado = @id_estado, txt_estado = @txt_estado Where id_grupo_prod=@id";
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
                    log.ArchiveLog("Eliminar Grupo Producto: ", e.Message);
                }
            }
        }
        public void ActualizarGrupo(PROt05_grupo_prod grupoActualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PROt05_grupo_prod.Find(grupoActualizado.id_grupo_prod);
                    if (original != null && original.id_grupo_prod > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(grupoActualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Grupo Producto: ", e.Message);
                }
            }
        }
        public PROt05_grupo_prod GrupoXId(int id)
        {
            var oGrupo = new PROt05_grupo_prod();
            string sentencia = "SELECT * FROM PROt05_grupo_prod WHERE id_grupo_prod=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    oGrupo = cnn.Query<PROt05_grupo_prod>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Grupo Producto por ID: ", e.Message);
                }
            }
            return oGrupo;
        }
        public PROt05_grupo_prod GrupoProdXCod(string cod)
        {
            var obj = new PROt05_grupo_prod();
            string sentencia = "SELECT * FROM PROt05_grupo_prod WHERE cod_grupo_prod=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt05_grupo_prod>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Grupo Producto por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
