namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt13_turno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt13_turno()
        {
            CSHt01_caja_dtl = new HashSet<CSHt01_caja_dtl>();
            LABt03_emp_turno = new HashSet<LABt03_emp_turno>();
            TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
        }

        [Key]
        public int id_turno { get; set; }

        [StringLength(10)]
        public string cod_turno { get; set; }

        [StringLength(10)]
        public string txt_abrv { get; set; }

        [Required]
        [StringLength(50)]
        public string txt_desc { get; set; }

        public TimeSpan hora_inicio { get; set; }

        public TimeSpan hora_fin { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CSHt01_caja_dtl> CSHt01_caja_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABt03_emp_turno> LABt03_emp_turno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }
    }
}
