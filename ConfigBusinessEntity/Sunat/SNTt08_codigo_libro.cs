namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SNTt08_codigo_libro
    {
        [Key]
        public int id_libro { get; set; }

        [StringLength(10)]
        public string cod_libro { get; set; }

        [StringLength(10)]
        public string cod_libro_ple { get; set; }

        [StringLength(250)]
        public string txt_desc { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }
    }
}
