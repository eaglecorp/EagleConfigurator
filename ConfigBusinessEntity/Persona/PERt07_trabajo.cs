namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERt07_trabajo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERt07_trabajo()
        {
            PERt08_emp_trabajo = new HashSet<PERt08_emp_trabajo>();
        }

        [Key]
        public int id_trabajo { get; set; }

        [StringLength(10)]
        public string cod_trabajo { get; set; }

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
        public virtual ICollection<PERt08_emp_trabajo> PERt08_emp_trabajo { get; set; }
    }
}
