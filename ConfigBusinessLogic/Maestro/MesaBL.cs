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
        public int InsertarMesa(MSTt15_mesa obj)
        {
            return new MesaDA().InsertarMesa(obj);
        }
        public void EliminarMesa(int id)
        {
            new MesaDA().EliminarMesa(id);
        }
        public void ActualizarMesa(MSTt15_mesa actualizado)
        {
            new MesaDA().ActualizarMesa(actualizado);
        }
        public MSTt15_mesa MesaXId(int id)
        {
            return new MesaDA().MesaXId(id);
        }
        public MSTt15_mesa MesaXCod(string cod)
        {
            return new MesaDA().MesaXCod(cod);
        }
        public List<MSTt15_mesa> ListaMesa(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new MesaDA().ListaMesa(id_estado);
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
