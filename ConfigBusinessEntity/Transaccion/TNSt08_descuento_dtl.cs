namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt08_descuento_dtl
    {
        [Key]
        public long id_descuento_dtl { get; set; }

        public long? id_comp_emitido { get; set; }

        public int? id_descuento { get; set; }

        public decimal? porcentaje { get; set; }

        public decimal? monto { get; set; }

        public int? id_razon { get; set; }

        [StringLength(600)]
        public string txt_observ { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public long? id_emp_autorizador { get; set; }

        public virtual MSTt02_descuento MSTt02_descuento { get; set; }

        public virtual MSTt05_razon MSTt05_razon { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }

        public virtual TNSt04_comp_emitido TNSt04_comp_emitido { get; set; }
    }
}
