using ConfigBusinessEntity;
using ConfigDataAccess.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Maestro
{
    public class DescuentoBL
    {
        public int InsertarDescuento(MSTt02_descuento obj)
        {
            return new DescuentoDA().InsertarDescuento(obj);
        }

        public void EliminarDescuento(int id)
        {
            new DescuentoDA().EliminarDescuento(id);
        }

        public void ActualizarDescuento(MSTt02_descuento obj)
        {
            new DescuentoDA().ActualizarDescuento(obj);
        }

        public MSTt02_descuento DescuentoXId(int id)
        {
            return new DescuentoDA().DescuentoXId(id);
        }

        public MSTt02_descuento DescuentoXCod(string cod)
        {
            return new DescuentoDA().DescuentoXCod(cod);
        }

        public List<MSTt02_descuento> ListaDescuento(int? id_estado = null)
        {
            return new DescuentoDA().ListaDescuento(id_estado);
        }
    }
}
