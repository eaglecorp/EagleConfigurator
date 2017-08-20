namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt13_laboratorio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt13_laboratorio()
        {
            CLIt14_img_laboratorio = new HashSet<CLIt14_img_laboratorio>();
        }

        [Key]
        public long id_laboratorio { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fec_negocio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_registro { get; set; }

        [StringLength(5000)]
        public string hemograma { get; set; }

        [StringLength(5000)]
        public string urinalisis { get; set; }

        [StringLength(5000)]
        public string perfil_renal { get; set; }

        [StringLength(5000)]
        public string perfil_lipidico { get; set; }

        [StringLength(5000)]
        public string perfil_hepatico { get; set; }

        [StringLength(5000)]
        public string perfil_triode { get; set; }

        [StringLength(5000)]
        public string panel_metabolico { get; set; }

        [StringLength(5000)]
        public string otros { get; set; }

        public int? id_usuario { get; set; }

        [StringLength(50)]
        public string txt_usuario { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public long? id_atencion { get; set; }

        public virtual CLIt03_atencion CLIt03_atencion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt14_img_laboratorio> CLIt14_img_laboratorio { get; set; }
    }
}
