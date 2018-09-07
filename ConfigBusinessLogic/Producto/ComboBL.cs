using ConfigBusinessEntity;
using ConfigDataAccess.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Producto
{
    public class ComboBL
    {
        public List<PROt13_combo> ListaCombo(int? id_estado = null)
        {
            return new ComboDA().ListaCombo(id_estado);
        }
        public long InsertarCombo(PROt13_combo obj)
        {
            return new ComboDA().InsertarCombo(obj);
        }
        public void EliminarCombo(long id)
        {
            new ComboDA().EliminarCombo(id);
        }
        public void ActualizarCombo(PROt13_combo actualizado)
        {
            new ComboDA().ActualizarCombo(actualizado);
        }
        public PROt13_combo ComboXId(long id)
        {
            return new ComboDA().ComboXId(id);
        }
        public PROt13_combo ComboXCod(string cod)
        {
            return new ComboDA().ComboXCod(cod);
        }
        public PROt13_combo GetIdPorcentajeDeCombo(long id_combo)
        {
            return new ComboDA().GetIdPorcentajeDeCombo(id_combo);
        }
    }
}
