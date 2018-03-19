namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt05_razon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt05_razon()
        {
            LABt01_asistencia = new HashSet<LABt01_asistencia>();
            LABt02_asistencia_ajustada = new HashSet<LABt02_asistencia_ajustada>();
            TNSt05_comp_emitido_dtl = new HashSet<TNSt05_comp_emitido_dtl>();
            TNSt08_descuento_dtl = new HashSet<TNSt08_descuento_dtl>();
            TNSt02_comp_recibido_dtl = new HashSet<TNSt02_comp_recibido_dtl>();
        }

        [Key]
        public int id_razon { get; set; }

        [StringLength(10)]
        public string cod_razon { get; set; }

        [Required]
        [StringLength(100)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public int id_tipo_razon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABt01_asistencia> LABt01_asistencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABt02_asistencia_ajustada> LABt02_asistencia_ajustada { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt05_comp_emitido_dtl> TNSt05_comp_emitido_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt08_descuento_dtl> TNSt08_descuento_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt02_comp_recibido_dtl> TNSt02_comp_recibido_dtl { get; set; }

        public virtual MSTt16_tipo_razon MSTt16_tipo_razon { get; set; }
    }
}
