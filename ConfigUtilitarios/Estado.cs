using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios
{
    public class Estado
    {
        public static int IdInactivo { get; } = 0;
        public static string TxtInactivo { get; } = "INACTIVO";
        public static int IdActivo { get; } = 1;
        public static string TxtActivo { get; } = "ACTIVO";
    }
}
