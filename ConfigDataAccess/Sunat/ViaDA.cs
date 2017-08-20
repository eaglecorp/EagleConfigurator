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
    public class ViaDA
    {
        public List<SNTt15_via> ListaVia(int? id_estado = null)
        {
            var lista = new List<SNTt15_via>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt15_via"
                : @"SELECT * FROM SNTt15_via WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt15_via>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Vías: ", e.Message);
                }
            }
            return lista;
        }
    }
}
