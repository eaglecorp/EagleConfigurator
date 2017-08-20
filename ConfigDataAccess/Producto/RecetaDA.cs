using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using System.Data.SqlClient;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess
{
    public class RecetaDA
    {
        public List<PROt10_receta> ListaReceta(int? id_estado = null)
        {
            var lista = new List<PROt10_receta>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PROt10_receta" : @"SELECT * FROM PROt10_receta WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PROt10_receta>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Recetas: ", e.Message);
                }
            }
            return lista;
        }
    }
}
