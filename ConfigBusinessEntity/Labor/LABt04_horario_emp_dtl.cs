namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABt04_horario_emp_dtl
    {
        [Key]
        public long id_horario_emp_dtl { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_labor { get; set; }

        public TimeSpan hora_inicio { get; set; }

        public TimeSpan hora_fin { get; set; }

        public TimeSpan? hora_inicio_break { get; set; }

        public TimeSpan? hora_fin_break { get; set; }

        public TimeSpan tiempo_tolerancia { get; set; }

        public long id_horario_emp { get; set; }

        public int? id_turno { get; set; }

        public virtual LABt03_horario_emp LABt03_horario_emp { get; set; }

        public virtual MSTt13_turno MSTt13_turno { get; set; }
    }
}
