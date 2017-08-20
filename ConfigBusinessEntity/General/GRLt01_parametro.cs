namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GRLt01_parametro
    {
        [Key]
        public int id_parametro { get; set; }

        [StringLength(10)]
        public string cod_parametro { get; set; }

        [StringLength(50)]
        public string txt_desc { get; set; }

        public decimal? dec_valor { get; set; }

        [StringLength(500)]
        public string txt_valor { get; set; }

        [StringLength(350)]
        public string txt_obs { get; set; }

        public int sn_edit { get; set; }
    }
}
