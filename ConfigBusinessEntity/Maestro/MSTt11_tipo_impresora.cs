namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt11_tipo_impresora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt11_tipo_impresora()
        {
            MSTt10_impresora = new HashSet<MSTt10_impresora>();
        }

        [Key]
        public int id_tipo_impresora { get; set; }

        [StringLength(10)]
        public string cod_tipo_impresora { get; set; }

        [StringLength(100)]
        public string txt_desc { get; set; }

        [StringLength(100)]
        public string txt_info01 { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt10_impresora> MSTt10_impresora { get; set; }
    }
}
