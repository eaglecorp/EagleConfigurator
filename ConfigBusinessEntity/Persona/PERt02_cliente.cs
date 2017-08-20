namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERt02_cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PERt02_cliente()
        {
            CLIt01_paciente = new HashSet<CLIt01_paciente>();
            TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
        }

        [Key]
        public long id_cliente { get; set; }

        [StringLength(20)]
        public string cod_cliente { get; set; }

        [Required]
        [StringLength(1)]
        public string cod_tipo_per { get; set; }

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

        [StringLength(250)]
        public string nom_via { get; set; }

        [StringLength(20)]
        public string nro_via { get; set; }

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

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public int? id_estado_civil { get; set; }

        public int? id_via { get; set; }

        public int? id_zona { get; set; }

        public int? id_dist { get; set; }

        public int? id_tipo_doc_identidad { get; set; }

        public int? id_nacionalidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIt01_paciente> CLIt01_paciente { get; set; }

        public virtual MSTt07_estado_civil MSTt07_estado_civil { get; set; }

        public virtual SNTt02_tipo_doc_identidad SNTt02_tipo_doc_identidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }

        public virtual SNTt14_nacionalidad SNTt14_nacionalidad { get; set; }

        public virtual SNTt15_via SNTt15_via { get; set; }

        public virtual SNTt16_zona SNTt16_zona { get; set; }

        public virtual SNTt33_distrito SNTt33_distrito { get; set; }
    }
}
