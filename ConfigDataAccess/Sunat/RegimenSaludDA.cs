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
    public class RegimenSaludDA
    {
        public List<SNTt29_regimen_salud> ListaRegimenSalud(int? id_estado = null)
        {
            var lista = new List<SNTt29_regimen_salud>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt29_regimen_salud"
                : @"SELECT * FROM SNTt29_regimen_salud WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt29_regimen_salud>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Regímenes de Salud: ", e.Message);
                }
            }
            return lista;
        }
    }
}
