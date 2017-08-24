namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt12_caja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt12_caja()
        {
            CSHt01_caja_dtl = new HashSet<CSHt01_caja_dtl>();
            FISt01_control_numeracion = new HashSet<FISt01_control_numeracion>();
            GRLt04_configuracion_caja = new HashSet<GRLt04_configuracion_caja>();
        }

        [Key]
        public int id_caja { get; set; }

        [StringLength(10)]
        public string cod_caja { get; set; }

        [Required]
        [StringLength(100)]
        public string txt_desc { get; set; }

        [StringLength(100)]
        public string txt_ip { get; set; }

        [StringLength(100)]
        public string txt_info01 { get; set; }

        [StringLength(100)]
        public string txt_info02 { get; set; }

        public int? id_impresora { get; set; }

        public int? id_impresora02 { get; set; }

        public int? id_impresora03 { get; set; }

        public int? id_impresora04 { get; set; }

        public int? id_impresora05 { get; set; }

        public int? id_impresora06 { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CSHt01_caja_dtl> CSHt01_caja_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FISt01_control_numeracion> FISt01_control_numeracion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GRLt04_configuracion_caja> GRLt04_configuracion_caja { get; set; }

        public virtual MSTt10_impresora MSTt10_impresora { get; set; }

        public virtual MSTt10_impresora MSTt10_impresora1 { get; set; }

        public virtual MSTt10_impresora MSTt10_impresora2 { get; set; }

        public virtual MSTt10_impresora MSTt10_impresora3 { get; set; }

        public virtual MSTt10_impresora MSTt10_impresora4 { get; set; }

        public virtual MSTt10_impresora MSTt10_impresora5 { get; set; }
    }
}
