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

        public bool EliminarHorariosDtl(IEnumerable<long> idFechas)
        {
            bool success = false;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var fechasAEliminar = ctx.LABt04_horario_emp_dtl.Where(x => idFechas.Contains(x.id_horario_emp_dtl));
                    if (fechasAEliminar != null)
                    {
                        ctx.LABt04_horario_emp_dtl.RemoveRange(fechasAEliminar);
                        ctx.SaveChanges();
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Eliminar Horarios Dtl: ", e.Message);
                }
            }
            return success;
        }

        public bool ActualizarRangoDeHorario(long idHorario)
        {
            bool success = false;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var horario = ctx.LABt03_horario_emp.FirstOrDefault(x => x.id_horario_emp == idHorario);
                    if (horario != null &&
                        horario.id_horario_emp > 0 &&
                        horario.LABt04_horario_emp_dtl != null &&
                        horario.LABt04_horario_emp_dtl.Count > 0)
                    {
                        DateTime ultimaFecha = horario.LABt04_horario_emp_dtl.Max(x => x.fecha_labor);
                        DateTime primeraFecha = horario.LABt04_horario_emp_dtl.Min(x => x.fecha_labor);

                        if (primeraFecha != horario.fecha_inicio_horario || ultimaFecha != horario.fecha_fin_horario)
                        {
                            horario.fecha_inicio_horario = primeraFecha;
                            horario.fecha_fin_horario = ultimaFecha;
                            ctx.SaveChanges();
                            success = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Rango De Horario: ", e.Message);
                }
            }
            return success;
        }

        public bool EliminarHorario(long idHorario)
        {
            bool success = false;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var horario = ctx.LABt03_horario_emp.FirstOrDefault(x => x.id_horario_emp == idHorario);
                    if (horario != null && horario.id_horario_emp > 0)
                    {
                        ctx.LABt04_horario_emp_dtl.RemoveRange(horario.LABt04_horario_emp_dtl);
                        ctx.LABt03_horario_emp.Remove(horario);
                        ctx.SaveChanges();
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Eliminar Horario: ", e.Message);
                }
            }
            return success;
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
