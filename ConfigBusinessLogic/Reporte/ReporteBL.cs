using ConfigBusinessEntity;
using ConfigDataAccess.Reporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Reporte
{
    public class ReporteBL
    {
        public int InsertarReporte(RPTt01_reporte obj)
        {
            return new ReporteDA().InsertarReporte(obj);
        }
        public void EliminarReporte(int id)
        {
            new ReporteDA().EliminarReporte(id);
        }
        public void ActualizarReporte(RPTt01_reporte actualizado)
        {
            new ReporteDA().ActualizarReporte(actualizado);
        }
        public RPTt01_reporte ReporteXId(int id)
        {
            return new ReporteDA().ReporteXId(id);
        }
        public RPTt01_reporte ReporteXCod(string cod)
        {
            return new ReporteDA().ReporteXCod(cod);
        }
        public List<RPTt01_reporte> ListaReporte(int? id_estado = null)
        {
            return new ReporteDA().ListaReporte(id_estado);
        }
    }
}
