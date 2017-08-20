namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt01_paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt01_paciente()
        {
            CLIt05_antece_alergia = new HashSet<CLIt05_antece_alergia>();
            CLIt03_atencion = new HashSet<CLIt03_atencion>();
            CLIt19_cita = new HashSet<CLIt19_cita>();
        }

        [Key]
        public long id_paciente { get; set; }

        [StringLength(15)]
        public string cod_paciente { get; set; }

        [StringLength(15)]
        public string nro_hist_clinica { get; set; }

        [StringLength(100)]
        public string grupo_sanguineo { get; set; }

        [StringLength(1000)]
        public string observaciones { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public int? id_ocupacion { get; set; }

        public int? id_salud_eps { get; set; }

        public int? id_regimen_salud { get; set; }

        public long? id_cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt05_antece_alergia> CLIt05_antece_alergia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt03_atencion> CLIt03_atencion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt19_cita> CLIt19_cita { get; set; }

        public virtual PERt02_cliente PERt02_cliente { get; set; }

        public virtual SNTt19_ocupacion SNTt19_ocupacion { get; set; }

        public virtual SNTt23_salud_eps SNTt23_salud_eps { get; set; }

        public virtual SNTt29_regimen_salud SNTt29_regimen_salud { get; set; }
    }
}
