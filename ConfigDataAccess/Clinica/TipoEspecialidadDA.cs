using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess.Clinica
{
    public class TipoEspecialidadDA
    {
        public List<CLIt06_tipo_especialidad> ListaTipoEspecialidad(int? id_estado = null)
        {
            var lista = new List<CLIt06_tipo_especialidad>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM CLIt06_tipo_especialidad"
                : @"SELECT * FROM CLIt06_tipo_especialidad WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<CLIt06_tipo_especialidad>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Especialiad Médica: ", e.Message);
                }
            }
            return lista;
        }
    }
}
