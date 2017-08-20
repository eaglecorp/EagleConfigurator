namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt33_distrito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt33_distrito()
        {
            PERt02_cliente = new HashSet<PERt02_cliente>();
            PERt03_proveedor = new HashSet<PERt03_proveedor>();
            PERt04_empleado = new HashSet<PERt04_empleado>();
        }

        [Key]
        public int id_dist { get; set; }

        [Required]
        [StringLength(10)]
        public string cod_dist { get; set; }

        [StringLength(10)]
        public string cod_dist_ple { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        public int id_prov { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt02_cliente> PERt02_cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt03_proveedor> PERt03_proveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt04_empleado> PERt04_empleado { get; set; }

        public virtual SNTt32_provincia SNTt32_provincia { get; set; }
    }
}
