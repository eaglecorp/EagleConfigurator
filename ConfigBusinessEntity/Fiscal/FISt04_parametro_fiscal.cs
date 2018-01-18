namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FISt04_parametro_fiscal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FISt04_parametro_fiscal()
        {
            FISt05_configuracion_fiscal_caja = new HashSet<FISt05_configuracion_fiscal_caja>();
        }

        [Key]
        public int id_parametro_fiscal { get; set; }

        [Required]
        [StringLength(10)]
        public string cod_parametro_fiscal { get; set; }

        [Required]
        [StringLength(100)]
        public string txt_desc { get; set; }

        [StringLength(500)]
        public string valor_default { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FISt05_configuracion_fiscal_caja> FISt05_configuracion_fiscal_caja { get; set; }
    }
}
