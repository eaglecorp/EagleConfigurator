using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class TipoImpresoraBL
    {
        public int InsertarTipoImpresora(MSTt11_tipo_impresora obj)
        {
            return new TipoImpresoraDA().InsertarTipoImpresora(obj);
        }
        public void EliminarTipoImpresora(int id)
        {
            new TipoImpresoraDA().EliminarTipoImpresora(id);
        }
        public void ActualizarTipoImpresora(MSTt11_tipo_impresora actualizado)
        {
            new TipoImpresoraDA().ActualizarTipoImpresora(actualizado);
        }
        public MSTt11_tipo_impresora TipoImpresoraXId(int id)
        {
            return new TipoImpresoraDA().TipoImpresoraXId(id);
        }
        public MSTt11_tipo_impresora TipoImpresoraXCod(string cod)
        {
            return new TipoImpresoraDA().TipoImpresoraXCod(cod);
        }
        public List<MSTt11_tipo_impresora> ListaTipoImpresora(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new TipoImpresoraDA().ListaTipoImpresora(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_tipo_impresora == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_tipo_impresora > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_tipo_impresora != TopList.TipoImpresora).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
    }
}
