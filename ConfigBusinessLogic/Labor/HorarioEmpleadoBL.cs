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

        public IEnumerable<LABt03_horario_emp> ListaHorarioXEmpleado(long id)
        {
            return new HorarioEmpleadoDA().ListaHorarioXEmpleado(id);
        }
        public void EliminarHorarioXEmpleado(long id)
        {
            new HorarioEmpleadoDA().EliminarHorarioXEmpleado(id);
        }
    }
}
