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
    public class MesaBL
    {
        public int InsertarMesa(MSTt14_mesa obj)
        {
            return new MesaDA().InsertarMesa(obj);
        }
        public void CambiarEstadoMesa(int id_mesa, int id_estado_mesa)
        {
            new MesaDA().CambiarEstadoMesa(id_mesa,id_estado_mesa);
        }
        public void ActualizarMesa(MSTt14_mesa actualizado)
        {
            new MesaDA().ActualizarMesa(actualizado);
        }
        public MSTt14_mesa MesaXId(int id)
        {
            return new MesaDA().MesaXId(id);
        }
        public MSTt14_mesa MesaXCod(string cod)
        {
            return new MesaDA().MesaXCod(cod);
        }
        public List<MSTt14_mesa> ListaMesa(int? id_estado_mesa = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new MesaDA().ListaMesa(id_estado_mesa);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_mesa == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_mesa > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_mesa != TopList.Mesa).ThenBy(x => x.txt_num).ToList();

            return lista;
        }
    }
}
