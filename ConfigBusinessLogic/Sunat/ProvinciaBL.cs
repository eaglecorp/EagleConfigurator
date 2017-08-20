using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess.Sunat;

namespace ConfigBusinessLogic.Sunat
{
    public class ProvinciaBL
    {
        public List<SNTt32_provincia> ListaProvinciaXDep(int id, int? id_estado = null)
        {
            var list = new ProvinciaDA().ListaProvinciaXDep(id, id_estado);
            if (list != null)
                return list.OrderBy(x => x.txt_desc).ToList();

            return list;
        }

        public SNTt32_provincia ProvinciaXId(int id)
        {
            return new ProvinciaDA().ProvinciaXId(id);
        }

    }
}
