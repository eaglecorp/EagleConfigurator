using ConfigBusinessEntity;
using ConfigDataAccess.Persona;
using ConfigDataAccess.Seguridad;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.HelperGeneric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Seguridad
{
    public class UsuarioBL
    {
        public long InsertarUsuario(PERt01_usuario obj)
        {
            return new UsuarioDA().InsertarUsuario(obj);
        }

        public void EliminarUsuario(long id)
        {
            new UsuarioDA().EliminarUsuario(id);
        }

        public void ActualizarUsuario(PERt01_usuario obj)
        {
            new UsuarioDA().ActualizarUsuario(obj);
        }

        public void EliminarUsuarioXEmpleado(long id)
        {
            new UsuarioDA().EliminarUsuarioXEmpleado(id);
        }

        public void ActivarUsuarioXEmpleado(long id)
        {
            new UsuarioDA().ActivarUsuarioXEmpleado(id);
        }

        public PERt01_usuario UsuarioXId(long id)
        {
            return new UsuarioDA().UsuarioXId(id);
        }

        public PERt01_usuario UsuarioXCod(string cod)
        {
            return new UsuarioDA().UsuarioXCod(cod);
        }

        public PERt01_usuario UsuarioXUsername(string username)
        {
            return new UsuarioDA().UsuarioXUsername(username);
        }

        public PERt01_usuario UsuarioXEmpleado(long id_empleado)
        {
            return new UsuarioDA().UsuarioXEmpleado(id_empleado);
        }

        public PERt01_usuario ValidarUsuario(string username, string clave)
        {
            return new UsuarioDA().ValidarUsuario(username, clave);
        }

        public bool EsValidoIDPassword(long? idUsuario, long idPassword)
        {
            return new UsuarioDA().EsValidoIDPassword(idUsuario, idPassword);
        }

        public List<PERt01_usuario> ListaUsuario(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new UsuarioDA().ListaUsuario(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                try
                {
                    lista.RemoveAll(x => x.cod_usuario == Parameter.BlankRegister);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Usuario: UsuarioBL. ", e.Message);
                }
            }
            return lista;
        }

        public string GenerarClave()
        {
            string clave = "";
            var rdm = new Random();

            while (clave.Length < 10)
            {
                clave += rdm.Next(0, 9).ToString();
            }

            return clave;
        }

        public string GenerarUsername(string priNom, string segNom, string apPaterno, string apMaterno)
        {
            return new UsuarioDA().GenerarUsername(priNom, segNom, apPaterno, apMaterno);
        }

        public string ArmarMsjCredenciales(PERt01_usuario usuario, PERt04_empleado empleado, string asunto)
        {
            string parrafo = "";

            if (asunto == ParameterCode.SubjectRegister)
                parrafo = Parameter.AddMsjRegister;
            else if (asunto == ParameterCode.SubjectCredentials)
                parrafo = Parameter.AddMsjCredentials;

            if (parrafo != "" && parrafo != null)
                parrafo = parrafo + "\n\n";

            string nombreCompleto = Human.Nombre(empleado.txt_ape_pat, 
                                                    empleado.txt_pri_nom, 
                                                    empleado.txt_ape_mat, 
                                                    empleado.txt_seg_nom, 
                                                    empleado.txt_rzn_social)?.ToUpper();

            string saludo = $"¡HOLA! {nombreCompleto}";

            string credenciales = $"DATOS DE LA CUENTA\n------------------------------------\n• Username: {usuario.txt_usuario}\n• Contraseña: {new Encription().Decryption(usuario.txt_clave)}";

            string pie = $"¡Que tenga un excelente día!";

            string mensaje = $"{saludo}\n\n{parrafo}{credenciales}\n\n{pie}";

            return mensaje;
        }

        private void RespuestaEmailEnviado(bool sended, string email)
        {
            if (sended)
            {
                Msg.Ok_Info("Sus credenciales han sido enviadas a su correo: " + email + ".");
            }
            else
            {
                Msg.Ok_Wng("No se pudo enviar sus credenciales a su correo.");
            }
        }

        public bool CrearUsuarioAEmpleado(long idEmpleado)
        {
            bool success = false;
            var empleado = new EmpleadoDA().EmpleadoXId(idEmpleado);

            if (empleado != null && empleado.id_empleado > 0)
            {
                var usuario = new PERt01_usuario();

                usuario.txt_usuario = new UsuarioDA().GenerarUsername(
                    empleado.txt_pri_nom,
                    empleado.txt_seg_nom,
                    empleado.txt_ape_pat,
                    empleado.txt_ape_mat);

                if (usuario.txt_usuario != "")
                {
                    #region Armando el Usuario generado

                    usuario.id_estado = Estado.IdActivo;
                    usuario.txt_estado = Estado.TxtActivo;
                    usuario.txt_clave = new UsuarioBL().GenerarClave();
                    usuario.txt_clave = new Encription().Encryption(usuario.txt_clave);
                    usuario.sn_upd_requered = Estado.IdActivo;
                    usuario.id_empleado = idEmpleado;

                    #endregion

                    long idUsuario = new UsuarioDA().InsertarUsuario(usuario);

                    if (idUsuario > 0)
                    {
                        success = true;
                        #region Enviar email de registro de usuario

                        int sendMailRegister = Parameter.SendMailRegister;
                        if (sendMailRegister == Estado.IdActivo)
                        {
                            string emailFrom = Parameter.EmailFrom;
                            string password = Parameter.Password;
                            if (!string.IsNullOrEmpty(emailFrom) || !string.IsNullOrEmpty(password))
                            {
                                try
                                {
                                    usuario.id_usuario = idUsuario;

                                    if (!string.IsNullOrEmpty(empleado.txt_email1) || !string.IsNullOrEmpty(empleado.txt_email2))
                                    {
                                        string body = ArmarMsjCredenciales(usuario, empleado, ParameterCode.SubjectRegister);
                                        if (!string.IsNullOrEmpty(empleado.txt_email1))
                                        {
                                            RespuestaEmailEnviado(
                                            new Email().SendEmail(emailFrom, password, Parameter.DisplayNameEmail, empleado.txt_email1, Parameter.SubjectRegister, body, Parameter.MailServer, Parameter.Port),
                                            empleado.txt_email1);
                                        }
                                        else if (!string.IsNullOrEmpty(empleado.txt_email2))
                                        {
                                            RespuestaEmailEnviado(
                                            new Email().SendEmail(emailFrom, password, Parameter.DisplayNameEmail, empleado.txt_email2, Parameter.SubjectRegister, body, Parameter.MailServer, Parameter.Port),
                                            empleado.txt_email2);
                                        }
                                    }
                                    else
                                    {
                                        Msg.Ok_Info("El empleado no tiene ningún correo electrónico asociado. No se pudo enviar sus credenciales.");
                                    }
                                }
                                catch (Exception e)
                                {
                                    var log = new Log();
                                    log.ArchiveLog("Crear usuario a empleado - Enviando Email de Registro: ", e.Message);
                                }
                            }
                        }

                        #endregion
                    }
                }
            }
            return success;
        }

    }
}
