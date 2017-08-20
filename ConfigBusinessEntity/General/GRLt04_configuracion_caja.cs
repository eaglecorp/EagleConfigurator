namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GRLt04_configuracion_caja
    {
        [Key]
        public int id_config { get; set; }

        public int id_caja { get; set; }

        [StringLength(250)]
        public string txt_pathlog { get; set; }

        public virtual MSTt12_caja MSTt12_caja { get; set; }
    }
}
