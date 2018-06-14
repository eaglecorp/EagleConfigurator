using ConfigBusinessEntity;
using ConfigBusinessLogic.Sunat;
using ConfigDataAccess.Persona;
using System.Collections.Generic;
using System.Linq;

namespace ConfigBusinessLogic.Persona
{
    public class ProveedorBL
    {
        public long InsertarProveedor(PERt03_proveedor obj)
        {
            return new ProveedorDA().InsertarProveedor(obj);
        }

        public void EliminarProveedor(long id)
        {
            new ProveedorDA().EliminarProveedor(id);
        }

        public void ActualizarProveedor(PERt03_proveedor actualizado)
        {
            new ProveedorDA().ActualizarProveedor(actualizado);
        }

        public PERt03_proveedor ProveedorXIdMM(long id)
        {
            var proveedor = new ProveedorDA().ProveedorXIdMM(id);

            if (proveedor.SNTt33_distrito != null && proveedor.SNTt33_distrito.id_dist > 0)
            {
                var provincia = new ProvinciaBL().ProvinciaXId(proveedor.SNTt33_distrito.id_prov);
                proveedor.SNTt33_distrito.SNTt32_provincia = provincia;
            }

            return proveedor;
        }

        public PERt03_proveedor ProveedorViewXId(long id)
        {
            var proveedor = new ProveedorDA().ProveedorViewXId(id);

            if (proveedor.SNTt33_distrito != null && proveedor.SNTt33_distrito.id_dist > 0)
            {
                var provincia = new ProvinciaBL().ProvinciaXId(proveedor.SNTt33_distrito.id_prov);
                proveedor.SNTt33_distrito.SNTt32_provincia = provincia;
            }

            return proveedor;
        }

        public PERt03_proveedor ProveedorXCod(string cod)
        {
            return new ProveedorDA().ProveedorXCod(cod);
        }

        public List<PERt03_proveedor> ListaProveedor(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new ProveedorDA().ListaProveedor(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_proveedor == Parameter.BlankRegister);
            }
            return lista;
        }

        public PERt03_proveedor ProveedorXEmail(string email)
        {
            return new ProveedorDA().ProveedorXEmail(email);
        }
    }
}
