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
    public class ClaseEmpBL
    {
        public List<PERt06_clase_emp> ListaClaseEmp(int? id_estado = null, bool ocultarBlankReg = false, bool enableTopList = false)
        {
            var lista = new ClaseEmpDA().ListaClaseEmp(id_estado);
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                lista.RemoveAll(x => x.cod_clase_emp == Parameter.BlankRegister);
            }

            if (enableTopList && lista != null)
                return lista.OrderBy(x => x.cod_clase_emp != TopList.ClaseEmp).ThenBy(x => x.txt_nombre).ToList();

            return lista;
        }
        public int InsertarClaseEmp(PERt06_clase_emp obj)
        {
            return new ClaseEmpDA().InsertarClaseEmp(obj);
        }
        public void EliminarClaseEmp(int id)
        {
            new ClaseEmpDA().EliminarClaseEmp(id);
        }
        public void ActualizarClaseEmp(PERt06_clase_emp actualizado)
        {
            new ClaseEmpDA().ActualizarClaseEmp(actualizado);
        }
        public PERt06_clase_emp ClaseEmpXId(int id)
        {
            return new ClaseEmpDA().ClaseEmpXId(id);
        }
        public PERt06_clase_emp ClaseEmpXCod(string cod)
        {
            return new ClaseEmpDA().ClaseEmpXCod(cod);
        }
    }
}
