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
    public class NacionalidadDA
    {
        public List<SNTt14_nacionalidad> ListaNacionalidad(int? id_estado = null)
        {
            var lista = new List<SNTt14_nacionalidad>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt14_nacionalidad"
                : @"SELECT * FROM SNTt14_nacionalidad WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt14_nacionalidad>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Nacionalidades: ", e.Message);
                }
            }
            return lista;
        }
    }
}
