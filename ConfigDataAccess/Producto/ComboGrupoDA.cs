using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Producto
{
    public class ComboGrupoDA
    {
        public List<PROt17_combo_grupo> ListaComboGrupo(int? id_estado = null)
        {
            var lista = new List<PROt17_combo_grupo>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM PROt17_combo_grupo" :
                @"SELECT * FROM PROt17_combo_grupo WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt17_combo_grupo>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Combo Grupo: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarComboGrupo(PROt17_combo_grupo obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt17_combo_grupo.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_combo_grupo;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Combo Grupo: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarComboGrupo(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt17_combo_grupo SET id_estado = @id_estado, txt_estado = @txt_estado Where id_combo_grupo=@id";
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
                    log.ArchiveLog("Eliminar Combo Grupo: ", e.Message);
                }
            }
        }
        public void ActualizarComboGrupo(PROt17_combo_grupo actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PROt17_combo_grupo.Find(actualizado.id_combo_grupo);
                    if (original != null && original.id_combo_grupo > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Combo Grupo:", e.Message);
                }
            }
        }
        public PROt17_combo_grupo ComboGrupoXId(int id)
        {
            var obj = new PROt17_combo_grupo();
            string sentencia = "SELECT * FROM PROt17_combo_grupo WHERE id_combo_grupo=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt17_combo_grupo>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Combo Grupo por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PROt17_combo_grupo ComboGrupoXCod(string cod)
        {
            var obj = new PROt17_combo_grupo();
            string sentencia = "SELECT * FROM PROt17_combo_grupo WHERE cod_combo_grupo=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt17_combo_grupo>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Combo Grupo por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
