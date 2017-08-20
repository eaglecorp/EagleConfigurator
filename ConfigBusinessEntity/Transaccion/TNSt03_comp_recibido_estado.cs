namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TNSt03_comp_recibido_estado
    {
        [Key]
        public long id_comp_recibido_estado { get; set; }

        public long? id_comp_recibido { get; set; }

        public int? id_estado { get; set; }

        [StringLength(20)]
        public string txt_estado { get; set; }

        [StringLength(50)]
        public string txt_usuario { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? fecha_modificacion { get; set; }

        public virtual TNSt01_comp_recibido TNSt01_comp_recibido { get; set; }
    }
}
