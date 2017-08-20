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
    public class GrupoProdBL
    {
        public int InsertarGrupo(PROt05_grupo_prod obj)
        {
            return new GrupoProdDA().InsertarGrupo(obj);
        }

        public void EliminarGrupo(int id)
        {
            new GrupoProdDA().EliminarGrupo(id);
        }

        public void ActualizarGrupo(PROt05_grupo_prod obj)
        {
            new GrupoProdDA().ActualizarGrupo(obj);
        }

        public PROt05_grupo_prod GrupoXId(int id)
        {
            return new GrupoProdDA().GrupoXId(id);
        }

        public PROt05_grupo_prod GrupoProdXCod(string cod)
        {
            return new GrupoProdDA().GrupoProdXCod(cod);
        }

        public List<PROt05_grupo_prod> ListaGrupoProd(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new GrupoProdDA().ListaGrupoProd(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_grupo_prod == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_grupo_prod > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_grupo_prod != TopList.GrupoProd).ThenBy(x => x.txt_desc).ToList();

            return lista;
        }
    }
}
