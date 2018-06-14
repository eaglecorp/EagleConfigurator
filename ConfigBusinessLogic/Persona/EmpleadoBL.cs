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
using ConfigUtilitarios.HelperGeneric;

namespace ConfigBusinessLogic.Persona
{
    public class EmpleadoBL
    {
        public long InsertarEmpleado(PERt04_empleado obj)
        {
            long idEmpleado = new EmpleadoDA().InsertarEmpleado(obj);
            if (idEmpleado != 0)
            {
                var crearUsuario = Parameter.CreateUserAfterRegisterEmployee;
                if(crearUsuario == Estado.IdActivo)
                {
                    if(!new UsuarioBL().CrearUsuarioAEmpleado(idEmpleado))
                    {
                        Msg.Ok_Err("Se creó el empleado correctamente pero no se pudo crear su usuario.","Error");
                    }
                }
            }
            return idEmpleado;
        }

        public IEnumerable<PERt04_empleado> BuscarEmpleados(string nroDoc, string ruc,string codEmpleado, string nombre, int? idEstado)
        {
            return new EmpleadoDA().BuscarEmpleados(nroDoc, ruc, codEmpleado, nombre, idEstado);
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

        public PERt04_empleado EmpleadoViewXId(long id)
        {
            var empleado = new EmpleadoDA().EmpleadoViewXId(id);

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

        public PERt04_empleado EmpleadoXNroDoc(string nro_doc)
        {
            return new EmpleadoDA().EmpleadoXNroDoc(nro_doc);
        }
    }
}
