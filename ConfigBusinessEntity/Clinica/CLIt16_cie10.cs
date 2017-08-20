namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt16_cie10
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt16_cie10()
        {
            CLIt15_diagnostico = new HashSet<CLIt15_diagnostico>();
        }

        [Key]
        public int id_cie10 { get; set; }

        [StringLength(50)]
        public string COD_3 { get; set; }

        [StringLength(2000)]
        public string CATEGORIA { get; set; }

        [StringLength(50)]
        public string COD_4 { get; set; }

        [StringLength(2000)]
        public string DESCRIPCION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt15_diagnostico> CLIt15_diagnostico { get; set; }
    }
}
