namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt06_tipo_especialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt06_tipo_especialidad()
        {
            CLIt07_especialidad_medica = new HashSet<CLIt07_especialidad_medica>();
        }

        [Key]
        public int id_tipo_especialidad { get; set; }

        [StringLength(10)]
        public string cod_tipo_especialidad { get; set; }

        [StringLength(250)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt07_especialidad_medica> CLIt07_especialidad_medica { get; set; }
    }
}
