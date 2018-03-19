namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt06_unidad_medida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SNTt06_unidad_medida()
        {
            PROt09_producto = new HashSet<PROt09_producto>();
            PROt11_receta_dtl = new HashSet<PROt11_receta_dtl>();
            TNSt05_comp_emitido_dtl = new HashSet<TNSt05_comp_emitido_dtl>();
            TNSt02_comp_recibido_dtl = new HashSet<TNSt02_comp_recibido_dtl>();
        }

        [Key]
        public int id_um { get; set; }

        [StringLength(10)]
        public string cod_um { get; set; }

        [StringLength(10)]
        public string cod_um_ple { get; set; }

        [StringLength(10)]
        public string txt_abrv { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        [StringLength(20)]
        public string txt_unid_base { get; set; }

        public int? id_um_base { get; set; }

        [StringLength(1)]
        public string txt_operacion { get; set; }

        public decimal? dec_factor { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt09_producto> PROt09_producto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt11_receta_dtl> PROt11_receta_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt05_comp_emitido_dtl> TNSt05_comp_emitido_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt02_comp_recibido_dtl> TNSt02_comp_recibido_dtl { get; set; }
    }
}
