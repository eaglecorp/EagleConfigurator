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
        public int InsertarComboVariable(PROt15_combo_variable obj)
        {
            return new ComboVariableDA().InsertarComboVariable(obj);
        }
        public void EliminarComboVariable(int id)
        {
            new ComboVariableDA().EliminarComboVariable(id);
        }
        public void ActualizarComboVariable(PROt15_combo_variable actualizado)
        {
            new ComboVariableDA().ActualizarComboVariable(actualizado);
        }
        public PROt15_combo_variable ComboVariableXId(int id)
        {
           return new ComboVariableDA().ComboVariableXId(id);
        }
        public PROt15_combo_variable ComboVariableXCod(string cod)
        {
           return new ComboVariableDA().ComboVariableXCod(cod);
        }
    }
}
