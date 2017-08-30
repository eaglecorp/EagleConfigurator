namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt15_combo_variable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROt15_combo_variable()
        {
            PROt14_combo_fixed_dtl = new HashSet<PROt14_combo_fixed_dtl>();
            PROt16_combo_variable_dtl = new HashSet<PROt16_combo_variable_dtl>();
        }

        [Key]
        public int id_combo_variable { get; set; }

        [StringLength(10)]
        public string cod_combo_variable { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public decimal mto_pvpu_sin_tax { get; set; }

        public decimal mto_pvpu_con_tax { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt14_combo_fixed_dtl> PROt14_combo_fixed_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt16_combo_variable_dtl> PROt16_combo_variable_dtl { get; set; }
    }
}
