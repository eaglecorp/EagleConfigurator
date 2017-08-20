using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using System.Data.SqlClient;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess.Sunat
{
    public class DistritoDA
    {
        public List<SNTt33_distrito> ListaDistritoXProv(int id, int? id_estado = null)
        {
            var lista = new List<SNTt33_distrito>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
               @"SELECT * FROM SNTt33_distrito WHERE id_prov=@id"
               : @"SELECT * FROM SNTt33_distrito WHERE id_prov=@id AND id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt33_distrito>(sentencia, new { id, id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Distritos por Provincia: ", e.Message);
                }
            }
            return lista;
        }
    }
}
