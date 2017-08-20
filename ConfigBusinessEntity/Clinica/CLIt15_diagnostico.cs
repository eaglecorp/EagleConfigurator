namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt15_diagnostico
    {
        [Key]
        public long id_diagnostico { get; set; }

        [StringLength(10)]
        public string cod_diagnostico { get; set; }

        [StringLength(5000)]
        public string txt_desc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fec_negocio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_registro { get; set; }

        [StringLength(50)]
        public string cod4_cie10 { get; set; }

        [StringLength(2000)]
        public string txt_cie10 { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public int id_cie10 { get; set; }

        public long? id_atencion { get; set; }

        public virtual CLIt03_atencion CLIt03_atencion { get; set; }

        public virtual CLIt16_cie10 CLIt16_cie10 { get; set; }
    }
}
