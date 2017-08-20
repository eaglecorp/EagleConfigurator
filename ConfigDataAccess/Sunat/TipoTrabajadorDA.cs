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
    public class TipoTrabajadorDA
    {
        public List<SNTt17_tipo_trabajador> ListaTipoTrabajador(int? id_estado = null)
        {
            var lista = new List<SNTt17_tipo_trabajador>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM SNTt17_tipo_trabajador"
                : @"SELECT * FROM SNTt17_tipo_trabajador WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt17_tipo_trabajador>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Tipos de Trabajor: ", e.Message);
                }
            }
            return lista;
        }
    }
}
