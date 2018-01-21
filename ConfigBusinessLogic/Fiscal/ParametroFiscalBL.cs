using ConfigBusinessEntity;
using ConfigBusinessLogic.Maestro;
using ConfigDataAccess.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigBusinessLogic.Fiscal
{
    public class ParametroFiscalBL
    {
        public List<FISt04_parametro_fiscal> ListaParametroFiscal()
        {
            return new ParametroFiscalDA().ListaParametroFiscal();
        }

        public bool ActualizarParametrosFiscales(List<FISt04_parametro_fiscal> parametrosFiscales)
        {
            return new ParametroFiscalDA().ActualizarParametrosFiscales(parametrosFiscales);
        }

        public bool ActualizarAndInsertarParametrosFiscales(List<FISt04_parametro_fiscal> parametrosFiscales)
        {
            if (parametrosFiscales == null)
                return true;

            var parametrosParaActualizar = parametrosFiscales.Where(x => x.id_parametro_fiscal > 0).ToList();

            var parametrosParaInsertar = parametrosFiscales.Where(x => x.id_parametro_fiscal == 0).ToList();

            if (parametrosParaInsertar != null && parametrosParaInsertar.Count() > 0)
            {
                parametrosParaInsertar = AddCajasANuevosParametrosFiscales(parametrosParaInsertar);
            }

            return new ParametroFiscalDA().ActualizarAndInsertarParametrosFiscales(parametrosParaActualizar, parametrosParaInsertar);
        }

        public List<FISt04_parametro_fiscal> AddCajasANuevosParametrosFiscales(List<FISt04_parametro_fiscal> parametros)
        {
            var cajas = new CajaBL().ListaCaja();
            var paramFisParaInsertar = new List<FISt04_parametro_fiscal>();

            if (cajas != null && cajas.Count > 0)
            {
                foreach (var paramFis in parametros)
                {
                    foreach (var caja in cajas)
                    {
                        paramFis.FISt05_configuracion_fiscal_caja.Add(
                            new FISt05_configuracion_fiscal_caja()
                            {
                                id_parametro_fiscal = 0,
                                id_caja = caja.id_caja,
                                valor = paramFis.valor_default
                            }
                          );
                    }
                    paramFisParaInsertar.Add(paramFis);
                }
            }
            else
            {
                paramFisParaInsertar = parametros;
            }

            return paramFisParaInsertar;
        }

        public bool EstaDisponibleCodigo(long? idParametroFiscal, string codigo)
        {
            return new ParametroFiscalDA().EstaDisponibleCodigo(idParametroFiscal, codigo);
        }

        public bool EstaDisponibleNombre(long? idParametroFiscal, string nombre)
        {
            return new ParametroFiscalDA().EstaDisponibleNombre(idParametroFiscal, nombre);
        }
    }
}
