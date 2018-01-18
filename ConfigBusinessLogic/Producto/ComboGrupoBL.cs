using ConfigBusinessEntity;
using ConfigDataAccess.Producto;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Producto
{
    public class ComboGrupoBL
    {
        public List<PROt17_combo_grupo> ListaComboGrupo(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new ComboGrupoDA().ListaComboGrupo(id_estado);

            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_combo_grupo == Parameter.BlankRegister);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_combo_grupo != TopList.ComboGrupo).ThenBy(x => x.txt_desc).ToList();

            return lista;
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
