using ConfigBusinessEntity;
using ConfigBusinessLogic.Sunat;
using ConfigDataAccess.Persona;
using System.Collections.Generic;
using System.Linq;

namespace ConfigBusinessLogic.Persona
{
    public class ClienteBL
    {
        public long InsertarCliente(PERt02_cliente obj)
        {
            return new ClienteDA().InsertarCliente(obj);
        }

        public void EliminarCliente(long id)
        {
            new ClienteDA().EliminarCliente(id);
        }

        public void ActualizarCliente(PERt02_cliente actualizado)
        {
            new ClienteDA().ActualizarCliente(actualizado);
        }

        public PERt02_cliente ClienteXIdMM(long id)
        {
            var cliente = new ClienteDA().ClienteXIdMM(id);

            if (cliente.SNTt33_distrito != null && cliente.SNTt33_distrito.id_dist>0)
            {
                var provincia = new ProvinciaBL().ProvinciaXId(cliente.SNTt33_distrito.id_prov);
                cliente.SNTt33_distrito.SNTt32_provincia = provincia;
            }

            return cliente;
        }

        public PERt02_cliente ClienteXCod(string cod)
        {
            return new ClienteDA().ClienteXCod(cod);
        }

        public List<PERt02_cliente> ListaCliente(int? id_estado = null, bool ocultarBlankReg= false)
        {
            var lista = new ClienteDA().ListaCliente(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_cliente == Parameter.BlankRegister);
            }
            return lista;
        }

        public PERt02_cliente ClienteXEmail(string email)
        {
            return new ClienteDA().ClienteXEmail(email);
        }
    }
}
