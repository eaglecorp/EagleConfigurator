using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class LocationBL
    {
        public int InsertarLocation(MSTt08_location obj)
        {
            return new LocationDA().InsertarLocation(obj);
        }

        public void EliminarLocation(int id)
        {
            new LocationDA().EliminarLocation(id);
        }

        public void ActualizarLocation(MSTt08_location obj)
        {
            new LocationDA().ActualizarLocation(obj);
        }

        public MSTt08_location LocationXId(int id)
        {
            return new LocationDA().LocationXId(id);
        }

        public MSTt08_location LocationXCod(string cod)
        {
            return new LocationDA().LocationXCod(cod);
        }

        public List<MSTt08_location> ListaLocation(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new LocationDA().ListaLocation(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_location == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_location > 0)
                    lista.Remove(itemToRemove);
            }

            return lista;
        }
    }
}
