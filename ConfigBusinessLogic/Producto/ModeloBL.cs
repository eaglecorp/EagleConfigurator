using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess;


namespace ConfigBusinessLogic
{
    public class ModeloBL
    {

        public int InsertarModelo(PROt02_modelo obj)
        {
            return new ModeloDA().InsertarModelo(obj);
        }

        public void EliminarModelo(int id)
        {
            new ModeloDA().EliminarModelo(id);
        }

        public void ActualizarModelo(PROt02_modelo obj)
        {
            new ModeloDA().ActualizarModelo(obj);
        }

        public PROt02_modelo ModeloXId(int id)
        {
            return new ModeloDA().ModeloXId(id);
        }

        public PROt02_modelo ModeloXCod(string cod)
        {
            return new ModeloDA().ModeloXCod(cod);
        }

        public List<PROt02_modelo> ListaModelo(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new ModeloDA().ListaModelo(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_modelo == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_modelo > 0)
                    lista.Remove(itemToRemove);
            }
            return lista;
        }

        public List<PROt02_modelo> ListaModeloXMarca(int id_marca, int? id_estado = null)
        {
            var list = new ModeloDA().ListaModeloXMarca(id_marca, id_estado);

            if (list != null)
                return list.OrderBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
