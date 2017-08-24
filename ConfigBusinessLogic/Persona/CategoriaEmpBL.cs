using ConfigBusinessEntity;
using ConfigDataAccess.Persona;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Persona
{
    public class CategoriaEmpBL
    {
        public List<PERt05_categoria_emp> ListaCategoriaEmp(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new CategoriaEmpDA().ListaCategoriaEmp(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_categoria_emp == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_categoria_emp > 0)
                    lista.Remove(itemToRemove);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_categoria_emp != TopList.CategoriaEmp).ThenBy(x => x.txt_nombre).ToList();

            return lista;
        }
        public int InsertarCategoriaEmp(PERt05_categoria_emp obj)
        {
            return new CategoriaEmpDA().InsertarCategoriaEmp(obj);
        }
        public void EliminarCategoriaEmp(int id)
        {
            new CategoriaEmpDA().EliminarCategoriaEmp(id);
        }
        public void ActualizarCategoriaEmp(PERt05_categoria_emp actualizado)
        {
            new CategoriaEmpDA().ActualizarCategoriaEmp(actualizado);
        }
        public PERt05_categoria_emp CategoriaEmpXId(int id)
        {
            return new CategoriaEmpDA().CategoriaEmpXId(id);
        }
        public PERt05_categoria_emp CategoriaEmpXCod(string cod)
        {
           return new CategoriaEmpDA().CategoriaEmpXCod(cod);
        }
    }
}
