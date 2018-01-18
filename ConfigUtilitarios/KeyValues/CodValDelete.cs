using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigUtilitarios
{
    public class CodValDelete
    {
        //[TABLAPADRE]_[TABLAHIJA]
        public static int TipoLocation_Location         { get; } = 1;
        public static int Impuesto_Producto             { get; } = 2;
        public static int Familia_SubFamilia            { get; } = 3;
        public static int Familia_Clase                 { get; } = 4;
        public static int Marca_Modelo                  { get; } = 5;
        public static int Grupo_Clase                   { get; } = 6;
        public static int TipoProd_Producto             { get; } = 7;
        public static int Modelo_Producto               { get; } = 8;
        public static int SubFamilia_Producto           { get; } = 9;
        public static int Clase_Producto                { get; } = 10;
        public static int CategoriaReporte_Reporte      { get; } = 11;
        public static int TipoImpresora_Impresora       { get; } = 12;
        public static int Impresora_Caja                { get; } = 13;
        public static int Caja_ControlNumeracion        { get; } = 14;
        public static int EstadoMesa_Mesa               { get; } = 15;
        public static int ClaseEmp_Empleado             { get; } = 16;
        public static int CategoriaEmp_Empleado         { get; } = 17;
        public static int Producto_ComboFixedDtl        { get; } = 18;
        public static int Producto_ComboVariableDtl     { get; } = 19;
        public static int ComboGrupo_Combo              { get; } = 20;
        public static int ComboVariable_ComboFixedDtl   { get; } = 21;
        public static int Impuesto_ComboVariable        { get; } = 22;
        public static int Impuesto_Combo                { get; } = 23;
        public static int TipoRazon_Razon               { get; } = 24;
        public static int Trabajo_Empleado              { get; } = 25;
    }
}
