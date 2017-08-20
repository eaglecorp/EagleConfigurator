using ConfigBusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using ConfigUtilitarios;

namespace ConfigDataAccess.Maestro
{
    public class EstadoCivilDA
    {
        public List<MSTt07_estado_civil> ListaEstadoCivil(int? id_estado = null)
        {
            var lista = new List<MSTt07_estado_civil>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt07_estado_civil"
                : @"SELECT * FROM MSTt07_estado_civil WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt07_estado_civil>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Estado Civil: ", e.Message);
                }
            }
            return lista;
        }
    }
}
