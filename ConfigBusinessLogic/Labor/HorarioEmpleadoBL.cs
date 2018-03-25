using ConfigBusinessEntity;
using ConfigDataAccess.Labor;
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
        public bool EliminarHorarioDtl(long id_horario_emp)
        {
            return new HorarioEmpleadoDA().EliminarHorarioDtl(id_horario_emp);
        }
    }
}
