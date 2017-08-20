namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROt13_combo_dtl
    {
        [Key]
        public long id_combo_dtl { get; set; }

        [StringLength(10)]
        public string cod_combo_dtl { get; set; }

        public decimal? mto_pvpu_sin_igv { get; set; }

        public decimal? mto_pvpu_con_igv { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public long? id_combo { get; set; }

        public long? id_producto { get; set; }

        public virtual PROt09_producto PROt09_producto { get; set; }

        public virtual PROt12_combo PROt12_combo { get; set; }
    }
}
