using System;
using System.Collections.Generic;
using System.Linq;
using ConfigBusinessEntity;
using Dapper;
using System.Data.SqlClient;
using ConfigUtilitarios;

namespace ConfigDataAccess
{
    public class TipoMonedaDA
    {
        public List<SNTt04_tipo_moneda> ListaTipoMoneda(int? id_estado = null)
        {
            var lista = new List<SNTt04_tipo_moneda>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt04_tipo_moneda" :
                @"SELECT * FROM SNTt04_tipo_moneda WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt04_tipo_moneda>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Tipos de Moneda: ", e.Message);
                }
            }
            return lista;
        }

    }
}
