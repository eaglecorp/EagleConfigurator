namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABt03_emp_turno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LABt03_emp_turno()
        {
            LABt04_emp_turno_dtl = new HashSet<LABt04_emp_turno_dtl>();
        }

        [Key]
        public long id_emp_turno { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public int id_turno { get; set; }

        public long id_empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABt04_emp_turno_dtl> LABt04_emp_turno_dtl { get; set; }

        public virtual MSTt13_turno MSTt13_turno { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }
    }
}
