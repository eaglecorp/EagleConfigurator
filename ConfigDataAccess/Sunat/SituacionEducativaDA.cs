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
    public class SituacionEducativaDA
    {
        public List<SNTt18_situacion_educativa> ListaSituacionEducativa(int? id_estado = null)
        {
            var lista = new List<SNTt18_situacion_educativa>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt18_situacion_educativa"
                : @"SELECT * FROM SNTt18_situacion_educativa WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt18_situacion_educativa>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Situaciones Educativas: ", e.Message);
                }
            }
            return lista;
        }
    }
}
