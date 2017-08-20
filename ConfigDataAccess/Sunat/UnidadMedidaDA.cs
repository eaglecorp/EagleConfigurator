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
    public class UnidadMedidaDA
    {
        public List<SNTt06_unidad_medida> ListaUnidadMed(int? id_estado = null)
        {
            var lista = new List<SNTt06_unidad_medida>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt06_unidad_medida" :
                @"SELECT * FROM SNTt06_unidad_medida WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt06_unidad_medida>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Unidades de medida: ", e.Message);
                }
            }
            return lista;
        }

    }
}
