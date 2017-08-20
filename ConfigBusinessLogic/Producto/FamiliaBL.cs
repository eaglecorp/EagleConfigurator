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
    public class FamiliaBL
    {
        public int InsertarFamilia(PROt03_familia obj)
        {
            return new FamiliaDA().InsertarFamilia(obj);
        }

        public void EliminarFamilia(int id)
        {
            new FamiliaDA().EliminarFamilia(id);
        }

        public void ActualizarFamilia(PROt03_familia obj)
        {
            new FamiliaDA().ActualizarFamilia(obj);
        }

        public PROt03_familia FamiliaXId(int id)
        {
            return new FamiliaDA().FamiliaXId(id);
        }

        public PROt03_familia FamiliaXCod(string cod)
        {
            return new FamiliaDA().FamiliaXCod(cod);
        }

        public List<PROt03_familia> ListaFamiliaProd(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new FamiliaDA().ListaFamiliaProd(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_familia == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_familia > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_familia != TopList.Familia).ThenBy(x => x.txt_desc).ToList();


            return lista;
        }

        public List<PROt03_familia> ListaFamConSubFam()
        {
            return new FamiliaDA().ListaFamConSubFam();
        }


    }
}
