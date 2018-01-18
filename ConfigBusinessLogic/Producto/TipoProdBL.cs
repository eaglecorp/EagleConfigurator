using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess;
using ConfigUtilitarios;

namespace ConfigBusinessLogic
{
    public class TipoProdBL
    {
        public int InsertarTipoProd(PROt07_tipo_prod obj)
        {
            return new TipoProdDA().InsertarTipoProd(obj);
        }

        public void EliminarTipoProd(int id)
        {
            new TipoProdDA().EliminarTipoProd(id);
        }

        public void ActualizarTipoProd(PROt07_tipo_prod obj)
        {
            new TipoProdDA().ActualizarTipoProd(obj);
        }

        public PROt07_tipo_prod TipoProdXId(int id)
        {
            return new TipoProdDA().TipoProdXId(id);
        }

        public PROt07_tipo_prod TipoProdXCod(string cod)
        {
            return new TipoProdDA().TipoProdXCod(cod);
        }

        public List<PROt07_tipo_prod> ListaTipoProd(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new TipoProdDA().ListaTipoProd(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_tipo_prod == Parameter.BlankRegister);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_tipo_prod != TopList.TipoProd).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
    }
}
