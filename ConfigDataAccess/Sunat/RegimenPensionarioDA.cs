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
    public class RegimenPensionarioDA
    {
        public List<SNTt20_regimen_pensionario> ListaRegimenPensionario(int? id_estado = null)
        {
            var lista = new List<SNTt20_regimen_pensionario>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt20_regimen_pensionario"
                : @"SELECT * FROM SNTt20_regimen_pensionario WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt20_regimen_pensionario>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Regímenes Pensionarios: ", e.Message);
                }
            }
            return lista;
        }
    }
}
