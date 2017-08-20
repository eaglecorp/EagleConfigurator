namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt02_comp_recibido_dtl
    {
        [Key]
        public long id_comp_recibido_dtl { get; set; }

        public long? id_comp_recibido { get; set; }

        public long id_producto { get; set; }

        [StringLength(350)]
        public string txt_producto { get; set; }

        public int id_um { get; set; }

        public decimal qt_comp { get; set; }

        public decimal? punit_sin_igv { get; set; }

        public decimal? punit_con_igv { get; set; }

        public decimal? por_dscto { get; set; }

        public decimal? punit_dscto_sin_igv { get; set; }

        public decimal? punit_dscto_con_igv { get; set; }

        public decimal? mto_comp_sin_igv { get; set; }

        public decimal? mto_comp_con_igv { get; set; }

        public virtual PROt09_producto PROt09_producto { get; set; }

        public virtual SNTt06_unidad_medida SNTt06_unidad_medida { get; set; }

        public virtual TNSt01_comp_recibido TNSt01_comp_recibido { get; set; }
    }
}
