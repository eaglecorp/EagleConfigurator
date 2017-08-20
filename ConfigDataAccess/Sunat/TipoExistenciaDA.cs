using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using Dapper;
using System.Data.SqlClient;
using ConfigUtilitarios;

namespace ConfigDataAccess
{
    public class TipoExistenciaDA
    {
        public List<SNTt05_tipo_existencia> ListaTipoExistencia(int? id_estado = null)
        {
            var lista = new List<SNTt05_tipo_existencia>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt05_tipo_existencia" :
                @"SELECT * FROM SNTt05_tipo_existencia WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt05_tipo_existencia>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Tipos de Existencia: ", e.Message);
                }
            }
            return lista;
        }

    }
}
