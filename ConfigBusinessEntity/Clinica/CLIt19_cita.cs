namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt19_cita
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CLIt19_cita()
        {
            CLIt03_atencion = new HashSet<CLIt03_atencion>();
        }

        [Key]
        public long id_cita { get; set; }

        [StringLength(10)]
        public string cod_cita { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fec_cita { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_registro { get; set; }

        [StringLength(20)]
        public string hora { get; set; }

        [StringLength(20)]
        public string duracion { get; set; }

        [StringLength(200)]
        public string txt_obs { get; set; }

        public int? sn_asistencia { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public long id_empleado { get; set; }

        public long id_paciente { get; set; }

        public virtual CLIt01_paciente CLIt01_paciente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt03_atencion> CLIt03_atencion { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }
    }
}
