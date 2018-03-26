using ConfigBusinessEntity;
using ConfigDataAccess.Labor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Labor
{
    public class TrabajoEmpleadoBL
    {
        public long InsertarTrabajoEmpleado(LABt07_emp_trabajo obj)
        {
            return new TrabajoEmpleadoDA().InsertarTrabajoEmpleado(obj);
        }

        public bool ActualizarTrabajoEmpleado(LABt07_emp_trabajo actualizado)
        {
            return new TrabajoEmpleadoDA().ActualizarTrabajoEmpleado(actualizado);
        }

        public List<LABt07_emp_trabajo> ListaTrabajoXEmpleado(long idEmpleado)
        {
            return new TrabajoEmpleadoDA().ListaTrabajoXEmpleado(idEmpleado);
        }

        public bool ExisteTrabajoEmpleado(long idEmpleado, int idTrabajo)
        {
            return new TrabajoEmpleadoDA().ExisteTrabajoEmpleado(idEmpleado, idTrabajo);
        }
        public LABt07_emp_trabajo GetTrabajoEmpleado(long idEmpleado, int idTrabajo)
        {
            return new TrabajoEmpleadoDA().GetTrabajoEmpleado(idEmpleado, idTrabajo);
        }

        public bool DesactivarTrabajoEmpleado(long idTrabajoEmpleado)
        {
            return new TrabajoEmpleadoDA().DesactivarTrabajoEmpleado(idTrabajoEmpleado);
        }
    }
}
