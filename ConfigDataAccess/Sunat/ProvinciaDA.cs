using ConfigBusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess.Sunat
{
    public class ProvinciaDA
    {

        public List<SNTt32_provincia> ListaProvinciaXDep(int id, int? id_estado=null)
        {
            var lista = new List<SNTt32_provincia>();
            string sentencia = string.Empty;
           sentencia = (id_estado==null)?  @"SELECT * FROM SNTt32_provincia WHERE id_dpto=@id"
                                    : @"SELECT * FROM SNTt32_provincia WHERE id_dpto=@id AND id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<SNTt32_provincia>(sentencia, new { id , id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Provincias por Departamento: ", e.Message);
                }
            }
            return lista;
        }

        public SNTt32_provincia ProvinciaXId(int id)
        {
            var obj = new SNTt32_provincia();
            string sentencia = @"SELECT * FROM SNTt32_provincia WHERE id_prov=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<SNTt32_provincia>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Provincia por ID: ", e.Message);
                }
            }
            return obj;
        }
    }
}
