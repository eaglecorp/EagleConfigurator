namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt05_comp_emitido_dtl
    {
        [Key]
        public long id_comp_emitido_dtl { get; set; }

        public long? id_comp_emitido { get; set; }

        public long? id_producto { get; set; }

        [StringLength(1000)]
        public string txt_producto { get; set; }

        public int id_um { get; set; }

        public decimal qt_venta { get; set; }

        public decimal? peso { get; set; }

        public decimal punit_sin_igv { get; set; }

        public decimal punit_con_igv { get; set; }

        public decimal por_dscto { get; set; }

        public decimal punit_dscto_sin_igv { get; set; }

        public decimal punit_dscto_con_igv { get; set; }

        public decimal? mto_vta_sin_igv { get; set; }

        public decimal? mto_vta_con_igv { get; set; }

        public int? id_razon { get; set; }

        [StringLength(600)]
        public string txt_observ { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public virtual MSTt05_razon MSTt05_razon { get; set; }

        public virtual PROt09_producto PROt09_producto { get; set; }

        public virtual SNTt06_unidad_medida SNTt06_unidad_medida { get; set; }

        public virtual TNSt04_comp_emitido TNSt04_comp_emitido { get; set; }
    }
}
