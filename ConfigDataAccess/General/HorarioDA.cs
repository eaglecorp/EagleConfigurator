using ConfigBusinessEntity;
using Dapper;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.General
{
    public class HorarioDA
    {
        public List<GRLt03_horario> ListaHorario()
        {
            var lista = new List<GRLt03_horario>();
            string sentencia = @"SELECT * FROM GRLt03_horario";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<GRLt03_horario>(sentencia).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Horario: ", e.Message);
                }
            }
            return lista;
        }
    }
}
