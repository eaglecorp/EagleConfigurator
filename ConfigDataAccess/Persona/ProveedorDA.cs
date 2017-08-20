using ConfigBusinessEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using ConfigUtilitarios;

namespace ConfigDataAccess.Persona
{
    public class ProveedorDA
    {
        public List<PERt03_proveedor> ListaProveedor(int? id_estado = null)
        {
            var lista = new List<PERt03_proveedor>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PERt03_proveedor"
                                            : @"SELECT * FROM PERt03_proveedor WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PERt03_proveedor>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Proveedores: ", e.Message);
                }
            }
            return lista;
        }
        public long InsertarProveedor(PERt03_proveedor obj)
        {
            long id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PERt03_proveedor.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_proveedor;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Proveedor: ", e.Message);
                }
            }
            return id;

        }
        public void EliminarProveedor(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PERt03_proveedor SET id_estado = @id_estado, txt_estado = @txt_estado Where id_proveedor=@id";
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
                    log.ArchiveLog("Eliminar Proveedor: ", e.Message);
                }
            }
        }
        public void ActualizarProveedor(PERt03_proveedor actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PERt03_proveedor.Find(actualizado.id_proveedor);
                    if (original != null && original.id_proveedor > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Proveedor: ", e.Message);
                }
            }
        }
        public PERt03_proveedor ProveedorXId(long id)
        {
            var obj = new PERt03_proveedor();
            string sentencia = "SELECT * FROM PERt03_proveedor WHERE id_proveedor=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt03_proveedor>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Proveedor por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PERt03_proveedor ProveedorXCod(string cod)
        {
            var obj = new PERt03_proveedor();
            string sentencia = "SELECT * FROM PERt03_proveedor WHERE cod_proveedor=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt03_proveedor>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Proveedor por COD: ", e.Message);
                }
            }
            return obj;
        }
        public PERt03_proveedor ProveedorXIdMM(long id)
        {
            var obj = new PERt03_proveedor();
            obj = ProveedorXId(id);
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
                    log.ArchiveLog("Búsqueda Proveedor MM por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PERt03_proveedor ProveedorXEmail(string email)
        {
            var obj = new PERt03_proveedor();
           
            string sentencia = "SELECT * FROM PERt03_proveedor WHERE txt_email1=@email OR txt_email2=@email";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt03_proveedor>(sentencia, new { email }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Proveedor por Email: ", e.Message);
                }
            }
            return obj;
        }

    }
}
