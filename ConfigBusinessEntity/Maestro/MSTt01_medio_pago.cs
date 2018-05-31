namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt01_medio_pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt01_medio_pago()
        {
            TNSt07_medio_pago_dtl = new HashSet<TNSt07_medio_pago_dtl>();
        }

        [Key]
        public int id_medio_pago { get; set; }

        [StringLength(10)]
        public string cod_medio_pago { get; set; }

        [Required]
        [StringLength(150)]
        public string txt_desc { get; set; }

        public bool req_ref { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public int? id_tipo_medio_pago { get; set; }

        public virtual SNTt01_tipo_medio_pago SNTt01_tipo_medio_pago { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt07_medio_pago_dtl> TNSt07_medio_pago_dtl { get; set; }
    }
}
