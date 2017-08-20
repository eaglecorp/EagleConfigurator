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
    public class ModalidadFormativaDA
    {
        public List<SNTt26_modalidad_formativa> ListaModalidadFormativa(int? id_estado = null)
        {
            var lista = new List<SNTt26_modalidad_formativa>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt26_modalidad_formativa"
                : @"SELECT * FROM SNTt26_modalidad_formativa WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt26_modalidad_formativa>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Modalidades Formativas: ", e.Message);
                }
            }
            return lista;
        }
    }
}
