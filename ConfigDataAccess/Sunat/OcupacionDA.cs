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
    public class OcupacionDA
    {
        public List<SNTt19_ocupacion> ListaOcupacion(int? id_estado = null)
        {
            var lista = new List<SNTt19_ocupacion>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt19_ocupacion"
                : @"SELECT * FROM SNTt19_ocupacion WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt19_ocupacion>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Ocupaciones: ", e.Message);
                }
            }
            return lista;
        }
    }
}
