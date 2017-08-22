using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class CajaBL
    {
        public List<MSTt12_caja> ListaCaja(int? id_estado = null)
        {
            return new CajaDA().ListaCaja(id_estado);
        }
        public int InsertarCaja(MSTt12_caja obj)
        {
            return new CajaDA().InsertarCaja(obj);
        }
        public void EliminarCaja(int id)
        {
            new CajaDA().EliminarCaja(id);
        }
        public void ActualizarCaja(MSTt12_caja actualizado)
        {
            new CajaDA().ActualizarCaja(actualizado);
        }
        public MSTt12_caja CajaXId(int id)
        {
            return new CajaDA().CajaXId(id);
        }
        public MSTt12_caja CajaXCod(string cod)
        {
            return new CajaDA().CajaXCod(cod);
        }
    }
}
