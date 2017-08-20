namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt07_tipo_intangible
    {
        [Key]
        public int id_tipo_intangible { get; set; }

        [StringLength(10)]
        public string cod_tipo_intangible { get; set; }

        [StringLength(10)]
        public string cod_tipo_intangible_ple { get; set; }

        [StringLength(250)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }
    }
}
