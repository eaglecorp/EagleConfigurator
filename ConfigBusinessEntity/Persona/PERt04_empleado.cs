namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERt04_empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERt04_empleado()
        {
            CLIt03_atencion = new HashSet<CLIt03_atencion>();
            CLIt04_atencion_dtl = new HashSet<CLIt04_atencion_dtl>();
            CLIt19_cita = new HashSet<CLIt19_cita>();
            MSTt13_caja_dtl = new HashSet<MSTt13_caja_dtl>();
            PERt01_usuario = new HashSet<PERt01_usuario>();
            TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
            TNSt04_comp_emitido1 = new HashSet<TNSt04_comp_emitido>();
        }

        [Key]
        public long id_empleado { get; set; }

        [StringLength(20)]
        public string cod_empleado { get; set; }

        [Required]
        [StringLength(1)]
        public string cod_tipo_per { get; set; }

        public int? id_tipo_doc_identidad { get; set; }

        [StringLength(15)]
        public string nro_doc { get; set; }

        [StringLength(15)]
        public string nro_ruc { get; set; }

        [StringLength(1)]
        public string sexo { get; set; }

        [StringLength(200)]
        public string txt_ape_pat { get; set; }

        [StringLength(150)]
        public string txt_ape_mat { get; set; }

        [StringLength(120)]
        public string txt_pri_nom { get; set; }

        [StringLength(100)]
        public string txt_seg_nom { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_nac { get; set; }

        [StringLength(350)]
        public string txt_rzn_social { get; set; }

        [StringLength(350)]
        public string txt_nom_comercial { get; set; }

        public int? id_estado_civil { get; set; }

        public int? id_via { get; set; }

        [StringLength(250)]
        public string nom_via { get; set; }

        [StringLength(20)]
        public string nro_via { get; set; }

        public int? id_zona { get; set; }

        [StringLength(250)]
        public string nom_zona { get; set; }

        [StringLength(350)]
        public string txt_direccion1 { get; set; }

        [StringLength(350)]
        public string txt_direccion2 { get; set; }

        [StringLength(350)]
        public string txt_referencia { get; set; }

        [StringLength(50)]
        public string txt_email1 { get; set; }

        [StringLength(50)]
        public string txt_email2 { get; set; }

        [StringLength(50)]
        public string txt_web { get; set; }

        [StringLength(100)]
        public string telef_fijo1 { get; set; }

        [StringLength(100)]
        public string telef_fijo2 { get; set; }

        [StringLength(100)]
        public string telef_fijo3 { get; set; }

        [StringLength(100)]
        public string celular1 { get; set; }

        [StringLength(100)]
        public string celular2 { get; set; }

        [StringLength(100)]
        public string celular3 { get; set; }

        [StringLength(600)]
        public string url_img { get; set; }

        [StringLength(300)]
        public string info01 { get; set; }

        [StringLength(300)]
        public string info02 { get; set; }

        [StringLength(300)]
        public string info03 { get; set; }

        [StringLength(300)]
        public string info04 { get; set; }

        [StringLength(300)]
        public string info05 { get; set; }

        [StringLength(300)]
        public string info06 { get; set; }

        [StringLength(300)]
        public string info07 { get; set; }

        [StringLength(300)]
        public string info08 { get; set; }

        [StringLength(300)]
        public string info09 { get; set; }

        [StringLength(300)]
        public string info10 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha_ingreso { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha_cese { get; set; }

        public decimal? salario_mensual { get; set; }

        public decimal? salario_quincenal { get; set; }

        public decimal? salario_hora { get; set; }

        public decimal? nro_hora_mes { get; set; }

        [StringLength(50)]
        public string nro_cuenta { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public int? id_dist { get; set; }

        public int? id_nacionalidad { get; set; }

        public int? id_entidad_financiera { get; set; }

        public int? id_tipo_trabajador { get; set; }

        public int? id_situacion_educativa { get; set; }

        public int? id_ocupacion { get; set; }

        public int? id_regimen_pensionario { get; set; }

        public int? id_condicion_laboral { get; set; }

        public int? id_periodo_remuneracion { get; set; }

        public int? id_salud_eps { get; set; }

        public int? id_situacion { get; set; }

        public int? id_motivo_baja { get; set; }

        public int? id_modalidad_formativa { get; set; }

        public int? id_suspencion_laboral { get; set; }

        public int? id_regimen_salud { get; set; }

        public int? id_regimen_laboral { get; set; }

        public int? id_especialidad_medica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt03_atencion> CLIt03_atencion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt04_atencion_dtl> CLIt04_atencion_dtl { get; set; }

        public virtual CLIt07_especialidad_medica CLIt07_especialidad_medica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt19_cita> CLIt19_cita { get; set; }

        public virtual MSTt07_estado_civil MSTt07_estado_civil { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MSTt13_caja_dtl> MSTt13_caja_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERt01_usuario> PERt01_usuario { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido1 { get; set; }

        public virtual SNTt02_tipo_doc_identidad SNTt02_tipo_doc_identidad { get; set; }

        public virtual SNTt03_entidad_financiera SNTt03_entidad_financiera { get; set; }

        public virtual SNTt14_nacionalidad SNTt14_nacionalidad { get; set; }

        public virtual SNTt15_via SNTt15_via { get; set; }

        public virtual SNTt16_zona SNTt16_zona { get; set; }

        public virtual SNTt17_tipo_trabajador SNTt17_tipo_trabajador { get; set; }

        public virtual SNTt18_situacion_educativa SNTt18_situacion_educativa { get; set; }

        public virtual SNTt19_ocupacion SNTt19_ocupacion { get; set; }

        public virtual SNTt20_regimen_pensionario SNTt20_regimen_pensionario { get; set; }

        public virtual SNTt21_condicion_laboral SNTt21_condicion_laboral { get; set; }

        public virtual SNTt22_periodo_remuneracion SNTt22_periodo_remuneracion { get; set; }

        public virtual SNTt23_salud_eps SNTt23_salud_eps { get; set; }

        public virtual SNTt24_situacion SNTt24_situacion { get; set; }

        public virtual SNTt25_motivo_baja SNTt25_motivo_baja { get; set; }

        public virtual SNTt26_modalidad_formativa SNTt26_modalidad_formativa { get; set; }

        public virtual SNTt28_suspencion_laboral SNTt28_suspencion_laboral { get; set; }

        public virtual SNTt29_regimen_salud SNTt29_regimen_salud { get; set; }

        public virtual SNTt30_regimen_laboral SNTt30_regimen_laboral { get; set; }

        public virtual SNTt33_distrito SNTt33_distrito { get; set; }
    }
}
