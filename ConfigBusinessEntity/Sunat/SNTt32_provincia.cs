namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt32_provincia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt32_provincia()
        {
            SNTt33_distrito = new HashSet<SNTt33_distrito>();
        }

        [Key]
        public int id_prov { get; set; }

        [Required]
        [StringLength(10)]
        public string cod_prov { get; set; }

        [StringLength(10)]
        public string cod_prov_ple { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public int id_dpto { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public virtual SNTt31_departamento SNTt31_departamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SNTt33_distrito> SNTt33_distrito { get; set; }
    }
}
