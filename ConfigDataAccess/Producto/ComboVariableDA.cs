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
    public class ComboVariableDA
    {
        public List<PROt15_combo_variable> ListaComboVariable(int? id_estado = null)
        {


            var lista = new List<PROt15_combo_variable>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM PROt15_combo_variable" :
                @"SELECT * FROM PROt15_combo_variable WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt15_combo_variable>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Combo Variable: ", e.Message);
                }
            }
            return lista;
        }
        public long InsertarComboVariable(PROt15_combo_variable obj)
        {
            long id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                using (var tns = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        ctx.PROt15_combo_variable.Add(obj);
                        ctx.SaveChanges();
                        tns.Commit();
                        id = obj.id_combo_variable;
                    }
                    catch (Exception e)
                    {
                        tns.Rollback();
                        var log = new Log();
                        log.ArchiveLog("Insertar Combo Variable: ", e.Message);
                    }
                }

            }
            return id;
        }
        public void EliminarComboVariable(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PROt15_combo_variable SET id_estado = @id_estado, txt_estado = @txt_estado Where id_combo_variable=@id";
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
                    log.ArchiveLog("Eliminar Combo Variable: ", e.Message);
                }
            }
        }
        public void ActualizarComboVariable(PROt15_combo_variable actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                using (var tns = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        var original = ctx.PROt15_combo_variable.Find(actualizado.id_combo_variable);
                        if (original != null && original.id_combo_variable > 0)
                        {
                            //Actulización del master
                            ctx.Entry(original).CurrentValues.SetValues(actualizado);

                            //Actualización del detail
                            if (actualizado.PROt16_combo_variable_dtl != null)
                                foreach (var newItem in actualizado.PROt16_combo_variable_dtl)
                                {
                                    //Caso: Edición 
                                    if (newItem.id_combo_variable_dtl > 0)
                                    {
                                        var oldItem = ctx.PROt16_combo_variable_dtl.Find(newItem.id_combo_variable_dtl);
                                        if (oldItem != null)
                                        {
                                            ctx.Entry(oldItem).CurrentValues.SetValues(newItem);
                                        }
                                    }
                                    //Caso: Inserción
                                    else
                                    {
                                        ctx.PROt16_combo_variable_dtl.Add(newItem);
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
                        log.ArchiveLog("Actualizar Combo Variable: ", e.Message);
                    }
                }
            }
        }
        public PROt15_combo_variable ComboVariableXId(long id)
        {
            var obj = new PROt15_combo_variable();

            #region Con Dapper
            string sql = @"SELECT * FROM PROt15_combo_variable WHERE id_combo_variable=@id; 
                            SELECT  [id_combo_variable_dtl]
                                  ,[cod_combo_variable_dtl]
                                  ,[cantidad]
                                  ,[mto_pvpu_sin_tax]
                                  ,[mto_pvpu_con_tax]
                                  ,[id_estado]
                                  ,[txt_estado]
                                  ,[id_combo_variable]
                                  ,[id_producto]
                              FROM [PROt16_combo_variable_dtl] WHERE id_combo_variable = @id;";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    using (var multi = cnn.QueryMultiple(sql, new { id }))
                    {
                        obj = multi.Read<PROt15_combo_variable>().SingleOrDefault();
                        var combo_var_dtl = multi.Read<PROt16_combo_variable_dtl>().ToList();

                        if (combo_var_dtl != null)
                        {
                            obj.PROt16_combo_variable_dtl = combo_var_dtl;
                            foreach (var dtl in combo_var_dtl)
                            {
                                dtl.PROt09_producto = cnn.Query<PROt09_producto>("SELECT txt_desc FROM PROt09_producto WHERE id_producto = @id_producto", new { id_producto = dtl.id_producto }).SingleOrDefault();
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Combo Variable por ID: ", e.Message);
                }
            }
            #endregion

            #region EF
            //using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            //{
            //    try
            //    {
            //        ctx.PROt15_combo_variable.AsNoTracking().
            //            Select(x => new PROt15_combo_variable {
            //                id_combo_variable = x.id_combo_variable,
            //                cod_combo_variable = x.cod_combo_variable,
            //                mto_pvpu_con_tax = x.mto_pvpu_con_tax,
            //                mto_pvpu_sin_tax = x.mto_pvpu_sin_tax,
            //                txt_desc = x.txt_desc,
            //                id_estado = x.id_estado,
            //                txt_estado = x.txt_estado,
            //                PROt16_combo_variable_dtl = ctx.PROt16_combo_variable_dtl.
            //                                            AsNoTracking().
            //                                            Where(d => d.id_combo_variable == id).ToList()
            //            }).
            //            Where(x => x.id_combo_variable == id);
            //    }
            //    catch (Exception e)
            //    {
            //        var log = new Log();
            //        log.ArchiveLog("Búsqueda Combo Variable por ID: ", e.Message);
            //    }
            //} 
            #endregion

            return obj;
        }
        public PROt15_combo_variable ComboVariableXCod(string cod)
        {
            var obj = new PROt15_combo_variable();
            string sentencia = "SELECT * FROM PROt15_combo_variable WHERE cod_combo_variable=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt15_combo_variable>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Combo Variable por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
