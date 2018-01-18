namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FISt05_configuracion_fiscal_caja
    {
        [Key]
        public int id_configuracion_fiscal_caja { get; set; }

        [StringLength(500)]
        public string valor { get; set; }

        public int id_parametro_fiscal { get; set; }

        public int id_caja { get; set; }

        public virtual FISt04_parametro_fiscal FISt04_parametro_fiscal { get; set; }

        public virtual MSTt12_caja MSTt12_caja { get; set; }
    }
}
