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
    public class EstadoMesaBL
    {
        public int InsertarEstadoMesa(MSTt15_estado_mesa obj)
        {
            return new EstadoMesaDA().InsertarEstadoMesa(obj);
        }
        public void EliminarEstadoMesa(int id)
        {
            new EstadoMesaDA().EliminarEstadoMesa(id);
        }
        public void ActualizarEstadoMesa(MSTt15_estado_mesa actualizado)
        {
            new EstadoMesaDA().ActualizarEstadoMesa(actualizado);
        }
        public MSTt15_estado_mesa EstadoMesaXId(int id)
        {
            return new EstadoMesaDA().EstadoMesaXId(id);
        }
        public MSTt15_estado_mesa EstadoMesaXCod(string cod)
        {
            return new EstadoMesaDA().EstadoMesaXCod(cod);
        }
        public List<MSTt15_estado_mesa> ListaEstadoMesa(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new EstadoMesaDA().ListaEstadoMesa(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_estado_mesa == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_estado_mesa > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_estado_mesa != TopList.EstadoMesa).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
    }
}
