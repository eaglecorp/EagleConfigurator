namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt07_medio_pago_dtl
    {
        [Key]
        public long id_medio_pago_dtl { get; set; }

        public long? id_comp_emitido { get; set; }

        public int? id_medio_pago { get; set; }

        public decimal? impuesto { get; set; }

        public decimal? monto { get; set; }

        public decimal? mto_tipo_cambio { get; set; }

        [StringLength(300)]
        public string txt_observ { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public virtual MSTt01_medio_pago MSTt01_medio_pago { get; set; }

        public virtual TNSt04_comp_emitido TNSt04_comp_emitido { get; set; }
    }
}
