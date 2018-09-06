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
    public class ImpuestoBL
    {

        public int InsertarImpuesto(MSTt06_impuesto obj)
        {
            return new ImpuestoDA().InsertarImpuesto(obj);
        }

        public decimal SumarImpuestos(MSTt06_impuesto impto)
        {
            decimal porcImpto = 0;

            if (impto.por_impto01 != null)
            {
                porcImpto += (decimal)impto.por_impto01;
            }
            if (impto.por_impto02 != null)
            {
                porcImpto += (decimal)impto.por_impto02;
            }
            if (impto.por_impto03 != null)
            {
                porcImpto += (decimal)impto.por_impto03;
            }
            if (impto.por_impto04 != null)
            {
                porcImpto += (decimal)impto.por_impto04;
            }
            if (impto.por_impto05 != null)
            {
                porcImpto += (decimal)impto.por_impto05;
            }
            if (impto.por_impto06 != null)
            {
                porcImpto += (decimal)impto.por_impto06;
            }
            if (impto.por_impto07 != null)
            {
                porcImpto += (decimal)impto.por_impto07;
            }
            if (impto.por_impto08 != null)
            {
                porcImpto += (decimal)impto.por_impto08;
            }

            return porcImpto;
        }

        public void EliminarImpuesto(int id)
        {
            new ImpuestoDA().EliminarImpuesto(id);
        }

        public bool ActualizarImpuesto(MSTt06_impuesto obj)
        {
            return new ImpuestoDA().ActualizarImpuesto(obj);
        }

        public MSTt06_impuesto ImpuestoXId(int id)
        {
            return new ImpuestoDA().ImpuestoXId(id);
        }

        public MSTt06_impuesto ImpuestoXCod(string cod)
        {
            return new ImpuestoDA().ImpuestoXCod(cod);
        }

        public List<MSTt06_impuesto> ListaImpuesto(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new ImpuestoDA().ListaImpuesto(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_impuesto == Parameter.BlankRegister);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_impuesto != TopList.Impuesto).ThenBy(x => x.txt_abrv).ToList();

            return lista;
        }


        public decimal? GetPorcentajeAcumulado(int id)
        {
            return new ImpuestoDA().GetPorcentajeAcumulado(id);
        }
    }
}
