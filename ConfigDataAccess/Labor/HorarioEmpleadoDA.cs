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
                    log.ArchiveLog("Insertar Horario Empleado: ", e.Message);
                }
            }
            return id;
        }

        public LABt03_horario_emp HorarioXEmpleado(long id)
        {
            var horario = new LABt03_horario_emp();
            string sentencia = "SELECT * FROM LABt03_horario_emp WHERE id_empleado = @id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    horario = cnn.Query<LABt03_horario_emp>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Horario por empleado: ", e.Message);
                }
            }

            if (horario != null && horario.id_horario_emp > 0)
            {
                horario.LABt04_horario_emp_dtl = ListaHorarioDtl(horario.id_horario_emp).ToList();
            }

            return horario;
        }

        public bool EliminarHorarioDtl(long id_horario_emp)
        {
            var success = false;
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    using (var cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = $"DELETE LABt04_horario_emp_dtl WHERE id_horario_emp = {id_horario_emp}";
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("ELiminar Horario dtl. por horario: ", e.Message);
                }
            }
            return success;
        }

        private IEnumerable<LABt04_horario_emp_dtl> ListaHorarioDtl(long id_horario_emp)
        {
            IEnumerable<LABt04_horario_emp_dtl> lista = new List<LABt04_horario_emp_dtl>();
            string sentencia = "SELECT * FROM LABt04_horario_emp_dtl WHERE id_horario_emp = @id_horario_emp";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<LABt04_horario_emp_dtl>(sentencia, new { id_horario_emp });
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista horario dtl. por horario: ", e.Message);
                }
            }
            return lista;
        }
    }
}
