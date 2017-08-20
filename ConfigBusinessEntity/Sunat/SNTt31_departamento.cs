namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt31_departamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt31_departamento()
        {
            SNTt32_provincia = new HashSet<SNTt32_provincia>();
        }

        [Key]
        public int id_dpto { get; set; }

        [Required]
        [StringLength(10)]
        public string cod_dpto { get; set; }

        [StringLength(10)]
        public string cod_dpto_ple { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SNTt32_provincia> SNTt32_provincia { get; set; }
    }
}
