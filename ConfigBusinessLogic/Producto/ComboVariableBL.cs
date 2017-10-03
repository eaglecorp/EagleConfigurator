using ConfigBusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using ConfigDataAccess.Producto;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Producto
{
    public class ComboVariableBL
    {
        public List<PROt15_combo_variable> ListaComboVariable(int? id_estado = null)
        {
            return new ComboVariableDA().ListaComboVariable(id_estado);
        }
        public long InsertarComboVariable(PROt15_combo_variable obj)
        {
            return new ComboVariableDA().InsertarComboVariable(obj);
        }
        public void EliminarComboVariable(long id)
        {
            new ComboVariableDA().EliminarComboVariable(id);
        }
        public void ActualizarComboVariable(PROt15_combo_variable actualizado)
        {
            new ComboVariableDA().ActualizarComboVariable(actualizado);
        }
        public PROt15_combo_variable ComboVariableXId(long id)
        {
           return new ComboVariableDA().ComboVariableXId(id);
        }
        public PROt15_combo_variable ComboVariableXCod(string cod)
        {
           return new ComboVariableDA().ComboVariableXCod(cod);
        }

        public IEnumerable<PROt15_combo_variable> BuscarComboVariable(string cod, string descripcion, int? id_estado)
        {
            return new ComboVariableDA().BuscarComboVariable(cod, descripcion, id_estado);
        }
    }
}
