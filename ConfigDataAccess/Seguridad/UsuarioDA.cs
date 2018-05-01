using ConfigBusinessEntity;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigUtilitarios;

namespace ConfigDataAccess.Seguridad
{
    public class UsuarioDA
    {
        public List<PERt01_usuario> ListaUsuario(int? id_estado = null)
        {
            var lista = new List<PERt01_usuario>();
            string sentencia = string.Empty;
            sentencia = (id_estado == null) ? @"SELECT * FROM PERt01_usuario" : @"SELECT * FROM PERt01_usuario WHERE id_estado=@id_estado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    lista = cnn.Query<PERt01_usuario>(sentencia, new { id_estado }).ToList();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista de Usuarios: ", e.Message);
                }
            }
            return lista;
        }
        public long InsertarUsuario(PERt01_usuario obj)
        {
            long id = 0;
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    ctx.PERt01_usuario.Add(obj);
                    ctx.SaveChanges();
                    id = obj.id_usuario;
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Insertar Usuario: ", e.Message);
                }
            }
            return id;
        }
        public void EliminarUsuario(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    DateTime fecha_del = DateTime.Now;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PERt01_usuario SET id_estado = @id_estado, txt_estado = @txt_estado, fecha_modificacion=@fecha_del Where id_usuario=@id";
                        cmd.Parameters.AddWithValue("@id_estado", id_estado);
                        cmd.Parameters.AddWithValue("@txt_estado", txt_estado);
                        cmd.Parameters.AddWithValue("@fecha_del", fecha_del);
                        cmd.Parameters.AddWithValue("@id", id);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Eliminar Usuario: ", e.Message);
                }
            }
        }
        public void EliminarUsuarioXEmpleado(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdInactivo;
                    string txt_estado = Estado.TxtInactivo;
                    DateTime fecha_del = DateTime.Now;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PERt01_usuario SET id_estado = @id_estado, txt_estado = @txt_estado, fecha_modificacion=@fecha_del Where id_empleado=@id";
                        cmd.Parameters.AddWithValue("@id_estado", id_estado);
                        cmd.Parameters.AddWithValue("@txt_estado", txt_estado);
                        cmd.Parameters.AddWithValue("@fecha_del", fecha_del);
                        cmd.Parameters.AddWithValue("@id", id);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Eliminar Usuario por Empleado: ", e.Message);
                }
            }
        }
        public void ActivarUsuarioXEmpleado(long id)
        {
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    int id_estado = Estado.IdActivo;
                    string txt_estado = Estado.TxtActivo;
                    DateTime fecha = DateTime.Now;
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE PERt01_usuario SET id_estado = @id_estado, txt_estado = @txt_estado, fecha_modificacion=@fecha Where id_empleado=@id";
                        cmd.Parameters.AddWithValue("@id_estado", id_estado);
                        cmd.Parameters.AddWithValue("@txt_estado", txt_estado);
                        cmd.Parameters.AddWithValue("@fecha", fecha);
                        cmd.Parameters.AddWithValue("@id", id);
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Activar Usuario por Empleado: ", e.Message);
                }
            }
        }
        public void ActualizarUsuario(PERt01_usuario actualizado)
        {
            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    var original = ctx.PERt01_usuario.Find(actualizado.id_usuario);
                    if (original != null && original.id_usuario > 0)
                    {
                        ctx.Entry(original).CurrentValues.SetValues(actualizado);
                        ctx.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Actualizar Usuario: ", e.Message);
                }
            }
        }
        public PERt01_usuario UsuarioXId(long id)
        {
            var obj = new PERt01_usuario();
            string sentencia = "SELECT * FROM PERt01_usuario WHERE id_usuario=@id";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt01_usuario>(sentencia, new { id }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Usuario por ID: ", e.Message);
                }
            }
            return obj;
        }
        public PERt01_usuario UsuarioXCod(string cod)
        {
            var obj = new PERt01_usuario();
            string sentencia = "SELECT * FROM PERt01_usuario WHERE cod_usuario=@cod";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt01_usuario>(sentencia, new { cod }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Usuario por COD: ", e.Message);
                }
            }
            return obj;
        }
        public PERt01_usuario UsuarioXUsername(string username)
        {
            var obj = new PERt01_usuario();
            string sentencia = "SELECT * FROM PERt01_usuario WHERE txt_usuario=@username";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt01_usuario>(sentencia, new { username }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Usuario por Username: ", e.Message);
                }
            }
            return obj;
        }
        public PERt01_usuario UsuarioXEmpleado(long id_empleado)
        {
            var obj = new PERt01_usuario();
            string sentencia = "SELECT * FROM PERt01_usuario WHERE id_empleado=@id_empleado";
            using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    cnn.Open();
                    obj = cnn.Query<PERt01_usuario>(sentencia, new { id_empleado }).FirstOrDefault();
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Búsqueda Usuario por Empleado: ", e.Message);
                }
            }
            return obj;
        }
        public int GetUsuarioEnumerado(int numInicio, int numFin, string username)
        {
            int num = 0;
            if (numInicio <= numFin)
            {
                username = username + $"[{numInicio}-{numFin}]";
                string sentencia = $"SELECT COUNT(u.id_usuario) FROM PERt01_usuario  u WHERE u.txt_usuario LIKE @username";
                using (var cnn = new SqlConnection(ConnectionManager.GetConnectionString()))
                {
                    try
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandText = sentencia;
                            cmd.Parameters.AddWithValue("@username", username);
                            cnn.Open();
                            num = int.Parse(cmd.ExecuteScalar().ToString());
                        }
                    }
                    catch (Exception e)
                    {
                        var log = new Log();
                        log.ArchiveLog("Get Usuario Enumerado: ", e.Message);
                    }
                }
            }
            return num;
        }
        public PERt01_usuario ValidarUsuario(string username, string clave)
        {
            var obj = new PERt01_usuario();
            try
            {
                var usuario = UsuarioXUsername(username);

                if (usuario != null && usuario.id_usuario > 0)
                {
                    string claveValida = new Encription().Decryption(usuario.txt_clave);
                    obj = (clave == claveValida) ? usuario : null;
                }
                else
                {
                    obj = null;
                }
            }
            catch(Exception e)
            {
                var log = new Log();
                log.ArchiveLog("Validar Usuario: ", e.Message);
            }

            return obj;
        }
        public string GenerarUsername(string priNom, string segNom, string apPaterno, string apMaterno)
        {
            string pUsername = "";
            try
            {
                priNom = priNom.ToLower().Replace(" ", "").RemoveDiacritics();
                segNom = segNom.ToLower().Replace(" ", "").RemoveDiacritics();
                apPaterno = apPaterno.Replace(" ", "").ToLower().RemoveDiacritics();
                apMaterno = apMaterno.Replace(" ", "").ToLower().RemoveDiacritics();

                pUsername = (priNom.Substring(0, 1) + (apPaterno.Length > 19 ? apPaterno.Substring(0, 19) : apPaterno));
                bool disponible = false;
                var usuario = new PERt01_usuario();

                usuario = UsuarioXUsername(pUsername);

                if (usuario != null && usuario.id_usuario > 0)
                {
                    if (segNom.Length > 0 || apMaterno.Length > 0)
                    {
                        if (segNom.Length > 0)
                        {
                            pUsername = priNom.Substring(0, 1) + segNom.Substring(0, 1) + (apPaterno.Length > 18 ? apPaterno.Substring(0, 18) : apPaterno);
                            usuario = UsuarioXUsername(pUsername);
                            disponible = (usuario != null && usuario.id_usuario > 0) ? false : true;
                        }

                        if (disponible == false && apMaterno.Length > 0)
                        {
                            pUsername = priNom.Substring(0, 1) + (apPaterno.Length > 18 ? apPaterno.Substring(0, 18) : apPaterno) + apMaterno.Substring(0, 1);
                            usuario = UsuarioXUsername(pUsername);
                            disponible = (usuario != null && usuario.id_usuario > 0) ? false : true;
                        }

                        if (disponible == false && priNom.Length > 1 && apMaterno.Length > 0)
                        {
                            pUsername = priNom.Substring(0, 2) + (apPaterno.Length > 17 ? apPaterno.Substring(0, 17) : apPaterno) + apMaterno.Substring(0, 1);
                            usuario = UsuarioXUsername(pUsername);
                            disponible = (usuario != null && usuario.id_usuario > 0) ? false : true;
                        }
                    }
                    if (disponible == false)
                    {
                        int num = 0;

                        pUsername = (priNom.Substring(0, 1) + (apPaterno.Length > 19 ? apPaterno.Substring(0, 16) : apPaterno));
                        num = GetUsuarioEnumerado(1, 999, pUsername);
                        if ((pUsername.Length) + (num + 1).ToString().Length <= 20)
                        {
                            pUsername = pUsername + (num + 1).ToString();
                            usuario = UsuarioXUsername(pUsername);
                            disponible = (usuario != null && usuario.id_usuario > 0) ? false : true;
                        }
                        else
                        {
                            disponible = false;
                        }
                    }
                }
                else
                {
                    disponible = true;
                }

                if (!disponible)
                {
                    pUsername = "";
                    var log = new Log();
                    log.ArchiveLog("Generar Username: ", "Pasó el método satisfactoriamente pero no se logró generar un usuario.");
                }

            }
            catch(Exception e)
            {
                var log = new Log();
                log.ArchiveLog("Generar Username: ", e.Message);
            }
        
            return pUsername;

        }
        public bool EsValidoIDPassword(long? idUsuario, long idPassword)
        {
            bool isValid = true;

            using (var ctx = new EagleContext(ConnectionManager.GetConnectionString()))
            {
                try
                {
                    if (idUsuario == null)
                    {
                        //Cuando verifica en toda la tabla (EN INSERCIÓN)
                        isValid = ctx.PERt01_usuario.Any(x => x.id_password == idPassword);
                    }

                    else
                    {
                        //Cuando verifica en toda la tabla excepto su contenido (EN ACTUALIZACIÓN)
                        isValid = ctx.PERt01_usuario.Where(x => x.id_usuario != idUsuario)
                                                        .Any(x => x.id_password == idPassword);
                    }
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Validar ID Password de usuario: ", e.Message);
                }
            }
            return !isValid;
        }
    }


}
