using ConfigBusinessEntity;
using ConfigUtilitarios;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigDataAccess.Maestro
{
    public class TurnoDA
    {
        public List<MSTt13_turno> ListaTurno(int? id_estado = null)
        {
            var lista = new List<MSTt13_turno>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ?
                @"SELECT * FROM MSTt13_turno" :
                @"SELECT * FROM MSTt13_turno WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<MSTt13_turno>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Turno: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarTurno(MSTt13_turno obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.MSTt13_turno.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_turno;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Turno: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarTurno(int id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE MSTt13_turno SET id_estado = @id_estado, txt_estado = @txt_estado Where id_turno=@id";
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
                    log.ArchiveLog("Eliminar Turno: ", e.Message);
                }
            }
        }
        public void ActualizarTurno(MSTt13_turno actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.MSTt13_turno.Find(actualizado.id_turno);
                    if (original != null && original.id_turno > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Turno: ", e.Message);
                }
            }
        }
        public MSTt13_turno TurnoXId(int id)
        {
            var obj = new MSTt13_turno();
            string sentencia = "SELECT * FROM MSTt13_turno WHERE id_turno=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt13_turno>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Turno por ID: ", e.Message);
                }
            }
            return obj;
        }
        public MSTt13_turno TurnoXCod(string cod)
        {
            var obj = new MSTt13_turno();
            string sentencia = "SELECT * FROM MSTt13_turno WHERE cod_turno=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<MSTt13_turno>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Turno por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
