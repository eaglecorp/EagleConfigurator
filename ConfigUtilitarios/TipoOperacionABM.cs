using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios
{
    public class TipoOperacionABM
    {
        public static int No_Action { get; } = 1;
        public static int Nuevo { get; } = 2;
        public static int Insertar { get; } = 3;
        public static int Modificar { get; } = 4;
        public static int Eliminar { get; } = 5;
        public static int Rollback { get; } = 6;
        public static int Search { get; } = 7;
        public static int Filter { get; } = 8;
        public static int Cambio { get; } = 9;
    }
}
