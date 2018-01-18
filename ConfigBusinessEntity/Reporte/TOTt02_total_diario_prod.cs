namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOTt02_total_diario_prod
    {
        [Key]
        public long id_total_diario_prod { get; set; }

        public int? id_location { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fec_registro { get; set; }

        [Column(TypeName = "date")]
        public DateTime fec_negocio { get; set; }

        public int? id_can_vta { get; set; }

        public int? id_tipo_orden { get; set; }

        public long? id_producto { get; set; }

        public int? id_um { get; set; }

        public decimal? soh_ini { get; set; }

        public decimal? soh_fin { get; set; }

        public decimal? cant_compra { get; set; }

        public decimal? cant_transf_in { get; set; }

        public decimal? cant_trans_out { get; set; }

        public decimal? cant_vta { get; set; }

        public decimal? precio { get; set; }

        public decimal? precio_last { get; set; }

        public decimal? precio_avg { get; set; }

        public decimal? costo { get; set; }

        public long? id_usuario { get; set; }

        [StringLength(50)]
        public string txt_usuario { get; set; }

        public int? post { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? post_date { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }
    }
}
