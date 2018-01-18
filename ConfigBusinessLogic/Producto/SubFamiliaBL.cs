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
    public class SubFamiliaBL
    {
        public int InsertarSubFam(PROt04_subfamilia obj)
        {
            return new SubFamiliaDA().InsertarSubFam(obj);
        }

        public void EliminarSubFam(int id)
        {
            new SubFamiliaDA().EliminarSubFam(id);
        }

        public void ActualizarSubFam(PROt04_subfamilia obj)
        {
            new SubFamiliaDA().ActualizarSubFam(obj);
        }

        public PROt04_subfamilia SubFamiliaXId(int id)
        {
            return new SubFamiliaDA().SubFamiliaXId(id);
        }

        public PROt04_subfamilia SubFamiliaXCod(string cod)
        {
            return new SubFamiliaDA().SubFamiliaXCod(cod);
        }

        public List<PROt04_subfamilia> ListaSubFamilia(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new SubFamiliaDA().ListaSubFamilia(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_subfamilia == Parameter.BlankRegister);
            }
            return lista;
        }

        public List<PROt04_subfamilia> ListaSubFamXFam(int id_familia, int? id_estado = null)
        {
            var list = new SubFamiliaDA().ListaSubFamXFam(id_familia, id_estado);

            if (list != null)
                return list.OrderBy(x => x.txt_desc).ToList();

            return list;

        }
    }
}
