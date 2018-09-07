using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigBusinessEntity;
using ConfigDataAccess;

namespace ConfigBusinessLogic
{
    public class ProductoBL
    {
        public long InsertarProducto(PROt09_producto obj)
        {
            return new ProductoDA().InsertarProducto(obj);
        }

        public void EliminarProducto(long id)
        {
            new ProductoDA().EliminarProducto(id);
        }

        public bool ActivarProducto(long id)
        {
            return new ProductoDA().ActivarProducto(id);
        }

        public bool ActualizarProducto(PROt09_producto obj)
        {
            return new ProductoDA().ActualizarProducto(obj);
        }

        public List<PROt09_producto> ListaProducto(int? id_estado = null, bool ocultarBlankReg = false)
        {
            var lista = new ProductoDA().ListaProducto(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => (x.cod_producto == Parameter.BlankRegister) || (x.cod_producto2 == Parameter.BlankRegister));
            }
            return lista;
        }

        public PROt09_producto ProductoXId(long id)
        {
            return new ProductoDA().ProductoXId(id);
        }

        public PROt09_producto ProductoXIdMM(long id)
        {
            return new ProductoDA().ProductoXIdMM(id);
        }

        public PROt09_producto ProductoViewXId(long id)
        {
            return new ProductoDA().ProductoViewXId(id);
        }

        public PROt09_producto ProductoXCod(string cod)
        {
            return new ProductoDA().ProductoXCod(cod);
        }

        public PROt09_producto ProductoXCod2(string cod)
        {
            return new ProductoDA().ProductoXCod2(cod);
        }

        public PROt09_producto ProductoXCodBarra(string cod)
        {
            return new ProductoDA().ProductoXCodBarra(cod);
        }

        public List<PROt09_producto> ListaProductoXNom(string nombre, int? id_estado = null)
        {
            return new ProductoDA().ListaProductoXNom(nombre, id_estado);
        }

        public List<PROt09_producto> ListaProductoXMod(int id_modelo, int? id_estado = null)
        {
            return new ProductoDA().ListaProductoXMod(id_modelo, id_estado);
        }

        public IEnumerable<PROt09_producto> BuscarProducto(string cod, string cod02, string nombre, int? snVenta, int? snCompra, int? idEstado, bool ocultarBlankReg = true)
        {
            var lista = new ProductoDA().BuscarProductos(cod, cod02, nombre, snVenta, snCompra, idEstado);
            if (ocultarBlankReg && lista != null && lista.Count() > 0)
            {
                return lista.Where(x => x.cod_producto != Parameter.BlankRegister);
            }
            return lista;
        }

        public PROt09_producto GetIdPorcentajeDeProducto(long id_producto)
        {
            return new ProductoDA().GetIdPorcentajeDeProducto(id_producto);
        }

    }
}
