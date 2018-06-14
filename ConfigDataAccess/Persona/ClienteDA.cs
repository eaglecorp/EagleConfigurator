using ConfigBusinessEntity;
using Dapper;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Persona
{
    public class ClienteDA
    {

        public List<PERt02_cliente> ListaCliente(int? id_estado = null)
        {
            var lista = new List<PERt02_cliente>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PERt02_cliente"
                                            : @"SELECT * FROM PERt02_cliente WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PERt02_cliente>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Clientes: ", e.Message);
                }
            }
            return lista;
        }
        public long InsertarCliente(PERt02_cliente obj)
        {
            long id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PERt02_cliente.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_cliente;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Cliente: ", e.Message);
                }
            }
            return id;

        }
        public void EliminarCliente(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PERt02_cliente SET id_estado = @id_estado, txt_estado = @txt_estado Where id_cliente=@id";
                        cmd.Parameters.AddWithValue("@id_estado", id_estado);
                        cmd.Parameters.AddWithValue("@txt_estado", txt_estado);
                        cmd.Parameters.AddWithValue("@id", id);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Eliminar Cliente: ", e.Message);
                }
            }
        }
        public void ActualizarCliente(PERt02_cliente actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PERt02_cliente.Find(actualizado.id_cliente);
                    if (original != null && original.id_cliente > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Cliente: ", e.Message);
                }
            }
        }
        public PERt02_cliente ClienteXId(long id)
        {
            var obj = new PERt02_cliente();
            string sentencia = "SELECT * FROM PERt02_cliente WHERE id_cliente=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt02_cliente>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Cliente por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PERt02_cliente ClienteXCod(string cod)
        {
            var obj = new PERt02_cliente();
            string sentencia = "SELECT * FROM PERt02_cliente WHERE cod_cliente=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt02_cliente>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Cliente por COD: ", e.Message);
                }
            }
            return obj;
        }
        public PERt02_cliente ClienteXIdMM(long id)
        {
            var obj = new PERt02_cliente();
            //obteniendo
            obj = ClienteXId(id);
            const string sentencia =
                    @"SELECT * FROM SNTt02_tipo_doc_identidad WHERE id_tipo_doc_identidad=@id_tipo_doc_identidad
                    SELECT * FROM MSTt07_estado_civil WHERE id_estado_civil=@id_estado_civil
                    SELECT * FROM SNTt15_via WHERE id_via=@id_via
                    SELECT * FROM SNTt16_zona WHERE id_zona=@id_zona
                    SELECT * FROM SNTt14_nacionalidad WHERE id_nacionalidad=@id_nacionalidad
                    SELECT * FROM SNTt33_distrito WHERE id_dist=@id_dist";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    var multi = cnn.QueryMultiple(sentencia, new
                    {
                        id_tipo_doc_identidad = obj.id_tipo_doc_identidad,
                        id_estado_civil = obj.id_estado_civil,
                        id_via = obj.id_via,
                        id_zona = obj.id_zona,
                        id_nacionalidad = obj.id_nacionalidad,
                        id_dist = obj.id_dist
                    });

                    var tipoDocIden = multi.Read<SNTt02_tipo_doc_identidad>().FirstOrDefault();
                    var estadoCivil = multi.Read<MSTt07_estado_civil>().FirstOrDefault();
                    var via = multi.Read<SNTt15_via>().FirstOrDefault();
                    var zona = multi.Read<SNTt16_zona>().FirstOrDefault();
                    var nacionalidad = multi.Read<SNTt14_nacionalidad>().FirstOrDefault();
                    var distrito = multi.Read<SNTt33_distrito>().FirstOrDefault();

                    obj.SNTt02_tipo_doc_identidad = tipoDocIden;
                    obj.MSTt07_estado_civil = estadoCivil;
                    obj.SNTt15_via = via;
                    obj.SNTt16_zona = zona;
                    obj.SNTt14_nacionalidad = nacionalidad;
                    obj.SNTt33_distrito = distrito;

                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Cliente MM por ID: ", e.Message);
                }
            }
            return obj;
        }

        public PERt02_cliente ClienteViewXId(long id)
        {
            var obj = new PERt02_cliente();
            //obteniendo
            obj = ClienteXId(id);
            const string sentencia =
                    @"SELECT * FROM SNTt33_distrito WHERE id_dist=@id_dist";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    var multi = cnn.QueryMultiple(sentencia, new
                    {
                        id_dist = obj.id_dist
                    });

                    var distrito = multi.Read<SNTt33_distrito>().FirstOrDefault();
                    obj.SNTt33_distrito = distrito;

                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Cliente View por ID: ", e.Message);
                }
            }
            return obj;
        }

        public PERt02_cliente ClienteXEmail(string email)
        {
            var obj = new PERt02_cliente();
            
            string sentencia = "SELECT * FROM PERt02_cliente WHERE txt_email1=@email OR txt_email2=@email";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt02_cliente>(sentencia, new { email }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Cliente por Email: ", e.Message);
                }
            }
            return obj;
        }
    }
}
