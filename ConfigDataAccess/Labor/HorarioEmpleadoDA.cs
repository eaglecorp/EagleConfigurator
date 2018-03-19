using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace ConfigDataAccess.Labor
{
    public class HorarioEmpleadoDA
    {
        public long InsertarHorario(LABt03_horario_emp obj)
        {
            long id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.LABt03_horario_emp.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_horario_emp;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Horario: ", e.Message);
                }
            }
            return id;
        }

        public int HorarioXEmpleado(int id)
        {
            var obj = new LABt03_horario_emp();
            string sentencia = "SELECT * FROM LABt03_horario_emp WHERE id_empleado=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<LABt03_horario_emp>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Producto por COD: ", e.Message);
                }
            }
            return 0;
        }

        public IEnumerable<LABt03_horario_emp> ListaHorarioXEmpleado(long id)
        {
            IEnumerable<LABt03_horario_emp> lista = new List<LABt03_horario_emp>();
            string sentencia = "SELECT * FROM LABt03_horario_emp WHERE id_empleado = @id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<LABt03_horario_emp>(sentencia, new { id });
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista horario por empleado: ", e.Message);
                }
            }
            return lista;
        }

        public void EliminarHorarioXEmpleado(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    using (var cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = $"DELETE LABt03_horario_emp WHERE id_empleado = {id}";
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("ELiminar Producto: ", e.Message);
                }
            }
        }
    }
}
