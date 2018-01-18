namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOTt01_total_diario_vta
    {
        [Key]
        public long id_total_diario_vta { get; set; }

        public int? id_location { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime fec_registro { get; set; }

        [Column(TypeName = "date")]
        public DateTime fec_negocio { get; set; }

        public int? cant_ordenes { get; set; }

        public decimal? mto_ordenes { get; set; }

        public int? cant_boletas { get; set; }

        public decimal? mto_boletas { get; set; }

        public int? cant_facturas { get; set; }

        public decimal? mto_facturas { get; set; }

        public int? cant_not_cred { get; set; }

        public decimal? mto_not_cred { get; set; }

        public int? cant_comprobantes { get; set; }

        public decimal? mto_comprobantes { get; set; }

        public decimal? mto_forma_pago01 { get; set; }

        public decimal? mto_forma_pago02 { get; set; }

        public decimal? mto_forma_pago03 { get; set; }

        public decimal? mto_forma_pago04 { get; set; }

        public decimal? mto_forma_pago05 { get; set; }

        public decimal? mto_forma_pago06 { get; set; }

        public decimal? mto_forma_pago07 { get; set; }

        public decimal? mto_forma_pago08 { get; set; }

        public decimal? mto_forma_pago09 { get; set; }

        public decimal? mto_forma_pago10 { get; set; }

        public int? id_usuario { get; set; }

        [StringLength(50)]
        public string txt_usuario { get; set; }

        public int id_estado { get; set; }

        [Required]
        [StringLength(20)]
        public string txt_estado { get; set; }
    }
}
