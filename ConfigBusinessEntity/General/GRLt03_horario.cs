namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GRLt03_horario
    {
        [Key]
        public int id_horario { get; set; }

        [StringLength(10)]
        public string cod_horario { get; set; }

        [StringLength(12)]
        public string hora { get; set; }
    }
}
