using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios.ViewModels
{
    public class TrabajoEmpleadoVM
    {
        public long id_emp_trabajo { get; set; }
        public int id_trabajo { get; set; }
        public long id_empleado { get; set; }
        public string txt_nombre { get; set; }
    }
}
