namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt04_atencion_dtl
    {
        [Key]
        public long id_atencion_dtl { get; set; }

        [StringLength(10)]
        public string cod_atencion_dtl { get; set; }

        public long? id_atencion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fec_negocio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_registro { get; set; }

        public long? id_actividad { get; set; }

        [StringLength(500)]
        public string txt_observacion { get; set; }

        public int? id_estado { get; set; }

        [StringLength(50)]
        public string txt_estado { get; set; }

        public long id_empleado { get; set; }

        public virtual CLIt02_actividad CLIt02_actividad { get; set; }

        public virtual CLIt03_atencion CLIt03_atencion { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }
    }
}
