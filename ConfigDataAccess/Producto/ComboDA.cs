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
    public class ComboDA
    {
        public List<PROt13_combo> ListaCombo(int? id_estado = null)
        {
            var lista = new List<PROt13_combo>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM PROt13_combo" :
                @"SELECT * FROM PROt13_combo WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt13_combo>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Combo: ", e.Message);
                }
            }
            return lista;
        }
        public long InsertarCombo(PROt13_combo obj)
        {
            long id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                using (var tns = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        ctx.PROt13_combo.Add(obj);
                        ctx.SaveChanges();
                        tns.Commit();
                        id = obj.id_combo;
                    }
                    catch (Exception e)
                    {
                        tns.Rollback();
                        var log = new Log();
                        log.ArchiveLog("Insertar Combo: ", e.Message);
                    }
                }

            }
            return id;
        }
        public void EliminarCombo(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt13_combo SET id_estado = @id_estado, txt_estado = @txt_estado Where id_combo=@id";
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
                    log.ArchiveLog("Eliminar Combo: ", e.Message);
                }
            }
        }
        public void ActualizarCombo(PROt13_combo actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                using (var tns = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        var original = ctx.PROt13_combo.Find(actualizado.id_combo);
                        if (original != null && original.id_combo > 0)
                        {
                            ctx.Entry(original).CurrentValues.SetValues(actualizado);
                            if (actualizado.PROt14_combo_fixed_dtl != null)
                                foreach (var newItem in actualizado.PROt14_combo_fixed_dtl)
                                {
                                    //Edición 
                                    if (newItem.id_combo_fixed_dtl > 0)
                                    {
                                        var oldItem = ctx.PROt14_combo_fixed_dtl.Find(newItem.id_combo_fixed_dtl);
                                        if (oldItem != null)
                                        {
                                            ctx.Entry(oldItem).CurrentValues.SetValues(newItem);
                                        }
                                    }
                                    //Inserción
                                    else
                                    {
                                        ctx.PROt14_combo_fixed_dtl.Add(newItem);
                                    }
                                }
                            ctx.SaveChanges();
                            tns.Commit();
                        }
                    }
                    catch (Exception e)
                    {
                        tns.Rollback();
                        var log = new Log();
                        log.ArchiveLog("Actualizar Combo: ", e.Message);
                    }
                }
            }
        }
        public PROt13_combo ComboXId(long id)
        {
            var obj = new PROt13_combo();

            #region Con Dapper
            string sql = @"SELECT * FROM PROt13_combo WHERE id_combo=@id; 
                            SELECT [id_combo_fixed_dtl]
                                  ,[cod_combo_fixed_dtl]
                                  ,[cantidad]
                                  ,[mto_pvpu_sin_tax]
                                  ,[mto_pvpu_con_tax]
                                  ,[id_estado]
                                  ,[txt_estado]
                                  ,[id_producto]
                                  ,[id_combo]
                                  ,[id_combo_variable]
                                      FROM PROt14_combo_fixed_dtl WHERE id_combo = @id;";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    using (var multi = cnn.QueryMultiple(sql, new { id }))
                    {
                        obj = multi.Read<PROt13_combo>().SingleOrDefault();
                        var combo_fixed_dtl = multi.Read<PROt14_combo_fixed_dtl>().ToList();

                        if (combo_fixed_dtl != null)
                        {
                            obj.PROt14_combo_fixed_dtl = combo_fixed_dtl;
                            foreach (var dtl in combo_fixed_dtl)
                            {
                                if (dtl.id_producto != null)
                                    dtl.PROt09_producto = cnn.Query<PROt09_producto>("SELECT txt_desc FROM PROt09_producto WHERE id_producto = @id_producto", new { id_producto = dtl.id_producto }).SingleOrDefault();
                                else if (dtl.id_combo_variable != null)
                                {
                                    dtl.PROt15_combo_variable = new ComboVariableDA().ComboVariableXId((int)dtl.id_combo_variable);
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Combo por ID: ", e.Message);
                }
            }
            #endregion


            return obj;

        }
        public PROt13_combo ComboXCod(string cod)
        {
            var obj = new PROt13_combo();
            string sentencia = "SELECT * FROM PROt13_combo WHERE cod_combo=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt13_combo>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Combo por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
