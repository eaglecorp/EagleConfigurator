using ConfigBusinessEntity;
using ConfigDataAccess.Seguridad;
using ConfigUtilitarios;
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
            return new UsuarioDA().GenerarUsername(priNom,segNom,apPaterno,apMaterno);
        }

    }
}
