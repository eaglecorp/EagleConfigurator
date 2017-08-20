namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt03_atencion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt03_atencion()
        {
            CLIt04_atencion_dtl = new HashSet<CLIt04_atencion_dtl>();
            CLIt08_funciones_vitales = new HashSet<CLIt08_funciones_vitales>();
            CLIt09_anamnesis = new HashSet<CLIt09_anamnesis>();
            CLIt10_examen_fisico = new HashSet<CLIt10_examen_fisico>();
            CLIt11_estudio_complementario = new HashSet<CLIt11_estudio_complementario>();
            CLIt13_laboratorio = new HashSet<CLIt13_laboratorio>();
            CLIt17_tratamiento = new HashSet<CLIt17_tratamiento>();
            CLIt15_diagnostico = new HashSet<CLIt15_diagnostico>();
            CLIt18_evolucion = new HashSet<CLIt18_evolucion>();
        }

        [Key]
        public long id_atencion { get; set; }

        [StringLength(20)]
        public string cod_atencion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fec_negocio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_registro { get; set; }

        public long? id_actividad { get; set; }

        public long? id_cita { get; set; }

        public long id_paciente { get; set; }

        public long id_empleado { get; set; }

        public long id_usuario { get; set; }

        [StringLength(50)]
        public string txt_usuario { get; set; }

        public int? id_estado { get; set; }

        [StringLength(50)]
        public string txt_estado { get; set; }

        public virtual CLIt01_paciente CLIt01_paciente { get; set; }

        public virtual CLIt02_actividad CLIt02_actividad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt04_atencion_dtl> CLIt04_atencion_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt08_funciones_vitales> CLIt08_funciones_vitales { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt09_anamnesis> CLIt09_anamnesis { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt10_examen_fisico> CLIt10_examen_fisico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt11_estudio_complementario> CLIt11_estudio_complementario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt13_laboratorio> CLIt13_laboratorio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt17_tratamiento> CLIt17_tratamiento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt15_diagnostico> CLIt15_diagnostico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt18_evolucion> CLIt18_evolucion { get; set; }

        public virtual CLIt19_cita CLIt19_cita { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }
    }
}
