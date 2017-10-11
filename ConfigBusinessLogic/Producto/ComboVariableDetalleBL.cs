using ConfigDataAccess.Producto;
using ConfigUtilitarios.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Producto
{
    public class ComboVariableDetalleBL
    {

        public List<ComboItem> ListaDetalleXCboVar(long id_cbo_var)
        {
            return new ComboVariableDetalleDA().ListaDetalleXCboVar(id_cbo_var);
        }
    }
}
