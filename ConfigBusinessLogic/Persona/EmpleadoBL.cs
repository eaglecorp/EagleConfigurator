using System;
using System.Collections.Generic;
using ConfigBusinessEntity;
using ConfigDataAccess.Persona;
using ConfigUtilitarios;
using ConfigBusinessLogic.Seguridad;
using ConfigBusinessLogic.Sunat;
using System.Linq;
using ConfigUtilitarios.HelperControl;
using ConfigBusinessLogic.Labor;
using ConfigDataAccess.Labor;

namespace ConfigBusinessLogic.Persona
{
    public class EmpleadoBL
    {
        public long InsertarEmpleado(PERt04_empleado obj)
        {
            long idEmpleado = new EmpleadoDA().InsertarEmpleado(obj);
            if (idEmpleado != 0)
            {
                var usuario = new PERt01_usuario();

                usuario.txt_usuario = new UsuarioBL().GenerarUsername(obj.txt_pri_nom, obj.txt_seg_nom, obj.txt_ape_pat, obj.txt_ape_mat);

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

                    long idUsuario = new UsuarioBL().InsertarUsuario(usuario);

                    if (idUsuario > 0)
                    {
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
                                    var empleado = EmpleadoXId(idEmpleado);


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
                                }
                                catch (Exception e)
                                {
                                    var log = new Log();
                                    log.ArchiveLog("Insertar Empleado - Enviando Email de Registro: ", e.Message);
                                }
                            }
                        }

                    }
                }

            }
            return idEmpleado;
        }

        public IEnumerable<PERt04_empleado> BuscarEmpleados(string nroDoc, string ruc,string codEmpleado, string nombre, int? idEstado)
        {
            return new EmpleadoDA().BuscarEmpleados(nroDoc, ruc, codEmpleado, nombre, idEstado);
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

        private string Nombre(string apPaterno, string apMaterno, string primerNom, string segundoNom, string rznSocial)
        {
            string nombre = "";
            if (apPaterno != null && apPaterno.Trim() != "")
            {
                nombre = apPaterno + " ";
            }
            if (apMaterno != null && apMaterno.Trim() != "")
            {
                nombre += apMaterno + " ";
            }
            if (primerNom != null && primerNom.Trim() != "")
            {
                nombre += primerNom + " ";
            }
            if (segundoNom != null && segundoNom.Trim() != "")
            {
                nombre += segundoNom + " ";
            }
            if (rznSocial != null && rznSocial.Trim() != "")
            {
                if (nombre.Length > 0)
                {
                    nombre += "| " + rznSocial;
                }
                else
                {
                    nombre = rznSocial;
                }
            }
            return nombre.Trim().ToUpper();
        }

        public object BuscarProducto(string codProd, string v1, string v2, int idActivo1, int? ignorar, int idActivo2)
        {
            throw new NotImplementedException();
        }

        public void EliminarEmpleado(long id)
        {
            new EmpleadoDA().EliminarEmpleado(id);
            new UsuarioBL().EliminarUsuarioXEmpleado(id);
        }

        public void ActualizarEmpleado(PERt04_empleado actualizado)
        {
            new EmpleadoDA().ActualizarEmpleado(actualizado);
        }

        public PERt04_empleado EmpleadoXIdMM(long id)
        {
            var empleado = new EmpleadoDA().EmpleadoXIdMM(id);

            if (empleado.SNTt33_distrito != null && empleado.SNTt33_distrito.id_dist > 0)
            {
                var provincia = new ProvinciaBL().ProvinciaXId(empleado.SNTt33_distrito.id_prov);
                empleado.SNTt33_distrito.SNTt32_provincia = provincia;
            }
            if (empleado != null && empleado.id_empleado > 0)
            {
                empleado.LABt07_emp_trabajo = new TrabajoEmpleadoDA().ListaTrabajoXEmpleado(empleado.id_empleado);
            }

            return empleado;
        }

        public PERt04_empleado EmpleadoXId(long id)
        {
            return new EmpleadoDA().EmpleadoXId(id);
        }

        public PERt04_empleado EmpleadoXCod(string cod)
        {
            return new EmpleadoDA().EmpleadoXCod(cod);
        }

        public List<PERt04_empleado> ListaEmpleado(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new EmpleadoDA().ListaEmpleado(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                try
                {
                    lista.RemoveAll(x => x.cod_empleado == Parameter.BlankRegister);
                }
                catch (Exception e)
                {
                    var log = new Log();
                    log.ArchiveLog("Lista Empleado: EmpleadoBL. ", e.Message);
                }
            }
            return lista;
        }

        public PERt04_empleado EmpleadoXEmail(string email)
        {
            return new EmpleadoDA().EmpleadoXEmail(email);
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

            string nombreCompleto = Nombre(empleado.txt_ape_pat, empleado.txt_ape_mat, empleado.txt_pri_nom, empleado.txt_seg_nom, empleado.txt_rzn_social);

            string saludo = $"¡HOLA! {nombreCompleto}";

            string credenciales = $"DATOS DE LA CUENTA\n-------------------------\n•Username: {usuario.txt_usuario}\n•Contraseña: {new Encription().Decryption(usuario.txt_clave)}";

            string pie = $"Fecha de envío: {DateTime.Now}";

            string mensaje = $"{saludo}\n\n{parrafo}{credenciales}\n\n{pie}";

            return mensaje;
        }

        public PERt04_empleado EmpleadoXNroDoc(string nro_doc)
        {
            return new EmpleadoDA().EmpleadoXNroDoc(nro_doc);
        }
    }
}
