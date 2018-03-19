namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABt03_horario_emp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LABt03_horario_emp()
        {
            LABt04_horario_emp_dtl = new HashSet<LABt04_horario_emp_dtl>();
        }

        [Key]
        public long id_horario_emp { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_inicio_horario { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_fin_horario { get; set; }

        public long id_empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABt04_horario_emp_dtl> LABt04_horario_emp_dtl { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }
    }
}
