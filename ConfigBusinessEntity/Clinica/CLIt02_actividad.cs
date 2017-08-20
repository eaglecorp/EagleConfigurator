namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt02_actividad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt02_actividad()
        {
            CLIt03_atencion = new HashSet<CLIt03_atencion>();
            CLIt04_atencion_dtl = new HashSet<CLIt04_atencion_dtl>();
        }

        [Key]
        public long id_actividad { get; set; }

        [StringLength(20)]
        public string cod_actividad { get; set; }

        [StringLength(250)]
        public string txt_desc { get; set; }

        [StringLength(250)]
        public string txt_observacion { get; set; }

        public int? nro_orden { get; set; }

        public int? id_actividad_prev { get; set; }

        public int? id_actividad_next { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt03_atencion> CLIt03_atencion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt04_atencion_dtl> CLIt04_atencion_dtl { get; set; }
    }
}
