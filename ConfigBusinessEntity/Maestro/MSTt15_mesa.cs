namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt15_mesa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt15_mesa()
        {
            TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
        }

        [Key]
        public int id_mesa { get; set; }

        [StringLength(10)]
        public string cod_mesa { get; set; }

        [Required]
        [StringLength(5)]
        public string txt_num { get; set; }

        public int capacidad { get; set; }

        public int id_estado_mesa { get; set; }

        public int? id_can_vta { get; set; }

        public virtual MSTt04_canal_vta MSTt04_canal_vta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }

        public virtual MSTt16_estado_mesa MSTt16_estado_mesa { get; set; }
    }
}
