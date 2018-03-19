namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABt01_asistencia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LABt01_asistencia()
        {
            LABt02_asistencia_ajustada = new HashSet<LABt02_asistencia_ajustada>();
        }

        [Key]
        public long id_asistencia { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fecha_cronologica { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_negocio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fecha_gmt { get; set; }

        [StringLength(200)]
        public string txt_obsv { get; set; }

        [StringLength(260)]
        public string txt_photo_path_clock_in { get; set; }

        [StringLength(260)]
        public string txt_photo_path_clock_out { get; set; }

        public int sn_clock_in { get; set; }

        public int sn_break_in { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime clock_in { get; set; }

        [StringLength(50)]
        public string clock_in_status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? break_in { get; set; }

        [StringLength(50)]
        public string break_in_status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? break_out { get; set; }

        [StringLength(50)]
        public string break_out_status { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? clock_out { get; set; }

        [StringLength(50)]
        public string clock_out_status { get; set; }

        public int? id_location { get; set; }

        public int? id_can_vta { get; set; }

        public long? id_emp_autorizador { get; set; }

        public int? id_razon { get; set; }

        public long id_emp_trabajo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABt02_asistencia_ajustada> LABt02_asistencia_ajustada { get; set; }

        public virtual LABt07_emp_trabajo LABt07_emp_trabajo { get; set; }

        public virtual MSTt04_canal_vta MSTt04_canal_vta { get; set; }

        public virtual MSTt05_razon MSTt05_razon { get; set; }

        public virtual MSTt08_location MSTt08_location { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }
    }
}
