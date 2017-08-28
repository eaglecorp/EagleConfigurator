namespace ConfigBusinessEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GRLt02_estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_estado { get; set; }

        [StringLength(10)]
        public string cod_estado { get; set; }

        [StringLength(20)]
        public string txt_abrv { get; set; }

        [Required]
        [StringLength(250)]
        public string txt_desc { get; set; }
    }
}
