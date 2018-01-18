using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess;

namespace ConfigBusinessLogic
{
    public class ClaseProdBL
    {
        public int InsertarClase(PROt06_clase_prod obj)
        {
            return new ClaseProdDA().InsertarClase(obj);
        }

        public void EliminarClase(int id)
        {
            new ClaseProdDA().EliminarClase(id);
        }

        public void ActualizarClase(PROt06_clase_prod obj)
        {
            new ClaseProdDA().ActualizarClase(obj);
        }

        public PROt06_clase_prod ClaseXId(int id)
        {
            return new ClaseProdDA().ClaseXId(id);
        }

        public PROt06_clase_prod ClaseProdXCod(string cod)
        {
            return new ClaseProdDA().ClaseProdXCod(cod);
        }

        public List<PROt06_clase_prod> ListaClaseProd(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new ClaseProdDA().ListaClaseProd(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_clase_prod == Parameter.BlankRegister);
            }
            return lista;
        }

        public List<PROt06_clase_prod> ListaClaseProdXGrupo(int id_grupo_prod, int? id_estado = null, bool enableTopList = false)
        {
            var list = new ClaseProdDA().ListaClaseProdXGrupo(id_grupo_prod, id_estado);

            if (list != null)
                return list.OrderBy(x => x.txt_desc).ToList();

            return list;
        }

    }
}
