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
            return OrdenarConfigDeCajaPorCod(new CajaDA().CajaXId(id));
        }
        public MSTt12_caja CajaXCod(string cod)
        {
            return OrdenarConfigDeCajaPorCod(new CajaDA().CajaXCod(cod));
        }

        private MSTt12_caja OrdenarConfigDeCajaPorCod(MSTt12_caja caja)
        {
            try
            {
                if (caja == null ||
                       caja.FISt05_configuracion_fiscal_caja == null ||
                       caja.FISt05_configuracion_fiscal_caja.Count == 0)
                {
                    return caja;
                }

                caja.FISt05_configuracion_fiscal_caja = caja.FISt05_configuracion_fiscal_caja.
                                                            OrderBy(x => x.FISt04_parametro_fiscal.cod_parametro_fiscal).
                                                            ToList();

                return caja;
            }
            catch
            {
                return caja;
            }
        }
    }
}
