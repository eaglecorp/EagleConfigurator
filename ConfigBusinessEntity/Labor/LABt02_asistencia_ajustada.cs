namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LABt02_asistencia_ajustada
    {
        [Key]
        public long id_asistencia_ajustada { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fecha_cronologica { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fecha_cronologica_ajust { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_negocio { get; set; }

        [Column(TypeName = "date")]
        public DateTime fecha_negocio_ajust { get; set; }

        [StringLength(200)]
        public string txt_obsv { get; set; }

        [StringLength(260)]
        public string txt_photo_path_clock_in_ajust { get; set; }

        [StringLength(260)]
        public string txt_photo_path_clock_out_ajust { get; set; }

        public int sn_clock_in { get; set; }

        public int sn_break_in { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? clock_in { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? clock_in_ajust { get; set; }

        [StringLength(50)]
        public string clock_in_status { get; set; }

        [StringLength(50)]
        public string clock_in_status_ajust { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? break_in { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? break_in_ajust { get; set; }

        [StringLength(50)]
        public string break_in_status { get; set; }

        [StringLength(50)]
        public string break_in_status_ajust { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? break_out { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? break_out_ajust { get; set; }

        [StringLength(50)]
        public string break_out_status { get; set; }

        [StringLength(50)]
        public string break_out_status_ajust { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? clock_out { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? clock_out_ajust { get; set; }

        [StringLength(50)]
        public string clock_out_status { get; set; }

        [StringLength(50)]
        public string clock_out_status_ajust { get; set; }

        public long id_asistencia { get; set; }

        public int id_razon { get; set; }

        public long id_emp_autorizador { get; set; }

        public virtual LABt01_asistencia LABt01_asistencia { get; set; }

        public virtual MSTt05_razon MSTt05_razon { get; set; }

        public virtual PERt04_empleado PERt04_empleado { get; set; }
    }
}
