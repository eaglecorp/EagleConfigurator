using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess.Sunat
{
    public class PeriodoRemuneracionDA
    {
        public List<SNTt22_periodo_remuneracion> ListaPeriodoRemuneracion(int? id_estado = null)
        {
            var lista = new List<SNTt22_periodo_remuneracion>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt22_periodo_remuneracion"
                : @"SELECT * FROM SNTt22_periodo_remuneracion WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt22_periodo_remuneracion>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Periodos de Remuneración: ", e.Message);
                }
            }
            return lista;
        }
    }
}
