using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;

namespace ConfigBusinessLogic.Maestro
{
    public class MedioPagoBL
    {
        public int InsertarMedioPago(MSTt01_medio_pago obj)
        {
            return new MedioPagoDA().InsertarMedioPago(obj);
        }

        public void EliminarMedioPago(int id)
        {
            new MedioPagoDA().EliminarMedioPago(id);
        }

        public void ActualizarMedioPago(MSTt01_medio_pago obj)
        {
            new MedioPagoDA().ActualizarMedioPago(obj);
        }

        public MSTt01_medio_pago MedioPagoXId(int id)
        {
            return new MedioPagoDA().MedioPagoXId(id);
        }

        public MSTt01_medio_pago MedioPagoXCod(string cod)
        {
            return new MedioPagoDA().MedioPagoXCod(cod);
        }

        public List<MSTt01_medio_pago> ListaMedioPago(int? id_estado = null, bool ocultarBlankReg = false)
        {

            var lista = new MedioPagoDA().ListaMedioPago(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_medio_pago == Parameter.BlankRegister);
            }
            return lista;
        }
    }
}
