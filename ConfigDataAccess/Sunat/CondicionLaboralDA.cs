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
    public class CondicionLaboralDA
    {
        public List<SNTt21_condicion_laboral> ListaCondicionLaboral(int? id_estado = null)
        {
            var lista = new List<SNTt21_condicion_laboral>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM SNTt21_condicion_laboral"
                                            : @"SELECT * FROM SNTt21_condicion_laboral WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt21_condicion_laboral>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Condiciones Laborales: ", e.Message);
                }
            }
            return lista;
        }
    }
}
