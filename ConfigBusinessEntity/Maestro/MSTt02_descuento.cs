namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt02_descuento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt02_descuento()
        {
            TNSt08_descuento_dtl = new HashSet<TNSt08_descuento_dtl>();
        }

        [Key]
        public int id_descuento { get; set; }

        [StringLength(10)]
        public string cod_descuento { get; set; }

        [StringLength(100)]
        public string txt_desc { get; set; }

        [StringLength(1)]
        public string tipo_descuento { get; set; }

        public decimal? porcentaje { get; set; }

        public decimal? monto { get; set; }

        public decimal? monto_min { get; set; }

        public decimal? monto_max { get; set; }

        public int? sn_descuen_periodo { get; set; }

        public int? sn_descuen_dia { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p1_fecha_ini { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p1_fecha_fin { get; set; }

        public TimeSpan? p1_hora_ini { get; set; }

        public TimeSpan? p1_hora_fin { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p2_fecha_ini { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p2_fecha_fin { get; set; }

        public TimeSpan? p2_hora_ini { get; set; }

        public TimeSpan? p2_hora_fin { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p3_fecha_ini { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p3_fecha_fin { get; set; }

        public TimeSpan? p3_hora_ini { get; set; }

        public TimeSpan? p3_hora_fin { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p4_fecha_ini { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p4_fecha_fin { get; set; }

        public TimeSpan? p4_hora_ini { get; set; }

        public TimeSpan? p4_hora_fin { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p5_fecha_ini { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p5_fecha_fin { get; set; }

        public TimeSpan? p5_hora_ini { get; set; }

        public TimeSpan? p5_hora_fin { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p6_fecha_ini { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p6_fecha_fin { get; set; }

        public TimeSpan? p6_hora_ini { get; set; }

        public TimeSpan? p6_hora_fin { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p7_fecha_ini { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? p7_fecha_fin { get; set; }

        public TimeSpan? p7_hora_ini { get; set; }

        public TimeSpan? p7_hora_fin { get; set; }

        public int? sn_domingo { get; set; }

        public int? sn_lunes { get; set; }

        public int? sn_martes { get; set; }

        public int? sn_miercoles { get; set; }

        public int? sn_jueves { get; set; }

        public int? sn_viernes { get; set; }

        public int? sn_sabado { get; set; }

        public TimeSpan? dom_hora_ini { get; set; }

        public TimeSpan? dom_hora_fin { get; set; }

        public TimeSpan? lun_hora_ini { get; set; }

        public TimeSpan? lun_hora_fin { get; set; }

        public TimeSpan? mar_hora_ini { get; set; }

        public TimeSpan? mar_hora_fin { get; set; }

        public TimeSpan? mie_hora_ini { get; set; }

        public TimeSpan? mie_hora_fin { get; set; }

        public TimeSpan? jue_hora_ini { get; set; }

        public TimeSpan? jue_hora_fin { get; set; }

        public TimeSpan? vie_hora_ini { get; set; }

        public TimeSpan? vie_hora_fin { get; set; }

        public TimeSpan? sab_hora_ini { get; set; }

        public TimeSpan? sab_hora_fin { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt08_descuento_dtl> TNSt08_descuento_dtl { get; set; }
    }
}
