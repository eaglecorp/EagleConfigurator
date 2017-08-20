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
    public class EntidadFinancieraDA
    {
        public List<SNTt03_entidad_financiera> ListaEntidadFinanciera(int? id_estado = null)
        {
            var lista = new List<SNTt03_entidad_financiera>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt03_entidad_financiera"
                : @"SELECT * FROM SNTt03_entidad_financiera WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt03_entidad_financiera>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Entidades Financieras: ", e.Message);
                }
            }
            return lista;
        }
    }
}
