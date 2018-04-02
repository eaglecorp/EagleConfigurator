using ConfigBusinessEntity;
using ConfigDataAccess.Labor;
using System;
using System.Collections.Generic;

namespace ConfigBusinessLogic.Labor
{
    public class HorarioEmpleadoBL
    {
        public long InsertarHorario(LABt03_horario_emp obj)
        {
            return new HorarioEmpleadoDA().InsertarHorario(obj);
        }

        public LABt03_horario_emp HorarioXEmpleado(long id_empleado)
        {
            return new HorarioEmpleadoDA().HorarioXEmpleado(id_empleado);
        }
        public bool EliminarHorarioDtl(long id_horario_emp_dtl)
        {
            return new HorarioEmpleadoDA().EliminarHorarioDtl(id_horario_emp_dtl);
        }

        public bool EliminarHorariosDtl(IEnumerable<long> idFechas)
        {
            return new HorarioEmpleadoDA().EliminarHorariosDtl(idFechas);
        }

        public bool EliminarHorario(long idHorario)
        {
            return new HorarioEmpleadoDA().EliminarHorario(idHorario);
        }

        public bool ActualizarRangoDeHorario(long idHorario)
        {
            return new HorarioEmpleadoDA().ActualizarRangoDeHorario(idHorario);
        }
        public LABt04_horario_emp_dtl GetHorarioDtlXFecha(DateTime fecha, long idHorario)
        {
            return new HorarioEmpleadoDA().GetHorarioDtlXFecha(fecha, idHorario);
        }

        public bool ActualizarHorarioDtl(LABt04_horario_emp_dtl actualizado)
        {
            return new HorarioEmpleadoDA().ActualizarHorarioDtl(actualizado);
        }

        public bool ActualizarHorariosDtlXDiaDeSemana(LABt04_horario_emp_dtl actualizado, DateTime desde, DateTime diaDeSemana)
        {
            return new HorarioEmpleadoDA().ActualizarHorariosDtlXDiaDeSemana(actualizado,desde,diaDeSemana);
        }
    }
}
