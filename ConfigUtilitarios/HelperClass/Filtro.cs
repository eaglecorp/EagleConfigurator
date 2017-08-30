using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios
{
    public class Filtro
    {
        public static int Nombre { get; } = 1;
        public static int Codigo { get; } = 2;
    }

    public class ComboFiltro
    {
        public int IdCampo { get; set; }
        public string TxtCampo { get; set; }


        public List<ComboFiltro> ListarFiltros()
        {
            var listaCampos = new List<ComboFiltro>()
                { new ComboFiltro() {   IdCampo= Filtro.Nombre,TxtCampo="Nombre" },
                  new ComboFiltro() {   IdCampo =Filtro.Codigo,TxtCampo="Código" }
                };
            return listaCampos;
        }

    }
}
