namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERt06_clase_emp
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERt06_clase_emp()
        {
            PERt04_empleado = new HashSet<PERt04_empleado>();
            PERt08_security_access = new HashSet<PERt08_security_access>();
        }

        [Key]
        public int id_clase_emp { get; set; }

        [StringLength(10)]
        public string cod_clase_emp { get; set; }

        [Required]
        [StringLength(100)]
        public string txt_nombre { get; set; }

        [StringLength(750)]
        public string txt_desc { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt04_empleado> PERt04_empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt08_security_access> PERt08_security_access { get; set; }
    }
}
