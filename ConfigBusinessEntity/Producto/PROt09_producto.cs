namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt09_producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROt09_producto()
        {
            PROt08_precio_prod = new HashSet<PROt08_precio_prod>();
            TNSt02_comp_recibido_dtl = new HashSet<TNSt02_comp_recibido_dtl>();
            TNSt05_comp_emitido_dtl = new HashSet<TNSt05_comp_emitido_dtl>();
            PROt11_receta_dtl = new HashSet<PROt11_receta_dtl>();
            PROt14_combo_dtl = new HashSet<PROt14_combo_dtl>();
            PROt15_combo_size = new HashSet<PROt15_combo_size>();
        }

        [Key]
        public long id_producto { get; set; }

        [StringLength(50)]
        public string cod_producto { get; set; }

        [StringLength(50)]
        public string cod_producto2 { get; set; }

        [StringLength(20)]
        public string cod_barra { get; set; }

        [StringLength(350)]
        public string txt_desc { get; set; }

        public int? id_um { get; set; }

        public int? id_modelo { get; set; }

        public decimal? por_impto { get; set; }

        public int? id_tipo_moneda { get; set; }

        public decimal? mto_pvpu_con_igv { get; set; }

        public decimal? mto_pvmi_con_igv { get; set; }

        public decimal? mto_pvma_con_igv { get; set; }

        public decimal? mto_pvpu_sin_igv { get; set; }

        public decimal? mto_pvmi_sin_igv { get; set; }

        public decimal? mto_pvma_sin_igv { get; set; }

        public decimal? costo_prod { get; set; }

        [StringLength(10)]
        public string peso_prod { get; set; }

        [StringLength(10)]
        public string largo_prod { get; set; }

        [StringLength(10)]
        public string ancho_prod { get; set; }

        [StringLength(10)]
        public string altura_prod { get; set; }

        [StringLength(10)]
        public string diametro_prod { get; set; }

        [StringLength(300)]
        public string url_img_prod { get; set; }

        [StringLength(300)]
        public string txt_referencia { get; set; }

        public int? sn_combo { get; set; }

        public int? id_tipo_existencia { get; set; }

        public int? id_subfamilia { get; set; }

        public int? id_tipo_prod { get; set; }

        public int? id_clase_prod { get; set; }

        public long? id_receta { get; set; }

        public int? sn_exento { get; set; }

        public int? sn_inafecto { get; set; }

        public int? sn_venta { get; set; }

        public int? sn_compra { get; set; }

        public int? sn_receta { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public int? id_impuesto { get; set; }

        public long? id_combo { get; set; }

        public virtual MSTt06_impuesto MSTt06_impuesto { get; set; }

        public virtual PROt02_modelo PROt02_modelo { get; set; }

        public virtual PROt04_subfamilia PROt04_subfamilia { get; set; }

        public virtual PROt06_clase_prod PROt06_clase_prod { get; set; }

        public virtual PROt07_tipo_prod PROt07_tipo_prod { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt08_precio_prod> PROt08_precio_prod { get; set; }

        public virtual SNTt06_unidad_medida SNTt06_unidad_medida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt02_comp_recibido_dtl> TNSt02_comp_recibido_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TNSt05_comp_emitido_dtl> TNSt05_comp_emitido_dtl { get; set; }

        public virtual SNTt04_tipo_moneda SNTt04_tipo_moneda { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt11_receta_dtl> PROt11_receta_dtl { get; set; }

        public virtual SNTt05_tipo_existencia SNTt05_tipo_existencia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt14_combo_dtl> PROt14_combo_dtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PROt15_combo_size> PROt15_combo_size { get; set; }

        public virtual PROt10_receta PROt10_receta { get; set; }

        public virtual PROt13_combo PROt13_combo { get; set; }
    }
}
