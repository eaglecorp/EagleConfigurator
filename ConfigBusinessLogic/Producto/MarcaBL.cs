using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess;
using ConfigUtilitarios;

namespace ConfigBusinessLogic
{
    public class MarcaBL
    {
        public int InsertarMarca(PROt01_marca obj)
        {
            return new MarcaDA().InsertarMarca(obj);
        }

        public void EliminarMarca(int id)
        {
            new MarcaDA().EliminarMarca(id);
        }

        public void ActualizarMarca(PROt01_marca obj)
        {
            new MarcaDA().ActualizarMarca(obj);
        }

        public PROt01_marca MarcaXId(int id)
        {
            return new MarcaDA().MarcaXId(id);
        }

        public PROt01_marca MarcaXCod(string cod)
        {
            return new MarcaDA().MarcaXCod(cod);
        }

        public List<PROt01_marca> ListaMarca(int? id_estado=null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new MarcaDA().ListaMarca(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_marca == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_marca > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_marca != TopList.Marca).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
    }
}
