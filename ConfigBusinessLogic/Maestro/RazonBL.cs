using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class RazonBL
    {
        public int InsertarRazon(MSTt05_razon obj)
        {
            return new RazonDA().InsertarRazon(obj);
        }

        public void EliminarRazon(int id)
        {
            new RazonDA().EliminarRazon(id);
        }

        public void ActualizarRazon(MSTt05_razon obj)
        {
            new RazonDA().ActualizarRazon(obj);
        }

        public MSTt05_razon RazonXId(int id)
        {
            return new RazonDA().RazonXId(id);
        }

        public MSTt05_razon RazonXCod(string cod)
        {
            return new RazonDA().RazonXCod(cod);
        }

        public List<MSTt05_razon> ListaRazon(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new RazonDA().ListaRazon(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_razon == Parameter.BlankRegister);
            }

            return lista;
        }
    }
}
