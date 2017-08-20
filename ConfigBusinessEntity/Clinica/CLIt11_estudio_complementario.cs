namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt11_estudio_complementario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt11_estudio_complementario()
        {
            CLIt12_archivo_complementario = new HashSet<CLIt12_archivo_complementario>();
        }

        [Key]
        public long id_estudio_complementario { get; set; }

        [StringLength(10)]
        public string cod_estudio_complementario { get; set; }

        [StringLength(5000)]
        public string txt_desc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fec_negocio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_registro { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public long? id_atencion { get; set; }

        public virtual CLIt03_atencion CLIt03_atencion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt12_archivo_complementario> CLIt12_archivo_complementario { get; set; }
    }
}
