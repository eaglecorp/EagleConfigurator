namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt12_combo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROt12_combo()
        {
            PROt09_producto = new HashSet<PROt09_producto>();
            PROt13_combo_dtl = new HashSet<PROt13_combo_dtl>();
        }

        [Key]
        public long id_combo { get; set; }

        [StringLength(10)]
        public string cod_combo { get; set; }

        [StringLength(250)]
        public string txt_desc { get; set; }

        public decimal? mto_pvpu_sin_igv { get; set; }

        public decimal? mto_pvpu_con_igv { get; set; }

        public long? id_combo_grupo { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt09_producto> PROt09_producto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt13_combo_dtl> PROt13_combo_dtl { get; set; }

        public virtual PROt14_combo_grupo PROt14_combo_grupo { get; set; }
    }
}
