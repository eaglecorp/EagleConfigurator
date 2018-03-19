using ConfigBusinessEntity;
using ConfigDataAccess.Persona;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Persona
{
    public class TrabajoBL
    {
        public List<LABt06_trabajo> ListaTrabajo(int? id_estado = null,  bool order = false)
        {
            
            var lista = new TrabajoDA().ListaTrabajo(id_estado);

            if (order && lista != null && lista.Count > 0)
                return lista.OrderBy(x => x.txt_nombre).ToList();

            return lista;
        }
        public int InsertarTrabajo(LABt06_trabajo obj)
        {
            return new TrabajoDA().InsertarTrabajo(obj);
        }
        public void EliminarTrabajo(int id)
        {
            new TrabajoDA().EliminarTrabajo(id);
        }
        public void ActualizarTrabajo(LABt06_trabajo actualizado)
        {
            new TrabajoDA().ActualizarTrabajo(actualizado);
        }
        public LABt06_trabajo TrabajoXId(int id)
        {
            return new TrabajoDA().TrabajoXId(id);
        }
        public LABt06_trabajo TrabajoXCod(string cod)
        {
            return new TrabajoDA().TrabajoXCod(cod);
        }
    }
}
