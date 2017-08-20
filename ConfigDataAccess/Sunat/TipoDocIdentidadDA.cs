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
    public class TipoDocIdentidadDA
    {
        public List<SNTt02_tipo_doc_identidad> ListaTipoDocIdentidad(int? id_estado = null)
        {
            var lista = new List<SNTt02_tipo_doc_identidad>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? 
                @"SELECT * FROM SNTt02_tipo_doc_identidad" 
                : @"SELECT * FROM SNTt02_tipo_doc_identidad WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt02_tipo_doc_identidad>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Tipos de Documentos de Identidad: ", e.Message);
                }
            }
            return lista;
        }
    }
}
