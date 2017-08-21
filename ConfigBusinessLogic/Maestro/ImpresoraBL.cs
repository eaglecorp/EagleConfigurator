using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class ImpresoraBL
    {
        public List<MSTt10_impresora> ListaImpresora(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {

            var lista = new ImpresoraDA().ListaImpresora(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_impresora == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_impresora > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_impresora != TopList.Impresora).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
        public int InsertarImpresora(MSTt10_impresora obj)
        {
            return new ImpresoraDA().InsertarImpresora(obj);
        }
        public void EliminarImpresora(int id)
        {
            new ImpresoraDA().EliminarImpresora(id);
        }
        public void ActualizarImpresora(MSTt10_impresora actualizado)
        {
            new ImpresoraDA().ActualizarImpresora(actualizado);
        }
        public MSTt10_impresora ImpresoraXId(int id)
        {
            return new ImpresoraDA().ImpresoraXId(id);
        }
        public MSTt10_impresora ImpresoraXCod(string cod)
        {
            return new ImpresoraDA().ImpresoraXCod(cod);
        }
    }
}
