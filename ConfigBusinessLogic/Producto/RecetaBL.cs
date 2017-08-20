using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess;

namespace ConfigBusinessLogic
{
    public class RecetaBL
    {
        public List<PROt10_receta> ListaReceta(int? id_estado = null)
        {
            return new RecetaDA().ListaReceta(id_estado);
        }
    }
}
