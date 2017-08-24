namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CSHt01_caja_dtl
    {
        [Key]
        public long id_caja_dtl { get; set; }

        public int id_caja { get; set; }

        public long id_empleado { get; set; }

        public long id_emp_autorizador { get; set; }

        public bool sn_open { get; set; }

        public bool sn_close { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha { get; set; }

        public TimeSpan hora { get; set; }

        public int id_turno { get; set; }

        public virtual MSTt12_caja MSTt12_caja { get; set; }

        public virtual MSTt13_turno MSTt13_turno { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }

        public virtual PERt04_empleado PERt04_empleado1 { get; set; }
    }
}
