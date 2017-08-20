namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt01_tipo_medio_pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt01_tipo_medio_pago()
        {
            MSTt01_medio_pago = new HashSet<MSTt01_medio_pago>();
        }

        [Key]
        public int id_tipo_medio_pago { get; set; }

        [StringLength(10)]
        public string cod_tipo_medio_pago { get; set; }

        [StringLength(10)]
        public string cod_tipo_medio_pago_ple { get; set; }

        [StringLength(250)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt01_medio_pago> MSTt01_medio_pago { get; set; }
    }
}
