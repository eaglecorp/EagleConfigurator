using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class CanalVentaBL
    {
        public int InsertarCanalVenta(MSTt04_canal_vta obj)
        {
            return new CanalVentaDA().InsertarCanalVenta(obj);
        }

        public void EliminarCanalVenta(int id)
        {
            new CanalVentaDA().EliminarCanalVenta(id);
        }

        public void ActualizarCanalVenta(MSTt04_canal_vta obj)
        {
            new CanalVentaDA().ActualizarCanalVenta(obj);
        }

        public MSTt04_canal_vta CanalVentaXId(int id)
        {
            return new CanalVentaDA().CanalVentaXId(id);
        }

        public MSTt04_canal_vta CanalVentaXCod(string cod)
        {
            return new CanalVentaDA().CanalVentaXCod(cod);
        }

        public List<MSTt04_canal_vta> ListaCanalVenta(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new CanalVentaDA().ListaCanalVenta(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_can_vta == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_can_vta > 0)
                    lista.Remove(itemToRemove);
            }
            return lista;
        }
    }
}
