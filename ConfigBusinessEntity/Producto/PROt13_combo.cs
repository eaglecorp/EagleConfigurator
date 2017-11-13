namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt13_combo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROt13_combo()
        {
            PROt09_producto = new HashSet<PROt09_producto>();
            PROt14_combo_fixed_dtl = new HashSet<PROt14_combo_fixed_dtl>();
        }

        [Key]
        public long id_combo { get; set; }

        [StringLength(10)]
        public string cod_combo { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public decimal mto_pvpu_sin_tax { get; set; }

        public decimal mto_pvpu_con_tax { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        public int id_combo_grupo { get; set; }

        public int? id_impuesto { get; set; }

        public int sn_incluye_impto { get; set; }

        public int sn_precio_acumulado { get; set; }

        public virtual MSTt06_impuesto MSTt06_impuesto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt09_producto> PROt09_producto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt14_combo_fixed_dtl> PROt14_combo_fixed_dtl { get; set; }

        public virtual PROt17_combo_grupo PROt17_combo_grupo { get; set; }
    }
}
