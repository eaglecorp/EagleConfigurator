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
    public class SaludEpsDA
    {
        public List<SNTt23_salud_eps> ListaSaludEps(int? id_estado = null)
        {
            var lista = new List<SNTt23_salud_eps>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt23_salud_eps"
                : @"SELECT * FROM SNTt23_salud_eps WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt23_salud_eps>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Salud EPS: ", e.Message);
                }
            }
            return lista;
        }
    }
}
