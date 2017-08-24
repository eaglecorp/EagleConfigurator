using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Persona
{
    public class CategoriaEmpDA
    {
        public List<PERt05_categoria_emp> ListaCategoriaEmp(int? id_estado = null)
        {
            var lista = new List<PERt05_categoria_emp>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM PERt05_categoria_emp" :
                @"SELECT * FROM PERt05_categoria_emp WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PERt05_categoria_emp>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Categoría Empleado: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarCategoriaEmp(PERt05_categoria_emp obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PERt05_categoria_emp.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_categoria_emp;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Categoría Empleado: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarCategoriaEmp(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PERt05_categoria_emp SET id_estado = @id_estado, txt_estado = @txt_estado Where id_categoria_emp=@id";
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
                    log.ArchiveLog("Eliminar Categoría Empleado: ", e.Message);
                }
            }
        }
        public void ActualizarCategoriaEmp(PERt05_categoria_emp actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PERt05_categoria_emp.Find(actualizado.id_categoria_emp);
                    if (original != null && original.id_categoria_emp > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Categoría Empleado: ", e.Message);
                }
            }
        }
        public PERt05_categoria_emp CategoriaEmpXId(int id)
        {
            var obj = new PERt05_categoria_emp();
            string sentencia = "SELECT * FROM PERt05_categoria_emp WHERE id_categoria_emp=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt05_categoria_emp>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Categoría Empleado por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PERt05_categoria_emp CategoriaEmpXCod(string cod)
        {
            var obj = new PERt05_categoria_emp();
            string sentencia = "SELECT * FROM PERt05_categoria_emp WHERE cod_categoria_emp=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt05_categoria_emp>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Categoría Empleado por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
