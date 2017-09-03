using ConfigBusinessEntity;
using ConfigDataAccess.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Producto
{
    public class ComboGrupoBL
    {
        public List<PROt17_combo_grupo> ListaComboGrupo(int? id_estado = null)
        {
            return new ComboGrupoDA().ListaComboGrupo(id_estado);
        }
        public int InsertarComboGrupo(PROt17_combo_grupo obj)
        {
            return new ComboGrupoDA().InsertarComboGrupo(obj);
        }
        public void EliminarComboGrupo(int id)
        {
            new ComboGrupoDA().EliminarComboGrupo(id);
        }
        public void ActualizarComboGrupo(PROt17_combo_grupo actualizado)
        {
            new ComboGrupoDA().ActualizarComboGrupo(actualizado);
        }
        public PROt17_combo_grupo ComboGrupoXId(int id)
        {
            return new ComboGrupoDA().ComboGrupoXId(id);
        }
        public PROt17_combo_grupo ComboGrupoXCod(string cod)
        {
            return new ComboGrupoDA().ComboGrupoXCod(cod);
        }
    }
}
