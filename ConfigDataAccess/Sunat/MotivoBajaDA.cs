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
    public class MotivoBajaDA
    {
        public List<SNTt25_motivo_baja> ListaMotivoBaja(int? id_estado = null)
        {
            var lista = new List<SNTt25_motivo_baja>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt25_motivo_baja"
                : @"SELECT * FROM SNTt25_motivo_baja WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt25_motivo_baja>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Motivos de Baja: ", e.Message);
                }
            }
            return lista;
        }
    }
}
