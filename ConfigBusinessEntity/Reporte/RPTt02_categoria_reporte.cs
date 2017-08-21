namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RPTt02_categoria_reporte
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RPTt02_categoria_reporte()
        {
            RPTt01_reporte = new HashSet<RPTt01_reporte>();
        }

        [Key]
        public int id_categoria_reporte { get; set; }

        [StringLength(10)]
        public string cod_categoria_reporte { get; set; }

        [Required]
        [StringLength(50)]
        public string txt_desc { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RPTt01_reporte> RPTt01_reporte { get; set; }
    }
}
