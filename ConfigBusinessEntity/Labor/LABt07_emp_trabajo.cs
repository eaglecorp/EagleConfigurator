namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABt07_emp_trabajo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LABt07_emp_trabajo()
        {
            LABt01_asistencia = new HashSet<LABt01_asistencia>();
        }

        [Key]
        public long id_emp_trabajo { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public int id_trabajo { get; set; }

        public long id_empleado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABt01_asistencia> LABt01_asistencia { get; set; }

        public virtual LABt06_trabajo LABt06_trabajo { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }
    }
}
