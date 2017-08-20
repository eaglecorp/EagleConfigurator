namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FISt02_nivel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FISt02_nivel()
        {
            FISt01_control_numeracion = new HashSet<FISt01_control_numeracion>();
        }

        [Key]
        public int id_nivel { get; set; }

        [StringLength(10)]
        public string cod_nivel { get; set; }

        [Required]
        [StringLength(100)]
        public string txt_desc { get; set; }

        public int id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FISt01_control_numeracion> FISt01_control_numeracion { get; set; }
    }
}
