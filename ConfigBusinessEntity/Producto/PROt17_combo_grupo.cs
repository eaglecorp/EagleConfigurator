namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt17_combo_grupo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROt17_combo_grupo()
        {
            PROt13_combo = new HashSet<PROt13_combo>();
        }

        [Key]
        public int id_combo_grupo { get; set; }

        [StringLength(10)]
        public string cod_combo_grupo { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt13_combo> PROt13_combo { get; set; }
    }
}
