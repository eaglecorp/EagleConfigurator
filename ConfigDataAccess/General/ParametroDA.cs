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
    public class ParametroDA
    {
        public List<GRLt01_parametro> ListaParametro()
        {
            var lista = new List<GRLt01_parametro>();
            string sentencia = @"SELECT * FROM GRLt01_parametro";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<GRLt01_parametro>(sentencia).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Parámetros: ", e.Message);
                }
            }
            return lista;
        }
        public int InsertarParametro(GRLt01_parametro obj)
        {
            int id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.GRLt01_parametro.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_parametro;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Parámetro: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarParametro(int id)
        {
            var obj = new GRLt01_parametro() { id_parametro = id };
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.Entry(obj).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Eliminar Parámetro: ", e.Message);
                }
            }
        }
        public void ActualizarParametro(GRLt01_parametro actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.GRLt01_parametro.Find(actualizado.id_parametro);
                    if (original != null && original.id_parametro > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Parámetro: ", e.Message);
                }
            }
        }
        public GRLt01_parametro ParametroXId(int id)
        {
            var obj = new GRLt01_parametro();
            string sentencia = "SELECT * FROM GRLt01_parametro WHERE id_parametro=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<GRLt01_parametro>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Parámetro por ID: ", e.Message);
                }
            }
            return obj;
        }
        public GRLt01_parametro ParametroXCod(string cod)
        {
            var obj = new GRLt01_parametro();
            string sentencia = "SELECT * FROM GRLt01_parametro WHERE cod_parametro=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<GRLt01_parametro>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Parámetro por COD: ", e.Message);
                }
            }
            return obj;
        }
    }
}
