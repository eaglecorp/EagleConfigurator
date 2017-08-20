namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLIt17_tratamiento
    {
        [Key]
        public long id_tratamiento { get; set; }

        [StringLength(10)]
        public string cod_tratamiento { get; set; }

        [StringLength(5000)]
        public string txt_desc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fec_negocio { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fec_registro { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public long id_atencion { get; set; }

        public virtual CLIt03_atencion CLIt03_atencion { get; set; }
    }
}
