namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt10_impresora
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt10_impresora()
        {
            MSTt12_caja = new HashSet<MSTt12_caja>();
            MSTt12_caja1 = new HashSet<MSTt12_caja>();
            MSTt12_caja2 = new HashSet<MSTt12_caja>();
            MSTt12_caja3 = new HashSet<MSTt12_caja>();
            MSTt12_caja4 = new HashSet<MSTt12_caja>();
            MSTt12_caja5 = new HashSet<MSTt12_caja>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_impresora { get; set; }

        [StringLength(10)]
        public string cod_impresora { get; set; }

        [StringLength(100)]
        public string txt_desc { get; set; }

        [StringLength(100)]
        public string txt_ip { get; set; }

        public int id_tipo_impresora { get; set; }

        [StringLength(100)]
        public string txt_marca { get; set; }

        [StringLength(100)]
        public string txt_modelo { get; set; }

        [StringLength(100)]
        public string txt_info01 { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt12_caja> MSTt12_caja { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt12_caja> MSTt12_caja1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt12_caja> MSTt12_caja2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt12_caja> MSTt12_caja3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt12_caja> MSTt12_caja4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt12_caja> MSTt12_caja5 { get; set; }

        public virtual MSTt11_tipo_impresora MSTt11_tipo_impresora { get; set; }
    }
}
