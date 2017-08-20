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
    public class EspecialidadMedicaDA
    {
        public List<CLIt07_especialidad_medica> ListaEspcMedicaXTipo(int id_tipo_especialidad, int? id_estado = null)
        {
            var lista = new List<CLIt07_especialidad_medica>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM CLIt07_especialidad_medica WHERE id_tipo_especialidad=@id_tipo_especialidad" :
                @"SELECT * FROM CLIt07_especialidad_medica WHERE id_tipo_especialidad=@id_tipo_especialidad AND id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<CLIt07_especialidad_medica>(sentencia, new { id_tipo_especialidad, id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Especialidad Médica por Tipo de Espcialidad: ", e.Message);
                }
            }
            return lista;
        }
    }
}
