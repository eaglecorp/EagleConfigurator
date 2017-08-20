namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FISt01_control_numeracion
    {
        [Key]
        public long id_control_numeracion { get; set; }

        public int? id_caja { get; set; }

        public int? id_can_vta { get; set; }

        public int id_nivel { get; set; }

        public int id_tipo_numeracion { get; set; }

        public int id_tipo_comp { get; set; }

        [StringLength(20)]
        public string txt_nro_serie { get; set; }

        public long? nro_inicial { get; set; }

        public long? nro_final { get; set; }

        public long? nro_actual { get; set; }

        [StringLength(100)]
        public string txt_serie_impresora { get; set; }

        [StringLength(200)]
        public string txt_info01 { get; set; }

        [StringLength(200)]
        public string txt_info02 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha01 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha02 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha_registro { get; set; }

        public int? locked_by { get; set; }

        public int id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        public virtual FISt02_nivel FISt02_nivel { get; set; }

        public virtual FISt03_tipo_numeracion FISt03_tipo_numeracion { get; set; }

        public virtual MSTt04_canal_vta MSTt04_canal_vta { get; set; }

        public virtual MSTt12_caja MSTt12_caja { get; set; }

        public virtual SNTt10_tipo_comprobante SNTt10_tipo_comprobante { get; set; }
    }
}
