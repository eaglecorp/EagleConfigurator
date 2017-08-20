namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt06_comp_emitido_estado
    {
        [Key]
        public long id_comp_emitido_estado { get; set; }

        public long? id_comp_emitido { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [StringLength(50)]
        public string txt_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha_modificacion { get; set; }

        public virtual TNSt04_comp_emitido TNSt04_comp_emitido { get; set; }
    }
}
