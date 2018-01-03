using ConfigBusinessEntity;
using ConfigDataAccess.General;
using ConfigUtilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.General
{
    public class ParametroBL
    {
        public int InsertarParametro(GRLt01_parametro obj)
        {
            if (obj.cod_parametro == ParameterCode.Password)
                obj.txt_valor = new Encription().Encryption(obj.txt_valor);

            return new ParametroDA().InsertarParametro(obj);
        }

        public void EliminarParametro(int id)
        {
            new ParametroDA().EliminarParametro(id);
        }

        public void ActualizarParametro(GRLt01_parametro obj)
        {
            if (obj.cod_parametro == ParameterCode.Password)
                obj.txt_valor = new Encription().Encryption(obj.txt_valor);

            new ParametroDA().ActualizarParametro(obj);
        }

        public bool ActualizarParametros(List<GRLt01_parametro> parametros)
        {
            return new ParametroDA().ActualizarParametros(parametros);
        }

        public GRLt01_parametro ParametroXId(int id)
        {
            var p = new GRLt01_parametro();
            p = new ParametroDA().ParametroXId(id);
            if (p != null && p.id_parametro > 0 && p.cod_parametro == ParameterCode.Password)
                p.txt_valor = new Encription().Decryption(p.txt_valor);

            return p;
        }

        public List<GRLt01_parametro> ListaParametro(bool ocultarBlankReg = false)
        {
            var lista = new ParametroDA().ListaParametro();
            if (ocultarBlankReg && lista != null && lista.Count > 0)
            {
                var itemToRemove = lista.SingleOrDefault(x => x.cod_parametro == Parameter.BlankRegister);
                if (itemToRemove != null && itemToRemove.id_parametro > 0)
                    lista.Remove(itemToRemove);
            }
            return lista;
        }

        public GRLt01_parametro ParametroXCod(string cod)
        {

            var p = new GRLt01_parametro();
            p = new ParametroDA().ParametroXCod(cod);
            if (p != null && p.id_parametro > 0 && p.cod_parametro == ParameterCode.Password)
                p.txt_valor = new Encription().Decryption(p.txt_valor);
            return p;
        }
    }
}
