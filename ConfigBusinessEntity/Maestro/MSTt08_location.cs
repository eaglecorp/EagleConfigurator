namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MSTt08_location
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MSTt08_location()
        {
            LABt01_asistencia = new HashSet<LABt01_asistencia>();
            TNSt04_comp_emitido = new HashSet<TNSt04_comp_emitido>();
            TNSt01_comp_recibido = new HashSet<TNSt01_comp_recibido>();
        }

        [Key]
        public int id_location { get; set; }

        [StringLength(10)]
        public string cod_location { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha_negocio { get; set; }

        [StringLength(300)]
        public string txt_direccion1 { get; set; }

        [StringLength(300)]
        public string txt_direccion2 { get; set; }

        [StringLength(30)]
        public string txt_abrev1 { get; set; }

        [StringLength(30)]
        public string txt_abrev2 { get; set; }

        [StringLength(20)]
        public string nro_ruc { get; set; }

        [StringLength(20)]
        public string fono1 { get; set; }

        [StringLength(20)]
        public string fono2 { get; set; }

        [StringLength(150)]
        public string txt_datos1 { get; set; }

        [StringLength(150)]
        public string txt_datos2 { get; set; }

        [StringLength(150)]
        public string txt_datos3 { get; set; }

        [StringLength(150)]
        public string txt_datos4 { get; set; }

        public decimal? latitud { get; set; }

        public decimal? longitud { get; set; }

        public int? sn_almacen { get; set; }

        public int? sn_location_current { get; set; }

        public int id_tipo_location { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABt01_asistencia> LABt01_asistencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt04_comp_emitido> TNSt04_comp_emitido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt01_comp_recibido> TNSt01_comp_recibido { get; set; }

        public virtual MSTt09_tipo_location MSTt09_tipo_location { get; set; }
    }
}
