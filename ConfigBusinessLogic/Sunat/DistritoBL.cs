using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess.Sunat;

namespace ConfigBusinessLogic.Sunat
{
    public class DistritoBL
    {
        public List<SNTt33_distrito> ListaDistritoXProv(int id, int? id_estado=null)
        {
            var list = new DistritoDA().ListaDistritoXProv(id,id_estado);
            if (list != null)
                return list.OrderBy(x => x.txt_desc).ToList();

            return list;
        }
    }
}
