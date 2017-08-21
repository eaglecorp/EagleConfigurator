using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class ImpresoraBL
    {
        public List<MSTt10_impresora> ListaImpresora(int? id_estado = null)
        {
            return new ImpresoraDA().ListaImpresora(id_estado);
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
