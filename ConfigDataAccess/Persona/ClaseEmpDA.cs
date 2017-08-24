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
    public class ClaseEmpDA
    {
        public List<PERt06_clase_emp> ListaClaseEmp(int? id_estado = null)
        {
            var lista = new List<PERt06_clase_emp>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM PERt06_clase_emp" :
                @"SELECT * FROM PERt06_clase_emp WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PERt06_clase_emp>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Clase Empleado: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarClaseEmp(PERt06_clase_emp obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PERt06_clase_emp.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_clase_emp;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Clase Empleado: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarClaseEmp(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PERt06_clase_emp SET id_estado = @id_estado, txt_estado = @txt_estado Where id_clase_emp=@id";
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
                    log.ArchiveLog("Eliminar Clase Empleado: ", e.Message);
                }
            }
        }
        public void ActualizarClaseEmp(PERt06_clase_emp actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PERt06_clase_emp.Find(actualizado.id_clase_emp);
                    if (original != null && original.id_clase_emp > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Clase Empleado: ", e.Message);
                }
            }
        }
        public PERt06_clase_emp ClaseEmpXId(int id)
        {
            var obj = new PERt06_clase_emp();
            string sentencia = "SELECT * FROM PERt06_clase_emp WHERE id_clase_emp=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt06_clase_emp>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Clase Empleado por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PERt06_clase_emp ClaseEmpXCod(string cod)
        {
            var obj = new PERt06_clase_emp();
            string sentencia = "SELECT * FROM PERt06_clase_emp WHERE cod_clase_emp=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt06_clase_emp>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Clase Empleado por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
