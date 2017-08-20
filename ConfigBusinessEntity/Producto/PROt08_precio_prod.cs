namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt08_precio_prod
    {
        [Key]
        public long id_precio_prod { get; set; }

        public long? id_producto { get; set; }

        public decimal? mto_pu_sin_igv_1 { get; set; }

        public decimal? mto_pu_sin_igv_2 { get; set; }

        public decimal? mto_pu_sin_igv_3 { get; set; }

        public decimal? mto_pu_sin_igv_4 { get; set; }

        public decimal? mto_pu_sin_igv_5 { get; set; }

        public decimal? mto_pu_sin_igv_6 { get; set; }

        public decimal? mto_pu_sin_igv_7 { get; set; }

        public decimal? mto_pu_sin_igv_8 { get; set; }

        public decimal? mto_pu_sin_igv_9 { get; set; }

        public decimal? mto_pu_sin_igv_10 { get; set; }

        public decimal? mto_pu_con_igv_1 { get; set; }

        public decimal? mto_pu_con_igv_2 { get; set; }

        public decimal? mto_pu_con_igv_3 { get; set; }

        public decimal? mto_pu_con_igv_4 { get; set; }

        public decimal? mto_pu_con_igv_5 { get; set; }

        public decimal? mto_pu_con_igv_6 { get; set; }

        public decimal? mto_pu_con_igv_7 { get; set; }

        public decimal? mto_pu_con_igv_8 { get; set; }

        public decimal? mto_pu_con_igv_9 { get; set; }

        public decimal? mto_pu_con_igv_10 { get; set; }

        public decimal? mto_costo_1 { get; set; }

        public decimal? mto_costo_2 { get; set; }

        public decimal? mto_costo_3 { get; set; }

        public decimal? mto_costo_4 { get; set; }

        public decimal? mto_costo_5 { get; set; }

        public decimal? mto_costo_6 { get; set; }

        public decimal? mto_costo_7 { get; set; }

        public decimal? mto_costo_8 { get; set; }

        public decimal? mto_costo_9 { get; set; }

        public decimal? mto_costo_10 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_efectivo_desde { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_efectivo_hasta { get; set; }

        [StringLength(500)]
        public string txt_obsv { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public virtual PROt09_producto PROt09_producto { get; set; }
    }
}
