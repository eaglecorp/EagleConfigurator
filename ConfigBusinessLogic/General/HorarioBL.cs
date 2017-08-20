using ConfigBusinessEntity;
using ConfigDataAccess.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.General
{
    public class HorarioBL
    {
         public List<GRLt03_horario> ListaHorario()
        {
            return new HorarioDA().ListaHorario();
        }
    }
}
