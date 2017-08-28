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
        public int InsertarComboVariable(PROt15_combo_variable obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PROt15_combo_variable.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_combo_variable;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Combo Variable: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarComboVariable(int id)
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
                try
                {
                    var original = ctx.PROt15_combo_variable.Find(actualizado.id_combo_variable);
                    if (original != null && original.id_combo_variable > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Combo Variable: ", e.Message);
                }
            }
        }
        public PROt15_combo_variable ComboVariableXId(int id)
        {
            var obj = new PROt15_combo_variable();
            string sentencia = "SELECT * FROM PROt15_combo_variable WHERE id_combo_variable=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PROt15_combo_variable>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Combo Variable por ID: ", e.Message);
                }
            }
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
