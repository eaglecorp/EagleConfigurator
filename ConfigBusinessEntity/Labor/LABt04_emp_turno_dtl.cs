namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABt04_emp_turno_dtl
    {
        [Key]
        public long id_emp_turno_dtl { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_labor { get; set; }

        public int sn_custom_clock { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime start_clock { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime end_clock { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public long id_emp_turno { get; set; }

        public virtual LABt03_emp_turno LABt03_emp_turno { get; set; }
    }
}
