using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool InsertarHorariosDtl(IEnumerable<LABt04_horario_emp_dtl> horariosDtl)
        {
            var success = false;

            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.LABt04_horario_emp_dtl.AddRange(horariosDtl);
                    ctx.SaveChanges();
                    success = true;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Horarios Dtl: ", e.Message);
                }
            }
            return success;
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
                        }
                    }
                    success = true;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Rango De Horario: ", e.Message);
                }
            }
            return success;
        }

        public bool ActualizarHorarioDtl(LABt04_horario_emp_dtl actualizado)
        {
            bool success = false;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.LABt04_horario_emp_dtl.Find(actualizado.id_horario_emp_dtl);
                    if (original != null && original.id_horario_emp_dtl > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Horario Dtl: ", e.Message);
                }
            }
            return success;
        }

        public bool ActualizarHorariosDtl(IEnumerable<LABt04_horario_emp_dtl> actualizados)
        {
            bool success = false;
            string sentencia = @"UPDATE [dbo].[LABt04_horario_emp_dtl]
                                   SET [hora_inicio] = @hora_inicio
                                      ,[hora_fin] = @hora_fin
                                      ,[hora_inicio_break] = @hora_inicio_break
                                      ,[hora_fin_break] = @hora_fin_break
                                      ,[tiempo_tolerancia] = @tiempo_tolerancia
                                 WHERE [id_horario_emp_dtl] = @id_horario_emp_dtl";

            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                using (var tns = ctx.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var actualizado in actualizados)
                        {
                            var parameterList = new List<SqlParameter>();
                            parameterList.Add(new SqlParameter("@hora_inicio", actualizado.hora_inicio));
                            parameterList.Add(new SqlParameter("@hora_fin", actualizado.hora_fin));
                            parameterList.Add(new SqlParameter("@hora_inicio_break", (dynamic)actualizado.hora_inicio_break ?? DBNull.Value));
                            parameterList.Add(new SqlParameter("@hora_fin_break", (dynamic)actualizado.hora_fin_break ?? DBNull.Value));
                            parameterList.Add(new SqlParameter("@tiempo_tolerancia", actualizado.tiempo_tolerancia));
                            parameterList.Add(new SqlParameter("@id_horario_emp_dtl", actualizado.id_horario_emp_dtl));
                            SqlParameter[] parameters = parameterList.ToArray();

                            ctx.Database.ExecuteSqlCommand(sentencia, parameters);
                        }

                        ctx.SaveChanges();
                        tns.Commit();
                        success = true;
                    }
                    catch (Exception e)
                    {
                        tns.Rollback();
                        var log = new Log();
                        log.ArchiveLog("Actualizar Horarios Dtl: ", e.Message);
                    }
                }
            }
            return success;
        }


        public bool ActualizarHorariosDtlXDiaDeSemana(LABt04_horario_emp_dtl actualizado, DateTime desde, DateTime diaDeSemana)
        {
            bool success = false;

            using (var conexion = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    using (var cmd = new SqlCommand("USP_LAB_UPD_HOR_DTL_X_DIA_SEMANA", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add(new SqlParameter("@id_horario_emp", actualizado.id_horario_emp));
                        cmd.Parameters.Add(new SqlParameter("@hora_inicio", actualizado.hora_inicio));
                        cmd.Parameters.Add(new SqlParameter("@hora_fin", actualizado.hora_fin));
                        cmd.Parameters.Add(new SqlParameter("@hora_inicio_break", (dynamic)actualizado.hora_inicio_break ?? DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@hora_fin_break", (dynamic)actualizado.hora_fin_break ?? DBNull.Value));
                        cmd.Parameters.Add(new SqlParameter("@tiempo_tolerancia", actualizado.tiempo_tolerancia));
                        cmd.Parameters.Add(new SqlParameter("@desde", desde));
                        cmd.Parameters.Add(new SqlParameter("@dia_de_semana", diaDeSemana));

                        var returnParameter = cmd.Parameters.Add("@success", SqlDbType.Bit);
                        returnParameter.Direction = ParameterDirection.ReturnValue;

                        conexion.Open();
                        cmd.ExecuteNonQuery();

                        #region Evaluando retorno
                        if (int.TryParse(returnParameter.Value.ToString(), out int result) && result == 1)
                        {
                            success = true;
                        }
                        else
                        {
                            var log = new Log();
                            log.ArchiveLog("Ocurrió un error en la actualización de los horarios dtl x dia de semana.", "USP_LAB_UPD_HOR_DTL_X_DIA_SEMANA");
                        }
                        #endregion
                    }

                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Horarios Dtl. por día de semana: ", e.Message);
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

        public bool EliminarHorarioDtl(long id_horario_emp_dtl)
        {
            var success = false;
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    using (var cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = $"DELETE LABt04_horario_emp_dtl WHERE id_horario_emp_dtl = {id_horario_emp_dtl}";
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        success = true;
                    }
                    LABt04_horario_emp_dtl a = new LABt04_horario_emp_dtl();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("ELiminar Horario dtl. por horario: ", e.Message);
                }
            }
            return success;
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

        public LABt04_horario_emp_dtl GetHorarioDtlXFecha(DateTime fecha, long idHorario)
        {
            var horarioDtl = new LABt04_horario_emp_dtl();
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    horarioDtl = ctx.LABt04_horario_emp_dtl.FirstOrDefault(x => x.id_horario_emp == idHorario && x.fecha_labor == fecha);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Get Horario Dtl. por fecha: ", e.Message);
                }
            }
            return horarioDtl;
        }
    }
}
