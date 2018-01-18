namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt16_tipo_razon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt16_tipo_razon()
        {
            MSTt05_razon = new HashSet<MSTt05_razon>();
        }

        [Key]
        public int id_tipo_razon { get; set; }

        [StringLength(10)]
        public string cod_tipo_razon { get; set; }

        [Required]
        [StringLength(50)]
        public string txt_desc { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt05_razon> MSTt05_razon { get; set; }
    }
}
