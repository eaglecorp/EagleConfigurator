using ConfigBusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess.Sunat
{
    public class TipoMedioPagoDA
    {
        public List<SNTt01_tipo_medio_pago> ListaTipoMedioPago(int? id_estado = null)
        {
            var lista = new List<SNTt01_tipo_medio_pago>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt01_tipo_medio_pago"
                : @"SELECT * FROM SNTt01_tipo_medio_pago WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt01_tipo_medio_pago>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Tipos de Medios de Pago: ", e.Message);
                }
            }
            return lista;
        }
    }
}
