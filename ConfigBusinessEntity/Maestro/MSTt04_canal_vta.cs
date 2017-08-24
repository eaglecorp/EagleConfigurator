namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt04_canal_vta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt04_canal_vta()
        {
            FISt01_control_numeracion = new HashSet<FISt01_control_numeracion>();
            MSTt14_mesa = new HashSet<MSTt14_mesa>();
            TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
        }

        [Key]
        public int id_can_vta { get; set; }

        [StringLength(10)]
        public string cod_can_vta { get; set; }

        [StringLength(10)]
        public string txt_abrv { get; set; }

        [StringLength(200)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FISt01_control_numeracion> FISt01_control_numeracion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt14_mesa> MSTt14_mesa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }
    }
}
