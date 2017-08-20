using ConfigBusinessEntity;
using ConfigDataAccess.Reporte;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Reporte
{
    public class CategoriaReporteBL
    {
        public int InsertarCategoriaReporte(RPTt02_categoria_reporte obj)
        {
            return new CategoriaReporteDA().InsertarCategoriaReporte(obj);
        }
        public void EliminarCategoriaReporte(int id)
        {
            new CategoriaReporteDA().EliminarCategoriaReporte(id);
        }
        public void ActualizarCategoriaReporte(RPTt02_categoria_reporte actualizado)
        {
            new CategoriaReporteDA().ActualizarCategoriaReporte(actualizado);
        }
        public RPTt02_categoria_reporte CategoriaReporteXId(int id)
        {
            return new CategoriaReporteDA().CategoriaReporteXId(id);
        }
        public RPTt02_categoria_reporte CategoriaReporteXCod(string cod)
        {
            return new CategoriaReporteDA().CategoriaReporteXCod(cod);
        }
        public List<RPTt02_categoria_reporte> ListaCategoriaReporte(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new CategoriaReporteDA().ListaCategoriaReporte(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_categoria_reporte == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_categoria_reporte > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_categoria_reporte != TopList.CategoriaReporte).ThenBy(x => x.txt_desc).ToList();


            return lista;
        }
    }
}
